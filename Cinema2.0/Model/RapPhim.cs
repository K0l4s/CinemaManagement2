namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RapPhim")]
    public partial class RapPhim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RapPhim()
        {
            Ghes = new HashSet<Ghe>();
            LichChieux = new HashSet<LichChieu>();
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [StringLength(30)]
        public string maRap { get; set; }

        [Required]
        [StringLength(50)]
        public string tenRap { get; set; }

        [StringLength(30)]
        public string maLoaiRap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ghe> Ghes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }

        public virtual loaiRap loaiRap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
