namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaoDien")]
    public partial class DaoDien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaoDien()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(30)]
        public string maDaoDien { get; set; }

        [Required]
        [StringLength(72)]
        public string tenDaoDien { get; set; }

        public string moTa { get; set; }

        public byte[] anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
