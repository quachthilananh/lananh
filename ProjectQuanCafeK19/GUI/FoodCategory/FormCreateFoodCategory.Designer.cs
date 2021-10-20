namespace ProjectQuanCafeK19.GUI.FoodCategory
{
    partial class FormCreateFoodCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateFoodCategory));
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.pb_Name = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Create = new Guna.UI2.WinForms.Guna2Button();
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tt_Name = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
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
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.Silver;
            this.tb_Name.Location = new System.Drawing.Point(84, 29);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(230, 30);
            this.tb_Name.TabIndex = 54;
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
            this.pb_Name.Location = new System.Drawing.Point(40, 28);
            this.pb_Name.Name = "pb_Name";
            this.pb_Name.Size = new System.Drawing.Size(37, 33);
            this.pb_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Name.TabIndex = 53;
            this.pb_Name.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_Name, "Nhập tên loại");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
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
            this.btn_Cancel.Location = new System.Drawing.Point(29, 269);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(133, 35);
            this.btn_Cancel.TabIndex = 51;
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
            this.btn_Create.Location = new System.Drawing.Point(195, 269);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.ShadowDecoration.Parent = this.btn_Create;
            this.btn_Create.Size = new System.Drawing.Size(133, 35);
            this.btn_Create.TabIndex = 50;
            this.btn_Create.Text = "Thêm mới";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Avatar.Location = new System.Drawing.Point(93, 85);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Avatar.ShadowDecoration.Parent = this.pb_Avatar;
            this.pb_Avatar.Size = new System.Drawing.Size(167, 163);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 49;
            this.pb_Avatar.TabStop = false;
            this.tt_Avatar.SetToolTip(this.pb_Avatar, "Chọn ảnh minh hoạ");
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // FormCreateFoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(353, 326);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.pb_Name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateFoodCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreateFoodCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Create;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.PictureBox pb_Name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip tt_Name;
    }
}