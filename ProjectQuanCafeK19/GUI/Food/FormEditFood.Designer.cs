namespace ProjectQuanCafeK19.GUI.Food
{
    partial class FormEditFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditFood));
            this.lb_Count = new Guna.UI.WinForms.GunaLabel();
            this.lb_Price = new Guna.UI.WinForms.GunaLabel();
            this.lb_Cost = new Guna.UI.WinForms.GunaLabel();
            this.lb_FoodCategory = new Guna.UI.WinForms.GunaLabel();
            this.cb_FoodCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nud_Count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.nud_Cost = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nud_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tt_Name = new System.Windows.Forms.ToolTip(this.components);
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.pb_ID = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_Name = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Count
            // 
            this.lb_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Count.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Count.Location = new System.Drawing.Point(19, 332);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(113, 36);
            this.lb_Count.TabIndex = 77;
            this.lb_Count.Text = "Số lượng";
            this.lb_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Price
            // 
            this.lb_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Price.Location = new System.Drawing.Point(19, 290);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(113, 36);
            this.lb_Price.TabIndex = 76;
            this.lb_Price.Text = "Giá bán ra";
            this.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cost
            // 
            this.lb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Cost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cost.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Cost.Location = new System.Drawing.Point(19, 248);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(113, 36);
            this.lb_Cost.TabIndex = 75;
            this.lb_Cost.Text = "Giá vốn";
            this.lb_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FoodCategory
            // 
            this.lb_FoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lb_FoodCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_FoodCategory.Location = new System.Drawing.Point(19, 161);
            this.lb_FoodCategory.Name = "lb_FoodCategory";
            this.lb_FoodCategory.Size = new System.Drawing.Size(302, 33);
            this.lb_FoodCategory.TabIndex = 74;
            this.lb_FoodCategory.Text = "Loại thực phẩm";
            this.lb_FoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_FoodCategory
            // 
            this.cb_FoodCategory.BackColor = System.Drawing.Color.Transparent;
            this.cb_FoodCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_FoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FoodCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cb_FoodCategory.FocusedState.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_FoodCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_FoodCategory.FormattingEnabled = true;
            this.cb_FoodCategory.HoverState.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.ItemHeight = 30;
            this.cb_FoodCategory.ItemsAppearance.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Location = new System.Drawing.Point(17, 200);
            this.cb_FoodCategory.Name = "cb_FoodCategory";
            this.cb_FoodCategory.ShadowDecoration.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Size = new System.Drawing.Size(304, 36);
            this.cb_FoodCategory.TabIndex = 70;
            // 
            // nud_Count
            // 
            this.nud_Count.BackColor = System.Drawing.Color.Transparent;
            this.nud_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_Count.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nud_Count.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nud_Count.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nud_Count.DisabledState.Parent = this.nud_Count;
            this.nud_Count.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nud_Count.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nud_Count.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nud_Count.FocusedState.Parent = this.nud_Count;
            this.nud_Count.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Count.ForeColor = System.Drawing.Color.Black;
            this.nud_Count.Location = new System.Drawing.Point(138, 332);
            this.nud_Count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Count.Name = "nud_Count";
            this.nud_Count.ShadowDecoration.Parent = this.nud_Count;
            this.nud_Count.Size = new System.Drawing.Size(183, 36);
            this.nud_Count.TabIndex = 72;
            this.nud_Count.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nud_Count.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.Black;
            this.tb_Name.Location = new System.Drawing.Point(77, 94);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(230, 30);
            this.tb_Name.TabIndex = 69;
            this.tb_Name.TabStop = false;
            this.tb_Name.Text = "Tên thực phẩm";
            this.tt_Name.SetToolTip(this.tb_Name, "Nhập tên thực phẩm");
            this.tb_Name.Enter += new System.EventHandler(this.tb_Name_Enter);
            this.tb_Name.Leave += new System.EventHandler(this.tb_Name_Leave);
            // 
            // nud_Cost
            // 
            this.nud_Cost.BackColor = System.Drawing.Color.Transparent;
            this.nud_Cost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nud_Cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_Cost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nud_Cost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nud_Cost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nud_Cost.DisabledState.Parent = this.nud_Cost;
            this.nud_Cost.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nud_Cost.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nud_Cost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nud_Cost.FocusedState.Parent = this.nud_Cost;
            this.nud_Cost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Cost.ForeColor = System.Drawing.Color.Black;
            this.nud_Cost.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_Cost.Location = new System.Drawing.Point(138, 248);
            this.nud_Cost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Cost.Name = "nud_Cost";
            this.nud_Cost.ShadowDecoration.Parent = this.nud_Cost;
            this.nud_Cost.Size = new System.Drawing.Size(183, 36);
            this.nud_Cost.TabIndex = 73;
            this.nud_Cost.ThousandsSeparator = true;
            this.nud_Cost.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nud_Cost.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // nud_Price
            // 
            this.nud_Price.BackColor = System.Drawing.Color.Transparent;
            this.nud_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nud_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nud_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nud_Price.DisabledState.Parent = this.nud_Price;
            this.nud_Price.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nud_Price.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nud_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nud_Price.FocusedState.Parent = this.nud_Price;
            this.nud_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Price.ForeColor = System.Drawing.Color.Black;
            this.nud_Price.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_Price.Location = new System.Drawing.Point(138, 290);
            this.nud_Price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Price.Name = "nud_Price";
            this.nud_Price.ShadowDecoration.Parent = this.nud_Price;
            this.nud_Price.Size = new System.Drawing.Size(183, 36);
            this.nud_Price.TabIndex = 71;
            this.nud_Price.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nud_Price.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.ForeColor = System.Drawing.Color.Black;
            this.tb_ID.Location = new System.Drawing.Point(77, 24);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(230, 30);
            this.tb_ID.TabIndex = 80;
            this.tb_ID.TabStop = false;
            this.tb_ID.Text = "1";
            this.tt_Name.SetToolTip(this.tb_ID, "Nhập tên thực phẩm");
            // 
            // pb_ID
            // 
            this.pb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_ID.Image = global::ProjectQuanCafeK19.Properties.Resources.key_480px;
            this.pb_ID.Location = new System.Drawing.Point(33, 23);
            this.pb_ID.Name = "pb_ID";
            this.pb_ID.Size = new System.Drawing.Size(37, 33);
            this.pb_ID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ID.TabIndex = 79;
            this.pb_ID.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_ID, "Nhập tên thực phẩm");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            this.tt_Name.SetToolTip(this.pictureBox3, "Nhập tên thực phẩm");
            // 
            // pb_Name
            // 
            this.pb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Name.Image = global::ProjectQuanCafeK19.Properties.Resources.food_and_wine_480px;
            this.pb_Name.Location = new System.Drawing.Point(33, 93);
            this.pb_Name.Name = "pb_Name";
            this.pb_Name.Size = new System.Drawing.Size(37, 33);
            this.pb_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Name.TabIndex = 68;
            this.pb_Name.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_Name, "Nhập tên thực phẩm");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.tt_Name.SetToolTip(this.pictureBox2, "Nhập tên thực phẩm");
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Avatar.Location = new System.Drawing.Point(86, 380);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pb_Avatar.ShadowDecoration.Parent = this.pb_Avatar;
            this.pb_Avatar.Size = new System.Drawing.Size(167, 163);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 64;
            this.pb_Avatar.TabStop = false;
            this.tt_Avatar.SetToolTip(this.pb_Avatar, "Chọn ảnh minh hoạ");
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // of_Avatar
            // 
            this.of_Avatar.FileName = "of_Avatar";
            // 
            // e_FormCreateAccount
            // 
            this.e_FormCreateAccount.ElipseRadius = 20;
            this.e_FormCreateAccount.TargetControl = this;
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
            this.btn_Cancel.Location = new System.Drawing.Point(12, 549);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(84, 35);
            this.btn_Cancel.TabIndex = 83;
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
            this.btn_Delete.Location = new System.Drawing.Point(237, 549);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.Parent = this.btn_Delete;
            this.btn_Delete.Size = new System.Drawing.Size(95, 35);
            this.btn_Delete.TabIndex = 81;
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
            this.btn_Update.Location = new System.Drawing.Point(102, 549);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(129, 35);
            this.btn_Update.TabIndex = 82;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // FormEditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(340, 598);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.pb_ID);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_Cost);
            this.Controls.Add(this.lb_FoodCategory);
            this.Controls.Add(this.cb_FoodCategory);
            this.Controls.Add(this.nud_Count);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.nud_Cost);
            this.Controls.Add(this.nud_Price);
            this.Controls.Add(this.pb_Name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditFood";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lb_Count;
        private Guna.UI.WinForms.GunaLabel lb_Price;
        private Guna.UI.WinForms.GunaLabel lb_Cost;
        private Guna.UI.WinForms.GunaLabel lb_FoodCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cb_FoodCategory;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Count;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ToolTip tt_Name;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Cost;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Price;
        private System.Windows.Forms.PictureBox pb_Name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.PictureBox pb_ID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
    }
}