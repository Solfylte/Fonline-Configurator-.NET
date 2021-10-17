using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Configurator;

namespace FOConfig
{
    public class FOnlineConfigManager : BaseConfigManager
    {
        public FOnlineConfigManager(IDataManager dataManager, string defaultConfigHeader) : base(dataManager, defaultConfigHeader) 
        {
            SwitchToConfigSection(defaultConfigHeader);
            Save();
        }
    }
}
