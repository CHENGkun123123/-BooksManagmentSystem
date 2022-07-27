namespace BookUI
{
    partial class Login_Form
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AdminId_Tb = new CCWin.SkinControl.SkinTextBox();
            this.AdminPwd_Tb = new CCWin.SkinControl.SkinTextBox();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // AdminId_Tb
            // 
            this.AdminId_Tb.BackColor = System.Drawing.Color.Transparent;
            this.AdminId_Tb.DownBack = null;
            this.AdminId_Tb.Icon = null;
            this.AdminId_Tb.IconIsButton = false;
            this.AdminId_Tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminId_Tb.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AdminId_Tb.IsPasswordChat = '\0';
            this.AdminId_Tb.IsSystemPasswordChar = false;
            this.AdminId_Tb.Lines = new string[] {
        "点击输入用户名"};
            this.AdminId_Tb.Location = new System.Drawing.Point(149, 133);
            this.AdminId_Tb.Margin = new System.Windows.Forms.Padding(0);
            this.AdminId_Tb.MaxLength = 32767;
            this.AdminId_Tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.AdminId_Tb.MouseBack = null;
            this.AdminId_Tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminId_Tb.Multiline = false;
            this.AdminId_Tb.Name = "AdminId_Tb";
            this.AdminId_Tb.NormlBack = null;
            this.AdminId_Tb.Padding = new System.Windows.Forms.Padding(5);
            this.AdminId_Tb.ReadOnly = false;
            this.AdminId_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminId_Tb.Size = new System.Drawing.Size(232, 28);
            // 
            // 
            // 
            this.AdminId_Tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminId_Tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminId_Tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 8.75F);
            this.AdminId_Tb.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminId_Tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.AdminId_Tb.SkinTxt.Name = "BaseText";
            this.AdminId_Tb.SkinTxt.Size = new System.Drawing.Size(222, 16);
            this.AdminId_Tb.SkinTxt.TabIndex = 0;
            this.AdminId_Tb.SkinTxt.Text = "点击输入用户名";
            this.AdminId_Tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminId_Tb.SkinTxt.WaterText = "";
            this.AdminId_Tb.TabIndex = 0;
            this.AdminId_Tb.Text = "点击输入用户名";
            this.AdminId_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminId_Tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminId_Tb.WaterText = "";
            this.AdminId_Tb.WordWrap = true;
            this.AdminId_Tb.Enter += new System.EventHandler(this.AdminIdChk_Enter);
            this.AdminId_Tb.Leave += new System.EventHandler(this.AdminIdChk_Leave);
            // 
            // AdminPwd_Tb
            // 
            this.AdminPwd_Tb.BackColor = System.Drawing.Color.Transparent;
            this.AdminPwd_Tb.DownBack = null;
            this.AdminPwd_Tb.Icon = null;
            this.AdminPwd_Tb.IconIsButton = false;
            this.AdminPwd_Tb.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminPwd_Tb.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AdminPwd_Tb.IsPasswordChat = '\0';
            this.AdminPwd_Tb.IsSystemPasswordChar = false;
            this.AdminPwd_Tb.Lines = new string[] {
        "点击输入密码"};
            this.AdminPwd_Tb.Location = new System.Drawing.Point(149, 182);
            this.AdminPwd_Tb.Margin = new System.Windows.Forms.Padding(0);
            this.AdminPwd_Tb.MaxLength = 32767;
            this.AdminPwd_Tb.MinimumSize = new System.Drawing.Size(28, 28);
            this.AdminPwd_Tb.MouseBack = null;
            this.AdminPwd_Tb.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminPwd_Tb.Multiline = false;
            this.AdminPwd_Tb.Name = "AdminPwd_Tb";
            this.AdminPwd_Tb.NormlBack = null;
            this.AdminPwd_Tb.Padding = new System.Windows.Forms.Padding(5);
            this.AdminPwd_Tb.ReadOnly = false;
            this.AdminPwd_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminPwd_Tb.Size = new System.Drawing.Size(232, 28);
            // 
            // 
            // 
            this.AdminPwd_Tb.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPwd_Tb.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPwd_Tb.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 8.75F);
            this.AdminPwd_Tb.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminPwd_Tb.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.AdminPwd_Tb.SkinTxt.Name = "BaseText";
            this.AdminPwd_Tb.SkinTxt.Size = new System.Drawing.Size(222, 16);
            this.AdminPwd_Tb.SkinTxt.TabIndex = 0;
            this.AdminPwd_Tb.SkinTxt.Text = "点击输入密码";
            this.AdminPwd_Tb.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminPwd_Tb.SkinTxt.WaterText = "";
            this.AdminPwd_Tb.TabIndex = 1;
            this.AdminPwd_Tb.Text = "点击输入密码";
            this.AdminPwd_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminPwd_Tb.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminPwd_Tb.WaterText = "";
            this.AdminPwd_Tb.WordWrap = true;
            this.AdminPwd_Tb.Enter += new System.EventHandler(this.AdminPwdChk_Enter);
            this.AdminPwd_Tb.Leave += new System.EventHandler(this.AdminPwdChk_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LoginBtn.DownBack = null;
            this.LoginBtn.Location = new System.Drawing.Point(220, 237);
            this.LoginBtn.MouseBack = null;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = null;
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "确认登录";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.AdminPwd_Tb);
            this.Controls.Add(this.AdminId_Tb);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.Shadow = false;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "管理系统登录";
            this.TitleOffset = new System.Drawing.Point(195, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox AdminId_Tb;
        private CCWin.SkinControl.SkinTextBox AdminPwd_Tb;
        private CCWin.SkinControl.SkinButton LoginBtn;
    }
}

