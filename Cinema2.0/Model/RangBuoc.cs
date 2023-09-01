namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RangBuoc")]
    public partial class RangBuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string maVoucher { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string maDieuKien { get; set; }

        public string moRong { get; set; }

        public virtual DieuKienSuDung DieuKienSuDung { get; set; }

        public virtual Voucher Voucher { get; set; }
    }
}
