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
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using leomon;

namespace 串口调试助手
{
    public partial class MainForm : Form
    {
        private void SaveConfig(string fileName)
        {
            Editor editor = new Editor();
            if (hasPorts)
            {           
                //保存选中的端口
                editor.PutInt32("selectedPort", this.portNameComboBox.SelectedIndex);
                //保存设置的波特率
                editor.PutInt32("baudRate", this.baudRateComboBox.SelectedIndex);
                //保存设置的校验方式
                editor.PutInt32("parity", this.parityComboBox.SelectedIndex);
                //保存设置的数据位
                editor.PutInt32("dataBits", this.dataBitsComboBox.SelectedIndex);
                //保存设置的停止位
                editor.PutInt32("stopBits", this.stopBitsComboBox.SelectedIndex);
                //保存自动发送数据时间间隔
                editor.PutInt32("intervalTime", (int)this.intervalTimeNumericUpDown.Value);
                //保存接收方式
                editor.PutBoolean("acceptChar", this.acceptCharRadioButton.Checked);
                editor.PutBoolean("acceptHex", this.acceptHexRadioButton.Checked);
                //保存发送方式
                editor.PutBoolean("sendChar", this.sendCharRadioButton.Checked);
                editor.PutBoolean("sendHex", this.sendHexRadioButton.Checked);
                //保存标志变量，即是否在接收框中显示信息。
                editor.PutBoolean("showInfo", showInfo);

                //保存发送字符串
                editor.PutString("sendString", this.sendRichTextBox.Text);            
                SharedPreferences sp = new SharedPreferences(fileName);
                //记得调用该方法将上述内容一次写入并保存。
                sp.Save(editor);
            }
            
        }

        private void LoadConfig(string fileName)
        {
            CloseCurrentPort();
            SharedPreferences sp = new SharedPreferences(fileName);
            if (sp.ConfigFileExists)
            {
                LogHelper.WriteInfo(typeof(MainForm), "加载配置文件: " + fileName);
                //读取选中的端口
                //if (hasPorts)
                //{
                //    portNameComboBox.SelectedIndex = sp.GetInt32("selectedPort", 0);
                //}
                //读取设置的波特率
                baudRateComboBox.SelectedIndex = sp.GetInt32("baudRate", 0);
                //读取设置的校验方式
                parityComboBox.SelectedIndex = sp.GetInt32("parity", 0);
                //读取设置的数据位
                dataBitsComboBox.SelectedIndex = sp.GetInt32("dataBits", 0);
                //读取设置的停止位
                stopBitsComboBox.SelectedIndex = sp.GetInt32("stopBits", 0);
                //读取自动发送数据时间间隔
                intervalTimeNumericUpDown.Value = (decimal)sp.GetInt32("intervalTime", 500);
                //读取接收方式
                acceptCharRadioButton.Checked = sp.GetBoolean("acceptChar", true);
                acceptHexRadioButton.Checked = sp.GetBoolean("acceptHex", false);
                //读取发送方式
                sendCharRadioButton.Checked = sp.GetBoolean("sendChar", true);
                sendHexRadioButton.Checked = sp.GetBoolean("sendHex", true);
                //读取要发送的字符串
                sendRichTextBox.Text = sp.GetString("sendString", "");
                //读取标志变量，即是否在接收框中显示信息。
                showInfo = sp.GetBoolean("showInfo", true);
                if (showInfo)
                {
                    displayReadInfoButton.Text = "不显示接收缓冲区内容";
                }
                else
                {
                    displayReadInfoButton.Text = "显示接收缓冲区内容";
                }

                this.acceptRichTextBox.Clear();
                firstTime = false;
            }
            else
            {
                firstTime = true;
                //载入默认设置
                MessageBox.Show("没有找到配置文件，使用默认配置");
                LogHelper.WriteDebug(typeof(MainForm), "没有找到配置文件，使用默认配置");
                ResetToDefaultSettings();
            }
            if (openOrClosePortButton.Text == "打开选中端口")
            {
                acceptRichTextBox.Clear();
                OpenSelectedPort();
                //更改配置信息
                SetSerialPortPropertiesBeforeSending();
            }
            else
            {
                CloseCurrentPort();
            }
        }

