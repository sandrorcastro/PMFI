using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;
using Domain.Specifications;
using System;
using System.Linq.Expressions;

namespace Domain.Services.Base
{
    
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;

        public ServiceBase(IRepositoryBase<T> _repository)
        {
            repository = _repository;
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.AddAsync(entity, cancellationToken);
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.AddRangeAsync(entities, cancellationToken);
        }

        public Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.AnyAsync(specification, cancellationToken);
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return repository.AnyAsync(cancellationToken);
        }

        public IAsyncEnumerable<T> AsAsyncEnumerable(ISpecification<T> specification)
        {
            return repository.AsAsyncEnumerable(specification);
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.CountAsync(specification, cancellationToken);
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return repository.CountAsync(cancellationToken) ;
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.DeleteAsync(entity, cancellationToken);
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.DeleteRangeAsync(entities, cancellationToken);
        }

        public Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.FirstOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.FirstOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return repository.GetByIdAsync<TId>(id, cancellationToken);
        }

        public Task<T?> GetBySpecAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.GetByIdAsync(specification, cancellationToken);
        }

        public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.GetBySpecAsync<TResult>(specification, cancellationToken);
        }

        public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return repository.ListAsync(cancellationToken);
        }

        public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.ListAsync(specification, cancellationToken);
        }

        public Task<List<TResult>> ListAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.ListAsync<TResult>(specification, cancellationToken);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return repository.SaveChangesAsync(cancellationToken);
        }

        public Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.SingleOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.SingleOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.UpdateAsync(entity, cancellationToken);
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.UpdateRangeAsync(entities, cancellationToken);
        }
    }
}
