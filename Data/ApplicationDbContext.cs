using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Order> Order { get; set; }
     public DbSet<Purchase> Purchase { get; set; }
   
    }

   
}
