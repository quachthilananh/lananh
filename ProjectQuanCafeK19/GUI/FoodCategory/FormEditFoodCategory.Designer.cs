namespace ProjectQuanCafeK19.GUI.FoodCategory
{
    partial class FormEditFoodCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditFoodCategory));
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tt_Name = new System.Windows.Forms.ToolTip(this.components);
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.pb_Name = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_ID = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // e_FormCreateAccount
            // 
            this.e_FormCreateAccount.ElipseRadius = 20;
            this.e_FormCreateAccount.TargetControl = this;
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
            this.pb_Avatar.Location = new System.Drawing.Point(93, 164);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Avatar.ShadowDecoration.Parent = this.pb_Avatar;
            this.pb_Avatar.Size = new System.Drawing.Size(167, 163);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 55;
            this.pb_Avatar.TabStop = false;
            this.tt_Avatar.SetToolTip(this.pb_Avatar, "Chọn ảnh minh hoạ");
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.ForeColor = System.Drawing.Color.Black;
            this.tb_ID.Location = new System.Drawing.Point(83, 32);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(230, 30);
            this.tb_ID.TabIndex = 60;
            this.tb_ID.TabStop = false;
            this.tb_ID.Text = "Mã loại";
            this.tt_Name.SetToolTip(this.tb_ID, "Nhập tên loại");
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.Black;
            this.tb_Name.Location = new System.Drawing.Point(83, 108);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(230, 30);
            this.tb_Name.TabIndex = 66;
            this.tb_Name.TabStop = false;
            this.tb_Name.Text = "Tên loại";
            this.tt_Name.SetToolTip(this.tb_Name, "Nhập tên loại");
            this.tb_Name.Enter += new System.EventHandler(this.tb_Name_Enter);
            this.tb_Name.Leave += new System.EventHandler(this.tb_Name_Leave);
            // 
            // pb_Name
            // 
            this.pb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Name.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Name.Location = new System.Drawing.Point(39, 107);
            this.pb_Name.Name = "pb_Name";
            this.pb_Name.Size = new System.Drawing.Size(37, 33);
            this.pb_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Name.TabIndex = 65;
            this.pb_Name.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_Name, "Nhập tên loại");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            this.tt_Name.SetToolTip(this.pictureBox3, "Nhập tên loại");
            // 
            // pb_ID
            // 
            this.pb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_ID.Image = global::ProjectQuanCafeK19.Properties.Resources.key_480px;
            this.pb_ID.Location = new System.Drawing.Point(39, 31);
            this.pb_ID.Name = "pb_ID";
            this.pb_ID.Size = new System.Drawing.Size(37, 33);
            this.pb_ID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ID.TabIndex = 59;
            this.pb_ID.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_ID, "Nhập tên loại");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.tt_Name.SetToolTip(this.pictureBox2, "Nhập tên loại");
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
            this.btn_Cancel.Location = new System.Drawing.Point(14, 333);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(84, 35);
            this.btn_Cancel.TabIndex = 63;
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
            this.btn_Delete.Location = new System.Drawing.Point(239, 333);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(95, 35);
            this.btn_Delete.TabIndex = 61;
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
            this.btn_Update.Location = new System.Drawing.Point(104, 333);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(129, 35);
            this.btn_Update.TabIndex = 62;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // FormEditFoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(353, 377);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.pb_Name);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.pb_ID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditFoodCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditFoodCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.ToolTip tt_Name;
        private System.Windows.Forms.PictureBox pb_ID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.PictureBox pb_Name;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}