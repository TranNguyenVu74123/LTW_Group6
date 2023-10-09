namespace CNPM.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanLyTK")]
    public partial class QuanLyTK
    {
        [Key]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(10)]
        public string MK { get; set; }
    }
}
