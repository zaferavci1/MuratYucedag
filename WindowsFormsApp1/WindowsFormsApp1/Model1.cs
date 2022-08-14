using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Kategory> Kategories { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategory>()
                .HasMany(e => e.Urunlers)
                .WithOptional(e => e.Kategory)
                .HasForeignKey(e => e.Kategory_KetgoryId);
        }
    }
}
