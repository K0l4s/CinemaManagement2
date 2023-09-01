namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonGia")]
    public partial class DonGia
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string maLoaiGhe { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string maLoaiRap { get; set; }

        [Column("donGia")]
        public double donGia1 { get; set; }

        public virtual LoaiGhe LoaiGhe { get; set; }

        public virtual loaiRap loaiRap { get; set; }
    }
}
