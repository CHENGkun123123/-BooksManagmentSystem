using BookModel;
using Common.Helper;
using Common.Utils;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 图书信息表数据访问类
    /// </summary>
    public class BookInfoDAL
    {
        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int BookAdd(BookInfoModel model)
        {
            string sql = "Insert Into BookInfo Values(@Name,@CategoryType,@Author,@Money,@BookID,@State)";

            SqlParameter[] pars =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@CategoryType",model.CategoryType),
                new SqlParameter("@Author",model.@Author),
                new SqlParameter("@Money",model.Money),
                new SqlParameter("@BookID","B"+UUIDUtils.UUIDRandom()),//生成图书编号
                new SqlParameter("@State",model.State),
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int BookDel(int id)
        {
            string sql = "DELETE FROM BookInfo WHERE ID = @ID";

            SqlParameter[] pars =
            {
                new SqlParameter("@ID",id)
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }

        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <returns></returns>
        public int BookUpd(BookInfoModel model)
        {
            string sql = @"UPDATE BookInfo SET Name=@Name,CategoryType=@CategoryType,Author=@Author,Money=@Money WHERE ID=@ID";

            SqlParameter[] pars =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@CategoryType",model.CategoryType),
                new SqlParameter("@Author",model.@Author),
                new SqlParameter("@Money",model.Money),
                new SqlParameter("@ID",model.Id)
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }

        /// <summary>
        /// 连表获取图书信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCategoryIdBookInfo(string categoryId)
        {
            string sql = @"SELECT a.ID 图书ID,a.Name 图书名称,a.Author 图书作者,a.Money 图书价格,a.BookID 图书编号,c.CategoryName 图书类型,a.CategoryType 图书类别id,b.Description 借出状态 FROM BookInfo a
                           LEFT JOIN BookState b
                           ON a.State = b.BookState
                           LEFT JOIN BookCategory c
                           ON a.CategoryType = c.CategoryID
                           WHERE a.CategoryType like @CategoryType";
            SqlParameter[] pars =
            {
                new SqlParameter("@CategoryType",$"%{categoryId}%")
            };
            return SqlDBHelper.ExecuteDataTable(sql, pars);
        }

        /// <summary>
        /// 连表获取图书信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookInfo(string id)
        {
            string sql = @"SELECT a.ID 图书ID,a.Name 图书名称,a.Author 图书作者,a.Money 图书价格,a.BookID 图书编号,c.CategoryName 图书类型,a.CategoryType 图书类别id,b.Description 借出状态 FROM BookInfo a
                           LEFT JOIN BookState b
                           ON a.State = b.BookState
                           LEFT JOIN BookCategory c
                           ON a.CategoryType = c.CategoryID
                           WHERE a.ID like @ID";
            SqlParameter[] pars =
            {
                new SqlParameter("@ID",$"%{id}%")
            };
            return SqlDBHelper.ExecuteDataTable(sql, pars);
        }
    }
}
