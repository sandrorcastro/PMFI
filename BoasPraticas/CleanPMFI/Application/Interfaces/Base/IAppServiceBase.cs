
using Domain.Pagination;
using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;

namespace Application.Interfaces.Base
{
        public interface IAppServiceBase<T> : IServiceBase<T> where T : class
        {
        Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
        Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
        Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken);
    }
   
}
