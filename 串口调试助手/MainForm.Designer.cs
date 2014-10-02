namespace 串口调试助手
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存配置信息SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置信息另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.载入配置信息LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用帮助UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDisplayToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainFormContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存配置信息SToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.载入配置信息LToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.openStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.CheckPortButton = new System.Windows.Forms.Button();
            this.openOrClosePortButton = new System.Windows.Forms.Button();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.updateDateTimer = new System.Windows.Forms.Timer(this.components);
            this.acceptZoneSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.displayReadInfoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acceptHexRadioButton = new System.Windows.Forms.RadioButton();
            this.acceptCharRadioButton = new System.Windows.Forms.RadioButton();
            this.saveAcceptBoxTextButton = new System.Windows.Forms.Button();
            this.clearAcceptBoxTextButton = new System.Windows.Forms.Button();
            this.acceptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendZoneSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.sendMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseFileRadioButton = new System.Windows.Forms.RadioButton();
            this.inputCharRadioButton = new System.Windows.Forms.RadioButton();
            this.clearSendBoxTextButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendHexRadioButton = new System.Windows.Forms.RadioButton();
            this.sendCharRadioButton = new System.Windows.Forms.RadioButton();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.stopSendButton = new System.Windows.Forms.Button();
            this.startSendButton = new System.Windows.Forms.Button();
            this.autoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.intervalTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.acceptStatusLabel = new System.Windows.Forms.Label();
            this.sendStatusLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.warningToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.autoSendTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.XmlPathTextBox = new System.Windows.Forms.TextBox();
            this.XmlListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SendInfoButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StopListenButton = new System.Windows.Forms.Button();
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.LocalIPTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RemoteIPTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ListenButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.XmlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainFormContextMenuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openStatusPictureBox)).BeginInit();
            this.acceptZoneSettingGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sendZoneSettingGroupBox.SuspendLayout();
            this.sendMessageGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.sendSettingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTimeNumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.XmlContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存配置信息SToolStripMenuItem,
            this.配置信息另存为AToolStripMenuItem,
            this.载入配置信息LToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 保存配置信息SToolStripMenuItem
            // 
            this.保存配置信息SToolStripMenuItem.Name = "保存配置信息SToolStripMenuItem";
            this.保存配置信息SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.保存配置信息SToolStripMenuItem.Text = "保存配置信息(&S)";
            this.保存配置信息SToolStripMenuItem.Click += new System.EventHandler(this.保存配置信息SToolStripMenuItem_Click);
            // 
            // 配置信息另存为AToolStripMenuItem
            // 
            this.配置信息另存为AToolStripMenuItem.Name = "配置信息另存为AToolStripMenuItem";
            this.配置信息另存为AToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.配置信息另存为AToolStripMenuItem.Text = "配置信息另存为(_A)";
            this.配置信息另存为AToolStripMenuItem.Click += new System.EventHandler(this.配置信息另存为AToolStripMenuItem_Click);
            // 
            // 载入配置信息LToolStripMenuItem
            // 
            this.载入配置信息LToolStripMenuItem.Name = "载入配置信息LToolStripMenuItem";
            this.载入配置信息LToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.载入配置信息LToolStripMenuItem.Text = "载入配置信息(&L)";
            this.载入配置信息LToolStripMenuItem.Click += new System.EventHandler(this.载入配置信息LToolStripMenuItem_Click);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于软件AToolStripMenuItem,
            this.使用帮助UToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于软件AToolStripMenuItem
            // 
            this.关于软件AToolStripMenuItem.Name = "关于软件AToolStripMenuItem";
            this.关于软件AToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.关于软件AToolStripMenuItem.Text = "关于软件(&A)";
            this.关于软件AToolStripMenuItem.Click += new System.EventHandler(this.关于软件AToolStripMenuItem_Click);
            // 
            // 使用帮助UToolStripMenuItem
            // 
            this.使用帮助UToolStripMenuItem.Name = "使用帮助UToolStripMenuItem";
            this.使用帮助UToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.使用帮助UToolStripMenuItem.Text = "使用帮助(&U)";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDisplayToolStripStatusLabel,
            this.dateTimeToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 498);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(812, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusDisplayToolStripStatusLabel
            // 
            this.statusDisplayToolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.statusDisplayToolStripStatusLabel.Name = "statusDisplayToolStripStatusLabel";
            this.statusDisplayToolStripStatusLabel.Size = new System.Drawing.Size(797, 17);
            this.statusDisplayToolStripStatusLabel.Spring = true;
            this.statusDisplayToolStripStatusLabel.Text = "状态显示";
            this.statusDisplayToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeToolStripStatusLabel
            // 
            this.dateTimeToolStripStatusLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimeToolStripStatusLabel.Name = "dateTimeToolStripStatusLabel";
            this.dateTimeToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainFormContextMenuStrip
            // 
            this.mainFormContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存配置信息SToolStripMenuItem1,
            this.载入配置信息LToolStripMenuItem1,
            this.关于软件AToolStripMenuItem1});
            this.mainFormContextMenuStrip.Name = "mainFormContextMenuStrip";
            this.mainFormContextMenuStrip.Size = new System.Drawing.Size(164, 70);
            // 
            // 保存配置信息SToolStripMenuItem1
            // 
            this.保存配置信息SToolStripMenuItem1.Name = "保存配置信息SToolStripMenuItem1";
            this.保存配置信息SToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.保存配置信息SToolStripMenuItem1.Text = "保存配置信息(&S)";
            // 
            // 载入配置信息LToolStripMenuItem1
            // 
            this.载入配置信息LToolStripMenuItem1.Name = "载入配置信息LToolStripMenuItem1";
            this.载入配置信息LToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.载入配置信息LToolStripMenuItem1.Text = "载入配置信息(&L)";
            // 
            // 关于软件AToolStripMenuItem1
            // 
            this.关于软件AToolStripMenuItem1.Name = "关于软件AToolStripMenuItem1";
            this.关于软件AToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.关于软件AToolStripMenuItem1.Text = "关于软件(&A)";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox.ContextMenuStrip = this.mainFormContextMenuStrip;
            this.groupBox.Controls.Add(this.openStatusPictureBox);
            this.groupBox.Controls.Add(this.CheckPortButton);
            this.groupBox.Controls.Add(this.openOrClosePortButton);
            this.groupBox.Controls.Add(this.stopBitsComboBox);
            this.groupBox.Controls.Add(this.dataBitsComboBox);
            this.groupBox.Controls.Add(this.parityComboBox);
            this.groupBox.Controls.Add(this.baudRateComboBox);
            this.groupBox.Controls.Add(this.portNameComboBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox.Location = new System.Drawing.Point(6, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(251, 369);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "串口配置区";
            // 
            // openStatusPictureBox
            // 
            this.openStatusPictureBox.Image = global::串口调试助手.Properties.Resources.no;
            this.openStatusPictureBox.InitialImage = null;
            this.openStatusPictureBox.Location = new System.Drawing.Point(52, 275);
            this.openStatusPictureBox.Name = "openStatusPictureBox";
            this.openStatusPictureBox.Size = new System.Drawing.Size(131, 47);
            this.openStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openStatusPictureBox.TabIndex = 12;
            this.openStatusPictureBox.TabStop = false;
            // 
            // CheckPortButton
            // 
            this.CheckPortButton.Location = new System.Drawing.Point(128, 335);
            this.CheckPortButton.Name = "CheckPortButton";
            this.CheckPortButton.Size = new System.Drawing.Size(104, 23);
            this.CheckPortButton.TabIndex = 11;
            this.CheckPortButton.Text = "查找可用端口";
            this.CheckPortButton.UseVisualStyleBackColor = true;
            this.CheckPortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openOrClosePortButton
            // 
            this.openOrClosePortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openOrClosePortButton.Enabled = false;
            this.openOrClosePortButton.Location = new System.Drawing.Point(9, 336);
            this.openOrClosePortButton.Name = "openOrClosePortButton";
            this.openOrClosePortButton.Size = new System.Drawing.Size(104, 23);
            this.openOrClosePortButton.TabIndex = 10;
            this.openOrClosePortButton.Text = "打开选中端口";
            this.openOrClosePortButton.UseVisualStyleBackColor = true;
            this.openOrClosePortButton.Click += new System.EventHandler(this.openOrClosePortButton_Click);
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.BackColor = System.Drawing.Color.White;
            this.stopBitsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(90, 240);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(142, 25);
            this.stopBitsComboBox.TabIndex = 9;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.BackColor = System.Drawing.Color.White;
            this.dataBitsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(90, 188);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(142, 25);
            this.dataBitsComboBox.TabIndex = 8;
            // 
            // parityComboBox
            // 
            this.parityComboBox.BackColor = System.Drawing.Color.White;
            this.parityComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "无校验(None)",
            "偶校验(Even)",
            "奇校验(Odd)",
            "保留为0(Space)",
            "保留为1(Mark)"});
            this.parityComboBox.Location = new System.Drawing.Point(90, 136);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(142, 25);
            this.parityComboBox.TabIndex = 7;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.BackColor = System.Drawing.Color.White;
            this.baudRateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "128000",
            "256000"});
            this.baudRateComboBox.Location = new System.Drawing.Point(90, 84);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(142, 25);
            this.baudRateComboBox.TabIndex = 6;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.BackColor = System.Drawing.Color.White;
            this.portNameComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNameComboBox.Enabled = false;
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(90, 35);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(142, 25);
            this.portNameComboBox.Sorted = true;
            this.portNameComboBox.TabIndex = 5;
            this.portNameComboBox.SelectedIndexChanged += new System.EventHandler(this.portNameComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "奇偶校验位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            // 
            // mySerialPort
            // 
            this.mySerialPort.ReadBufferSize = 2;
            this.mySerialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.mySerialPort_ErrorReceived);
            this.mySerialPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.mySerialPort_PinChanged);
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // updateDateTimer
            // 
            this.updateDateTimer.Enabled = true;
            this.updateDateTimer.Interval = 200;
            this.updateDateTimer.Tick += new System.EventHandler(this.updateDateTimer_Tick);
            // 
            // acceptZoneSettingGroupBox
            // 
            this.acceptZoneSettingGroupBox.Controls.Add(this.displayReadInfoButton);
            this.acceptZoneSettingGroupBox.Controls.Add(this.groupBox1);
            this.acceptZoneSettingGroupBox.Controls.Add(this.saveAcceptBoxTextButton);
            this.acceptZoneSettingGroupBox.Controls.Add(this.clearAcceptBoxTextButton);
            this.acceptZoneSettingGroupBox.Enabled = false;
            this.acceptZoneSettingGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acceptZoneSettingGroupBox.Location = new System.Drawing.Point(556, 6);
            this.acceptZoneSettingGroupBox.Name = "acceptZoneSettingGroupBox";
            this.acceptZoneSettingGroupBox.Size = new System.Drawing.Size(187, 175);
            this.acceptZoneSettingGroupBox.TabIndex = 4;
            this.acceptZoneSettingGroupBox.TabStop = false;
            this.acceptZoneSettingGroupBox.Text = "串口通信接收区设置";
            // 
            // displayReadInfoButton
            // 
            this.displayReadInfoButton.Location = new System.Drawing.Point(7, 91);
            this.displayReadInfoButton.Name = "displayReadInfoButton";
            this.displayReadInfoButton.Size = new System.Drawing.Size(174, 23);
            this.displayReadInfoButton.TabIndex = 3;
            this.displayReadInfoButton.Text = "不显示接收缓冲区内容";
            this.displayReadInfoButton.UseVisualStyleBackColor = true;
            this.displayReadInfoButton.Click += new System.EventHandler(this.displayReadInfoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.acceptHexRadioButton);
            this.groupBox1.Controls.Add(this.acceptCharRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收方式";
            // 
            // acceptHexRadioButton
            // 
            this.acceptHexRadioButton.AutoSize = true;
            this.acceptHexRadioButton.Location = new System.Drawing.Point(7, 39);
            this.acceptHexRadioButton.Name = "acceptHexRadioButton";
            this.acceptHexRadioButton.Size = new System.Drawing.Size(48, 21);
            this.acceptHexRadioButton.TabIndex = 1;
            this.acceptHexRadioButton.Text = "Hex";
            this.acceptHexRadioButton.UseVisualStyleBackColor = true;
            this.acceptHexRadioButton.CheckedChanged += new System.EventHandler(this.acceptHexRadioButton_CheckedChanged);
            // 
            // acceptCharRadioButton
            // 
            this.acceptCharRadioButton.AutoSize = true;
            this.acceptCharRadioButton.Checked = true;
            this.acceptCharRadioButton.Location = new System.Drawing.Point(7, 22);
            this.acceptCharRadioButton.Name = "acceptCharRadioButton";
            this.acceptCharRadioButton.Size = new System.Drawing.Size(50, 21);
            this.acceptCharRadioButton.TabIndex = 0;
            this.acceptCharRadioButton.TabStop = true;
            this.acceptCharRadioButton.Text = "字符";
            this.acceptCharRadioButton.UseVisualStyleBackColor = true;
            this.acceptCharRadioButton.CheckedChanged += new System.EventHandler(this.acceptCharRadioButton_CheckedChanged);
            // 
            // saveAcceptBoxTextButton
            // 
            this.saveAcceptBoxTextButton.Location = new System.Drawing.Point(7, 115);
            this.saveAcceptBoxTextButton.Name = "saveAcceptBoxTextButton";
            this.saveAcceptBoxTextButton.Size = new System.Drawing.Size(174, 23);
            this.saveAcceptBoxTextButton.TabIndex = 1;
            this.saveAcceptBoxTextButton.Text = "保存接收区内容";
            this.saveAcceptBoxTextButton.UseVisualStyleBackColor = true;
            this.saveAcceptBoxTextButton.Click += new System.EventHandler(this.saveAcceptBoxTextButton_Click);
            // 
            // clearAcceptBoxTextButton
            // 
            this.clearAcceptBoxTextButton.Location = new System.Drawing.Point(6, 139);
            this.clearAcceptBoxTextButton.Name = "clearAcceptBoxTextButton";
            this.clearAcceptBoxTextButton.Size = new System.Drawing.Size(175, 23);
            this.clearAcceptBoxTextButton.TabIndex = 0;
            this.clearAcceptBoxTextButton.Text = "清空接收区内容";
            this.clearAcceptBoxTextButton.UseVisualStyleBackColor = true;
            this.clearAcceptBoxTextButton.Click += new System.EventHandler(this.clearAcceptBoxTextButton_Click);
            // 
            // acceptRichTextBox
            // 
            this.acceptRichTextBox.BackColor = System.Drawing.Color.White;
            this.acceptRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acceptRichTextBox.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acceptRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.acceptRichTextBox.Location = new System.Drawing.Point(277, 28);
            this.acceptRichTextBox.Name = "acceptRichTextBox";
            this.acceptRichTextBox.ReadOnly = true;
            this.acceptRichTextBox.Size = new System.Drawing.Size(260, 118);
            this.acceptRichTextBox.TabIndex = 5;
            this.acceptRichTextBox.Text = "";
            // 
            // sendZoneSettingGroupBox
            // 
            this.sendZoneSettingGroupBox.Controls.Add(this.sendMessageGroupBox);
            this.sendZoneSettingGroupBox.Controls.Add(this.clearSendBoxTextButton);
            this.sendZoneSettingGroupBox.Controls.Add(this.groupBox3);
            this.sendZoneSettingGroupBox.Enabled = false;
            this.sendZoneSettingGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendZoneSettingGroupBox.Location = new System.Drawing.Point(556, 187);
            this.sendZoneSettingGroupBox.Name = "sendZoneSettingGroupBox";
            this.sendZoneSettingGroupBox.Size = new System.Drawing.Size(187, 191);
            this.sendZoneSettingGroupBox.TabIndex = 6;
            this.sendZoneSettingGroupBox.TabStop = false;
            this.sendZoneSettingGroupBox.Text = "串口通信发送区设置";
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.chooseFileRadioButton);
            this.sendMessageGroupBox.Controls.Add(this.inputCharRadioButton);
            this.sendMessageGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendMessageGroupBox.Location = new System.Drawing.Point(7, 85);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Size = new System.Drawing.Size(174, 57);
            this.sendMessageGroupBox.TabIndex = 8;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "发送内容";
            // 
            // chooseFileRadioButton
            // 
            this.chooseFileRadioButton.AutoSize = true;
            this.chooseFileRadioButton.Location = new System.Drawing.Point(7, 33);
            this.chooseFileRadioButton.Name = "chooseFileRadioButton";
            this.chooseFileRadioButton.Size = new System.Drawing.Size(74, 21);
            this.chooseFileRadioButton.TabIndex = 1;
            this.chooseFileRadioButton.Text = "选择文件";
            this.chooseFileRadioButton.UseVisualStyleBackColor = true;
            this.chooseFileRadioButton.CheckedChanged += new System.EventHandler(this.chooseFileRadioButton_CheckedChanged);
            // 
            // inputCharRadioButton
            // 
            this.inputCharRadioButton.AutoSize = true;
            this.inputCharRadioButton.Checked = true;
            this.inputCharRadioButton.Location = new System.Drawing.Point(7, 16);
            this.inputCharRadioButton.Name = "inputCharRadioButton";
            this.inputCharRadioButton.Size = new System.Drawing.Size(74, 21);
            this.inputCharRadioButton.TabIndex = 0;
            this.inputCharRadioButton.TabStop = true;
            this.inputCharRadioButton.Text = "输入字符";
            this.inputCharRadioButton.UseVisualStyleBackColor = true;
            this.inputCharRadioButton.CheckedChanged += new System.EventHandler(this.inputCharRadioButton_CheckedChanged);
            // 
            // clearSendBoxTextButton
            // 
            this.clearSendBoxTextButton.Location = new System.Drawing.Point(7, 161);
            this.clearSendBoxTextButton.Name = "clearSendBoxTextButton";
            this.clearSendBoxTextButton.Size = new System.Drawing.Size(174, 23);
            this.clearSendBoxTextButton.TabIndex = 4;
            this.clearSendBoxTextButton.Text = "清空发送区内容";
            this.clearSendBoxTextButton.UseVisualStyleBackColor = true;
            this.clearSendBoxTextButton.Click += new System.EventHandler(this.clearSendBoxTextButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendHexRadioButton);
            this.groupBox3.Controls.Add(this.sendCharRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送方式";
            // 
            // sendHexRadioButton
            // 
            this.sendHexRadioButton.AutoSize = true;
            this.sendHexRadioButton.Location = new System.Drawing.Point(7, 42);
            this.sendHexRadioButton.Name = "sendHexRadioButton";
            this.sendHexRadioButton.Size = new System.Drawing.Size(48, 21);
            this.sendHexRadioButton.TabIndex = 1;
            this.sendHexRadioButton.Text = "Hex";
            this.sendHexRadioButton.UseVisualStyleBackColor = true;
            this.sendHexRadioButton.CheckedChanged += new System.EventHandler(this.sendHexRadioButton_CheckedChanged);
            // 
            // sendCharRadioButton
            // 
            this.sendCharRadioButton.AutoSize = true;
            this.sendCharRadioButton.Checked = true;
            this.sendCharRadioButton.Location = new System.Drawing.Point(7, 22);
            this.sendCharRadioButton.Name = "sendCharRadioButton";
            this.sendCharRadioButton.Size = new System.Drawing.Size(50, 21);
            this.sendCharRadioButton.TabIndex = 0;
            this.sendCharRadioButton.TabStop = true;
            this.sendCharRadioButton.Text = "字符";
            this.sendCharRadioButton.UseVisualStyleBackColor = true;
            this.sendCharRadioButton.CheckedChanged += new System.EventHandler(this.sendCharRadioButton_CheckedChanged);
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.BackColor = System.Drawing.Color.White;
            this.sendRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendRichTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.sendRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.sendRichTextBox.Location = new System.Drawing.Point(277, 187);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(260, 82);
            this.sendRichTextBox.TabIndex = 7;
            this.sendRichTextBox.Text = "";
            // 
            // sendSettingGroupBox
            // 
            this.sendSettingGroupBox.Controls.Add(this.stopSendButton);
            this.sendSettingGroupBox.Controls.Add(this.startSendButton);
            this.sendSettingGroupBox.Controls.Add(this.autoSendCheckBox);
            this.sendSettingGroupBox.Controls.Add(this.label7);
            this.sendSettingGroupBox.Controls.Add(this.intervalTimeNumericUpDown);
            this.sendSettingGroupBox.Controls.Add(this.label6);
            this.sendSettingGroupBox.Enabled = false;
            this.sendSettingGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendSettingGroupBox.Location = new System.Drawing.Point(277, 274);
            this.sendSettingGroupBox.Name = "sendSettingGroupBox";
            this.sendSettingGroupBox.Size = new System.Drawing.Size(260, 97);
            this.sendSettingGroupBox.TabIndex = 8;
            this.sendSettingGroupBox.TabStop = false;
            this.sendSettingGroupBox.Text = "发送设置";
            // 
            // stopSendButton
            // 
            this.stopSendButton.Enabled = false;
            this.stopSendButton.Location = new System.Drawing.Point(159, 67);
            this.stopSendButton.Name = "stopSendButton";
            this.stopSendButton.Size = new System.Drawing.Size(96, 23);
            this.stopSendButton.TabIndex = 5;
            this.stopSendButton.Text = "停止自动发送";
            this.stopSendButton.UseVisualStyleBackColor = true;
            this.stopSendButton.Click += new System.EventHandler(this.stopSendButton_Click);
            // 
            // startSendButton
            // 
            this.startSendButton.Location = new System.Drawing.Point(10, 67);
            this.startSendButton.Name = "startSendButton";
            this.startSendButton.Size = new System.Drawing.Size(96, 23);
            this.startSendButton.TabIndex = 4;
            this.startSendButton.Text = "发送数据";
            this.startSendButton.UseVisualStyleBackColor = true;
            this.startSendButton.Click += new System.EventHandler(this.startSendButton_Click);
            // 
            // autoSendCheckBox
            // 
            this.autoSendCheckBox.AutoSize = true;
            this.autoSendCheckBox.Location = new System.Drawing.Point(185, 27);
            this.autoSendCheckBox.Name = "autoSendCheckBox";
            this.autoSendCheckBox.Size = new System.Drawing.Size(75, 21);
            this.autoSendCheckBox.TabIndex = 3;
            this.autoSendCheckBox.Text = "自动发送";
            this.autoSendCheckBox.UseVisualStyleBackColor = true;
            this.autoSendCheckBox.CheckedChanged += new System.EventHandler(this.autoSendCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "ms";
            // 
            // intervalTimeNumericUpDown
            // 
            this.intervalTimeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalTimeNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.intervalTimeNumericUpDown.Location = new System.Drawing.Point(105, 25);
            this.intervalTimeNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalTimeNumericUpDown.Name = "intervalTimeNumericUpDown";
            this.intervalTimeNumericUpDown.Size = new System.Drawing.Size(49, 19);
            this.intervalTimeNumericUpDown.TabIndex = 1;
            this.intervalTimeNumericUpDown.ThousandsSeparator = true;
            this.intervalTimeNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.intervalTimeNumericUpDown.ValueChanged += new System.EventHandler(this.intervalTimeNumericUpDown_ValueChanged);
            this.intervalTimeNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.intervalTimeNumericUpDown_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "设置时间间隔：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(274, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "接收区";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(391, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "已接收：";
            // 
            // acceptStatusLabel
            // 
            this.acceptStatusLabel.AutoSize = true;
            this.acceptStatusLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acceptStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.acceptStatusLabel.Location = new System.Drawing.Point(453, 8);
            this.acceptStatusLabel.Name = "acceptStatusLabel";
            this.acceptStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.acceptStatusLabel.TabIndex = 11;
            this.acceptStatusLabel.Text = "0字节";
            this.acceptStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendStatusLabel
            // 
            this.sendStatusLabel.AutoSize = true;
            this.sendStatusLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.sendStatusLabel.Location = new System.Drawing.Point(453, 164);
            this.sendStatusLabel.Name = "sendStatusLabel";
            this.sendStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.sendStatusLabel.TabIndex = 14;
            this.sendStatusLabel.Text = "0字节";
            this.sendStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(391, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "已发送：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(274, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "发送区";
            // 
            // warningToolTip
            // 
            this.warningToolTip.AutoPopDelay = 2000;
            this.warningToolTip.InitialDelay = 100;
            this.warningToolTip.ReshowDelay = 100;
            this.warningToolTip.ToolTipTitle = "小贴士";
            // 
            // autoSendTimer
            // 
            this.autoSendTimer.Tick += new System.EventHandler(this.autoSendTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 466);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Controls.Add(this.acceptZoneSettingGroupBox);
            this.tabPage1.Controls.Add(this.sendStatusLabel);
            this.tabPage1.Controls.Add(this.acceptRichTextBox);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.sendZoneSettingGroupBox);
            this.tabPage1.Controls.Add(this.sendRichTextBox);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.acceptStatusLabel);
            this.tabPage1.Controls.Add(this.sendSettingGroupBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "手动测试";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "自动测试";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.XmlPathTextBox);
            this.groupBox2.Controls.Add(this.XmlListBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 383);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置文件路径";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // XmlPathTextBox
            // 
            this.XmlPathTextBox.Location = new System.Drawing.Point(7, 45);
            this.XmlPathTextBox.Name = "XmlPathTextBox";
            this.XmlPathTextBox.Size = new System.Drawing.Size(159, 21);
            this.XmlPathTextBox.TabIndex = 1;
            this.XmlPathTextBox.TextChanged += new System.EventHandler(this.XmlPathTextBox_TextChanged);
            // 
            // XmlListBox
            // 
            this.XmlListBox.ContextMenuStrip = this.XmlContextMenuStrip;
            this.XmlListBox.FormattingEnabled = true;
            this.XmlListBox.ItemHeight = 12;
            this.XmlListBox.Location = new System.Drawing.Point(7, 81);
            this.XmlListBox.Name = "XmlListBox";
            this.XmlListBox.Size = new System.Drawing.Size(234, 292);
            this.XmlListBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.StartButton);
            this.groupBox5.Controls.Add(this.SendInfoButton);
            this.groupBox5.Location = new System.Drawing.Point(554, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 383);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "下发配置";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(34, 125);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "开始自动测试";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SendInfoButton
            // 
            this.SendInfoButton.Location = new System.Drawing.Point(34, 48);
            this.SendInfoButton.Name = "SendInfoButton";
            this.SendInfoButton.Size = new System.Drawing.Size(117, 23);
            this.SendInfoButton.TabIndex = 0;
            this.SendInfoButton.Text = "下发配置信息";
            this.SendInfoButton.UseVisualStyleBackColor = true;
            this.SendInfoButton.Click += new System.EventHandler(this.SendInfoButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.StopListenButton);
            this.groupBox4.Controls.Add(this.SendMsgButton);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.LocalPortTextBox);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.LocalIPTextBox);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.RemotePortTextBox);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.RemoteIPTextBox);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.ListenButton);
            this.groupBox4.Location = new System.Drawing.Point(35, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 383);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TCP";
            // 
            // StopListenButton
            // 
            this.StopListenButton.Location = new System.Drawing.Point(131, 138);
            this.StopListenButton.Name = "StopListenButton";
            this.StopListenButton.Size = new System.Drawing.Size(75, 23);
            this.StopListenButton.TabIndex = 12;
            this.StopListenButton.Text = "停止监听";
            this.StopListenButton.UseVisualStyleBackColor = true;
            this.StopListenButton.Click += new System.EventHandler(this.StopListenButton_Click);
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.Location = new System.Drawing.Point(68, 329);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(75, 23);
            this.SendMsgButton.TabIndex = 11;
            this.SendMsgButton.Text = "发送";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(23, 270);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(183, 34);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 29);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(159, 46);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(47, 21);
            this.LocalPortTextBox.TabIndex = 8;
            this.LocalPortTextBox.Text = "8500";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(157, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "端口号";
            // 
            // LocalIPTextBox
            // 
            this.LocalIPTextBox.Location = new System.Drawing.Point(23, 46);
            this.LocalIPTextBox.Name = "LocalIPTextBox";
            this.LocalIPTextBox.Size = new System.Drawing.Size(120, 21);
            this.LocalIPTextBox.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 5;
            this.label20.Text = "本地IP地址";
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(159, 102);
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(47, 21);
            this.RemotePortTextBox.TabIndex = 4;
            this.RemotePortTextBox.Text = "8500";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(157, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "端口号";
            // 
            // RemoteIPTextBox
            // 
            this.RemoteIPTextBox.Location = new System.Drawing.Point(23, 102);
            this.RemoteIPTextBox.Name = "RemoteIPTextBox";
            this.RemoteIPTextBox.Size = new System.Drawing.Size(120, 21);
            this.RemoteIPTextBox.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "对方IP地址";
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(32, 138);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(76, 23);
            this.ListenButton.TabIndex = 0;
            this.ListenButton.Text = "监听";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "接收消息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "发送消息";
            // 
            // XmlContextMenuStrip
            // 
            this.XmlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.XmlContextMenuStrip.Name = "XmlContextMenuStrip";
            this.XmlContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            this.XmlContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.XmlContextMenuStrip_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "删除";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 520);
            this.ContextMenuStrip = this.mainFormContextMenuStrip;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainFormContextMenuStrip.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openStatusPictureBox)).EndInit();
            this.acceptZoneSettingGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sendZoneSettingGroupBox.ResumeLayout(false);
            this.sendMessageGroupBox.ResumeLayout(false);
            this.sendMessageGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.sendSettingGroupBox.ResumeLayout(false);
            this.sendSettingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTimeNumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.XmlContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存配置信息SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 载入配置信息LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusDisplayToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeToolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip mainFormContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 保存配置信息SToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 载入配置信息LToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于软件AToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.Button openOrClosePortButton;
        private System.Windows.Forms.Button CheckPortButton;
        private System.Windows.Forms.PictureBox openStatusPictureBox;
        private System.Windows.Forms.Timer updateDateTimer;
        private System.Windows.Forms.GroupBox acceptZoneSettingGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton acceptHexRadioButton;
        private System.Windows.Forms.RadioButton acceptCharRadioButton;
        private System.Windows.Forms.Button saveAcceptBoxTextButton;
        private System.Windows.Forms.Button clearAcceptBoxTextButton;
        private System.Windows.Forms.RichTextBox acceptRichTextBox;
        private System.Windows.Forms.GroupBox sendZoneSettingGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton sendHexRadioButton;
        private System.Windows.Forms.RadioButton sendCharRadioButton;
        private System.Windows.Forms.Button clearSendBoxTextButton;
        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.RadioButton chooseFileRadioButton;
        private System.Windows.Forms.RadioButton inputCharRadioButton;
        private System.Windows.Forms.RichTextBox sendRichTextBox;
        private System.Windows.Forms.GroupBox sendSettingGroupBox;
        private System.Windows.Forms.CheckBox autoSendCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown intervalTimeNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button stopSendButton;
        private System.Windows.Forms.Button startSendButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label acceptStatusLabel;
        private System.Windows.Forms.Label sendStatusLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip warningToolTip;
        private bool hasStartSend = false;
        private string initialText;
        private System.IO.Ports.SerialPort mySerialPort;
        //private System.IO.Ports.SerialPort sendSerialPort;
        //自定义委托
        //实现对接收区的信息更新！
        public delegate void UpdateAcceptTextBoxTextHandler(string text);
        public UpdateAcceptTextBoxTextHandler UpdateTextHandler;
        private System.Windows.Forms.Timer autoSendTimer;
        private System.Windows.Forms.Button displayReadInfoButton;
        private bool showInfo = true;
        private bool isReading = false;

        private System.IO.StreamWriter sw;
        private bool needWrite = false;
        private System.Windows.Forms.ToolStripMenuItem 配置信息另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助UToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button SendInfoButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox RemoteIPTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox LocalIPTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.Button StopListenButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox XmlListBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox XmlPathTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip XmlContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