        private void StartServer()
        {

            try 
            {
                IPAddress.Parse(this.LocalIPTextBox.Text);
                Int32.Parse(this.LocalPortTextBox.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            const int BufferSize = 1024;

            IPAddress ip = IPAddress.Parse(this.LocalIPTextBox.Text);
            Int32 port = Int32.Parse(this.LocalPortTextBox.Text);

            try
            {
                listener = new TcpListener(ip, port);
                listener.Start();           // 开始侦听
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.ListenButton.Enabled = false;

            

            // 获取一个连接，中断方法
            remoteClient = listener.AcceptTcpClient();
            // 打印连接到的客户端信息
            //Console.WriteLine("Client Connected！{0} <-- {1}",
                //remoteClient.Client.LocalEndPoint, remoteClient.Client.RemoteEndPoint);

            // 获得流，并写入buffer中
            streamToClient = remoteClient.GetStream();
            try
            {
                do
                {
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead = streamToClient.Read(buffer, 0, BufferSize);
                    //Console.WriteLine("Reading data, {0} bytes ...", bytesRead);

                    // 获得请求的字符串
                    string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                    //Console.WriteLine("Received: {0}", msg);
                    //MessageBox.Show(msg);
                    this.richTextBox1.Text = msg;

                    HandleCmd(msg);
                } while (true);
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                streamToClient.Close();
                remoteClient.Close();
                listener.Stop();
                return;
            }
        }


        private void StartClient()
        {
            try
            {
                IPAddress.Parse(this.RemoteIPTextBox.Text);
                Int32.Parse(this.RemotePortTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            //TcpClient client;
            Console.WriteLine("Client Running ...");
            if (client == null)
            {
                IPAddress ip = IPAddress.Parse(this.RemoteIPTextBox.Text);
                Int32 port = Int32.Parse(this.RemotePortTextBox.Text);
                try
                {
                    client = new TcpClient();
                    client.Connect(ip, port);      // 与服务器连接
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
      
            // 打印连接到的服务端信息
            Console.WriteLine("Server Connected！{0} --> {1}",
                client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

            string msg = this.richTextBox2.Text;
            NetworkStream streamToServer = client.GetStream();
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes(msg);     // 获得缓存
                streamToServer.Write(buffer, 0, buffer.Length);     // 发往服务器
                //Console.WriteLine("Sent: {0}", msg);
                LogHelper.WriteDebug(typeof(MainForm), "发送指令: " + msg);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
                streamToServer.Close();
                client.Close();
                LogHelper.WriteDebug(typeof(MainForm), "发送指令: " + msg + " fail, error = " + ex.Message);
                return;
            }

        }

        private void HandleCmd(string cmd)
        {
            LogHelper.WriteDebug(typeof(MainForm), "接收指令: " +  cmd);
            //如果收到USE XML XXX的消息，就加载这个配置文件，并打开串口, 然后发送指令 USE OK
            if (cmd.Contains("USE XML"))
            {
                string file = cmd.Split(default(Char[]), 3, StringSplitOptions.RemoveEmptyEntries)[2];
                //MessageBox.Show(file);

                LoadConfig(file);
                this.richTextBox2.Text = "USE OK";
                SendMsgButton_Click(null, null);
            }
            //如果收到USE OK的消息，说明对方已经加载好配置文件，并已经打开了串口；
            //这边就可以发字符串了，然后发送指令 SEND OK
            else if (cmd.Contains("USE OK"))
            {
                //MessageBox.Show("USE OK");
                startSendButton_Click(null, null);
                this.richTextBox2.Text = "SEND OK";
                SendMsgButton_Click(null, null);
            }
            //如果收到SEND OK消息，说明对方已经发送了字符串，这边可以接收并检查接收的字符串了，
            //然后发送字符串到串口，最后发送 SEND OVER指令，表明双方都发送完毕
            else if (cmd.Contains("SEND OK"))
            {
                //MessageBox.Show("SEND OK");
                bool ret = check();
                //MessageBox.Show(ret.ToString());
                startSendButton_Click(null, null);
                this.richTextBox2.Text = "SEND OVER";
                SendMsgButton_Click(null, null);
            }
            //如果收到 SEND OVER消息，说明己方和对方都已发送了串口消息，一个配置文件测试完毕
            else if (cmd.Contains("SEND OVER"))
            {
                //MessageBox.Show("SEND OVER");
                bool ret = check();
                //MessageBox.Show(ret.ToString());
                this.richTextBox1.Text = ("OVER");
            }
            else
            {
                //MessageBox.Show("ERROR");
                LogHelper.WriteDebug(typeof(MainForm), "接收指令: " + cmd + ", 非法指令!");
            }

        }

    }
}
