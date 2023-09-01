namespace Cinema2._0.GUI.ToolBox
{
    partial class Form_MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MessageBox));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pannelCaption = new System.Windows.Forms.Panel();
            this.txtCaption = new System.Windows.Forms.Label();
            this.btnClosePannel = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Yes = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Panel();
            this.btnAbort = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Panel();
            this.btnRetry = new System.Windows.Forms.Button();
            this.Ignore = new System.Windows.Forms.Panel();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.iconInfor = new System.Windows.Forms.PictureBox();
            this.iconError = new System.Windows.Forms.PictureBox();
            this.iconQuestion = new System.Windows.Forms.PictureBox();
            this.iconWarning = new System.Windows.Forms.PictureBox();
            this.pannelCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePannel)).BeginInit();
            this.panel3.SuspendLayout();
            this.Yes.SuspendLayout();
            this.No.SuspendLayout();
            this.OK.SuspendLayout();
            this.Abort.SuspendLayout();
            this.Retry.SuspendLayout();
            this.Ignore.SuspendLayout();
            this.Cancel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 192);
            this.panel2.TabIndex = 6;
            // 
            // pannelCaption
            // 
            this.pannelCaption.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pannelCaption.Controls.Add(this.txtCaption);
            this.pannelCaption.Controls.Add(this.btnClosePannel);
            this.pannelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelCaption.Location = new System.Drawing.Point(0, 0);
            this.pannelCaption.Name = "pannelCaption";
            this.pannelCaption.Size = new System.Drawing.Size(486, 30);
            this.pannelCaption.TabIndex = 7;
            this.pannelCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pannelCaption_MouseMove);
            // 
            // txtCaption
            // 
            this.txtCaption.AutoSize = true;
            this.txtCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCaption.Location = new System.Drawing.Point(4, 4);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(66, 18);
            this.txtCaption.TabIndex = 5;
            this.txtCaption.Text = "Caption";
            // 
            // btnClosePannel
            // 
            this.btnClosePannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePannel.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClosePannel.ErrorImage")));
            this.btnClosePannel.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePannel.Image")));
            this.btnClosePannel.Location = new System.Drawing.Point(453, 0);
            this.btnClosePannel.Name = "btnClosePannel";
            this.btnClosePannel.Size = new System.Drawing.Size(30, 30);
            this.btnClosePannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosePannel.TabIndex = 4;
            this.btnClosePannel.TabStop = false;
            this.btnClosePannel.Click += new System.EventHandler(this.btnClosePannel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.Yes);
            this.panel3.Controls.Add(this.No);
            this.panel3.Controls.Add(this.OK);
            this.panel3.Controls.Add(this.Abort);
            this.panel3.Controls.Add(this.Retry);
            this.panel3.Controls.Add(this.Ignore);
            this.panel3.Controls.Add(this.Cancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 53);
            this.panel3.TabIndex = 14;
            // 
            // Yes
            // 
            this.Yes.Controls.Add(this.btnYes);
            this.Yes.Dock = System.Windows.Forms.DockStyle.Right;
            this.Yes.Location = new System.Drawing.Point(-648, 0);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(162, 53);
            this.Yes.TabIndex = 23;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Location = new System.Drawing.Point(18, 5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(127, 44);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // No
            // 
            this.No.Controls.Add(this.btnNo);
            this.No.Dock = System.Windows.Forms.DockStyle.Right;
            this.No.Location = new System.Drawing.Point(-486, 0);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(162, 53);
            this.No.TabIndex = 22;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Location = new System.Drawing.Point(18, 5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(127, 44);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // OK
            // 
            this.OK.Controls.Add(this.btnOk);
            this.OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.OK.Location = new System.Drawing.Point(-324, 0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(162, 53);
            this.OK.TabIndex = 21;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(18, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(127, 44);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Abort
            // 
            this.Abort.Controls.Add(this.btnAbort);
            this.Abort.Dock = System.Windows.Forms.DockStyle.Right;
            this.Abort.Location = new System.Drawing.Point(-162, 0);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(162, 53);
            this.Abort.TabIndex = 20;
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbort.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnAbort.FlatAppearance.BorderSize = 0;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbort.Location = new System.Drawing.Point(18, 5);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(127, 44);
            this.btnAbort.TabIndex = 12;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // Retry
            // 
            this.Retry.Controls.Add(this.btnRetry);
            this.Retry.Dock = System.Windows.Forms.DockStyle.Right;
            this.Retry.Location = new System.Drawing.Point(0, 0);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(162, 53);
            this.Retry.TabIndex = 19;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetry.Location = new System.Drawing.Point(18, 5);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(127, 44);
            this.btnRetry.TabIndex = 13;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // Ignore
            // 
            this.Ignore.Controls.Add(this.btnIgnore);
            this.Ignore.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ignore.Location = new System.Drawing.Point(162, 0);
            this.Ignore.Name = "Ignore";
            this.Ignore.Size = new System.Drawing.Size(162, 53);
            this.Ignore.TabIndex = 18;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIgnore.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnIgnore.FlatAppearance.BorderSize = 0;
            this.btnIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgnore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIgnore.Location = new System.Drawing.Point(18, 5);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(127, 44);
            this.btnIgnore.TabIndex = 14;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.UseVisualStyleBackColor = false;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // Cancel
            // 
            this.Cancel.Controls.Add(this.btnCancel);
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Location = new System.Drawing.Point(324, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(162, 53);
            this.Cancel.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(18, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 44);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtText);
            this.panel4.Controls.Add(this.iconInfor);
            this.panel4.Controls.Add(this.iconError);
            this.panel4.Controls.Add(this.iconQuestion);
            this.panel4.Controls.Add(this.iconWarning);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 109);
            this.panel4.TabIndex = 15;
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtText.Location = new System.Drawing.Point(400, 0);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(86, 109);
            this.txtText.TabIndex = 6;
            this.txtText.Text = "Không có thông tin để hiển thị!";
            this.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconInfor
            // 
            this.iconInfor.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconInfor.Image = ((System.Drawing.Image)(resources.GetObject("iconInfor.Image")));
            this.iconInfor.Location = new System.Drawing.Point(300, 0);
            this.iconInfor.Name = "iconInfor";
            this.iconInfor.Size = new System.Drawing.Size(100, 109);
            this.iconInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconInfor.TabIndex = 5;
            this.iconInfor.TabStop = false;
            // 
            // iconError
            // 
            this.iconError.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconError.Image = ((System.Drawing.Image)(resources.GetObject("iconError.Image")));
            this.iconError.Location = new System.Drawing.Point(200, 0);
            this.iconError.Name = "iconError";
            this.iconError.Size = new System.Drawing.Size(100, 109);
            this.iconError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconError.TabIndex = 4;
            this.iconError.TabStop = false;
            // 
            // iconQuestion
            // 
            this.iconQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconQuestion.Image = ((System.Drawing.Image)(resources.GetObject("iconQuestion.Image")));
            this.iconQuestion.Location = new System.Drawing.Point(100, 0);
            this.iconQuestion.Name = "iconQuestion";
            this.iconQuestion.Size = new System.Drawing.Size(100, 109);
            this.iconQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconQuestion.TabIndex = 3;
            this.iconQuestion.TabStop = false;
            // 
            // iconWarning
            // 
            this.iconWarning.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconWarning.Image = ((System.Drawing.Image)(resources.GetObject("iconWarning.Image")));
            this.iconWarning.Location = new System.Drawing.Point(0, 0);
            this.iconWarning.Name = "iconWarning";
            this.iconWarning.Size = new System.Drawing.Size(100, 109);
            this.iconWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconWarning.TabIndex = 1;
            this.iconWarning.TabStop = false;
            // 
            // Form_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(486, 192);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pannelCaption);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MessageBox";
            this.pannelCaption.ResumeLayout(false);
            this.pannelCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePannel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Yes.ResumeLayout(false);
            this.No.ResumeLayout(false);
            this.OK.ResumeLayout(false);
            this.Abort.ResumeLayout(false);
            this.Retry.ResumeLayout(false);
            this.Ignore.ResumeLayout(false);
            this.Cancel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pannelCaption;
        private System.Windows.Forms.Label txtCaption;
        private System.Windows.Forms.PictureBox btnClosePannel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Yes;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Panel No;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Panel OK;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel Abort;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Panel Retry;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Panel Ignore;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Panel Cancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.PictureBox iconInfor;
        private System.Windows.Forms.PictureBox iconError;
        private System.Windows.Forms.PictureBox iconQuestion;
        private System.Windows.Forms.PictureBox iconWarning;
    }
}