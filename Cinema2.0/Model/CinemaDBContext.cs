using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cinema2._0.Model
{
    public partial class CinemaDBContext : DbContext
    {
        public CinemaDBContext()
            : base("name=CinemaDBContext")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<DaoDien> DaoDiens { get; set; }
        public virtual DbSet<DienVien> DienViens { get; set; }
        public virtual DbSet<DieuKienSuDung> DieuKienSuDungs { get; set; }
        public virtual DbSet<DonGia> DonGias { get; set; }
        public virtual DbSet<DoTuoi> DoTuois { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichChieu> LichChieux { get; set; }
        public virtual DbSet<LoaiGhe> LoaiGhes { get; set; }
        public virtual DbSet<loaiRap> loaiRaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<RangBuoc> RangBuocs { get; set; }
        public virtual DbSet<RapPhim> RapPhims { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanKH> TaiKhoanKHs { get; set; }
        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<VeXemPhim> VeXemPhims { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.maChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.tenChucVu)
                .IsFixedLength();

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CongTy>()
                .Property(e => e.maCongTy)
                .IsUnicode(false);

            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.CongTies)
                .Map(m => m.ToTable("SanXuat").MapLeftKey("maCongTy").MapRightKey("maPhim"));

            modelBuilder.Entity<DaoDien>()
                .Property(e => e.maDaoDien)
                .IsUnicode(false);

            modelBuilder.Entity<DaoDien>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.DaoDiens)
                .Map(m => m.ToTable("QuayPhim").MapLeftKey("maDaoDien").MapRightKey("maPhim"));

            modelBuilder.Entity<DienVien>()
                .Property(e => e.maDienVien)
                .IsUnicode(false);

            modelBuilder.Entity<DienVien>()
                .HasMany(e => e.Phims)
                .WithMany(e => e.DienViens)
                .Map(m => m.ToTable("ThamGia").MapLeftKey("maDienVien").MapRightKey("maPhim"));

            modelBuilder.Entity<DieuKienSuDung>()
                .Property(e => e.maDieuKien)
                .IsUnicode(false);

            modelBuilder.Entity<DieuKienSuDung>()
                .HasMany(e => e.RangBuocs)
                .WithRequired(e => e.DieuKienSuDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonGia>()
                .Property(e => e.maLoaiGhe)
                .IsUnicode(false);

            modelBuilder.Entity<DonGia>()
                .Property(e => e.maLoaiRap)
                .IsUnicode(false);

            modelBuilder.Entity<DoTuoi>()
                .Property(e => e.maDoTuoi)
                .IsUnicode(false);

            modelBuilder.Entity<DoTuoi>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.DoTuoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ghe>()
                .Property(e => e.maGhe)
                .IsUnicode(false);

            modelBuilder.Entity<Ghe>()
                .Property(e => e.tenGhe)
                .IsFixedLength();

            modelBuilder.Entity<Ghe>()
                .Property(e => e.maRap)
                .IsUnicode(false);

            modelBuilder.Entity<Ghe>()
                .Property(e => e.maLoaiGhe)
                .IsUnicode(false);

            modelBuilder.Entity<Ghe>()
                .HasMany(e => e.VeXemPhims)
                .WithRequired(e => e.Ghe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.maHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.soDienThoaiKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.Vouchers)
                .WithMany(e => e.HoaDons)
                .Map(m => m.ToTable("ApDung").MapLeftKey("maHoaDon").MapRightKey("maVoucher"));

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.soDienThoaiKhachHang);

            modelBuilder.Entity<KhachHang>()
                .HasOptional(e => e.TaiKhoanKH)
                .WithRequired(e => e.KhachHang);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.maPhim)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.maRapPhim)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.maLichChieu)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .HasMany(e => e.VeXemPhims)
                .WithRequired(e => e.LichChieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiGhe>()
                .Property(e => e.maLoaiGhe)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiGhe>()
                .Property(e => e.tenLoaiGhe)
                .IsFixedLength();

            modelBuilder.Entity<LoaiGhe>()
                .HasMany(e => e.DonGias)
                .WithRequired(e => e.LoaiGhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiGhe>()
                .HasMany(e => e.Ghes)
                .WithRequired(e => e.LoaiGhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<loaiRap>()
                .Property(e => e.maLoaiRap)
                .IsUnicode(false);

            modelBuilder.Entity<loaiRap>()
                .Property(e => e.tenLoaiRap)
                .IsFixedLength();

            modelBuilder.Entity<loaiRap>()
                .HasMany(e => e.DonGias)
                .WithRequired(e => e.loaiRap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.canCuoc)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.quanLy)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanVien1)
                .WithOptional(e => e.NhanVien2)
                .HasForeignKey(e => e.quanLy);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.TaiKhoanNV)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.RapPhims)
                .WithMany(e => e.NhanViens)
                .Map(m => m.ToTable("GiamSatRap").MapLeftKey("maNhanVien").MapRightKey("maRap"));

            modelBuilder.Entity<Phim>()
                .Property(e => e.maPhim)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .Property(e => e.maDoTuoi)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .Property(e => e.trailerURL)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .HasMany(e => e.LichChieux)
                .WithRequired(e => e.Phim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phim>()
                .HasMany(e => e.TheLoais)
                .WithMany(e => e.Phims)
                .Map(m => m.ToTable("SoHuuTheLoai").MapLeftKey("maPhim").MapRightKey("maTheLoai"));

            modelBuilder.Entity<RangBuoc>()
                .Property(e => e.maVoucher)
                .IsUnicode(false);

            modelBuilder.Entity<RangBuoc>()
                .Property(e => e.maDieuKien)
                .IsUnicode(false);

            modelBuilder.Entity<RangBuoc>()
                .Property(e => e.moRong)
                .IsUnicode(false);

            modelBuilder.Entity<RapPhim>()
                .Property(e => e.maRap)
                .IsUnicode(false);

            modelBuilder.Entity<RapPhim>()
                .Property(e => e.maLoaiRap)
                .IsUnicode(false);

            modelBuilder.Entity<RapPhim>()
                .HasMany(e => e.Ghes)
                .WithRequired(e => e.RapPhim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RapPhim>()
                .HasMany(e => e.LichChieux)
                .WithRequired(e => e.RapPhim)
                .HasForeignKey(e => e.maRapPhim)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanKH>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKH>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanKH>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.maTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<VeXemPhim>()
                .Property(e => e.maGhe)
                .IsUnicode(false);

            modelBuilder.Entity<VeXemPhim>()
                .Property(e => e.maHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<VeXemPhim>()
                .Property(e => e.maVeXemPhim)
                .IsUnicode(false);

            modelBuilder.Entity<VeXemPhim>()
                .Property(e => e.maLichChieu)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.maVoucher)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .HasMany(e => e.RangBuocs)
                .WithRequired(e => e.Voucher)
                .WillCascadeOnDelete(false);
        }
    }
}
