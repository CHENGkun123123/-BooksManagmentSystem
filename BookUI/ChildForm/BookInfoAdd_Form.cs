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
    public partial class BookInfoAdd_Form : Skin_VS
    {
        /// <summary>
        /// 非空判断委托
        /// </summary>
        Func<Control.ControlCollection, bool> Myfunc;

        //接收按钮名称
        string btnName;
        //图书id
        int id;

        /// <summary>
        /// 默认构造
        /// </summary>
        /// <param name="btnName"></param>
        public BookInfoAdd_Form(string btnName,int id)
        {
            this.btnName = btnName;
            this.id = id;
            InitializeComponent();
        }

        /// <summary>
        /// 图书保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            //委托调用
            Myfunc = ControlUtils.TextBoxCheckIsNull;
            //判断窗体控件是否有空值
            if (Myfunc(this.Controls))
            {
                IsUpAdd();
            }
            this.Close();
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
            if (this.btnName == "BookAdd_Btn")//添加操作
            {
                //输出添加图书结果
                MessageBox.Show(EnumHelper.GetDescription(new BookInfoBLL().AddBook(model)));
            }
            else if (this.btnName == "Modify_btn")//修改操作
            {
                model.Id = this.id;
                //输出添加图书结果
                MessageBox.Show(EnumHelper.GetDescription(new BookInfoBLL().AddBook(model)));
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
            this.BookCategorycbo.DataSource = new BookInfoBLL().FindCategory();
            this.BookCategorycbo.DisplayMember = "CategoryName";
            this.BookCategorycbo.ValueMember = "CategoryID";
        }


    }
}
