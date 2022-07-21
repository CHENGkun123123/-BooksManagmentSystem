using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModel
{
    /// <summary>
    /// 借还记录表实体类
    /// </summary>
    public class BookBorrowReturnInfoModel
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookBorrowReturnInfoModel()
        {
        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="readerID"></param>
        /// <param name="borrowTime"></param>
        /// <param name="returnTime"></param>
        public BookBorrowReturnInfoModel(string bookID, string readerID, DateTime borrowTime, DateTime returnTime)
        {
            BookID = bookID;
            ReaderID = readerID;
            BorrowTime = borrowTime;
            ReturnTime = returnTime;
        }

        #region 字段
        private string _bookID;
        private string _readerID;
        private DateTime _borrowTime;
        private DateTime _returnTime;
        #endregion

        #region 属性
        /// <summary>
        /// 图书编号
        /// </summary>
        public string BookID { get => _bookID; set => _bookID = value; }
        /// <summary>
        /// 读者编号
        /// </summary>
        public string ReaderID { get => _readerID; set => _readerID = value; }
        /// <summary>
        /// 借书时间
        /// </summary>
        public DateTime BorrowTime { get => _borrowTime; set => _borrowTime = value; }
        /// <summary>
        /// 还书时间
        /// </summary>
        public DateTime ReturnTime { get => _returnTime; set => _returnTime = value; }
        #endregion
    }
}
