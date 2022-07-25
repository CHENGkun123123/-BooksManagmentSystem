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
    /// 读者信息表数据访问类
    /// </summary>
    public class ReaderInfoDAL
    {
        /// <summary>
        /// 获取读者信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindReaders()
        {
            string sql = @"SELECT id ID,ReaderID 读者编号,ReadName 读者姓名,EMail 读者邮箱,Address 读者地址,Mobile 读者电话 FROM [dbo].[ReaderInfo]";
            return SqlDBHelper.ExecuteDataTable(sql, null);
        }
        /// <summary>
        /// 根据读者id获取读者信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetReader(string readerId)
        {
            string sql = @"SELECT id ID,ReaderID 读者编号,ReadName 读者姓名,EMail 读者邮箱,Address 读者地址,Mobile 读者电话 FROM [dbo].[ReaderInfo]
                        WHERE ReaderID = @id";

            SqlParameter[] sprs =
            {
                new SqlParameter("@id",readerId)
            };
            return SqlDBHelper.ExecuteDataTable(sql, sprs);
        }


    }
}
