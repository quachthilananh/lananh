using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQuanCafeK19.GUI.Account;

namespace ProjectQuanCafeK19
{
    public partial class UC_Account : UserControl
    {
        QuanCafeK19Entities entity = new QuanCafeK19Entities();

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public UC_Account()
        {
            InitializeComponent();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            dgv_Account.DataSource = entity.GetListAccount();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var formCreateAccount = new FormCreateAccount();
            formCreateAccount.ShowDialog();
            UC_Account_Load(sender, e);
        }

        private void dgv_Account_DoubleClick(object sender, EventArgs e)
        {
            string username = dgv_Account.SelectedRows[0].Cells[0].Value.ToString();
            string password = dgv_Account.SelectedRows[0].Cells[1].Value.ToString();
            string displayName = dgv_Account.SelectedRows[0].Cells[2].Value.ToString();
            string typeAccount = dgv_Account.SelectedRows[0].Cells[3].Value.ToString();

            var editAccount = new FormEditAccount();

            try
            {
                Image avatar = byteArrayToImage((byte[])dgv_Account.SelectedRows[0].Cells[4].Value);
                editAccount.LoadEditAccount(username, password, displayName, typeAccount, avatar);
            }
            catch (Exception)
            {
                editAccount.LoadEditAccountNoAvatar(username, password, displayName, typeAccount);
            }

            editAccount.ShowDialog();
            UC_Account_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_Account_Load(sender, e);
        }

        private void btn_SearchDisplayName_Click(object sender, EventArgs e)
        {
            dgv_Account.DataSource = entity.SearchAccountByDisplayName(tb_SearchDisplayName.Text);
        }

        private void btn_SearchUsername_Click(object sender, EventArgs e)
        {
            dgv_Account.DataSource = entity.SearchAccountByUsername(tb_SearchUsername.Text);
        }
    }
}
