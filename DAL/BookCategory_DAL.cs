using Common.Helper;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 图书类型表数据访问类
    /// </summary>
    public class BookCategory_DAL
    {
        /// <summary>
        /// 获取子类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()
        {
            string sql = "SELECT * FROM BookCategory WHERE ParentID!=@Parentid";

            SqlParameter par = new SqlParameter("@Parentid", "0");//父级id

            return SqlDBHelper.ExecuteDataTable(sql, par);
        }

        /// <summary>
        /// 获取父类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindParentCategory()
        {
            string sql = "SELECT * FROM BookCategory WHERE ParentID=@Parentid";

            SqlParameter par = new SqlParameter("@Parentid", "0");//父级id

            return SqlDBHelper.ExecuteDataTable(sql, par);
        }
    }
}
