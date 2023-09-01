namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanNV")]
    public partial class TaiKhoanNV
    {
        [Key]
        [StringLength(30)]
        public string maNhanVien { get; set; }

        [Required]
        [StringLength(40)]
        public string matKhau { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
