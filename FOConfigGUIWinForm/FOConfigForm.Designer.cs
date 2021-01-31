using System.Windows.Forms;

namespace FOConfigGUIWinForm
{
    partial class FOConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOConfigForm));
            tabControlMainContent = new TabControl();
            pageOther = new TabPage();
            groupBoxMisk = new GroupBox();
            checkBoxLoggingTime = new CheckBox();
            checkBoxLogging = new CheckBox();
            checkBoxInvertMessBox = new CheckBox();
            checkBoxSoundNotify = new CheckBox();
            checkBoxWinNotify = new CheckBox();
            groupBoxLanguage = new GroupBox();
            comboBoxLanguage = new ComboBox();
            pageGame = new TabPage();
            groupBoxGame = new GroupBox();
            checkBoxAlwaysRun = new CheckBox();
            numericUpDownTextDelay = new NumericUpDown();
            numericUpDownScrollStep = new NumericUpDown();
            numericUpDownScrollDelay = new NumericUpDown();
            labelTextDelay = new Label();
            labelScrollStep = new Label();
            labelScrollDelay = new Label();
            pageCombat = new TabPage();
            groupBoxDamageHitDelay = new GroupBox();
            numericUpDownDamageHitDelay = new NumericUpDown();
            labelDamageHitDelay = new Label();
            groupBoxCombatMessagesType = new GroupBox();
            radioButtonMessagesBrief = new RadioButton();
            radioButtonMessagesVerbose = new RadioButton();
            groupBoxIndicatorType = new GroupBox();
            radioButtonIndicatorNumbers = new RadioButton();
            radioButtonIndicatorLines = new RadioButton();
            radioButtonIndicatorBoth = new RadioButton();
            groupBoxDefaultCombatMode = new GroupBox();
            radioButtonCombatTurnBased = new RadioButton();
            radioButtonCombatRealTime = new RadioButton();
            radioButtonCombatBoth = new RadioButton();
            pageNet = new TabPage();
            groupBoxProxy = new GroupBox();
            textBoxProxyPass = new TextBox();
            textBoxProxyUser = new TextBox();
            labelProxyPass = new Label();
            labelProxyUser = new Label();
            numericUpDownProxyPort = new NumericUpDown();
            comboBoxProxyHost = new ComboBox();
            labelProxyPort = new Label();
            labelProxyHost = new Label();
            radioButtonProxyTypeHttp = new RadioButton();
            radioButtonProxyTypeSocks5 = new RadioButton();
            radioButtonProxyTypeSocks4 = new RadioButton();
            radioButtonProxyTypeNone = new RadioButton();
            labelType = new Label();
            groupBoxGameServer = new GroupBox();
            numericUpDownRemotePort = new NumericUpDown();
            comboBoxRemoteHost = new ComboBox();
            labelRemotePort = new Label();
            labelRemoteHost = new Label();
            pageVideo = new TabPage();
            groupBoxVideo = new GroupBox();
            numericUpDownBaseTexture = new NumericUpDown();
            numericUpDownFlushValue = new NumericUpDown();
            numericUpDownLight = new NumericUpDown();
            labelLight = new Label();
            groupBoxResolution = new GroupBox();
            comboBoxScreenHeight = new ComboBox();
            comboBoxScreenWidth = new ComboBox();
            pageSound = new TabPage();
            buttonPlay = new Button();
            buttonSave = new Button();
            buttonExit = new Button();
            labelFlushValue = new Label();
            labelBaseTexture = new Label();
            labelMultiSampling = new Label();
            comboBoxMultiSampling = new ComboBox();
            labelAnimation3dFPS = new Label();
            numericUpDownAnimation3dFPS = new NumericUpDown();
            numericUpDownAnimation3dSmoothTime = new NumericUpDown();
            labelAnimation3dSmoothTime = new Label();
            checkBoxFullScreen = new CheckBox();
            checkBoxVSync = new CheckBox();
            checkBoxAlwaysOnTop = new CheckBox();
            labelFixedFPS = new Label();
            numericUpDownFixedFPS = new NumericUpDown();
            groupBoxVolume = new GroupBox();
            trackBarMusicVolume = new TrackBar();
            labelMusicVolume = new Label();
            labelSoundVolume = new Label();
            trackBarSoundVolume = new TrackBar();
            tabControlMainContent.SuspendLayout();
            pageOther.SuspendLayout();
            groupBoxMisk.SuspendLayout();
            groupBoxLanguage.SuspendLayout();
            pageGame.SuspendLayout();
            groupBoxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownTextDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownScrollStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownScrollDelay)).BeginInit();
            pageCombat.SuspendLayout();
            groupBoxDamageHitDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownDamageHitDelay)).BeginInit();
            groupBoxCombatMessagesType.SuspendLayout();
            groupBoxIndicatorType.SuspendLayout();
            groupBoxDefaultCombatMode.SuspendLayout();
            pageNet.SuspendLayout();
            groupBoxProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownProxyPort)).BeginInit();
            groupBoxGameServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownRemotePort)).BeginInit();
            pageVideo.SuspendLayout();
            groupBoxVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownBaseTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownFlushValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownLight)).BeginInit();
            groupBoxResolution.SuspendLayout();
            pageSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownAnimation3dFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownAnimation3dSmoothTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownFixedFPS)).BeginInit();
            groupBoxVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBarMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(trackBarSoundVolume)).BeginInit();
            SuspendLayout();
            // 
            // tabControlMainContent
            // 
            tabControlMainContent.Controls.Add(pageOther);
            tabControlMainContent.Controls.Add(pageGame);
            tabControlMainContent.Controls.Add(pageCombat);
            tabControlMainContent.Controls.Add(pageNet);
            tabControlMainContent.Controls.Add(pageVideo);
            tabControlMainContent.Controls.Add(pageSound);
            tabControlMainContent.Location = new System.Drawing.Point(4, 4);
            tabControlMainContent.Name = "tabControlMainContent";
            tabControlMainContent.SelectedIndex = 0;
            tabControlMainContent.Size = new System.Drawing.Size(270, 325);
            tabControlMainContent.TabIndex = 0;
            // 
            // pageOther
            // 
            pageOther.Controls.Add(groupBoxMisk);
            pageOther.Controls.Add(groupBoxLanguage);
            pageOther.Location = new System.Drawing.Point(4, 22);
            pageOther.Name = "pageOther";
            pageOther.Padding = new Padding(3);
            pageOther.Size = new System.Drawing.Size(262, 299);
            pageOther.TabIndex = 0;
            pageOther.Text = "Other";
            pageOther.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisk
            // 
            groupBoxMisk.Controls.Add(checkBoxLoggingTime);
            groupBoxMisk.Controls.Add(checkBoxLogging);
            groupBoxMisk.Controls.Add(checkBoxInvertMessBox);
            groupBoxMisk.Controls.Add(checkBoxSoundNotify);
            groupBoxMisk.Controls.Add(checkBoxWinNotify);
            groupBoxMisk.Location = new System.Drawing.Point(6, 69);
            groupBoxMisk.Name = "groupBoxMisk";
            groupBoxMisk.Size = new System.Drawing.Size(250, 224);
            groupBoxMisk.TabIndex = 1;
            groupBoxMisk.TabStop = false;
            // 
            // checkBoxLoggingTime
            // 
            checkBoxLoggingTime.AutoSize = true;
            checkBoxLoggingTime.Location = new System.Drawing.Point(6, 151);
            checkBoxLoggingTime.Name = "checkBoxLoggingTime";
            checkBoxLoggingTime.Size = new System.Drawing.Size(111, 17);
            checkBoxLoggingTime.TabIndex = 4;
            checkBoxLoggingTime.Text = "Logging with time.";
            checkBoxLoggingTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogging
            // 
            checkBoxLogging.AutoSize = true;
            checkBoxLogging.Checked = true;
            checkBoxLogging.CheckState = CheckState.Checked;
            checkBoxLogging.Location = new System.Drawing.Point(6, 128);
            checkBoxLogging.Name = "checkBoxLogging";
            checkBoxLogging.Size = new System.Drawing.Size(136, 17);
            checkBoxLogging.TabIndex = 3;
            checkBoxLogging.Text = "Logging in \'Fonline.log\'.";
            checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvertMessBox
            // 
            checkBoxInvertMessBox.AutoSize = true;
            checkBoxInvertMessBox.Location = new System.Drawing.Point(6, 92);
            checkBoxInvertMessBox.Name = "checkBoxInvertMessBox";
            checkBoxInvertMessBox.Size = new System.Drawing.Size(81, 30);
            checkBoxInvertMessBox.TabIndex = 2;
            checkBoxInvertMessBox.Text = "Invert text\r\nin messbox.";
            checkBoxInvertMessBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxSoundNotify
            // 
            checkBoxSoundNotify.AutoSize = true;
            checkBoxSoundNotify.Location = new System.Drawing.Point(6, 56);
            checkBoxSoundNotify.Name = "checkBoxSoundNotify";
            checkBoxSoundNotify.Size = new System.Drawing.Size(105, 30);
            checkBoxSoundNotify.TabIndex = 1;
            checkBoxSoundNotify.Text = "Beep sound on\r\nnot active game.";
            checkBoxSoundNotify.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinNotify
            // 
            checkBoxWinNotify.AutoSize = true;
            checkBoxWinNotify.Checked = true;
            checkBoxWinNotify.CheckState = CheckState.Checked;
            checkBoxWinNotify.Location = new System.Drawing.Point(6, 20);
            checkBoxWinNotify.Name = "checkBoxWinNotify";
            checkBoxWinNotify.Size = new System.Drawing.Size(105, 30);
            checkBoxWinNotify.TabIndex = 0;
            checkBoxWinNotify.Text = "Flush window on\r\nnot active game.";
            checkBoxWinNotify.UseVisualStyleBackColor = true;
            // 
            // groupBoxLanguage
            // 
            groupBoxLanguage.Controls.Add(comboBoxLanguage);
            groupBoxLanguage.Location = new System.Drawing.Point(6, 6);
            groupBoxLanguage.Name = "groupBoxLanguage";
            groupBoxLanguage.Size = new System.Drawing.Size(250, 57);
            groupBoxLanguage.TabIndex = 0;
            groupBoxLanguage.TabStop = false;
            groupBoxLanguage.Text = "Language \\  Язык";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Русский"});
            comboBoxLanguage.Location = new System.Drawing.Point(6, 19);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new System.Drawing.Size(168, 21);
            comboBoxLanguage.TabIndex = 0;
            comboBoxLanguage.SelectedIndex = 0;
            // 
            // pageGame
            // 
            pageGame.Controls.Add(groupBoxGame);
            pageGame.Location = new System.Drawing.Point(4, 22);
            pageGame.Name = "pageGame";
            pageGame.Padding = new Padding(3);
            pageGame.Size = new System.Drawing.Size(262, 299);
            pageGame.TabIndex = 1;
            pageGame.Text = "Game";
            pageGame.UseVisualStyleBackColor = true;
            // 
            // groupBoxGame
            // 
            groupBoxGame.Controls.Add(checkBoxAlwaysRun);
            groupBoxGame.Controls.Add(numericUpDownTextDelay);
            groupBoxGame.Controls.Add(numericUpDownScrollStep);
            groupBoxGame.Controls.Add(numericUpDownScrollDelay);
            groupBoxGame.Controls.Add(labelTextDelay);
            groupBoxGame.Controls.Add(labelScrollStep);
            groupBoxGame.Controls.Add(labelScrollDelay);
            groupBoxGame.Location = new System.Drawing.Point(6, 6);
            groupBoxGame.Name = "groupBoxGame";
            groupBoxGame.Size = new System.Drawing.Size(250, 287);
            groupBoxGame.TabIndex = 1;
            groupBoxGame.TabStop = false;
            groupBoxGame.Text = "Game";
            // 
            // checkBoxAlwaysRun
            // 
            checkBoxAlwaysRun.AutoSize = true;
            checkBoxAlwaysRun.Checked = true;
            checkBoxAlwaysRun.CheckState = CheckState.Checked;
            checkBoxAlwaysRun.Location = new System.Drawing.Point(6, 94);
            checkBoxAlwaysRun.Name = "checkBoxAlwaysRun";
            checkBoxAlwaysRun.Size = new System.Drawing.Size(77, 17);
            checkBoxAlwaysRun.TabIndex = 6;
            checkBoxAlwaysRun.Text = "Always run";
            checkBoxAlwaysRun.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTextDelay
            // 
            numericUpDownTextDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            numericUpDownTextDelay.Location = new System.Drawing.Point(160, 66);
            numericUpDownTextDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            numericUpDownTextDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDownTextDelay.Name = "numericUpDownTextDelay";
            numericUpDownTextDelay.Size = new System.Drawing.Size(80, 20);
            numericUpDownTextDelay.TabIndex = 5;
            numericUpDownTextDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // numericUpDownScrollStep
            // 
            numericUpDownScrollStep.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            numericUpDownScrollStep.Location = new System.Drawing.Point(160, 40);
            numericUpDownScrollStep.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            numericUpDownScrollStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDownScrollStep.Name = "numericUpDownScrollStep";
            numericUpDownScrollStep.Size = new System.Drawing.Size(80, 20);
            numericUpDownScrollStep.TabIndex = 4;
            numericUpDownScrollStep.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownScrollDelay
            // 
            numericUpDownScrollDelay.Location = new System.Drawing.Point(160, 14);
            numericUpDownScrollDelay.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            numericUpDownScrollDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDownScrollDelay.Name = "numericUpDownScrollDelay";
            numericUpDownScrollDelay.Size = new System.Drawing.Size(80, 20);
            numericUpDownScrollDelay.TabIndex = 3;
            numericUpDownScrollDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelTextDelay
            // 
            labelTextDelay.AutoSize = true;
            labelTextDelay.Location = new System.Drawing.Point(6, 68);
            labelTextDelay.Name = "labelTextDelay";
            labelTextDelay.Size = new System.Drawing.Size(78, 13);
            labelTextDelay.TabIndex = 2;
            labelTextDelay.Text = "Text delay (ms)";
            // 
            // labelScrollStep
            // 
            labelScrollStep.AutoSize = true;
            labelScrollStep.Location = new System.Drawing.Point(6, 42);
            labelScrollStep.Name = "labelScrollStep";
            labelScrollStep.Size = new System.Drawing.Size(56, 13);
            labelScrollStep.TabIndex = 1;
            labelScrollStep.Text = "Scroll step";
            // 
            // labelScrollDelay
            // 
            labelScrollDelay.AutoSize = true;
            labelScrollDelay.Location = new System.Drawing.Point(6, 16);
            labelScrollDelay.Name = "labelScrollDelay";
            labelScrollDelay.Size = new System.Drawing.Size(61, 13);
            labelScrollDelay.TabIndex = 0;
            labelScrollDelay.Text = "Scroll delay";
            // 
            // pageCombat
            // 
            pageCombat.Controls.Add(groupBoxDamageHitDelay);
            pageCombat.Controls.Add(groupBoxCombatMessagesType);
            pageCombat.Controls.Add(groupBoxIndicatorType);
            pageCombat.Controls.Add(groupBoxDefaultCombatMode);
            pageCombat.Location = new System.Drawing.Point(4, 22);
            pageCombat.Name = "pageCombat";
            pageCombat.Padding = new Padding(3);
            pageCombat.Size = new System.Drawing.Size(262, 299);
            pageCombat.TabIndex = 2;
            pageCombat.Text = "Combat";
            pageCombat.UseVisualStyleBackColor = true;
            // 
            // groupBoxDamageHitDelay
            // 
            groupBoxDamageHitDelay.Controls.Add(numericUpDownDamageHitDelay);
            groupBoxDamageHitDelay.Controls.Add(labelDamageHitDelay);
            groupBoxDamageHitDelay.Location = new System.Drawing.Point(7, 254);
            groupBoxDamageHitDelay.Name = "groupBoxDamageHitDelay";
            groupBoxDamageHitDelay.Size = new System.Drawing.Size(250, 39);
            groupBoxDamageHitDelay.TabIndex = 5;
            groupBoxDamageHitDelay.TabStop = false;
            groupBoxDamageHitDelay.Text = "Damage indication on head";
            // 
            // numericUpDownDamageHitDelay
            // 
            numericUpDownDamageHitDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            numericUpDownDamageHitDelay.Location = new System.Drawing.Point(159, 14);
            numericUpDownDamageHitDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            numericUpDownDamageHitDelay.Name = "numericUpDownDamageHitDelay";
            numericUpDownDamageHitDelay.Size = new System.Drawing.Size(80, 20);
            numericUpDownDamageHitDelay.TabIndex = 7;
            numericUpDownDamageHitDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelDamageHitDelay
            // 
            labelDamageHitDelay.AutoSize = true;
            labelDamageHitDelay.Location = new System.Drawing.Point(6, 16);
            labelDamageHitDelay.Name = "labelDamageHitDelay";
            labelDamageHitDelay.Size = new System.Drawing.Size(56, 13);
            labelDamageHitDelay.TabIndex = 6;
            labelDamageHitDelay.Text = "Delay (ms)";
            // 
            // groupBoxCombatMessagesType
            // 
            groupBoxCombatMessagesType.Controls.Add(radioButtonMessagesBrief);
            groupBoxCombatMessagesType.Controls.Add(radioButtonMessagesVerbose);
            groupBoxCombatMessagesType.Location = new System.Drawing.Point(6, 200);
            groupBoxCombatMessagesType.Name = "groupBoxCombatMessagesType";
            groupBoxCombatMessagesType.Size = new System.Drawing.Size(250, 47);
            groupBoxCombatMessagesType.TabIndex = 4;
            groupBoxCombatMessagesType.TabStop = false;
            groupBoxCombatMessagesType.Text = "Ammo amount display";
            // 
            // radioButtonMessagesBrief
            // 
            radioButtonMessagesBrief.AutoSize = true;
            radioButtonMessagesBrief.Checked = true;
            radioButtonMessagesBrief.Location = new System.Drawing.Point(93, 19);
            radioButtonMessagesBrief.Name = "radioButtonMessagesBrief";
            radioButtonMessagesBrief.Size = new System.Drawing.Size(46, 17);
            radioButtonMessagesBrief.TabIndex = 1;
            radioButtonMessagesBrief.TabStop = true;
            radioButtonMessagesBrief.Text = "Brief";
            radioButtonMessagesBrief.UseVisualStyleBackColor = true;
            // 
            // radioButtonMessagesVerbose
            // 
            radioButtonMessagesVerbose.AutoSize = true;
            radioButtonMessagesVerbose.Location = new System.Drawing.Point(6, 19);
            radioButtonMessagesVerbose.Name = "radioButtonMessagesVerbose";
            radioButtonMessagesVerbose.Size = new System.Drawing.Size(64, 17);
            radioButtonMessagesVerbose.TabIndex = 0;
            radioButtonMessagesVerbose.Text = "Verbose";
            radioButtonMessagesVerbose.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndicatorType
            // 
            groupBoxIndicatorType.Controls.Add(radioButtonIndicatorNumbers);
            groupBoxIndicatorType.Controls.Add(radioButtonIndicatorLines);
            groupBoxIndicatorType.Controls.Add(radioButtonIndicatorBoth);
            groupBoxIndicatorType.Location = new System.Drawing.Point(6, 103);
            groupBoxIndicatorType.Name = "groupBoxIndicatorType";
            groupBoxIndicatorType.Size = new System.Drawing.Size(250, 91);
            groupBoxIndicatorType.TabIndex = 3;
            groupBoxIndicatorType.TabStop = false;
            groupBoxIndicatorType.Text = "Ammo amount display";
            // 
            // radioButtonIndicatorNumbers
            // 
            radioButtonIndicatorNumbers.AutoSize = true;
            radioButtonIndicatorNumbers.Location = new System.Drawing.Point(6, 65);
            radioButtonIndicatorNumbers.Name = "radioButtonIndicatorNumbers";
            radioButtonIndicatorNumbers.Size = new System.Drawing.Size(67, 17);
            radioButtonIndicatorNumbers.TabIndex = 2;
            radioButtonIndicatorNumbers.Text = "Numbers";
            radioButtonIndicatorNumbers.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndicatorLines
            // 
            radioButtonIndicatorLines.AutoSize = true;
            radioButtonIndicatorLines.Location = new System.Drawing.Point(6, 42);
            radioButtonIndicatorLines.Name = "radioButtonIndicatorLines";
            radioButtonIndicatorLines.Size = new System.Drawing.Size(50, 17);
            radioButtonIndicatorLines.TabIndex = 1;
            radioButtonIndicatorLines.Text = "Lines";
            radioButtonIndicatorLines.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndicatorBoth
            // 
            radioButtonIndicatorBoth.AutoSize = true;
            radioButtonIndicatorBoth.Checked = true;
            radioButtonIndicatorBoth.Location = new System.Drawing.Point(6, 19);
            radioButtonIndicatorBoth.Name = "radioButtonIndicatorBoth";
            radioButtonIndicatorBoth.Size = new System.Drawing.Size(81, 17);
            radioButtonIndicatorBoth.TabIndex = 0;
            radioButtonIndicatorBoth.TabStop = true;
            radioButtonIndicatorBoth.Text = "Both modes";
            radioButtonIndicatorBoth.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefaultCombatMode
            // 
            groupBoxDefaultCombatMode.Controls.Add(radioButtonCombatTurnBased);
            groupBoxDefaultCombatMode.Controls.Add(radioButtonCombatRealTime);
            groupBoxDefaultCombatMode.Controls.Add(radioButtonCombatBoth);
            groupBoxDefaultCombatMode.Location = new System.Drawing.Point(6, 6);
            groupBoxDefaultCombatMode.Name = "groupBoxDefaultCombatMode";
            groupBoxDefaultCombatMode.Size = new System.Drawing.Size(250, 91);
            groupBoxDefaultCombatMode.TabIndex = 0;
            groupBoxDefaultCombatMode.TabStop = false;
            groupBoxDefaultCombatMode.Text = "Default combat mode";
            // 
            // radioButtonCombatTurnBased
            // 
            radioButtonCombatTurnBased.AutoSize = true;
            radioButtonCombatTurnBased.Location = new System.Drawing.Point(6, 65);
            radioButtonCombatTurnBased.Name = "radioButtonCombatTurnBased";
            radioButtonCombatTurnBased.Size = new System.Drawing.Size(79, 17);
            radioButtonCombatTurnBased.TabIndex = 2;
            radioButtonCombatTurnBased.Text = "Turn-based";
            radioButtonCombatTurnBased.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombatRealTime
            // 
            radioButtonCombatRealTime.AutoSize = true;
            radioButtonCombatRealTime.Location = new System.Drawing.Point(6, 42);
            radioButtonCombatRealTime.Name = "radioButtonCombatRealTime";
            radioButtonCombatRealTime.Size = new System.Drawing.Size(69, 17);
            radioButtonCombatRealTime.TabIndex = 1;
            radioButtonCombatRealTime.Text = "Real-time";
            radioButtonCombatRealTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombatBoth
            // 
            radioButtonCombatBoth.AutoSize = true;
            radioButtonCombatBoth.Checked = true;
            radioButtonCombatBoth.Location = new System.Drawing.Point(6, 19);
            radioButtonCombatBoth.Name = "radioButtonCombatBoth";
            radioButtonCombatBoth.Size = new System.Drawing.Size(81, 17);
            radioButtonCombatBoth.TabIndex = 0;
            radioButtonCombatBoth.TabStop = true;
            radioButtonCombatBoth.Text = "Both modes";
            radioButtonCombatBoth.UseVisualStyleBackColor = true;
            // 
            // pageNet
            // 
            pageNet.Controls.Add(groupBoxProxy);
            pageNet.Controls.Add(groupBoxGameServer);
            pageNet.Location = new System.Drawing.Point(4, 22);
            pageNet.Name = "pageNet";
            pageNet.Padding = new Padding(3);
            pageNet.Size = new System.Drawing.Size(262, 299);
            pageNet.TabIndex = 3;
            pageNet.Text = "Net";
            pageNet.UseVisualStyleBackColor = true;
            // 
            // groupBoxProxy
            // 
            groupBoxProxy.Controls.Add(textBoxProxyPass);
            groupBoxProxy.Controls.Add(textBoxProxyUser);
            groupBoxProxy.Controls.Add(labelProxyPass);
            groupBoxProxy.Controls.Add(labelProxyUser);
            groupBoxProxy.Controls.Add(numericUpDownProxyPort);
            groupBoxProxy.Controls.Add(comboBoxProxyHost);
            groupBoxProxy.Controls.Add(labelProxyPort);
            groupBoxProxy.Controls.Add(labelProxyHost);
            groupBoxProxy.Controls.Add(radioButtonProxyTypeHttp);
            groupBoxProxy.Controls.Add(radioButtonProxyTypeSocks5);
            groupBoxProxy.Controls.Add(radioButtonProxyTypeSocks4);
            groupBoxProxy.Controls.Add(radioButtonProxyTypeNone);
            groupBoxProxy.Controls.Add(labelType);
            groupBoxProxy.Location = new System.Drawing.Point(6, 76);
            groupBoxProxy.Name = "groupBoxProxy";
            groupBoxProxy.Size = new System.Drawing.Size(250, 217);
            groupBoxProxy.TabIndex = 1;
            groupBoxProxy.TabStop = false;
            groupBoxProxy.Text = "Proxy";
            // 
            // textBoxProxyPass
            // 
            textBoxProxyPass.Location = new System.Drawing.Point(6, 151);
            textBoxProxyPass.Name = "textBoxProxyPass";
            textBoxProxyPass.Size = new System.Drawing.Size(226, 20);
            textBoxProxyPass.TabIndex = 16;
            // 
            // textBoxProxyUser
            // 
            textBoxProxyUser.Location = new System.Drawing.Point(6, 111);
            textBoxProxyUser.Name = "textBoxProxyUser";
            textBoxProxyUser.Size = new System.Drawing.Size(226, 20);
            textBoxProxyUser.TabIndex = 15;
            // 
            // labelProxyPass
            // 
            labelProxyPass.AutoSize = true;
            labelProxyPass.Location = new System.Drawing.Point(6, 135);
            labelProxyPass.Name = "labelProxyPass";
            labelProxyPass.Size = new System.Drawing.Size(53, 13);
            labelProxyPass.TabIndex = 14;
            labelProxyPass.Text = "Password";
            // 
            // labelProxyUser
            // 
            labelProxyUser.AutoSize = true;
            labelProxyUser.Location = new System.Drawing.Point(6, 95);
            labelProxyUser.Name = "labelProxyUser";
            labelProxyUser.Size = new System.Drawing.Size(33, 13);
            labelProxyUser.TabIndex = 12;
            labelProxyUser.Text = "Login";
            // 
            // numericUpDownProxyPort
            // 
            numericUpDownProxyPort.Location = new System.Drawing.Point(176, 70);
            numericUpDownProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            numericUpDownProxyPort.Name = "numericUpDownProxyPort";
            numericUpDownProxyPort.Size = new System.Drawing.Size(64, 20);
            numericUpDownProxyPort.TabIndex = 11;
            numericUpDownProxyPort.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // comboBoxProxyHost
            // 
            comboBoxProxyHost.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost"});
            comboBoxProxyHost.FormattingEnabled = true;
            comboBoxProxyHost.Location = new System.Drawing.Point(6, 69);
            comboBoxProxyHost.Name = "comboBoxProxyHost";
            comboBoxProxyHost.Size = new System.Drawing.Size(162, 21);
            comboBoxProxyHost.TabIndex = 10;
            // 
            // labelProxyPort
            // 
            labelProxyPort.AutoSize = true;
            labelProxyPort.Location = new System.Drawing.Point(208, 53);
            labelProxyPort.Name = "labelProxyPort";
            labelProxyPort.Size = new System.Drawing.Size(26, 13);
            labelProxyPort.TabIndex = 9;
            labelProxyPort.Text = "Port";
            // 
            // labelProxyHost
            // 
            labelProxyHost.AutoSize = true;
            labelProxyHost.Location = new System.Drawing.Point(6, 53);
            labelProxyHost.Name = "labelProxyHost";
            labelProxyHost.Size = new System.Drawing.Size(29, 13);
            labelProxyHost.TabIndex = 6;
            labelProxyHost.Text = "Host";
            // 
            // radioButtonProxyTypeHttp
            // 
            radioButtonProxyTypeHttp.AutoSize = true;
            radioButtonProxyTypeHttp.Location = new System.Drawing.Point(198, 33);
            radioButtonProxyTypeHttp.Name = "radioButtonProxyTypeHttp";
            radioButtonProxyTypeHttp.Size = new System.Drawing.Size(45, 17);
            radioButtonProxyTypeHttp.TabIndex = 4;
            radioButtonProxyTypeHttp.Text = "Http";
            radioButtonProxyTypeHttp.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeSocks5
            // 
            radioButtonProxyTypeSocks5.AutoSize = true;
            radioButtonProxyTypeSocks5.Location = new System.Drawing.Point(128, 33);
            radioButtonProxyTypeSocks5.Name = "radioButtonProxyTypeSocks5";
            radioButtonProxyTypeSocks5.Size = new System.Drawing.Size(64, 17);
            radioButtonProxyTypeSocks5.TabIndex = 3;
            radioButtonProxyTypeSocks5.Text = "Socks 5";
            radioButtonProxyTypeSocks5.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeSocks4
            // 
            radioButtonProxyTypeSocks4.AutoSize = true;
            radioButtonProxyTypeSocks4.Location = new System.Drawing.Point(63, 33);
            radioButtonProxyTypeSocks4.Name = "radioButtonProxyTypeSocks4";
            radioButtonProxyTypeSocks4.Size = new System.Drawing.Size(64, 17);
            radioButtonProxyTypeSocks4.TabIndex = 2;
            radioButtonProxyTypeSocks4.Text = "Socks 4";
            radioButtonProxyTypeSocks4.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeNone
            // 
            radioButtonProxyTypeNone.AutoSize = true;
            radioButtonProxyTypeNone.Checked = true;
            radioButtonProxyTypeNone.Location = new System.Drawing.Point(11, 33);
            radioButtonProxyTypeNone.Name = "radioButtonProxyTypeNone";
            radioButtonProxyTypeNone.Size = new System.Drawing.Size(51, 17);
            radioButtonProxyTypeNone.TabIndex = 1;
            radioButtonProxyTypeNone.TabStop = true;
            radioButtonProxyTypeNone.Text = "None";
            radioButtonProxyTypeNone.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new System.Drawing.Point(96, 16);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(31, 13);
            labelType.TabIndex = 0;
            labelType.Text = "Type";
            // 
            // groupBoxGameServer
            // 
            groupBoxGameServer.Controls.Add(numericUpDownRemotePort);
            groupBoxGameServer.Controls.Add(comboBoxRemoteHost);
            groupBoxGameServer.Controls.Add(labelRemotePort);
            groupBoxGameServer.Controls.Add(labelRemoteHost);
            groupBoxGameServer.Location = new System.Drawing.Point(6, 6);
            groupBoxGameServer.Name = "groupBoxGameServer";
            groupBoxGameServer.Size = new System.Drawing.Size(250, 64);
            groupBoxGameServer.TabIndex = 0;
            groupBoxGameServer.TabStop = false;
            groupBoxGameServer.Text = "Game server";
            // 
            // numericUpDownRemotePort
            // 
            numericUpDownRemotePort.Location = new System.Drawing.Point(176, 33);
            numericUpDownRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            numericUpDownRemotePort.Name = "numericUpDownRemotePort";
            numericUpDownRemotePort.Size = new System.Drawing.Size(64, 20);
            numericUpDownRemotePort.TabIndex = 8;
            numericUpDownRemotePort.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // comboBoxRemoteHost
            // 
            comboBoxRemoteHost.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost"});
            comboBoxRemoteHost.FormattingEnabled = true;
            comboBoxRemoteHost.Location = new System.Drawing.Point(6, 32);
            comboBoxRemoteHost.Name = "comboBoxRemoteHost";
            comboBoxRemoteHost.Size = new System.Drawing.Size(162, 21);
            comboBoxRemoteHost.TabIndex = 5;
            // 
            // labelRemotePort
            // 
            labelRemotePort.AutoSize = true;
            labelRemotePort.Location = new System.Drawing.Point(208, 16);
            labelRemotePort.Name = "labelRemotePort";
            labelRemotePort.Size = new System.Drawing.Size(26, 13);
            labelRemotePort.TabIndex = 4;
            labelRemotePort.Text = "Port";
            // 
            // labelRemoteHost
            // 
            labelRemoteHost.AutoSize = true;
            labelRemoteHost.Location = new System.Drawing.Point(6, 16);
            labelRemoteHost.Name = "labelRemoteHost";
            labelRemoteHost.Size = new System.Drawing.Size(29, 13);
            labelRemoteHost.TabIndex = 0;
            labelRemoteHost.Text = "Host";
            // 
            // pageVideo
            // 
            pageVideo.Controls.Add(groupBoxVideo);
            pageVideo.Controls.Add(groupBoxResolution);
            pageVideo.Location = new System.Drawing.Point(4, 22);
            pageVideo.Name = "pageVideo";
            pageVideo.Padding = new Padding(3);
            pageVideo.Size = new System.Drawing.Size(262, 299);
            pageVideo.TabIndex = 4;
            pageVideo.Text = "Video";
            pageVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxVideo
            // 
            groupBoxVideo.Controls.Add(numericUpDownFixedFPS);
            groupBoxVideo.Controls.Add(labelFixedFPS);
            groupBoxVideo.Controls.Add(checkBoxAlwaysOnTop);
            groupBoxVideo.Controls.Add(checkBoxVSync);
            groupBoxVideo.Controls.Add(checkBoxFullScreen);
            groupBoxVideo.Controls.Add(labelAnimation3dSmoothTime);
            groupBoxVideo.Controls.Add(numericUpDownAnimation3dSmoothTime);
            groupBoxVideo.Controls.Add(numericUpDownAnimation3dFPS);
            groupBoxVideo.Controls.Add(labelAnimation3dFPS);
            groupBoxVideo.Controls.Add(comboBoxMultiSampling);
            groupBoxVideo.Controls.Add(labelMultiSampling);
            groupBoxVideo.Controls.Add(labelBaseTexture);
            groupBoxVideo.Controls.Add(labelFlushValue);
            groupBoxVideo.Controls.Add(numericUpDownBaseTexture);
            groupBoxVideo.Controls.Add(numericUpDownFlushValue);
            groupBoxVideo.Controls.Add(numericUpDownLight);
            groupBoxVideo.Controls.Add(labelLight);
            groupBoxVideo.Location = new System.Drawing.Point(6, 62);
            groupBoxVideo.Name = "groupBoxVideo";
            groupBoxVideo.Size = new System.Drawing.Size(250, 231);
            groupBoxVideo.TabIndex = 1;
            groupBoxVideo.TabStop = false;
            // 
            // numericUpDownBaseTexture
            // 
            numericUpDownBaseTexture.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            numericUpDownBaseTexture.Location = new System.Drawing.Point(169, 32);
            numericUpDownBaseTexture.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            numericUpDownBaseTexture.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            numericUpDownBaseTexture.Name = "numericUpDownBaseTexture";
            numericUpDownBaseTexture.Size = new System.Drawing.Size(75, 20);
            numericUpDownBaseTexture.TabIndex = 3;
            numericUpDownBaseTexture.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // numericUpDownFlushValue
            // 
            numericUpDownFlushValue.Location = new System.Drawing.Point(87, 32);
            numericUpDownFlushValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDownFlushValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDownFlushValue.Name = "numericUpDownFlushValue";
            numericUpDownFlushValue.Size = new System.Drawing.Size(75, 20);
            numericUpDownFlushValue.TabIndex = 2;
            numericUpDownFlushValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numericUpDownLight
            // 
            numericUpDownLight.Location = new System.Drawing.Point(6, 32);
            numericUpDownLight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            numericUpDownLight.Name = "numericUpDownLight";
            numericUpDownLight.Size = new System.Drawing.Size(75, 20);
            numericUpDownLight.TabIndex = 1;
            numericUpDownLight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelLight
            // 
            labelLight.AutoSize = true;
            labelLight.Location = new System.Drawing.Point(6, 16);
            labelLight.Name = "labelLight";
            labelLight.Size = new System.Drawing.Size(30, 13);
            labelLight.TabIndex = 0;
            labelLight.Text = "Light";
            // 
            // groupBoxResolution
            // 
            groupBoxResolution.Controls.Add(comboBoxScreenHeight);
            groupBoxResolution.Controls.Add(comboBoxScreenWidth);
            groupBoxResolution.Location = new System.Drawing.Point(6, 6);
            groupBoxResolution.Name = "groupBoxResolution";
            groupBoxResolution.Size = new System.Drawing.Size(250, 50);
            groupBoxResolution.TabIndex = 0;
            groupBoxResolution.TabStop = false;
            groupBoxResolution.Text = "Resolution";
            // 
            // comboBoxScreenHeight
            // 
            comboBoxScreenHeight.AutoCompleteCustomSource.AddRange(new string[] {
            "480",
            "600",
            "768",
            "1024"});
            comboBoxScreenHeight.FormattingEnabled = true;
            comboBoxScreenHeight.Items.AddRange(new object[] {
            "480",
            "600",
            "768",
            "1024",
            "720",
            "768",
            "900",
            "1080"});
            comboBoxScreenHeight.Location = new System.Drawing.Point(128, 19);
            comboBoxScreenHeight.Name = "comboBoxScreenHeight";
            comboBoxScreenHeight.Size = new System.Drawing.Size(116, 21);
            comboBoxScreenHeight.TabIndex = 1;
            comboBoxScreenHeight.SelectedIndexChanged += new System.EventHandler(comboBoxScreenHeight_SelectedIndexChanged);
            // 
            // comboBoxScreenWidth
            // 
            comboBoxScreenWidth.AutoCompleteCustomSource.AddRange(new string[] {
            "640",
            "800",
            "1024",
            "1024",
            "1280",
            "1360",
            "1600",
            "1920"});
            comboBoxScreenWidth.FormattingEnabled = true;
            comboBoxScreenWidth.Items.AddRange(new object[] {
            "640",
            "800",
            "1024",
            "1280",
            "1280",
            "1366",
            "1600",
            "1920"});
            comboBoxScreenWidth.Location = new System.Drawing.Point(6, 19);
            comboBoxScreenWidth.Name = "comboBoxScreenWidth";
            comboBoxScreenWidth.Size = new System.Drawing.Size(116, 21);
            comboBoxScreenWidth.TabIndex = 0;
            comboBoxScreenWidth.SelectedIndexChanged += new System.EventHandler(comboBoxScreenWidth_SelectedIndexChanged);
            comboBoxScreenWidth.SelectedIndex = 2;
            // 
            // pageSound
            // 
            pageSound.Controls.Add(groupBoxVolume);
            pageSound.Location = new System.Drawing.Point(4, 22);
            pageSound.Name = "pageSound";
            pageSound.Padding = new Padding(3);
            pageSound.Size = new System.Drawing.Size(262, 299);
            pageSound.TabIndex = 5;
            pageSound.Text = "Sound";
            pageSound.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            buttonPlay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonPlay.Location = new System.Drawing.Point(4, 331);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new System.Drawing.Size(82, 28);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonSave.Location = new System.Drawing.Point(96, 331);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(82, 28);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonExit.Location = new System.Drawing.Point(188, 331);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(82, 28);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelFlushValue
            // 
            labelFlushValue.AutoSize = true;
            labelFlushValue.Location = new System.Drawing.Point(84, 16);
            labelFlushValue.Name = "labelFlushValue";
            labelFlushValue.Size = new System.Drawing.Size(71, 13);
            labelFlushValue.TabIndex = 4;
            labelFlushValue.Text = "Cache sprites";
            // 
            // labelBaseTexture
            // 
            labelBaseTexture.AutoSize = true;
            labelBaseTexture.Location = new System.Drawing.Point(171, 16);
            labelBaseTexture.Name = "labelBaseTexture";
            labelBaseTexture.Size = new System.Drawing.Size(64, 13);
            labelBaseTexture.TabIndex = 5;
            labelBaseTexture.Text = "Texture size";
            // 
            // labelMultiSampling
            // 
            labelMultiSampling.AutoSize = true;
            labelMultiSampling.Location = new System.Drawing.Point(16, 69);
            labelMultiSampling.Name = "labelMultiSampling";
            labelMultiSampling.Size = new System.Drawing.Size(85, 13);
            labelMultiSampling.TabIndex = 6;
            labelMultiSampling.Text = "Multisampling 3d";
            // 
            // comboBoxMultiSampling
            // 
            comboBoxMultiSampling.Items.AddRange(new object[] {
            "Auto",
            "Disable",
            "NonMaskable",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x",
            "13x",
            "14x",
            "15x",
            "16x"});
            comboBoxMultiSampling.FormattingEnabled = true;
            comboBoxMultiSampling.SelectedIndex = 1;
            comboBoxMultiSampling.Location = new System.Drawing.Point(128, 66);
            comboBoxMultiSampling.Name = "comboBoxMultiSampling";
            comboBoxMultiSampling.Size = new System.Drawing.Size(116, 21);
            comboBoxMultiSampling.TabIndex = 2;
            // 
            // labelAnimation3dFPS
            // 
            labelAnimation3dFPS.AutoSize = true;
            labelAnimation3dFPS.Location = new System.Drawing.Point(20, 105);
            labelAnimation3dFPS.Name = "labelAnimation3dFPS";
            labelAnimation3dFPS.Size = new System.Drawing.Size(42, 13);
            labelAnimation3dFPS.TabIndex = 7;
            labelAnimation3dFPS.Text = "3d FPS";
            // 
            // numericUpDownAnimation3dFPS
            // 
            numericUpDownAnimation3dFPS.Location = new System.Drawing.Point(6, 125);
            numericUpDownAnimation3dFPS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDownAnimation3dFPS.Name = "numericUpDownAnimation3dFPS";
            numericUpDownAnimation3dFPS.Size = new System.Drawing.Size(75, 20);
            numericUpDownAnimation3dFPS.TabIndex = 8;
            // 
            // numericUpDownAnimation3dSmoothTime
            // 
            numericUpDownAnimation3dSmoothTime.Location = new System.Drawing.Point(6, 190);
            numericUpDownAnimation3dSmoothTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDownAnimation3dSmoothTime.Name = "numericUpDownAnimation3dSmoothTime";
            numericUpDownAnimation3dSmoothTime.Size = new System.Drawing.Size(75, 20);
            numericUpDownAnimation3dSmoothTime.TabIndex = 9;
            // 
            // labelAnimation3dSmoothTime
            // 
            labelAnimation3dSmoothTime.AutoSize = true;
            labelAnimation3dSmoothTime.Location = new System.Drawing.Point(16, 152);
            labelAnimation3dSmoothTime.Name = "labelAnimation3dSmoothTime";
            labelAnimation3dSmoothTime.Size = new System.Drawing.Size(56, 26);
            labelAnimation3dSmoothTime.TabIndex = 10;
            labelAnimation3dSmoothTime.Text = "3d smooth\r\ntransition";
            // 
            // checkBoxFullScreen
            // 
            checkBoxFullScreen.AutoSize = true;
            checkBoxFullScreen.Checked = true;
            checkBoxFullScreen.CheckState = CheckState.Checked;
            checkBoxFullScreen.Location = new System.Drawing.Point(128, 105);
            checkBoxFullScreen.Name = "checkBoxFullScreen";
            checkBoxFullScreen.Size = new System.Drawing.Size(74, 17);
            checkBoxFullScreen.TabIndex = 11;
            checkBoxFullScreen.Text = "Fullscreen";
            checkBoxFullScreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxVSync
            // 
            checkBoxVSync.AutoSize = true;
            checkBoxVSync.Location = new System.Drawing.Point(128, 128);
            checkBoxVSync.Name = "checkBoxVSync";
            checkBoxVSync.Size = new System.Drawing.Size(57, 17);
            checkBoxVSync.TabIndex = 12;
            checkBoxVSync.Text = "VSync";
            checkBoxVSync.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlwaysOnTop
            // 
            checkBoxAlwaysOnTop.AutoSize = true;
            checkBoxAlwaysOnTop.Location = new System.Drawing.Point(128, 151);
            checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            checkBoxAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            checkBoxAlwaysOnTop.TabIndex = 13;
            checkBoxAlwaysOnTop.Text = "Always on top";
            checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // labelFixedFPS
            // 
            labelFixedFPS.AutoSize = true;
            labelFixedFPS.Location = new System.Drawing.Point(123, 184);
            labelFixedFPS.Name = "labelFixedFPS";
            labelFixedFPS.Size = new System.Drawing.Size(32, 26);
            labelFixedFPS.TabIndex = 14;
            labelFixedFPS.Text = "Fixed\r\nFPS";
            // 
            // numericUpDownFixedFPS
            // 
            numericUpDownFixedFPS.Location = new System.Drawing.Point(169, 190);
            numericUpDownFixedFPS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            numericUpDownFixedFPS.Name = "numericUpDownFixedFPS";
            numericUpDownFixedFPS.Size = new System.Drawing.Size(75, 20);
            numericUpDownFixedFPS.TabIndex = 15;
            numericUpDownFixedFPS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(labelSoundVolume);
            groupBoxVolume.Controls.Add(trackBarSoundVolume);
            groupBoxVolume.Controls.Add(labelMusicVolume);
            groupBoxVolume.Controls.Add(trackBarMusicVolume);
            groupBoxVolume.Location = new System.Drawing.Point(6, 6);
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.Size = new System.Drawing.Size(250, 287);
            groupBoxVolume.TabIndex = 0;
            groupBoxVolume.TabStop = false;
            groupBoxVolume.Text = "Volume";
            // 
            // trackBarMusicVolume
            // 
            trackBarMusicVolume.BackColor = System.Drawing.SystemColors.Window;
            trackBarMusicVolume.Location = new System.Drawing.Point(6, 37);
            trackBarMusicVolume.Maximum = 100;
            trackBarMusicVolume.Name = "trackBarMusicVolume";
            trackBarMusicVolume.Size = new System.Drawing.Size(238, 45);
            trackBarMusicVolume.TabIndex = 0;
            trackBarMusicVolume.TickFrequency = 10;
            trackBarMusicVolume.Value = 75;
            // 
            // labelMusicVolume
            // 
            labelMusicVolume.AutoSize = true;
            labelMusicVolume.Location = new System.Drawing.Point(10, 18);
            labelMusicVolume.Name = "labelMusicVolume";
            labelMusicVolume.Size = new System.Drawing.Size(35, 13);
            labelMusicVolume.TabIndex = 1;
            labelMusicVolume.Text = "Music";
            // 
            // labelSoundVolume
            // 
            labelSoundVolume.AutoSize = true;
            labelSoundVolume.Location = new System.Drawing.Point(10, 86);
            labelSoundVolume.Name = "labelSoundVolume";
            labelSoundVolume.Size = new System.Drawing.Size(38, 13);
            labelSoundVolume.TabIndex = 3;
            labelSoundVolume.Text = "Sound";
            // 
            // trackBarSoundVolume
            // 
            trackBarSoundVolume.BackColor = System.Drawing.SystemColors.Window;
            trackBarSoundVolume.Location = new System.Drawing.Point(6, 105);
            trackBarSoundVolume.Maximum = 100;
            trackBarSoundVolume.Name = "trackBarSoundVolume";
            trackBarSoundVolume.Size = new System.Drawing.Size(238, 45);
            trackBarSoundVolume.TabIndex = 2;
            trackBarSoundVolume.TickFrequency = 10;
            trackBarSoundVolume.Value = 75;
            // 
            // FOConfigForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(277, 364);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(buttonPlay);
            Controls.Add(tabControlMainContent);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "FOConfigForm";
            Text = "FOnline configurator";
            tabControlMainContent.ResumeLayout(false);
            pageOther.ResumeLayout(false);
            groupBoxMisk.ResumeLayout(false);
            groupBoxMisk.PerformLayout();
            groupBoxLanguage.ResumeLayout(false);
            pageGame.ResumeLayout(false);
            groupBoxGame.ResumeLayout(false);
            groupBoxGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownTextDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownScrollStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownScrollDelay)).EndInit();
            pageCombat.ResumeLayout(false);
            groupBoxDamageHitDelay.ResumeLayout(false);
            groupBoxDamageHitDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownDamageHitDelay)).EndInit();
            groupBoxCombatMessagesType.ResumeLayout(false);
            groupBoxCombatMessagesType.PerformLayout();
            groupBoxIndicatorType.ResumeLayout(false);
            groupBoxIndicatorType.PerformLayout();
            groupBoxDefaultCombatMode.ResumeLayout(false);
            groupBoxDefaultCombatMode.PerformLayout();
            pageNet.ResumeLayout(false);
            groupBoxProxy.ResumeLayout(false);
            groupBoxProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownProxyPort)).EndInit();
            groupBoxGameServer.ResumeLayout(false);
            groupBoxGameServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownRemotePort)).EndInit();
            pageVideo.ResumeLayout(false);
            groupBoxVideo.ResumeLayout(false);
            groupBoxVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownBaseTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownFlushValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownLight)).EndInit();
            groupBoxResolution.ResumeLayout(false);
            pageSound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(numericUpDownAnimation3dFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownAnimation3dSmoothTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownFixedFPS)).EndInit();
            groupBoxVolume.ResumeLayout(false);
            groupBoxVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(trackBarMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(trackBarSoundVolume)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMainContent;
        private TabPage pageOther;
        private TabPage pageGame;
        private TabPage pageCombat;
        private TabPage pageNet;
        private TabPage pageVideo;
        private TabPage pageSound;
        private GroupBox groupBoxLanguage;
        private ComboBox comboBoxLanguage;
        private GroupBox groupBoxMisk;
        private CheckBox checkBoxLoggingTime;
        private CheckBox checkBoxLogging;
        private CheckBox checkBoxInvertMessBox;
        private CheckBox checkBoxSoundNotify;
        private CheckBox checkBoxWinNotify;
        private GroupBox groupBoxGame;
        private NumericUpDown numericUpDownScrollStep;
        private NumericUpDown numericUpDownScrollDelay;
        private Label labelTextDelay;
        private Label labelScrollStep;
        private Label labelScrollDelay;
        private NumericUpDown numericUpDownTextDelay;
        private CheckBox checkBoxAlwaysRun;
        private GroupBox groupBoxDefaultCombatMode;
        private RadioButton radioButtonCombatTurnBased;
        private RadioButton radioButtonCombatRealTime;
        private RadioButton radioButtonCombatBoth;
        private GroupBox groupBoxCombatMessagesType;
        private RadioButton radioButtonMessagesBrief;
        private RadioButton radioButtonMessagesVerbose;
        private GroupBox groupBoxIndicatorType;
        private RadioButton radioButtonIndicatorNumbers;
        private RadioButton radioButtonIndicatorLines;
        private RadioButton radioButtonIndicatorBoth;
        private GroupBox groupBoxDamageHitDelay;
        private NumericUpDown numericUpDownDamageHitDelay;
        private Label labelDamageHitDelay;
        private GroupBox groupBoxGameServer;
        private Button buttonPlay;
        private Button buttonSave;
        private Button buttonExit;
        private GroupBox groupBoxProxy;
        private TextBox textBoxProxyPass;
        private TextBox textBoxProxyUser;
        private Label labelProxyPass;
        private Label labelProxyUser;
        private NumericUpDown numericUpDownProxyPort;
        private ComboBox comboBoxProxyHost;
        private Label labelProxyPort;
        private Label labelProxyHost;
        private RadioButton radioButtonProxyTypeHttp;
        private RadioButton radioButtonProxyTypeSocks5;
        private RadioButton radioButtonProxyTypeSocks4;
        private RadioButton radioButtonProxyTypeNone;
        private Label labelType;
        private NumericUpDown numericUpDownRemotePort;
        private ComboBox comboBoxRemoteHost;
        private Label labelRemotePort;
        private Label labelRemoteHost;
        private GroupBox groupBoxResolution;
        private ComboBox comboBoxScreenHeight;
        private ComboBox comboBoxScreenWidth;
        private GroupBox groupBoxVideo;
        private Label labelLight;
        private NumericUpDown numericUpDownBaseTexture;
        private NumericUpDown numericUpDownFlushValue;
        private NumericUpDown numericUpDownLight;
        private Label labelBaseTexture;
        private Label labelFlushValue;
        private NumericUpDown numericUpDownFixedFPS;
        private Label labelFixedFPS;
        private CheckBox checkBoxAlwaysOnTop;
        private CheckBox checkBoxVSync;
        private CheckBox checkBoxFullScreen;
        private Label labelAnimation3dSmoothTime;
        private NumericUpDown numericUpDownAnimation3dSmoothTime;
        private NumericUpDown numericUpDownAnimation3dFPS;
        private Label labelAnimation3dFPS;
        private ComboBox comboBoxMultiSampling;
        private Label labelMultiSampling;
        private GroupBox groupBoxVolume;
        private Label labelSoundVolume;
        private TrackBar trackBarSoundVolume;
        private Label labelMusicVolume;
        private TrackBar trackBarMusicVolume;
    }
}