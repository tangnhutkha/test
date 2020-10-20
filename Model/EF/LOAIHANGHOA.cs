namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHANGHOA")]
    public partial class LOAIHANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHANGHOA()
        {
            CT_GOIHANG = new HashSet<CT_GOIHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MALOAIHH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLHH { get; set; }

        [StringLength(30)]
        public string QuyCachTinh { get; set; }

        public long? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_GOIHANG> CT_GOIHANG { get; set; }
    }
}
