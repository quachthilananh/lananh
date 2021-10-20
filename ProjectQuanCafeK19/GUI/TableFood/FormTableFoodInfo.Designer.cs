namespace ProjectQuanCafeK19.GUI.TableFood
{
    partial class FormTableFoodInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_FoodCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Food = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nud_Count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pl_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_TableFoodInfo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tb_TotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_CheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.bt_AddFood = new Guna.UI2.WinForms.Guna2Button();
            this.lb_Discount = new Guna.UI.WinForms.GunaLabel();
            this.lb_Count = new Guna.UI.WinForms.GunaLabel();
            this.lb_Food = new Guna.UI.WinForms.GunaLabel();
            this.lb_FoodCategory = new Guna.UI.WinForms.GunaLabel();
            this.nud_Discount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).BeginInit();
            this.pl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableFoodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount)).BeginInit();
            this.SuspendLayout();
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
            this.cb_FoodCategory.Location = new System.Drawing.Point(492, 55);
            this.cb_FoodCategory.Name = "cb_FoodCategory";
            this.cb_FoodCategory.ShadowDecoration.Parent = this.cb_FoodCategory;
            this.cb_FoodCategory.Size = new System.Drawing.Size(302, 36);
            this.cb_FoodCategory.TabIndex = 0;
            this.cb_FoodCategory.SelectedIndexChanged += new System.EventHandler(this.cb_FoodCategory_SelectedIndexChanged);
            // 
            // cb_Food
            // 
            this.cb_Food.BackColor = System.Drawing.Color.Transparent;
            this.cb_Food.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Food.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Food.FocusedState.Parent = this.cb_Food;
            this.cb_Food.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.HoverState.Parent = this.cb_Food;
            this.cb_Food.ItemHeight = 30;
            this.cb_Food.ItemsAppearance.Parent = this.cb_Food;
            this.cb_Food.Location = new System.Drawing.Point(492, 140);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.ShadowDecoration.Parent = this.cb_Food;
            this.cb_Food.Size = new System.Drawing.Size(302, 36);
            this.cb_Food.TabIndex = 0;
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
            this.nud_Count.FillColor = System.Drawing.Color.LightSkyBlue;
            this.nud_Count.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nud_Count.FocusedState.Parent = this.nud_Count;
            this.nud_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Count.ForeColor = System.Drawing.Color.White;
            this.nud_Count.Location = new System.Drawing.Point(651, 182);
            this.nud_Count.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nud_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Count.Name = "nud_Count";
            this.nud_Count.ShadowDecoration.Parent = this.nud_Count;
            this.nud_Count.Size = new System.Drawing.Size(143, 36);
            this.nud_Count.TabIndex = 1;
            this.nud_Count.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nud_Count.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.nud_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pl_Main
            // 
            this.pl_Main.BorderColor = System.Drawing.Color.DimGray;
            this.pl_Main.BorderThickness = 5;
            this.pl_Main.Controls.Add(this.dgv_TableFoodInfo);
            this.pl_Main.Controls.Add(this.tb_TotalPrice);
            this.pl_Main.Controls.Add(this.bt_CheckOut);
            this.pl_Main.Controls.Add(this.btn_Close);
            this.pl_Main.Controls.Add(this.bt_AddFood);
            this.pl_Main.Controls.Add(this.lb_Discount);
            this.pl_Main.Controls.Add(this.lb_Count);
            this.pl_Main.Controls.Add(this.lb_Food);
            this.pl_Main.Controls.Add(this.lb_FoodCategory);
            this.pl_Main.Controls.Add(this.cb_Food);
            this.pl_Main.Controls.Add(this.nud_Discount);
            this.pl_Main.Controls.Add(this.nud_Count);
            this.pl_Main.Controls.Add(this.cb_FoodCategory);
            this.pl_Main.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Main.FillColor = System.Drawing.Color.Transparent;
            this.pl_Main.Location = new System.Drawing.Point(0, 0);
            this.pl_Main.Name = "pl_Main";
            this.pl_Main.ShadowDecoration.Parent = this.pl_Main;
            this.pl_Main.Size = new System.Drawing.Size(806, 459);
            this.pl_Main.TabIndex = 2;
            // 
            // dgv_TableFoodInfo
            // 
            this.dgv_TableFoodInfo.AllowUserToAddRows = false;
            this.dgv_TableFoodInfo.AllowUserToDeleteRows = false;
            this.dgv_TableFoodInfo.AllowUserToResizeColumns = false;
            this.dgv_TableFoodInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TableFoodInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TableFoodInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TableFoodInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TableFoodInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TableFoodInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_TableFoodInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv_TableFoodInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TableFoodInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TableFoodInfo.ColumnHeadersHeight = 60;
            this.dgv_TableFoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TableFoodInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TableFoodInfo.DoubleBuffered = true;
            this.dgv_TableFoodInfo.EnableHeadersVisualStyles = false;
            this.dgv_TableFoodInfo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv_TableFoodInfo.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_TableFoodInfo.Location = new System.Drawing.Point(12, 12);
            this.dgv_TableFoodInfo.MultiSelect = false;
            this.dgv_TableFoodInfo.Name = "dgv_TableFoodInfo";
            this.dgv_TableFoodInfo.ReadOnly = true;
            this.dgv_TableFoodInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TableFoodInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TableFoodInfo.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_TableFoodInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TableFoodInfo.RowTemplate.Height = 50;
            this.dgv_TableFoodInfo.RowTemplate.ReadOnly = true;
            this.dgv_TableFoodInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TableFoodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TableFoodInfo.Size = new System.Drawing.Size(471, 435);
            this.dgv_TableFoodInfo.TabIndex = 81;
            // 
            // tb_TotalPrice
            // 
            this.tb_TotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb_TotalPrice.BorderThickness = 0;
            this.tb_TotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TotalPrice.DefaultText = "0";
            this.tb_TotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TotalPrice.DisabledState.Parent = this.tb_TotalPrice;
            this.tb_TotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TotalPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb_TotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TotalPrice.FocusedState.Parent = this.tb_TotalPrice;
            this.tb_TotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalPrice.ForeColor = System.Drawing.Color.White;
            this.tb_TotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TotalPrice.HoverState.Parent = this.tb_TotalPrice;
            this.tb_TotalPrice.IconLeft = global::ProjectQuanCafeK19.Properties.Resources.money_512px;
            this.tb_TotalPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tb_TotalPrice.Location = new System.Drawing.Point(492, 344);
            this.tb_TotalPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_TotalPrice.Name = "tb_TotalPrice";
            this.tb_TotalPrice.PasswordChar = '\0';
            this.tb_TotalPrice.PlaceholderForeColor = System.Drawing.Color.White;
            this.tb_TotalPrice.PlaceholderText = "";
            this.tb_TotalPrice.ReadOnly = true;
            this.tb_TotalPrice.SelectedText = "";
            this.tb_TotalPrice.SelectionStart = 1;
            this.tb_TotalPrice.ShadowDecoration.Parent = this.tb_TotalPrice;
            this.tb_TotalPrice.Size = new System.Drawing.Size(302, 36);
            this.tb_TotalPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tb_TotalPrice.TabIndex = 80;
            this.tb_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_CheckOut
            // 
            this.bt_CheckOut.BorderRadius = 20;
            this.bt_CheckOut.CheckedState.Parent = this.bt_CheckOut;
            this.bt_CheckOut.CustomImages.Parent = this.bt_CheckOut;
            this.bt_CheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.bt_CheckOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CheckOut.ForeColor = System.Drawing.Color.White;
            this.bt_CheckOut.HoverState.Parent = this.bt_CheckOut;
            this.bt_CheckOut.Image = global::ProjectQuanCafeK19.Properties.Resources.checkout_512px;
            this.bt_CheckOut.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_CheckOut.Location = new System.Drawing.Point(492, 390);
            this.bt_CheckOut.Name = "bt_CheckOut";
            this.bt_CheckOut.ShadowDecoration.Parent = this.bt_CheckOut;
            this.bt_CheckOut.Size = new System.Drawing.Size(190, 52);
            this.bt_CheckOut.TabIndex = 79;
            this.bt_CheckOut.Text = "Thanh toán";
            this.bt_CheckOut.Click += new System.EventHandler(this.bt_CheckOut_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BorderRadius = 20;
            this.btn_Close.CheckedState.Parent = this.btn_Close;
            this.btn_Close.CustomImages.Parent = this.btn_Close;
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.Parent = this.btn_Close;
            this.btn_Close.Image = global::ProjectQuanCafeK19.Properties.Resources.back_to_480px;
            this.btn_Close.Location = new System.Drawing.Point(688, 390);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Parent = this.btn_Close;
            this.btn_Close.Size = new System.Drawing.Size(106, 52);
            this.btn_Close.TabIndex = 79;
            this.btn_Close.Text = "Quay lại";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // bt_AddFood
            // 
            this.bt_AddFood.BorderRadius = 20;
            this.bt_AddFood.CheckedState.Parent = this.bt_AddFood;
            this.bt_AddFood.CustomImages.Parent = this.bt_AddFood;
            this.bt_AddFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.bt_AddFood.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddFood.ForeColor = System.Drawing.Color.White;
            this.bt_AddFood.HoverState.Parent = this.bt_AddFood;
            this.bt_AddFood.Image = global::ProjectQuanCafeK19.Properties.Resources.add_to_shopping_basket_512px;
            this.bt_AddFood.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_AddFood.Location = new System.Drawing.Point(492, 224);
            this.bt_AddFood.Name = "bt_AddFood";
            this.bt_AddFood.ShadowDecoration.Parent = this.bt_AddFood;
            this.bt_AddFood.Size = new System.Drawing.Size(302, 45);
            this.bt_AddFood.TabIndex = 79;
            this.bt_AddFood.Text = "Thêm món";
            this.bt_AddFood.Click += new System.EventHandler(this.bt_AddFood_Click);
            // 
            // lb_Discount
            // 
            this.lb_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.lb_Discount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Discount.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Discount.Location = new System.Drawing.Point(492, 297);
            this.lb_Discount.Name = "lb_Discount";
            this.lb_Discount.Size = new System.Drawing.Size(153, 36);
            this.lb_Discount.TabIndex = 78;
            this.lb_Discount.Text = "Giảm giá";
            this.lb_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Count
            // 
            this.lb_Count.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lb_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Count.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Count.Location = new System.Drawing.Point(492, 182);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(153, 36);
            this.lb_Count.TabIndex = 78;
            this.lb_Count.Text = "Số lượng";
            this.lb_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Food
            // 
            this.lb_Food.BackColor = System.Drawing.Color.Silver;
            this.lb_Food.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Food.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Food.Location = new System.Drawing.Point(492, 99);
            this.lb_Food.Name = "lb_Food";
            this.lb_Food.Size = new System.Drawing.Size(302, 33);
            this.lb_Food.TabIndex = 75;
            this.lb_Food.Text = "Thực phẩm";
            this.lb_Food.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FoodCategory
            // 
            this.lb_FoodCategory.BackColor = System.Drawing.Color.Silver;
            this.lb_FoodCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FoodCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_FoodCategory.Location = new System.Drawing.Point(492, 14);
            this.lb_FoodCategory.Name = "lb_FoodCategory";
            this.lb_FoodCategory.Size = new System.Drawing.Size(302, 33);
            this.lb_FoodCategory.TabIndex = 75;
            this.lb_FoodCategory.Text = "Loại thực phẩm";
            this.lb_FoodCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_Discount
            // 
            this.nud_Discount.BackColor = System.Drawing.Color.Transparent;
            this.nud_Discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_Discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nud_Discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nud_Discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nud_Discount.DisabledState.Parent = this.nud_Discount;
            this.nud_Discount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nud_Discount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nud_Discount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.nud_Discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nud_Discount.FocusedState.Parent = this.nud_Discount;
            this.nud_Discount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Discount.ForeColor = System.Drawing.Color.White;
            this.nud_Discount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Discount.Location = new System.Drawing.Point(651, 297);
            this.nud_Discount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nud_Discount.Name = "nud_Discount";
            this.nud_Discount.ShadowDecoration.Parent = this.nud_Discount;
            this.nud_Discount.Size = new System.Drawing.Size(143, 36);
            this.nud_Discount.TabIndex = 1;
            this.nud_Discount.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nud_Discount.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // FormTableFoodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 459);
            this.Controls.Add(this.pl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTableFoodInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTableFoodInfo";
            this.Load += new System.EventHandler(this.FormTableFoodInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Count)).EndInit();
            this.pl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableFoodInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_FoodCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Food;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Count;
        private Guna.UI2.WinForms.Guna2Panel pl_Main;
        private Guna.UI.WinForms.GunaLabel lb_FoodCategory;
        private Guna.UI.WinForms.GunaLabel lb_Food;
        private Guna.UI.WinForms.GunaLabel lb_Count;
        private Guna.UI2.WinForms.Guna2Button bt_AddFood;
        private Guna.UI.WinForms.GunaLabel lb_Discount;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_Discount;
        private Guna.UI2.WinForms.Guna2Button bt_CheckOut;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2TextBox tb_TotalPrice;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_TableFoodInfo;
    }
}