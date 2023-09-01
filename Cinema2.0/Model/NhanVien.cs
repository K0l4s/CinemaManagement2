namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            NhanVien1 = new HashSet<NhanVien>();
            RapPhims = new HashSet<RapPhim>();
        }

        [Key]
        [StringLength(30)]
        public string maNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string soDienThoai { get; set; }

        [Required]
        [StringLength(72)]
        public string hoVaTen { get; set; }

        [Required]
        [StringLength(12)]
        public string canCuoc { get; set; }

        public DateTime ngaySinh { get; set; }

        [Required]
        public string diaChi { get; set; }

        [Required]
        [StringLength(40)]
        public string queQuan { get; set; }

        [StringLength(30)]
        public string quanLy { get; set; }

        [Required]
        [StringLength(30)]
        public string maChucVu { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanVien1 { get; set; }

        public virtual NhanVien NhanVien2 { get; set; }

        public virtual TaiKhoanNV TaiKhoanNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapPhim> RapPhims { get; set; }
    }
}
