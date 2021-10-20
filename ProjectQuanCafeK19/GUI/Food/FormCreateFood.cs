using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.Food
{
    public partial class FormCreateFood : Form
    {
        QuanCafeK19Entities Food = new QuanCafeK19Entities();

        public FormCreateFood()
        {
            InitializeComponent();
        }

        #region Placeholder
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            if (tb_Name.Text == "Tên thực phẩm")
            {
                tb_Name.Text = "";
                tb_Name.ForeColor = Color.Black;
            }
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                tb_Name.Text = "Tên thực phẩm";
                tb_Name.ForeColor = Color.Silver;
            }
        }
        #endregion

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_Name.Text;
                int idFoodCategory = Convert.ToInt32(cb_FoodCategory.SelectedValue);
                int cost = Convert.ToInt32(nud_Cost.Value);
                int price = Convert.ToInt32(nud_Price.Value);
                int count = Convert.ToInt32(nud_Count.Value);
                byte[] avatar = ImageToByteArray(pb_Avatar.Image);

                Food.InsertFood(name, idFoodCategory, cost, price, count, avatar);

                MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_Avatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Image file (*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
                if (of.ShowDialog() == DialogResult.OK)
                    pb_Avatar.Image = new Bitmap(of.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập hình ảnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCreateFood_Load(object sender, EventArgs e)
        {
            cb_FoodCategory.DataSource = Food.GetListFoodCategory();
            cb_FoodCategory.DisplayMember = "Tên_loại";
            cb_FoodCategory.ValueMember = "Mã_loại";
        }
    }
}
