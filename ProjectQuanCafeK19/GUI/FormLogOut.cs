using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanCafeK19.GUI
{
    public partial class FormLogOut : Form
    {
        public FormLogOut()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            FormMain.myActiveForm = false;
            Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
