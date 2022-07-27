using System;

namespace BookModel
{
    /// <summary>
    /// 借还记录表实体类
    /// </summary>
    public class BookBorrowReturnInfo_Model
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookBorrowReturnInfo_Model()
        {
        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="readerID"></param>
        /// <param name="borrowTime"></param>
        /// <param name="returnTime"></param>
        public BookBorrowReturnInfo_Model(string bookID, string readerID, DateTime borrowTime, DateTime returnTime)
        {
            _bookID = bookID;
            _readerID = readerID;
            _borrowTime = borrowTime;
            _returnTime = returnTime;
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
