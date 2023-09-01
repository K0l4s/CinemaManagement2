namespace Cinema2._0.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienVien")]
    public partial class DienVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DienVien()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(30)]
        public string maDienVien { get; set; }

        [Required]
        [StringLength(72)]
        public string tenDienVien { get; set; }

        public string moTa { get; set; }

        public byte[] anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
