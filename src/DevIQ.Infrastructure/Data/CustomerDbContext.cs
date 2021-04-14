using DevIQ.Core.Entities;
using Microsoft.EntityFrameworkCore;
using DevIQ.Infrastructure.Data.Config;

namespace DevIQ.Infrastructure.Data
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new StoreConfiguration());
        }
    }
}
