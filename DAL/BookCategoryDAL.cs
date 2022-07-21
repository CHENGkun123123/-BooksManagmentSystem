using Common.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 图书类型表数据访问层
    /// </summary>
    public class BookCategoryDAL
    {
        /// <summary>
        /// 获取类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()
        {
            string sql = "SELECT * FROM BookCategory WHERE ParentID!=@Parentid";

            SqlParameter par = new SqlParameter("@Parentid","0");//父级id

            return SqlDBHelper.ExecuteDataTable(sql, par);
        }
    }
}
