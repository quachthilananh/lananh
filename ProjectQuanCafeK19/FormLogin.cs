using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Moveable no-border
        int mouseDownX, mouseDownY;
        bool mouseDown;
        private void pl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        private void pl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseDownX, MousePosition.Y - mouseDownY);
            }
        }

        private void pl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region Placeholder text
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
        #endregion

        private void pb_Minimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void pb_Shutdown_Click(object sender, EventArgs e) => Application.Exit();

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                tb_Password.Focus();
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                bn_Login.PerformClick();
        }

        public static int CurrentUser = 0; // 1: quản lý, 0: nhân viên

        private void lb_Login_Click(object sender, EventArgs e)
        {

        }

        private void bn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Username.Focus();
            }
            if (string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Password.Focus();
            }
            try
            {
                using (var entity = new QuanCafeK19Entities())
                {
                    List<int> lst = entity.LoginAccount(tb_Username.Text, tb_Password.Text).Select(i => i.GetValueOrDefault(0)).ToList();
                    foreach (var item in lst)
                    {
                        if (item == 1)
                        {
                            CurrentUser = 1;
                            var formMain = new FormMain();
                            Hide();
                            formMain.ShowDialog();
                            Show();
                            if (chk_SaveAccount.Checked == false)
                            {
                                tb_Username.Text = "Tên tài khoản";
                                tb_Username.ForeColor = Color.Silver;
                                tb_Password.Text = "Password";
                                tb_Password.ForeColor = Color.Silver;
                            }
                        }
                        else if (item == 0)
                        {
                            var formMain = new FormMain();
                            Hide();
                            formMain.ShowDialog();
                            Show();
                            if (chk_SaveAccount.Checked == false)
                            {
                                tb_Username.Text = "Tên tài khoản";
                                tb_Username.ForeColor = Color.Silver;
                                tb_Password.Text = "Password";
                                tb_Password.ForeColor = Color.Silver;
                            }
                            CurrentUser = 0;
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
