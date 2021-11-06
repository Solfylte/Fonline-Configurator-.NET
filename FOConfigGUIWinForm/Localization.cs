using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;

namespace FOConfigGUIWinForm
{
    class Localization : BaseConfigManager, ILocalizationManager
    {
        private Control[] controls;
        Dictionary<string, string> defaultLocalization = new Dictionary<string, string>();

        public Localization(IDataManager dataManager, string defaultConfigHeader, FOConfigForm form) : base(dataManager, defaultConfigHeader)
        {
            controls = GetControls(form).ToArray();
            defaultLocalization = GetDefaultLocalization();
        }

        private IEnumerable<Control> GetControls(Control control)
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

        public string[] GetLanguageHeaders()
        {
            string[] headers = dataManager.GetHeaders();
            for (int i = 0; i < headers.Length; i++)
                headers[i] = headers[i].Replace("[", "").Replace("]","");

            return headers;
        }

        public void SetLanguage(string header)
        {
            if (IsDefaultFormLanguage(header))
                SetDefaultLanguage();
            else
            {
                SwitchToConfigSection($"[{header}]");
                SetLanguageFromCurrentSection();
            }    
        }

        private void SetDefaultLanguage()
        {
            for (int i = 0; i < controls.Length; i++)
                if (defaultLocalization.ContainsKey(controls[i].Name))
                    controls[i].Text = defaultLocalization[controls[i].Name];
        }

        private void SetLanguageFromCurrentSection()
        {
            for (int i = 0; i < controls.Length; i++)
                if (GetValue<string>(controls[i].Name, out string value))
                    controls[i].Text = value;
        }

        private bool IsDefaultFormLanguage(string header) => header == defaultConfigHeader;
    }
}
