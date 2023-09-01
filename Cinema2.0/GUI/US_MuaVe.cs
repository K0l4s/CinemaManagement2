using Cinema2._0.Event;
using Cinema2._0.GUI.ToolBox;
using Cinema2._0.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.GUI
{
    public partial class US_MuaVe : UserControl
    {
        Event_MuaVe ev = new Event_MuaVe();
        List<VeXemPhim> veDangChon = new List<VeXemPhim> ();
        KhachHang khachHang = new KhachHang();
        //NhanVien nhanVien = new NhanVien();
        public US_MuaVe()
        {
            InitializeComponent();
        }

        private void US_MuaVe_Load(object sender, EventArgs e)
        {
            dgvFilm.AutoGenerateColumns = false;
            List<Phim> dsPhim = ev.layDSPhim();
            dgvFilm.DataSource = dsPhim;

            cbAge.DataSource = ev.layDSDoTuoi();
            cbAge.DisplayMember = "maDoTuoi";
            cbAge.ValueMember = "maDoTuoi";

            cbPhimDangChon.DataSource = dsPhim;
            cbPhimDangChon.DisplayMember = "tenPhim";
            cbPhimDangChon.ValueMember = "maPhim";

            cbAge.Text = "";
            txtEmployeeName.Text = ev.timKiemNhanVien(txtEmployeeID.Text).hoVaTen;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            US_MuaVe_Load(null, null);
            txtFilmName.ResetText();
            txtIDPhim.ResetText();
            cbAge.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int time;
                if (!String.IsNullOrEmpty(txtTime.Text))
                    time = Int32.Parse(txtTime.Text);
                else
                    time = -1;
                dgvFilm.DataSource = ev.locPhimTheoThuocTinh(txtIDPhim.Text,txtFilmName.Text,cbAge.Text
                    ,time);
            }
            catch { }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (pannelChooseVe.Visible == false)
            {
                pannelChooseVe.Visible = true;
                pannelChoose.Enabled = false;
                dgvFilm.Enabled = false;
                panel3.Enabled = false;
                cbSuatChieu_SelectedValueChanged(null, null);
            }
        }

        private void btnClosePannel_Click(object sender, EventArgs e)
        {
            if (pannelChooseVe.Visible)
            {
                pannelChooseVe.Visible = false;
                pannelChoose.Enabled = true;
                dgvFilm.Enabled = true;
                panel3.Enabled = true;
            }
        }

        private void cbPhimDangChon_SelectedValueChanged(object sender, EventArgs e)
        {
            capNhatcbSuatChieu();   
        }
        private void capNhatcbSuatChieu()
        {
            flpSeat.Controls.Clear();
            cbSuatChieu.ResetText();
            List<LichChieu> dsLich = ev.layDSLichChieuCua(cbPhimDangChon.SelectedValue.ToString(), dtpDate.Value);
            cbSuatChieu.DataSource = dsLich;
            cbSuatChieu.DisplayMember = "thoiGianBatDau";
            cbSuatChieu.ValueMember = "maLichChieu";
        }
        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            ckALL.Visible = true;
            pannelXoaHuyVe.Visible = true;

            btnXoaVe.Enabled = false;
            ckALL.Checked = false;
            foreach (var item in flpVe.Controls)
            {
                if(item is US_VeXemPhim)
                {
                    (item as US_VeXemPhim).check.Visible = true;
                    (item as US_VeXemPhim).check.Checked = false;
                }    
            }    
        }

        private void btnHuyThaoTac_Click(object sender, EventArgs e)
        {
            ckALL.Visible = false;
            pannelXoaHuyVe.Visible = false;

            ckALL.Checked = false;
            foreach (var item in flpVe.Controls)
            {
                if (item is US_VeXemPhim)
                {
                    (item as US_VeXemPhim).check.Visible = false;
                    (item as US_VeXemPhim).check.Checked = false;
                }
            }
            btnXoaVe.Enabled = true;
        }

        private void btnXacNhanXoa_Click(object sender, EventArgs e)
        {
            ckALL.Visible = false;
            pannelXoaHuyVe.Visible = false;

            btnXoaVe.Enabled = true;

            for (int i = 0;i<flpVe.Controls.Count;i++)
            {
                if (flpVe.Controls[i] is US_VeXemPhim)
                {
                    veDangChon.Remove((flpVe.Controls[i] as US_VeXemPhim).veXemPhim);
                    flpVe.Controls.Remove(flpVe.Controls[i]);
                }    
            }    
            ckALL.Checked = false;
            foreach (var item in flpVe.Controls)
            {
                if (item is US_VeXemPhim)
                {
                    (item as US_VeXemPhim).check.Visible = false;
                    (item as US_VeXemPhim).check.Checked = false;
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            capNhatcbSuatChieu();
        }

        private void cbSuatChieu_SelectedValueChanged(object sender, EventArgs e)
        {
            flpSeat.Controls.Clear();
            if (!String.IsNullOrEmpty(cbSuatChieu.Text))
            {
                List<VeXemPhim> dsVe = ev.layDSVeCua(cbSuatChieu.SelectedValue.ToString());
                foreach (var item in dsVe)
                {
                    US_Seat seat = new US_Seat();
                    seat.VeXemPhim = item;
                    if (veDangChon.Contains(item))
                    {
                        seat.choose = true;
                        seat.flag = false;
                    }
                    else
                    {
                        seat.choose = false;
                        seat.flag = true;
                    }
                    flpSeat.Controls.Add(seat);
                }
            }
            else
            {
                Label text = new Label();
                text.Text = "Không có dữ liệu!";
                flpSeat.Controls.Add(text);
            }
        }

        private void btnChonXong_Click(object sender, EventArgs e)
        {
            if (pannelChooseVe.Visible)
            {
                pannelChooseVe.Visible = false;
                pannelChoose.Enabled = true;
                dgvFilm.Enabled = true;
                panel3.Enabled= true;   
            }

            for (int i=0;i<flpSeat.Controls.Count;i++)
            {
                if (flpSeat.Controls[i] is US_Seat)
                {
                    US_Seat seat = (flpSeat.Controls[i] as US_Seat);
                    int count = 0;
                    foreach (var item in veDangChon)
                    {
                        if (item.maVeXemPhim == seat.VeXemPhim.maVeXemPhim)
                            break;
                        count++;
                    }
                    if (seat.choose && count == veDangChon.Count)
                    {
                        veDangChon.Add(seat.VeXemPhim);
                        US_VeXemPhim ve = new US_VeXemPhim(seat.VeXemPhim);
                        flpVe.Controls.Add(ve);
                    }
                }
            }
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            btnClosePannel_Click(null, null);
        }

        private void ckALL_CheckedChanged(object sender, EventArgs e)
        {
            if(ckALL.Checked == true)
            {
                foreach(var item in flpVe.Controls)
                {
                    if(item is US_VeXemPhim) 
                    {
                        (item as US_VeXemPhim).check.Checked = true;
                    }
                }    
            }    
        }

        private void flpVe_ControlAdded(object sender, ControlEventArgs e)
        {
            capNhatTien();
        }

        private void flpVe_ControlRemoved(object sender, ControlEventArgs e)
        {
            capNhatTien();
        }
        private void capNhatTien()
        {
            double sum = 0;
            foreach (var item in veDangChon)
            {
                sum += ev.layBangGia(item.Ghe);
            }
            txtTong.Text = sum.ToString();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pannelTien.Visible = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += 0;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "00";
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "000";
        }
        private void btn0000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "0000";
        }
        private void btn00000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "00000";
        }
        private void btn000000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "000000";
        }
        private void btn0000000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "0000000";
        }
        private void btn00000000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "00000000";
        }

        private void btn000000000_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTien.Text))
                txtTien.Text += "000000000";
        }
        
        
        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, ngăn việc nhập bằng cách xóa ký tự đó
                e.Handled = true;
            }
        }

        private void txtTien_Click(object sender, EventArgs e)
        {
            if (pannelTien.Visible == false)
                this.pannelTien.Visible = true;
        }

        private void txtTien_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTien.Text, out decimal number))
            {
                txtTien.Text = number.ToString("#,##0"); // Định dạng số thành định dạng tiền tệ với 2 số thập phân
                txtTien.SelectionStart = txtTien.Text.Length; // Di chuyển con trỏ về cuối TextBox
            }
            tinhTienThua();
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTong.Text, out decimal number))
            {
                txtTong.Text = number.ToString("#,##0"); // Định dạng số thành định dạng tiền tệ với 2 số thập phân
            }
            tinhTienThua();
        }

        private void txtThua_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtThua.Text, out decimal number))
            {
                txtThua.Text = number.ToString("#,##0"); // Định dạng số thành định dạng tiền tệ với 2 số thập phân
            }
        }
        private void tinhTienThua()
        {
            if (decimal.TryParse(txtTong.Text, out decimal tong) && decimal.TryParse(txtTien.Text, out decimal tien))
            {
                decimal tienThua = tien - tong;

                if (tienThua >= 0)
                {
                    // Hiển thị tiền thừa
                    txtThua.Text = tienThua.ToString("#,##0");
                }
                else
                {
                    // Hiển thị thông báo không đủ tiền
                    txtThua.Text = "Không đủ tiền";
                }

            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, ngăn việc nhập bằng cách xóa ký tự đó
                e.Handled = true;
            }
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            pannelLuuHuy.Visible = true;
            btnAddCus.Enabled = false;
            btnCheckCus.Enabled = false;
            btnClearCus.Enabled = false;
            txtCusName.ReadOnly = false;
        }
        private void btnHuyThemKH_Click(object sender, EventArgs e)
        {
            pannelLuuHuy.Visible = false;
            btnAddCus.Enabled = true;
            btnCheckCus.Enabled = true;
            btnClearCus.Enabled = true;
            txtCusName.ReadOnly = true;
        }
        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            pannelLuuHuy.Visible = false;
            btnAddCus.Enabled = true;
            btnCheckCus.Enabled = true;
            btnClearCus.Enabled = true;
            txtCusName.ReadOnly = true;

            KhachHang khachHangMoi = new KhachHang();
            khachHangMoi.hoTen = txtCusName.Text;
            khachHangMoi.soDienThoai = txtSDT.Text;
            khachHangMoi.ngayDangKy = DateTime.Today;
            bool flag = ev.themKhachHangMoi(khachHangMoi);
            if(flag)
            {
                Form_MessageBox message = new Form_MessageBox("Thêm thành công khách hàng "+txtCusName.Text
                    +" với số điện thoại "+txtSDT.Text + " vào hệ thống!", "Accepted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                message.ShowDialog();
                khachHang = khachHangMoi;
            }
            else
            {
                txtSDT.ResetText();
                txtCusName.ResetText();
            }    
        }
        private void btnCheckCus_Click(object sender, EventArgs e)
        {
            khachHang = ev.timKhachHang(txtSDT.Text);
            if(khachHang == null) 
            {
                Form_MessageBox message = new Form_MessageBox("Không tìm thấy khách hàng!"
                    ,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                message.ShowDialog();
            }
            else
            {
                string hoVaTen = khachHang.hoTen;
                txtCusName.Text = hoVaTen;
                Form_MessageBox message = new Form_MessageBox("Tìm thấy khách hàng " +hoVaTen +" trong hệ thống!"
                    , "Accept!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                message.ShowDialog();
            }    
        }

        private void btnClearCus_Click(object sender, EventArgs e)
        {
            khachHang = null;
            txtSDT.ResetText();
            txtCusName.ResetText();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtThua.Text) && txtThua.Text != "Không đủ tiền")
            {
                btnThanhCong.Enabled = true;

                pannelChooseVe.Visible = false;
                pannelTien.Visible = false;
                pannelLuuHuy.Visible = false;
                pannelXoaHuyVe.Visible = false;

                dgvFilm.Enabled = false;
                btnXacNhan.Enabled = false;
                btnHuyDon.Enabled = false;
                panel1.Enabled = false;
                panel5.Enabled = false;
                panel3.Enabled = false;
            }
            else
            {
                Form_MessageBox message = new Form_MessageBox("Không thể lập được hóa đơn, xin hãy thử lại!",
                    "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                message.ShowDialog();
            }    

        }

        private void btnThanhCong_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            DateTime now = DateTime.Now;
            string maHoaDon;
            hoaDon.soDienThoaiKhachHang = null;
            maHoaDon = khachHang.soDienThoai;
            hoaDon.soDienThoaiKhachHang = khachHang.soDienThoai;
            maHoaDon = maHoaDon + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond / 10;

            hoaDon.maHoaDon = maHoaDon;
            hoaDon.thoiGian = now;
            hoaDon.maNhanVien = txtEmployeeID.Text;

            bool flag = ev.taoHoaDon(hoaDon);
            foreach(var item in veDangChon)
            {
                flag = ev.chuyenTrangThaiVe(item,maHoaDon);
            }
            if (flag)
            {
                Form_MessageBox message = new Form_MessageBox("Hoàn tất thanh toán đơn hàng!",
                    "Accepted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                message.ShowDialog();
                btnHuyDon_Click(null, null);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            btnThanhCong.Enabled = false;

            dgvFilm.Enabled = true;
            btnXacNhan.Enabled = true;
            btnHuyDon.Enabled = true;
            panel1.Enabled = true;
            panel5.Enabled = true;
            panel3.Enabled = true;
            khachHang = new KhachHang();

            txtCusName.ResetText();
            txtSDT.ResetText();
            txtTong.ResetText();
            txtTien.ResetText();
            txtThua.ResetText();

            flpVe.Controls.Clear();
            veDangChon.Clear();
            flpSeat.Controls.Clear();
        }
    }
}
