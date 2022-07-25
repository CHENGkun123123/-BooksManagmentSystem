using BookBLL;
using Common.Utils;
using System.Windows.Forms;

namespace BookUI.ChildControl
{
    /// <summary>
    /// 读者管理控件窗体
    /// </summary>
    public partial class ReaderInfo_ContRol : UserControl
    {
        /// <summary>
        /// 读者信息业务类
        /// </summary>
        ReaderInfoBLL readerInfoBLL = new ReaderInfoBLL();

        /// <summary>
        /// 默认构造
        /// </summary>
        public ReaderInfo_ContRol()
        {
            InitializeComponent();
            //生成数据源
            MyReaderDataSource(); 
            //生成按钮
            MyDgvBtn();
        }
        /// <summary>
        /// 获取数据源
        /// </summary>
        private void MyReaderDataSource()
        {
            //为控件数据源绑定数据
            this.ReaderInfo_Dgv.DataSource = readerInfoBLL.FindReaders();
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
            this.ReaderInfo_Dgv.Columns.Add(btn);
            //删除按钮
            DataGridViewButtonColumn delbtn = new DataGridViewButtonColumn();
            delbtn.Name = "del_btn";
            delbtn.HeaderText = "";
            delbtn.DefaultCellStyle.NullValue = "删除";
            this.ReaderInfo_Dgv.Columns.Add(delbtn);
        }

        /// <summary>
        /// 搜索按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderSearch_btn_Click(object sender, System.EventArgs e)
        {
            //非空判断
            if (ControlUtils.TextBoxCheckIsNull(skinPanel1.Controls))
            {
                this.ReaderInfo_Dgv.DataSource = readerInfoBLL.FindReaders(this.ReaderId_tb.Text);
                //查询结果为空时刷新数据
                if (this.ReaderInfo_Dgv.Rows.Count==0)
                {
                    MessageBox.Show("该读者不存在");
                    MyReaderDataSource();
                }
            }
        }
    }
}
