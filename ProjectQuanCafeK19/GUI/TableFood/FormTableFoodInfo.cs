using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.TableFood
{
    public partial class FormTableFoodInfo : Form
    {
        private QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public FormTableFoodInfo()
        {
            InitializeComponent();
        }

        public int IDTableFood { get; set; }

        public string Status { get; set; }

        private void cb_FoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 1;

            try
            {
                id = Convert.ToInt32(cb_FoodCategory.SelectedValue);
            }
            catch (Exception)
            {

            }
            finally
            {
                cb_Food.DataSource = entity.GetListFoodByIDFoodCategory(id);
                cb_Food.DisplayMember = "Tên_thực_phẩm";
                cb_Food.ValueMember = "Mã_thực_phẩm";
            }
        }

        private void FormTableFoodInfo_Load(object sender, EventArgs e)
        {
            cb_FoodCategory.DataSource = entity.GetListFoodCategory();
            cb_FoodCategory.DisplayMember = "Tên_loại";
            cb_FoodCategory.ValueMember = "Mã_loại";

            dgv_TableFoodInfo.DataSource = entity.GetBillInfoForTableFood(IDTableFood);
            LoadTotalPrice();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_AddFood_Click(object sender, EventArgs e)
        {
            /*
             Khi thêm món
            1. Nếu bàn chưa có người, thì thêm Bill, thêm BillInfo
            2. Nếu bàn đã có người, thêm hoặc update BillInfo
             */

            if (Status == "Trống")
            {
                entity.InsertBill(IDTableFood); // thêm Bill

                int idBill = 1;
                var dataIDBill = entity.GetIDBillLatest(); // lấy IDBill vừa thêm
                foreach (var item in dataIDBill)
                {
                    idBill = item.Value;
                    break;
                }

                int idFood = Convert.ToInt32(cb_Food.SelectedValue); // lấy IDFood
                int count = Convert.ToInt32(nud_Count.Value); // lấy Count Food
                entity.InsertBillInfo(idBill, idFood, count); // thêm BillInfo

                dgv_TableFoodInfo.DataSource = entity.GetBillInfoForTableFood(IDTableFood); // load lại dgb_TableFoodInfo
                entity.UpdateStatusTableFood(IDTableFood, 1); // update thành có người
                Status = "Có người";
            }
            else
            {
                bool foodExist = false; // kiểm tra Food đó đã tồn tại trong Bill chưa
                for (int i = 0; i < dgv_TableFoodInfo.Rows.Count; i++)
                {
                    if (cb_Food.Text == dgv_TableFoodInfo.Rows[i].Cells[1].Value.ToString()) // nếu đã có trong BILL thì update Count của BillInfo
                    {
                        int id = Convert.ToInt32(dgv_TableFoodInfo.Rows[i].Cells[0].Value); // lấy IDBillInfo
                        int count = Convert.ToInt32(nud_Count.Value); // lấy Count
                        entity.UpdateCountBillInfo(id, count);
                        dgv_TableFoodInfo.DataSource = entity.GetBillInfoForTableFood(IDTableFood);
                        foodExist = true;
                    }
                }

                if (foodExist == false) // nếu Food định thêm không có trong Bill
                {
                    int idBill = GetIDBill();
                    int idFood = Convert.ToInt32(cb_Food.SelectedValue);
                    int count = Convert.ToInt32(nud_Count.Value);
                    entity.InsertBillInfo(idBill, idFood, count);

                    dgv_TableFoodInfo.DataSource = entity.GetBillInfoForTableFood(IDTableFood);
                    entity.UpdateStatusTableFood(IDTableFood, 1);
                }
            }

            LoadTotalPrice();
        }

        void LoadTotalPrice()
        {
            if (Status != "Trống")
            {
                int idBill = GetIDBill();

                int totalPrice = 0;
                var dataTotalPrice = entity.GetTotalPriceByIDBill(idBill);
                foreach (var item in dataTotalPrice)
                {
                    totalPrice = Convert.ToInt32(item);
                    break;
                }
                tb_TotalPrice.Text = totalPrice.ToString();
            }
        }

        int GetIDBill()
        {
            int idBill = 0;
            if (Status != "Trống")
            {
                var dataIDBill = entity.GetIDBillByIDBillInfo(Convert.ToInt32(dgv_TableFoodInfo.Rows[0].Cells[0].Value));
                foreach (var item in dataIDBill) // lấy IDBill
                {
                    idBill = Convert.ToInt32(item);
                }
            }
            return idBill;
        }

        private void bt_CheckOut_Click(object sender, EventArgs e)
        {
            /*
            hiển thị messagebox tổng số tiền
            update lại status bill thành 1, discount, totalprice, datacheckout
             */

            if (Status != "Trống")
            {
                int totalPrice = Convert.ToInt32(tb_TotalPrice.Text);
                int discount = Convert.ToInt32(nud_Discount.Value);
                int finalPrice = Convert.ToInt32(totalPrice - (totalPrice * (discount * 1.0 / 100)));
                if (MessageBox.Show($"Tổng tiền ({totalPrice}đ) + Giảm giá {discount}% ({totalPrice * (discount * 1.0 / 100)}đ) = {finalPrice}đ", "Thông báo thanh toán!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    entity.UpdateBill(GetIDBill(), 1, discount, finalPrice);
                    entity.UpdateStatusTableFood(IDTableFood, 0); // update thành trống
                    Close();
                }
            }
        }
    }
}
