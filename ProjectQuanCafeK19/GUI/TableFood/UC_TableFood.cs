using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ProjectQuanCafeK19.GUI.TableFood
{
    public partial class UC_TableFood : UserControl
    {
        public UC_TableFood()
        {
            InitializeComponent();
        }

        private void UC_TableFood_Load(object sender, EventArgs e)
        {
            flp_TableFood.Controls.Clear();

            QuanCafeK19Entities entities = new QuanCafeK19Entities();

            var data = entities.GetListTableFood();

            foreach (var item in data)
            {
                var button = new Guna2GradientTileButton
                {
                    BorderRadius = 20,
                    FillColor = Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255))))),
                    FillColor2 = Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255))))),
                    Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Image = Properties.Resources.User_Group_500px,
                    ImageSize = new Size(80, 80),
                    Location = new Point(3, 3),
                    Name = "btn_Table" + item.Mã_bàn,
                    Size = new Size(170, 170),
                    Text = item.Tên_bàn + Environment.NewLine + item.Trạng_thái
                };

                if (item.Trạng_thái == "Trống")
                {
                    button.FillColor = Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
                    button.FillColor2 = Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
                    button.Image = Properties.Resources.tableware2_500px;
                }

                flp_TableFood.Controls.Add(button);

                button.Click += Button_Click;

                button.DoubleClick += Button_DoubleClick;

                button.Tag = item;
            }
        }

        private void Button_DoubleClick(object sender, EventArgs e)
        {
            var tableFoodInfo = new FormTableFoodInfo();
            int idTableFood = ((sender as Guna2GradientTileButton).Tag as GetListTableFood_Result).Mã_bàn;
            tableFoodInfo.IDTableFood = idTableFood;
            tableFoodInfo.Status = ((sender as Guna2GradientTileButton).Tag as GetListTableFood_Result).Trạng_thái;
            tableFoodInfo.ShowDialog();
            UC_TableFood_Load(sender, e);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
