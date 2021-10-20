using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQuanCafeK19.GUI.Bill;

namespace ProjectQuanCafeK19.GUI.Report
{
    public partial class UC_Report : UserControl
    {
        /*
         * Số nhân viên
         * Số loại thực phẩm
         * Số thực phẩm
         * Số hoá đơn
         * Tiền vốn
         * Tiền lãi
         * Số sản phẩm đã bán
         * Xuất file excel: Tháng, Tiền vốn, Tiền lãi, Số sản phẩm đã bán
         */

        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public UC_Report()
        {
            InitializeComponent();
        }

        int totalStaff = 0;
        int i_totalStaff = 0;
        int totalFoodCategory = 0;
        int i_totalFoodCategory = 0;
        int totalFood = 0;
        int i_totalFood = 0;
        int totalProductSold = 0;
        int i_totalProductSold = 0;
        int totalCost = 0;
        int i_totalCost = 0;
        int totalPrice = 0;
        int i_totalPrice = 0;

        private void timerReport_Tick(object sender, EventArgs e)
        {
            if (i_totalStaff < totalStaff)
            {
                i_totalStaff++;
                tb_TotalStaff.Text = i_totalStaff.ToString();
            }

            if (i_totalFoodCategory < totalFoodCategory)
            {
                i_totalFoodCategory++;
                tb_TotalCategory.Text = i_totalFoodCategory.ToString();
            }

            if (i_totalFood < totalFood)
            {
                i_totalFood++;
                tb_Food.Text = i_totalFood.ToString();
            }

            if (i_totalProductSold < totalProductSold)
            {
                i_totalProductSold++;
                tb_TotalSold.Text = i_totalProductSold.ToString();
            }

            if (i_totalStaff == totalStaff && i_totalFoodCategory == totalFoodCategory && i_totalFood == totalFood && i_totalProductSold == totalProductSold)
            {
                timerReport.Stop();                
            }
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            var data = entity.TotalStaff();
            foreach (var item in data)
            {
                totalStaff = Convert.ToInt32(item);
            }

            data = entity.TotalCategory();
            foreach (var item in data)
            {
                totalFoodCategory = Convert.ToInt32(item);
            }

            data = entity.TotalFood();
            foreach (var item in data)
            {
                totalFood = Convert.ToInt32(item);
            }

            data = entity.TotalProductSold();
            foreach (var item in data)
            {
                totalProductSold += Convert.ToInt32(item);
            }

            data = entity.TotalCost();
            foreach (var item in data)
            {
                totalCost += Convert.ToInt32(item);
            }
            tb_Cost.Text = totalCost.ToString();

            data = entity.TotalPrice();
            foreach (var item in data)
            {
                totalPrice += Convert.ToInt32(item);
            }
            tb_Price.Text = totalPrice.ToString();

            tb_Interest.Text = (totalPrice - totalCost).ToString();

            timerReport.Start();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            totalStaff = 0;
            i_totalStaff = 0;
            totalFoodCategory = 0;
            i_totalFoodCategory = 0;
            totalFood = 0;
            i_totalFood = 0;
            totalProductSold = 0;
            i_totalProductSold = 0;
            totalCost = 0;
            i_totalCost = 0;
            totalPrice = 0;
            i_totalPrice = 0;
            UC_Report_Load(sender, e);
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            var formBill = new FormBill();
            formBill.ShowDialog();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            //var formReport = new FormReport();
            //formReport.Staff = totalStaff;
            //formReport.Category = totalFoodCategory;
            //formReport.Food = totalFood;
            //formReport.Sold = totalProductSold;
            //formReport.Cost = totalCost;
            //formReport.Price = totalPrice;
            //formReport.Interest = totalPrice - totalCost;

            //formReport.ShowDialog();
        }
    }
}
