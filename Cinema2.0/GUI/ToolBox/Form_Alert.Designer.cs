namespace Cinema2._0.GUI.ToolBox
{
    partial class Form_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));
            this.btnClosePannel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClosePannel
            // 
            this.btnClosePannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePannel.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClosePannel.ErrorImage")));
            this.btnClosePannel.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePannel.Image")));
            this.btnClosePannel.Location = new System.Drawing.Point(449, 12);
            this.btnClosePannel.Name = "btnClosePannel";
            this.btnClosePannel.Size = new System.Drawing.Size(39, 33);
            this.btnClosePannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosePannel.TabIndex = 8;
            this.btnClosePannel.TabStop = false;
            this.btnClosePannel.Click += new System.EventHandler(this.btnClosePannel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt.Location = new System.Drawing.Point(119, 60);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(332, 34);
            this.txt.TabIndex = 6;
            this.txt.Text = "Thao tác thành công!";
            // 
            // Form_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.Controls.Add(this.btnClosePannel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Alert";
            this.Load += new System.EventHandler(this.Form_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClosePannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt;
    }
}