using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQuanCafeK19.GUI.Food;

namespace ProjectQuanCafeK19.GUI.FoodCategory
{
    public partial class UC_FoodCategory : UserControl
    {
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public UC_FoodCategory()
        {
            InitializeComponent();
        }

        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        private void UC_FoodCategory_Load(object sender, EventArgs e)
        {
            QuanCafeK19Entities entity = new QuanCafeK19Entities();
            dgv_FoodCategory.DataSource = entity.GetListFoodCategory();
        }

        private void btn_CreateFoodCategory_Click(object sender, EventArgs e)
        {
            var formCreateFoodCategory = new FormCreateFoodCategory();
            formCreateFoodCategory.ShowDialog();
            UC_FoodCategory_Load(sender, e);
        }

        private void dgv_FoodCategory_DoubleClick(object sender, EventArgs e)
        {
            string id = dgv_FoodCategory.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgv_FoodCategory.SelectedRows[0].Cells[1].Value.ToString();

            var editFoodCategory = new FormEditFoodCategory();

            try
            {
                Image avatar = byteArrayToImage((byte[])dgv_FoodCategory.SelectedRows[0].Cells[2].Value);
                editFoodCategory.LoadEditFoodCategory(id, name, avatar);
            }
            catch (Exception)
            {
                editFoodCategory.LoadEditFoodCategoryNoAvatar(id, name);
            }

            editFoodCategory.ShowDialog();
            UC_FoodCategory_Load(sender, e);
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            dgv_FoodCategory.DataSource = entity.SearchFoodCategoryByName(tb_SearchByName.Text);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_FoodCategory_Load(sender, e);
        }
    }
}
