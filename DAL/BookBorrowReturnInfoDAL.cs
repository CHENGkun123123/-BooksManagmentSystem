using Common.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 图书借还表数据访问类
    /// </summary>
    public class BookBorrowReturnInfoDAL
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
    }
}
