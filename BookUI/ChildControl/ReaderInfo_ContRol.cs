using BookBLL;
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
            //
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
    }
}
