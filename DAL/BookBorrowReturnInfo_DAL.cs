using Common.Enum;
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
    /// 图书借还表数据访问类
    /// </summary>
    public class BookBorrowReturnInfo_DAL
    {
        /// <summary>
        /// 连表获取借还记录信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo()
        {
            string sql = @"SELECT a.ID ID,a.BookID 图书编号,a.ReaderID 读者编号,a.BorrowTime 借书时间,a.ReturnTime 还书时间,b.Name 图书名称,c.ReadName 读者名字,c.Mobile 读者电话,c.Address 读者地址 FROM [dbo].[BookBorrowReturnInfo] a
                           LEFT JOIN [dbo].[BookInfo] b
                           ON a.BookID = b.BookID
                           LEFT JOIN [dbo].[ReaderInfo] c
                           ON c.ReaderID = a.ReaderID";
            return SqlDBHelper.ExecuteDataTable(sql, null);
        }

        /// <summary>
        /// 根据读者id获取未还记录
        /// </summary>
        /// <param name="readerid">读者id</param>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo(string readerid)
        {
            string sql = @"SELECT ID ID,ReaderID 读者编号,BookID 图书编号,BorrowTime 借书时间 FROM [dbo].[BookBorrowReturnInfo]
                          WHERE ReaderID = @ReaderID AND ReturnTime IS NULL";

            SqlParameter[] pars =
            {
                new SqlParameter("@ReaderID",readerid)
            };

            return SqlDBHelper.ExecuteDataTable(sql, pars);
        }

        /// <summary>
        /// 根据书籍id和读者id更新还书时间和书籍状态-使用事务
        /// </summary>
        /// <returns></returns>
        public bool UpDBorrowTr(string readerId, string bookId)
        {
            string[] sql =
            {
                //操作借还记录表
                @"UPDATE [dbo].[BookBorrowReturnInfo] SET ReturnTime = @ReturnTime
                WHERE ReaderID = @ReaderID AND BookID = @BookID",
                //操作图书表
                @"UPDATE [dbo].[BookInfo] SET State = @State
                WHERE BookId = @BookId",
             };

            SqlParameter[] pars1 =
            {
                new SqlParameter("@ReturnTime",DateTime.Now.ToString()),
                new SqlParameter("@ReaderID",readerId),
                new SqlParameter("@BookID",bookId),
            };
            SqlParameter[] pars2 =
            {
                new SqlParameter("@State",BookState_Enum.Default_State),//未借出状态
                new SqlParameter("@BookId2",bookId)
            };
            List<SqlParameter[]> parsList = new List<SqlParameter[]>
            {
                pars1,pars2
            };

            return SqlDBHelper.ExecuteNonQueryT(sql, parsList);
        }

        /// <summary>
        /// 根据书籍id和读者id更新借书时间和书籍状态-使用事务
        /// </summary>
        /// <returns></returns>
        public bool UpDReturnTr(string readerId, string bookId)
        {
            string[] sql =
            {
                //操作借还记录表
                @"INSERT INTO [dbo].[BookBorrowReturnInfo] VALUES(@BookID,@ReaderID,@BorrowTime,@ReturnTime)",
                //操作图书表
                @"UPDATE [dbo].[BookInfo] SET State = @State
                WHERE BookId = @BookId",
             };

            SqlParameter[] pars1 =
            {
                new SqlParameter("@BookID",bookId),
                new SqlParameter("@ReaderID",readerId),
                new SqlParameter("@BorrowTime",DateTime.Now.ToString()),
                new SqlParameter("@ReturnTime",DBNull.Value)
            };
            SqlParameter[] pars2 =
            {
                new SqlParameter("@State",BookState_Enum.Lend_State),//未借出状态
                new SqlParameter("@BookId2",bookId)
            };
            List<SqlParameter[]> parsList = new List<SqlParameter[]>
            {
                pars1,pars2
            };

            return SqlDBHelper.ExecuteNonQueryT(sql, parsList);
        }
    }
}
