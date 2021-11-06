using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configurator;
using FOConfig;

namespace FOConfigGUIWinForm
{
    public partial class FOConfigForm : Form
    {
        private const string FONLINE_APP_NAME = "FOnline.exe";

        private IConfigManager config;
        private ILocalizationManager localization;

        private CombatMode combatMode;
        private IndicatorType indicatorType;
        private CombatMessageType combatMessageType;
        private ProxyType proxyType;

        public FOConfigForm(IConfigManager config)
        {
            this.config = config;

            InitializeComponent();

            UpdateOtherValuesPage();
            UpdateGameValuesPage();
            UpdateCombatValuesPage();
            UpdateNetValuesPage();
            UpdateVideoValuesPage();
            UpdateSoundValuesPage();
        }

        public void SetLocalizationConfig(ILocalizationManager localization)
        {
            this.localization = localization;
            comboBoxLanguage.Items.AddRange(localization.GetLanguageHeaders());
            UpdateCombobox("Language", comboBoxLanguage);
            localization.SetLanguage(comboBoxLanguage.Items[comboBoxLanguage.SelectedIndex].ToString());
        }

        private void UpdateOtherValuesPage()
        {
            UpdateCheckBox("WinNotify", checkBoxWinNotify);
            UpdateCheckBox("SoundNotify", checkBoxSoundNotify);
            UpdateCheckBox("InvertMessBox", checkBoxInvertMessBox);
            UpdateCheckBox("Logging", checkBoxLogging);
            UpdateCheckBox("LoggingTime", checkBoxLoggingTime);
            UpdateNumericUpDown("FixedFPS", numericUpDownFixedFPS);
        }

        private void UpdateGameValuesPage()
        {
            UpdateNumericUpDown("ScrollDelay", numericUpDownScrollDelay);
            UpdateNumericUpDown("ScrollStep", numericUpDownScrollStep);
            UpdateNumericUpDown("TextDelay", numericUpDownTextDelay);
            UpdateCheckBox("AlwaysRun", checkBoxAlwaysRun);
        }

        private void UpdateCombatValuesPage()
        {
            UpdateCombatModeValue();
            UpdateIndicatorTypeValue();
            UpdateCombatMessageTypeValue();
            UpdateNumericUpDown("DamageHitDelay", numericUpDownDamageHitDelay);
        }

        private void UpdateNetValuesPage()
        {
            UpdateCombobox("RemoteHost", comboBoxRemoteHost);
            UpdateNumericUpDown("RemotePort", numericUpDownRemotePort);
            UpdateProxyTypeValue();
            UpdateCombobox("ProxyHost", comboBoxProxyHost);
            UpdateNumericUpDown("ProxyPort", numericUpDownProxyPort);
            UpdateTextBox("ProxyUser", textBoxProxyUser);
            UpdateTextBox("ProxyPass", textBoxProxyPass);
        }

        private void UpdateVideoValuesPage()
        {
            UpdateCombobox("ScreenWidth", comboBoxScreenWidth);
            UpdateCombobox("ScreenHeight", comboBoxScreenHeight);
            UpdateNumericUpDown("Light", numericUpDownLight);
            UpdateNumericUpDown("FlushValue", numericUpDownFlushValue);
            UpdateNumericUpDown("BaseTexture", numericUpDownBaseTexture);
            UpdateCheckBox("FullScreen", checkBoxFullScreen);
            UpdateCheckBox("VSync", checkBoxVSync);
            UpdateCheckBox("AlwaysOnTop", checkBoxAlwaysOnTop);
            UpdateNumericUpDown("Animation3dSmoothTime", numericUpDownAnimation3dSmoothTime);
            UpdateNumericUpDown("Animation3dFPS", numericUpDownAnimation3dFPS);
            UpdateCombobox("MultiSampling", comboBoxMultiSampling);
        }

        private void UpdateSoundValuesPage()
        {
            UpdateTrackBar("MusicVolume", trackBarMusicVolume);
            UpdateTrackBar("SoundVolume", trackBarSoundVolume);
        }

