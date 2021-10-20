namespace ProjectQuanCafeK19.GUI.Account
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tt_Username = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tt_Password = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tb_RePassword = new System.Windows.Forms.TextBox();
            this.tt_RePassword = new System.Windows.Forms.ToolTip(this.components);
            this.pb_RePassword = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_DisplayName = new System.Windows.Forms.TextBox();
            this.tt_DisplayName = new System.Windows.Forms.ToolTip(this.components);
            this.pb_DisplayName = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cb_TypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_TypeAccount = new Guna.UI.WinForms.GunaLabel();
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Create = new Guna.UI2.WinForms.Guna2Button();
            this.pl_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.Silver;
            this.tb_Password.Location = new System.Drawing.Point(86, 100);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(230, 28);
            this.tb_Password.TabIndex = 21;
            this.tb_Password.TabStop = false;
            this.tb_Password.Text = "Password";
            this.tt_Password.SetToolTip(this.tb_Password, "Nhập mật khẩu");
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.Silver;
            this.tb_Username.Location = new System.Drawing.Point(86, 28);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(230, 30);
            this.tb_Username.TabIndex = 22;
            this.tb_Username.TabStop = false;
            this.tb_Username.Text = "Tên tài khoản";
            this.tt_Username.SetToolTip(this.tb_Username, "Tên tài khoản");
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            this.tb_Username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Username_Validating);
            // 
            // pb_Username
            // 
            this.pb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Username.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Username.Location = new System.Drawing.Point(42, 27);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(37, 33);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Username.TabIndex = 20;
            this.pb_Username.TabStop = false;
            this.tt_Username.SetToolTip(this.pb_Username, "Tên tài khoản");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.tt_Username.SetToolTip(this.pictureBox3, "Tên tài khoản");
            // 
            // pb_Password
            // 
            this.pb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Password.Image = global::ProjectQuanCafeK19.Properties.Resources.password_480px;
            this.pb_Password.Location = new System.Drawing.Point(42, 97);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(37, 33);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Password.TabIndex = 19;
            this.pb_Password.TabStop = false;
            this.tt_Password.SetToolTip(this.pb_Password, "Nhập mật khẩu");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(26, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(304, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.tt_Password.SetToolTip(this.pictureBox4, "Nhập mật khẩu");
            // 
            // e_FormCreateAccount
            // 
            this.e_FormCreateAccount.ElipseRadius = 0;
            this.e_FormCreateAccount.TargetControl = this;
            // 
            // tb_RePassword
            // 
            this.tb_RePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_RePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RePassword.ForeColor = System.Drawing.Color.Silver;
            this.tb_RePassword.Location = new System.Drawing.Point(86, 170);
            this.tb_RePassword.Multiline = true;
            this.tb_RePassword.Name = "tb_RePassword";
            this.tb_RePassword.PasswordChar = '*';
            this.tb_RePassword.Size = new System.Drawing.Size(230, 28);
            this.tb_RePassword.TabIndex = 21;
            this.tb_RePassword.TabStop = false;
            this.tb_RePassword.Text = "Password";
            this.tt_RePassword.SetToolTip(this.tb_RePassword, "Nhập lại mật khẩu");
            this.tb_RePassword.Enter += new System.EventHandler(this.tb_RePassword_Enter);
            this.tb_RePassword.Leave += new System.EventHandler(this.tb_RePassword_Leave);
            // 
            // pb_RePassword
            // 
            this.pb_RePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_RePassword.Image = global::ProjectQuanCafeK19.Properties.Resources.password_480px;
            this.pb_RePassword.Location = new System.Drawing.Point(42, 167);
            this.pb_RePassword.Name = "pb_RePassword";
            this.pb_RePassword.Size = new System.Drawing.Size(37, 33);
            this.pb_RePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_RePassword.TabIndex = 19;
            this.pb_RePassword.TabStop = false;
            this.tt_RePassword.SetToolTip(this.pb_RePassword, "Nhập lại mật khẩu");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.tt_RePassword.SetToolTip(this.pictureBox1, "Nhập lại mật khẩu");
            // 
            // tb_DisplayName
            // 
            this.tb_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DisplayName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DisplayName.ForeColor = System.Drawing.Color.Silver;
            this.tb_DisplayName.Location = new System.Drawing.Point(86, 239);
            this.tb_DisplayName.Multiline = true;
            this.tb_DisplayName.Name = "tb_DisplayName";
            this.tb_DisplayName.Size = new System.Drawing.Size(230, 30);
            this.tb_DisplayName.TabIndex = 25;
            this.tb_DisplayName.TabStop = false;
            this.tb_DisplayName.Text = "Tên hiển thị";
            this.tt_DisplayName.SetToolTip(this.tb_DisplayName, "Tên hiển thị");
            this.tb_DisplayName.Enter += new System.EventHandler(this.tb_DisplayName_Enter);
            this.tb_DisplayName.Leave += new System.EventHandler(this.tb_DisplayName_Leave);
            // 
            // pb_DisplayName
            // 
            this.pb_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_DisplayName.Image = global::ProjectQuanCafeK19.Properties.Resources.workspace_480px;
            this.pb_DisplayName.Location = new System.Drawing.Point(42, 238);
            this.pb_DisplayName.Name = "pb_DisplayName";
            this.pb_DisplayName.Size = new System.Drawing.Size(37, 33);
            this.pb_DisplayName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DisplayName.TabIndex = 24;
            this.pb_DisplayName.TabStop = false;
            this.tt_DisplayName.SetToolTip(this.pb_DisplayName, "Tên hiển thị");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(26, 219);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(304, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.tt_DisplayName.SetToolTip(this.pictureBox6, "Tên hiển thị");
            // 
            // cb_TypeAccount
            // 
            this.cb_TypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.cb_TypeAccount.BorderColor = System.Drawing.SystemColors.Control;
            this.cb_TypeAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TypeAccount.FillColor = System.Drawing.SystemColors.Control;
            this.cb_TypeAccount.FocusedColor = System.Drawing.Color.Empty;
            this.cb_TypeAccount.FocusedState.Parent = this.cb_TypeAccount;
            this.cb_TypeAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TypeAccount.ForeColor = System.Drawing.Color.Black;
            this.cb_TypeAccount.FormattingEnabled = true;
            this.cb_TypeAccount.HoverState.Parent = this.cb_TypeAccount;
            this.cb_TypeAccount.ItemHeight = 30;
            this.cb_TypeAccount.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cb_TypeAccount.ItemsAppearance.Parent = this.cb_TypeAccount;
            this.cb_TypeAccount.Location = new System.Drawing.Point(173, 305);
            this.cb_TypeAccount.Name = "cb_TypeAccount";
            this.cb_TypeAccount.ShadowDecoration.Parent = this.cb_TypeAccount;
            this.cb_TypeAccount.Size = new System.Drawing.Size(157, 36);
            this.cb_TypeAccount.TabIndex = 27;
            // 
            // lb_TypeAccount
            // 
            this.lb_TypeAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lb_TypeAccount.Location = new System.Drawing.Point(26, 305);
            this.lb_TypeAccount.Name = "lb_TypeAccount";
            this.lb_TypeAccount.Size = new System.Drawing.Size(148, 36);
            this.lb_TypeAccount.TabIndex = 28;
            this.lb_TypeAccount.Text = "Loại tài khoản:";
            this.lb_TypeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // of_Avatar
            // 
            this.of_Avatar.FileName = "of_Avatar";
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Avatar.Location = new System.Drawing.Point(95, 354);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Avatar.ShadowDecoration.Parent = this.pb_Avatar;
            this.pb_Avatar.Size = new System.Drawing.Size(167, 163);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 29;
            this.pb_Avatar.TabStop = false;
            this.tt_Avatar.SetToolTip(this.pb_Avatar, "Chọn ảnh đại diện");
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BorderRadius = 15;
            this.btn_Cancel.CheckedState.Parent = this.btn_Cancel;
            this.btn_Cancel.CustomImages.Parent = this.btn_Cancel;
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.HoverState.Parent = this.btn_Cancel;
            this.btn_Cancel.Image = global::ProjectQuanCafeK19.Properties.Resources.cancel_480px;
            this.btn_Cancel.Location = new System.Drawing.Point(31, 538);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(133, 35);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Trở lại";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Create.BorderRadius = 15;
            this.btn_Create.CheckedState.Parent = this.btn_Create;
            this.btn_Create.CustomImages.Parent = this.btn_Create;
            this.btn_Create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.HoverState.Parent = this.btn_Create;
            this.btn_Create.Image = global::ProjectQuanCafeK19.Properties.Resources.add_480px;
            this.btn_Create.Location = new System.Drawing.Point(197, 538);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.ShadowDecoration.Parent = this.btn_Create;
            this.btn_Create.Size = new System.Drawing.Size(133, 35);
            this.btn_Create.TabIndex = 34;
            this.btn_Create.Text = "Thêm mới";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // pl_Main
            // 
            this.pl_Main.BackColor = System.Drawing.Color.Transparent;
            this.pl_Main.BorderColor = System.Drawing.Color.DimGray;
            this.pl_Main.BorderRadius = 5;
            this.pl_Main.BorderThickness = 5;
            this.pl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Main.Location = new System.Drawing.Point(0, 0);
            this.pl_Main.Name = "pl_Main";
            this.pl_Main.ShadowDecoration.Parent = this.pl_Main;
            this.pl_Main.Size = new System.Drawing.Size(353, 585);
            this.pl_Main.TabIndex = 35;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(353, 585);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.lb_TypeAccount);
            this.Controls.Add(this.cb_TypeAccount);
            this.Controls.Add(this.tb_DisplayName);
            this.Controls.Add(this.pb_DisplayName);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tb_RePassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.pb_RePassword);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_Username);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip tt_Username;
        private System.Windows.Forms.ToolTip tt_Password;
        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private System.Windows.Forms.TextBox tb_RePassword;
        private System.Windows.Forms.PictureBox pb_RePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tt_RePassword;
        private System.Windows.Forms.TextBox tb_DisplayName;
        private System.Windows.Forms.PictureBox pb_DisplayName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolTip tt_DisplayName;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TypeAccount;
        private Guna.UI.WinForms.GunaLabel lb_TypeAccount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private Guna.UI2.WinForms.Guna2Button btn_Create;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Panel pl_Main;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}