namespace DE_01.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHH VIEN")]
    public partial class SINHH_VIEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string HoTenSV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime NgaySinh { get; set; }

        public virtual LOPP LOPP { get; set; }
    }
}
