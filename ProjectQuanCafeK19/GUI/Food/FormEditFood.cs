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
    public partial class FormEditFood : Form
    {
        QuanCafeK19Entities Food = new QuanCafeK19Entities();

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public FormEditFood()
        {
            InitializeComponent();
        }

        void LoadComboBoxFoodCategory()
        {
            cb_FoodCategory.DataSource = Food.GetListFoodCategory();
            cb_FoodCategory.DisplayMember = "Tên_loại";
            cb_FoodCategory.ValueMember = "Mã_loại";
        }

        public void LoadEditFood(int id, string name, string nameFoodCategory, int cost, int price, int count, Image avatar)
        {
            tb_ID.Text = id.ToString();
            tb_Name.Text = name;
            LoadComboBoxFoodCategory();
            cb_FoodCategory.Text = nameFoodCategory;
            nud_Cost.Value = cost;
            nud_Price.Value = price;
            nud_Count.Value = count;
            pb_Avatar.Image = avatar;
        }

        public void LoadEditFoodNoAvatar(int id, string name, string nameFoodCategory, int cost, int price, int count)
        {
            tb_ID.Text = id.ToString();
            tb_Name.Text = name;
            LoadComboBoxFoodCategory();
            cb_FoodCategory.Text = nameFoodCategory;
            nud_Cost.Value = cost;
            nud_Price.Value = price;
            nud_Count.Value = count;
        }

        #region Placeholder
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            if (tb_ID.Text == "Tên thực phẩm")
            {
                tb_ID.Text = "";
                tb_ID.ForeColor = Color.Black;
            }
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_ID.Text == "")
            {
                tb_ID.Text = "Tên thực phẩm";
                tb_ID.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_ID.Text);
                string name = tb_Name.Text;
                int idFoodCategory = Convert.ToInt32(cb_FoodCategory.SelectedValue);
                int cost = Convert.ToInt32(nud_Cost.Value);
                int price = Convert.ToInt32(nud_Price.Value);
                int count = Convert.ToInt32(nud_Count.Value);
                byte[] avatar = ImageToByteArray(pb_Avatar.Image);

                Food.UpdateFood(id, name, idFoodCategory, cost, price, count, avatar);

                MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_ID.Text);
                Food.DeleteFood(id);
                MessageBox.Show("Xoá thành công!", "Thông báo!", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
