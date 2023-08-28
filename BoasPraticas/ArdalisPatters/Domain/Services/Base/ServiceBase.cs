

using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Specification;
//using Domain.Specification;
using System;
using System.Linq.Expressions;
using System.Threading;

namespace Domain.Services.Base
{
    //public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;

        public ServiceBase(IRepositoryBase<T> _repository)
        {
            repository = _repository;
        }

        public System.Threading.Tasks.Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<Pagination.PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
