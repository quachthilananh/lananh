namespace ProjectQuanCafeK19.GUI.TableFood
{
    partial class UC_TableFood
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_TableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.flp_TableFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_TableFood
            // 
            this.flp_TableFood.AutoScroll = true;
            this.flp_TableFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.flp_TableFood.Controls.Add(this.guna2GradientTileButton1);
            this.flp_TableFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_TableFood.Location = new System.Drawing.Point(0, 0);
            this.flp_TableFood.Name = "flp_TableFood";
            this.flp_TableFood.Size = new System.Drawing.Size(728, 696);
            this.flp_TableFood.TabIndex = 0;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderRadius = 20;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(180, 180);
            this.guna2GradientTileButton1.TabIndex = 0;
            this.guna2GradientTileButton1.Text = "Có người";
            // 
            // UC_TableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_TableFood);
            this.Name = "UC_TableFood";
            this.Size = new System.Drawing.Size(728, 696);
            this.Load += new System.EventHandler(this.UC_TableFood_Load);
            this.flp_TableFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_TableFood;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
    }
}
