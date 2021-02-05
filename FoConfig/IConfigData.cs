using System.Collections.Generic;

namespace Configurator
{
    public interface IConfigData
    {
        Dictionary<string, string> StringVelues { get; set; }
        Dictionary<string, bool> BoolVelues { get; set; }
        Dictionary<string, ushort> UshortVelues { get; set; }
    }
}