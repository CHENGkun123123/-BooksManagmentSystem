namespace BookModel
{
    /// <summary>
    /// 图书类型表实体类
    /// </summary>
    public class BookCategoryModel : BaseModel
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookCategoryModel()
        {
        }
        /// <summary>
        /// 构造重载
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="categoryName"></param>
        /// <param name="parentID"></param>
        public BookCategoryModel(int categoryID, string categoryName, int parentID)
        {
            _categoryID = categoryID;
            _categoryName = categoryName;
            _parentID = parentID;
        }
        #region 字段
        private int _categoryID;
        private string _categoryName;
        private int _parentID;
        /// <summary>
        /// 类型编号
        /// </summary>
        public int CategoryID { get => _categoryID; set => _categoryID = value; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        /// <summary>
        /// 父类ID
        /// </summary>
        public int ParentID { get => _parentID; set => _parentID = value; }
        #endregion
    }
}
