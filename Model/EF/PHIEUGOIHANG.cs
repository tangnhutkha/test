namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUGOIHANG")]
    public partial class PHIEUGOIHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUGOIHANG()
        {
            CT_GOIHANG = new HashSet<CT_GOIHANG>();
        }

        [Key]
        [StringLength(20)]
        public string SOPGH { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_VE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLapPGH { get; set; }

        public long? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GOIHANG> CT_GOIHANG { get; set; }

        public virtual VE VE { get; set; }
    }
}
