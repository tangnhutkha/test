namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUYEN")]
    public partial class CHUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYEN()
        {
            CT_XE_LICHCHAY = new HashSet<CT_XE_LICHCHAY>();
            LOTRINHs = new HashSet<LOTRINH>();
        }

        [Key]
        [StringLength(5)]
        public string MACHUYEN { get; set; }

        [StringLength(50)]
        public string TENCHUYEN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioDi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioDen { get; set; }

        public decimal? SoKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_XE_LICHCHAY> CT_XE_LICHCHAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTRINH> LOTRINHs { get; set; }
    }
}
