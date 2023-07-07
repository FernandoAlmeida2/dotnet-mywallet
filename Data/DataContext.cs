using dotnet_mywallet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mywallet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = modelBuilder.Entity<User>();
            user.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            user.Property(x => x.Name).HasColumnName("name").IsRequired();
            user.Property(x => x.Email).HasColumnName("email").IsRequired();
            user.Property(x => x.CreatedAt).HasColumnName("createdAt").IsRequired();

            var record = modelBuilder.Entity<Record>();
            record.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            record.Property(x => x.Amount).HasColumnName("amount").IsRequired();
            record.Property(x => x.Type).HasColumnName("type").IsRequired();
            record.Property(x => x.CreatedAt).HasColumnName("createdAt").IsRequired();
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Record> Records => Set<Record>(); 
    }
}