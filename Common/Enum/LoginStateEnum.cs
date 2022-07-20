using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    /// <summary>
    /// 登录状态相关枚举类
    /// </summary>
    public enum LoginStateEnum
    {
        [Description("登录成功")]
        ok = 0,

        [Description("登录失败")]
        Err = 1,

        [Description("密码错误")]
        PwdErr = 2,

        [Description("账户名为空")]
        NameNotErr = 3,

        [Description("密码为空")]
        PwdNotErr = 4,

        [Description("账户不存在")]
        NameErr = 5,

        [Description("点击输入用户名")]
        DefaultNameErr = 6,

        [Description("点击输入密码")]
        DefaultPwdErr = 7,
    }
}
