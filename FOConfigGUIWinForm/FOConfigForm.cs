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

        private IConfigManager _config;

        private CombatMode _combatMode;
        private IndicatorType _indicatorType;
        private CombatMessageType _combatMessageType;
        private ProxyType _proxyType;

        public FOConfigForm(IConfigManager configManager)
        {
            InitializeComponent();
            SetComboboxDefaultValues();

            _config = configManager;
            GetValuesFromConfigData();
        }

        private void SetComboboxDefaultValues()
        {
            comboBoxLanguage.SelectedIndex = 0;
            comboBoxMultiSampling.SelectedIndex = 0;
            comboBoxRemoteHost.SelectedIndex = 0;
            comboBoxScreenHeight.SelectedIndex = 0;
        }

        private void GetValuesFromConfigData()
        {
            GetOther();
            GetGame();
            GetCombat();
            GetNet();
            GetVideo();
            GetSound();
        }

        private void GetOther()
        {
            comboBoxLanguage.SelectedValue = GetString("Language");
            checkBoxWinNotify.Checked = GetBool("WinNotify");
            checkBoxSoundNotify.Checked = GetBool("SoundNotify");
            checkBoxInvertMessBox.Checked = GetBool("InvertMessBox");
            checkBoxLogging.Checked = GetBool("Logging");
            checkBoxLoggingTime.Checked = GetBool("LoggingTime");
            numericUpDownFixedFPS.Value = GetClampedDecimal("FixedFPS", numericUpDownFixedFPS);
        }

        private void GetGame()
        {
            numericUpDownScrollDelay.Value = GetClampedDecimal("ScrollDelay", numericUpDownScrollDelay);
            numericUpDownScrollStep.Value = GetClampedDecimal("ScrollStep", numericUpDownScrollStep);
            numericUpDownTextDelay.Value = GetClampedDecimal("TextDelay", numericUpDownTextDelay);
            checkBoxAlwaysRun.Checked = GetBool("AlwaysRun");
        }

        private void GetCombat()
        {
            GetCombatModeRadiobutton();
            GetIndicatorTypeRadiobutton();
            GetCombatMessageTypeRadiobutton();
            numericUpDownDamageHitDelay.Value = GetClampedDecimal("DamageHitDelay", numericUpDownDamageHitDelay);
        }

        private void GetNet()
        {
            comboBoxRemoteHost.SelectedValue = GetString("RemoteHost");
            numericUpDownRemotePort.Value = GetClampedDecimal("RemotePort", numericUpDownRemotePort);
            GetProxyTypeRadioButton();
            comboBoxProxyHost.SelectedValue = GetString("ProxyHost");
            numericUpDownProxyPort.Value = GetClampedDecimal("ProxyPort", numericUpDownProxyPort);
            textBoxProxyUser.Text = GetString("ProxyUser");
            textBoxProxyPass.Text = GetString("ProxyPass");
        }

        private void GetVideo()
        {
            comboBoxScreenWidth.SelectedValue = GetInt("ScreenWidth");
            comboBoxScreenHeight.SelectedValue = GetInt("ScreenHeight");
            numericUpDownLight.Value = GetClampedDecimal("Light", numericUpDownLight);
            numericUpDownFlushValue.Value = GetClampedDecimal("FlushValue", numericUpDownFlushValue);
            numericUpDownBaseTexture.Value = GetClampedDecimal("BaseTexture", numericUpDownBaseTexture);
            checkBoxFullScreen.Checked = GetBool("FullScreen");
            checkBoxVSync.Checked = GetBool("VSync");
            checkBoxAlwaysOnTop.Checked = GetBool("AlwaysOnTop");
            numericUpDownAnimation3dSmoothTime.Value = GetClampedDecimal("Animation3dSmoothTime", numericUpDownAnimation3dSmoothTime);
            numericUpDownAnimation3dFPS.Value = GetClampedDecimal("Animation3dFPS", numericUpDownAnimation3dFPS);
            comboBoxMultiSampling.SelectedValue = GetInt("MultiSampling");
        }

        private void GetSound()
        {
            trackBarMusicVolume.Value = GetClampedInt("MusicVolume", trackBarMusicVolume);
            trackBarSoundVolume.Value = GetClampedInt("SoundVolume", trackBarSoundVolume);
        }

        private void GetCombatModeRadiobutton()
        {
            _combatMode = (CombatMode)GetInt("DefaultCombatMode");
            radioButtonCombatBoth.Checked = _combatMode == CombatMode.BOTH;
            radioButtonCombatRealTime.Checked = _combatMode == CombatMode.REAL_TIME;
            radioButtonCombatTurnBased.Checked = _combatMode == CombatMode.TURN_BASED;
        }

        private void GetIndicatorTypeRadiobutton()
        {
            _indicatorType = (IndicatorType)GetInt("IndicatorType");
            radioButtonIndicatorLines.Checked = _indicatorType == IndicatorType.LINES;
            radioButtonIndicatorNumbers.Checked = _indicatorType == IndicatorType.NUMBERS;
            radioButtonIndicatorBoth.Checked = _indicatorType == IndicatorType.LINES_AND_NUMBERS;
        }

        private void GetCombatMessageTypeRadiobutton()
        {
            _combatMessageType = (CombatMessageType)GetInt("CombatMessagesType");
            radioButtonMessagesBrief.Checked = _combatMessageType == CombatMessageType.BRIEF;
            radioButtonMessagesVerbose.Checked = _combatMessageType == CombatMessageType.VERBOSE;
        }

        private void GetProxyTypeRadioButton()
        {
            _proxyType = (ProxyType)GetInt("ProxyType");
            radioButtonProxyTypeNone.Checked = _proxyType == ProxyType.NONE;
            radioButtonProxyTypeSocks4.Checked = _proxyType == ProxyType.SOCKS4;
            radioButtonProxyTypeSocks5.Checked = _proxyType == ProxyType.SOCKS5;
            radioButtonProxyTypeHttp.Checked = _proxyType == ProxyType.HTTP;
        }

        private bool GetBool(string key) => _config.GetValue<bool>(key);
        private string GetString(string key) => _config.GetValue<string>(key);
        private int GetInt(string key) => _config.GetValue<int>(key);

        private int GetClampedInt(string key, TrackBar trackBar)
        {
            return GetClampedInt(GetInt(key), trackBar.Minimum, trackBar.Maximum);
        }

        private int GetClampedInt(int value, int minimum, int maximum)
        {
            if (value < minimum)
                value = minimum;
            else if (value > maximum)
                value = maximum;

            return value;
        }

        private decimal GetClampedDecimal(string key, NumericUpDown numericUpDown)
        {
            return (decimal)GetClampedInt(GetInt(key), (int)numericUpDown.Minimum, (int)numericUpDown.Maximum);
        }

        private void SetValue(string key, string value) => _config.SetValue<string>(key, value);
        private void SetValue(string key, bool value) => _config.SetValue<bool>(key, value);
        private void SetValue(string key, decimal value) => _config.SetValue<int>(key, (int)value);

        private void buttonSave_Click(object sender, EventArgs e) => SetValuesToConfigData();

        private void SetValuesToConfigData()
        {
            SetOther();
            SetGame();
            SetCombat();
            SetNet();
            SetVideo();
            SetSound();

            _config.Save();
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
            SetValue("DefaultCombatMode", (int)_combatMode);
            SetValue("IndicatorType", (int)_indicatorType);
            SetValue("CombatMessagesType", (int)_combatMessageType);
            SetValue("DamageHitDelay", numericUpDownDamageHitDelay.Value);
        }

        private void SetNet()
        {
            SetValue("RemoteHost", comboBoxRemoteHost.Text);
            SetValue("RemotePort", numericUpDownRemotePort.Value);
            SetValue("ProxyType", (int)_proxyType);
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
            if (File.Exists(FONLINE_APP_NAME))
            {
                SetValuesToConfigData();
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
            // TO DO: change languages
        }
    }
}