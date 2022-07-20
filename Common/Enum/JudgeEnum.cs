using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    /// <summary>
    /// 判断相关枚举
    /// </summary>
    public enum JudgeEnum
    {
        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        Default_State = 0,
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Successful_State = 1,

    }
}
