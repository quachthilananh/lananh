namespace ProjectQuanCafeK19
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pl_One = new System.Windows.Forms.Panel();
            this.btn_Product = new Guna.UI.WinForms.GunaButton();
            this.btn_Category = new Guna.UI.WinForms.GunaButton();
            this.btn_Report = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_TableFood = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_Items = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btn_Staff = new Guna.UI.WinForms.GunaGradientTileButton();
            this.pl_Two = new System.Windows.Forms.Panel();
            this.uc_Bill = new ProjectQuanCafeK19.GUI.Bill.UC_Bill();
            this.uc_Report = new ProjectQuanCafeK19.GUI.Report.UC_Report();
            this.uc_TableFood = new ProjectQuanCafeK19.GUI.TableFood.UC_TableFood();
            this.uc_Food = new ProjectQuanCafeK19.GUI.Food.UC_Food();
            this.uc_FoodCategory = new ProjectQuanCafeK19.GUI.FoodCategory.UC_FoodCategory();
            this.uc_Account = new ProjectQuanCafeK19.UC_Account();
            this.pl_Three = new System.Windows.Forms.Panel();
            this.pl_Top = new System.Windows.Forms.Panel();
            this.e_PannelOne = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.e_PannelTwo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.e_PanelThree = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipse_FormMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.pb_Setting = new System.Windows.Forms.PictureBox();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.tt_MoveForm = new System.Windows.Forms.ToolTip(this.components);
            this.pl_One.SuspendLayout();
            this.pl_Two.SuspendLayout();
            this.pl_Three.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_One
            // 
            this.pl_One.BackColor = System.Drawing.Color.White;
            this.pl_One.Controls.Add(this.btn_Product);
            this.pl_One.Controls.Add(this.btn_Category);
            this.pl_One.Controls.Add(this.btn_Report);
            this.pl_One.Controls.Add(this.btn_TableFood);
            this.pl_One.Controls.Add(this.btn_Items);
            this.pl_One.Controls.Add(this.btn_Staff);
            this.pl_One.Controls.Add(this.pl_Two);
            this.pl_One.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_One.Location = new System.Drawing.Point(75, 0);
            this.pl_One.Name = "pl_One";
            this.pl_One.Size = new System.Drawing.Size(1173, 706);
            this.pl_One.TabIndex = 0;
            // 
            // btn_Product
            // 
            this.btn_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Product.AnimationSpeed = 0.03F;
            this.btn_Product.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Product.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.Black;
            this.btn_Product.Image = null;
            this.btn_Product.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Product.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Product.Location = new System.Drawing.Point(13, 310);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Product.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Product.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Product.OnHoverImage = null;
            this.btn_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Product.Radius = 10;
            this.btn_Product.Size = new System.Drawing.Size(150, 29);
            this.btn_Product.TabIndex = 2;
            this.btn_Product.Text = "Sản phẩm";
            this.btn_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.AnimationHoverSpeed = 0.07F;
            this.btn_Category.AnimationSpeed = 0.03F;
            this.btn_Category.BackColor = System.Drawing.Color.Transparent;
            this.btn_Category.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Category.BorderColor = System.Drawing.Color.Black;
            this.btn_Category.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Category.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Category.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.Black;
            this.btn_Category.Image = null;
            this.btn_Category.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Category.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Category.Location = new System.Drawing.Point(13, 275);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Category.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Category.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Category.OnHoverImage = null;
            this.btn_Category.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Category.Radius = 10;
            this.btn_Category.Size = new System.Drawing.Size(150, 29);
            this.btn_Category.TabIndex = 2;
            this.btn_Category.Text = "Danh mục";
            this.btn_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.AnimationHoverSpeed = 0.07F;
            this.btn_Report.AnimationSpeed = 0.03F;
            this.btn_Report.BackColor = System.Drawing.Color.Transparent;
            this.btn_Report.BaseColor1 = System.Drawing.Color.Transparent;
            this.btn_Report.BaseColor2 = System.Drawing.Color.Transparent;
            this.btn_Report.BorderColor = System.Drawing.Color.Black;
            this.btn_Report.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Report.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Report.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.Black;
            this.btn_Report.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Report.Image = global::ProjectQuanCafeK19.Properties.Resources.account_500px;
            this.btn_Report.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Report.Location = new System.Drawing.Point(13, 445);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Report.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Report.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Report.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Report.OnHoverImage = null;
            this.btn_Report.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.btn_Report.Radius = 20;
            this.btn_Report.Size = new System.Drawing.Size(150, 87);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Báo cáo";
            this.btn_Report.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btn_Report.UseTransfarantBackground = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_TableFood
            // 
            this.btn_TableFood.AnimationHoverSpeed = 0.07F;
            this.btn_TableFood.AnimationSpeed = 0.03F;
            this.btn_TableFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_TableFood.BaseColor1 = System.Drawing.Color.Transparent;
            this.btn_TableFood.BaseColor2 = System.Drawing.Color.Transparent;
            this.btn_TableFood.BorderColor = System.Drawing.Color.Black;
            this.btn_TableFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TableFood.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TableFood.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TableFood.ForeColor = System.Drawing.Color.Black;
            this.btn_TableFood.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_TableFood.Image = global::ProjectQuanCafeK19.Properties.Resources.tableware_500px;
            this.btn_TableFood.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_TableFood.Location = new System.Drawing.Point(13, 78);
            this.btn_TableFood.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TableFood.Name = "btn_TableFood";
            this.btn_TableFood.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_TableFood.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_TableFood.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_TableFood.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TableFood.OnHoverImage = null;
            this.btn_TableFood.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.btn_TableFood.Radius = 20;
            this.btn_TableFood.Size = new System.Drawing.Size(150, 87);
            this.btn_TableFood.TabIndex = 1;
            this.btn_TableFood.Text = "Bàn ăn";
            this.btn_TableFood.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btn_TableFood.UseTransfarantBackground = true;
            this.btn_TableFood.Click += new System.EventHandler(this.btn_TableFood_Click);
            // 
            // btn_Items
            // 
            this.btn_Items.AnimationHoverSpeed = 0.07F;
            this.btn_Items.AnimationSpeed = 0.03F;
            this.btn_Items.BackColor = System.Drawing.Color.Transparent;
            this.btn_Items.BaseColor1 = System.Drawing.Color.Transparent;
            this.btn_Items.BaseColor2 = System.Drawing.Color.Transparent;
            this.btn_Items.BorderColor = System.Drawing.Color.Black;
            this.btn_Items.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Items.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Items.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Items.ForeColor = System.Drawing.Color.Black;
            this.btn_Items.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Items.Image = global::ProjectQuanCafeK19.Properties.Resources.ingredients_500px;
            this.btn_Items.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Items.Location = new System.Drawing.Point(13, 177);
            this.btn_Items.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Items.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Items.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Items.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Items.OnHoverImage = null;
            this.btn_Items.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.btn_Items.Radius = 20;
            this.btn_Items.Size = new System.Drawing.Size(150, 87);
            this.btn_Items.TabIndex = 1;
            this.btn_Items.Text = "Mặt hàng";
            this.btn_Items.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btn_Items.UseTransfarantBackground = true;
            // 
            // btn_Staff
            // 
            this.btn_Staff.AnimationHoverSpeed = 0.07F;
            this.btn_Staff.AnimationSpeed = 0.03F;
            this.btn_Staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_Staff.BaseColor1 = System.Drawing.Color.Transparent;
            this.btn_Staff.BaseColor2 = System.Drawing.Color.Transparent;
            this.btn_Staff.BorderColor = System.Drawing.Color.Black;
            this.btn_Staff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Staff.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Staff.Image = global::ProjectQuanCafeK19.Properties.Resources.user_groups_500px;
            this.btn_Staff.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Staff.Location = new System.Drawing.Point(13, 346);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Staff.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_Staff.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Staff.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Staff.OnHoverImage = null;
            this.btn_Staff.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.btn_Staff.Radius = 20;
            this.btn_Staff.Size = new System.Drawing.Size(150, 87);
            this.btn_Staff.TabIndex = 1;
            this.btn_Staff.Text = "Nhân viên";
            this.btn_Staff.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.btn_Staff.UseTransfarantBackground = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // pl_Two
            // 
            this.pl_Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.pl_Two.Controls.Add(this.uc_TableFood);
            this.pl_Two.Controls.Add(this.uc_Bill);
            this.pl_Two.Controls.Add(this.uc_Report);
            this.pl_Two.Controls.Add(this.uc_Food);
            this.pl_Two.Controls.Add(this.uc_FoodCategory);
            this.pl_Two.Controls.Add(this.uc_Account);
            this.pl_Two.Controls.Add(this.pl_Three);
            this.pl_Two.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_Two.Location = new System.Drawing.Point(178, 0);
            this.pl_Two.Name = "pl_Two";
            this.pl_Two.Size = new System.Drawing.Size(995, 706);
            this.pl_Two.TabIndex = 0;
            // 
            // uc_Bill
            // 
            this.uc_Bill.Location = new System.Drawing.Point(0, 0);
            this.uc_Bill.Name = "uc_Bill";
            this.uc_Bill.Size = new System.Drawing.Size(737, 706);
            this.uc_Bill.TabIndex = 6;
            // 
            // uc_Report
            // 
            this.uc_Report.Location = new System.Drawing.Point(-1, 0);
            this.uc_Report.Name = "uc_Report";
            this.uc_Report.Size = new System.Drawing.Size(737, 706);
            this.uc_Report.TabIndex = 5;
            // 
            // uc_TableFood
            // 
            this.uc_TableFood.Location = new System.Drawing.Point(6, 6);
            this.uc_TableFood.Name = "uc_TableFood";
            this.uc_TableFood.Size = new System.Drawing.Size(728, 696);
            this.uc_TableFood.TabIndex = 4;
            // 
            // uc_Food
            // 
            this.uc_Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.uc_Food.Location = new System.Drawing.Point(-1, 0);
            this.uc_Food.Name = "uc_Food";
            this.uc_Food.Size = new System.Drawing.Size(737, 706);
            this.uc_Food.TabIndex = 3;
            // 
            // uc_FoodCategory
            // 
            this.uc_FoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.uc_FoodCategory.Location = new System.Drawing.Point(2, 0);
            this.uc_FoodCategory.Name = "uc_FoodCategory";
            this.uc_FoodCategory.Size = new System.Drawing.Size(737, 706);
            this.uc_FoodCategory.TabIndex = 2;
            // 
            // uc_Account
            // 
            this.uc_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.uc_Account.Location = new System.Drawing.Point(0, 0);
            this.uc_Account.Name = "uc_Account";
            this.uc_Account.Size = new System.Drawing.Size(737, 706);
            this.uc_Account.TabIndex = 1;
            // 
            // pl_Three
            // 
            this.pl_Three.BackColor = System.Drawing.Color.White;
            this.pl_Three.Controls.Add(this.pl_Top);
            this.pl_Three.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_Three.Location = new System.Drawing.Point(736, 0);
            this.pl_Three.Name = "pl_Three";
            this.pl_Three.Size = new System.Drawing.Size(259, 706);
            this.pl_Three.TabIndex = 0;
            // 
            // pl_Top
            // 
            this.pl_Top.BackColor = System.Drawing.Color.Transparent;
            this.pl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_Top.Location = new System.Drawing.Point(0, 0);
            this.pl_Top.Name = "pl_Top";
            this.pl_Top.Size = new System.Drawing.Size(259, 37);
            this.pl_Top.TabIndex = 6;
            this.tt_MoveForm.SetToolTip(this.pl_Top, "Nắm ở đây để di chuyển phần mềm");
            this.pl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseDown);
            this.pl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseMove);
            this.pl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseUp);
            // 
            // e_PannelOne
            // 
            this.e_PannelOne.ElipseRadius = 40;
            this.e_PannelOne.TargetControl = this.pl_One;
            // 
            // e_PannelTwo
            // 
            this.e_PannelTwo.ElipseRadius = 40;
            this.e_PannelTwo.TargetControl = this.pl_Two;
            // 
            // e_PanelThree
            // 
            this.e_PanelThree.ElipseRadius = 40;
            this.e_PanelThree.TargetControl = this.pl_Three;
            // 
            // elipse_FormMain
            // 
            this.elipse_FormMain.ElipseRadius = 40;
            this.elipse_FormMain.TargetControl = this;
            // 
            // pb_User
            // 
            this.pb_User.BackColor = System.Drawing.Color.Transparent;
            this.pb_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_User.Image = global::ProjectQuanCafeK19.Properties.Resources.account_96px;
            this.pb_User.Location = new System.Drawing.Point(19, 78);
            this.pb_User.Name = "pb_User";
            this.pb_User.Size = new System.Drawing.Size(36, 34);
            this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_User.TabIndex = 1;
            this.pb_User.TabStop = false;
            // 
            // pb_Setting
            // 
            this.pb_Setting.BackColor = System.Drawing.Color.Transparent;
            this.pb_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Setting.Image = global::ProjectQuanCafeK19.Properties.Resources.settings_480px;
            this.pb_Setting.Location = new System.Drawing.Point(19, 125);
            this.pb_Setting.Name = "pb_Setting";
            this.pb_Setting.Size = new System.Drawing.Size(36, 34);
            this.pb_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Setting.TabIndex = 1;
            this.pb_Setting.TabStop = false;
            // 
            // pb_LogOut
            // 
            this.pb_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::ProjectQuanCafeK19.Properties.Resources.logout_rounded_up_512px;
            this.pb_LogOut.Location = new System.Drawing.Point(19, 658);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(36, 34);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_LogOut.TabIndex = 1;
            this.pb_LogOut.TabStop = false;
            this.pb_LogOut.Click += new System.EventHandler(this.pb_LogOut_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(12, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(53, 47);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 706);
            this.Controls.Add(this.pb_User);
            this.Controls.Add(this.pb_Setting);
            this.Controls.Add(this.pb_LogOut);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.pl_One);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pl_One.ResumeLayout(false);
            this.pl_Two.ResumeLayout(false);
            this.pl_Three.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pl_One;
        private Bunifu.Framework.UI.BunifuElipse e_PannelOne;
        private System.Windows.Forms.Panel pl_Two;
        private Bunifu.Framework.UI.BunifuElipse e_PannelTwo;
        private System.Windows.Forms.Panel pl_Three;
        private Bunifu.Framework.UI.BunifuElipse e_PanelThree;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.PictureBox pb_Setting;
        private System.Windows.Forms.PictureBox pb_User;
        private Guna.UI.WinForms.GunaGradientTileButton btn_Staff;
        private Guna.UI.WinForms.GunaGradientTileButton btn_Report;
        private Guna.UI.WinForms.GunaGradientTileButton btn_TableFood;
        private Guna.UI.WinForms.GunaGradientTileButton btn_Items;
        private Guna.UI.WinForms.GunaButton btn_Category;
        private Guna.UI.WinForms.GunaButton btn_Product;
        private Bunifu.Framework.UI.BunifuElipse elipse_FormMain;
        private UC_Account uc_Account;
        private System.Windows.Forms.Panel pl_Top;
        private System.Windows.Forms.ToolTip tt_MoveForm;
        private GUI.FoodCategory.UC_FoodCategory uc_FoodCategory;
        private GUI.Food.UC_Food uc_Food;
        private GUI.Bill.UC_Bill uc_Bill;
        private GUI.Report.UC_Report uc_Report;
        private GUI.TableFood.UC_TableFood uc_TableFood;
    }
}

