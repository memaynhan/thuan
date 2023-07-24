using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DE_01.NewFolder1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<LOPP> LOPPs { get; set; }
        public virtual DbSet<SINHH_VIEN> SINHH_VIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOPP>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHH_VIEN>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHH_VIEN>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
