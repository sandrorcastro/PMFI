
using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;

namespace Application.Interfaces.Base
{
        public interface IAppServiceBase<T> : IServiceBase<T> where T : class
        {
    //    Task<List<T>> ListAsync(CancellationToken cancellationToken = default);
    //    Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);
    }
   
}
