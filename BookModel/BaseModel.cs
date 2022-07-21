namespace BookModel
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class BaseModel
    {
        //默认构造方法
        public BaseModel()
        {
        }
        /// <summary>
        /// 构造方法重载
        /// </summary>
        /// <param name="id"></param>
        public BaseModel(int id)
        {
            _id = id;
        }

        private int _id;

        /// <summary>
        /// id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
    }
}
