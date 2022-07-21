using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    /// <summary>
    /// 图书信息添加枚举类
    /// </summary>
    public enum BookInfoAddEnum
    {
        /// <summary>
        /// 图书名称为空
        /// </summary>
        [Description("图书名称为空")]
        NameNotErr = 0,

        /// <summary>
        /// 图书作者为空
        /// </summary>
        [Description("图书作者为空")]
        AuthorNotErr = 1,
    }
}
