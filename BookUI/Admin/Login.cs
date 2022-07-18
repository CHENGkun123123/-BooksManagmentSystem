using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBLL;
using BookModel;
using CCWin;
using Common.Enum;

namespace BookUI
{
    public partial class Login : Skin_VS
    {
        /// <summary>
        /// 登录窗体初始化
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户名输入框控件活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminIdChk_Enter(object sender, EventArgs e)
        {
            if (AdminIdChk.Text == "点击输入用户名")
            {
                AdminIdChk.Text = null;
            }
            AdminIdChk.ForeColor = Color.Black;
        }

        /// <summary>
        /// 用户名输入框控件离开活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminIdChk_Leave(object sender, EventArgs e)
        {
            if (AdminIdChk.Text.Length == (int)AdminInfoEnum.TextLength)
            {
                AdminIdChk.Text = "点击输入用户名";
                AdminIdChk.ForeColor = Color.DimGray;
            }

        }

        /// <summary>
        /// 密码输入框控件活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPwdChk_Enter(object sender, EventArgs e)
        {
            if (AdminPwdChk.Text == "点击输入密码")
            {
                AdminPwdChk.Text = null;
                AdminPwdChk.IsSystemPasswordChar = true;
            }
            AdminPwdChk.ForeColor = Color.Black;
        }

        /// <summary>
        /// 密码输入框控件离开活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPwdChk_Leave(object sender, EventArgs e)
        {
            if (AdminPwdChk.Text.Length == (int)AdminInfoEnum.TextLength)
            {
                AdminPwdChk.Text = "点击输入密码";
                AdminPwdChk.IsSystemPasswordChar = false;
                AdminPwdChk.ForeColor = Color.DimGray;
            }
        }
        /// <summary>
        /// 登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            AdminInfoModel admin = new AdminInfoModel
            {
                AdminID = AdminIdChk.Text,
                AdminPwd = AdminPwdChk.Text
            };

            if (string.IsNullOrEmpty(admin.AdminPwd) || AdminIdChk.Text == "点击输入用户名")
            {
                MessageBox.Show("请输入账号！");
            }
            else if (string.IsNullOrEmpty(admin.AdminID) || AdminPwdChk.Text == "点击输入密码")
            {
                MessageBox.Show("请输入密码！");
            }
            else
            {
                MessageBox.Show(new AdminInfoBLL().Login(admin));
            }
        }
    }
}
