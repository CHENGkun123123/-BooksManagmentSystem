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
        No = 2
    }
}
