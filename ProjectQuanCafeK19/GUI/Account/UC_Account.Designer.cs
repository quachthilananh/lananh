namespace ProjectQuanCafeK19
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Account = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.e_dgv_Account = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_CreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.tb_SearchDisplayName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchDisplayName = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SearchUsername = new Guna.UI2.WinForms.Guna2Button();
            this.tb_SearchUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Account
            // 
            this.dgv_Account.AllowUserToAddRows = false;
            this.dgv_Account.AllowUserToDeleteRows = false;
            this.dgv_Account.AllowUserToResizeColumns = false;
            this.dgv_Account.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Account.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Account.ColumnHeadersHeight = 60;
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Account.DoubleBuffered = true;
            this.dgv_Account.EnableHeadersVisualStyles = false;
            this.dgv_Account.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv_Account.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Account.Location = new System.Drawing.Point(15, 152);
            this.dgv_Account.MultiSelect = false;
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            this.dgv_Account.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Account.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Account.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Account.RowTemplate.Height = 50;
            this.dgv_Account.RowTemplate.ReadOnly = true;
            this.dgv_Account.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account.Size = new System.Drawing.Size(708, 490);
            this.dgv_Account.TabIndex = 32;
            this.dgv_Account.DoubleClick += new System.EventHandler(this.dgv_Account_DoubleClick);
            // 
            // e_dgv_Account
            // 
            this.e_dgv_Account.ElipseRadius = 20;
            this.e_dgv_Account.TargetControl = this.dgv_Account;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccount.BorderRadius = 15;
            this.btn_CreateAccount.CheckedState.Parent = this.btn_CreateAccount;
            this.btn_CreateAccount.CustomImages.Parent = this.btn_CreateAccount;
            this.btn_CreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_CreateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAccount.ForeColor = System.Drawing.Color.White;
            this.btn_CreateAccount.HoverState.Parent = this.btn_CreateAccount;
            this.btn_CreateAccount.Image = global::ProjectQuanCafeK19.Properties.Resources.create_480px;
            this.btn_CreateAccount.Location = new System.Drawing.Point(590, 100);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.ShadowDecoration.Parent = this.btn_CreateAccount;
            this.btn_CreateAccount.Size = new System.Drawing.Size(133, 45);
            this.btn_CreateAccount.TabIndex = 33;
            this.btn_CreateAccount.Text = "Thêm mới";
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // tb_SearchDisplayName
            // 
            this.tb_SearchDisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchDisplayName.DefaultText = "Nguyễn Văn A";
            this.tb_SearchDisplayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SearchDisplayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SearchDisplayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchDisplayName.DisabledState.Parent = this.tb_SearchDisplayName;
            this.tb_SearchDisplayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchDisplayName.FillColor = System.Drawing.Color.DimGray;
            this.tb_SearchDisplayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchDisplayName.FocusedState.Parent = this.tb_SearchDisplayName;
            this.tb_SearchDisplayName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchDisplayName.ForeColor = System.Drawing.Color.White;
            this.tb_SearchDisplayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchDisplayName.HoverState.Parent = this.tb_SearchDisplayName;
            this.tb_SearchDisplayName.IconLeft = global::ProjectQuanCafeK19.Properties.Resources.search_512px;
            this.tb_SearchDisplayName.Location = new System.Drawing.Point(29, 98);
            this.tb_SearchDisplayName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_SearchDisplayName.Name = "tb_SearchDisplayName";
            this.tb_SearchDisplayName.PasswordChar = '\0';
            this.tb_SearchDisplayName.PlaceholderText = "";
            this.tb_SearchDisplayName.SelectedText = "";
            this.tb_SearchDisplayName.ShadowDecoration.Parent = this.tb_SearchDisplayName;
            this.tb_SearchDisplayName.Size = new System.Drawing.Size(267, 45);
            this.tb_SearchDisplayName.TabIndex = 34;
            // 
            // btn_SearchDisplayName
            // 
            this.btn_SearchDisplayName.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SearchDisplayName.CheckedState.Parent = this.btn_SearchDisplayName;
            this.btn_SearchDisplayName.CustomImages.Parent = this.btn_SearchDisplayName;
            this.btn_SearchDisplayName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_SearchDisplayName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchDisplayName.ForeColor = System.Drawing.Color.White;
            this.btn_SearchDisplayName.HoverState.Parent = this.btn_SearchDisplayName;
            this.btn_SearchDisplayName.Location = new System.Drawing.Point(305, 98);
            this.btn_SearchDisplayName.Name = "btn_SearchDisplayName";
            this.btn_SearchDisplayName.ShadowDecoration.Parent = this.btn_SearchDisplayName;
            this.btn_SearchDisplayName.Size = new System.Drawing.Size(190, 45);
            this.btn_SearchDisplayName.TabIndex = 33;
            this.btn_SearchDisplayName.Text = "Tìm theo tên hiển thị";
            this.btn_SearchDisplayName.Click += new System.EventHandler(this.btn_SearchDisplayName_Click);
            // 
            // btn_SearchUsername
            // 
            this.btn_SearchUsername.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SearchUsername.CheckedState.Parent = this.btn_SearchUsername;
            this.btn_SearchUsername.CustomImages.Parent = this.btn_SearchUsername;
            this.btn_SearchUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_SearchUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchUsername.ForeColor = System.Drawing.Color.White;
            this.btn_SearchUsername.HoverState.Parent = this.btn_SearchUsername;
            this.btn_SearchUsername.Location = new System.Drawing.Point(305, 41);
            this.btn_SearchUsername.Name = "btn_SearchUsername";
            this.btn_SearchUsername.ShadowDecoration.Parent = this.btn_SearchUsername;
            this.btn_SearchUsername.Size = new System.Drawing.Size(190, 45);
            this.btn_SearchUsername.TabIndex = 33;
            this.btn_SearchUsername.Text = "Tìm theo tên người dùng";
            this.btn_SearchUsername.Click += new System.EventHandler(this.btn_SearchUsername_Click);
            // 
            // tb_SearchUsername
            // 
            this.tb_SearchUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchUsername.DefaultText = "nguyenvana";
            this.tb_SearchUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SearchUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SearchUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchUsername.DisabledState.Parent = this.tb_SearchUsername;
            this.tb_SearchUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchUsername.FillColor = System.Drawing.Color.DimGray;
            this.tb_SearchUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchUsername.FocusedState.Parent = this.tb_SearchUsername;
            this.tb_SearchUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchUsername.ForeColor = System.Drawing.Color.White;
            this.tb_SearchUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchUsername.HoverState.Parent = this.tb_SearchUsername;
            this.tb_SearchUsername.IconLeft = global::ProjectQuanCafeK19.Properties.Resources.search_512px;
            this.tb_SearchUsername.Location = new System.Drawing.Point(29, 41);
            this.tb_SearchUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_SearchUsername.Name = "tb_SearchUsername";
            this.tb_SearchUsername.PasswordChar = '\0';
            this.tb_SearchUsername.PlaceholderText = "";
            this.tb_SearchUsername.SelectedText = "";
            this.tb_SearchUsername.ShadowDecoration.Parent = this.tb_SearchUsername;
            this.tb_SearchUsername.Size = new System.Drawing.Size(267, 45);
            this.tb_SearchUsername.TabIndex = 34;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderRadius = 15;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoverState.Parent = this.btn_Refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(590, 653);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(133, 45);
            this.btn_Refresh.TabIndex = 33;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tb_SearchUsername);
            this.Controls.Add(this.btn_SearchUsername);
            this.Controls.Add(this.tb_SearchDisplayName);
            this.Controls.Add(this.btn_SearchDisplayName);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.dgv_Account);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(737, 706);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Account;
        private Bunifu.Framework.UI.BunifuElipse e_dgv_Account;
        private Guna.UI2.WinForms.Guna2Button btn_CreateAccount;
        private Guna.UI2.WinForms.Guna2TextBox tb_SearchDisplayName;
        private Guna.UI2.WinForms.Guna2Button btn_SearchDisplayName;
        private Guna.UI2.WinForms.Guna2Button btn_SearchUsername;
        private Guna.UI2.WinForms.Guna2TextBox tb_SearchUsername;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
    }
}
