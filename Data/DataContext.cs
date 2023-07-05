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
            user.Property(x => x.Name).HasColumnName("name").IsRequired();
            user.Property(x => x.Email).HasColumnName("email").IsRequired();
        }

        public DbSet<User> Users => Set<User>();
    }
}