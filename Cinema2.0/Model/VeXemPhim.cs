namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeXemPhim")]
    public partial class VeXemPhim
    {
        [Required]
        [StringLength(30)]
        public string maGhe { get; set; }

        [StringLength(30)]
        public string maHoaDon { get; set; }

        [Key]
        [StringLength(30)]
        public string maVeXemPhim { get; set; }

        [Required]
        [StringLength(30)]
        public string maLichChieu { get; set; }

        public virtual Ghe Ghe { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual LichChieu LichChieu { get; set; }
    }
}
