namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DieuKienSuDung")]
    public partial class DieuKienSuDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DieuKienSuDung()
        {
            RangBuocs = new HashSet<RangBuoc>();
        }

        [Key]
        [StringLength(30)]
        public string maDieuKien { get; set; }

        [Required]
        public string tenDieuKien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RangBuoc> RangBuocs { get; set; }
    }
}
