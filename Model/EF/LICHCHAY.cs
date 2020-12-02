namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHCHAY")]
    public partial class LICHCHAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHCHAY()
        {
            CT_XE_LICHCHAY = new HashSet<CT_XE_LICHCHAY>();
        }

        [Key]
        public int MALC { get; set; }

        [StringLength(100)]
        public string TENLC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApDungTuNgay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DenNgay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_XE_LICHCHAY> CT_XE_LICHCHAY { get; set; }
    }
}
