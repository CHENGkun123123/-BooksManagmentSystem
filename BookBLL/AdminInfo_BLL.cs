using BookModel;
using Common.Enum;
using Common.Tools;
using DAL;
using System;
using System.Data;

namespace BookBLL
{
    /// <summary>
    /// 管理员信息业务类
    /// </summary>
    public class AdminInfo_BLL
    {
        /// <summary>
        /// 管理员信息数据访问类
        /// </summary>
        AdminInfo_DAL AdminInfoDAL = new AdminInfo_DAL();

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public LoginState_Enum Login(AdminInfo_Model admin)
        {
            //判断用户名和密码是否为空
            if (string.IsNullOrEmpty(admin.AdminID) || admin.AdminID == EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultNameErr))
            {
                return LoginState_Enum.NameNotErr;
            }
            else if (string.IsNullOrEmpty(admin.AdminPwd) || admin.AdminPwd == EnumHelper.GetDescription<Enum>(LoginState_Enum.DefaultPwdErr))
            {
                return LoginState_Enum.PwdNotErr;
            }
            //创建DataTable容器
            DataTable dataTable = AdminInfoDAL.GetAdminInfo(admin);
            //判断容器是否有内容
            if (dataTable.Rows.Count <= 0)
            {
                return LoginState_Enum.NameErr;
            }
            else if (MD5Tool.EncryptByMD5(admin.AdminPwd) != dataTable.Rows[0]["AdminPwd"].ToString())//判断密码是否一致
            {
                return LoginState_Enum.PwdErr;
            }
            return LoginState_Enum.ok;
        }
    }
}
