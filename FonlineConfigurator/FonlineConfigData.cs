using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configurator;

namespace FoConfig
{
    public class FonlineConfigData: IConfigData
    {
        public Dictionary<string, string> StringVelues { get => _stringVelues; set => _stringVelues = value; }
        public Dictionary<string, bool> BoolVelues { get => _boolVelues; set => _boolVelues = value; }
        public Dictionary<string, ushort> UshortVelues { get => _ushortVelues; set => _ushortVelues = value; }

        private Dictionary<string, string> _stringVelues = new Dictionary<string, string>();
        private Dictionary<string, bool> _boolVelues = new Dictionary<string, bool>();
        private Dictionary<string, ushort> _ushortVelues = new Dictionary<string, ushort>();

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
            FillStringValues();
            FillBoolValues();
            FillUShortValues();
        }

        private void FillStringValues()
        {
            _stringVelues.Add("Language", Language);
            _stringVelues.Add("RemoteHost", RemoteHost);
            _stringVelues.Add("ProxyHost", ProxyHost);
            _stringVelues.Add("ProxyUser", ProxyUser);
            _stringVelues.Add("ProxyPass", ProxyPass);
            _stringVelues.Add("FonlineDataPath", FonlineDataPath);
            _stringVelues.Add("WindowName", WindowName);
        }

        private void FillBoolValues()
        {
            _boolVelues.Add("WinNotify", WinNotify);
            _boolVelues.Add("SoundNotify", SoundNotify);
            _boolVelues.Add("InvertMessBox", InvertMessBox);
            _boolVelues.Add("Logging", Logging);
            _boolVelues.Add("LoggingTime", LoggingTime);
            _boolVelues.Add("AlwaysRun", AlwaysRun);
            _boolVelues.Add("FullScreen", FullScreen);
            _boolVelues.Add("VSync", VSync);
            _boolVelues.Add("AlwaysOnTop", AlwaysOnTop);
        }

        private void FillUShortValues()
        {
            _ushortVelues.Add("FixedFPS", FixedFPS);
            _ushortVelues.Add("ScrollDelay", ScrollDelay);
            _ushortVelues.Add("ScrollStep", ScrollStep);
            _ushortVelues.Add("TextDelay", TextDelay);
            _ushortVelues.Add("RemotePort", RemotePort);
            _ushortVelues.Add("ProxyType", ProxyType);
            _ushortVelues.Add("ProxyPort", ProxyPort);
            _ushortVelues.Add("ScreenWidth", ScreenWidth);
            _ushortVelues.Add("ScreenHeight", ScreenHeight);
            _ushortVelues.Add("Light", Light);
            _ushortVelues.Add("FlushValue", FlushValue);
            _ushortVelues.Add("BaseTexture", BaseTexture);
            _ushortVelues.Add("DoubleClickTime", DoubleClickTime);
            _ushortVelues.Add("Animation3dSmoothTime", Animation3dSmoothTime);
            _ushortVelues.Add("Animation3dFPS", Animation3dFPS);
            _ushortVelues.Add("MusicVolume", MusicVolume);
            _ushortVelues.Add("SoundVolume", SoundVolume);
            _ushortVelues.Add("DefaultCombatMode", DefaultCombatMode);
            _ushortVelues.Add("IndicatorType", IndicatorType);
            _ushortVelues.Add("CombatMessagesType", CombatMessagesType);
            _ushortVelues.Add("DamageHitDelay", DamageHitDelay);
            _ushortVelues.Add("MultiSampling", MultiSampling);
        }
    }
}