namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DVVANTAI")]
    public partial class DVVANTAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DVVANTAI()
        {
            XEs = new HashSet<XE>();
        }

        [Key]
        [StringLength(10)]
        public string MADV { get; set; }

        [StringLength(50)]
        public string TENDV { get; set; }

        [StringLength(50)]
        public string TENDN { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XE> XEs { get; set; }
    }
}
