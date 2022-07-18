using BookModel;
using Common.Tools;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBLL
{
    /// <summary>
    /// 管理员业务层
    /// </summary>
    public class AdminInfoBLL
    {

        public string Login(AdminInfoModel admin)
        {
            DataTable dataTable = new AdminInfoDAL().GetAdminInfo(admin);
            if (dataTable.Rows.Count<=0)
            {
                return "账户不存在";
            }
            else if (MD5Tool.EncryptByMD5(admin.AdminPwd) != dataTable.Rows[0]["AdminPwd"].ToString())//判断密码是否一致
            {
                return "密码错误";
            }
            return "登录成功";
        }
    }
}
