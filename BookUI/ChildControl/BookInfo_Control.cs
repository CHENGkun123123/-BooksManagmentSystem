using BookBLL;
using BookModel;
using Common.Enum;
using Common.Tools;
using Common.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookUI.ChildForm
{
    /// <summary>
    /// 图书管理控件窗体
    /// </summary>
    public partial class BookInfo_Control : UserControl
    {
        /// <summary>
        /// 图书信息业务类
        /// </summary>
        BookInfoBLL bookInfoBLL = new BookInfoBLL(); 

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
            using (BookInfoAddAndUpd_Form add_Form = new BookInfoAddAndUpd_Form(this.BookAdd_Btn.Name, null))
            {
                add_Form.ShowDialog();
            };
            //刷新数据源
            MyBookInfoDataSource(null);
        }

        /// <summary>
        /// 页面加载时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfo_Control_Load(object sender, EventArgs e)
        {
            //生成数据源
            MyBookInfoDataSource(null);
            //生成表格按钮
            MyDgvBtn();
            //生成目录树
            AddTvwNode();

        }

        /// <summary>
        /// 创建父节点
        /// </summary>
        private TreeNode AddTvwNode()
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Text = "图书信息管理目录";
            treeNode.Name = "";
            //根目录
            this.BookCategory_tvw.Nodes.Add(treeNode);
            //父节点数据循环
            DataTable tb = bookInfoBLL.FindParentCategory();

            foreach (DataRow dr in tb.Rows)
            {
                TreeNode tn = new TreeNode();
                if (dr["ParentID"].ToString() == "0")
                {
                    tn.Text = dr["CategoryName"].ToString();
                    tn.Name = "";
                    this.BookCategory_tvw.Nodes[0].Nodes.Add(tn);
                }
                //创建子节点
                NewNodes(dr, tn);
            }
            return treeNode;
        }

        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="tn"></param>
        private static void NewNodes(DataRow dr, TreeNode tn)
        {
            //子节点数据循环
            foreach (DataRow drr in new BookInfoBLL().FindCategory().Rows)
            {
                if (drr["ParentID"].ToString() == dr["CategoryID"].ToString())
                {
                    //ddr为dr的子节点
                    TreeNode ttn = new TreeNode();
                    ttn.Name = drr["CategoryID"].ToString();
                    ttn.Text = drr["CategoryName"].ToString();
                    tn.Nodes.Add(ttn);
                }

            }
        }

        /// <summary>
        /// 生成按钮
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
        /// 单击单元格内容时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfo_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取用户点击的单元格行索引
            int index = this.BookInfo_dgv.SelectedCells[0].RowIndex;
            //获取当前行的id
            int bookId = (int)this.BookInfo_dgv.Rows[index].Cells[2].Value;

            IsDelOrUpd(bookId, this.BookInfo_dgv.Columns[e.ColumnIndex].Name);
        }

        /// <summary>
        /// 判断执行删除还是修改方法
        /// </summary>
        /// <param name="e"></param>
        /// <param name="bookId"></param>
        private void IsDelOrUpd(int bookId,string name)
        {
            if (name == "Modify_btn")//修改按钮点击事件
            {
                Func<BookInfoModel> _action = new Func<BookInfoModel>(UpdDefaultMes);

                //窗口显示
                using (BookInfoAddAndUpd_Form add_Form = new BookInfoAddAndUpd_Form(name, _action))
                {
                    add_Form.ShowDialog();
                };
                //刷新数据
                MyBookInfoDataSource(null);
            }
            else if (name == "del_btn")//删除按钮点击事件
            {
                //执行删除
                MessageEnum mes = bookInfoBLL.DelBook(bookId);
                if (mes == MessageEnum.OK)
                {
                    MessageBox.Show(EnumHelper.GetDescription(mes));
                }
                //刷新数据
                MyBookInfoDataSource(null);
            }
        }



        /// <summary>
        /// 获取选中图书的默认参数
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private BookInfoModel UpdDefaultMes()
        {
            //获取用户点击的单元格行索引
            int index = this.BookInfo_dgv.SelectedCells[0].RowIndex;
            //获取当前行的id
            int bookId = (int)this.BookInfo_dgv.Rows[index].Cells[2].Value;
            //获取选中行信息
            int price = Convert.ToInt32(this.BookInfo_dgv.Rows[index].Cells["图书价格"].Value);
            string bookName = this.BookInfo_dgv.Rows[index].Cells["图书名称"].Value.ToString();
            string BookAuthor = this.BookInfo_dgv.Rows[index].Cells["图书作者"].Value.ToString();
            int bookCategory = (int)this.BookInfo_dgv.Rows[index].Cells["图书类别id"].Value;

            BookInfoModel model = new BookInfoModel(bookId, bookName, BookAuthor, price, bookCategory);
            return model;
        }

        /// <summary>
        /// 获取数据源
        /// </summary>
        private void MyBookInfoDataSource(string categoryId)
        {
            //数据源赋值
            this.BookInfo_dgv.DataSource = bookInfoBLL.GetCategoryBook(categoryId);
            //隐藏
            this.BookInfo_dgv.Columns["图书类别id"].Visible = false;
        }

        /// <summary>
        /// 双击节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookCategory_tvw_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string categoryType = e.Node.Name;
            MyBookInfoDataSource(categoryType);
        }

        /// <summary>
        /// 搜索按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookSearch_btn_Click(object sender, EventArgs e)
        {
            if (ControlUtils.TextBoxCheckIsNull(panel1.Controls))
            {
                //数据源赋值
                this.BookInfo_dgv.DataSource = bookInfoBLL.FindBook(this.BookSearch_tb.Text);
            }
        }
    }
}
