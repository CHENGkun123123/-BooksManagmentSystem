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
    public enum MessageEnum
    {
        [Description("操作成功")]
        OK = 0,
        [Description("数据为空")]
        NotErr = 1,
        [Description("操作失败")]
        No = 2,
        [Description("删除成功")]
        Del_OK = 3,
        [Description("修改成功")]
        Upd_OK = 4,
        [Description("删除失败")]
        Del_NotErr = 5,
        [Description("修改失败")]
        Upd_NoErr = 6,
        [Description("添加成功")]
        Add_OK = 7,
        [Description("添加失败")]
        Add_NotErr = 8,

        [Description("读者存在图书未还")]
        Reader_BookReturn = 9,

    }
}
