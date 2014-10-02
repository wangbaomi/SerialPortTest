using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using leomon;

namespace 串口调试助手
{
    public partial class MainForm : Form
    {
        private TcpListener listener;//监听本地端口
        private TcpClient client;//TCP客户端,向对方发送消息
        private Thread thread;//监听线程
        private TcpClient remoteClient;//用于获取对方发来的消息
        private NetworkStream streamToClient;//用于读取对方发来的消息
        private bool sendOver = false;//无用，要删掉
        private Thread useXmlThread;//循环使用不同配置文件的线程
        AutoResetEvent useXmlEvent = new AutoResetEvent(false);//用于向useXmlThread线程发送暂停和继续的消息

        //接收串口信息的格式
        private enum ReceivedDataType
        {
            CharType,
            HexType
        };

        //发送串口信息的格式
        private enum SendDataType
        {
            CharType,
            HexType
        }

        private ReceivedDataType myReceivedDataType = ReceivedDataType.CharType;//保存接收串口信息的格式
        private SendDataType mySendDataType = SendDataType.CharType;//保存发送串口信息的格式
        private int totalReceivedBytes = 0;//接收串口信息的总字节数
        private int totalSendBytes = 0;//发送串口信息的总字节数
        private bool autoSend = false;//保存是否自动发送
        private string cmd = "";  //命令行启动参数
        private bool hasPorts = false;//是否有可用的串口

        //直接打开窗口
        public MainForm()
        {
            InitializeComponent();
            UpdateTextHandler = new UpdateAcceptTextBoxTextHandler(UpdateText);
            LogHelper.WriteDebug(typeof(MainForm), "Start without args.");
        }
        //命令行打开窗口，接收一个参数
        public MainForm(string args)
        {
            InitializeComponent();
            UpdateTextHandler = new UpdateAcceptTextBoxTextHandler(UpdateText);
            cmd = args;
            LogHelper.WriteDebug(typeof(MainForm), "Start with args: " + cmd);
        }
       
