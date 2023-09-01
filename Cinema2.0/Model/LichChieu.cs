namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichChieu")]
    public partial class LichChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichChieu()
        {
            VeXemPhims = new HashSet<VeXemPhim>();
        }

        [Required]
        [StringLength(30)]
        public string maPhim { get; set; }

        [Required]
        [StringLength(30)]
        public string maRapPhim { get; set; }

        [Key]
        [StringLength(30)]
        public string maLichChieu { get; set; }

        public TimeSpan thoiGianBatDau { get; set; }

        public TimeSpan thoiGianKetThuc { get; set; }
        public DateTime ngayChieu { get; set; }

        public virtual Phim Phim { get; set; }

        public virtual RapPhim RapPhim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXemPhim> VeXemPhims { get; set; }
    }
}
