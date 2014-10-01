using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 串口调试助手
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// 变量：声明串口变量。
        /// </summary>
        private System.IO.Ports.SerialPort myBluetoothSerialPort;

        /// <summary>
        /// 标志窗口是否可见
        /// </summary>
        private bool showFlag = true;

        /// <summary>
        /// 委托声明，用来接收数据时。
        /// </summary>
        /// <param name="str"></param>
        public delegate void DataReceivedCallback(string str);
        public DataReceivedCallback DataReceivedHandler;

        //各种控制定义
        private string SPEEDUP_SHORTCUT = "{UP}";  //加速
        private string SLOWDOWN_SHORTCUT = "{DOWN}"; //减速
        private string TURNLEFT_SHORTCUT = "{LEFT}"; //左转
        private string TURNRIGHT_SHORTCUT = "{RIGHT}";    //右转
        private string N2_SHORTCUT = "M";   //释放氮气
        private string OTHERTOOLS_SHORTCUT = "{ENTER}";   //其他控制键

        /// <summary>
        /// 调用系统的API来进行按键的虚拟
        /// </summary>
        /// <param name="keyCode">按键值</param>
        /// <param name="keyScan">扫描码，一般为0</param>
        /// <param name="keyFlags">按键的标志，0为按下，1为一次完整的按键，2为释放</param>
        /// <param name="keyExtraInfo">额外信息，一般为0</param>
        [DllImport("User32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte keyCode,
            byte keyScan,
            int keyFlags,
            int keyExtraInfo
            );
        public enum State
        {
            Down = 0,
            DownAndUp,
            Up
        }

        /// <summary>
        /// 鼠标事件的模拟！
        /// </summary>
        /// <param name="dwFlags">详见下面的注释中的组合等模式。</param>
        /// <param name="dx">根据MOUSEEVENTF_ABSOLUTE标志，指定x,y的绝对或者相对坐标</param>
        /// <param name="dy">同上</param>
        /// <param name="cButtons">没有使用</param>
        /// <param name="dwExtraInfo">没用使用</param>
        /// 关于dwFlags:
        [DllImport("User32.dll")]
        public static extern void mouse_event(
            int dwFlags,
            int dx,
            int dy,
            int cButtons,
            int dwExtraInfo
            );

        private const int MOUSEEVENT_MOVE = 0X0001; //模拟鼠标移动
        private const int MOUSEEVENT_LEFTDOWN = 0X0002; //模拟鼠标左键按下
        private const int MOUSEEVENT_LEFTUP = 0X0004;   //模拟鼠标左键抬起
        private const int MOUSEEVENT_RIGHTDOWN = 0X0008;    //模拟鼠标右键按下
        private const int MOUSEEVENT_RIGHTUP = 0X0010;  //模拟鼠标右键抬起
        private const int MOUSEEVENT_MIDDLEDOWN = 0X0020;   //模拟鼠标中键按下
        private const int MOUSEEVENT_MIDDLEUP = 0X0040; //模拟鼠标中键抬起
        private const int MOUSEEVENT_ABSOLUTE = 0X8000; //表示是否使用绝对坐标

        private int prePosX = 0, prePosY = 0;
        private int nowPosX = 0, nowPosY = 0;
        
        /// <summary>
        /// 对指令进行解析
        /// </summary>
        /// <param name="text"></param>
        private void AnalyzeCommands(string text)
        {
            int x = 0;
            int y = 0;
            switch (text)
            {
                case "MUp&":
                    y -= 5;
                    mouse_event(MOUSEEVENT_MOVE, x, y, 0, 0);
                    break;
                case "MDown&":
                    y += 5;
                    mouse_event(MOUSEEVENT_MOVE, x, y, 0, 0);
                    break;
                default:
                    break;
            }
        }
        //SuperKeys.WinIoSys keyBoard = new SuperKeys.WinIoSys();
    }
}
