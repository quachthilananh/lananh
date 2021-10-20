namespace ProjectQuanCafeK19
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lb_Login = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pl_Top = new System.Windows.Forms.Panel();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Shutdown = new System.Windows.Forms.PictureBox();
            this.bn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chk_SaveAccount = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lb_SaveAccount = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_ForgotPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.pb_Banner = new System.Windows.Forms.PictureBox();
            this.pl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Shutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_Login.Location = new System.Drawing.Point(116, 176);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(199, 25);
            this.lb_Login.TabIndex = 1;
            this.lb_Login.Text = "Kiến An, Hải Phòng";
            this.lb_Login.Click += new System.EventHandler(this.lb_Login_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pl_Top
            // 
            this.pl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.pl_Top.Controls.Add(this.pb_Minimize);
            this.pl_Top.Controls.Add(this.pb_Shutdown);
            this.pl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Top.Location = new System.Drawing.Point(0, 0);
            this.pl_Top.Name = "pl_Top";
            this.pl_Top.Size = new System.Drawing.Size(947, 37);
            this.pl_Top.TabIndex = 5;
            this.pl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseDown);
            this.pl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseMove);
            this.pl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseUp);
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.pb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_Minimize.Image")));
            this.pb_Minimize.Location = new System.Drawing.Point(847, 3);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(41, 34);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Minimize.TabIndex = 3;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            // 
            // pb_Shutdown
            // 
            this.pb_Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.pb_Shutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Shutdown.Image = ((System.Drawing.Image)(resources.GetObject("pb_Shutdown.Image")));
            this.pb_Shutdown.Location = new System.Drawing.Point(894, 3);
            this.pb_Shutdown.Name = "pb_Shutdown";
            this.pb_Shutdown.Size = new System.Drawing.Size(41, 34);
            this.pb_Shutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Shutdown.TabIndex = 3;
            this.pb_Shutdown.TabStop = false;
            this.pb_Shutdown.Click += new System.EventHandler(this.pb_Shutdown_Click);
            // 
            // bn_Login
            // 
            this.bn_Login.BackColor = System.Drawing.Color.Transparent;
            this.bn_Login.BorderRadius = 25;
            this.bn_Login.CheckedState.Parent = this.bn_Login;
            this.bn_Login.CustomImages.Parent = this.bn_Login;
            this.bn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bn_Login.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Login.ForeColor = System.Drawing.Color.White;
            this.bn_Login.HoverState.Parent = this.bn_Login;
            this.bn_Login.Location = new System.Drawing.Point(80, 425);
            this.bn_Login.Name = "bn_Login";
            this.bn_Login.ShadowDecoration.Parent = this.bn_Login;
            this.bn_Login.Size = new System.Drawing.Size(249, 47);
            this.bn_Login.TabIndex = 20;
            this.bn_Login.Text = "Đăng Nhập";
            this.bn_Login.Click += new System.EventHandler(this.bn_Login_Click);
            // 
            // chk_SaveAccount
            // 
            this.chk_SaveAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_SaveAccount.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_SaveAccount.Checked = true;
            this.chk_SaveAccount.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_SaveAccount.ForeColor = System.Drawing.Color.White;
            this.chk_SaveAccount.Location = new System.Drawing.Point(123, 385);
            this.chk_SaveAccount.Name = "chk_SaveAccount";
            this.chk_SaveAccount.Size = new System.Drawing.Size(20, 20);
            this.chk_SaveAccount.TabIndex = 19;
            // 
            // lb_SaveAccount
            // 
            this.lb_SaveAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaveAccount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_SaveAccount.Location = new System.Drawing.Point(142, 376);
            this.lb_SaveAccount.Name = "lb_SaveAccount";
            this.lb_SaveAccount.Size = new System.Drawing.Size(151, 35);
            this.lb_SaveAccount.TabIndex = 17;
            this.lb_SaveAccount.Text = "Lưu tài khoản";
            this.lb_SaveAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.Silver;
            this.tb_Password.Location = new System.Drawing.Point(112, 325);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(230, 28);
            this.tb_Password.TabIndex = 15;
            this.tb_Password.TabStop = false;
            this.tb_Password.Text = "Password";
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Password_KeyPress);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.Silver;
            this.tb_Username.Location = new System.Drawing.Point(112, 248);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(230, 30);
            this.tb_Username.TabIndex = 16;
            this.tb_Username.TabStop = false;
            this.tb_Username.Text = "Tên tài khoản";
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Username_KeyPress);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // lb_ForgotPassword
            // 
            this.lb_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_ForgotPassword.Location = new System.Drawing.Point(52, 491);
            this.lb_ForgotPassword.Name = "lb_ForgotPassword";
            this.lb_ForgotPassword.Size = new System.Drawing.Size(304, 35);
            this.lb_ForgotPassword.TabIndex = 22;
            this.lb_ForgotPassword.Text = "Quên mật khẩu ?";
            this.lb_ForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(80, 414);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(249, 69);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // pb_Password
            // 
            this.pb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Password.Image = ((System.Drawing.Image)(resources.GetObject("pb_Password.Image")));
            this.pb_Password.Location = new System.Drawing.Point(68, 322);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(37, 33);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Password.TabIndex = 13;
            this.pb_Password.TabStop = false;
            // 
            // pb_Username
            // 
            this.pb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Username.Image = ((System.Drawing.Image)(resources.GetObject("pb_Username.Image")));
            this.pb_Username.Location = new System.Drawing.Point(68, 247);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(37, 33);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Username.TabIndex = 14;
            this.pb_Username.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(52, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(304, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 228);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.milkshake_500px;
            this.pb_Avatar.Location = new System.Drawing.Point(116, 55);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(177, 104);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Avatar.TabIndex = 10;
            this.pb_Avatar.TabStop = false;
            // 
            // pb_Banner
            // 
            this.pb_Banner.Image = ((System.Drawing.Image)(resources.GetObject("pb_Banner.Image")));
            this.pb_Banner.Location = new System.Drawing.Point(416, 76);
            this.pb_Banner.Name = "pb_Banner";
            this.pb_Banner.Size = new System.Drawing.Size(505, 385);
            this.pb_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Banner.TabIndex = 0;
            this.pb_Banner.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_ForgotPassword);
            this.Controls.Add(this.bn_Login);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.chk_SaveAccount);
            this.Controls.Add(this.lb_SaveAccount);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.pb_Username);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.pl_Top);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.pb_Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.pl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Shutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Banner;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pl_Top;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Shutdown;
        private Guna.UI2.WinForms.Guna2GradientButton bn_Login;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuCheckbox chk_SaveAccount;
        private System.Windows.Forms.Label lb_SaveAccount;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Label lb_ForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}