namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XE")]
    public partial class XE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XE()
        {
            CT_XE_LICHCHAY = new HashSet<CT_XE_LICHCHAY>();
            SODOGHEs = new HashSet<SODOGHE>();
        }

        [Key]
        [StringLength(10)]
        public string BIENSO { get; set; }

        public byte? SOCHO { get; set; }

        [Required]
        [StringLength(2)]
        public string MALX { get; set; }

        [Required]
        [StringLength(10)]
        public string MADV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_XE_LICHCHAY> CT_XE_LICHCHAY { get; set; }

        public virtual DVVANTAI DVVANTAI { get; set; }

        public virtual LOAIXE LOAIXE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SODOGHE> SODOGHEs { get; set; }
    }
}
