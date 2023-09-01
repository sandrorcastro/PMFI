using Application.Interfaces.Base;
using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;
using Domain.Pagination;

namespace Application.Services.Base
{

    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> serviceBase;
        public AppServiceBase(IServiceBase<T> _serviceBase)
        {
            serviceBase = _serviceBase;
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            return serviceBase.AddAsync(entity, cancellationToken);
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return serviceBase.AddRangeAsync(entities, cancellationToken);
        }

        public Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.AnyAsync(specification, cancellationToken);
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return serviceBase.AnyAsync(cancellationToken);
        }

        public IAsyncEnumerable<T> AsAsyncEnumerable(ISpecification<T> specification)
        {
            return serviceBase.AsAsyncEnumerable(specification);
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.CountAsync(specification, cancellationToken);
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return serviceBase.CountAsync(cancellationToken) ;
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            return serviceBase.DeleteAsync(entity, cancellationToken);
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return serviceBase.DeleteRangeAsync(entities, cancellationToken);
        }

        public Task<T?> FindAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return serviceBase.FindAsync<TId>(id, cancellationToken);
        }

        public Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.FirstOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.FirstOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return serviceBase.GetByIdAsync<TId>(id, cancellationToken);
        }

        public Task<T?> GetBySpecAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.GetBySpecAsync(specification, cancellationToken);
        }

        public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.GetBySpecAsync<TResult>(specification, cancellationToken);
        }

        public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return serviceBase.ListAsync(cancellationToken);
        }

        public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.ListAsync(specification, cancellationToken);
        }

        public Task<List<TResult>> ListAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.ListAsync<TResult>(specification, cancellationToken);
        }

        public async Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await serviceBase.ProjectToFirstOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public async Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await serviceBase.ProjectToListAsync<TResult>(specification, cancellationToken);
        }

        public async Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken)
        {
            return await serviceBase.ProjectToListAsync<TResult>(specification,filter, cancellationToken);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return serviceBase.SaveChangesAsync(cancellationToken);
        }

        public Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.SingleOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return serviceBase.SingleOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            return serviceBase.UpdateAsync(entity, cancellationToken);
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return serviceBase.UpdateRangeAsync(entities, cancellationToken);   
        }
    }
}
