using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;
using System.Linq.Expressions;

namespace Domain.Interfaces.Base
{
    public interface IServiceBase<T> :IRepositoryBase<T>  where T : class
    {
      //  Task<List<T>> ListAsync(CancellationToken cancellationToken = default);
      //  Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);
    }
}
