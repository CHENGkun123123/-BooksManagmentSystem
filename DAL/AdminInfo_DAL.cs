using BookModel;
using Common.Helper;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 管理员信息数据访问类
    /// </summary>
    public class AdminInfo_DAL
    {
        /// <summary>
        /// 根据用户名获取管理员信息
        /// </summary>
        /// <param name="admin">管理员实体类</param>
        /// <returns></returns>
        public DataTable GetAdminInfo(AdminInfo_Model admin)
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