        private void UpdateCombatModeValue()
        {
            if (config.GetValue<int>("DefaultCombatMode", out int value))
            {
                combatMode = (CombatMode)value;
                radioButtonCombatBoth.Checked = combatMode == CombatMode.BOTH;
                radioButtonCombatRealTime.Checked = combatMode == CombatMode.REAL_TIME;
                radioButtonCombatTurnBased.Checked = combatMode == CombatMode.TURN_BASED;
            }
            else if (radioButtonCombatBoth.Checked)
                combatMode = CombatMode.BOTH;
            else if (radioButtonCombatRealTime.Checked)
                combatMode = CombatMode.REAL_TIME;
            else
                combatMode = CombatMode.TURN_BASED;

            SetValue("DefaultCombatMode", (int)combatMode);
        }

        private void UpdateIndicatorTypeValue()
        {
            if (config.GetValue<int>("IndicatorType", out int value))
            {
                indicatorType = (IndicatorType)value;
                radioButtonIndicatorLines.Checked = indicatorType == IndicatorType.LINES;
                radioButtonIndicatorNumbers.Checked = indicatorType == IndicatorType.NUMBERS;
                radioButtonIndicatorBoth.Checked = indicatorType == IndicatorType.LINES_AND_NUMBERS;
            }
            else if (radioButtonIndicatorLines.Checked)
                indicatorType = IndicatorType.LINES;
            else if (radioButtonIndicatorNumbers.Checked)
                indicatorType = IndicatorType.NUMBERS;
            else
                indicatorType = IndicatorType.LINES_AND_NUMBERS;

            SetValue("IndicatorType", (int)combatMessageType);
        }

        private void UpdateCombatMessageTypeValue()
        {
            if (config.GetValue<int>("CombatMessagesType", out int value))
            {
                combatMessageType = (CombatMessageType)value;
                radioButtonMessagesBrief.Checked = combatMessageType == CombatMessageType.BRIEF;
                radioButtonMessagesVerbose.Checked = combatMessageType == CombatMessageType.VERBOSE;
            }
            else if (radioButtonMessagesBrief.Checked)
                combatMessageType = CombatMessageType.BRIEF;
            else
                combatMessageType = CombatMessageType.VERBOSE;

            SetValue("CombatMessagesType", (int)combatMessageType);
        }

        private void UpdateProxyTypeValue()
        {
            if (config.GetValue<int>("ProxyType", out int value))
            {
                proxyType = (ProxyType)value;
                radioButtonProxyTypeNone.Checked = proxyType == ProxyType.NONE;
                radioButtonProxyTypeSocks4.Checked = proxyType == ProxyType.SOCKS4;
                radioButtonProxyTypeSocks5.Checked = proxyType == ProxyType.SOCKS5;
                radioButtonProxyTypeHttp.Checked = proxyType == ProxyType.HTTP;
            }
            else if (radioButtonProxyTypeNone.Checked)
                proxyType = ProxyType.NONE;
            else if(radioButtonProxyTypeSocks4.Checked)
                proxyType = ProxyType.SOCKS4;
            else if(radioButtonProxyTypeSocks5.Checked)
                proxyType = ProxyType.SOCKS5;
            else
                proxyType = ProxyType.HTTP;
        }

        private void UpdateCombobox(string key, ComboBox comboBox)
        {
            if(comboBox.Items.Count>0)
                comboBox.SelectedIndex = 0;

            if (config.GetValue<string>(key, out string value))
                comboBox.SelectedIndex = comboBox.FindString(value);
            else
                SetValue(key, (string)comboBox.SelectedValue);
        }

        private void UpdateCheckBox(string key, CheckBox checkBox)
        {
            if (config.GetValue<bool>(key, out bool value))
                checkBox.Checked = value;
            else
                SetValue(key, checkBox.Checked);
        }

        private void UpdateNumericUpDown(string key, NumericUpDown numericUpDown)
        {
            if (config.GetValue<int>(key, out int value))
                numericUpDown.Value = value;
            else
                SetValue(key, numericUpDown.Value);
        }

        private void UpdateTrackBar(string key, TrackBar trackBar)
        {
            if (config.GetValue<int>(key, out int value))
                trackBar.Value = value;
            else
                SetValue(key, trackBar.Value);
        }

