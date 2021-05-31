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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IReader reader = new TextFileReader();
            IWriter writer = new TextFileWriter();
            FOnlineDataManager dataManager = new FOnlineDataManager(reader, writer, "FOnline.cfg");

            IConfigManager configManager = new FOnlineConfigManager(dataManager);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FOConfigForm(configManager));
        }
    }
}
