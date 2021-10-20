using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.Report
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public int Staff { get; set; }
        public int Category { get; set; }
        public int Food { get; set; }
        public int Sold { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }
        public int Interest { get; set; }
        public string BestFood { get; set; } = "Cappucino";
        public string BestCategory { get; set; } = "Trà trái cây";

        private void FormReport_Load(object sender, EventArgs e)
        {
            dgv_Report.DataSource = entity.Report();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = $"THỐNG KÊ CHI TIẾT";
            string temp = $"Nhân viên: {Staff}\r\nLoại thực phẩm: {Category}\r\nThực phẩm: {Food}\r\nĐã bán: {Sold}\r\nTổng vốn: {Cost}đ\r\nTổng thu về: {Price}đ\r\nTổng lãi: {Interest}đ\r\nBán chạy nhất: {BestFood}\r\nLoại bán chạy nhất: {BestCategory}\r\n";
            printer.SubTitle = temp + $"Ngày in: {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Quán Cafe K19";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv_Report);
        }
    }
}
