using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI.Account
{
    public partial class FormEditAccount : Form
    {
        public void LoadEditAccount(string username, string password, string displayName, string typeAccount, Image avatar)
        {
            tb_Username.Text = username;
            tb_Password.Text = password;
            tb_RePassword.Text = password;
            tb_DisplayName.Text = displayName;
            cb_TypeAccount.Text = typeAccount;
            pb_Avatar.Image = avatar;
        }

        public void LoadEditAccountNoAvatar(string username, string password, string displayName, string typeAccount)
        {
            tb_Username.Text = username;
            tb_Password.Text = password;
            tb_RePassword.Text = password;
            tb_DisplayName.Text = displayName;
            cb_TypeAccount.Text = typeAccount;
        }

        QuanCafeK19Entities Account = new QuanCafeK19Entities();
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public FormEditAccount()
        {
            InitializeComponent();
        }

        #region Placeholder
        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Tên tài khoản")
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.Black;
            }
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Tên tài khoản";
                tb_Username.ForeColor = Color.Silver;
            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Password")
            {
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Password";
                tb_Password.ForeColor = Color.Silver;
            }
        }

        private void tb_RePassword_Enter(object sender, EventArgs e)
        {
            if (tb_RePassword.Text == "Password")
            {
                tb_RePassword.Text = "";
                tb_RePassword.ForeColor = Color.Black;
            }
        }

        private void tb_RePassword_Leave(object sender, EventArgs e)
        {
            if (tb_RePassword.Text == "")
            {
                tb_RePassword.Text = "Password";
                tb_RePassword.ForeColor = Color.Silver;
            }
        }

        private void tb_DisplayName_Enter(object sender, EventArgs e)
        {
            if (tb_DisplayName.Text == "Tên hiển thị")
            {
                tb_DisplayName.Text = "";
                tb_DisplayName.ForeColor = Color.Black;
            }
        }

        private void tb_DisplayName_Leave(object sender, EventArgs e)
        {
            if (tb_DisplayName.Text == "")
            {
                tb_DisplayName.Text = "Tên hiển thị";
                tb_DisplayName.ForeColor = Color.Silver;
            }
        }
        #endregion

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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_Username.Text;
                Account.DeleteAccount(username);
                MessageBox.Show("Xoá tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá tài khoản thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_Username.Text;
                string password = tb_Password.Text;
                string rePassword = tb_RePassword.Text;
                string displayName = tb_DisplayName.Text;
                int typeAccount = (cb_TypeAccount.Text == "Quản lý") ? 1 : 0;
                byte[] avatar = ImageToByteArray(pb_Avatar.Image);

                if (password != rePassword)
                {
                    MessageBox.Show("Mật khẩu và Nhập lại mật khẩu khác nhau!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Account.UpdateAccount(username, password, displayName, typeAccount, avatar);

                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
