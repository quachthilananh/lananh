using ProjectQuanCafeK19.GUI;
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
    public partial class FormMain : Form
    {
        public static bool myActiveForm = true;

        #region Moveable no-border
        int mouseDownX, mouseDownY;
        bool mouseDown;
        private void pl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownX = e.X + this.Size.Width - pl_Top.Size.Width;
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

        public FormMain()
        {
            InitializeComponent();
            uc_Account.Hide();
            uc_FoodCategory.Hide();
            uc_Food.Hide();
            uc_TableFood.BringToFront();
            uc_Report.Hide();
            uc_Bill.Hide();
        }

        public void pb_LogOut_Click(object sender, EventArgs e)
        {
            var formLogOut = new FormLogOut();
            formLogOut.ShowDialog();
            FormMain_Load(sender, e);
        }

        public void LogOut()
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (myActiveForm == false)
            {
                Close();
            }
        }
        private void btn_Staff_Click(object sender, EventArgs e)
        {
            if (FormLogin.CurrentUser == 1)
            {
                uc_Account.Show();
                uc_Account.BringToFront();
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            uc_Food.Show();
            uc_Food.BringToFront();
        }

        private void btn_TableFood_Click(object sender, EventArgs e)
        {
            uc_TableFood.Show();
            uc_TableFood.BringToFront();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            uc_Report.Show();
            uc_Report.BringToFront();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            uc_FoodCategory.Show();
            uc_FoodCategory.BringToFront();
        }
    }
}
