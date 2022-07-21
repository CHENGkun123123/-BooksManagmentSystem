using BookModel;
using Common.Enum;
using Common.Tools;
using DAL;
using System;
using System.Data;

namespace BookBLL
{
    /// <summary>
    /// 管理员信息相关业务层
    /// </summary>
    public class AdminInfoBLL
    {
        /// <summary>
        /// 管理员信息表数据访问类
        /// </summary>
        AdminInfoDAL AdminInfoDAL = new AdminInfoDAL();

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public LoginStateEnum Login(AdminInfoModel admin)
        {
            //判断用户名和密码是否为空
            if (string.IsNullOrEmpty(admin.AdminID) || admin.AdminID == EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultNameErr))
            {
                return LoginStateEnum.NameNotErr;
            }
            else if (string.IsNullOrEmpty(admin.AdminPwd) || admin.AdminPwd == EnumHelper.GetDescription<Enum>(LoginStateEnum.DefaultPwdErr))
            {
                return LoginStateEnum.PwdNotErr;
            }
            //创建DataTable容器
            DataTable dataTable = AdminInfoDAL.GetAdminInfo(admin);
            //判断容器是否有内容
            if (dataTable.Rows.Count <= 0)
            {
                return LoginStateEnum.NameErr;
            }
            else if (MD5Tool.EncryptByMD5(admin.AdminPwd) != dataTable.Rows[0]["AdminPwd"].ToString())//判断密码是否一致
            {
                return LoginStateEnum.PwdErr;
            }
            return LoginStateEnum.ok;
        }
    }
}
