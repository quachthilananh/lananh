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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
            cpb_Loading.Percentage = 0;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            cpb_Loading.Percentage += 2;
            if (cpb_Loading.Percentage >= 100)
            {
                timerLoading.Stop();
                this.Hide();
                var formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}
