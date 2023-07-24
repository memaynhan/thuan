namespace DE_01.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPP")]
    public partial class LOPP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string TenLop { get; set; }
    }
}
