using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.BillInfo
{
    public partial class FormBillInfo : Form
    {
        public FormBillInfo()
        {
            InitializeComponent();
        }

        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public int IDBill { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Discount { get; set; }
        public string NameTableFood { get; set; }
        public int TotalPrice { get; set; }
        public string StatusBill { get; set; }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgv_BillInfo.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_BillInfo.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_BillInfo.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_BillInfo.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_BillInfo.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_BillInfo.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = $"CHI TIẾT HOÁ ĐƠN";
            printer.SubTitle = $"Mã hoá đơn: {IDBill}\r\nNgày ghi: {CheckIn}\r\nNgày thanh toán: {CheckOut}\r\nGiảm giá: {Discount}%\r\nTên bàn: {NameTableFood}\r\nTổng tiền: {TotalPrice}\r\nTrạng thái: {StatusBill}\r\nNgày in: {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Quán Cafe K19";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_BillInfo);
        }

        private void FormBillInfo_Load(object sender, EventArgs e)
        {
            dgv_BillInfo.DataSource = entity.GetBillInfoForBill(IDBill);
        }
    }
}
