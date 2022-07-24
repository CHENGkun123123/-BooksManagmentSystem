using BookUI.ChildControl;
using BookUI.ChildForm;
using CCWin;
using System;
using System.Windows.Forms;

namespace BookUI.Admin
{
    /// <summary>
    /// 主页窗体
    /// </summary>
    public partial class SystemHome_From : Skin_VS
    {
        /// <summary>
        /// 默认构造方法
        public SystemHome_From()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 图书管理窗体活动时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            BookInfo_Control book_Control = new BookInfo_Control();
            //设置自动调整大小属性
            book_Control.Dock = DockStyle.Fill;
            this.skinPanel1.Controls.Add(book_Control);
        }

        /// <summary>
        /// 读者管理窗体活动时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ReaderInfo_ContRol readerInfo_ContRol = new ReaderInfo_ContRol();
            //设置自动调整大小属性
            readerInfo_ContRol.Dock = DockStyle.Fill;
            this.skinPanel2.Controls.Add(readerInfo_ContRol);
        }

        /// <summary>
        /// 借还管理窗体活动时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            BorrowReturnInfo_Control borrowReturnInfo_Control = new BorrowReturnInfo_Control();
            //设置自动调整大小属性
            borrowReturnInfo_Control.Dock = DockStyle.Fill;
            this.skinPanel3.Controls.Add(borrowReturnInfo_Control);
        }

        /// <summary>
        /// 图书借还窗体活动时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            BookBorrowed_Control bookBorrowed_Control = new BookBorrowed_Control();
            //设置自动调整大小属性
            bookBorrowed_Control.Dock = DockStyle.Fill;
            this.skinPanel4.Controls.Add(bookBorrowed_Control);
        }

     
    }
}
