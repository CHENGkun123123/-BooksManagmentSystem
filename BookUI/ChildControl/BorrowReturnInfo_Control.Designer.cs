namespace BookUI.ChildControl
{
    partial class BorrowReturnInfo_Control
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BorrowReturnInfo_Dgv = new CCWin.SkinControl.SkinDataGridView();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowReturnInfo_Dgv)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorrowReturnInfo_Dgv
            // 
            this.BorrowReturnInfo_Dgv.AllowUserToAddRows = false;
            this.BorrowReturnInfo_Dgv.AllowUserToDeleteRows = false;
            this.BorrowReturnInfo_Dgv.AllowUserToResizeColumns = false;
            this.BorrowReturnInfo_Dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.BorrowReturnInfo_Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BorrowReturnInfo_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowReturnInfo_Dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BorrowReturnInfo_Dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BorrowReturnInfo_Dgv.ColumnFont = null;
            this.BorrowReturnInfo_Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowReturnInfo_Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BorrowReturnInfo_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowReturnInfo_Dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorrowReturnInfo_Dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.BorrowReturnInfo_Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowReturnInfo_Dgv.EnableHeadersVisualStyles = false;
            this.BorrowReturnInfo_Dgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorrowReturnInfo_Dgv.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowReturnInfo_Dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.BorrowReturnInfo_Dgv.Location = new System.Drawing.Point(0, 100);
            this.BorrowReturnInfo_Dgv.Name = "BorrowReturnInfo_Dgv";
            this.BorrowReturnInfo_Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BorrowReturnInfo_Dgv.RowHeadersVisible = false;
            this.BorrowReturnInfo_Dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BorrowReturnInfo_Dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BorrowReturnInfo_Dgv.RowTemplate.Height = 23;
            this.BorrowReturnInfo_Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowReturnInfo_Dgv.Size = new System.Drawing.Size(967, 441);
            this.BorrowReturnInfo_Dgv.TabIndex = 1;
            this.BorrowReturnInfo_Dgv.TitleBack = null;
            this.BorrowReturnInfo_Dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.BorrowReturnInfo_Dgv.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(967, 100);
            this.skinPanel1.TabIndex = 2;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("幼圆", 20F, System.Drawing.FontStyle.Bold);
            this.skinLabel1.Location = new System.Drawing.Point(433, 36);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(128, 27);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "借还记录";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorrowReturnInfo_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BorrowReturnInfo_Dgv);
            this.Controls.Add(this.skinPanel1);
            this.Name = "BorrowReturnInfo_Control";
            this.Size = new System.Drawing.Size(967, 541);
            this.Load += new System.EventHandler(this.BorrowReturnInfo_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowReturnInfo_Dgv)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView BorrowReturnInfo_Dgv;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}
