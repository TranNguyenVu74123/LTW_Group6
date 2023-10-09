using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CNPM.Model1
{
    public partial class HangHoaDBContext : DbContext
    {
        public HangHoaDBContext()
            : base("name=Model15")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HangTon> HangTons { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhaCungCap1> NhaCungCaps { get; set; }
        public virtual DbSet<QuanLyTK> QuanLyTKs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuanLyTK>()
                .Property(e => e.MK)
                .IsFixedLength();
        }
    }
}
