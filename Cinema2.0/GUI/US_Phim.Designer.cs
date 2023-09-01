namespace Cinema2._0.GUI
{
    partial class US_Phim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Phim));
            this.poster = new System.Windows.Forms.PictureBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIn4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayKhoiChieu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtDoTuoi = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.panelIn4.SuspendLayout();
            this.SuspendLayout();
            // 
            // poster
            // 
            this.poster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster.ErrorImage = ((System.Drawing.Image)(resources.GetObject("poster.ErrorImage")));
            this.poster.Image = ((System.Drawing.Image)(resources.GetObject("poster.Image")));
            this.poster.Location = new System.Drawing.Point(0, 0);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(300, 474);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster.TabIndex = 0;
            this.poster.TabStop = false;
            this.poster.MouseEnter += new System.EventHandler(this.poster_MouseEnter);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(212, 444);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 8;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            // 
            // panelIn4
            // 
            this.panelIn4.BackColor = System.Drawing.Color.White;
            this.panelIn4.Controls.Add(this.label8);
            this.panelIn4.Controls.Add(this.label7);
            this.panelIn4.Controls.Add(this.label6);
            this.panelIn4.Controls.Add(this.dtpNgayKhoiChieu);
            this.panelIn4.Controls.Add(this.label5);
            this.panelIn4.Controls.Add(this.label4);
            this.panelIn4.Controls.Add(this.label3);
            this.panelIn4.Controls.Add(this.label2);
            this.panelIn4.Controls.Add(this.txtMoTa);
            this.panelIn4.Controls.Add(this.txtThoiLuong);
            this.panelIn4.Controls.Add(this.txtDoTuoi);
            this.panelIn4.Controls.Add(this.txtTenPhim);
            this.panelIn4.Controls.Add(this.txtMaPhim);
            this.panelIn4.Location = new System.Drawing.Point(10, 12);
            this.panelIn4.Name = "panelIn4";
            this.panelIn4.Size = new System.Drawing.Size(277, 425);
            this.panelIn4.TabIndex = 10;
            this.panelIn4.MouseLeave += new System.EventHandler(this.panelIn4_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mô Tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thời lượng:";
            // 
            // dtpNgayKhoiChieu
            // 
            this.dtpNgayKhoiChieu.Location = new System.Drawing.Point(13, 178);
            this.dtpNgayKhoiChieu.Name = "dtpNgayKhoiChieu";
            this.dtpNgayKhoiChieu.Size = new System.Drawing.Size(252, 22);
            this.dtpNgayKhoiChieu.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày Khởi Chiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Độ Tuổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Phim:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(15, 267);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(250, 141);
            this.txtMoTa.TabIndex = 24;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(15, 223);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(211, 22);
            this.txtThoiLuong.TabIndex = 23;
            // 
            // txtDoTuoi
            // 
            this.txtDoTuoi.Location = new System.Drawing.Point(15, 133);
            this.txtDoTuoi.Name = "txtDoTuoi";
            this.txtDoTuoi.Size = new System.Drawing.Size(250, 22);
            this.txtDoTuoi.TabIndex = 22;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(15, 88);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(250, 22);
            this.txtTenPhim.TabIndex = 21;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(15, 44);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(250, 22);
            this.txtMaPhim.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xem Trailer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Chi Tiết";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // US_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelIn4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.poster);
            this.Name = "US_Phim";
            this.Size = new System.Drawing.Size(300, 474);
            this.Load += new System.EventHandler(this.US_Phim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.panelIn4.ResumeLayout(false);
            this.panelIn4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIn4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtDoTuoi;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
