using BookBLL;
using BookModel;
using BookUI.ChildForm;
using Common.Tools;
using Common.Utils;
using System;
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
        /// 搜索
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

        /// <summary>
        /// 添加读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderAdd_Tsm_Click(object sender, System.EventArgs e)
        {
            //窗口显示
            using (ReaderInfoAddAndUpd_Form add_Form = new ReaderInfoAddAndUpd_Form(this.ReaderAdd_Tsm.Name, null))
            {
                add_Form.ShowDialog();
            };
            //刷新数据源
            MyReaderDataSource();
        }

        /// <summary>
        /// 修改读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderUpD_Tsm_Click(object sender, System.EventArgs e)
        {
            Func<ReaderInfoModel> _action = new Func<ReaderInfoModel>(UpdDefaultMes);
            //窗口显示
            using (ReaderInfoAddAndUpd_Form add_Form = new ReaderInfoAddAndUpd_Form(this.ReaderUpD_Tsm.Name, _action))
            {
                add_Form.ShowDialog();
            };
            //刷新数据源
            MyReaderDataSource();
        }

        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderInfo_Dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //判断用户点击是否为鼠标右键
            if (e.Button == MouseButtons.Right)
            {
                //判断选中行索引
                if (e.RowIndex >= 0)
                {
                    //清除前面选中的行
                    ReaderInfo_Dgv.ClearSelection();
                    //当前选中行设为被选中
                    ReaderInfo_Dgv.Rows[e.RowIndex].Selected = true;
                    ReaderInfo_Dgv.CurrentCell = ReaderInfo_Dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //菜单显示位置在当前鼠标位置
                    ReaderInfo_Cms.Show(MousePosition.X, MousePosition.Y);

                }
            }
        }

        /// <summary>
        /// 删除读者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderDel_Tsm_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //获取选中行读者编号单元格的值
                int idex = ReaderInfo_Dgv.CurrentRow.Index;
                string readerId = ReaderInfo_Dgv.Rows[idex].Cells[1].Value.ToString();
                MessageBox.Show(EnumHelper.GetDescription(readerInfoBLL.DelReader(readerId)));
                MyReaderDataSource();
            }
        }

        /// <summary>
        /// 获取选中行读者参数
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private ReaderInfoModel UpdDefaultMes()
        {
            //获取选中行读者编号单元格的值
            int idex = ReaderInfo_Dgv.CurrentRow.Index;
            int id = (int)ReaderInfo_Dgv.Rows[idex].Cells["ID"].Value;
            string readName = ReaderInfo_Dgv.Rows[idex].Cells["读者姓名"].Value.ToString();
            string email = ReaderInfo_Dgv.Rows[idex].Cells["读者邮箱"].Value.ToString();
            string address = ReaderInfo_Dgv.Rows[idex].Cells["读者地址"].Value.ToString();
            string mobile = ReaderInfo_Dgv.Rows[idex].Cells["读者电话"].Value.ToString();

            ReaderInfoModel model = new ReaderInfoModel(id, readName, email, address, mobile);
            return model;
        }
    }
}
