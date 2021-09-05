using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;
using FOConfig;

namespace FOConfigGUIWinForm
{
    static class Program
    {
        private const string CONFIG_NAME = "FOnline.cfg";
        private const string LOCALIZATION_CONFIG_NAME = "Localization.cfg";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IDataManager dataManager = new FOnlineDataManager(new TextFileReader(), new TextFileWriter(), CONFIG_NAME);
            IConfigManager config = new FOnlineConfigManager(dataManager, "[Game Options]");

            IDataManager localizationData = new FOnlineDataManager(new TextFileReader(), new TextFileWriter(), LOCALIZATION_CONFIG_NAME);
            IConfigManager localizationConfig = new FOnlineConfigManager(localizationData, "[engl]");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FOConfigForm(config, localizationConfig));
        }
    }
}
