using ProjectQuanCafeK19.GUI.BillInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.Bill
{
    public partial class FormBill : Form
    {
        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = entity.GetListBill();
        }

        private void btn_SearchByDate_Click(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = entity.SearchBillByDate(dtp_CheckIn.Value, dtp_CheckOut.Value);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgv_Bill.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_Bill.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_Bill.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_Bill.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_Bill.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_Bill.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void dgv_Bill_DoubleClick(object sender, EventArgs e)
        {
            var formBillInfo = new FormBillInfo();
            formBillInfo.IDBill = Convert.ToInt32(dgv_Bill.SelectedRows[0].Cells[0].Value);
            formBillInfo.CheckIn = Convert.ToDateTime(dgv_Bill.SelectedRows[0].Cells[1].Value);
            formBillInfo.CheckOut = Convert.ToDateTime(dgv_Bill.SelectedRows[0].Cells[2].Value);
            formBillInfo.Discount = Convert.ToInt32(dgv_Bill.SelectedRows[0].Cells[3].Value);
            formBillInfo.NameTableFood = Convert.ToString(dgv_Bill.SelectedRows[0].Cells[4].Value);
            formBillInfo.TotalPrice = Convert.ToInt32(dgv_Bill.SelectedRows[0].Cells[5].Value);
            formBillInfo.StatusBill = Convert.ToString(dgv_Bill.SelectedRows[0].Cells[6].Value);
            formBillInfo.ShowDialog();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "TẤT CẢ HOÁ ĐƠN";
            printer.SubTitle = $"Ngày: {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Quán Cafe K19";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_Bill);
        }
    }
}
