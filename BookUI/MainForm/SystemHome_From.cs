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
        public SystemHome_From(string name)
        {
            InitializeComponent();
            this.AdminName.Text += $"{name}已登录";
        }

        #region 事件
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

        /// <summary>
        /// 跳转图书管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = this.tabPage1;
        }

        /// <summary>
        /// 跳转读者管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = this.tabPage2;
        }

        /// <summary>
        /// 跳转借还记录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = this.tabPage3;
        }

        /// <summary>
        /// 跳转借书还书按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = this.tabPage4;
        }
        #endregion

    }
}
