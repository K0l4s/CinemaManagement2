namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            VeXemPhims = new HashSet<VeXemPhim>();
            Vouchers = new HashSet<Voucher>();
        }

        [Key]
        [StringLength(30)]
        public string maHoaDon { get; set; }

        public DateTime thoiGian { get; set; }

        [Required]
        [StringLength(30)]
        public string maNhanVien { get; set; }

        [StringLength(10)]
        public string soDienThoaiKhachHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXemPhim> VeXemPhims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
