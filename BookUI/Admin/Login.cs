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
using Common.Tools;

namespace BookUI
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class Login : Skin_VS
    {
        /// <summary>
        /// 默认构造方法
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
            //判断控件Text内容
            if (AdminIdChk.Text == EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultNameErr))
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
            //判断控件Text内容
            if (AdminIdChk.Text.Length == (int)JudgeEnum.Default_State)
            {
                AdminIdChk.Text = EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultNameErr);
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
            //判断控件Text内容
            if (AdminPwdChk.Text == EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultPwdErr))
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
            //判断控件Text内容
            if (AdminPwdChk.Text.Length == (int)JudgeEnum.Default_State)
            {
                AdminPwdChk.Text = EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultPwdErr);
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
            //赋值
            AdminInfoModel admin = new AdminInfoModel(AdminIdChk.Text, AdminPwdChk.Text);
            //输出登录信息
            MessageBox.Show(EnumHelper.GetDescription<Enum>(new AdminInfoBLL().Login(admin)));
        }

    }
}
