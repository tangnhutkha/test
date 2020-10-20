namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VE")]
    public partial class VE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VE()
        {
            PHIEUGOIHANGs = new HashSet<PHIEUGOIHANG>();
        }

        [Key]
        [StringLength(10)]
        public string ID_VE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayIn { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLenXe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GioLenXe { get; set; }

        [StringLength(50)]
        public string QRCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BIENSO { get; set; }

        public int MALC { get; set; }

        [Required]
        [StringLength(10)]
        public string MAKH { get; set; }

        public virtual CT_XE_LICHCHAY CT_XE_LICHCHAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGOIHANG> PHIEUGOIHANGs { get; set; }

        public virtual TTKHACHHANG TTKHACHHANG { get; set; }
    }
}
