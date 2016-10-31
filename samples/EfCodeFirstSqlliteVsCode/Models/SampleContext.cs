using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstSql.Models
{
    public class SampleContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./T4EnumGenerator.EfCodeFirstSql.SampleDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // set unique indexes
            modelBuilder.Entity<Parent>()
                .HasIndex(b => b.Name)
                .IsUnique();
        }
    }
    
}
