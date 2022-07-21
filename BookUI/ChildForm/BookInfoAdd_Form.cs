using BookBLL;
using BookModel;
using CCWin;
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
    /// 图书添加窗体
    /// </summary>
    public partial class BookInfoAdd_Form : Skin_VS
    {
        public BookInfoAdd_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 图书保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAddBtn_Click(object sender, EventArgs e)
        {

            BookInfoModel model = new BookInfoModel(this.BookNamechk.Text,((int)this.BookCategorycbo.SelectedValue),this.BookAuthorchk.Text, (long)this.BookPricenud.Value,"",0);
            new BookInfoBLL().Add(model);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfoAdd_Form_Load(object sender, EventArgs e)
        {
            //下拉框赋值
            this.BookCategorycbo.DataSource = new BookInfoBLL().FindCategory();
            this.BookCategorycbo.DisplayMember = "CategoryName";
            this.BookCategorycbo.ValueMember = "CategoryID";
        }
    }
}
