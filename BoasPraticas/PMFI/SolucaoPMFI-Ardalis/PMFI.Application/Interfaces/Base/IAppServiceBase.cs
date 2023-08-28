using PMFI.Domain.Interfaces.Specifications;
using System.Linq.Expressions;

namespace PMFI.Application.Interfaces.Base
{

    public interface IAppServiceBase<TEntity,TEntityViewModel> where TEntity : class where TEntityViewModel : class
        {
            public Task<TEntityViewModel> AddAsync(TEntityViewModel entityViewModel, CancellationToken cancellationToken = default);
            public Task<IEnumerable<TEntityViewModel>> AddRangeAsync(IEnumerable<TEntityViewModel> entitiesViewModel, CancellationToken cancellationToken = default);
            public Task<bool> AnyAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<bool> AnyAsync(CancellationToken cancellationToken = default);
            public Task<int> CountAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<int> CountAsync(CancellationToken cancellationToken = default);
            public Task DeleteAsync(TEntityViewModel  entityViewModel, CancellationToken cancellationToken = default);
            public Task DeleteRangeAsync(IEnumerable<TEntityViewModel> entitiesViewModel, CancellationToken cancellationToken = default);
            public Task<TEntityViewModel?> FirstOrDefaultAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default);
            public Task<TEntityViewModel?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;
            public Task<TEntityViewModel?> GetBySpecAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default);
            public Task<List<TEntityViewModel>> ListAsync(CancellationToken cancellationToken = default);
            public Task<List<TEntityViewModel>> ListAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<List<TResult>> ListAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default);
            public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
            public Task<TEntityViewModel?> SingleOrDefaultAsync(ISingleResultSpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default);
            public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default);
            public Task UpdateAsync(TEntityViewModel entityViewModel, CancellationToken cancellationToken = default);
            public Task UpdateRangeAsync(IEnumerable<TEntityViewModel> entities, CancellationToken cancellationToken = default);
    }
   
}
