using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;
using FoConfig;

namespace FOConfigGUIWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            DataManager dataManager = new DataManager(reader, writer, "FOnline.cfg");
            IDefaultConfigData defaultConfigData = new FonlineConfigData();

            IConfigManager configManager = new ConfigManager(defaultConfigData, dataManager);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FOConfigForm(configManager));
        }
    }
}
