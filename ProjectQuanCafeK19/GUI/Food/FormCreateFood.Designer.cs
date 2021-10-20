namespace ProjectQuanCafeK19.GUI.Food
{
    partial class FormCreateFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateFood));
            this.e_FormCreateAccount = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.of_Avatar = new System.Windows.Forms.OpenFileDialog();
            this.tt_Avatar = new System.Windows.Forms.ToolTip(this.components);
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tt_Name = new System.Windows.Forms.ToolTip(this.components);
            this.cb_FoodCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nud_Cost = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nud_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nud_Count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lb_FoodCategory = new Guna.UI.WinForms.GunaLabel();
            this.lb_Cost = new Guna.UI.WinForms.GunaLabel();
            this.lb_Price = new Guna.UI.WinForms.GunaLabel();
            this.lb_Count = new Guna.UI.WinForms.GunaLabel();
            this.pb_Name = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Create = new Guna.UI2.WinForms.Guna2Button();
            this.pb_Avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).BeginInit();
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
            this.tb_Name.Location = new System.Drawing.Point(77, 25);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(230, 30);
            this.tb_Name.TabIndex = 60;
            this.tb_Name.TabStop = false;
            this.tb_Name.Text = "Tên thực phẩm";
            this.tt_Name.SetToolTip(this.tb_Name, "Nhập tên thực phẩm");
            this.tb_Name.Enter += new System.EventHandler(this.tb_Name_Enter);
            this.tb_Name.Leave += new System.EventHandler(this.tb_Name_Leave);
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
            this.cb_FoodCategory.Location = new System.Drawing.Point(17, 131);
            this.cb_FoodCategory.Name = "cb_FoodCategory";
            this.cb_FoodCategory.ShadowDecoration.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Size = new System.Drawing.Size(304, 36);
            this.cb_FoodCategory.TabIndex = 61;
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
            this.nud_Cost.Location = new System.Drawing.Point(138, 179);
            this.nud_Cost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Cost.Name = "nud_Cost";
            this.nud_Cost.ShadowDecoration.Parent = this.nud_Cost;
            this.nud_Cost.Size = new System.Drawing.Size(183, 36);
            this.nud_Cost.TabIndex = 62;
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
            this.nud_Price.Location = new System.Drawing.Point(138, 221);
            this.nud_Price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Price.Name = "nud_Price";
            this.nud_Price.ShadowDecoration.Parent = this.nud_Price;
            this.nud_Price.Size = new System.Drawing.Size(183, 36);
            this.nud_Price.TabIndex = 62;
            this.nud_Price.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nud_Price.UpDownButtonForeColor = System.Drawing.Color.White;
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
            this.nud_Count.Location = new System.Drawing.Point(138, 263);
            this.nud_Count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Count.Name = "nud_Count";
            this.nud_Count.ShadowDecoration.Parent = this.nud_Count;
            this.nud_Count.Size = new System.Drawing.Size(183, 36);
            this.nud_Count.TabIndex = 62;
            this.nud_Count.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.nud_Count.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // lb_FoodCategory
            // 
            this.lb_FoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lb_FoodCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_FoodCategory.Location = new System.Drawing.Point(19, 92);
            this.lb_FoodCategory.Name = "lb_FoodCategory";
            this.lb_FoodCategory.Size = new System.Drawing.Size(302, 33);
            this.lb_FoodCategory.TabIndex = 63;
            this.lb_FoodCategory.Text = "Loại thực phẩm";
            this.lb_FoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cost
            // 
            this.lb_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Cost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cost.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Cost.Location = new System.Drawing.Point(19, 179);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(113, 36);
            this.lb_Cost.TabIndex = 63;
            this.lb_Cost.Text = "Giá vốn";
            this.lb_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Price
            // 
            this.lb_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Price.Location = new System.Drawing.Point(19, 221);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(113, 36);
            this.lb_Price.TabIndex = 63;
            this.lb_Price.Text = "Giá bán ra";
            this.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Count
            // 
            this.lb_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.lb_Count.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Count.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Count.Location = new System.Drawing.Point(19, 263);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(113, 36);
            this.lb_Count.TabIndex = 63;
            this.lb_Count.Text = "Số lượng";
            this.lb_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Name
            // 
            this.pb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.pb_Name.Image = global::ProjectQuanCafeK19.Properties.Resources.food_and_wine_480px;
            this.pb_Name.Location = new System.Drawing.Point(33, 24);
            this.pb_Name.Name = "pb_Name";
            this.pb_Name.Size = new System.Drawing.Size(37, 33);
            this.pb_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Name.TabIndex = 59;
            this.pb_Name.TabStop = false;
            this.tt_Name.SetToolTip(this.pb_Name, "Nhập tên thực phẩm");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.tt_Name.SetToolTip(this.pictureBox2, "Nhập tên thực phẩm");
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
            this.btn_Cancel.Location = new System.Drawing.Point(20, 487);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.Parent = this.btn_Cancel;
            this.btn_Cancel.Size = new System.Drawing.Size(133, 35);
            this.btn_Cancel.TabIndex = 57;
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
            this.btn_Create.Location = new System.Drawing.Point(186, 487);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.ShadowDecoration.Parent = this.btn_Create;
            this.btn_Create.Size = new System.Drawing.Size(133, 35);
            this.btn_Create.TabIndex = 56;
            this.btn_Create.Text = "Thêm mới";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Avatar.Image = global::ProjectQuanCafeK19.Properties.Resources.user_480px;
            this.pb_Avatar.Location = new System.Drawing.Point(86, 311);
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
            // FormCreateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(340, 537);
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
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreateFood";
            this.Load += new System.EventHandler(this.FormCreateFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse e_FormCreateAccount;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ToolTip tt_Name;
        private System.Windows.Forms.PictureBox pb_Name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Create;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pb_Avatar;
        private System.Windows.Forms.ToolTip tt_Avatar;
        private System.Windows.Forms.OpenFileDialog of_Avatar;
        private Guna.UI2.WinForms.Guna2ComboBox cb_FoodCategory;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Price;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Cost;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Count;
        private Guna.UI.WinForms.GunaLabel lb_FoodCategory;
        private Guna.UI.WinForms.GunaLabel lb_Cost;
        private Guna.UI.WinForms.GunaLabel lb_Count;
        private Guna.UI.WinForms.GunaLabel lb_Price;
    }
}