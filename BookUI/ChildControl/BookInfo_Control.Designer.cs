namespace BookUI.ChildForm
{
    partial class BookInfo_Control
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookAdd_Btn = new CCWin.SkinControl.SkinButton();
            this.BookSearch_btn = new CCWin.SkinControl.SkinButton();
            this.BookSearch_tb = new CCWin.SkinControl.SkinTextBox();
            this.lbl_BookSearch_tb = new CCWin.SkinControl.SkinLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookCategory_tvw = new CCWin.SkinControl.SkinTreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookInfo_dgv = new CCWin.SkinControl.SkinDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookInfo_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BookAdd_Btn);
            this.panel1.Controls.Add(this.BookSearch_btn);
            this.panel1.Controls.Add(this.BookSearch_tb);
            this.panel1.Controls.Add(this.lbl_BookSearch_tb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 100);
            this.panel1.TabIndex = 0;
            // 
            // BookAdd_Btn
            // 
            this.BookAdd_Btn.BackColor = System.Drawing.Color.Transparent;
            this.BookAdd_Btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BookAdd_Btn.DownBack = null;
            this.BookAdd_Btn.Location = new System.Drawing.Point(709, 38);
            this.BookAdd_Btn.MouseBack = null;
            this.BookAdd_Btn.Name = "BookAdd_Btn";
            this.BookAdd_Btn.NormlBack = null;
            this.BookAdd_Btn.Size = new System.Drawing.Size(75, 23);
            this.BookAdd_Btn.TabIndex = 5;
            this.BookAdd_Btn.Text = "添加书籍";
            this.BookAdd_Btn.UseVisualStyleBackColor = false;
            this.BookAdd_Btn.Click += new System.EventHandler(this.BookAddBtn_Click);
            // 
            // BookSearch_btn
            // 
            this.BookSearch_btn.BackColor = System.Drawing.Color.Transparent;
            this.BookSearch_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BookSearch_btn.DownBack = null;
            this.BookSearch_btn.Location = new System.Drawing.Point(347, 38);
            this.BookSearch_btn.MouseBack = null;
            this.BookSearch_btn.Name = "BookSearch_btn";
            this.BookSearch_btn.NormlBack = null;
            this.BookSearch_btn.Size = new System.Drawing.Size(75, 23);
            this.BookSearch_btn.TabIndex = 6;
            this.BookSearch_btn.Text = "搜索";
            this.BookSearch_btn.UseVisualStyleBackColor = false;
            this.BookSearch_btn.Click += new System.EventHandler(this.BookSearch_btn_Click);
            // 
            // BookSearch_tb
            // 
            this.BookSearch_tb.BackColor = System.Drawing.Color.Transparent;
            this.BookSearch_tb.DownBack = null;
            this.BookSearch_tb.Icon = null;
            this.BookSearch_tb.IconIsButton = false;
            this.BookSearch_tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.BookSearch_tb.IsPasswordChat = '\0';
            this.BookSearch_tb.IsSystemPasswordChar = false;
            this.BookSearch_tb.Lines = new string[0];
            this.BookSearch_tb.Location = new System.Drawing.Point(154, 36);
            this.BookSearch_tb.Margin = new System.Windows.Forms.Padding(0);
            this.BookSearch_tb.MaxLength = 32767;
            this.BookSearch_tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.BookSearch_tb.MouseBack = null;
            this.BookSearch_tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.BookSearch_tb.Multiline = false;
            this.BookSearch_tb.Name = "BookSearch_tb";
            this.BookSearch_tb.NormlBack = null;
            this.BookSearch_tb.Padding = new System.Windows.Forms.Padding(5);
            this.BookSearch_tb.ReadOnly = false;
            this.BookSearch_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BookSearch_tb.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.BookSearch_tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookSearch_tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookSearch_tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.BookSearch_tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.BookSearch_tb.SkinTxt.Name = "BaseText";
            this.BookSearch_tb.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.BookSearch_tb.SkinTxt.TabIndex = 0;
            this.BookSearch_tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.BookSearch_tb.SkinTxt.WaterText = "";
            this.BookSearch_tb.TabIndex = 4;
            this.BookSearch_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookSearch_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.BookSearch_tb.WaterText = "";
            this.BookSearch_tb.WordWrap = true;
            // 
            // lbl_BookSearch_tb
            // 
            this.lbl_BookSearch_tb.AutoSize = true;
            this.lbl_BookSearch_tb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookSearch_tb.BorderColor = System.Drawing.Color.White;
            this.lbl_BookSearch_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_BookSearch_tb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_BookSearch_tb.Location = new System.Drawing.Point(95, 42);
            this.lbl_BookSearch_tb.Name = "lbl_BookSearch_tb";
            this.lbl_BookSearch_tb.Size = new System.Drawing.Size(56, 17);
            this.lbl_BookSearch_tb.TabIndex = 3;
            this.lbl_BookSearch_tb.Text = "图书编号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BookCategory_tvw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 425);
            this.panel2.TabIndex = 1;
            // 
            // BookCategory_tvw
            // 
            this.BookCategory_tvw.BorderColor = System.Drawing.Color.White;
            this.BookCategory_tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookCategory_tvw.LineColor = System.Drawing.Color.White;
            this.BookCategory_tvw.Location = new System.Drawing.Point(0, 0);
            this.BookCategory_tvw.Name = "BookCategory_tvw";
            this.BookCategory_tvw.Size = new System.Drawing.Size(200, 425);
            this.BookCategory_tvw.TabIndex = 0;
            this.BookCategory_tvw.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.BookCategory_tvw_NodeMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BookInfo_dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 425);
            this.panel3.TabIndex = 2;
            // 
            // BookInfo_dgv
            // 
            this.BookInfo_dgv.AllowUserToAddRows = false;
            this.BookInfo_dgv.AllowUserToDeleteRows = false;
            this.BookInfo_dgv.AllowUserToResizeColumns = false;
            this.BookInfo_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.BookInfo_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookInfo_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookInfo_dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BookInfo_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookInfo_dgv.ColumnFont = null;
            this.BookInfo_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookInfo_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookInfo_dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookInfo_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookInfo_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookInfo_dgv.EnableHeadersVisualStyles = false;
            this.BookInfo_dgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BookInfo_dgv.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfo_dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.BookInfo_dgv.Location = new System.Drawing.Point(0, 0);
            this.BookInfo_dgv.Name = "BookInfo_dgv";
            this.BookInfo_dgv.ReadOnly = true;
            this.BookInfo_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookInfo_dgv.RowHeadersVisible = false;
            this.BookInfo_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BookInfo_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BookInfo_dgv.RowTemplate.Height = 23;
            this.BookInfo_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookInfo_dgv.Size = new System.Drawing.Size(649, 425);
            this.BookInfo_dgv.TabIndex = 0;
            this.BookInfo_dgv.TitleBack = null;
            this.BookInfo_dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.BookInfo_dgv.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.BookInfo_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookInfo_dgv_CellContentClick);
            // 
            // BookInfo_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookInfo_Control";
            this.Size = new System.Drawing.Size(849, 525);
            this.Load += new System.EventHandler(this.BookInfo_Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookInfo_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinButton BookAdd_Btn;
        private CCWin.SkinControl.SkinButton BookSearch_btn;
        private CCWin.SkinControl.SkinTextBox BookSearch_tb;
        private CCWin.SkinControl.SkinLabel lbl_BookSearch_tb;
        private CCWin.SkinControl.SkinTreeView BookCategory_tvw;
        private CCWin.SkinControl.SkinDataGridView BookInfo_dgv;
    }
}
