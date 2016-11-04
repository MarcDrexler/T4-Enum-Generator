using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstSqlVs.Models
{
    public class SampleContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<UniqueClass> UniqueClasses { get; set; }
        public DbSet<LanguageString> LanguageStrings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=T4EnumGenerator.EfCodeFirstSqlVs.SampleDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set unique indexes
            modelBuilder.Entity<Parent>()
                .HasIndex(b => b.Name)
                .IsUnique();

            modelBuilder.Entity<UniqueClass>()
                .HasIndex(b => b.Id)
                .IsUnique();
        }
    }
}
