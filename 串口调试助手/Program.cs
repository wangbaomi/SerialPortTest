using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 串口调试助手
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
            {
               // MessageBox.Show(args.ToString());
                Application.Run(new MainForm(args[0]));
            }
            else
            {
                Application.Run(new MainForm()); 
            } 
            //Application.Run(new MainForm());
        }
    }
}
