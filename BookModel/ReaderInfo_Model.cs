namespace BookModel
{
    /// <summary>
    /// 读者基本信息表实体类
    /// </summary>
    public class ReaderInfoModel : Base_Model
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public ReaderInfoModel()
        {
        }
        /// <summary>
        /// 有参构造,用于新增读者信息
        /// </summary>
        /// <param name="readerID"></param>
        /// <param name="readName"></param>
        /// <param name="eMail"></param>
        /// <param name="address"></param>
        /// <param name="mobile"></param>
        public ReaderInfoModel(string readName, string eMail, string address, string mobile)
        {
            _readName = readName;
            _eMail = eMail;
            _address = address;
            _mobile = mobile;
        }

        /// <summary>
        /// 用于接收修改信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="readName"></param>
        /// <param name="eMail"></param>
        /// <param name="address"></param>
        /// <param name="mobile"></param>
        public ReaderInfoModel(int id,string readName, string eMail, string address, string mobile)
        {
            Id = id;
            _readName = readName;
            _eMail = eMail;
            _address = address;
            _mobile = mobile;
        }



        #region 字段
        private string _readerID;
        private string _readName;
        private string _eMail;
        private string _address;
        private string _mobile;
        #endregion

        #region 属性
        /// <summary>
        /// 读者编号
        /// </summary>
        public string ReaderID { get => _readerID; set => _readerID = value; }
        /// <summary>
        /// 读者姓名
        /// </summary>
        public string ReadName { get => _readName; set => _readName = value; }
        /// <summary>
        /// 读者邮箱
        /// </summary>
        public string EMail { get => _eMail; set => _eMail = value; }
        /// <summary>
        /// 读者住址
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        /// <summary>
        /// 读者手机号码
        /// </summary>
        public string Mobile { get => _mobile; set => _mobile = value; }
        #endregion
    }
}
