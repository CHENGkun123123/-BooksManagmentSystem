namespace BookModel
{
    /// <summary>
    /// 图书信息表实体类
    /// </summary>
    public class BookInfo_Model : Base_Model
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookInfo_Model()
        {
        }

        /// <summary>
        /// 有参构造
        /// </summary>
        /// <param name="name"></param>
        /// <param name="categoryType"></param>
        /// <param name="author"></param>
        /// <param name="money"></param>
        /// <param name="state"></param>
        public BookInfo_Model(string name, int categoryType, string author, long money, int state)
        {
            _name = name;
            _categoryType = categoryType;
            _author = author;
            _money = money;
            _state = state;
        }

        /// <summary>
        /// 接收修改信息构造
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="money"></param>
        public BookInfo_Model(int id,string name, string author, long money,int bookCategory)
        {
            _name = name;
            _author = author;
            _money = money;
            _categoryType= bookCategory;
            Id = id;
        }



        #region 字段
        private string _name;
        private int _categoryType;
        private string _author;
        private long _money;
        private string bookID;
        private int _state;
        #endregion

        #region 属性
        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        /// <summary>
        /// 图书类型
        /// </summary>
        public int CategoryType { get => _categoryType; set => _categoryType = value; }
        /// <summary>
        /// 图书作者
        /// </summary>
        public string Author { get => _author; set => _author = value; }
        /// <summary>
        /// 图书价格
        /// </summary>
        public long Money { get => _money; set => _money = value; }
        /// <summary>
        /// 图书编号
        /// </summary>
        public string BookID { get => bookID; set => bookID = value; }
        /// <summary>
        /// 图书状态
        /// </summary>
        public int State { get => _state; set => _state = value; }
        #endregion


    }
}
