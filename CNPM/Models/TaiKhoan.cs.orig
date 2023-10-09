namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            DangKies = new HashSet<DangKy>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

<<<<<<< HEAD
        [Required] 
        [StringLength(100)]
        public string Email { get; set; } 
=======
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
>>>>>>> 75f0c27dec2f7ddd1064c30c9c7fa0f52557fa47

        [StringLength(100)]
        public string MatKhauMoi { get; set; }

        public bool? DaThayDoiMatKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKy> DangKies { get; set; }
    }
}
