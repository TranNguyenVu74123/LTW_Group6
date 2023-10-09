namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangTon")]
    public partial class HangTon
    {
        [Key]
        [StringLength(50)]
        public string MaHT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHT { get; set; }

        [Required]
        [StringLength(50)]
        public string DVT { get; set; }

        public double GiaNhapHang { get; set; }

        public int SLT { get; set; }

        [Required]
        [StringLength(50)]
        public string MaHH { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNCC { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual NhaCungCap1 NhaCungCap { get; set; }
    }
}