        /// <summary>
        /// 当主form绘制后，进行初始化操作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //检查可用端口
            CheckAvailablePorts();
            //开始更新时间和日期标签
            updateDateTimer.Start();
            //载入配置信息
            if (cmd == "")
            {
                LoadConfig("串口助手配置.xml");//载入默认配置
            }
            else
            {
                LoadConfig(cmd);
            }
            //显示当前目录的配置文件列表
            DirectoryInfo TheFolder = new DirectoryInfo(System.Environment.CurrentDirectory);
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                //MessageBox.Show(NextFile.Extension);
                if (NextFile.Extension == ".xml")
                {
                    this.XmlListBox.Items.Add(NextFile.Name);
                }

            }
           
        }
        /// <summary>
        /// 默认端口参数设置
        /// </summary>
        private void ResetToDefaultSettings()
        {
            //默认波特率
            baudRateComboBox.SelectedItem = "9600";
            //默认不校验
            parityComboBox.SelectedIndex = 0;
            //默认数据位设置为8位
            dataBitsComboBox.SelectedIndex = 0;
            //默认停止位设置为1位
            stopBitsComboBox.SelectedIndex = 0;
            LogHelper.WriteDebug(typeof(MainForm), "默认端口参数设置");
        }

        
        /// <summary>
        /// 获取可用的端口名，并添加到选择框中，同时设置相关
        /// 默认项。
        /// </summary>
        private void CheckAvailablePorts()
        {
            portNameComboBox.Items.Clear();
            string[] allAvailablePorts = SerialPort.GetPortNames();
            LogHelper.WriteDebug(typeof(MainForm), "Check all available ports: " + allAvailablePorts.Length);
            //判断是否有可用的端口
            if (allAvailablePorts.Length > 0)
            {
                hasPorts = true;
                //使能控件portNamesComboBox，openOrCloseButton
                openOrClosePortButton.Enabled = true;
                portNameComboBox.Enabled = true;
                //依次添加可用的串口
                portNameComboBox.Items.AddRange(allAvailablePorts);
                //默认选中第一个项
                portNameComboBox.SelectedIndex = 0;
                //显示相应的状态信息
                statusDisplayToolStripStatusLabel.Text = string.Format("  欢迎使用！自动查找到该计算机可用端口数：{0}，当前选中端口号{1}  :)",
                    allAvailablePorts.Length, portNameComboBox.SelectedItem.ToString());
               
            }
            else
            {
                hasPorts = false;
                autoSendCheckBox.Enabled = false;
                startSendButton.Enabled = false;
                stopSendButton.Enabled = false;
                openOrClosePortButton.Enabled = false;
                //清空所有项
                portNameComboBox.Items.Clear();
                portNameComboBox.Enabled = false;
                statusDisplayToolStripStatusLabel.Text = "  抱歉，未查找到当前计算机中可用端口。";
                //同时弹出警告对话框，提示是否进行再次检查？!
                ShowWarningMessageBox();
            }
        }

        /// <summary>
        /// 当没有检测到可用端口号时，弹出该对话框，
        /// 提示是否重新检测。
        /// </summary>
        private void ShowWarningMessageBox()
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("抱歉，没有检测到当前计算机中可用端口，请插入相关设备或者检查有关驱动是否安装？" + 
            Environment.NewLine + "提示：您可以取消后单击“查找可用端口”按钮重新查找。",
                "自动查找计算机可用端口", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Retry)
            {
                //重新运行检测方法
                CheckAvailablePorts();
            }
        }

        //检查端口号
        private void button1_Click(object sender, EventArgs e)
        {
            CheckAvailablePorts();
        }


        private void openOrClosePortButton_Click(object sender, EventArgs e)
        {
            if (openOrClosePortButton.Text == "打开选中端口")
            {
                acceptRichTextBox.Clear();
                sendRichTextBox.Clear();
                OpenSelectedPort();
                //更改配置信息
                SetSerialPortPropertiesBeforeSending();
            }
            else
            {
                CloseCurrentPort();
            }
        }

        private void OpenSelectedPort()
        {
            try
            {
                //设置打开的端口号
                mySerialPort.PortName = portNameComboBox.SelectedItem.ToString();
                //打开选中串口
                mySerialPort.Open();
                //更换为打开状态的图片
                openStatusPictureBox.ImageLocation = @"icons\yes.jpg";
                //更新状态栏的显示
                statusDisplayToolStripStatusLabel.Text = string.Format("  打开端口 {0}成功！",
                    mySerialPort.PortName);
                openOrClosePortButton.Text = "关闭选中端口";
                //打开串口成功后
                OpenSelectedPortSuccessfully();
                LogHelper.WriteInfo(typeof(MainForm), "Open port " + this.portNameComboBox.SelectedItem.ToString() + " success.");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                LogHelper.WriteInfo(typeof(MainForm), "Open port" + this.portNameComboBox.SelectedItem.ToString() + " fail, error = " + ee.Message);
            }

        }

        private void OpenSelectedPortSuccessfully()
        {
            baudRateComboBox.Enabled = false;
            dataBitsComboBox.Enabled = false;
            stopBitsComboBox.Enabled = false;
            parityComboBox.Enabled = false;
            portNameComboBox.Enabled = false;
            sendSettingGroupBox.Enabled = true;
            acceptZoneSettingGroupBox.Enabled = true;
            sendZoneSettingGroupBox.Enabled = true;
            acceptRichTextBox.Enabled = true;
            sendRichTextBox.Enabled = true; 
        }

        private void CloseCurrentPort()
        {
            autoSend = false;
            autoSendCheckBox.Checked = false;
            //关闭选中串口
            mySerialPort.Close();
            //更换为关闭状态的图片
            openStatusPictureBox.ImageLocation = @"icons\no.jpg";
            //do something
            openOrClosePortButton.Text = "打开选中端口";
            //更新状态栏的显示
            statusDisplayToolStripStatusLabel.Text = string.Format("  关闭端口 {0}成功！",
                mySerialPort.PortName);
            //所有设置控件非使能态
            CloseSelectedPortSuccessfully();
            LogHelper.WriteInfo(typeof(MainForm), "Close port " + this.portNameComboBox.SelectedItem.ToString() + " success.");
        }

        private void CloseSelectedPortSuccessfully()
        {
            portNameComboBox.Enabled = true;
            acceptZoneSettingGroupBox.Enabled = false;
            sendZoneSettingGroupBox.Enabled = false;
            acceptRichTextBox.Enabled = true;
            sendRichTextBox.Enabled = true;
            baudRateComboBox.Enabled = true;
            dataBitsComboBox.Enabled = true;
            stopBitsComboBox.Enabled = true;
            parityComboBox.Enabled = true;
            sendSettingGroupBox.Enabled = false;
            totalReceivedBytes = 0;
            totalSendBytes = 0;
            isReading = false;
            //acceptRichTextBox.Clear();
            //sendRichTextBox.Clear();
        }

        private bool firstTime = false;
        int count = 2;
        private void updateDateTimer_Tick(object sender, EventArgs e)
        {
            //更新日期和时间的显示
            dateTimeToolStripStatusLabel.Text =
                DateTime.Now.ToString("yyyy/M/d dddd hh:mm:ss");
            if (isReading)
            {
                statusDisplayToolStripStatusLabel.Text += " .";
                if (statusDisplayToolStripStatusLabel.Text.Length > 30)
                {
                    //statusDisplayToolStripStatusLabel.Text = "就绪.";
                }
                //
            }
            if (hasStartSend)
            {
                startSendButton.Text += " .";
                if (startSendButton.Text.Length > 14)
                {
                    startSendButton.Text = initialText;
                }
            }
            if (count > 0)
            {
                count--;
                if (count == 0)
                {
                    if (firstTime && hasPorts)
                    {
                        //new AboutForm().ShowDialog();
                    }
                }
            }
        }

        private void saveAcceptBoxTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new StreamWriter("dataInfo.txt");
                sw.Close();
                needWrite = true;
                MessageBox.Show("最近数据已经保存到dataInfo.txt中！");
            }
            catch
            { }
        }

        private void clearAcceptBoxTextButton_Click(object sender, EventArgs e)
        {
            acceptRichTextBox.Clear();
            acceptStatusLabel.Text = "0字节";
            totalReceivedBytes = 0;
        }

        private void clearSendBoxTextButton_Click(object sender, EventArgs e)
        {
            sendRichTextBox.Clear();
            sendStatusLabel.Text = "0字节";
            totalSendBytes = 0;
        }

        private void startSendButton_Click(object sender, EventArgs e)
        {
      
            initialText = startSendButton.Text;

            if (this.sendRichTextBox.TextLength != 0)
            {
                SendTextNow();
            }
        }

        /// <summary>
        /// 开始向端口发送数据
        /// </summary>
        private void SendTextNow()
        {
            try
            {

                SerialPortSendChar(this.sendRichTextBox.Text.ToString());
                LogHelper.WriteInfo(typeof(MainForm), "Send Chars: " + this.sendRichTextBox.Text.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                LogHelper.WriteInfo(typeof(MainForm), "Send Chars: " + this.sendRichTextBox.Text.ToString() + " fail, error = " + e.Message);
            }
        }

        private void SerialPortSendChar(String str)
        {
            char[] ch = str.ToCharArray();
            foreach (var item in ch)
            {
                if (item <= 255)
                {
                    totalSendBytes += 1;
                }
                else
                {
                    totalSendBytes += 2;
                }
            }
            if (mySerialPort == null || mySerialPort.IsOpen == false)
            {
                MessageBox.Show("拒绝操作，没有任何串口被开启，无法发送数据！", "发送数据");
            }
            else
            {
                try
                {
                    mySerialPort.Write(ch, 0, ch.Length);
                    sendStatusLabel.Text = totalSendBytes.ToString() + "字节";
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        /// <summary>
        /// 在开始发送前设置串口信息。
        /// </summary>
        private void SetSerialPortPropertiesBeforeSending()
        {
            mySerialPort.Encoding = Encoding.Default;
            //设置成为选中的波特率
            mySerialPort.BaudRate = GetSelectedBaudRate();
            //设置成为选中的奇偶校验位
            mySerialPort.Parity = GetSelectedParity();
            //设置成为选中的数据位
            mySerialPort.DataBits = GetSelectedDataBits();
            //设置成为选中的端口停止位
            try
            {
                mySerialPort.StopBits = GetSelectedStopBits();
            }
            catch (IOException ee)
            {
                //MessageBox.Show(ee.Message + "已经将 停止位 设置为 默认一位 了！",
                //    "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mySerialPort.StopBits = StopBits.One;
                stopBitsComboBox.SelectedItem = "1";
            }

            //更新状态栏的显示
            statusDisplayToolStripStatusLabel.Text = string.Format(
                "当前打开的端口 {0}，波特率 {1}，奇偶校验 {2}， 数据位 {3}，停止位 {4}",
                portNameComboBox.SelectedItem, baudRateComboBox.SelectedItem, parityComboBox.SelectedItem,
                dataBitsComboBox.SelectedItem, stopBitsComboBox.SelectedItem);
            LogHelper.WriteInfo(typeof(MainForm), statusDisplayToolStripStatusLabel.Text);
        }

        private StopBits GetSelectedStopBits()
        {
            StopBits stopBits = StopBits.One;
            switch (stopBitsComboBox.SelectedItem.ToString())
            {
                case "1":
                    { stopBits = StopBits.One; }
                    break;
                case "2":
                    { stopBits = StopBits.Two; }
                    break;
                case "1.5":
                    { stopBits = StopBits.OnePointFive; }
                    break;
                default:
                    stopBits = StopBits.One;
                    break;
            }
            return stopBits;
        }

        private int GetSelectedDataBits()
        {
            int dataBits = 8;
            if (!(int.TryParse(dataBitsComboBox.SelectedItem.ToString(), out dataBits)))
            {
                MessageBox.Show("转换失败！");
            }
            return dataBits;
        }

        private Parity GetSelectedParity()
        {
            Parity parity = Parity.None;
            switch (parityComboBox.SelectedItem.ToString())
            {
                case "偶校验(Even)":
                    {
                        parity = Parity.Even;
                    }
                    break;
                case "奇校验(Odd)":
                    {
                        parity = Parity.Odd;
                    }
                    break;
                case "保留为0(Space)":
                    {
                        parity = Parity.Space;
                    }
                    break;
                case "保留为1(Mark)":
                    {
                        parity = Parity.Mark;
                    }
                    break;
                default:
                    {
                        parity = Parity.None;
                    }
                    break;
            }
            return parity;
        }

        private int GetSelectedBaudRate()
        {
            int baudRate = 0;
            if (!(int.TryParse(baudRateComboBox.SelectedItem.ToString(), out baudRate)))
            {
                baudRate = 9600;
            }
            return baudRate;
        }

        private void stopSendButton_Click(object sender, EventArgs e)
        {
            if (startSendButton.Enabled == false)
            {
                startSendButton.Enabled = true;
                startSendButton.Text = "发送数据";
                hasStartSend = false;
                autoSend = false;
                startSendButton.TextAlign = ContentAlignment.MiddleCenter;
                stopSendButton.Enabled = false;
                autoSendCheckBox.Enabled = true;
                if (autoSendCheckBox.Checked)
                    autoSendCheckBox.Checked = false;
                initialText = string.Empty;
                autoSendTimer.Enabled = false;
                intervalTimeNumericUpDown.Enabled = true;
                autoSendTimer.Stop();
            }
        }

        private void chooseFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chooseFileRadioButton.Checked)
            {
                //禁用发送区输入
                sendRichTextBox.Enabled = false;
                //弹出打开文件对话框
                ChooseFileToSend();
            }
            else
            {
                sendRichTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// 打开选择文件对话框，选择要发送的文件。
        /// </summary>
        private void ChooseFileToSend()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "txt文件|*.txt|其它文件|*.*";
            fd.FileName = "txt文件";
            fd.Title = "选择要发送的文件...";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //TO DO.
                using (StreamReader sr = new StreamReader(fd.FileName, Encoding.Default))
                {
                    sendRichTextBox.Clear();
                    sendRichTextBox.AppendText(sr.ReadToEnd());
                }
            }
            if (inputCharRadioButton.Checked == false)
                inputCharRadioButton.Checked = true;
        }

        private void intervalTimeNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            warningToolTip.Show("输入的范围应在0到10000之间", (NumericUpDown)sender);
        }

        private void portNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当改变端口名称时，则停止当前端口的通信，释放相关资源
            CloseCurrentPort();
            //初始化相关设置
            ResetToDefaultSettings();
            //更新状态栏显示
            statusDisplayToolStripStatusLabel.Text = "当前选中端口号：" + portNameComboBox.SelectedItem.ToString();
        }

        private void autoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sendRichTextBox.TextLength == 0)
            {
                this.autoSendCheckBox.Checked = false;
                autoSend = false;
                MessageBox.Show("没有需要发送的内容 >_<");
            }
            else
            {
                if (autoSendCheckBox.Checked == true)
                {
                    autoSend = true;
                    startSendButton.Enabled = false;
                    startSendButton.TextAlign = ContentAlignment.MiddleLeft;
                    startSendButton.Text = "自动发送中.";
                    initialText = startSendButton.Text;
                    hasStartSend = true;
                    if (stopSendButton.Enabled == false)
                        stopSendButton.Enabled = true;
                    //SetSerialPortPropertiesBeforeSending();

                    autoSendTimer.Enabled = true;
                    autoSendCheckBox.Enabled = false;
                    intervalTimeNumericUpDown.Enabled = false;
                    autoSendTimer.Interval = (int)intervalTimeNumericUpDown.Value;
                    autoSendTimer.Start();
                }
                else
                {
                    autoSend = false;
                    startSendButton.Enabled = true;
                    startSendButton.Text = "发送数据";
                    initialText = string.Empty;
                    hasStartSend = false;
                    startSendButton.TextAlign = ContentAlignment.MiddleCenter;
                    stopSendButton.Enabled = false;
                }
            }
        }


        /// <summary>
        /// 每次从SerialPort接收数据时发生，由于运行在辅助线程
        /// 所以必须要通过委托来实现跨线程。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string text = string.Empty;
                int size = sp.BytesToRead;
                if (myReceivedDataType == ReceivedDataType.HexType)
                {
                    for (int i = 0; i < size; i++)
                    {
                        int tempByte = sp.ReadByte();
                        string tempStr = "0X";
                        if (tempByte <= 0X0F)
                        {
                            tempStr = "0X0";
                        }
                        text +=
                            tempStr + Convert.ToString(tempByte, 16).ToUpper() + " ";
                    }
                }
                else
                {
                    text = sp.ReadExisting();
                }
                totalReceivedBytes += size;
                this.Invoke(UpdateTextHandler, text);
                //Thread.Sleep(50);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void UpdateText(string text)
        {
            if (showInfo)
            {
                acceptRichTextBox.Text += text;
                LogHelper.WriteInfo(typeof(MainForm), "Receive Chars: " + text);
                acceptStatusLabel.Text = totalReceivedBytes.ToString() + "字节";
            }
            isReading = true;
            statusDisplayToolStripStatusLabel.Text = "正在接收.";
        }

        /// <summary>
        /// 每次从SerialPort接收到错误时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }

        /// <summary>
        /// 每次SerialPort的Pin改变时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }

        private void intervalTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            autoSendTimer.Interval = (int)intervalTimeNumericUpDown.Value;
        }

        private void autoSendTimer_Tick(object sender, EventArgs e)
        {
            if (autoSend)
            {
                try
                {
                    SerialPortSendChar(this.sendRichTextBox.Text.ToString());
                }
                catch
                {

                }
            }
        }

        private void displayReadInfoButton_Click(object sender, EventArgs e)
        {
            if (displayReadInfoButton.Text == "不显示接收缓冲区内容")
            {
                showInfo = false;
                displayReadInfoButton.Text = "显示接收缓冲区内容";
            }
            else
            {
                showInfo = true;
                displayReadInfoButton.Text = "不显示接收缓冲区内容";
                //
            }
        }

        private void acceptCharRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.acceptRichTextBox.Clear();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    myReceivedDataType = ReceivedDataType.CharType;
                }
                else
                {
                    myReceivedDataType = ReceivedDataType.HexType;
                }
            }
        }

        private void acceptHexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.acceptRichTextBox.Clear();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (!rb.Checked)
                {
                    myReceivedDataType = ReceivedDataType.CharType;
                }
                else
                {
                    myReceivedDataType = ReceivedDataType.HexType;
                }
            }
        }

        private void sendCharRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    mySendDataType = SendDataType.CharType;
                }
                else
                {
                    mySendDataType = SendDataType.HexType;
                }
            }
        }

        private void sendHexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (!rb.Checked)
                {
                    mySendDataType = SendDataType.CharType;
                }
                else
                {
                    mySendDataType = SendDataType.HexType;
                }
            }
        }

        private void inputCharRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 保存配置信息SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig("串口助手配置.xml");
            MessageBox.Show("保存成功！");
        }

        private void 配置信息另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "串口助手自定义配置.xml";
            sfd.Filter = "xml|*.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveConfig(sfd.FileName);
                MessageBox.Show("保存成功！");
            }
        }

        private void 载入配置信息LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "xml|*.xml";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadConfig(opf.FileName);
                //MessageBox.Show("成功载入配置文件：" + opf.FileName);
            }
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           //退出前不保存配置。
            CloseCurrentPort();
            //SaveConfig("串口助手配置.xml");
            StopListenButton_Click(null, null);
            if (useXmlThread != null && useXmlThread.ThreadState == ThreadState.Running)
            {
                useXmlThread.Abort();
            }
            if (useXmlEvent != null)
            {
                useXmlEvent.Dispose();
            }
            return;
        }

        private void 关于软件AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AboutForm af = new AboutForm();
            //af.ShowDialog();
        }



        private void ListenButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            if (thread != null && thread.ThreadState == ThreadState.Running)
            {
                MessageBox.Show("已经在监听中...");
                return;
            }
            try
            {
                thread = new Thread(new ThreadStart( StartServer));
                thread.Start();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
           
        }

        private void SendMsgButton_Click(object sender, EventArgs e)
        {
            StartClient();
        }

        private void StopListenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (streamToClient != null)
                {
                    streamToClient.Close();
                }
                if (remoteClient != null)
                {
                    remoteClient.Close();
                }
                if (listener != null)
                {
                    listener.Stop();
                }
                if (thread != null && thread.ThreadState == ThreadState.Running)
                {
                    thread.Abort();
                }
                
                this.StopListenButton.Enabled = false;
                this.StartButton.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }

        private void SendInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("下发配置，暂时不支持");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个按钮无意义！");
        }

        //对比接收信息与发送信息是否一致
        private bool check()
        {
            if (this.sendRichTextBox.Text.Equals(this.acceptRichTextBox.Text))
            {
                LogHelper.WriteInfo(typeof(MainForm), "Check: Send chars == Receive chars.");
                return true;
            }
            LogHelper.WriteInfo(typeof(MainForm), "Check: Send chars != Receive chars.");
            return false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //检查是否在监听本地端口
            if (this.ListenButton.Enabled == true)
            {
                MessageBox.Show("需要监听本地端口");
                return;
            }
            //检查是否有配置文件列表
            if (this.XmlListBox.Items.Count == 0)
            {
                MessageBox.Show("需要添加配置文件信息");
                return;
            }

          

            useXmlThread = new Thread(useXmls);
            useXmlThread.Start();
            
        }

        //单独开一个线程，发送完消息后，暂停，等待窗口通知，然后继续
        //开始每个配置文件
        private void useXmls()
        {
            
            try
            {
                for (int i = 0; i < this.XmlListBox.Items.Count; i++)
                {
                    LogHelper.WriteInfo(typeof(MainForm), "自动测试, 配置文件为: " + XmlListBox.Items[i].ToString());
                    this.richTextBox2.Text = "USE XML " + XmlListBox.Items[i].ToString();
                    SendMsgButton_Click(null, null);
                    LoadConfig(XmlListBox.Items[i].ToString());
                    useXmlEvent.WaitOne();



                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                string xmlPath = dilog.SelectedPath;
                this.XmlPathTextBox.Text = xmlPath;
            }
        }

        private void XmlPathTextBox_TextChanged(object sender, EventArgs e)
        {
            this.XmlListBox.Items.Clear();
            DirectoryInfo TheFolder = new DirectoryInfo(this.XmlPathTextBox.Text);
            foreach (FileInfo NextFile in TheFolder.GetFiles())
            {
                //MessageBox.Show(NextFile.Extension);
                if (NextFile.Extension == ".xml")
                {
                    this.XmlListBox.Items.Add(NextFile.Name);
                }
                
            }
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "OVER")
            {
                useXmlEvent.Set();
            }
        }

        private void XmlContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.XmlListBox.Items.RemoveAt(this.XmlListBox.SelectedIndex);
        }
    }
}
