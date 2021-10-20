namespace ProjectQuanCafeK19
{
    partial class FormLoading
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
            this.elipseLoading = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cpb_Loading = new XanderUI.XUICircleProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elipseLoading
            // 
            this.elipseLoading.ElipseRadius = 30;
            this.elipseLoading.TargetControl = this;
            // 
            // cpb_Loading
            // 
            this.cpb_Loading.AnimationSpeed = 5;
            this.cpb_Loading.BackColor = System.Drawing.Color.White;
            this.cpb_Loading.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cpb_Loading.FilledColorAlpha = 130;
            this.cpb_Loading.FilledThickness = 25;
            this.cpb_Loading.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpb_Loading.IsAnimated = false;
            this.cpb_Loading.Location = new System.Drawing.Point(206, 426);
            this.cpb_Loading.Name = "cpb_Loading";
            this.cpb_Loading.Percentage = 63;
            this.cpb_Loading.ShowText = true;
            this.cpb_Loading.Size = new System.Drawing.Size(151, 145);
            this.cpb_Loading.TabIndex = 3;
            this.cpb_Loading.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cpb_Loading.TextSize = 15;
            this.cpb_Loading.UnFilledColor = System.Drawing.SystemColors.Control;
            this.cpb_Loading.UnfilledThickness = 15;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 50);
            this.label2.TabIndex = 5;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectQuanCafeK19.Properties.Resources.img4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpb_Loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elipseLoading;
        private XanderUI.XUICircleProgressBar cpb_Loading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}