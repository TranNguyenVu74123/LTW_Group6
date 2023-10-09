namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaHH { get; set; }

<<<<<<< HEAD
        public int? SoLuong { get; set; }
=======
        public int SoLuong { get; set; }
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47

        public virtual HoaDon HoaDon { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
