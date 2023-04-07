using FptBookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FptBookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DetailOrder>().HasKey(item => new
            {
                item.OrderID,
                item.BookID
            });
            builder.Entity<DetailOrder>().HasOne(item => item.Order).WithMany(item => item.DetailOrders).HasForeignKey(item => item.OrderID);
            builder.Entity<DetailOrder>().HasOne(item => item.Book).WithMany(item => item.DetailOrders).HasForeignKey(item => item.BookID);
            base.OnModelCreating(builder);
        }
       

        public DbSet<Book> Books { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<DetailOrder> DetailOrder { get; set; }
        public DbSet<Category> Category { get; set; }
        //Setup Relationship ban phu
        
    }
}
