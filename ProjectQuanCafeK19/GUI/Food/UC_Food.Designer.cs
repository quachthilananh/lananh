namespace ProjectQuanCafeK19.GUI.Food
{
    partial class UC_Food
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.e_dgv_Food = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_Food = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Create = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.tb_SearchByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchByName = new Guna.UI2.WinForms.Guna2Button();
            this.cb_FoodCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_FoodCategory = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // e_dgv_Food
            // 
            this.e_dgv_Food.ElipseRadius = 20;
            this.e_dgv_Food.TargetControl = this.dgv_Food;
            // 
            // dgv_Food
            // 
            this.dgv_Food.AllowUserToAddRows = false;
            this.dgv_Food.AllowUserToDeleteRows = false;
            this.dgv_Food.AllowUserToResizeColumns = false;
            this.dgv_Food.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgv_Food.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Food.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Food.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Food.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Food.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_Food.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Food.ColumnHeadersHeight = 60;
            this.dgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Food.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Food.DoubleBuffered = true;
            this.dgv_Food.EnableHeadersVisualStyles = false;
            this.dgv_Food.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv_Food.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Food.Location = new System.Drawing.Point(15, 152);
            this.dgv_Food.MultiSelect = false;
            this.dgv_Food.Name = "dgv_Food";
            this.dgv_Food.ReadOnly = true;
            this.dgv_Food.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Food.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Food.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Food.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Food.RowTemplate.Height = 100;
            this.dgv_Food.RowTemplate.ReadOnly = true;
            this.dgv_Food.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Food.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Food.Size = new System.Drawing.Size(708, 490);
            this.dgv_Food.TabIndex = 38;
            this.dgv_Food.DoubleClick += new System.EventHandler(this.dgv_Food_DoubleClick);
            // 
            // btn_Create
            // 
            this.btn_Create.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Create.BorderRadius = 15;
            this.btn_Create.CheckedState.Parent = this.btn_Create;
            this.btn_Create.CustomImages.Parent = this.btn_Create;
            this.btn_Create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.HoverState.Parent = this.btn_Create;
            this.btn_Create.Image = global::ProjectQuanCafeK19.Properties.Resources.create_480px;
            this.btn_Create.Location = new System.Drawing.Point(587, 111);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.ShadowDecoration.Parent = this.btn_Create;
            this.btn_Create.Size = new System.Drawing.Size(133, 35);
            this.btn_Create.TabIndex = 40;
            this.btn_Create.Text = "Thêm mới";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
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
            this.btn_Refresh.Location = new System.Drawing.Point(587, 649);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(133, 45);
            this.btn_Refresh.TabIndex = 41;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_SearchByName
            // 
            this.tb_SearchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchByName.DefaultText = "Trà xoài";
            this.tb_SearchByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SearchByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SearchByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchByName.DisabledState.Parent = this.tb_SearchByName;
            this.tb_SearchByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SearchByName.FillColor = System.Drawing.Color.DimGray;
            this.tb_SearchByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchByName.FocusedState.Parent = this.tb_SearchByName;
            this.tb_SearchByName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchByName.ForeColor = System.Drawing.Color.White;
            this.tb_SearchByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SearchByName.HoverState.Parent = this.tb_SearchByName;
            this.tb_SearchByName.IconLeft = global::ProjectQuanCafeK19.Properties.Resources.search_512px;
            this.tb_SearchByName.Location = new System.Drawing.Point(22, 101);
            this.tb_SearchByName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_SearchByName.Name = "tb_SearchByName";
            this.tb_SearchByName.PasswordChar = '\0';
            this.tb_SearchByName.PlaceholderText = "";
            this.tb_SearchByName.SelectedText = "";
            this.tb_SearchByName.SelectionStart = 8;
            this.tb_SearchByName.ShadowDecoration.Parent = this.tb_SearchByName;
            this.tb_SearchByName.Size = new System.Drawing.Size(267, 45);
            this.tb_SearchByName.TabIndex = 43;
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SearchByName.CheckedState.Parent = this.btn_SearchByName;
            this.btn_SearchByName.CustomImages.Parent = this.btn_SearchByName;
            this.btn_SearchByName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_SearchByName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchByName.ForeColor = System.Drawing.Color.White;
            this.btn_SearchByName.HoverState.Parent = this.btn_SearchByName;
            this.btn_SearchByName.Location = new System.Drawing.Point(298, 101);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.ShadowDecoration.Parent = this.btn_SearchByName;
            this.btn_SearchByName.Size = new System.Drawing.Size(190, 45);
            this.btn_SearchByName.TabIndex = 42;
            this.btn_SearchByName.Text = "Tìm theo tên hiển thị";
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
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
            this.cb_FoodCategory.Location = new System.Drawing.Point(22, 56);
            this.cb_FoodCategory.Name = "cb_FoodCategory";
            this.cb_FoodCategory.ShadowDecoration.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Size = new System.Drawing.Size(267, 36);
            this.cb_FoodCategory.TabIndex = 62;
            this.cb_FoodCategory.SelectedIndexChanged += new System.EventHandler(this.cb_FoodCategory_SelectedIndexChanged);
            // 
            // lb_FoodCategory
            // 
            this.lb_FoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lb_FoodCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_FoodCategory.Location = new System.Drawing.Point(22, 20);
            this.lb_FoodCategory.Name = "lb_FoodCategory";
            this.lb_FoodCategory.Size = new System.Drawing.Size(267, 33);
            this.lb_FoodCategory.TabIndex = 64;
            this.lb_FoodCategory.Text = "Loại thực phẩm";
            this.lb_FoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lb_FoodCategory);
            this.Controls.Add(this.cb_FoodCategory);
            this.Controls.Add(this.tb_SearchByName);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.dgv_Food);
            this.Name = "UC_Food";
            this.Size = new System.Drawing.Size(737, 706);
            this.Load += new System.EventHandler(this.UC_Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse e_dgv_Food;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Food;
        private Guna.UI2.WinForms.Guna2Button btn_Create;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2TextBox tb_SearchByName;
        private Guna.UI2.WinForms.Guna2Button btn_SearchByName;
        private Guna.UI2.WinForms.Guna2ComboBox cb_FoodCategory;
        private Guna.UI.WinForms.GunaLabel lb_FoodCategory;
    }
}