        private void UpdateTextBox(string key, TextBox textBox)
        {
            if (config.GetValue<string>(key, out string value))
                textBox.Text = value;
            else
                SetValue(key, textBox.Text);
        }

        private void SetValue(string key, string value) => config.SetValue<string>(key, value);
        private void SetValue(string key, bool value) => config.SetValue<bool>(key, value);
        private void SetValue(string key, decimal value) => config.SetValue<int>(key, (int)value);

        private void buttonSave_Click(object sender, EventArgs e) => SetValuesToConfigData();

        private void SetValuesToConfigData()
        {
            SetOther();
            SetGame();
            SetCombat();
            SetNet();
            SetVideo();
            SetSound();

            config.Save();
        }

        private void SetOther()
        {
            SetValue("Language", comboBoxLanguage.Text);
            SetValue("WinNotify", checkBoxWinNotify.Checked);
            SetValue("SoundNotify", checkBoxSoundNotify.Checked);
            SetValue("InvertMessBox", checkBoxInvertMessBox.Checked);
            SetValue("Logging", checkBoxLogging.Checked);
            SetValue("LoggingTime", checkBoxLogging.Checked);
            SetValue("FixedFPS", numericUpDownFixedFPS.Value);
        }

        private void SetGame()
        {
            SetValue("ScrollDelay", numericUpDownScrollDelay.Value);
            SetValue("ScrollStep", numericUpDownScrollStep.Value);
            SetValue("TextDelay", numericUpDownTextDelay.Value);
            SetValue("AlwaysRun", checkBoxAlwaysRun.Checked);
        }

        private void SetCombat()
        {
            SetValue("DefaultCombatMode", (int)combatMode);
            SetValue("IndicatorType", (int)indicatorType);
            SetValue("CombatMessagesType", (int)combatMessageType);
            SetValue("DamageHitDelay", numericUpDownDamageHitDelay.Value);
        }

        private void SetNet()
        {
            SetValue("RemoteHost", comboBoxRemoteHost.Text);
            SetValue("RemotePort", numericUpDownRemotePort.Value);
            SetValue("ProxyType", (int)proxyType);
            SetValue("ProxyHost", comboBoxProxyHost.Text);
            SetValue("ProxyPort", numericUpDownProxyPort.Value);
            SetValue("ProxyUser", textBoxProxyUser.Text);
            SetValue("ProxyPass", textBoxProxyPass.Text);
        }

        private void SetVideo()
        {
            SetValue("ScreenWidth", comboBoxScreenWidth.Text);
            SetValue("ScreenHeight", comboBoxScreenHeight.Text);
            SetValue("Light", numericUpDownLight.Value);
            SetValue("FlushValue", numericUpDownFlushValue.Value);
            SetValue("BaseTexture", numericUpDownBaseTexture.Value);
            SetValue("FullScreen", checkBoxFullScreen.Checked);
            SetValue("VSync", checkBoxVSync.Checked);
            SetValue("AlwaysOnTop", checkBoxAlwaysOnTop.Checked);
            SetValue("Animation3dSmoothTime", numericUpDownAnimation3dSmoothTime.Value);
            SetValue("Animation3dFPS", numericUpDownAnimation3dFPS.Value);
            SetValue("MultiSampling", comboBoxMultiSampling.Text);
        }

        private void SetSound()
        {
            SetValue("MusicVolume", trackBarMusicVolume.Value);
            SetValue("SoundVolume", trackBarSoundVolume.Value);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SetValuesToConfigData();
            if (File.Exists(FONLINE_APP_NAME))
            {
                Process gameProcess = Process.Start(FONLINE_APP_NAME);
                Application.Exit();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) => Application.Exit();

        private void comboBoxScreenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxScreenHeight.SelectedIndex = comboBoxScreenWidth.SelectedIndex;
        }

        private void comboBoxScreenHeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxScreenWidth.SelectedIndex = comboBoxScreenHeight.SelectedIndex;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            localization.SetLanguage(comboBoxLanguage.Items[comboBoxLanguage.SelectedIndex].ToString());
        }
    }
}