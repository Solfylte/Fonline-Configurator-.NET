using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator;

namespace FoConfig
{
    public class FonlineConfigData: IDefaultConfigData
    {
        public string Header => _header;
        public Dictionary<string, string> StringValues { get => _stringValues; }
        public Dictionary<string, bool> BoolValues { get => _boolValues; }
        public Dictionary<string, int> IntValues { get => _intValues; }

        private Dictionary<string, string> _stringValues = new Dictionary<string, string>();
        private Dictionary<string, bool> _boolValues = new Dictionary<string, bool>();
        private Dictionary<string, int> _intValues = new Dictionary<string, int>();

        private string _header;

        private string Language = "engl";
        private bool WinNotify = true;
        private bool SoundNotify= false;
        private bool InvertMessBox = false;
        private bool Logging= true;
        private bool LoggingTime = false;
        private ushort FixedFPS = 100;
        private ushort ScrollDelay = 30;
        private ushort ScrollStep = 30;
        private ushort TextDelay = 3000;
        private bool AlwaysRun= true;
        private string RemoteHost = "localhost";
        private ushort RemotePort = 4000;
        private ushort ProxyType = 0;
        private string ProxyHost = "";
        private ushort ProxyPort = 0;
        private string ProxyUser = "";
        private string ProxyPass = "";
        private ushort ScreenWidth = 1920;
        private ushort ScreenHeight = 1080;
        private ushort Light = 20;
        private ushort FlushValue = 250;
        private ushort BaseTexture = 512;
        private ushort DoubleClickTime = 1;
        private bool FullScreen = true;
        private bool VSync = false;
        private bool AlwaysOnTop= false;
        private ushort Animation3dSmoothTime = 0;
        private ushort Animation3dFPS = 0;
        private ushort MusicVolume = 73;
        private ushort SoundVolume = 77;
        private ushort DefaultCombatMode = 0;
        private ushort IndicatorType = 2;
        private ushort CombatMessagesType = 1;
        private ushort DamageHitDelay = 1000;
        private ushort MultiSampling = 0;
        private string FonlineDataPath = ".\\data";
        private string WindowName = "FOnline";

        public FonlineConfigData()
        {
            _header = "[Game Options]";

            FillStringValues();
            FillBoolValues();
            FillUShortValues();
        }

        private void FillStringValues()
        {
            _stringValues.Add("Language", Language);
            _stringValues.Add("RemoteHost", RemoteHost);
            _stringValues.Add("ProxyHost", ProxyHost);
            _stringValues.Add("ProxyUser", ProxyUser);
            _stringValues.Add("ProxyPass", ProxyPass);
            _stringValues.Add("FonlineDataPath", FonlineDataPath);
            _stringValues.Add("WindowName", WindowName);
        }

        private void FillBoolValues()
        {
            _boolValues.Add("WinNotify", WinNotify);
            _boolValues.Add("SoundNotify", SoundNotify);
            _boolValues.Add("InvertMessBox", InvertMessBox);
            _boolValues.Add("Logging", Logging);
            _boolValues.Add("LoggingTime", LoggingTime);
            _boolValues.Add("AlwaysRun", AlwaysRun);
            _boolValues.Add("FullScreen", FullScreen);
            _boolValues.Add("VSync", VSync);
            _boolValues.Add("AlwaysOnTop", AlwaysOnTop);
        }

        private void FillUShortValues()
        {
            _intValues.Add("FixedFPS", FixedFPS);
            _intValues.Add("ScrollDelay", ScrollDelay);
            _intValues.Add("ScrollStep", ScrollStep);
            _intValues.Add("TextDelay", TextDelay);
            _intValues.Add("RemotePort", RemotePort);
            _intValues.Add("ProxyType", ProxyType);
            _intValues.Add("ProxyPort", ProxyPort);
            _intValues.Add("ScreenWidth", ScreenWidth);
            _intValues.Add("ScreenHeight", ScreenHeight);
            _intValues.Add("Light", Light);
            _intValues.Add("FlushValue", FlushValue);
            _intValues.Add("BaseTexture", BaseTexture);
            _intValues.Add("DoubleClickTime", DoubleClickTime);
            _intValues.Add("Animation3dSmoothTime", Animation3dSmoothTime);
            _intValues.Add("Animation3dFPS", Animation3dFPS);
            _intValues.Add("MusicVolume", MusicVolume);
            _intValues.Add("SoundVolume", SoundVolume);
            _intValues.Add("DefaultCombatMode", DefaultCombatMode);
            _intValues.Add("IndicatorType", IndicatorType);
            _intValues.Add("CombatMessagesType", CombatMessagesType);
            _intValues.Add("DamageHitDelay", DamageHitDelay);
            _intValues.Add("MultiSampling", MultiSampling);
        }
    }
}