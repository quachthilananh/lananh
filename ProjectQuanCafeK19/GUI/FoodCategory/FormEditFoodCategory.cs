using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.FoodCategory
{
    public partial class FormEditFoodCategory : Form
    {
        public void LoadEditFoodCategory(string id, string name, Image avatar)
        {
            tb_ID.Text = id;
            tb_Name.Text = name;
            pb_Avatar.Image = avatar;
        }

        public void LoadEditFoodCategoryNoAvatar(string id, string name)
        {
            tb_ID.Text = id;
            tb_Name.Text = name;
        }

        QuanCafeK19Entities FoodCategory = new QuanCafeK19Entities();

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        #region Placeholder
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            if (tb_ID.Text == "Tên loại")
            {
                tb_ID.Text = "";
                tb_ID.ForeColor = Color.Black;
            }
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_ID.Text == "")
            {
                tb_ID.Text = "Tên loại";
                tb_ID.ForeColor = Color.Silver;
            }
        }
        #endregion

        public FormEditFoodCategory()
        {
            InitializeComponent();
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
                byte[] avatar = ImageToByteArray(pb_Avatar.Image);

                FoodCategory.UpdateFoodCategory(id, name, avatar);

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
                FoodCategory.DeleteFoodCategory(id);
                MessageBox.Show("Xoá thành công!", "Thông báo!", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
