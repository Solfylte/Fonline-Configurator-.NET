using System.Collections.Generic;

namespace Configurator
{
    public interface IDefaultConfigData
    {
        Dictionary<string, string> StringValues { get; set; }
        Dictionary<string, bool> BoolValues { get; set; }
        Dictionary<string, ushort> UshortValues { get; set; }
        string Header { get; }
    }
}