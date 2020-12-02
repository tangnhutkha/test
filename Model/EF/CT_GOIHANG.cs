namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_GOIHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOPGH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MALOAIHH { get; set; }

        public byte? SoLuongHH { get; set; }

        public long? ThanhTien { get; set; }

        public virtual LOAIHANGHOA LOAIHANGHOA { get; set; }

        public virtual PHIEUGOIHANG PHIEUGOIHANG { get; set; }
    }
}
