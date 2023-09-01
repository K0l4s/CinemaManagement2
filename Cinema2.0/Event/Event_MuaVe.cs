using Cinema2._0.GUI.ToolBox;
using Cinema2._0.Model;
using ProjectCinema.NEW_GUI;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.Event
{
    
    public class Event_MuaVe
    {
        CinemaDBContext db = new CinemaDBContext();
        public List<Phim> layDSPhim()
        {
            return db.Phims.ToList();
        }

        public List<Phim> locPhimTheoThuocTinh(string maPhim, string tenPhim,
                                                string doTuoi, int thoiLuong)
        {
            List<Phim> dsPhim = new List<Phim>();
            foreach (var item in layDSPhim())
            {
                if( (String.IsNullOrEmpty(maPhim) ||  item.maPhim == maPhim ) 
                    && (String.IsNullOrEmpty(tenPhim) || item.tenPhim == tenPhim)
                    && (String.IsNullOrEmpty(doTuoi) || item.DoTuoi.maDoTuoi == doTuoi)
                    && (thoiLuong == -1 || item.thoiLuong == thoiLuong)
                    )
                {
                    dsPhim.Add(item);
                }    
            }
            return dsPhim;
        }
        public List<DoTuoi> layDSDoTuoi()
        {
            return db.DoTuois.ToList();
        }
        public NhanVien timKiemNhanVien(string maNV)
        {
            return db.NhanViens.Find(maNV);
        }
        public List<LichChieu> layDSLichChieuCua(string maPhim, DateTime ngayChieu )
        {
            
            List<LichChieu> dsLichChieu = new List<LichChieu>();
            foreach (var item in db.LichChieux.Where(c => c.maPhim == maPhim).ToList()) 
            {
                if (item.ngayChieu.Date == ngayChieu.Date)
                {
                    dsLichChieu.Add(item);
                }
            }
            return dsLichChieu;
        }
        public List<VeXemPhim> layDSVeCua(string maLichChieu)
        {
            return db.VeXemPhims.Where(c => c.maLichChieu == maLichChieu).ToList();
        }
        public KhachHang timKhachHang(string sdt)
        {
            return db.KhachHangs.Find(sdt);
        }
        public bool themKhachHangMoi(KhachHang khachHang)
        {
            try
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();

                TaiKhoanKH taiKhoanKH = new TaiKhoanKH();
                taiKhoanKH.soDienThoai = khachHang.soDienThoai;
                taiKhoanKH.matKhau = khachHang.soDienThoai;
                db.TaiKhoanKHs.Add(taiKhoanKH);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Form_MessageBox message = new Form_MessageBox(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                message.ShowDialog();
                return false;
            }
        }
        public double layBangGia(Ghe ghe)
        {
            string maLoaiGhe = db.Ghes.Find(ghe.maGhe).maLoaiGhe;
            string maLoaiRap = db.RapPhims.Find(ghe.maRap).maLoaiRap;
            return db.DonGias.Find(maLoaiGhe, maLoaiRap).donGia1;
        }
        public bool chuyenTrangThaiVe(VeXemPhim ve, string maHoaDon)
        {
            try
            {
                db.VeXemPhims.Find(ve.maVeXemPhim).maHoaDon = maHoaDon;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Form_MessageBox message = new Form_MessageBox(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                message.ShowDialog();
                return false;
            }
        }
        public bool taoHoaDon(HoaDon hoaDon)
        {
            try
            {
                db.HoaDons.Add(hoaDon);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Form_MessageBox message = new Form_MessageBox(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                message.ShowDialog();
                return false;
            }
        }
    }
}
