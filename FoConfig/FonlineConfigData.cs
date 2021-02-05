using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoConfig
{
    public class FonlineConfigData: IConfigData
    {
        public Dictionary<string, string> StringVelues { get => _stringVelues; set => _stringVelues = value; }
        public Dictionary<string, bool> BoolVelues { get => _boolVelues; set => _boolVelues = value; }
        public Dictionary<string, bool> UshortVelues { get => _ushortVelues; set => _ushortVelues = value; }

        private Dictionary<string, string> _stringVelues = new Dictionary<string, string>();
        private Dictionary<string, bool> _boolVelues = new Dictionary<string, bool>();
        private Dictionary<string, bool> _ushortVelues = new Dictionary<string, bool>();

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
    }
}