using BookBLL;
using Common.Enum;
using Common.Tools;
using System;
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
            using (BookInfoAdd_Form add_Form = new BookInfoAdd_Form(this.BookAdd_Btn.Name,0))
            {
                add_Form.ShowDialog();
            };
            //刷新数据源
            MyBookInfoDataSource();
        }

        /// <summary>
        /// 页面加载时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfo_Control_Load(object sender, EventArgs e)
        {
            //生成数据源
            MyBookInfoDataSource();
            //生成表格按钮
            MyDgvBtn();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        private void MyDgvBtn()
        {
            //添加修改按钮
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Modify_btn";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "修改";
            this.BookInfo_dgv.Columns.Add(btn);
            //删除按钮
            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.Name = "del_btn";
            delbtn.HeaderText = "";
            delbtn.DefaultCellStyle.NullValue = "删除";
            this.BookInfo_dgv.Columns.Add(delbtn);
        }




        /// <summary>
        /// 单击表格时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfo_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.BookInfo_dgv.Columns[e.ColumnIndex].Name == "Modify_btn")//修改按钮点击事件
            {
                //获取用户点击的单元格行索引
                int index = this.BookInfo_dgv.SelectedCells[0].RowIndex;

                //窗口显示
                using (BookInfoAdd_Form add_Form = new BookInfoAdd_Form(this.BookInfo_dgv.Columns[e.ColumnIndex].Name,(int)this.BookInfo_dgv.Rows[index].Cells[2].Value))
                {
                    add_Form.ShowDialog();
                };
                //刷新数据源
                MyBookInfoDataSource();
            }
            else if (this.BookInfo_dgv.Columns[e.ColumnIndex].Name == "del_btn")//删除按钮点击事件
            {
                //获取用户点击的单元格行索引
                int index = this.BookInfo_dgv.SelectedCells[0].RowIndex;
                //获取当前行的id
                int Bookid = (int)this.BookInfo_dgv.Rows[index].Cells[2].Value;
                //执行删除
                MessageEnum mes = new BookInfoBLL().DelBook(Bookid);

                if (mes == MessageEnum.OK)
                {
                    //刷新数据
                    MyBookInfoDataSource();
                    MessageBox.Show(EnumHelper.GetDescription(mes));
                }
            }
        }

        /// <summary>
        /// 获取数据源
        /// </summary>
        private void MyBookInfoDataSource()
        {
            //数据源赋值
            this.BookInfo_dgv.DataSource = new BookInfoBLL().FindBook();
        }
    }
}
