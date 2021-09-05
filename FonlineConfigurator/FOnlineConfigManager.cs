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
        private const string DEFAULT_CONFIG_HEADER = "[Game Options]";

        public FOnlineConfigManager(IDataManager dataManager) : base(dataManager) { }

        protected override Dictionary<string, string> GetConfigByDefault()
        {
            IDataManager defConfigDataManager = new FOnlineDataManager(new XMLFileReader(), null, DEFAULT_CONFIG_NAME);
            return defConfigDataManager.GetConfigSection(DEFAULT_CONFIG_HEADER);
        }

        protected override string GetHeader() => DEFAULT_CONFIG_HEADER;
    }
}
