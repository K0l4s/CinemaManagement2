namespace Cinema2._0.GUI
{
    partial class US_Seat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Seat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaGhe = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaGhe);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // txtMaGhe
            // 
            this.txtMaGhe.AutoSize = true;
            this.txtMaGhe.Font = new System.Drawing.Font("San Francisco Display Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGhe.Location = new System.Drawing.Point(24, 75);
            this.txtMaGhe.Name = "txtMaGhe";
            this.txtMaGhe.Size = new System.Drawing.Size(51, 27);
            this.txtMaGhe.TabIndex = 3;
            this.txtMaGhe.Text = "A01";
            this.txtMaGhe.Click += new System.EventHandler(this.txtMaGhe_Click);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(18, 8);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(64, 66);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // US_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "US_Seat";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.US_Seat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtMaGhe;
        private System.Windows.Forms.PictureBox icon;
    }
}
