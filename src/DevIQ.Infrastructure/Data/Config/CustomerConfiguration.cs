using DevIQ.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIQ.Infrastructure.Data.Config
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));

            builder.Metadata.FindNavigation(nameof(Customer.Stores))
                            .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.HasKey(x => x.Id);
        }
    }
}