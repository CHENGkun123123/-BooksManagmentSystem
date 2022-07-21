using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModel
{
    /// <summary>
    /// 图书状态表实体类
    /// </summary>
    public class BookStateModel
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookStateModel()
        {
        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="bookState"></param>
        /// <param name="description"></param>
        public BookStateModel(int bookState, string description)
        {
            BookState = bookState;
            Description = description;
        }

        #region 字段
        private int _bookState;
        private string _description;
        #endregion

        #region 属性
        /// <summary>
        /// 图书状态编号
        /// </summary>
        public int BookState { get => _bookState; set => _bookState = value; }

        /// <summary>
        /// 图书状态描述
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        #endregion
    }
}
