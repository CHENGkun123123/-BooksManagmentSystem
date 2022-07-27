using System.ComponentModel;

namespace Common.Enum
{
    /// <summary>
    /// 判断相关枚举
    /// </summary>
    public enum Judge_Enum
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
