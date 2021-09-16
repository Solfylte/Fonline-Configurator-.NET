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
            SwitchToConfigSection(defaultConfigHeader);
            Save();
        }

        public IEnumerable<Control> GetControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControls(ctrl))
                                      .Concat(controls)
                                      .Where(c => CanBeTranslated(c));
        }

        private bool CanBeTranslated(Control control)
        {
            return control.Text != "" && control.Name != ""
                    && control.GetType() != typeof(NumericUpDown) && control.GetType() != typeof(ComboBox);
        }

        protected override Dictionary<string, string> GetConfigByDefault()
        {          
            Dictionary<string, string> configByDefault = new Dictionary<string, string>();

            for (int i = 0; i < controls.Length; i++)
            {
                if(!configByDefault.ContainsKey(controls[i].Name))
                    configByDefault.Add(controls[i].Name, controls[i].Text);
            }

            return configByDefault;
        }
    }
}
