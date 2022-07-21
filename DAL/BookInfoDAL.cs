using BookModel;
using Common.Helper;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 图书信息表数据访问层
    /// </summary>
    public class BookInfoDAL
    {
        /// <summary>
        /// 添加图书信息
        /// </summary>
        public int BookAdd(BookInfoModel model)
        {
            string sql = "Insert Into BookInfo Values(@Name,@CategoryType,@Author,@Money,@BookID,@State)";

            SqlParameter[] pars =
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@CategoryType",model.CategoryType),
                new SqlParameter("@Author",model.@Author),
                new SqlParameter("@Money",model.Money),
                new SqlParameter("@BookID",UUIDUtils.UUIDRandom()),//生成图书编号
                new SqlParameter("@State",model.State),
            };

            return SqlDBHelper.ExecuteNonQuery(sql, pars);
        }
    }
}
