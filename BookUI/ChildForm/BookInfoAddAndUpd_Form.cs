using BookBLL;
using BookModel;
using CCWin;
using CCWin.SkinControl;
using Common.Enum;
using Common.Tools;
using Common.Utils;
using System;
using System.Windows.Forms;

namespace BookUI.ChildForm
{
    /// <summary>
    /// 图书添加和修改窗体
    /// </summary>
    public partial class BookInfoAddAndUpd_Form : Skin_VS
    {
        /// <summary>
        /// 图书信息业务层
        /// </summary>
        BookInfo_BLL bookInfo = new BookInfo_BLL();
        #region 字段
        /// <summary>
        /// 接收按钮名称
        /// </summary>
        private string _btnName;
        /// <summary>
        /// 图书id
        /// </summary>
        private int _id;
        /// <summary>
        /// 委托用于赋值
        /// </summary>
        private Func<BookInfo_Model> _func;
        #endregion
        #region 属性
        /// <summary>
        /// 委托属性
        /// </summary>
        public Func<BookInfo_Model> Func { get => _func; set => _func = value; }
        /// <summary>                                                      
        /// 用于接收按钮名称                                                              
        /// </summary>
        public string BtnName { get => _btnName; set => _btnName = value; }
        /// <summary>
        /// 用于接收图书id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        #endregion
        /// <summary>
        /// 默认构造
        /// </summary>
        /// <param name="btnName"></param>
        public BookInfoAddAndUpd_Form(string btnName, Func<BookInfo_Model> func)
        {
            this.BtnName = btnName;
            this.Func = func;
            InitializeComponent();
        }

        #region 方法
        /// <summary>
        /// 判断修改或添加
        /// </summary>
        private void IsUpAdd()
        {
            //赋值
            BookInfo_Model model = new BookInfo_Model(
           this.BookName_tb.Text
           , (int)this.BookCategorycbo.SelectedValue
           , this.BookAuthor_tb.Text
           , (long)this.BookPricenud.Value
           , (int)BookState_Enum.Default_State);

            //判断是添加还是修改
            if (this.BtnName == "BookAdd_Btn")//添加操作
            {
                //输出添加图书结果
                MessageBox.Show(EnumHelper.GetDescription(bookInfo.AddBook(model)));
            }
            else if (this.BtnName == "Modify_btn")//修改操作
            {
                model.Id = this.Id;
                //输出修改图书结果
                MessageBox.Show(EnumHelper.GetDescription(bookInfo.UpdBook(model)));
            }
        }
        #endregion

        #region 事件
        /// <summary>
        /// 图书保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            //判断窗体控件是否有空值
            if (ControlUtils.TextBoxCheckIsNull(this.Controls))
            {
                IsUpAdd();
                this.Close();
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookInfoAdd_Form_Load(object sender, EventArgs e)
        {
            //下拉框赋值
            this.BookCategorycbo.DataSource = bookInfo.FindCategory();
            this.BookCategorycbo.DisplayMember = "CategoryName";
            this.BookCategorycbo.ValueMember = "CategoryID";

            //修改信息赋值
            if (this.BtnName == "Modify_btn")
            {
                BookInfo_Model model = this.Func.Invoke();
                this.BookName_tb.Text = model.Name;
                this.BookAuthor_tb.Text = model.Author;
                this.BookPricenud.Value = model.Money;
                this.BookCategorycbo.SelectedValue = model.CategoryType;
                this.Id = model.Id;
                this.Text = "图书修改";
            }
        }
        #endregion
    }
}
