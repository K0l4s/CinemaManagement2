namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ghe")]
    public partial class Ghe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ghe()
        {
            VeXemPhims = new HashSet<VeXemPhim>();
        }

        [Key]
        [StringLength(30)]
        public string maGhe { get; set; }

        [Required]
        [StringLength(10)]
        public string tenGhe { get; set; }

        [Required]
        [StringLength(30)]
        public string maRap { get; set; }

        [Required]
        [StringLength(30)]
        public string maLoaiGhe { get; set; }

        public virtual LoaiGhe LoaiGhe { get; set; }

        public virtual RapPhim RapPhim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXemPhim> VeXemPhims { get; set; }
    }
}
