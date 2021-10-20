namespace ProjectQuanCafeK19.GUI.Account
{
    partial class FormEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditAccount));
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.tt_DisplayName = new System.Windows.Forms.ToolTip(this.components);
            this.tb_DisplayName = new System.Windows.Forms.TextBox();
            this.pb_DisplayName = new System.Windows.Forms.PictureBox();
            this.pb_DadDisplayName = new System.Windows.Forms.PictureBox();
            this.tt_RePassword = new System.Windows.Forms.ToolTip(this.components);
            this.tb_RePassword = new System.Windows.Forms.TextBox();
            this.pb_RePassword = new System.Windows.Forms.PictureBox();
            this.pb_DadRePassword = new System.Windows.Forms.PictureBox();
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tt_Password = new System.Windows.Forms.ToolTip(this.components);
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.pb_Password = new System.Windows.Forms.PictureBox();
            this.pb_DadPassword = new System.Windows.Forms.PictureBox();
            this.tt_Username = new System.Windows.Forms.ToolTip(this.components);
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pb_DadUsername = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.lb_TypeAccount = new Guna.UI.WinForms.GunaLabel();
            this.cb_TypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pl_Main = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadDisplayName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadRePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Avatar.Location = new System.Drawing.Point(95, 357);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Avatar.ShadowDecoration.Parent = this.pb_Avatar;
            this.pb_Avatar.Size = new System.Drawing.Size(167, 163);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 66;
            this.pb_Avatar.TabStop = false;
            this.tt_Avatar.SetToolTip(this.pb_Avatar, "Chọn ảnh đại diện");
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // of_Avatar
            // 
            this.of_Avatar.FileName = "of_Avatar";
            // 
            // tb_DisplayName
            // 
            this.tb_DisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DisplayName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DisplayName.ForeColor = System.Drawing.Color.Black;
            this.tb_DisplayName.Location = new System.Drawing.Point(86, 242);
            this.tb_DisplayName.Multiline = true;
            this.tb_DisplayName.Name = "tb_DisplayName";
            this.tb_DisplayName.Size = new System.Drawing.Size(230, 30);
            this.tb_DisplayName.TabIndex = 63;
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
            this.pb_DisplayName.Location = new System.Drawing.Point(42, 241);
            this.pb_DisplayName.Name = "pb_DisplayName";
            this.pb_DisplayName.Size = new System.Drawing.Size(37, 33);
            this.pb_DisplayName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DisplayName.TabIndex = 62;
            this.pb_DisplayName.TabStop = false;
            this.tt_DisplayName.SetToolTip(this.pb_DisplayName, "Tên hiển thị");
            // 
            // pb_DadDisplayName
            // 
            this.pb_DadDisplayName.Image = ((System.Drawing.Image)(resources.GetObject("pb_DadDisplayName.Image")));
            this.pb_DadDisplayName.Location = new System.Drawing.Point(26, 222);
            this.pb_DadDisplayName.Name = "pb_DadDisplayName";
            this.pb_DadDisplayName.Size = new System.Drawing.Size(304, 70);
            this.pb_DadDisplayName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DadDisplayName.TabIndex = 61;
            this.pb_DadDisplayName.TabStop = false;
            this.tt_DisplayName.SetToolTip(this.pb_DadDisplayName, "Tên hiển thị");
            // 
            // tb_RePassword
            // 
            this.tb_RePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_RePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RePassword.ForeColor = System.Drawing.Color.Black;
            this.tb_RePassword.Location = new System.Drawing.Point(86, 173);
            this.tb_RePassword.Multiline = true;
            this.tb_RePassword.Name = "tb_RePassword";
            this.tb_RePassword.PasswordChar = '*';
            this.tb_RePassword.Size = new System.Drawing.Size(230, 28);
            this.tb_RePassword.TabIndex = 58;
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
            this.pb_RePassword.Location = new System.Drawing.Point(42, 170);
            this.pb_RePassword.Name = "pb_RePassword";
            this.pb_RePassword.Size = new System.Drawing.Size(37, 33);
            this.pb_RePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_RePassword.TabIndex = 55;
            this.pb_RePassword.TabStop = false;
            this.tt_RePassword.SetToolTip(this.pb_RePassword, "Nhập lại mật khẩu");
            // 
            // pb_DadRePassword
            // 
            this.pb_DadRePassword.Image = ((System.Drawing.Image)(resources.GetObject("pb_DadRePassword.Image")));
            this.pb_DadRePassword.Location = new System.Drawing.Point(26, 152);
            this.pb_DadRePassword.Name = "pb_DadRePassword";
            this.pb_DadRePassword.Size = new System.Drawing.Size(304, 69);
            this.pb_DadRePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DadRePassword.TabIndex = 52;
            this.pb_DadRePassword.TabStop = false;
            this.tt_RePassword.SetToolTip(this.pb_DadRePassword, "Nhập lại mật khẩu");
            // 
            // e_FormCreateAccount
            // 
            this.e_FormCreateAccount.ElipseRadius = 0;
            this.e_FormCreateAccount.TargetControl = this;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.Black;
            this.tb_Password.Location = new System.Drawing.Point(86, 103);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(230, 28);
            this.tb_Password.TabIndex = 59;
            this.tb_Password.TabStop = false;
            this.tb_Password.Text = "Password";
            this.tt_Password.SetToolTip(this.tb_Password, "Nhập mật khẩu");
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // pb_Password
            // 
            this.pb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Password.Image = global::ProjectQuanCafeK19.Properties.Resources.password_480px;
            this.pb_Password.Location = new System.Drawing.Point(42, 100);
            this.pb_Password.Name = "pb_Password";
            this.pb_Password.Size = new System.Drawing.Size(37, 33);
            this.pb_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Password.TabIndex = 56;
            this.pb_Password.TabStop = false;
            this.tt_Password.SetToolTip(this.pb_Password, "Nhập mật khẩu");
            // 
            // pb_DadPassword
            // 
            this.pb_DadPassword.Image = ((System.Drawing.Image)(resources.GetObject("pb_DadPassword.Image")));
            this.pb_DadPassword.Location = new System.Drawing.Point(26, 82);
            this.pb_DadPassword.Name = "pb_DadPassword";
            this.pb_DadPassword.Size = new System.Drawing.Size(304, 69);
            this.pb_DadPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DadPassword.TabIndex = 53;
            this.pb_DadPassword.TabStop = false;
            this.tt_Password.SetToolTip(this.pb_DadPassword, "Nhập mật khẩu");
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.Black;
            this.tb_Username.Location = new System.Drawing.Point(86, 31);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(230, 30);
            this.tb_Username.TabIndex = 60;
            this.tb_Username.TabStop = false;
            this.tb_Username.Text = "Tên tài khoản";
            this.tt_Username.SetToolTip(this.tb_Username, "Tên tài khoản");
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // pb_Username
            // 
            this.pb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Username.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Username.Location = new System.Drawing.Point(42, 30);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(37, 33);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Username.TabIndex = 57;
            this.pb_Username.TabStop = false;
            this.tt_Username.SetToolTip(this.pb_Username, "Tên tài khoản");
            // 
            // pb_DadUsername
            // 
            this.pb_DadUsername.Image = ((System.Drawing.Image)(resources.GetObject("pb_DadUsername.Image")));
            this.pb_DadUsername.Location = new System.Drawing.Point(26, 11);
            this.pb_DadUsername.Name = "pb_DadUsername";
            this.pb_DadUsername.Size = new System.Drawing.Size(304, 70);
            this.pb_DadUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_DadUsername.TabIndex = 54;
            this.pb_DadUsername.TabStop = false;
            this.tt_Username.SetToolTip(this.pb_DadUsername, "Tên tài khoản");
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
            this.btn_Cancel.Location = new System.Drawing.Point(6, 540);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(84, 35);
            this.btn_Cancel.TabIndex = 51;
            this.btn_Cancel.Text = "Trở lại";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderRadius = 15;
            this.btn_Delete.CheckedState.Parent = this.btn_Delete;
            this.btn_Delete.CustomImages.Parent = this.btn_Delete;
            this.btn_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.HoverState.Parent = this.btn_Delete;
            this.btn_Delete.Image = global::ProjectQuanCafeK19.Properties.Resources.trash_480px;
            this.btn_Delete.Location = new System.Drawing.Point(252, 540);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(95, 35);
            this.btn_Delete.TabIndex = 50;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderRadius = 15;
            this.btn_Update.CheckedState.Parent = this.btn_Update;
            this.btn_Update.CustomImages.Parent = this.btn_Update;
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.Parent = this.btn_Update;
            this.btn_Update.Image = global::ProjectQuanCafeK19.Properties.Resources.add_480px;
            this.btn_Update.Location = new System.Drawing.Point(107, 540);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(129, 35);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_TypeAccount
            // 
            this.lb_TypeAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lb_TypeAccount.Location = new System.Drawing.Point(26, 308);
            this.lb_TypeAccount.Name = "lb_TypeAccount";
            this.lb_TypeAccount.Size = new System.Drawing.Size(148, 36);
            this.lb_TypeAccount.TabIndex = 65;
            this.lb_TypeAccount.Text = "Loại tài khoản:";
            this.lb_TypeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cb_TypeAccount.Location = new System.Drawing.Point(173, 308);
            this.cb_TypeAccount.Name = "cb_TypeAccount";
            this.cb_TypeAccount.ShadowDecoration.Parent = this.cb_TypeAccount;
            this.cb_TypeAccount.Size = new System.Drawing.Size(157, 36);
            this.cb_TypeAccount.TabIndex = 64;
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
            this.pl_Main.TabIndex = 67;
            // 
            // FormEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(353, 585);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.lb_TypeAccount);
            this.Controls.Add(this.cb_TypeAccount);
            this.Controls.Add(this.tb_DisplayName);
            this.Controls.Add(this.pb_DisplayName);
            this.Controls.Add(this.pb_DadDisplayName);
            this.Controls.Add(this.tb_RePassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.pb_RePassword);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pb_Password);
            this.Controls.Add(this.pb_DadRePassword);
            this.Controls.Add(this.pb_Username);
            this.Controls.Add(this.pb_DadPassword);
            this.Controls.Add(this.pb_DadUsername);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.pl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadDisplayName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadRePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DadUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private System.Windows.Forms.ToolTip tt_DisplayName;
        private System.Windows.Forms.ToolTip tt_RePassword;
        private System.Windows.Forms.ToolTip tt_Password;
        private System.Windows.Forms.ToolTip tt_Username;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private Guna.UI.WinForms.GunaLabel lb_TypeAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TypeAccount;
        private System.Windows.Forms.TextBox tb_DisplayName;
        private System.Windows.Forms.PictureBox pb_DisplayName;
        private System.Windows.Forms.PictureBox pb_DadDisplayName;
        private System.Windows.Forms.TextBox tb_RePassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.PictureBox pb_RePassword;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Password;
        private System.Windows.Forms.PictureBox pb_DadRePassword;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.PictureBox pb_DadPassword;
        private System.Windows.Forms.PictureBox pb_DadUsername;
        private Guna.UI2.WinForms.Guna2Panel pl_Main;
    }
}