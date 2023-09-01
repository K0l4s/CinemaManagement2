using Cinema2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.GUI
{
    public partial class US_Phim : UserControl
    {
        public Phim phim { get; set; }
        public US_Phim()
        {
            InitializeComponent();
            panelIn4.Visible = false;
            
        }

        private void poster_MouseEnter(object sender, EventArgs e)
        {
            if (panelIn4.Visible == false)
                panelIn4.Visible = true;
        }


        private void US_Phim_Load(object sender, EventArgs e)
        {
            txtMaPhim.Text = phim.maPhim;
            txtDoTuoi.Text = phim.DoTuoi.maDoTuoi.ToString();
            txtMoTa.Text = phim.moTa;
            txtTenPhim.Text = phim.tenPhim;
            txtThoiLuong.Text = phim.thoiLuong.ToString();
            dtpNgayKhoiChieu.Value = phim.khoiChieu;
        }

        private void panelIn4_MouseLeave(object sender, EventArgs e)
        {

            if (panelIn4.Visible)
                panelIn4.Visible = false;
        }
    }
}
