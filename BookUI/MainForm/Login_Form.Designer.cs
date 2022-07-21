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
            this.AdminIdChk = new CCWin.SkinControl.SkinTextBox();
            this.AdminPwdChk = new CCWin.SkinControl.SkinTextBox();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // AdminIdChk
            // 
            this.AdminIdChk.BackColor = System.Drawing.Color.Transparent;
            this.AdminIdChk.DownBack = null;
            this.AdminIdChk.Icon = null;
            this.AdminIdChk.IconIsButton = false;
            this.AdminIdChk.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminIdChk.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AdminIdChk.IsPasswordChat = '\0';
            this.AdminIdChk.IsSystemPasswordChar = false;
            this.AdminIdChk.Lines = new string[] {
        "点击输入用户名"};
            this.AdminIdChk.Location = new System.Drawing.Point(149, 133);
            this.AdminIdChk.Margin = new System.Windows.Forms.Padding(0);
            this.AdminIdChk.MaxLength = 32767;
            this.AdminIdChk.MinimumSize = new System.Drawing.Size(28, 28);
            this.AdminIdChk.MouseBack = null;
            this.AdminIdChk.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminIdChk.Multiline = false;
            this.AdminIdChk.Name = "AdminIdChk";
            this.AdminIdChk.NormlBack = null;
            this.AdminIdChk.Padding = new System.Windows.Forms.Padding(5);
            this.AdminIdChk.ReadOnly = false;
            this.AdminIdChk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminIdChk.Size = new System.Drawing.Size(232, 28);
            // 
            // 
            // 
            this.AdminIdChk.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminIdChk.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminIdChk.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 8.75F);
            this.AdminIdChk.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminIdChk.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.AdminIdChk.SkinTxt.Name = "BaseText";
            this.AdminIdChk.SkinTxt.Size = new System.Drawing.Size(222, 16);
            this.AdminIdChk.SkinTxt.TabIndex = 0;
            this.AdminIdChk.SkinTxt.Text = "点击输入用户名";
            this.AdminIdChk.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminIdChk.SkinTxt.WaterText = "";
            this.AdminIdChk.TabIndex = 0;
            this.AdminIdChk.Text = "点击输入用户名";
            this.AdminIdChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminIdChk.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminIdChk.WaterText = "";
            this.AdminIdChk.WordWrap = true;
            this.AdminIdChk.Enter += new System.EventHandler(this.AdminIdChk_Enter);
            this.AdminIdChk.Leave += new System.EventHandler(this.AdminIdChk_Leave);
            // 
            // AdminPwdChk
            // 
            this.AdminPwdChk.BackColor = System.Drawing.Color.Transparent;
            this.AdminPwdChk.DownBack = null;
            this.AdminPwdChk.Icon = null;
            this.AdminPwdChk.IconIsButton = false;
            this.AdminPwdChk.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminPwdChk.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AdminPwdChk.IsPasswordChat = '\0';
            this.AdminPwdChk.IsSystemPasswordChar = false;
            this.AdminPwdChk.Lines = new string[] {
        "点击输入密码"};
            this.AdminPwdChk.Location = new System.Drawing.Point(149, 182);
            this.AdminPwdChk.Margin = new System.Windows.Forms.Padding(0);
            this.AdminPwdChk.MaxLength = 32767;
            this.AdminPwdChk.MinimumSize = new System.Drawing.Size(28, 28);
            this.AdminPwdChk.MouseBack = null;
            this.AdminPwdChk.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.AdminPwdChk.Multiline = false;
            this.AdminPwdChk.Name = "AdminPwdChk";
            this.AdminPwdChk.NormlBack = null;
            this.AdminPwdChk.Padding = new System.Windows.Forms.Padding(5);
            this.AdminPwdChk.ReadOnly = false;
            this.AdminPwdChk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminPwdChk.Size = new System.Drawing.Size(232, 28);
            // 
            // 
            // 
            this.AdminPwdChk.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminPwdChk.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPwdChk.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 8.75F);
            this.AdminPwdChk.SkinTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminPwdChk.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.AdminPwdChk.SkinTxt.Name = "BaseText";
            this.AdminPwdChk.SkinTxt.Size = new System.Drawing.Size(222, 16);
            this.AdminPwdChk.SkinTxt.TabIndex = 0;
            this.AdminPwdChk.SkinTxt.Text = "点击输入密码";
            this.AdminPwdChk.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminPwdChk.SkinTxt.WaterText = "";
            this.AdminPwdChk.TabIndex = 0;
            this.AdminPwdChk.Text = "点击输入密码";
            this.AdminPwdChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminPwdChk.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminPwdChk.WaterText = "";
            this.AdminPwdChk.WordWrap = true;
            this.AdminPwdChk.Enter += new System.EventHandler(this.AdminPwdChk_Enter);
            this.AdminPwdChk.Leave += new System.EventHandler(this.AdminPwdChk_Leave);
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
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "确认登录";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.White;
            this.CaptionBackColorTop = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.AdminPwdChk);
            this.Controls.Add(this.AdminIdChk);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Shadow = false;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "管理系统登录";
            this.TitleOffset = new System.Drawing.Point(195, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox AdminIdChk;
        private CCWin.SkinControl.SkinTextBox AdminPwdChk;
        private CCWin.SkinControl.SkinButton LoginBtn;
    }
}

