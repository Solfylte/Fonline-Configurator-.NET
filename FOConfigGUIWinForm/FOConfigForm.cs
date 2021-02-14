using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;

namespace FOConfigGUIWinForm
{
    public partial class FOConfigForm : Form
    {
        private IConfigManager _config;

        public FOConfigForm(IConfigManager configManager)
        {
            InitializeComponent();

            _config = configManager;
            ReadConfigData();
        }

        private void ReadConfigData()
        {
            checkBoxWinNotify.Checked = _config.GetBool("WinNotify");
        }

        private void comboBoxScreenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxScreenHeight.SelectedIndex = comboBoxScreenWidth.SelectedIndex;
        }

        private void comboBoxScreenHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxScreenWidth.SelectedIndex = comboBoxScreenHeight.SelectedIndex;
        }
    }
}
