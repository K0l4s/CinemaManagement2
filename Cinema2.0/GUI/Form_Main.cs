using Cinema2._0.GUI;
using Cinema2._0.GUI.ToolBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCinema.NEW_GUI
{
    public partial class Form_Main : Form
    {
        bool flagSize = false;
        US_MuaVe muaVe = new US_MuaVe();
        US_QLPhim phim = new US_QLPhim();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - (this.Width / 2);
                this.Top += e.Y - (this.Height / 22);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            panelObject.Controls.Add(muaVe);
            muaVe.Dock = DockStyle.Fill;
        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (flagSize)
            {
                this.WindowState = FormWindowState.Normal;
                flagSize = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                flagSize = true;
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_MessageBox message = new Form_MessageBox("Bạn có chắc chắn thoát không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            message.ShowDialog();
            if (message.yes)
                this.Close();
        }

        private void btnCreatBill_Click(object sender, EventArgs e)
        {
            panelObject.Controls.Clear();
            panelObject.Controls.Add(muaVe);
            muaVe.Dock = DockStyle.Fill;
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            panelObject.Controls.Clear();
            panelObject.Controls.Add(phim);
            muaVe.Dock = DockStyle.Fill;
        }
    }
}
