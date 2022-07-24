using BookModel;
using Common.Helper;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员信息表数据访问类
    /// </summary>
    public class AdminInfoDAL
    {
        /// <summary>
        /// 根据用户名获取管理员信息
        /// </summary>
        /// <param name="admin">管理员实体类</param>
        /// <returns></returns>
        public DataTable GetAdminInfo(AdminInfoModel admin)
        {
            string sql = "select * from AdminInfo where AdminID = @name";

            SqlParameter[] pars =
            {
                new SqlParameter("@name" , admin.AdminID),
            };

            return SqlDBHelper.ExecuteDataTable(sql, pars);
        }
    }
}
