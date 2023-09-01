namespace ProjectCinema.NEW_GUI
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelObject = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnCreatBill = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnZoom);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 39);
            this.panel2.TabIndex = 3;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnZoom
            // 
            this.btnZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoom.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnZoom.ErrorImage")));
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.Location = new System.Drawing.Point(1220, 0);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(30, 39);
            this.btnZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnZoom.TabIndex = 3;
            this.btnZoom.TabStop = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1250, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelObject
            // 
            this.panelObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelObject.Location = new System.Drawing.Point(250, 39);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(1030, 681);
            this.panelObject.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btnFilm);
            this.panelMenu.Controls.Add(this.btnCreatBill);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 81);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 81);
            this.button6.TabIndex = 6;
            this.button6.Text = "Khách Hàng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 81);
            this.button4.TabIndex = 4;
            this.button4.Text = "Chuc Nang 01";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 81);
            this.button3.TabIndex = 3;
            this.button3.Text = "Chuc Nang 01";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Chuc Nang 01";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.Transparent;
            this.btnFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnFilm.Image")));
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.Location = new System.Drawing.Point(0, 81);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(250, 81);
            this.btnFilm.TabIndex = 1;
            this.btnFilm.Text = "Quản Lý Phim";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnCreatBill
            // 
            this.btnCreatBill.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreatBill.FlatAppearance.BorderSize = 0;
            this.btnCreatBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatBill.Font = new System.Drawing.Font("#9Slide03 AllRoundGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreatBill.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatBill.Image")));
            this.btnCreatBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatBill.Location = new System.Drawing.Point(0, 0);
            this.btnCreatBill.Name = "btnCreatBill";
            this.btnCreatBill.Size = new System.Drawing.Size(250, 81);
            this.btnCreatBill.TabIndex = 0;
            this.btnCreatBill.Text = "Tạo Hóa Đơn";
            this.btnCreatBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatBill.UseVisualStyleBackColor = false;
            this.btnCreatBill.Click += new System.EventHandler(this.btnCreatBill_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCreatBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.PictureBox btnZoom;
    }
}