using Microsoft.EntityFrameworkCore;
using System;
using TC.Model;

namespace TC.Context
{
    public class TCCoreDBContext :DbContext
    {
        public static readonly object VanBanDens;

        public TCCoreDBContext(DbContextOptions<TCCoreDBContext> options): base(options)
        {
        }
        public DbSet<VanBanDens> VanBanDen { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
