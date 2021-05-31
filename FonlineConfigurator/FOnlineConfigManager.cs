using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator;

namespace FOConfig
{
    public class FOnlineConfigManager : BaseConfigManager
    {
        public FOnlineConfigManager(IDataManager dataManager) : base(dataManager)
        {

        }

        protected override Dictionary<string, string> GetConfigByDefault()
        {
            return new Dictionary<string, string>();
        }

        protected override string GetHeader()
        {
            return "[Game Options]";
        }
    }
}
