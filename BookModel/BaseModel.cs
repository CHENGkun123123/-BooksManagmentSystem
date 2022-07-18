using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private int _id;

        /// <summary>
        /// id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
    }
}
