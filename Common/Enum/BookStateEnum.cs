using System.ComponentModel;

namespace Common.Enum
{
    /// <summary>
    /// 图书状态枚举类
    /// </summary>
    public enum BookStateEnum
    {
        /// <summary>
        /// 未借出
        /// </summary>
        [Description("未借出")]
        Default_State = 0,

        /// <summary>
        /// 已借出
        /// </summary>
        [Description("已借出")]
        Lend_State = 1,

    }
}
