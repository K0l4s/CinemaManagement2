using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.GUI.ToolBox
{
    public partial class Form_MessageBox : Form
    {
        public bool yes { get; set; }
        public bool no { get; set; }
        public bool cancel { get; set; }
        public bool ok { get; set; }
        public bool abort { get; set; }
        public bool ignore { get; set; }
        public bool retry { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = false;
            no = false;
            ok = true;
            abort = false;
            ignore = false;
            retry = false;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = false;
            no = true;
            ok = false;
            abort = false;
            ignore = false;
            retry = false;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = true;
            no = false;
            ok = false;
            abort = false;
            ignore = false;
            retry = false;
            this.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = false;
            no = false;
            ok = false;
            abort = true;
            ignore = false;
            retry = false;
            this.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = false;
            no = false;
            ok = false;
            abort = false;
            ignore = false;
            retry = true;
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            cancel = false;
            yes = false;
            no = false;
            ok = false;
            abort = false;
            ignore = true;
            retry = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            yes = false;
            no = false;
            ok = false;
            abort = false;
            ignore = false;
            retry = false;
            this.Close();
        }

        public Form_MessageBox(string text, string caption = null, MessageBoxButtons? button = null, MessageBoxIcon? icon = null)
        {
            InitializeComponent();
            if (String.IsNullOrEmpty(text))
            {
                txtText.Text = "Không có thông tin để hiển thị!";
            }
            else
                txtText.Text = text;
            if (String.IsNullOrEmpty(caption))
            {
                txtCaption.Text = "MessageBox";
            }
            else
                txtCaption.Text = caption;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    {
                        Yes.Visible = false;
                        No.Visible = false;
                        Retry.Visible = false;
                        Cancel.Visible = false;
                        Abort.Visible = false;
                        OK.Visible = true;
                        Ignore.Visible = false;
                        break;
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        Yes.Visible = false;
                        No.Visible = false;
                        Retry.Visible = false;
                        Cancel.Visible = true;
                        Abort.Visible = false;
                        OK.Visible = true;
                        Ignore.Visible = false;
                        OK.Dock = DockStyle.Left;
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        Yes.Visible = false;
                        No.Visible = false;
                        Retry.Visible = true;
                        Cancel.Visible = true;
                        Abort.Visible = false;
                        OK.Visible = false;
                        Ignore.Visible = false;
                        Retry.Dock = DockStyle.Left;
                        break;
                    }
                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        Yes.Visible = false;
                        No.Visible = false;
                        Retry.Visible = true;
                        Cancel.Visible = false;
                        Abort.Visible = true;
                        OK.Visible = false;
                        Ignore.Visible = true;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        Yes.Visible = true;
                        No.Visible = true;
                        Retry.Visible = false;
                        Cancel.Visible = false;
                        Abort.Visible = false;
                        OK.Visible = false;
                        Ignore.Visible = false;
                        Yes.Dock = DockStyle.Left;
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        Yes.Visible = true;
                        No.Visible = true;
                        Retry.Visible = false;
                        Cancel.Visible = true;
                        Abort.Visible = false;
                        OK.Visible = false;
                        Ignore.Visible = false;
                        break;
                    }
                default:
                    {
                        Yes.Visible = false;
                        No.Visible = false;
                        Retry.Visible = false;
                        Cancel.Visible = false;
                        Abort.Visible = false;
                        OK.Visible = true;
                        Ignore.Visible = false;
                        break;
                    }
            }
            switch (icon)
            {
                case MessageBoxIcon.Question:
                    {
                        iconQuestion.Visible = true;
                        iconError.Visible = false;
                        iconInfor.Visible = false;
                        iconWarning.Visible = false;
                        break;
                    }
                case MessageBoxIcon.Warning:
                    {
                        iconQuestion.Visible = false;
                        iconError.Visible = false;
                        iconInfor.Visible = false;
                        iconWarning.Visible = true;
                        break;
                    }
                case MessageBoxIcon.Error:
                    {
                        iconQuestion.Visible = false;
                        iconError.Visible = true;
                        iconInfor.Visible = false;
                        iconWarning.Visible = false;
                        break;
                    }
                case MessageBoxIcon.Information:
                    {
                        iconQuestion.Visible = false;
                        iconError.Visible = false;
                        iconInfor.Visible = true;
                        iconWarning.Visible = false;
                        break;
                    }
                default:
                    {
                        iconQuestion.Visible = false;
                        iconError.Visible = false;
                        iconInfor.Visible = false;
                        iconWarning.Visible = false;
                        break;
                    }
            }

        }
        private void btnClosePannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pannelCaption_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - (this.Width / 2);
                this.Top += e.Y - (this.Height / 22);
            }
        }
    }
}
