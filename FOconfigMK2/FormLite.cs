using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace FOconfig.NET
{
    public partial class Form1 : Form
    {
        // Прокси.
        // Типы (ProxyType):
        // 0 - Нет прокси.
        // 1 - Socks4
        // 2 - Socks5
        // 3 - HTTP
        int ProxyType;

        // Режим боя по-умолчанию.
        // Используется для определения режима боя, когда его выбор ограничен.
        // 0 - в реальном времени и пошаговом;
        // 1 - только в реальном;
        // 2 - только в пошаговом.
        int DefaultCombatMode;

        // Переключение раскладки в чате.
        // 0 - Ctrl + Shift
        // 1 - Alt + Shift
        // 2 - Right Ctrl
        int LangChange;

        // Индикация патронов и износа.
        // 0 - полоски
        // 1 - цифры
        // 2 - полоски и цифры
        int IndicatorType;

        // Тип боевых сообщений.
        // 0 - полное/verbose
        // 1 - краткое/brief
        int CombatMessagesType;

       private readonly ReadAndWriteFiles fileConfig;
       private readonly ReadAndWriteFiles HostInfo;

        public Form1()
        {
            InitializeComponent();
            
            fileConfig = new ReadAndWriteFiles("FOnline.cfg");
            HostInfo = new ReadAndWriteFiles(GetClientPath()+"data\\res\\HostInfo.inf");
            
            comboBoxHost.Items.AddRange(HostInfo.arrayListOfStrings);

            if (fileConfig.IsNewConfig) return;
            
                // Настройки сервера
                comboBoxHost.Text = fileConfig.ReadValueInLine("RemoteHost");
                numericUpDownPort.Value = Convert.ToInt16(fileConfig.ReadValueInLine("RemotePort"));

                // Прокси
                ProxyType = Convert.ToInt16(fileConfig.ReadValueInLine("ProxyType"));
                if (ProxyType == 0) radioButtonNoneTypeProxi.Checked = true;
                else if (ProxyType == 1) radioButtonSocks4TypeProxi.Checked = true;
                else if (ProxyType == 2) radioButtonSocks5TypeProxi.Checked = true;
                else if (ProxyType == 3) radioButtonHttpTypeProxi.Checked = true;

                // ProxyHost
                comboBoxHostProxi.Text = (fileConfig.ReadValueInLine("ProxyHost"));
                numericUpDownPortProxi.Value = Convert.ToInt16(fileConfig.ReadValueInLine("ProxyPort"));
                textBoxLoginProxi.Text = fileConfig.ReadValueInLine("ProxyUser");
                textBoxPassProxi.Text = fileConfig.ReadValueInLine("ProxyPass");

                // Бег по-умолчанию
                if (fileConfig.ReadValueInLine("AlwaysRun") == "True") checkBoxAlwaysRun.Checked = true;
                else checkBoxAlwaysRun.Checked = false;

                // Режим боя по-умолчанию
                DefaultCombatMode = Convert.ToInt16(fileConfig.ReadValueInLine("DefaultCombatMode"));
                if (DefaultCombatMode == 0) radioButtonBothModes.Checked = true;
                else if (DefaultCombatMode == 1) radioButtonRealTime.Checked = true;
                else if (DefaultCombatMode == 2) radioButtonTurnBased.Checked = true;

                // Звуковое давление музыки, звуков
                trackBarMusic.Value = Convert.ToInt16(fileConfig.ReadValueInLine("MusicVolume"));
                trackBarSound.Value = Convert.ToInt16(fileConfig.ReadValueInLine("SoundVolume"));

                // Разрешение окна
                comboBoxResolution.Text = (fileConfig.ReadValueInLine("ScreenWidth") + "x" + fileConfig.ReadValueInLine("ScreenHeight"));

                // Полноэкранный режим
                checkBoxFullScreen.Checked = (fileConfig.ReadValueInLine("FullScreen") == "True");

                // Поверх всех окон
                checkBoxAlvaysOnTop.Checked = (fileConfig.ReadValueInLine("AlwaysOnTop") == "True");

                // Общий уровень освещенности
                numericUpDownLight.Value = Convert.ToInt16(fileConfig.ReadValueInLine("Light"));

                // Плавность скроллинга
                int value = Convert.ToInt16(fileConfig.ReadValueInLine("ScrollDelay"));
                numericUpDownScrollDelay.Value = (value < numericUpDownScrollDelay.Minimum ? numericUpDownScrollDelay.Minimum : value);

                // Дополнительное уменьшение скорости скроллинга
                value = Convert.ToInt16(fileConfig.ReadValueInLine("ScrollStep"));
                numericUpDownScrollStep.Value = (value < numericUpDownScrollStep.Minimum ? numericUpDownScrollStep.Minimum : value);

                // Базовое время, в течении которого показывается текст реплик. В миллисекундах
                value = Convert.ToInt16(fileConfig.ReadValueInLine("TextDelay"));
                numericUpDownTextDelay.Value = (value < numericUpDownTextDelay.Minimum ? numericUpDownTextDelay.Minimum : value);

                // Время показывания информации о повреждении. В миллисекундах
                numericUpDownDelayTextOnHead.Value = Convert.ToInt16(fileConfig.ReadValueInLine("DamageHitDelay"));

                // Уменьшение нагрузки на процессор
                numericUpDownSlap.Value = Convert.ToInt16(fileConfig.ReadValueInLine("FixedFPS"));

                // Переключение раскладки в чате
                LangChange = Convert.ToInt16(fileConfig.ReadValueInLine("LangChange"));
                if (LangChange == 0) radioButtonContrlShift.Checked = true;
                else if (LangChange == 1) radioButtonAltShift.Checked = true;

                // Индикация патронов и износа
                IndicatorType = Convert.ToInt16(fileConfig.ReadValueInLine("IndicatorType"));
                if (IndicatorType == 0) radioButtonLines.Checked = true;
                else if (IndicatorType == 1) radioButtonNumbers.Checked = true;
                else if (IndicatorType == 2) radioButtonLinesAndNumbers.Checked = true;

                // Инвертирование окна сообщений
                checkBoxInvertTextInMassegBox.Checked = (fileConfig.ReadValueInLine("InvertMessBox") == "True");

                // Логирование
                checkBoxLoggingInFonlineLog.Checked = (fileConfig.ReadValueInLine("Logging") == "True");
     
                // Если при неактивном окне клиента вам приходит сообщение, то в панеле задач моргнет иконка
                checkBoxFlushWindowOnNotActiveGame.Checked = (fileConfig.ReadValueInLine("WinNotify") == "True");

                // Если при неактивном окне клиента вам приходит сообщение, то прозвучит звуковой сигнал
                checkBoxBeepSoundOnNotActiveGage.Checked = (fileConfig.ReadValueInLine("SoundNotify") == "True");

                // Тип боевых сообщений
                CombatMessagesType = Convert.ToInt16(fileConfig.ReadValueInLine("CombatMessagesType"));
                if (CombatMessagesType == 0) radioButtonCombatMessegesFull.Checked = true;
                else if (CombatMessagesType == 1) radioButtonCombatMessegesBrief.Checked = true;

                // Кэшируемые спрайты
                numericUpDownCecheSprites.Value = Convert.ToInt16(fileConfig.ReadValueInLine("FlushValue"));

                // Размер текстуры, где будут храниться спрайты
                value = Convert.ToInt16(fileConfig.ReadValueInLine("BaseTexture"));
                numericUpDownTextureSize.Value = (value < numericUpDownTextureSize.Minimum ? numericUpDownTextureSize.Minimum : value);

                // Вертикальная синхронизация
                checkBoxVSync.Checked = (fileConfig.ReadValueInLine("VSync") == "True");

                // Сглаживание 3d (antialiasing)
                comboBoxMultisampling3D.SelectedIndex = Convert.ToInt16(fileConfig.ReadValueInLine("MultiSampling")) + 1;

                // Кол-во кадров в секунду для 3d графики
                numericUpDown3DFps.Value = Convert.ToInt16(fileConfig.ReadValueInLine("Animation3dFPS"));

                // Сглаживание переходов в 3d графике, время в миллисекундах
                numericUpDown3DSmoothTransition.Value = Convert.ToInt16(fileConfig.ReadValueInLine("Animation3dSmoothTime"));
        }
        
        // Сохранение данных в файл
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            fileConfig.WriteText("[Game Options]");
            fileConfig.WriteText("WindowName = FOnline: TLA mk2");
            
            fileConfig.WriteValueInLine("Language", "engl");

            // Настройки сервера
            fileConfig.WriteValueInLine("RemoteHost", comboBoxHost.Text);
            fileConfig.WriteValueInLine("RemotePort", Convert.ToString(numericUpDownPort.Value));

            // Прокси
            fileConfig.WriteValueInLine("ProxyType", Convert.ToString(ProxyType));
            fileConfig.WriteValueInLine("ProxyHost", Convert.ToString(comboBoxHostProxi.Text));
            fileConfig.WriteValueInLine("ProxyPort", Convert.ToString(numericUpDownPortProxi.Value));
            fileConfig.WriteValueInLine("ProxyUser", textBoxLoginProxi.Text);
            fileConfig.WriteValueInLine("ProxyPass", textBoxPassProxi.Text);

            // Бег по-умолчанию
            fileConfig.WriteValueInLine("AlwaysRun", (checkBoxAlwaysRun.Checked) ? "True" : "False");

            //Режим боя по-умолчанию
            fileConfig.WriteValueInLine("DefaultCombatMode", Convert.ToString(DefaultCombatMode));

            // Звуковое давление музыки, звуков
            fileConfig.WriteValueInLine("MusicVolume", Convert.ToString(trackBarMusic.Value));
            fileConfig.WriteValueInLine("SoundVolume", Convert.ToString(trackBarSound.Value));

            // Будут ли воспроизводится звуки, когда игра не активна
            //fileConfig.WriteValueInLine("GlobalSound", checkBoxGlobalSond.Checked ? "1" : "0", true);

            // Разрешение окна
            int i=0;
            foreach (char ch in comboBoxResolution.Text)
            {
                if (ch < '0' || ch > '9') break;
                i++;
            }
            fileConfig.WriteValueInLine("ScreenWidth", comboBoxResolution.Text.Substring(0, i));
            fileConfig.WriteValueInLine("ScreenHeight", comboBoxResolution.Text.Substring(i + 1, comboBoxResolution.Text.Length - i - 1));

            // Полноэкранный режим
            fileConfig.WriteValueInLine("FullScreen", checkBoxFullScreen.Checked ? "True" : "False");

            // Поверх всех окон.
            fileConfig.WriteValueInLine("AlwaysOnTop", checkBoxAlvaysOnTop.Checked ? "True" : "False");

            // Общий уровень освещенности
            fileConfig.WriteValueInLine("Light", Convert.ToString(numericUpDownLight.Value));

            // Плавность скроллинга
            fileConfig.WriteValueInLine("ScrollDelay", Convert.ToString(numericUpDownScrollDelay.Value));

            // Дополнительное уменьшение скорости скроллинга
            fileConfig.WriteValueInLine("ScrollStep", Convert.ToString(numericUpDownScrollStep.Value));

            // Базовое время, в течении которого показывается текст реплик. В миллисекундах
            fileConfig.WriteValueInLine("TextDelay", Convert.ToString(numericUpDownTextDelay.Value));

            // Время показывания информации о повреждении. В миллисекундах
            fileConfig.WriteValueInLine("DamageHitDelay", Convert.ToString(numericUpDownDelayTextOnHead.Value));

            // Уменьшение нагрузки на процессор
            fileConfig.WriteValueInLine("FixedFPS", Convert.ToString(numericUpDownSlap.Value));

            // Переключение раскладки в чате
            fileConfig.WriteValueInLine("LangChange", Convert.ToString(LangChange));

            // Индикация патронов и износа
            fileConfig.WriteValueInLine("IndicatorType", Convert.ToString(IndicatorType));

            // Инвертирование окна сообщений
            fileConfig.WriteValueInLine("InvertMessBox", checkBoxInvertTextInMassegBox.Checked ? "True" : "False");

            // Логирование
            fileConfig.WriteValueInLine("Logging", checkBoxLoggingInFonlineLog.Checked ? "True" : "False");
            fileConfig.WriteValueInLine("LoggingTime", "True");
            fileConfig.WriteValueInLine("LoggingDebugOutput", "True");
            fileConfig.WriteValueInLine("LoggingThread", "True"); 

            // Если при неактивном окне клиента вам приходит сообщение, то в панеле задач моргнет иконка
            fileConfig.WriteValueInLine("WinNotify", checkBoxFlushWindowOnNotActiveGame.Checked ? "True" : "False");
           
            //Если при неактивном окне клиента вам приходит сообщение, то прозвучит звуковой сигнал.
            fileConfig.WriteValueInLine("SoundNotify", checkBoxBeepSoundOnNotActiveGage.Checked ? "True" : "False");

            // Тип боевых сообщений
            fileConfig.WriteValueInLine("CombatMessagesType", Convert.ToString(CombatMessagesType));

            HostInfo.WriteTextInLine(comboBoxHost.Text, comboBoxHost.Text);

            // Кэшируемые спрайты
            fileConfig.WriteValueInLine("FlushValue", Convert.ToString(numericUpDownCecheSprites.Value));

            // Размер текстуры, где будут храниться спрайты
            fileConfig.WriteValueInLine("BaseTexture", Convert.ToString(numericUpDownTextureSize.Value));

            // Вертикальная синхронизация
            fileConfig.WriteValueInLine("VSync", checkBoxVSync.Checked ? "True" : "False");

            // Сглаживание 3d (antialiasing)
            fileConfig.WriteValueInLine("MultiSampling", Convert.ToString(comboBoxMultisampling3D.SelectedIndex - 1));

            // Кол-во кадров в секунду для 3d графики
            fileConfig.WriteValueInLine("Animation3dFPS", Convert.ToString(numericUpDown3DFps.Value));

            // Сглаживание переходов в 3d графике, время в миллисекундах
            fileConfig.WriteValueInLine("Animation3dSmoothTime", Convert.ToString(numericUpDown3DSmoothTransition.Value));
       
            // Запись файла
            fileConfig.WriteFile(GetClientPath() + "FOnline.cfg");
            HostInfo.WriteFile( GetClientPath()+"data\\res\\HostInfo.inf");
        }

        // Играть
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            ButtonSave_Click(null, null);
            try
            {
                Process newProc = Process.Start("FOnline.exe");
                this.Close();
            }
            catch 
            {
                MessageBox.Show("buttonPlay_Click error");
            }
        }

        // Прокси
        // Нет
        private void RadioButtonNoneTypeProxi_CheckedChanged(object sender, EventArgs e)
        {
            ProxyType = 0;
            textBoxLoginProxi.Enabled = false;
            textBoxPassProxi.Enabled = false;
            comboBoxHostProxi.Enabled = false;
            numericUpDownPortProxi.Enabled = false;
        }

        // Socks4
        private void RadioButtonSocks4TypeProxi_CheckedChanged(object sender, EventArgs e)
        {
            ProxyType = 1;
            textBoxLoginProxi.Enabled = true;
            textBoxPassProxi.Enabled = true;
            comboBoxHostProxi.Enabled = true;
            numericUpDownPortProxi.Enabled = true;
        }

        // Socks5
        private void RadioButtonSocks5TypeProxi_CheckedChanged(object sender, EventArgs e)
        {
            ProxyType = 2;
            textBoxLoginProxi.Enabled = true;
            textBoxPassProxi.Enabled = true;
            comboBoxHostProxi.Enabled = true;
            numericUpDownPortProxi.Enabled = true;
        }

        // HTTP
        private void RadioButtonHttpTypeProxi_CheckedChanged(object sender, EventArgs e)
        {
            ProxyType = 3;
            textBoxLoginProxi.Enabled = true;
            textBoxPassProxi.Enabled = true;
            comboBoxHostProxi.Enabled = true;
            numericUpDownPortProxi.Enabled = true;
        }

        // Режим боя по-умолчанию
        // В реальном времени и пошаговом
        private void RadioButtonBothModes_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCombatMode = 0;
        }

        // Только в реальном
        private void RadioButtonRealTime_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCombatMode = 1;
        }

        // Только в пошаговом
        private void RadioButtonTurnBased_CheckedChanged(object sender, EventArgs e)
        {
            DefaultCombatMode = 2;
        }

        // Переключение раскладки в чате
        // Ctrl + Shift
        private void RadioButtonContrlShift_CheckedChanged(object sender, EventArgs e)
        {
            LangChange = 0;
        }

        // Alt + Shift
        private void RadioButtonAltShift_CheckedChanged(object sender, EventArgs e)
        {
            LangChange = 1;
        }

        // Индикация патронов и износа.
        // Полоски
        private void RadioButtonLines_CheckedChanged(object sender, EventArgs e)
        {
            IndicatorType = 0;
        }

        //Цифры
        private void RadioButtonNumbers_CheckedChanged(object sender, EventArgs e)
        {
            IndicatorType = 1;
        }

        // Полоски и цифры
        private void RadioButtonLinesAndNumbers_CheckedChanged(object sender, EventArgs e)
        {
            IndicatorType = 2;
        }

        // Тип боевых сообщений
        // Полные
        private void RadioButtonCombatMessegesFull_CheckedChanged(object sender, EventArgs e)
        {
            CombatMessagesType = 0;
        }

        // Краткие
        private void RadioButtonCombatMessegesBrief_CheckedChanged(object sender, EventArgs e)
        {
            CombatMessagesType = 1;
        }

        // Выход
        private void ButtonExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetClientPath()
        {
            if (System.Windows.Forms.Application.StartupPath[System.Windows.Forms.Application.StartupPath.Length - 1] == '\\')
            {
                return System.Windows.Forms.Application.StartupPath;
            }
            else
            {
                return System.Windows.Forms.Application.StartupPath + '\\';
            }
        }
    }
}//1033