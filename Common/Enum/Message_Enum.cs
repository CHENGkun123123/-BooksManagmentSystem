using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    /// <summary>
    /// 提示信息枚举
    /// </summary>
    public enum Message_Enum
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        [Description("操作成功")]
        OK = 0,
        
        /// <summary>
        /// 数据为空
        /// </summary>
        [Description("数据为空")]
        NotErr = 1,

        /// <summary>
        /// 操作失败
        /// </summary>
        [Description("操作失败")]
        No = 2,

        /// <summary>
        /// 删除成功
        /// </summary>
        [Description("删除成功")]
        Del_OK = 3,

        /// <summary>
        /// 修改成功
        /// </summary>
        [Description("修改成功")]
        Upd_OK = 4,

        /// <summary>
        /// 删除失败
        /// </summary>
        [Description("删除失败")]
        Del_NotErr = 5,

        /// <summary>
        /// 修改失败
        /// </summary>
        [Description("修改失败")]
        Upd_NoErr = 6,

        /// <summary>
        /// 添加成功
        /// </summary>
        [Description("添加成功")]
        Add_OK = 7,

        /// <summary>
        /// 添加失败
        /// </summary>
        [Description("添加失败")]
        Add_NotErr = 8,

        /// <summary>
        /// 读者存在图书未还
        /// </summary>
        [Description("读者存在图书未还")]
        Reader_BookReturn = 9,

    }
}
