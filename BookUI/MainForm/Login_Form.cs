using BookBLL;
using BookModel;
using CCWin;
using Common.Enum;
using Common.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookUI
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class Login_Form : Skin_VS
    {
        /// <summary>
        /// 管理员业务类
        /// </summary>
        AdminInfo_BLL adminInfoBLL = new AdminInfo_BLL();
        #region 字段
        /// <summary>
        /// 用户名
        /// </summary>
        string _name;
        #endregion
        #region 属性
        /// <summary>
        /// 用户名属性
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        #endregion



        /// <summary>
        /// 默认构造方法
        /// </summary>
        public Login_Form()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 用户名输入框控件活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminIdChk_Enter(object sender, EventArgs e)
        {
            //判断控件Text内容
            if (AdminId_Tb.Text == EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultNameErr))
            {
                AdminId_Tb.Text = null;
            }
            AdminId_Tb.ForeColor = Color.Black;
        }

        /// <summary>
        /// 用户名输入框控件离开活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminIdChk_Leave(object sender, EventArgs e)
        {
            //判断控件Text内容
            if (AdminId_Tb.Text.Length == (int)Judge_Enum.Default_State)
            {
                AdminId_Tb.Text = EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultNameErr);
                AdminId_Tb.ForeColor = Color.DimGray;
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
            if (AdminPwd_Tb.Text == EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultPwdErr))
            {
                AdminPwd_Tb.Text = null;
                AdminPwd_Tb.IsSystemPasswordChar = true;
            }
            AdminPwd_Tb.ForeColor = Color.Black;
        }

        /// <summary>
        /// 密码输入框控件离开活动时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPwdChk_Leave(object sender, EventArgs e)
        {
            //判断控件Text内容
            if (AdminPwd_Tb.Text.Length == (int)Judge_Enum.Default_State)
            {
                AdminPwd_Tb.Text = EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultPwdErr);
                AdminPwd_Tb.IsSystemPasswordChar = false;
                AdminPwd_Tb.ForeColor = Color.DimGray;
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
            AdminInfo_Model admin = new AdminInfo_Model(AdminId_Tb.Text, AdminPwd_Tb.Text);
            if (adminInfoBLL.Login(admin) == LoginState_Enum.ok)
            {
                //返回登录结果
                DialogResult = DialogResult.OK;
                this.Name = AdminId_Tb.Text;
                this.Close();
            }
            else
            {
                //输出错误信息
                MessageBox.Show(EnumHelper.GetDescription<Enum>(adminInfoBLL.Login(admin)));
            }
        }
        #endregion


    }
}
