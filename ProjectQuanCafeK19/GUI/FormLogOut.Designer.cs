namespace ProjectQuanCafeK19.GUI
{
    partial class FormLogOut
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogOut));
            this.el_FormLogOut = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_LogOut = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // el_FormLogOut
            // 
            this.el_FormLogOut.ElipseRadius = 30;
            this.el_FormLogOut.TargetControl = this;
            // 
            // btn_Back
            // 
            this.btn_Back.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Back.BorderRadius = 15;
            this.btn_Back.CheckedState.Parent = this.btn_Back;
            this.btn_Back.CustomImages.Parent = this.btn_Back;
            this.btn_Back.FillColor = System.Drawing.Color.Silver;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.HoverState.Parent = this.btn_Back;
            this.btn_Back.Image = global::ProjectQuanCafeK19.Properties.Resources.back_to_480px;
            this.btn_Back.Location = new System.Drawing.Point(9, 114);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.ShadowDecoration.Parent = this.btn_Back;
            this.btn_Back.Size = new System.Drawing.Size(189, 45);
            this.btn_Back.TabIndex = 34;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderRadius = 15;
            this.btn_Exit.CheckedState.Parent = this.btn_Exit;
            this.btn_Exit.CustomImages.Parent = this.btn_Exit;
            this.btn_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.Parent = this.btn_Exit;
            this.btn_Exit.Image = global::ProjectQuanCafeK19.Properties.Resources.exit_480px;
            this.btn_Exit.Location = new System.Drawing.Point(10, 63);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Parent = this.btn_Exit;
            this.btn_Exit.Size = new System.Drawing.Size(189, 45);
            this.btn_Exit.TabIndex = 34;
            this.btn_Exit.Text = "Đóng phần mềm";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BorderColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.BorderRadius = 15;
            this.btn_LogOut.CheckedState.Parent = this.btn_LogOut;
            this.btn_LogOut.CustomImages.Parent = this.btn_LogOut;
            this.btn_LogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.btn_LogOut.HoverState.Parent = this.btn_LogOut;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(10, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.ShadowDecoration.Parent = this.btn_LogOut;
            this.btn_LogOut.Size = new System.Drawing.Size(189, 45);
            this.btn_LogOut.TabIndex = 34;
            this.btn_LogOut.Text = "Đăng xuất";
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 171);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogOut";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_LogOut;
        private Bunifu.Framework.UI.BunifuElipse el_FormLogOut;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
    }
}