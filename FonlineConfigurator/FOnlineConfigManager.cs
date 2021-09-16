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
        private const string DEFAULT_CONFIG_NAME = "DefaultValues.xml";

        public FOnlineConfigManager(IDataManager dataManager, string defaultConfigHeader) : base(dataManager, defaultConfigHeader) 
        {
            SwitchToConfigSection(defaultConfigHeader);
            Save();
        }

        protected override Dictionary<string, string> GetConfigByDefault()
        {
            IDataManager defConfigDataManager = new FOnlineDataManager(new XMLFileReader(), null, DEFAULT_CONFIG_NAME);
            return defConfigDataManager.GetConfigSection(defaultConfigHeader);
        }
    }
}
