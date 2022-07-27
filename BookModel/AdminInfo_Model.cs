namespace BookModel
{
    /// <summary>
    /// 管理员信息表实体类
    /// </summary>
    public class AdminInfo_Model : Base_Model
    {
        //默认构造方法
        public AdminInfo_Model()
        {

        }
        /// <summary>
        /// 构造方法重载
        /// </summary>
        /// <param name="adminID"></param>
        /// <param name="adminPwd"></param>
        public AdminInfo_Model(string adminID, string adminPwd)
        {
            _adminID = adminID;
            _adminPwd = adminPwd;
        }

        #region 字段
        private string _adminID;
        private string _adminPwd;
        #endregion

        #region 属性
        /// <summary>
        /// 管理员编号 
        /// </summary>
        public string AdminID { get => _adminID; set => _adminID = value; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPwd { get => _adminPwd; set => _adminPwd = value; }
        #endregion

    }
}
