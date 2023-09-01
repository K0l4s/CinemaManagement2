namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoTuoi")]
    public partial class DoTuoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoTuoi()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(30)]
        public string maDoTuoi { get; set; }

        public int gioiHan { get; set; }

        public string ghiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
