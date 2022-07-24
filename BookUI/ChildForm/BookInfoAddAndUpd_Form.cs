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
    /// 图书添加窗体
    /// </summary>
    public partial class BookInfoAddAndUpd_Form : Skin_VS
    {
        /// <summary>
        /// 图书信息业务层
        /// </summary>
        BookInfoBLL bookInfo = new BookInfoBLL();
        #region 字段
        /// <summary>
        /// 接收按钮名称
        /// </summary>
        string btnName;
        /// <summary>
        /// 图书id
        /// </summary>
        int id;
        /// <summary>
        /// 委托用于赋值
        /// </summary>
        Func<BookInfoModel> _func;
        #endregion
        #region 属性
        /// <summary>
        /// 委托属性
        /// </summary>
        public Func<BookInfoModel> Func { get => _func; set => _func = value; }
        /// <summary>                                                      
        /// 用于接收按钮名称                                                              
        /// </summary>
        public string BtnName { get => btnName; set => btnName = value; }
        /// <summary>
        /// 用于接收图书id
        /// </summary>
        public int Id { get => id; set => id = value; }
        #endregion
        /// <summary>
        /// 默认构造
        /// </summary>
        /// <param name="btnName"></param>
        public BookInfoAddAndUpd_Form(string btnName, Func<BookInfoModel> func)
        {
            this.BtnName = btnName;
            this.Func = func;
            InitializeComponent();
        }

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
        /// 判断修改或添加
        /// </summary>
        private void IsUpAdd()
        {
            //赋值
            BookInfoModel model = new BookInfoModel(
           this.BookName_tb.Text
           , (int)this.BookCategorycbo.SelectedValue
           , this.BookAuthor_tb.Text
           , (long)this.BookPricenud.Value
           , (int)BookStateEnum.Default_State);

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
                BookInfoModel model = this.Func.Invoke();
                this.BookName_tb.Text = model.Name;
                this.BookAuthor_tb.Text = model.Author;
                this.BookPricenud.Value = model.Money;
                this.BookCategorycbo.SelectedValue = model.CategoryType;
                this.Id = model.Id;
                this.Text = "图书修改";
            }
        }


    }
}
