namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOTRINH")]
    public partial class LOTRINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOTRINH()
        {
            CHUYENs = new HashSet<CHUYEN>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MADIEMDI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MADIMDEN { get; set; }

        public decimal? KhoangCach { get; set; }

        public virtual DIADIEM DIADIEM { get; set; }

        public virtual DIADIEM DIADIEM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYEN> CHUYENs { get; set; }
    }
}
