namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            LichChieux = new HashSet<LichChieu>();
            DaoDiens = new HashSet<DaoDien>();
            CongTies = new HashSet<CongTy>();
            TheLoais = new HashSet<TheLoai>();
            DienViens = new HashSet<DienVien>();
        }

        [Required]
        public string tenPhim { get; set; }

        [Key]
        [StringLength(30)]
        public string maPhim { get; set; }

        [Required]
        [StringLength(30)]
        public string maDoTuoi { get; set; }

        public string trailerURL { get; set; }

        public byte[] poster { get; set; }

        public DateTime khoiChieu { get; set; }

        public int thoiLuong { get; set; }

        public int thich { get; set; }

        public string moTa { get; set; }

        public virtual DoTuoi DoTuoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaoDien> DaoDiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongTy> CongTies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienVien> DienViens { get; set; }
    }
}
