
using Domain.Interfaces.Base;

namespace Application.Interfaces.Base
{
        public interface IAppServiceBase<T> : IServiceBase<T> where T : class
        {
                
        }
   
}
