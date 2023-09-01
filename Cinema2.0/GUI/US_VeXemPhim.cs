using Cinema2._0.Event;
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
    public partial class US_VeXemPhim : UserControl
    {
        public VeXemPhim veXemPhim { get; set; }
        Event_VeXemPhim ev = new Event_VeXemPhim();
        public CheckBox check { get { return ckbRemove; } set { ckbRemove = value; } }
        public US_VeXemPhim(VeXemPhim veXemPhim)
        {
            InitializeComponent();
            double donGia = ev.layBangGia(veXemPhim.Ghe);
            this.veXemPhim = veXemPhim;
            txtPrice.Text = donGia.ToString();
            string loaiVe = ev.layLoaiVe(veXemPhim.Ghe);
            txtLoaiVe.Text = loaiVe.ToString();
            txtTenPhim.Text = veXemPhim.LichChieu.Phim.tenPhim;
            txtMaPhong.Text = veXemPhim.LichChieu.RapPhim.tenRap;
            txtDay.Text = veXemPhim.LichChieu.ngayChieu.Day.ToString() + "/" + veXemPhim.LichChieu.ngayChieu.Month + "/"+ veXemPhim.LichChieu.ngayChieu.Year;
            txtStart.Text = veXemPhim.LichChieu.thoiGianBatDau.ToString();
            txtEnd.Text = veXemPhim.LichChieu.thoiGianKetThuc.ToString();
            txtID2.Text = veXemPhim.maVeXemPhim;
            txtID.Text = veXemPhim.maVeXemPhim;
            txtMaGhe.Text = veXemPhim.maGhe;

        }

        private void US_VeXemPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
