using Application.Interfaces;
using AutoMapper;
using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Specification;

namespace Application.Services
{
    //public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class 
    {
        private readonly IServiceBase<T> serviceBase;
        private readonly IMapper  mapper;



        //public AppServiceBase(IServiceBase<T> _serviceBase, IMapper _mapper)
        public AppServiceBase(IServiceBase<T> _serviceBase)
        {
            serviceBase = _serviceBase;
            //mapper = _mapper;
        }

        public async Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await serviceBase.ProjectToFirstOrDefaultAsync<TResult>(specification, cancellationToken).ConfigureAwait(false);
        }

        public async Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await serviceBase.ProjectToListAsync<TResult>(specification, cancellationToken);
        }

        public async Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken)
        {

           
        }
    }
}
