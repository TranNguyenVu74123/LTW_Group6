namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKy")]
    public partial class DangKy
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int TaiKhoanID { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
