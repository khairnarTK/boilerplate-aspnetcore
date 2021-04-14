using System;
using System.Threading.Tasks;
using DevIQ.Core.Entities.Seeds;
using Microsoft.EntityFrameworkCore;

namespace DevIQ.Infrastructure.Data
{
    public class CustomerDbContextSeed
    {
        private readonly CustomerDbContext dbContext;

        public CustomerDbContextSeed(CustomerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SeedAsync(int retry = 0)
        {
            try
            {
                dbContext.Database.Migrate();

                if (await dbContext.Customers.CountAsync() == 0)
                {
                    foreach (var customer in CustomerSeed.Seed())
                    {
                        dbContext.Customers.Add(customer);
                    }
                }

                await dbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                if (retry > 0)
                {
                    await SeedAsync(retry - 1);
                }
            }
        }
    }
}

