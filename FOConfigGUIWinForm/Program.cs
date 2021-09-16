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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDataManager configData = new FOnlineDataManager(new TextFileReader(), new TextFileWriter(), CONFIG_NAME);
            IConfigManager config = new FOnlineConfigManager(configData, "[Game Options]");

            FOConfigForm form = new FOConfigForm(config);

            IDataManager localizationData = new FOnlineDataManager(new TextFileReader(), new TextFileWriter(), LOCALIZATION_CONFIG_NAME);
            IConfigManager localization = new Localization(localizationData, "[engl]", form);

            Application.Run(form);
        }
    }
}
