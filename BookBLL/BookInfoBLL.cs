using BookModel;
using Common.Enum;
using DAL;
using System.Data;

namespace BookBLL
{
    /// <summary>
    /// 图书信息相关业务类
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
        /// 借书还书信息表数据访问类
        /// </summary>
        BookBorrowReturnInfoDAL bookBorrowReturnInfoDAL = new BookBorrowReturnInfoDAL();

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <returns></returns>
        public MessageEnum AddBook(BookInfoModel model)
        {
            if (bookInfoDAL.BookAdd(model) > 0)
            {
                return MessageEnum.OK;
            }
            return MessageEnum.No;
        }

        /// <summary>
        /// 获取图书子类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()
        {
            return bookCategoryDAL.FindCategory();
        }

        /// <summary>
        /// 获取图书父类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindParentCategory()
        {
            return bookCategoryDAL.FindParentCategory();
        }

        /// <summary>
        /// 根据类别id获取图书信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCategoryBook(string categoryId)
        {
            return bookInfoDAL.GetCategoryIdBookInfo(categoryId);
        }

        /// <summary>
        /// 根据id获取图书信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBook(string id)
        {
            return bookInfoDAL.FindBookInfo(id);
        }

        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public MessageEnum UpdBook(BookInfoModel model)
        {
            if (bookInfoDAL.BookUpd(model) > 0)
            {
                return MessageEnum.OK;
            }
            return MessageEnum.No;
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <returns></returns>
        public MessageEnum DelBook(int id)
        {
            if (bookInfoDAL.BookDel(id) > 0)
            {
                return MessageEnum.OK;
            }
            return MessageEnum.No;
        }

        /// <summary>
        /// 获取借还记录列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo()
        {
            return bookBorrowReturnInfoDAL.FindBookBorrowInfo();
        }
    }
}
