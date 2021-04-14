using DevIQ.Core.Interfaces;
using Ardalis.Specification;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIQ.Infrastructure.Data;

namespace DevIQ.Core.Infrastructure.Data
{
    /// <inheritdoc/>
   /* public class CachedCustomerRepository<T> : IReadRepository<T> where T : class, IAggregateRoot
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<CachedCustomerRepository<T>> _logger;
        private readonly MyRepository<T> _sourceRepository;
        private MemoryCacheEntryOptions _cacheOptions;

        public CachedCustomerRepository(IMemoryCache cache,
            ILogger<CachedCustomerRepository<T>> logger,
            MyRepository<T> sourceRepository)
        {
            _cache = cache;
            _logger = logger;
            _sourceRepository = sourceRepository;

            _cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(relative: TimeSpan.FromSeconds(10));
        }


        /// <inheritdoc/>
        public Task<T> GetByIdAsync(int id)
        {
            return _sourceRepository.GetByIdAsync(id);
        }

        /// <inheritdoc/>
        public Task<T> GetByIdAsync<TId>(TId id)
        {
            return _sourceRepository.GetByIdAsync(id);
        }

        /// <inheritdoc/>
        public Task<T> GetBySpecAsync<Spec>(Spec specification) where Spec : ISingleResultSpecification, ISpecification<T>
        {
            if (specification.CacheEnabled)
            {
                string key = $"{specification.CacheKey}-GetBySpecAsync";
                _logger.LogInformation("Checking cache for " + key);
                return _cache.GetOrCreate(key, entry =>
                {
                    entry.SetOptions(_cacheOptions);
                    _logger.LogWarning("Fetching source data for " + key);
                    return _sourceRepository.GetBySpecAsync(specification);
                });
            }
            return _sourceRepository.GetBySpecAsync(specification);
        }


        /// <inheritdoc/>
        public Task<List<T>> ListAsync()
        {
            string key = $"{nameof(T)}-ListAsync";
            return _cache.GetOrCreate(key, entry =>
            {
                entry.SetOptions(_cacheOptions);
                return _sourceRepository.ListAsync();
            });
        }


        /// <inheritdoc/>
        public Task<List<TResult>> ListAsync<TResult>(Ardalis.Specification.ISpecification<T, TResult> specification)
        {
            if (specification.CacheEnabled)
            {
                string key = $"{specification.CacheKey}-ListAsync";
                _logger.LogInformation("Checking cache for " + key);
                return _cache.GetOrCreate(key, entry =>
                {
                    entry.SetOptions(_cacheOptions);
                    _logger.LogWarning("Fetching source data for " + key);
                    return _sourceRepository.ListAsync(specification);
                });
            }
            return _sourceRepository.ListAsync(specification);
        }

        Task<int> IReadRepositoryBase<T>.CountAsync(ISpecification<T> specification)
        {
            return _sourceRepository.CountAsync(specification);

        }

        Task<T> IReadRepositoryBase<T>.GetByIdAsync<TId>(TId id)
        {
            throw new NotImplementedException();
        }

        Task<T> IReadRepositoryBase<T>.GetBySpecAsync<Spec>(Spec specification)
        {
            throw new NotImplementedException();
        }

        Task<TResult> IReadRepositoryBase<T>.GetBySpecAsync<TResult>(ISpecification<T, TResult> specification)
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IReadRepositoryBase<T>.ListAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IReadRepositoryBase<T>.ListAsync(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }

        Task<List<TResult>> IReadRepositoryBase<T>.ListAsync<TResult>(ISpecification<T, TResult> specification)
        {
            throw new NotImplementedException();
        }
    }*/
}