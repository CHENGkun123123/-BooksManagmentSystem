using BookBLL;
using BookModel;
using CCWin;
using Common.Tools;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookUI.ChildForm
{
    /// <summary>
    /// 读者添加和修改窗体
    /// </summary>
    public partial class ReaderInfoAddAndUpd_Form : Skin_VS
    {
        /// <summary>
        /// 读者业务类
        /// </summary>
        ReaderInfo_BLL readerInfoBLL = new ReaderInfo_BLL();

        #region 字段
        /// <summary>
        /// 接收按钮名称
        /// </summary>
        private string _btnName;
        /// <summary>
        /// 读者id
        /// </summary>
        private int _id;
        /// <summary>
        /// 委托用于赋值
        /// </summary>
        private Func<ReaderInfoModel> _func;
        #endregion
        #region 属性
        /// <summary>
        /// 委托属性
        /// </summary>
        public Func<ReaderInfoModel> Func { get => _func; set => _func = value; }
        /// <summary>                                                      
        /// 用于接收按钮名称                                                              
        /// </summary>
        public string BtnName { get => _btnName; set => _btnName = value; }
        /// <summary>
        /// 用于读者id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        #endregion
        /// <summary>
        /// 默认构造
        /// </summary>
        public ReaderInfoAddAndUpd_Form(string btnName, Func<ReaderInfoModel> func)
        {
            InitializeComponent();
            this.BtnName = btnName;
            this.Func = func;
        }

        #region 方法
        /// <summary>
        /// 判断是修改还是添加
        /// </summary>
        /// <param name="readerInfoModel"></param>
        private void IsUpd_Add(ReaderInfoModel readerInfoModel)
        {
            if (IsTextNotNull())
            {
                //正则判断电话号码
                if (Regex.IsMatch(this.Mobile_tb.Text.Trim(), @"^\d{7,11}$"))
                {

                    if (this.BtnName == "ReaderAdd_Tsm")//添加操作
                    {
                        //输出添加结果
                        MessageBox.Show(EnumHelper.GetDescription(readerInfoBLL.AddReader(readerInfoModel)));
                    }
                    else if (this.BtnName == "ReaderUpD_Tsm")//修改操作
                    {
                        readerInfoModel.Id = this._id;
                        MessageBox.Show(EnumHelper.GetDescription(readerInfoBLL.UpdReader(readerInfoModel)));
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("联系方式格式不正确");
                }
            }
            else
            {
                MessageBox.Show("读者姓名不能空");
            }
        }

        /// <summary>
        /// 判断输入值是否为空
        /// </summary>
        /// <returns></returns>
        private bool IsTextNotNull()
        {
            if (!string.IsNullOrEmpty(this.ReaderName_tb.Text))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region 事件
        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderAddBtn_Click(object sender, EventArgs e)
        {
            ReaderInfoModel readerInfoModel = new ReaderInfoModel(
                   this.ReaderName_tb.Text,
                   this.ReaderEmail_tb.Text,
                   this.AddRess_tb.Text,
                   this.Mobile_tb.Text
                   );
            IsUpd_Add(readerInfoModel);
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderInfoAddAndUpd_Form_Load(object sender, EventArgs e)
        {
            //修改信息赋值
            if (this.BtnName == "ReaderUpD_Tsm")
            {
                ReaderInfoModel model = this.Func.Invoke();
                this.ReaderName_tb.Text = model.ReadName;
                this.ReaderEmail_tb.Text = model.EMail;
                this.AddRess_tb.Text = model.Address;
                this.Mobile_tb.Text = model.Mobile;
                this._id = model.Id;
                this.Text = "读者修改";
            }
        }
        #endregion
    }
}
