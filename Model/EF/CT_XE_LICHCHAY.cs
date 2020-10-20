namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_XE_LICHCHAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_XE_LICHCHAY()
        {
            VEs = new HashSet<VE>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BIENSO { get; set; }

        [Required]
        [StringLength(5)]
        public string MACHUYEN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MALC { get; set; }

        public long? TienVe { get; set; }

        public virtual XE XE { get; set; }

        public virtual CHUYEN CHUYEN { get; set; }

        public virtual LICHCHAY LICHCHAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}
