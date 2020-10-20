namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SODOGHE")]
    public partial class SODOGHE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASDG { get; set; }

        [StringLength(50)]
        public string TENSDG { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINH_SDG { get; set; }

        [Required]
        [StringLength(10)]
        public string BIENSO { get; set; }

        public virtual XE XE { get; set; }
    }
}
