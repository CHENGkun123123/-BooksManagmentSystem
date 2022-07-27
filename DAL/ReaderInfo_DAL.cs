using BookModel;
using Common.Helper;
using Common.Utils;
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
    public class ReaderInfo_DAL
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
                        WHERE ReaderID = @readerId";

            SqlParameter[] sprs =
            {
                new SqlParameter("@readerId",readerId)
            };
            return SqlDBHelper.ExecuteDataTable(sql, sprs);
        }

        /// <summary>
        /// 根据读者编号删除读者信息
        /// </summary>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int DelReader(string readerId)
        {
            string sql = @"DELETE FROM ReaderInfo WHERE ReaderID = @ReaderID";

            SqlParameter[] sprs =
            {
                new SqlParameter("@ReaderID",readerId)
            };
            return SqlDBHelper.ExecuteNonQuery(sql, sprs);
        }

        /// <summary>
        /// 添加读者
        /// </summary>
        /// <returns></returns>
        public int AddReader(ReaderInfoModel model)
        {
            string sql = @"Insert Into ReaderInfo Values(@ReaderId,@ReadName,@EMail,@Address,@Mobile)";

            SqlParameter[] pars =
            {
                new SqlParameter("@ReaderId","R"+UUIDUtils.UUIDRandom()),//生成读者编号
                new SqlParameter("@ReadName",model.ReadName),
                new SqlParameter("@EMail",model.EMail),
                new SqlParameter("@Address",model.Address),
                new SqlParameter("@Mobile",model.Mobile),
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }

        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <returns></returns>
        public int ReaderUpd(ReaderInfoModel model)
        {
            string sql = @"UPDATE ReaderInfo SET ReadName=@ReadName,EMail=@EMail,Address=@Address,Mobile=@Mobile WHERE ID=@ID";

            SqlParameter[] pars =
            {
                new SqlParameter("@ReadName",model.ReadName),
                new SqlParameter("@EMail",model.EMail),
                new SqlParameter("@Address",model.Address),
                new SqlParameter("@Mobile",model.Mobile),
                new SqlParameter("@ID",model.Id)
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }
    }
}
