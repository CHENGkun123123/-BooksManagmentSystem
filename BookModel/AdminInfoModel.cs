using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModel
{
    /// <summary>
    /// 管理员信息表实体类
    /// </summary>
    public class AdminInfoModel : BaseModel
    {
        //默认构造方法
        public AdminInfoModel()
        {

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
