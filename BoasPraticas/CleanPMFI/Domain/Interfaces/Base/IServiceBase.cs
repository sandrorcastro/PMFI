using Domain.Interfaces.Base;
using System.Linq.Expressions;

namespace Domain.Interfaces.Base
{
    public interface IServiceBase<T> :IRepositoryBase<T>  where T : class
    {
        
    }
}
