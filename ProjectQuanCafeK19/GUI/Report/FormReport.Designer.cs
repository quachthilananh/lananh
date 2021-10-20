namespace ProjectQuanCafeK19.GUI.Report
{
    partial class FormReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Report = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_PDF = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Report
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_Report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Report.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Report.ColumnHeadersHeight = 21;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Report.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Report.EnableHeadersVisualStyles = false;
            this.dgv_Report.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Report.Location = new System.Drawing.Point(0, 75);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.ReadOnly = true;
            this.dgv_Report.RowHeadersVisible = false;
            this.dgv_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Report.Size = new System.Drawing.Size(800, 375);
            this.dgv_Report.TabIndex = 3;
            this.dgv_Report.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Report.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Report.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Report.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Report.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Report.ThemeStyle.ReadOnly = true;
            this.dgv_Report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Report.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_PDF.Location = new System.Drawing.Point(403, 12);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.ShadowDecoration.Parent = this.btn_PDF;
            this.btn_PDF.Size = new System.Drawing.Size(180, 47);
            this.btn_PDF.TabIndex = 4;
            this.btn_PDF.Text = "Xuất PDF";
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
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
            this.btn_Excel.Location = new System.Drawing.Point(217, 12);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(180, 47);
            this.btn_Excel.TabIndex = 5;
            this.btn_Excel.Text = "Xuất Excel";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.dgv_Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_Report;
        private Guna.UI2.WinForms.Guna2Button btn_PDF;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
    }
}