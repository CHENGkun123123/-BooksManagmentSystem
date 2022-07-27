using System.ComponentModel;

namespace Common.Enum
{
    /// <summary>
    /// 登录状态相关枚举类
    /// </summary>
    public enum LoginState_Enum
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        [Description("登录成功")]
        ok = 0,

        /// <summary>
        /// 登录失败
        /// </summary>
        [Description("登录失败")]
        Err = 1,

        /// <summary>
        /// 密码错误
        /// </summary>
        [Description("密码错误")]
        PwdErr = 2,

        /// <summary>
        /// 账户名为空
        /// </summary>
        [Description("账户名为空")]
        NameNotErr = 3,

        /// <summary>
        /// 密码为空
        /// </summary>
        [Description("密码为空")]
        PwdNotErr = 4,

        /// <summary>
        /// 账户不存在
        /// </summary>
        [Description("账户不存在")]
        NameErr = 5,

        /// <summary>
        /// 点击输入用户名
        /// </summary>
        [Description("点击输入用户名")]
        DefaultNameErr = 6,

        /// <summary>
        /// 点击输入密码
        /// </summary>
        [Description("点击输入密码")]
        DefaultPwdErr = 7,
    }
}
