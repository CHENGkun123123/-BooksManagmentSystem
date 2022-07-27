namespace BookModel
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class Base_Model
    {
        //默认构造方法
        public Base_Model()
        {
        }
        /// <summary>
        /// 构造方法重载
        /// </summary>
        /// <param name="id"></param>
        public Base_Model(int id)
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
