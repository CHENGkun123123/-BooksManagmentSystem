using BookBLL;
using Common.Enum;
using Common.Tools;
using Common.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookUI.ChildControl
{
    /// <summary>
    /// 图书借还窗体
    /// </summary>
    public partial class BookBorrowed_Control : UserControl
    {
        /// <summary>
        /// 读者信息业务类
        /// </summary>
        ReaderInfo_BLL readerInfoBLL = new ReaderInfo_BLL();
        /// <summary>
        /// 图书信息业务类
        /// </summary>
        BookInfo_BLL bookInfoBLL = new BookInfo_BLL();

        /// <summary>
        /// 默认构造
        /// </summary>
        public BookBorrowed_Control()
        {
            InitializeComponent();
        }

        #region 方法
        /// <summary>
        /// 获取读者信息并设置控件属性显示
        /// </summary>
        /// <param name="readerInfo"></param>
        private void IsControlVisble()
        {
            DataTable readerInfo = readerInfoBLL.FindReaders(this.ReaderId_tb.Text);
            if (readerInfo.Rows.Count != 0)
            {
                this.ReaderId_lbl.Text = readerInfo.Rows[0]["读者编号"].ToString();
                this.ReaderName_lbl.Text = readerInfo.Rows[0]["读者姓名"].ToString();
                this.lbl_ReaderId_lbl.Visible = true;
                this.ReaderId_lbl.Visible = true;
                this.lbl_ReaderName_lbl.Visible = true;
                this.ReaderName_lbl.Visible = true;
                this.skinPanel4.Visible = true;
                this.BookInfo_Dgv.Visible = true;
                this.skinPanel5.Visible = true;
                this.BorrowReturnInfo_Dgv.Visible = true;
                this.skinPanel6.Visible = true;
                //生成图书数据源
                GetBooksInfo(null);
                //生成借还记录数据源
                GetBorrowInfo(this.ReaderId_tb.Text);
            }
            else
            {
                MessageBox.Show("读者不存在");
            }
        }

        /// <summary>
        /// 获取图书信息数据源
        /// </summary>
        private void GetBooksInfo(string id)
        {
            this.BookInfo_Dgv.DataSource = bookInfoBLL.GetBookState(id);
            //隐藏
            this.BookInfo_Dgv.Columns["图书类别id"].Visible = false;
        }

        /// <summary>
        /// 获取图书借书记录
        /// </summary>
        private void GetBorrowInfo(string readerid)
        {
            this.BorrowReturnInfo_Dgv.DataSource = bookInfoBLL.FindBookBorrowInfo(readerid);
            this.BorrowReturnInfo_Dgv.Sort
        }

        /// <summary>
        /// 判断是否有借还记录
        /// </summary>
        private bool IsBorrowReturnInfoNotNull()
        {
            if (this.BorrowReturnInfo_Dgv.RowCount == 0)
            {
                MessageBox.Show("记录不存在");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 判断是否存在图书
        /// </summary>
        /// <returns></returns>
        private bool IsBookInfoNotNull()
        {
            if (this.BookInfo_Dgv.RowCount == 0)
            {
                MessageBox.Show("图书不存在");
                return false;
            }
            return true;
        }
        #endregion

        #region 事件
        /// <summary>
        /// 读者id确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderOk_Btn_Click(object sender, System.EventArgs e)
        {
            if (ControlUtils.TextBoxCheckIsNull(skinPanel1.Controls))
            {
                //控件属性设置显示
                IsControlVisble();
            }
        }
        
        /// <summary>
        /// 图书id确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Book_OK_Btn_Click(object sender, System.EventArgs e)
        {
            GetBooksInfo(this.BookId_tb.Text);
        }
        
        /// <summary>
        /// 还书按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Btn_Click(object sender, EventArgs e)
        {
            if (IsBorrowReturnInfoNotNull())
            {
                //获取用户点击的单元格行索引
                int index = this.BorrowReturnInfo_Dgv.SelectedCells[0].RowIndex;
                //获取当前行的读者id
                string readerId = this.BorrowReturnInfo_Dgv.Rows[index].Cells[1].Value.ToString();
                //获取当前行的图书id
                string bookId = this.BorrowReturnInfo_Dgv.Rows[index].Cells[2].Value.ToString();
                MessageBox.Show(EnumHelper.GetDescription(bookInfoBLL.UpDBorrowTime(readerId, bookId)));
                //生成图书数据源
                GetBooksInfo(null);
                //生成借还记录数据源
                GetBorrowInfo(this.ReaderId_tb.Text);
            }

        } 
        
        /// <summary>
        /// 借书按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Borrow_Btn_Click(object sender, EventArgs e)
        {

            if (IsBookInfoNotNull())
            {
                //获取用户点击的单元格行索引
                int index = this.BookInfo_Dgv.SelectedCells[0].RowIndex;
                //获取当的读者id
                string readerId = this.ReaderId_tb.Text;
                //获取当前行的图书id
                string bookId = this.BookInfo_Dgv.Rows[index].Cells[4].Value.ToString();
                MessageBox.Show(EnumHelper.GetDescription(bookInfoBLL.UpDReturnTime(readerId, bookId)));
                //生成图书数据源
                GetBooksInfo(null);
                //生成借还记录数据源
                GetBorrowInfo(this.ReaderId_tb.Text);
            }

        }
        #endregion
    }
}
