using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Common.Helper
{
    /// <summary>
    /// 数据库访问类
    /// </summary>
    public class SqlDBHelper
    {
        //数据库链接串
        private static string connString = ConfigurationManager.ConnectionStrings["Books"].ToString();

        /// <summary>
        /// 打开数据库链接
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlConnection ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
;           conn.Open();

            return conn;
        }

    }
}
