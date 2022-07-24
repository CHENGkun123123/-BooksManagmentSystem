using BookBLL;
using System.Windows.Forms;

namespace BookUI.ChildControl
{
    /// <summary>
    /// 借还记录控件窗体
    /// </summary>
    public partial class BorrowReturnInfo_Control : UserControl
    {
        /// <summary>
        /// 图书相关业务类
        /// </summary>
        BookInfoBLL bookInfoBLL = new BookInfoBLL();
        /// <summary>
        /// 默认构造
        /// </summary>
        public BorrowReturnInfo_Control()
        {
            InitializeComponent();
            //生成数据源
            MyBorrowDataSource();
        }

        /// <summary>
        /// 生成数据源
        /// </summary>
        public void MyBorrowDataSource()
        {
            //绑定数据源
            this.BorrowReturnInfo_Dgv.DataSource = bookInfoBLL.FindBookBorrowInfo();
        }
    }
}
