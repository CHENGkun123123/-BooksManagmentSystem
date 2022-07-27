using BookUI.Admin;
using System;
using System.Windows.Forms;

namespace BookUI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //登录窗体
            Login_Form login_Form = new Login_Form();
            //判断是否登录成功
            if (login_Form.ShowDialog() == DialogResult.OK)
            {
                //启动主页
                Application.Run(new SystemHome_From(login_Form.Name));
            }
        }
    }
}
