using BookModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBLL
{
    /// <summary>
    /// 图书信息相关业务层
    /// </summary>
    public class BookInfoBLL
    {
        /// <summary>
        /// 图书信息表数据访问类
        /// </summary>
        BookInfoDAL bookInfoDAL = new BookInfoDAL();
        /// <summary>
        /// 图书类别表数据访问类
        /// </summary>
        BookCategoryDAL bookCategoryDAL = new BookCategoryDAL();

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <returns></returns>
        public int Add(BookInfoModel model)
        {
            return bookInfoDAL.BookAdd(model);
        }

        /// <summary>
        /// 获取图书类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()
        {
            return bookCategoryDAL.FindCategory();
        }

    }
}
