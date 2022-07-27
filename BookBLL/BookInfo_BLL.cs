using BookModel;
using Common.Enum;
using DAL;
using System.Data;

namespace BookBLL
{
    /// <summary>
    /// 图书信息相关业务类
    /// </summary>
    public class BookInfo_BLL
    {
        /// <summary>
        /// 图书信息数据访问类
        /// </summary>
        BookInfo_DAL bookInfoDAL = new BookInfo_DAL();
        /// <summary>
        /// 图书类别数据访问类
        /// </summary>
        BookCategory_DAL bookCategoryDAL = new BookCategory_DAL();
        /// <summary>
        /// 借书还书信息数据访问类
        /// </summary>
        BookBorrowReturnInfo_DAL bookBorrowReturnInfoDAL = new BookBorrowReturnInfo_DAL();

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <returns></returns>
        public Message_Enum AddBook(BookInfo_Model model)
        {
            if (bookInfoDAL.BookAdd(model) > 0)
            {
                return Message_Enum.OK;
            }
            return Message_Enum.No;
        }

        /// <summary>
        /// 获取图书子类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCategory()=>bookCategoryDAL.FindCategory();

        /// <summary>
        /// 获取图书父类别信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindParentCategory() => bookCategoryDAL.FindParentCategory();

        /// <summary>
        /// 根据类别id获取图书信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetCategoryBook(string categoryId)=> bookInfoDAL.GetCategoryIdBookInfo(categoryId);

        /// <summary>
        /// 根据id获取图书信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBook(string id)=> bookInfoDAL.FindBookInfo(id);

        /// <summary>
        /// 修改图书信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Message_Enum UpdBook(BookInfo_Model model)
        {
            if (bookInfoDAL.BookUpd(model) > 0)
            {
                return Message_Enum.OK;
            }
            return Message_Enum.No;
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <returns></returns>
        public Message_Enum DelBook(int id)
        {
            if (bookInfoDAL.BookDel(id) > 0)
            {
                return Message_Enum.OK;
            }
            return Message_Enum.No;
        }

        /// <summary>
        /// 获取借还记录列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo()=> bookBorrowReturnInfoDAL.FindBookBorrowInfo();

        /// <summary>
        /// 根据读者id获取借还记录列表
        /// </summary>
        /// <returns></returns>
        public DataTable FindBookBorrowInfo(string readerid)=> bookBorrowReturnInfoDAL.FindBookBorrowInfo(readerid);

        /// <summary>
        /// 根据图书状态获取图书列表
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public DataTable GetBookState(string bookId)=> bookInfoDAL.GetBookState(bookId);

        /// <summary>
        /// 更新还书时间
        /// </summary>
        /// <returns></returns>
        public Message_Enum UpDBorrowTime(string readerId, string bookId)
        {
            if (bookBorrowReturnInfoDAL.UpDBorrowTr(readerId, bookId))
            {
                return Message_Enum.OK;
            }

            return Message_Enum.No;
        }

        /// <summary>
        /// 更新借书时间
        /// </summary>
        /// <returns></returns>
        public Message_Enum UpDReturnTime(string readerId, string bookId)
        {
            if (bookBorrowReturnInfoDAL.UpDReturnTr(readerId, bookId))
            {
                return Message_Enum.OK;
            }

            return Message_Enum.No;
        }
    }
}
