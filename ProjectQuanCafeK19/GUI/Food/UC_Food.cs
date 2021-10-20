using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.Food
{
    public partial class UC_Food : UserControl
    {
        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public UC_Food()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var formCreateFood = new FormCreateFood();
            formCreateFood.ShowDialog();
            UC_Food_Load(sender, e);
        }

        private void dgv_Food_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_Food.SelectedRows[0].Cells[0].Value);
            string name = dgv_Food.SelectedRows[0].Cells[1].Value.ToString();
            string nameFoodCategory = dgv_Food.SelectedRows[0].Cells[2].Value.ToString();
            int cost = Convert.ToInt32(dgv_Food.SelectedRows[0].Cells[3].Value);
            int price = Convert.ToInt32(dgv_Food.SelectedRows[0].Cells[4].Value);
            int count = Convert.ToInt32(dgv_Food.SelectedRows[0].Cells[5].Value);

            var editFood = new FormEditFood();

            try
            {
                Image avatar = byteArrayToImage((byte[])dgv_Food.SelectedRows[0].Cells[6].Value);
                editFood.LoadEditFood(id, name, nameFoodCategory, cost, price, count, avatar);
            }
            catch (Exception)
            {
                editFood.LoadEditFoodNoAvatar(id, name, nameFoodCategory, cost, price, count);
            }

            editFood.ShowDialog();
            UC_Food_Load(sender, e);
        }

        private void UC_Food_Load(object sender, EventArgs e)
        {
            dgv_Food.DataSource = entity.GetListFood();
            cb_FoodCategory.DataSource = entity.GetListFoodCategory();
            cb_FoodCategory.DisplayMember = "Tên_loại";
            cb_FoodCategory.ValueMember = "Mã_loại";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_Food_Load(sender, e);
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            dgv_Food.DataSource = entity.SearchFoodByName(tb_SearchByName.Text);
        }

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
                dgv_Food.DataSource = entity.GetListFoodByIDFoodCategory(id);
            }
        }
    }
}
