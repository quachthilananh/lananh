namespace ProjectQuanCafeK19.GUI.Bill
{
    partial class FormBill
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
            this.dtp_CheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgv_Bill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtp_CheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SearchByDate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_PDF = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_CheckIn
            // 
            this.dtp_CheckIn.CheckedState.Parent = this.dtp_CheckIn;
            this.dtp_CheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_CheckIn.ForeColor = System.Drawing.Color.Black;
            this.dtp_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_CheckIn.HoverState.Parent = this.dtp_CheckIn;
            this.dtp_CheckIn.Location = new System.Drawing.Point(28, 12);
            this.dtp_CheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_CheckIn.Name = "dtp_CheckIn";
            this.dtp_CheckIn.ShadowDecoration.Parent = this.dtp_CheckIn;
            this.dtp_CheckIn.Size = new System.Drawing.Size(273, 47);
            this.dtp_CheckIn.TabIndex = 1;
            this.dtp_CheckIn.Value = new System.DateTime(2020, 10, 14, 10, 50, 15, 962);
            // 
            // dgv_Bill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Bill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Bill.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Bill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Bill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Bill.EnableHeadersVisualStyles = false;
            this.dgv_Bill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Bill.Location = new System.Drawing.Point(0, 75);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.ReadOnly = true;
            this.dgv_Bill.RowHeadersVisible = false;
            this.dgv_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Bill.Size = new System.Drawing.Size(1182, 375);
            this.dgv_Bill.TabIndex = 2;
            this.dgv_Bill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Bill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Bill.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Bill.ThemeStyle.ReadOnly = true;
            this.dgv_Bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Bill.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Bill.DoubleClick += new System.EventHandler(this.dgv_Bill_DoubleClick);
            // 
            // dtp_CheckOut
            // 
            this.dtp_CheckOut.CheckedState.Parent = this.dtp_CheckOut;
            this.dtp_CheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_CheckOut.ForeColor = System.Drawing.Color.Black;
            this.dtp_CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_CheckOut.HoverState.Parent = this.dtp_CheckOut;
            this.dtp_CheckOut.Location = new System.Drawing.Point(307, 12);
            this.dtp_CheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_CheckOut.Name = "dtp_CheckOut";
            this.dtp_CheckOut.ShadowDecoration.Parent = this.dtp_CheckOut;
            this.dtp_CheckOut.Size = new System.Drawing.Size(273, 47);
            this.dtp_CheckOut.TabIndex = 1;
            this.dtp_CheckOut.Value = new System.DateTime(2020, 10, 14, 10, 50, 15, 962);
            // 
            // btn_Excel
            // 
            this.btn_Excel.CheckedState.Parent = this.btn_Excel;
            this.btn_Excel.CustomImages.Parent = this.btn_Excel;
            this.btn_Excel.FillColor = System.Drawing.Color.DimGray;
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.HoverState.Parent = this.btn_Excel;
            this.btn_Excel.Image = global::ProjectQuanCafeK19.Properties.Resources.microsoft_excel_208px;
            this.btn_Excel.Location = new System.Drawing.Point(772, 12);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(180, 47);
            this.btn_Excel.TabIndex = 3;
            this.btn_Excel.Text = "Xuất Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_SearchByDate
            // 
            this.btn_SearchByDate.CheckedState.Parent = this.btn_SearchByDate;
            this.btn_SearchByDate.CustomImages.Parent = this.btn_SearchByDate;
            this.btn_SearchByDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchByDate.ForeColor = System.Drawing.Color.White;
            this.btn_SearchByDate.HoverState.Parent = this.btn_SearchByDate;
            this.btn_SearchByDate.Image = global::ProjectQuanCafeK19.Properties.Resources.search_512px;
            this.btn_SearchByDate.Location = new System.Drawing.Point(586, 12);
            this.btn_SearchByDate.Name = "btn_SearchByDate";
            this.btn_SearchByDate.ShadowDecoration.Parent = this.btn_SearchByDate;
            this.btn_SearchByDate.Size = new System.Drawing.Size(180, 47);
            this.btn_SearchByDate.TabIndex = 3;
            this.btn_SearchByDate.Text = "Tìm theo thời gian";
            this.btn_SearchByDate.Click += new System.EventHandler(this.btn_SearchByDate_Click);
            // 
            // btn_PDF
            // 
            this.btn_PDF.CheckedState.Parent = this.btn_PDF;
            this.btn_PDF.CustomImages.Parent = this.btn_PDF;
            this.btn_PDF.FillColor = System.Drawing.Color.DimGray;
            this.btn_PDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDF.ForeColor = System.Drawing.Color.White;
            this.btn_PDF.HoverState.Parent = this.btn_PDF;
            this.btn_PDF.Image = global::ProjectQuanCafeK19.Properties.Resources.pdf_480px;
            this.btn_PDF.Location = new System.Drawing.Point(958, 12);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.ShadowDecoration.Parent = this.btn_PDF;
            this.btn_PDF.Size = new System.Drawing.Size(180, 47);
            this.btn_PDF.TabIndex = 3;
            this.btn_PDF.Text = "Xuất PDF";
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_SearchByDate);
            this.Controls.Add(this.dgv_Bill);
            this.Controls.Add(this.dtp_CheckOut);
            this.Controls.Add(this.dtp_CheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CheckIn;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Bill;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CheckOut;
        private Guna.UI2.WinForms.Guna2Button btn_SearchByDate;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private Guna.UI2.WinForms.Guna2Button btn_PDF;
    }
}