namespace ProjectQuanCafeK19.GUI.FoodCategory
{
    partial class UC_FoodCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.e_dgv_FoodCategory = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_FoodCategory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_CreateFoodCategory = new Guna.UI2.WinForms.Guna2Button();
            this.tb_SearchByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_SearchByName = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // e_dgv_FoodCategory
            // 
            this.e_dgv_FoodCategory.ElipseRadius = 20;
            this.e_dgv_FoodCategory.TargetControl = this.dgv_FoodCategory;
            // 
            // dgv_FoodCategory
            // 
            this.dgv_FoodCategory.AllowUserToAddRows = false;
            this.dgv_FoodCategory.AllowUserToDeleteRows = false;
            this.dgv_FoodCategory.AllowUserToResizeColumns = false;
            this.dgv_FoodCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_FoodCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FoodCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FoodCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_FoodCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_FoodCategory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_FoodCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_FoodCategory.ColumnHeadersHeight = 60;
            this.dgv_FoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_FoodCategory.DoubleBuffered = true;
            this.dgv_FoodCategory.EnableHeadersVisualStyles = false;
            this.dgv_FoodCategory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv_FoodCategory.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_FoodCategory.Location = new System.Drawing.Point(15, 152);
            this.dgv_FoodCategory.MultiSelect = false;
            this.dgv_FoodCategory.Name = "dgv_FoodCategory";
            this.dgv_FoodCategory.ReadOnly = true;
            this.dgv_FoodCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_FoodCategory.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_FoodCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_FoodCategory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodCategory.RowTemplate.Height = 100;
            this.dgv_FoodCategory.RowTemplate.ReadOnly = true;
            this.dgv_FoodCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FoodCategory.Size = new System.Drawing.Size(708, 490);
            this.dgv_FoodCategory.TabIndex = 34;
            this.dgv_FoodCategory.DoubleClick += new System.EventHandler(this.dgv_FoodCategory_DoubleClick);
            // 
            // btn_CreateFoodCategory
            // 
            this.btn_CreateFoodCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CreateFoodCategory.BorderRadius = 15;
            this.btn_CreateFoodCategory.CheckedState.Parent = this.btn_CreateFoodCategory;
            this.btn_CreateFoodCategory.CustomImages.Parent = this.btn_CreateFoodCategory;
            this.btn_CreateFoodCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_CreateFoodCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateFoodCategory.ForeColor = System.Drawing.Color.White;
            this.btn_CreateFoodCategory.HoverState.Parent = this.btn_CreateFoodCategory;
            this.btn_CreateFoodCategory.Image = global::ProjectQuanCafeK19.Properties.Resources.create_480px;
            this.btn_CreateFoodCategory.Location = new System.Drawing.Point(587, 111);
            this.btn_CreateFoodCategory.Name = "btn_CreateFoodCategory";
            this.btn_CreateFoodCategory.ShadowDecoration.Parent = this.btn_CreateFoodCategory;
            this.btn_CreateFoodCategory.Size = new System.Drawing.Size(133, 35);
            this.btn_CreateFoodCategory.TabIndex = 36;
            this.btn_CreateFoodCategory.Text = "Thêm mới";
            this.btn_CreateFoodCategory.Click += new System.EventHandler(this.btn_CreateFoodCategory_Click);
            // 
            // tb_SearchByName
            // 
            this.tb_SearchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchByName.DefaultText = "Trà trái cây";
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
            this.tb_SearchByName.Location = new System.Drawing.Point(28, 101);
            this.tb_SearchByName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_SearchByName.Name = "tb_SearchByName";
            this.tb_SearchByName.PasswordChar = '\0';
            this.tb_SearchByName.PlaceholderText = "";
            this.tb_SearchByName.SelectedText = "";
            this.tb_SearchByName.ShadowDecoration.Parent = this.tb_SearchByName;
            this.tb_SearchByName.Size = new System.Drawing.Size(267, 45);
            this.tb_SearchByName.TabIndex = 38;
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
            this.btn_SearchByName.Location = new System.Drawing.Point(304, 101);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.ShadowDecoration.Parent = this.btn_SearchByName;
            this.btn_SearchByName.Size = new System.Drawing.Size(190, 45);
            this.btn_SearchByName.TabIndex = 37;
            this.btn_SearchByName.Text = "Tìm theo tên hiển thị";
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
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
            this.btn_Refresh.Location = new System.Drawing.Point(587, 651);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(133, 45);
            this.btn_Refresh.TabIndex = 39;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // UC_FoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_SearchByName);
            this.Controls.Add(this.btn_SearchByName);
            this.Controls.Add(this.btn_CreateFoodCategory);
            this.Controls.Add(this.dgv_FoodCategory);
            this.Name = "UC_FoodCategory";
            this.Size = new System.Drawing.Size(737, 706);
            this.Load += new System.EventHandler(this.UC_FoodCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse e_dgv_FoodCategory;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_FoodCategory;
        private Guna.UI2.WinForms.Guna2Button btn_CreateFoodCategory;
        private Guna.UI2.WinForms.Guna2TextBox tb_SearchByName;
        private Guna.UI2.WinForms.Guna2Button btn_SearchByName;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
    }
}
