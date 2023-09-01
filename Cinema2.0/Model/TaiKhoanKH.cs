namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanKH")]
    public partial class TaiKhoanKH
    {
        [Key]
        [StringLength(10)]
        public string soDienThoai { get; set; }

        [Required]
        [StringLength(30)]
        public string matKhau { get; set; }

        [StringLength(75)]
        public string email { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
