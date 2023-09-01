namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaiRap")]
    public partial class loaiRap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loaiRap()
        {
            DonGias = new HashSet<DonGia>();
            RapPhims = new HashSet<RapPhim>();
        }

        [Key]
        [StringLength(30)]
        public string maLoaiRap { get; set; }

        [Required]
        [StringLength(30)]
        public string tenLoaiRap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonGia> DonGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapPhim> RapPhims { get; set; }
    }
}
