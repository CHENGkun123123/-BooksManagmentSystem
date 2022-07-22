using BookModel;
using Common.Enum;
using DAL;
using System.Data;

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
        public MessageEnum AddBook(BookInfoModel model)
        {
            if (bookInfoDAL.BookAdd(model)>0)
            {
                return MessageEnum.OK;
            }
            return MessageEnum.No;
        }

        /// <summary>
        /// 获取图书类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()
        {
            return bookCategoryDAL.FindCategory();
        }

        /// <summary>
        /// 获取图书信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBook()
        {
            return bookInfoDAL.FindBookInfo();
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <returns></returns>
        public MessageEnum DelBook(int id)
        {
            if (bookInfoDAL.BookDel(id)>0)
            {
                return MessageEnum.OK;
            }
            return MessageEnum.No;
        }
    }
}
