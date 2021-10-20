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
    public partial class FormCreateFoodCategory : Form
    {
        #region Placeholder
        private void tb_Name_Enter(object sender, EventArgs e)
        {
            if (tb_Name.Text == "Tên loại")
            {
                tb_Name.Text = "";
                tb_Name.ForeColor = Color.Black;
            }
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                tb_Name.Text = "Tên loại";
                tb_Name.ForeColor = Color.Silver;
            }
        }
        #endregion

        QuanCafeK19Entities FoodCategory = new QuanCafeK19Entities();

        public FormCreateFoodCategory()
        {
            InitializeComponent();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_Name.Text;                
                byte[] avatar = ImageToByteArray(pb_Avatar.Image);

                FoodCategory.InsertFoodCategory(name, avatar);

                MessageBox.Show("Thêm loại thực phẩm thành công!", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm loại thực phẩm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
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
