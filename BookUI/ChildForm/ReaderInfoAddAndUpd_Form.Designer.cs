namespace BookUI.ChildForm
{
    partial class ReaderInfoAddAndUpd_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReaderAddBtn = new CCWin.SkinControl.SkinButton();
            this.lbl_Mobile_tb = new CCWin.SkinControl.SkinLabel();
            this.lbl_AddRess_tb = new CCWin.SkinControl.SkinLabel();
            this.lbl_ReaderEmail_tb = new CCWin.SkinControl.SkinLabel();
            this.lbl_ReaderName_tb = new CCWin.SkinControl.SkinLabel();
            this.ReaderEmail_tb = new CCWin.SkinControl.SkinTextBox();
            this.ReaderName_tb = new CCWin.SkinControl.SkinTextBox();
            this.AddRess_tb = new CCWin.SkinControl.SkinTextBox();
            this.Mobile_tb = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // ReaderAddBtn
            // 
            this.ReaderAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReaderAddBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ReaderAddBtn.DownBack = null;
            this.ReaderAddBtn.Location = new System.Drawing.Point(305, 315);
            this.ReaderAddBtn.MouseBack = null;
            this.ReaderAddBtn.Name = "ReaderAddBtn";
            this.ReaderAddBtn.NormlBack = null;
            this.ReaderAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ReaderAddBtn.TabIndex = 12;
            this.ReaderAddBtn.Text = "保存";
            this.ReaderAddBtn.UseVisualStyleBackColor = false;
            this.ReaderAddBtn.Click += new System.EventHandler(this.ReaderAddBtn_Click);
            // 
            // lbl_Mobile_tb
            // 
            this.lbl_Mobile_tb.AutoSize = true;
            this.lbl_Mobile_tb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_tb.BorderColor = System.Drawing.Color.White;
            this.lbl_Mobile_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Mobile_tb.Location = new System.Drawing.Point(192, 254);
            this.lbl_Mobile_tb.Name = "lbl_Mobile_tb";
            this.lbl_Mobile_tb.Size = new System.Drawing.Size(56, 17);
            this.lbl_Mobile_tb.TabIndex = 7;
            this.lbl_Mobile_tb.Text = "联系方式";
            // 
            // lbl_AddRess_tb
            // 
            this.lbl_AddRess_tb.AutoSize = true;
            this.lbl_AddRess_tb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddRess_tb.BorderColor = System.Drawing.Color.White;
            this.lbl_AddRess_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AddRess_tb.Location = new System.Drawing.Point(192, 210);
            this.lbl_AddRess_tb.Name = "lbl_AddRess_tb";
            this.lbl_AddRess_tb.Size = new System.Drawing.Size(56, 17);
            this.lbl_AddRess_tb.TabIndex = 8;
            this.lbl_AddRess_tb.Text = "家庭住址";
            // 
            // lbl_ReaderEmail_tb
            // 
            this.lbl_ReaderEmail_tb.AutoSize = true;
            this.lbl_ReaderEmail_tb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReaderEmail_tb.BorderColor = System.Drawing.Color.White;
            this.lbl_ReaderEmail_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ReaderEmail_tb.Location = new System.Drawing.Point(192, 163);
            this.lbl_ReaderEmail_tb.Name = "lbl_ReaderEmail_tb";
            this.lbl_ReaderEmail_tb.Size = new System.Drawing.Size(56, 17);
            this.lbl_ReaderEmail_tb.TabIndex = 9;
            this.lbl_ReaderEmail_tb.Text = "读者邮箱";
            // 
            // lbl_ReaderName_tb
            // 
            this.lbl_ReaderName_tb.AutoSize = true;
            this.lbl_ReaderName_tb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReaderName_tb.BorderColor = System.Drawing.Color.White;
            this.lbl_ReaderName_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ReaderName_tb.Location = new System.Drawing.Point(192, 119);
            this.lbl_ReaderName_tb.Name = "lbl_ReaderName_tb";
            this.lbl_ReaderName_tb.Size = new System.Drawing.Size(56, 17);
            this.lbl_ReaderName_tb.TabIndex = 10;
            this.lbl_ReaderName_tb.Text = "读者名称";
            // 
            // ReaderEmail_tb
            // 
            this.ReaderEmail_tb.BackColor = System.Drawing.Color.Transparent;
            this.ReaderEmail_tb.DownBack = null;
            this.ReaderEmail_tb.Icon = null;
            this.ReaderEmail_tb.IconIsButton = false;
            this.ReaderEmail_tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReaderEmail_tb.IsPasswordChat = '\0';
            this.ReaderEmail_tb.IsSystemPasswordChar = false;
            this.ReaderEmail_tb.Lines = new string[0];
            this.ReaderEmail_tb.Location = new System.Drawing.Point(264, 156);
            this.ReaderEmail_tb.Margin = new System.Windows.Forms.Padding(0);
            this.ReaderEmail_tb.MaxLength = 32767;
            this.ReaderEmail_tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.ReaderEmail_tb.MouseBack = null;
            this.ReaderEmail_tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReaderEmail_tb.Multiline = false;
            this.ReaderEmail_tb.Name = "ReaderEmail_tb";
            this.ReaderEmail_tb.NormlBack = null;
            this.ReaderEmail_tb.Padding = new System.Windows.Forms.Padding(5);
            this.ReaderEmail_tb.ReadOnly = false;
            this.ReaderEmail_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReaderEmail_tb.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.ReaderEmail_tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReaderEmail_tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReaderEmail_tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ReaderEmail_tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ReaderEmail_tb.SkinTxt.Name = "BaseText";
            this.ReaderEmail_tb.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.ReaderEmail_tb.SkinTxt.TabIndex = 0;
            this.ReaderEmail_tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReaderEmail_tb.SkinTxt.WaterText = "";
            this.ReaderEmail_tb.TabIndex = 5;
            this.ReaderEmail_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReaderEmail_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReaderEmail_tb.WaterText = "";
            this.ReaderEmail_tb.WordWrap = true;
            // 
            // ReaderName_tb
            // 
            this.ReaderName_tb.BackColor = System.Drawing.Color.Transparent;
            this.ReaderName_tb.DownBack = null;
            this.ReaderName_tb.Icon = null;
            this.ReaderName_tb.IconIsButton = false;
            this.ReaderName_tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReaderName_tb.IsPasswordChat = '\0';
            this.ReaderName_tb.IsSystemPasswordChar = false;
            this.ReaderName_tb.Lines = new string[0];
            this.ReaderName_tb.Location = new System.Drawing.Point(264, 112);
            this.ReaderName_tb.Margin = new System.Windows.Forms.Padding(0);
            this.ReaderName_tb.MaxLength = 32767;
            this.ReaderName_tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.ReaderName_tb.MouseBack = null;
            this.ReaderName_tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ReaderName_tb.Multiline = false;
            this.ReaderName_tb.Name = "ReaderName_tb";
            this.ReaderName_tb.NormlBack = null;
            this.ReaderName_tb.Padding = new System.Windows.Forms.Padding(5);
            this.ReaderName_tb.ReadOnly = false;
            this.ReaderName_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReaderName_tb.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.ReaderName_tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReaderName_tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReaderName_tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ReaderName_tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ReaderName_tb.SkinTxt.Name = "BaseText";
            this.ReaderName_tb.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.ReaderName_tb.SkinTxt.TabIndex = 0;
            this.ReaderName_tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReaderName_tb.SkinTxt.WaterText = "";
            this.ReaderName_tb.TabIndex = 6;
            this.ReaderName_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReaderName_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ReaderName_tb.WaterText = "";
            this.ReaderName_tb.WordWrap = true;
            // 
            // AddRess_tb
            // 
            this.AddRess_tb.BackColor = System.Drawing.Color.Transparent;
            this.AddRess_tb.DownBack = null;
            this.AddRess_tb.Icon = null;
            this.AddRess_tb.IconIsButton = false;
            this.AddRess_tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.AddRess_tb.IsPasswordChat = '\0';
            this.AddRess_tb.IsSystemPasswordChar = false;
            this.AddRess_tb.Lines = new string[0];
            this.AddRess_tb.Location = new System.Drawing.Point(264, 204);
            this.AddRess_tb.Margin = new System.Windows.Forms.Padding(0);
            this.AddRess_tb.MaxLength = 32767;
            this.AddRess_tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.AddRess_tb.MouseBack = null;
            this.AddRess_tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.AddRess_tb.Multiline = false;
            this.AddRess_tb.Name = "AddRess_tb";
            this.AddRess_tb.NormlBack = null;
            this.AddRess_tb.Padding = new System.Windows.Forms.Padding(5);
            this.AddRess_tb.ReadOnly = false;
            this.AddRess_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddRess_tb.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.AddRess_tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddRess_tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRess_tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.AddRess_tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.AddRess_tb.SkinTxt.Name = "BaseText";
            this.AddRess_tb.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.AddRess_tb.SkinTxt.TabIndex = 0;
            this.AddRess_tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AddRess_tb.SkinTxt.WaterText = "";
            this.AddRess_tb.TabIndex = 5;
            this.AddRess_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddRess_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AddRess_tb.WaterText = "";
            this.AddRess_tb.WordWrap = true;
            // 
            // Mobile_tb
            // 
            this.Mobile_tb.BackColor = System.Drawing.Color.Transparent;
            this.Mobile_tb.DownBack = null;
            this.Mobile_tb.Icon = null;
            this.Mobile_tb.IconIsButton = false;
            this.Mobile_tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Mobile_tb.IsPasswordChat = '\0';
            this.Mobile_tb.IsSystemPasswordChar = false;
            this.Mobile_tb.Lines = new string[0];
            this.Mobile_tb.Location = new System.Drawing.Point(264, 248);
            this.Mobile_tb.Margin = new System.Windows.Forms.Padding(0);
            this.Mobile_tb.MaxLength = 11;
            this.Mobile_tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.Mobile_tb.MouseBack = null;
            this.Mobile_tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Mobile_tb.Multiline = false;
            this.Mobile_tb.Name = "Mobile_tb";
            this.Mobile_tb.NormlBack = null;
            this.Mobile_tb.Padding = new System.Windows.Forms.Padding(5);
            this.Mobile_tb.ReadOnly = false;
            this.Mobile_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Mobile_tb.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.Mobile_tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mobile_tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mobile_tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Mobile_tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Mobile_tb.SkinTxt.MaxLength = 11;
            this.Mobile_tb.SkinTxt.Name = "BaseText";
            this.Mobile_tb.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.Mobile_tb.SkinTxt.TabIndex = 0;
            this.Mobile_tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Mobile_tb.SkinTxt.WaterText = "";
            this.Mobile_tb.TabIndex = 5;
            this.Mobile_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Mobile_tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Mobile_tb.WaterText = "";
            this.Mobile_tb.WordWrap = true;
            // 
            // ReaderInfoAddAndUpd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.ReaderAddBtn);
            this.Controls.Add(this.lbl_Mobile_tb);
            this.Controls.Add(this.lbl_AddRess_tb);
            this.Controls.Add(this.lbl_ReaderEmail_tb);
            this.Controls.Add(this.lbl_ReaderName_tb);
            this.Controls.Add(this.Mobile_tb);
            this.Controls.Add(this.AddRess_tb);
            this.Controls.Add(this.ReaderEmail_tb);
            this.Controls.Add(this.ReaderName_tb);
            this.MaximizeBox = false;
            this.Name = "ReaderInfoAddAndUpd_Form";
            this.ShowDrawIcon = false;
            this.Text = "读者添加";
            this.TitleCenter = true;
            this.TitleOffset = new System.Drawing.Point(30, 0);
            this.Load += new System.EventHandler(this.ReaderInfoAddAndUpd_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton ReaderAddBtn;
        private CCWin.SkinControl.SkinLabel lbl_Mobile_tb;
        private CCWin.SkinControl.SkinLabel lbl_AddRess_tb;
        private CCWin.SkinControl.SkinLabel lbl_ReaderEmail_tb;
        private CCWin.SkinControl.SkinLabel lbl_ReaderName_tb;
        private CCWin.SkinControl.SkinTextBox ReaderEmail_tb;
        private CCWin.SkinControl.SkinTextBox ReaderName_tb;
        private CCWin.SkinControl.SkinTextBox AddRess_tb;
        private CCWin.SkinControl.SkinTextBox Mobile_tb;
    }
}