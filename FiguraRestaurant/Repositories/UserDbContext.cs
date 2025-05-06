using FiguraRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace FiguraRestaurant.Repositories
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=figuradb;Integrated Security=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
