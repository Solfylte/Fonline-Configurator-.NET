using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;

namespace FOConfigGUIWinForm
{
    class Localization : BaseConfigManager
    {
        private Control[] controls;

        public Localization(IDataManager dataManager, string defaultConfigHeader, FOConfigForm form) : base(dataManager, defaultConfigHeader)
        {
            controls = GetControls(form).ToArray();
        }

        public IEnumerable<Control> GetControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControls(ctrl))
                                      .Concat(controls)
                                      .Where(c => ShouldBeTranslated(c));
        }

        private bool ShouldBeTranslated(Control control)
        {
            return control.Text != "" && control.Name != ""
                    && control.GetType() != typeof(NumericUpDown) && control.GetType() != typeof(ComboBox);
        }

        private Dictionary<string, string> GetDefaultLocalization()
        {          
            Dictionary<string, string> defaultLocalization = new Dictionary<string, string>();

            for (int i = 0; i < controls.Length; i++)
            {
                if(!defaultLocalization.ContainsKey(controls[i].Name))
                    defaultLocalization.Add(controls[i].Name, controls[i].Text);
            }

            return defaultLocalization;
        }
    }
}
