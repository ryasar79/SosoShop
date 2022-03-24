namespace SOSOSHOP.DAL.Concrete.EntityFramework.Context
{
    using Microsoft.EntityFrameworkCore;
    using SOSOShop.Entity.Concrete;
    public class SOSOShopContext : DbContext
    {
        public SOSOShopContext(DbContextOptions<SOSOShopContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatusCode> OrderStatusCodes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }

    }
}
