using BookBLL;
using BookModel;
using CCWin;
using CCWin.SkinControl;
using Common.Enum;
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

        public BookInfoAdd_Form()
        {
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
            //判断窗体是否有空值
            if (Myfunc(this.Controls))
            {
                BookInfoModel model = new BookInfoModel(
               this.BookName_tb.Text
               , (int)this.BookCategorycbo.SelectedValue
               , this.BookAuthor_tb.Text
               , (long)this.BookPricenud.Value
               , (int)BookStateEnum.Default_State);

                new BookInfoBLL().Add(model);
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

        /// <summary>
        /// 判断TextBox控件是否为空
        /// </summary>
        /// <returns></returns>
        private bool TextBoxCheckIsNull()
        {
            //循环页面控件
            foreach (Control control in this.Controls)
            {
                //判断是否为TextBox控件
                if (control is SkinTextBox)
                {
                    //判断控件Text值是否为空
                    if (string.IsNullOrEmpty((control as SkinTextBox).Text))
                    {
                        //获取控件名
                        string txt_name = ((control as SkinTextBox).Name);
                        //获取Label控件名
                        Label l = (Label)this.Controls.Find("lbl_" + txt_name, true)[0];
                        //输出为空信息
                        MessageBox.Show($"{l.Text}不能为空");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
