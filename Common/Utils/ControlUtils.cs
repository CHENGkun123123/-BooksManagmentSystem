using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Utils
{
    /// <summary>
    /// 控件工具类
    /// </summary>
    public class ControlUtils
    {
        /// <summary>
        /// 判断TextBox是否为空
        /// </summary>
        /// <returns></returns>
        public static bool TextBoxCheckIsNull<T>(T controlObj)where T : Control.ControlCollection
        {
            //循环页面控件
            foreach (Control cont in controlObj)
            {

;                //判断是否为TextBox控件
                if (cont is SkinTextBox)
                {
                    //判断控件Text值是否为空
                    if (string.IsNullOrEmpty((cont as SkinTextBox).Text))
                    {
                        //获取控件名
                        string txt_name = ((cont as SkinTextBox).Name);
                        //获取Label控件
                        SkinLabel l = (SkinLabel)controlObj.Find($"lbl_{txt_name}" , true)[0];
                        //返回错误信息
                        MessageBox.Show($"{l.Text}不能为空");
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
