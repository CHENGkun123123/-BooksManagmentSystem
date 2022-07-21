using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookUI.ChildForm
{
    /// <summary>
    /// 图书管理控件窗体
    /// </summary>
    public partial class BookInfo_Control : UserControl
    {
        /// <summary>
        /// 默认构造
        /// </summary>
        public BookInfo_Control()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 图书添加按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            //窗口显示
            new BookInfoAdd_Form().ShowDialog();
        }
    }
}
