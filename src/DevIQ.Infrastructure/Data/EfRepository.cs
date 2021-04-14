using DevIQ.Core.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;

namespace DevIQ.Infrastructure.Data
{
    /// <inheritdoc/>
    /// public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    public class EfRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IAggregateRoot
    {
        private readonly CustomerDbContext _dbContext;

        public EfRepository(CustomerDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

    }
}