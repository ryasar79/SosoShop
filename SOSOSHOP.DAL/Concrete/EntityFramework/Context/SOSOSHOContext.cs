namespace SOSOSHOP.DAL.Concrete.EntityFramework.Context
{
    using Microsoft.EntityFrameworkCore;
	using SOSOSHOP.Entity.Concrete;
    public class SOSOSHOPContext : DbContext
    {
        public SOSOSHOPContext(DbContextOptions<SOSOSHOPContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatusCode> OrderStatusCodes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }

    }
}
