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
            this.tabControlMainContent = new System.Windows.Forms.TabControl();
            this.pageOther = new System.Windows.Forms.TabPage();
            this.groupBoxMisk = new System.Windows.Forms.GroupBox();
            this.checkBoxLoggingTime = new System.Windows.Forms.CheckBox();
            this.checkBoxLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxInvertMessBox = new System.Windows.Forms.CheckBox();
            this.checkBoxSoundNotify = new System.Windows.Forms.CheckBox();
            this.checkBoxWinNotify = new System.Windows.Forms.CheckBox();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.pageGame = new System.Windows.Forms.TabPage();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.checkBoxAlwaysRun = new System.Windows.Forms.CheckBox();
            this.numericUpDownTextDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScrollStep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScrollDelay = new System.Windows.Forms.NumericUpDown();
            this.labelTextDelay = new System.Windows.Forms.Label();
            this.labelScrollStep = new System.Windows.Forms.Label();
            this.labelScrollDelay = new System.Windows.Forms.Label();
            this.pageCombat = new System.Windows.Forms.TabPage();
            this.groupBoxDamageHitDelay = new System.Windows.Forms.GroupBox();
            this.numericUpDownDamageHitDelay = new System.Windows.Forms.NumericUpDown();
            this.labelDamageHitDelay = new System.Windows.Forms.Label();
            this.groupBoxCombatMessagesType = new System.Windows.Forms.GroupBox();
            this.radioButtonMessagesBrief = new System.Windows.Forms.RadioButton();
            this.radioButtonMessagesVerbose = new System.Windows.Forms.RadioButton();
            this.groupBoxIndicatorType = new System.Windows.Forms.GroupBox();
            this.radioButtonIndicatorNumbers = new System.Windows.Forms.RadioButton();
            this.radioButtonIndicatorLines = new System.Windows.Forms.RadioButton();
            this.radioButtonIndicatorBoth = new System.Windows.Forms.RadioButton();
            this.groupBoxDefaultCombatMode = new System.Windows.Forms.GroupBox();
            this.radioButtonCombatTurnBased = new System.Windows.Forms.RadioButton();
            this.radioButtonCombatRealTime = new System.Windows.Forms.RadioButton();
            this.radioButtonCombatBoth = new System.Windows.Forms.RadioButton();
            this.pageNet = new System.Windows.Forms.TabPage();
            this.groupBoxProxy = new System.Windows.Forms.GroupBox();
            this.textBoxProxyPass = new System.Windows.Forms.TextBox();
            this.textBoxProxyUser = new System.Windows.Forms.TextBox();
            this.labelProxyPass = new System.Windows.Forms.Label();
            this.labelProxyUser = new System.Windows.Forms.Label();
            this.numericUpDownProxyPort = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProxyHost = new System.Windows.Forms.ComboBox();
            this.labelProxyPort = new System.Windows.Forms.Label();
            this.labelProxyHost = new System.Windows.Forms.Label();
            this.radioButtonProxyTypeHttp = new System.Windows.Forms.RadioButton();
            this.radioButtonProxyTypeSocks5 = new System.Windows.Forms.RadioButton();
            this.radioButtonProxyTypeSocks4 = new System.Windows.Forms.RadioButton();
            this.radioButtonProxyTypeNone = new System.Windows.Forms.RadioButton();
            this.labelType = new System.Windows.Forms.Label();
            this.groupBoxGameServer = new System.Windows.Forms.GroupBox();
            this.numericUpDownRemotePort = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRemoteHost = new System.Windows.Forms.ComboBox();
            this.labelRemotePort = new System.Windows.Forms.Label();
            this.labelRemoteHost = new System.Windows.Forms.Label();
            this.pageVideo = new System.Windows.Forms.TabPage();
            this.groupBoxVideo = new System.Windows.Forms.GroupBox();
            this.numericUpDownFixedFPS = new System.Windows.Forms.NumericUpDown();
            this.labelFixedFPS = new System.Windows.Forms.Label();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxVSync = new System.Windows.Forms.CheckBox();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.labelAnimation3dSmoothTime = new System.Windows.Forms.Label();
            this.numericUpDownAnimation3dSmoothTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnimation3dFPS = new System.Windows.Forms.NumericUpDown();
            this.labelAnimation3dFPS = new System.Windows.Forms.Label();
            this.comboBoxMultiSampling = new System.Windows.Forms.ComboBox();
            this.labelMultiSampling = new System.Windows.Forms.Label();
            this.labelBaseTexture = new System.Windows.Forms.Label();
            this.labelFlushValue = new System.Windows.Forms.Label();
            this.numericUpDownBaseTexture = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFlushValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLight = new System.Windows.Forms.NumericUpDown();
            this.labelLight = new System.Windows.Forms.Label();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.comboBoxScreenHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxScreenWidth = new System.Windows.Forms.ComboBox();
            this.pageSound = new System.Windows.Forms.TabPage();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.labelSoundVolume = new System.Windows.Forms.Label();
            this.trackBarSoundVolume = new System.Windows.Forms.TrackBar();
            this.labelMusicVolume = new System.Windows.Forms.Label();
            this.trackBarMusicVolume = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlMainContent.SuspendLayout();
            this.pageOther.SuspendLayout();
            this.groupBoxMisk.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.pageGame.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScrollStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScrollDelay)).BeginInit();
            this.pageCombat.SuspendLayout();
            this.groupBoxDamageHitDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDamageHitDelay)).BeginInit();
            this.groupBoxCombatMessagesType.SuspendLayout();
            this.groupBoxIndicatorType.SuspendLayout();
            this.groupBoxDefaultCombatMode.SuspendLayout();
            this.pageNet.SuspendLayout();
            this.groupBoxProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProxyPort)).BeginInit();
            this.groupBoxGameServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemotePort)).BeginInit();
            this.pageVideo.SuspendLayout();
            this.groupBoxVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFixedFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimation3dSmoothTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimation3dFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlushValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLight)).BeginInit();
            this.groupBoxResolution.SuspendLayout();
            this.pageSound.SuspendLayout();
            this.groupBoxVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMainContent
            // 
            this.tabControlMainContent.Controls.Add(this.pageOther);
            this.tabControlMainContent.Controls.Add(this.pageGame);
            this.tabControlMainContent.Controls.Add(this.pageCombat);
            this.tabControlMainContent.Controls.Add(this.pageNet);
            this.tabControlMainContent.Controls.Add(this.pageVideo);
            this.tabControlMainContent.Controls.Add(this.pageSound);
            this.tabControlMainContent.Location = new System.Drawing.Point(4, 4);
            this.tabControlMainContent.Name = "tabControlMainContent";
            this.tabControlMainContent.SelectedIndex = 0;
            this.tabControlMainContent.Size = new System.Drawing.Size(270, 325);
            this.tabControlMainContent.TabIndex = 0;
            // 
            // pageOther
            // 
            this.pageOther.Controls.Add(this.groupBoxMisk);
            this.pageOther.Controls.Add(this.groupBoxLanguage);
            this.pageOther.Location = new System.Drawing.Point(4, 22);
            this.pageOther.Name = "pageOther";
            this.pageOther.Padding = new System.Windows.Forms.Padding(3);
            this.pageOther.Size = new System.Drawing.Size(262, 299);
            this.pageOther.TabIndex = 0;
            this.pageOther.Text = "Other";
            this.pageOther.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisk
            // 
            this.groupBoxMisk.Controls.Add(this.checkBoxLoggingTime);
            this.groupBoxMisk.Controls.Add(this.checkBoxLogging);
            this.groupBoxMisk.Controls.Add(this.checkBoxInvertMessBox);
            this.groupBoxMisk.Controls.Add(this.checkBoxSoundNotify);
            this.groupBoxMisk.Controls.Add(this.checkBoxWinNotify);
            this.groupBoxMisk.Location = new System.Drawing.Point(6, 69);
            this.groupBoxMisk.Name = "groupBoxMisk";
            this.groupBoxMisk.Size = new System.Drawing.Size(250, 224);
            this.groupBoxMisk.TabIndex = 1;
            this.groupBoxMisk.TabStop = false;
            // 
            // checkBoxLoggingTime
            // 
            this.checkBoxLoggingTime.AutoSize = true;
            this.checkBoxLoggingTime.Location = new System.Drawing.Point(6, 151);
            this.checkBoxLoggingTime.Name = "checkBoxLoggingTime";
            this.checkBoxLoggingTime.Size = new System.Drawing.Size(111, 17);
            this.checkBoxLoggingTime.TabIndex = 4;
            this.checkBoxLoggingTime.Text = "Logging with time.";
            this.checkBoxLoggingTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogging
            // 
            this.checkBoxLogging.AutoSize = true;
            this.checkBoxLogging.Checked = true;
            this.checkBoxLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogging.Location = new System.Drawing.Point(6, 128);
            this.checkBoxLogging.Name = "checkBoxLogging";
            this.checkBoxLogging.Size = new System.Drawing.Size(136, 17);
            this.checkBoxLogging.TabIndex = 3;
            this.checkBoxLogging.Text = "Logging in \'Fonline.log\'.";
            this.checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvertMessBox
            // 
            this.checkBoxInvertMessBox.AutoSize = true;
            this.checkBoxInvertMessBox.Location = new System.Drawing.Point(6, 92);
            this.checkBoxInvertMessBox.Name = "checkBoxInvertMessBox";
            this.checkBoxInvertMessBox.Size = new System.Drawing.Size(81, 30);
            this.checkBoxInvertMessBox.TabIndex = 2;
            this.checkBoxInvertMessBox.Text = "Invert text\r\nin messbox.";
            this.checkBoxInvertMessBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxSoundNotify
            // 
            this.checkBoxSoundNotify.AutoSize = true;
            this.checkBoxSoundNotify.Location = new System.Drawing.Point(6, 56);
            this.checkBoxSoundNotify.Name = "checkBoxSoundNotify";
            this.checkBoxSoundNotify.Size = new System.Drawing.Size(105, 30);
            this.checkBoxSoundNotify.TabIndex = 1;
            this.checkBoxSoundNotify.Text = "Beep sound on\r\nnot active game.";
            this.checkBoxSoundNotify.UseVisualStyleBackColor = true;
            // 
            // checkBoxWinNotify
            // 
            this.checkBoxWinNotify.AutoSize = true;
            this.checkBoxWinNotify.Checked = true;
            this.checkBoxWinNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWinNotify.Location = new System.Drawing.Point(6, 20);
            this.checkBoxWinNotify.Name = "checkBoxWinNotify";
            this.checkBoxWinNotify.Size = new System.Drawing.Size(105, 30);
            this.checkBoxWinNotify.TabIndex = 0;
            this.checkBoxWinNotify.Text = "Flush window on\r\nnot active game.";
            this.checkBoxWinNotify.UseVisualStyleBackColor = true;
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.comboBoxLanguage);
            this.groupBoxLanguage.Location = new System.Drawing.Point(6, 6);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(250, 57);
            this.groupBoxLanguage.TabIndex = 0;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Language \\  Язык";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(6, 19);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(168, 21);
            this.comboBoxLanguage.TabIndex = 0;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // pageGame
            // 
            this.pageGame.Controls.Add(this.groupBoxGame);
            this.pageGame.Location = new System.Drawing.Point(4, 22);
            this.pageGame.Name = "pageGame";
            this.pageGame.Padding = new System.Windows.Forms.Padding(3);
            this.pageGame.Size = new System.Drawing.Size(262, 299);
            this.pageGame.TabIndex = 1;
            this.pageGame.Text = "Game";
            this.pageGame.UseVisualStyleBackColor = true;
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.checkBoxAlwaysRun);
            this.groupBoxGame.Controls.Add(this.numericUpDownTextDelay);
            this.groupBoxGame.Controls.Add(this.numericUpDownScrollStep);
            this.groupBoxGame.Controls.Add(this.numericUpDownScrollDelay);
            this.groupBoxGame.Controls.Add(this.labelTextDelay);
            this.groupBoxGame.Controls.Add(this.labelScrollStep);
            this.groupBoxGame.Controls.Add(this.labelScrollDelay);
            this.groupBoxGame.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(250, 287);
            this.groupBoxGame.TabIndex = 1;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // checkBoxAlwaysRun
            // 
            this.checkBoxAlwaysRun.AutoSize = true;
            this.checkBoxAlwaysRun.Checked = true;
            this.checkBoxAlwaysRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlwaysRun.Location = new System.Drawing.Point(6, 94);
            this.checkBoxAlwaysRun.Name = "checkBoxAlwaysRun";
            this.checkBoxAlwaysRun.Size = new System.Drawing.Size(77, 17);
            this.checkBoxAlwaysRun.TabIndex = 6;
            this.checkBoxAlwaysRun.Text = "Always run";
            this.checkBoxAlwaysRun.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTextDelay
            // 
            this.numericUpDownTextDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTextDelay.Location = new System.Drawing.Point(160, 66);
            this.numericUpDownTextDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownTextDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTextDelay.Name = "numericUpDownTextDelay";
            this.numericUpDownTextDelay.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownTextDelay.TabIndex = 5;
            this.numericUpDownTextDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // numericUpDownScrollStep
            // 
            this.numericUpDownScrollStep.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownScrollStep.Location = new System.Drawing.Point(160, 40);
            this.numericUpDownScrollStep.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownScrollStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScrollStep.Name = "numericUpDownScrollStep";
            this.numericUpDownScrollStep.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownScrollStep.TabIndex = 4;
            this.numericUpDownScrollStep.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownScrollDelay
            // 
            this.numericUpDownScrollDelay.Location = new System.Drawing.Point(160, 14);
            this.numericUpDownScrollDelay.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownScrollDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScrollDelay.Name = "numericUpDownScrollDelay";
            this.numericUpDownScrollDelay.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownScrollDelay.TabIndex = 3;
            this.numericUpDownScrollDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelTextDelay
            // 
            this.labelTextDelay.AutoSize = true;
            this.labelTextDelay.Location = new System.Drawing.Point(6, 68);
            this.labelTextDelay.Name = "labelTextDelay";
            this.labelTextDelay.Size = new System.Drawing.Size(78, 13);
            this.labelTextDelay.TabIndex = 2;
            this.labelTextDelay.Text = "Text delay (ms)";
            // 
            // labelScrollStep
            // 
            this.labelScrollStep.AutoSize = true;
            this.labelScrollStep.Location = new System.Drawing.Point(6, 42);
            this.labelScrollStep.Name = "labelScrollStep";
            this.labelScrollStep.Size = new System.Drawing.Size(56, 13);
            this.labelScrollStep.TabIndex = 1;
            this.labelScrollStep.Text = "Scroll step";
            // 
            // labelScrollDelay
            // 
            this.labelScrollDelay.AutoSize = true;
            this.labelScrollDelay.Location = new System.Drawing.Point(6, 16);
            this.labelScrollDelay.Name = "labelScrollDelay";
            this.labelScrollDelay.Size = new System.Drawing.Size(61, 13);
            this.labelScrollDelay.TabIndex = 0;
            this.labelScrollDelay.Text = "Scroll delay";
            // 
            // pageCombat
            // 
            this.pageCombat.Controls.Add(this.groupBoxDamageHitDelay);
            this.pageCombat.Controls.Add(this.groupBoxCombatMessagesType);
            this.pageCombat.Controls.Add(this.groupBoxIndicatorType);
            this.pageCombat.Controls.Add(this.groupBoxDefaultCombatMode);
            this.pageCombat.Location = new System.Drawing.Point(4, 22);
            this.pageCombat.Name = "pageCombat";
            this.pageCombat.Padding = new System.Windows.Forms.Padding(3);
            this.pageCombat.Size = new System.Drawing.Size(262, 299);
            this.pageCombat.TabIndex = 2;
            this.pageCombat.Text = "Combat";
            this.pageCombat.UseVisualStyleBackColor = true;
            // 
            // groupBoxDamageHitDelay
            // 
            this.groupBoxDamageHitDelay.Controls.Add(this.numericUpDownDamageHitDelay);
            this.groupBoxDamageHitDelay.Controls.Add(this.labelDamageHitDelay);
            this.groupBoxDamageHitDelay.Location = new System.Drawing.Point(7, 254);
            this.groupBoxDamageHitDelay.Name = "groupBoxDamageHitDelay";
            this.groupBoxDamageHitDelay.Size = new System.Drawing.Size(250, 39);
            this.groupBoxDamageHitDelay.TabIndex = 5;
            this.groupBoxDamageHitDelay.TabStop = false;
            this.groupBoxDamageHitDelay.Text = "Damage indication on head";
            // 
            // numericUpDownDamageHitDelay
            // 
            this.numericUpDownDamageHitDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDamageHitDelay.Location = new System.Drawing.Point(159, 14);
            this.numericUpDownDamageHitDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownDamageHitDelay.Name = "numericUpDownDamageHitDelay";
            this.numericUpDownDamageHitDelay.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownDamageHitDelay.TabIndex = 7;
            this.numericUpDownDamageHitDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelDamageHitDelay
            // 
            this.labelDamageHitDelay.AutoSize = true;
            this.labelDamageHitDelay.Location = new System.Drawing.Point(6, 16);
            this.labelDamageHitDelay.Name = "labelDamageHitDelay";
            this.labelDamageHitDelay.Size = new System.Drawing.Size(56, 13);
            this.labelDamageHitDelay.TabIndex = 6;
            this.labelDamageHitDelay.Text = "Delay (ms)";
            // 
            // groupBoxCombatMessagesType
            // 
            this.groupBoxCombatMessagesType.Controls.Add(this.radioButtonMessagesBrief);
            this.groupBoxCombatMessagesType.Controls.Add(this.radioButtonMessagesVerbose);
            this.groupBoxCombatMessagesType.Location = new System.Drawing.Point(6, 200);
            this.groupBoxCombatMessagesType.Name = "groupBoxCombatMessagesType";
            this.groupBoxCombatMessagesType.Size = new System.Drawing.Size(250, 47);
            this.groupBoxCombatMessagesType.TabIndex = 4;
            this.groupBoxCombatMessagesType.TabStop = false;
            this.groupBoxCombatMessagesType.Text = "Ammo amount display";
            // 
            // radioButtonMessagesBrief
            // 
            this.radioButtonMessagesBrief.AutoSize = true;
            this.radioButtonMessagesBrief.Checked = true;
            this.radioButtonMessagesBrief.Location = new System.Drawing.Point(93, 19);
            this.radioButtonMessagesBrief.Name = "radioButtonMessagesBrief";
            this.radioButtonMessagesBrief.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMessagesBrief.TabIndex = 1;
            this.radioButtonMessagesBrief.TabStop = true;
            this.radioButtonMessagesBrief.Text = "Brief";
            this.radioButtonMessagesBrief.UseVisualStyleBackColor = true;
            // 
            // radioButtonMessagesVerbose
            // 
            this.radioButtonMessagesVerbose.AutoSize = true;
            this.radioButtonMessagesVerbose.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMessagesVerbose.Name = "radioButtonMessagesVerbose";
            this.radioButtonMessagesVerbose.Size = new System.Drawing.Size(64, 17);
            this.radioButtonMessagesVerbose.TabIndex = 0;
            this.radioButtonMessagesVerbose.Text = "Verbose";
            this.radioButtonMessagesVerbose.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndicatorType
            // 
            this.groupBoxIndicatorType.Controls.Add(this.radioButtonIndicatorNumbers);
            this.groupBoxIndicatorType.Controls.Add(this.radioButtonIndicatorLines);
            this.groupBoxIndicatorType.Controls.Add(this.radioButtonIndicatorBoth);
            this.groupBoxIndicatorType.Location = new System.Drawing.Point(6, 103);
            this.groupBoxIndicatorType.Name = "groupBoxIndicatorType";
            this.groupBoxIndicatorType.Size = new System.Drawing.Size(250, 91);
            this.groupBoxIndicatorType.TabIndex = 3;
            this.groupBoxIndicatorType.TabStop = false;
            this.groupBoxIndicatorType.Text = "Ammo amount display";
            // 
            // radioButtonIndicatorNumbers
            // 
            this.radioButtonIndicatorNumbers.AutoSize = true;
            this.radioButtonIndicatorNumbers.Location = new System.Drawing.Point(6, 65);
            this.radioButtonIndicatorNumbers.Name = "radioButtonIndicatorNumbers";
            this.radioButtonIndicatorNumbers.Size = new System.Drawing.Size(67, 17);
            this.radioButtonIndicatorNumbers.TabIndex = 2;
            this.radioButtonIndicatorNumbers.Text = "Numbers";
            this.radioButtonIndicatorNumbers.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndicatorLines
            // 
            this.radioButtonIndicatorLines.AutoSize = true;
            this.radioButtonIndicatorLines.Location = new System.Drawing.Point(6, 42);
            this.radioButtonIndicatorLines.Name = "radioButtonIndicatorLines";
            this.radioButtonIndicatorLines.Size = new System.Drawing.Size(50, 17);
            this.radioButtonIndicatorLines.TabIndex = 1;
            this.radioButtonIndicatorLines.Text = "Lines";
            this.radioButtonIndicatorLines.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndicatorBoth
            // 
            this.radioButtonIndicatorBoth.AutoSize = true;
            this.radioButtonIndicatorBoth.Checked = true;
            this.radioButtonIndicatorBoth.Location = new System.Drawing.Point(6, 19);
            this.radioButtonIndicatorBoth.Name = "radioButtonIndicatorBoth";
            this.radioButtonIndicatorBoth.Size = new System.Drawing.Size(81, 17);
            this.radioButtonIndicatorBoth.TabIndex = 0;
            this.radioButtonIndicatorBoth.TabStop = true;
            this.radioButtonIndicatorBoth.Text = "Both modes";
            this.radioButtonIndicatorBoth.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefaultCombatMode
            // 
            this.groupBoxDefaultCombatMode.Controls.Add(this.radioButtonCombatTurnBased);
            this.groupBoxDefaultCombatMode.Controls.Add(this.radioButtonCombatRealTime);
            this.groupBoxDefaultCombatMode.Controls.Add(this.radioButtonCombatBoth);
            this.groupBoxDefaultCombatMode.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDefaultCombatMode.Name = "groupBoxDefaultCombatMode";
            this.groupBoxDefaultCombatMode.Size = new System.Drawing.Size(250, 91);
            this.groupBoxDefaultCombatMode.TabIndex = 0;
            this.groupBoxDefaultCombatMode.TabStop = false;
            this.groupBoxDefaultCombatMode.Text = "Default combat mode";
            // 
            // radioButtonCombatTurnBased
            // 
            this.radioButtonCombatTurnBased.AutoSize = true;
            this.radioButtonCombatTurnBased.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCombatTurnBased.Name = "radioButtonCombatTurnBased";
            this.radioButtonCombatTurnBased.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCombatTurnBased.TabIndex = 2;
            this.radioButtonCombatTurnBased.Text = "Turn-based";
            this.radioButtonCombatTurnBased.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombatRealTime
            // 
            this.radioButtonCombatRealTime.AutoSize = true;
            this.radioButtonCombatRealTime.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCombatRealTime.Name = "radioButtonCombatRealTime";
            this.radioButtonCombatRealTime.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCombatRealTime.TabIndex = 1;
            this.radioButtonCombatRealTime.Text = "Real-time";
            this.radioButtonCombatRealTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombatBoth
            // 
            this.radioButtonCombatBoth.AutoSize = true;
            this.radioButtonCombatBoth.Checked = true;
            this.radioButtonCombatBoth.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCombatBoth.Name = "radioButtonCombatBoth";
            this.radioButtonCombatBoth.Size = new System.Drawing.Size(81, 17);
            this.radioButtonCombatBoth.TabIndex = 0;
            this.radioButtonCombatBoth.TabStop = true;
            this.radioButtonCombatBoth.Text = "Both modes";
            this.radioButtonCombatBoth.UseVisualStyleBackColor = true;
            // 
            // pageNet
            // 
            this.pageNet.Controls.Add(this.groupBoxProxy);
            this.pageNet.Controls.Add(this.groupBoxGameServer);
            this.pageNet.Location = new System.Drawing.Point(4, 22);
            this.pageNet.Name = "pageNet";
            this.pageNet.Padding = new System.Windows.Forms.Padding(3);
            this.pageNet.Size = new System.Drawing.Size(262, 299);
            this.pageNet.TabIndex = 3;
            this.pageNet.Text = "Net";
            this.pageNet.UseVisualStyleBackColor = true;
            // 
            // groupBoxProxy
            // 
            this.groupBoxProxy.Controls.Add(this.textBoxProxyPass);
            this.groupBoxProxy.Controls.Add(this.textBoxProxyUser);
            this.groupBoxProxy.Controls.Add(this.labelProxyPass);
            this.groupBoxProxy.Controls.Add(this.labelProxyUser);
            this.groupBoxProxy.Controls.Add(this.numericUpDownProxyPort);
            this.groupBoxProxy.Controls.Add(this.comboBoxProxyHost);
            this.groupBoxProxy.Controls.Add(this.labelProxyPort);
            this.groupBoxProxy.Controls.Add(this.labelProxyHost);
            this.groupBoxProxy.Controls.Add(this.radioButtonProxyTypeHttp);
            this.groupBoxProxy.Controls.Add(this.radioButtonProxyTypeSocks5);
            this.groupBoxProxy.Controls.Add(this.radioButtonProxyTypeSocks4);
            this.groupBoxProxy.Controls.Add(this.radioButtonProxyTypeNone);
            this.groupBoxProxy.Controls.Add(this.labelType);
            this.groupBoxProxy.Location = new System.Drawing.Point(6, 76);
            this.groupBoxProxy.Name = "groupBoxProxy";
            this.groupBoxProxy.Size = new System.Drawing.Size(250, 217);
            this.groupBoxProxy.TabIndex = 1;
            this.groupBoxProxy.TabStop = false;
            this.groupBoxProxy.Text = "Proxy";
            // 
            // textBoxProxyPass
            // 
            this.textBoxProxyPass.Location = new System.Drawing.Point(6, 151);
            this.textBoxProxyPass.Name = "textBoxProxyPass";
            this.textBoxProxyPass.Size = new System.Drawing.Size(226, 20);
            this.textBoxProxyPass.TabIndex = 16;
            // 
            // textBoxProxyUser
            // 
            this.textBoxProxyUser.Location = new System.Drawing.Point(6, 111);
            this.textBoxProxyUser.Name = "textBoxProxyUser";
            this.textBoxProxyUser.Size = new System.Drawing.Size(226, 20);
            this.textBoxProxyUser.TabIndex = 15;
            // 
            // labelProxyPass
            // 
            this.labelProxyPass.AutoSize = true;
            this.labelProxyPass.Location = new System.Drawing.Point(6, 135);
            this.labelProxyPass.Name = "labelProxyPass";
            this.labelProxyPass.Size = new System.Drawing.Size(53, 13);
            this.labelProxyPass.TabIndex = 14;
            this.labelProxyPass.Text = "Password";
            // 
            // labelProxyUser
            // 
            this.labelProxyUser.AutoSize = true;
            this.labelProxyUser.Location = new System.Drawing.Point(6, 95);
            this.labelProxyUser.Name = "labelProxyUser";
            this.labelProxyUser.Size = new System.Drawing.Size(33, 13);
            this.labelProxyUser.TabIndex = 12;
            this.labelProxyUser.Text = "Login";
            // 
            // numericUpDownProxyPort
            // 
            this.numericUpDownProxyPort.Location = new System.Drawing.Point(176, 70);
            this.numericUpDownProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownProxyPort.Name = "numericUpDownProxyPort";
            this.numericUpDownProxyPort.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownProxyPort.TabIndex = 11;
            this.numericUpDownProxyPort.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // comboBoxProxyHost
            // 
            this.comboBoxProxyHost.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost"});
            this.comboBoxProxyHost.FormattingEnabled = true;
            this.comboBoxProxyHost.Location = new System.Drawing.Point(6, 69);
            this.comboBoxProxyHost.Name = "comboBoxProxyHost";
            this.comboBoxProxyHost.Size = new System.Drawing.Size(162, 21);
            this.comboBoxProxyHost.TabIndex = 10;
            // 
            // labelProxyPort
            // 
            this.labelProxyPort.AutoSize = true;
            this.labelProxyPort.Location = new System.Drawing.Point(208, 53);
            this.labelProxyPort.Name = "labelProxyPort";
            this.labelProxyPort.Size = new System.Drawing.Size(26, 13);
            this.labelProxyPort.TabIndex = 9;
            this.labelProxyPort.Text = "Port";
            // 
            // labelProxyHost
            // 
            this.labelProxyHost.AutoSize = true;
            this.labelProxyHost.Location = new System.Drawing.Point(6, 53);
            this.labelProxyHost.Name = "labelProxyHost";
            this.labelProxyHost.Size = new System.Drawing.Size(29, 13);
            this.labelProxyHost.TabIndex = 6;
            this.labelProxyHost.Text = "Host";
            // 
            // radioButtonProxyTypeHttp
            // 
            this.radioButtonProxyTypeHttp.AutoSize = true;
            this.radioButtonProxyTypeHttp.Location = new System.Drawing.Point(198, 33);
            this.radioButtonProxyTypeHttp.Name = "radioButtonProxyTypeHttp";
            this.radioButtonProxyTypeHttp.Size = new System.Drawing.Size(45, 17);
            this.radioButtonProxyTypeHttp.TabIndex = 4;
            this.radioButtonProxyTypeHttp.Text = "Http";
            this.radioButtonProxyTypeHttp.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeSocks5
            // 
            this.radioButtonProxyTypeSocks5.AutoSize = true;
            this.radioButtonProxyTypeSocks5.Location = new System.Drawing.Point(128, 33);
            this.radioButtonProxyTypeSocks5.Name = "radioButtonProxyTypeSocks5";
            this.radioButtonProxyTypeSocks5.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProxyTypeSocks5.TabIndex = 3;
            this.radioButtonProxyTypeSocks5.Text = "Socks 5";
            this.radioButtonProxyTypeSocks5.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeSocks4
            // 
            this.radioButtonProxyTypeSocks4.AutoSize = true;
            this.radioButtonProxyTypeSocks4.Location = new System.Drawing.Point(63, 33);
            this.radioButtonProxyTypeSocks4.Name = "radioButtonProxyTypeSocks4";
            this.radioButtonProxyTypeSocks4.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProxyTypeSocks4.TabIndex = 2;
            this.radioButtonProxyTypeSocks4.Text = "Socks 4";
            this.radioButtonProxyTypeSocks4.UseVisualStyleBackColor = true;
            // 
            // radioButtonProxyTypeNone
            // 
            this.radioButtonProxyTypeNone.AutoSize = true;
            this.radioButtonProxyTypeNone.Checked = true;
            this.radioButtonProxyTypeNone.Location = new System.Drawing.Point(11, 33);
            this.radioButtonProxyTypeNone.Name = "radioButtonProxyTypeNone";
            this.radioButtonProxyTypeNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonProxyTypeNone.TabIndex = 1;
            this.radioButtonProxyTypeNone.TabStop = true;
            this.radioButtonProxyTypeNone.Text = "None";
            this.radioButtonProxyTypeNone.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(96, 16);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // groupBoxGameServer
            // 
            this.groupBoxGameServer.Controls.Add(this.numericUpDownRemotePort);
            this.groupBoxGameServer.Controls.Add(this.comboBoxRemoteHost);
            this.groupBoxGameServer.Controls.Add(this.labelRemotePort);
            this.groupBoxGameServer.Controls.Add(this.labelRemoteHost);
            this.groupBoxGameServer.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGameServer.Name = "groupBoxGameServer";
            this.groupBoxGameServer.Size = new System.Drawing.Size(250, 64);
            this.groupBoxGameServer.TabIndex = 0;
            this.groupBoxGameServer.TabStop = false;
            this.groupBoxGameServer.Text = "Game server";
            // 
            // numericUpDownRemotePort
            // 
            this.numericUpDownRemotePort.Location = new System.Drawing.Point(176, 33);
            this.numericUpDownRemotePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownRemotePort.Name = "numericUpDownRemotePort";
            this.numericUpDownRemotePort.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownRemotePort.TabIndex = 8;
            this.numericUpDownRemotePort.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // comboBoxRemoteHost
            // 
            this.comboBoxRemoteHost.FormattingEnabled = true;
            this.comboBoxRemoteHost.Items.AddRange(new object[] {
            "localhost"});
            this.comboBoxRemoteHost.Location = new System.Drawing.Point(6, 32);
            this.comboBoxRemoteHost.Name = "comboBoxRemoteHost";
            this.comboBoxRemoteHost.Size = new System.Drawing.Size(162, 21);
            this.comboBoxRemoteHost.TabIndex = 5;
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.Location = new System.Drawing.Point(208, 16);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(26, 13);
            this.labelRemotePort.TabIndex = 4;
            this.labelRemotePort.Text = "Port";
            // 
            // labelRemoteHost
            // 
            this.labelRemoteHost.AutoSize = true;
            this.labelRemoteHost.Location = new System.Drawing.Point(6, 16);
            this.labelRemoteHost.Name = "labelRemoteHost";
            this.labelRemoteHost.Size = new System.Drawing.Size(29, 13);
            this.labelRemoteHost.TabIndex = 0;
            this.labelRemoteHost.Text = "Host";
            // 
            // pageVideo
            // 
            this.pageVideo.Controls.Add(this.groupBoxVideo);
            this.pageVideo.Controls.Add(this.groupBoxResolution);
            this.pageVideo.Location = new System.Drawing.Point(4, 22);
            this.pageVideo.Name = "pageVideo";
            this.pageVideo.Padding = new System.Windows.Forms.Padding(3);
            this.pageVideo.Size = new System.Drawing.Size(262, 299);
            this.pageVideo.TabIndex = 4;
            this.pageVideo.Text = "Video";
            this.pageVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxVideo
            // 
            this.groupBoxVideo.Controls.Add(this.numericUpDownFixedFPS);
            this.groupBoxVideo.Controls.Add(this.labelFixedFPS);
            this.groupBoxVideo.Controls.Add(this.checkBoxAlwaysOnTop);
            this.groupBoxVideo.Controls.Add(this.checkBoxVSync);
            this.groupBoxVideo.Controls.Add(this.checkBoxFullScreen);
            this.groupBoxVideo.Controls.Add(this.labelAnimation3dSmoothTime);
            this.groupBoxVideo.Controls.Add(this.numericUpDownAnimation3dSmoothTime);
            this.groupBoxVideo.Controls.Add(this.numericUpDownAnimation3dFPS);
            this.groupBoxVideo.Controls.Add(this.labelAnimation3dFPS);
            this.groupBoxVideo.Controls.Add(this.comboBoxMultiSampling);
            this.groupBoxVideo.Controls.Add(this.labelMultiSampling);
            this.groupBoxVideo.Controls.Add(this.labelBaseTexture);
            this.groupBoxVideo.Controls.Add(this.labelFlushValue);
            this.groupBoxVideo.Controls.Add(this.numericUpDownBaseTexture);
            this.groupBoxVideo.Controls.Add(this.numericUpDownFlushValue);
            this.groupBoxVideo.Controls.Add(this.numericUpDownLight);
            this.groupBoxVideo.Controls.Add(this.labelLight);
            this.groupBoxVideo.Location = new System.Drawing.Point(6, 62);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Size = new System.Drawing.Size(250, 231);
            this.groupBoxVideo.TabIndex = 1;
            this.groupBoxVideo.TabStop = false;
            // 
            // numericUpDownFixedFPS
            // 
            this.numericUpDownFixedFPS.Location = new System.Drawing.Point(169, 190);
            this.numericUpDownFixedFPS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFixedFPS.Name = "numericUpDownFixedFPS";
            this.numericUpDownFixedFPS.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownFixedFPS.TabIndex = 15;
            this.numericUpDownFixedFPS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelFixedFPS
            // 
            this.labelFixedFPS.AutoSize = true;
            this.labelFixedFPS.Location = new System.Drawing.Point(123, 184);
            this.labelFixedFPS.Name = "labelFixedFPS";
            this.labelFixedFPS.Size = new System.Drawing.Size(32, 26);
            this.labelFixedFPS.TabIndex = 14;
            this.labelFixedFPS.Text = "Fixed\r\nFPS";
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(128, 151);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAlwaysOnTop.TabIndex = 13;
            this.checkBoxAlwaysOnTop.Text = "Always on top";
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxVSync
            // 
            this.checkBoxVSync.AutoSize = true;
            this.checkBoxVSync.Location = new System.Drawing.Point(128, 128);
            this.checkBoxVSync.Name = "checkBoxVSync";
            this.checkBoxVSync.Size = new System.Drawing.Size(57, 17);
            this.checkBoxVSync.TabIndex = 12;
            this.checkBoxVSync.Text = "VSync";
            this.checkBoxVSync.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.AutoSize = true;
            this.checkBoxFullScreen.Checked = true;
            this.checkBoxFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullScreen.Location = new System.Drawing.Point(128, 105);
            this.checkBoxFullScreen.Name = "checkBoxFullScreen";
            this.checkBoxFullScreen.Size = new System.Drawing.Size(74, 17);
            this.checkBoxFullScreen.TabIndex = 11;
            this.checkBoxFullScreen.Text = "Fullscreen";
            this.checkBoxFullScreen.UseVisualStyleBackColor = true;
            // 
            // labelAnimation3dSmoothTime
            // 
            this.labelAnimation3dSmoothTime.AutoSize = true;
            this.labelAnimation3dSmoothTime.Location = new System.Drawing.Point(16, 152);
            this.labelAnimation3dSmoothTime.Name = "labelAnimation3dSmoothTime";
            this.labelAnimation3dSmoothTime.Size = new System.Drawing.Size(56, 26);
            this.labelAnimation3dSmoothTime.TabIndex = 10;
            this.labelAnimation3dSmoothTime.Text = "3d smooth\r\ntransition";
            // 
            // numericUpDownAnimation3dSmoothTime
            // 
            this.numericUpDownAnimation3dSmoothTime.Location = new System.Drawing.Point(6, 190);
            this.numericUpDownAnimation3dSmoothTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnimation3dSmoothTime.Name = "numericUpDownAnimation3dSmoothTime";
            this.numericUpDownAnimation3dSmoothTime.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownAnimation3dSmoothTime.TabIndex = 9;
            // 
            // numericUpDownAnimation3dFPS
            // 
            this.numericUpDownAnimation3dFPS.Location = new System.Drawing.Point(6, 125);
            this.numericUpDownAnimation3dFPS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnimation3dFPS.Name = "numericUpDownAnimation3dFPS";
            this.numericUpDownAnimation3dFPS.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownAnimation3dFPS.TabIndex = 8;
            // 
            // labelAnimation3dFPS
            // 
            this.labelAnimation3dFPS.AutoSize = true;
            this.labelAnimation3dFPS.Location = new System.Drawing.Point(20, 105);
            this.labelAnimation3dFPS.Name = "labelAnimation3dFPS";
            this.labelAnimation3dFPS.Size = new System.Drawing.Size(42, 13);
            this.labelAnimation3dFPS.TabIndex = 7;
            this.labelAnimation3dFPS.Text = "3d FPS";
            // 
            // comboBoxMultiSampling
            // 
            this.comboBoxMultiSampling.FormattingEnabled = true;
            this.comboBoxMultiSampling.Items.AddRange(new object[] {
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
            this.comboBoxMultiSampling.Location = new System.Drawing.Point(128, 66);
            this.comboBoxMultiSampling.Name = "comboBoxMultiSampling";
            this.comboBoxMultiSampling.Size = new System.Drawing.Size(116, 21);
            this.comboBoxMultiSampling.TabIndex = 2;
            // 
            // labelMultiSampling
            // 
            this.labelMultiSampling.AutoSize = true;
            this.labelMultiSampling.Location = new System.Drawing.Point(16, 69);
            this.labelMultiSampling.Name = "labelMultiSampling";
            this.labelMultiSampling.Size = new System.Drawing.Size(85, 13);
            this.labelMultiSampling.TabIndex = 6;
            this.labelMultiSampling.Text = "Multisampling 3d";
            // 
            // labelBaseTexture
            // 
            this.labelBaseTexture.AutoSize = true;
            this.labelBaseTexture.Location = new System.Drawing.Point(171, 16);
            this.labelBaseTexture.Name = "labelBaseTexture";
            this.labelBaseTexture.Size = new System.Drawing.Size(64, 13);
            this.labelBaseTexture.TabIndex = 5;
            this.labelBaseTexture.Text = "Texture size";
            // 
            // labelFlushValue
            // 
            this.labelFlushValue.AutoSize = true;
            this.labelFlushValue.Location = new System.Drawing.Point(84, 16);
            this.labelFlushValue.Name = "labelFlushValue";
            this.labelFlushValue.Size = new System.Drawing.Size(71, 13);
            this.labelFlushValue.TabIndex = 4;
            this.labelFlushValue.Text = "Cache sprites";
            // 
            // numericUpDownBaseTexture
            // 
            this.numericUpDownBaseTexture.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownBaseTexture.Location = new System.Drawing.Point(169, 32);
            this.numericUpDownBaseTexture.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.numericUpDownBaseTexture.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownBaseTexture.Name = "numericUpDownBaseTexture";
            this.numericUpDownBaseTexture.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownBaseTexture.TabIndex = 3;
            this.numericUpDownBaseTexture.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // numericUpDownFlushValue
            // 
            this.numericUpDownFlushValue.Location = new System.Drawing.Point(87, 32);
            this.numericUpDownFlushValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFlushValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFlushValue.Name = "numericUpDownFlushValue";
            this.numericUpDownFlushValue.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownFlushValue.TabIndex = 2;
            this.numericUpDownFlushValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numericUpDownLight
            // 
            this.numericUpDownLight.Location = new System.Drawing.Point(6, 32);
            this.numericUpDownLight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownLight.Name = "numericUpDownLight";
            this.numericUpDownLight.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownLight.TabIndex = 1;
            this.numericUpDownLight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Location = new System.Drawing.Point(6, 16);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(30, 13);
            this.labelLight.TabIndex = 0;
            this.labelLight.Text = "Light";
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.comboBoxScreenHeight);
            this.groupBoxResolution.Controls.Add(this.comboBoxScreenWidth);
            this.groupBoxResolution.Location = new System.Drawing.Point(6, 6);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(250, 50);
            this.groupBoxResolution.TabIndex = 0;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "Resolution";
            // 
            // comboBoxScreenHeight
            // 
            this.comboBoxScreenHeight.AutoCompleteCustomSource.AddRange(new string[] {
            "480",
            "600",
            "768",
            "1024",
            "720",
            "768",
            "900",
            "1080"});
            this.comboBoxScreenHeight.FormattingEnabled = true;
            this.comboBoxScreenHeight.Items.AddRange(new object[] {
            "480",
            "600",
            "768",
            "1024",
            "720",
            "768",
            "900",
            "1080"});
            this.comboBoxScreenHeight.Location = new System.Drawing.Point(128, 19);
            this.comboBoxScreenHeight.Name = "comboBoxScreenHeight";
            this.comboBoxScreenHeight.Size = new System.Drawing.Size(116, 21);
            this.comboBoxScreenHeight.TabIndex = 1;
            this.comboBoxScreenHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxScreenHeight_SelectedIndexChanged);
            // 
            // comboBoxScreenWidth
            // 
            this.comboBoxScreenWidth.AutoCompleteCustomSource.AddRange(new string[] {
            "640",
            "800",
            "1024",
            "1024",
            "1280",
            "1360",
            "1600",
            "1920"});
            this.comboBoxScreenWidth.FormattingEnabled = true;
            this.comboBoxScreenWidth.Items.AddRange(new object[] {
            "640",
            "800",
            "1024",
            "1280",
            "1280",
            "1366",
            "1600",
            "1920"});
            this.comboBoxScreenWidth.Location = new System.Drawing.Point(6, 19);
            this.comboBoxScreenWidth.Name = "comboBoxScreenWidth";
            this.comboBoxScreenWidth.Size = new System.Drawing.Size(116, 21);
            this.comboBoxScreenWidth.TabIndex = 0;
            this.comboBoxScreenWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxScreenWidth_SelectedIndexChanged);
            // 
            // pageSound
            // 
            this.pageSound.Controls.Add(this.groupBoxVolume);
            this.pageSound.Location = new System.Drawing.Point(4, 22);
            this.pageSound.Name = "pageSound";
            this.pageSound.Padding = new System.Windows.Forms.Padding(3);
            this.pageSound.Size = new System.Drawing.Size(262, 299);
            this.pageSound.TabIndex = 5;
            this.pageSound.Text = "Sound";
            this.pageSound.UseVisualStyleBackColor = true;
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Controls.Add(this.labelSoundVolume);
            this.groupBoxVolume.Controls.Add(this.trackBarSoundVolume);
            this.groupBoxVolume.Controls.Add(this.labelMusicVolume);
            this.groupBoxVolume.Controls.Add(this.trackBarMusicVolume);
            this.groupBoxVolume.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(250, 287);
            this.groupBoxVolume.TabIndex = 0;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume";
            // 
            // labelSoundVolume
            // 
            this.labelSoundVolume.AutoSize = true;
            this.labelSoundVolume.Location = new System.Drawing.Point(10, 86);
            this.labelSoundVolume.Name = "labelSoundVolume";
            this.labelSoundVolume.Size = new System.Drawing.Size(38, 13);
            this.labelSoundVolume.TabIndex = 3;
            this.labelSoundVolume.Text = "Sound";
            // 
            // trackBarSoundVolume
            // 
            this.trackBarSoundVolume.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarSoundVolume.Location = new System.Drawing.Point(6, 105);
            this.trackBarSoundVolume.Maximum = 100;
            this.trackBarSoundVolume.Name = "trackBarSoundVolume";
            this.trackBarSoundVolume.Size = new System.Drawing.Size(238, 45);
            this.trackBarSoundVolume.TabIndex = 2;
            this.trackBarSoundVolume.TickFrequency = 10;
            this.trackBarSoundVolume.Value = 75;
            // 
            // labelMusicVolume
            // 
            this.labelMusicVolume.AutoSize = true;
            this.labelMusicVolume.Location = new System.Drawing.Point(10, 18);
            this.labelMusicVolume.Name = "labelMusicVolume";
            this.labelMusicVolume.Size = new System.Drawing.Size(35, 13);
            this.labelMusicVolume.TabIndex = 1;
            this.labelMusicVolume.Text = "Music";
            // 
            // trackBarMusicVolume
            // 
            this.trackBarMusicVolume.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarMusicVolume.Location = new System.Drawing.Point(6, 37);
            this.trackBarMusicVolume.Maximum = 100;
            this.trackBarMusicVolume.Name = "trackBarMusicVolume";
            this.trackBarMusicVolume.Size = new System.Drawing.Size(238, 45);
            this.trackBarMusicVolume.TabIndex = 0;
            this.trackBarMusicVolume.TickFrequency = 10;
            this.trackBarMusicVolume.Value = 75;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(4, 331);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(82, 28);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(96, 331);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 28);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(188, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FOConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 364);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.tabControlMainContent);
            this.Name = "FOConfigForm";
            this.Text = "FOnline configurator";
            this.tabControlMainContent.ResumeLayout(false);
            this.pageOther.ResumeLayout(false);
            this.groupBoxMisk.ResumeLayout(false);
            this.groupBoxMisk.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.pageGame.ResumeLayout(false);
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScrollStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScrollDelay)).EndInit();
            this.pageCombat.ResumeLayout(false);
            this.groupBoxDamageHitDelay.ResumeLayout(false);
            this.groupBoxDamageHitDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDamageHitDelay)).EndInit();
            this.groupBoxCombatMessagesType.ResumeLayout(false);
            this.groupBoxCombatMessagesType.PerformLayout();
            this.groupBoxIndicatorType.ResumeLayout(false);
            this.groupBoxIndicatorType.PerformLayout();
            this.groupBoxDefaultCombatMode.ResumeLayout(false);
            this.groupBoxDefaultCombatMode.PerformLayout();
            this.pageNet.ResumeLayout(false);
            this.groupBoxProxy.ResumeLayout(false);
            this.groupBoxProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProxyPort)).EndInit();
            this.groupBoxGameServer.ResumeLayout(false);
            this.groupBoxGameServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemotePort)).EndInit();
            this.pageVideo.ResumeLayout(false);
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFixedFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimation3dSmoothTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimation3dFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFlushValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLight)).EndInit();
            this.groupBoxResolution.ResumeLayout(false);
            this.pageSound.ResumeLayout(false);
            this.groupBoxVolume.ResumeLayout(false);
            this.groupBoxVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).EndInit();
            this.ResumeLayout(false);

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