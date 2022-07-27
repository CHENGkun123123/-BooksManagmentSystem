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
        BookInfo_BLL bookInfoBLL = new BookInfo_BLL();

        /// <summary>
        /// 默认构造
        /// </summary>
        public BorrowReturnInfo_Control()
        {
            InitializeComponent();
            //生成数据源
            MyBorrowDataSource();
        }

        #region 方法
        /// <summary>
        /// 生成数据源
        /// </summary>
        public void MyBorrowDataSource()
        {
            //绑定数据源
            this.BorrowReturnInfo_Dgv.DataSource = bookInfoBLL.FindBookBorrowInfo();
        }
        #endregion

        #region 事件
        /// <summary>
        /// 控件加载时发生事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BorrowReturnInfo_Control_Load(object sender, System.EventArgs e)
        {
            MyBorrowDataSource();
        }
        #endregion



    }
}
