using CuoiKy.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace CuoiKy.DTO
{
    public class QLSV : DbContext
    {
        public QLSV()
            : base("name=QLSV")
        {
            Database.SetInitializer(new CreateDB());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<LHP> LHPs { get; set; }
        /*public virtual DbSet<LSH> LSHes { get; set; }*/
    }

    
}