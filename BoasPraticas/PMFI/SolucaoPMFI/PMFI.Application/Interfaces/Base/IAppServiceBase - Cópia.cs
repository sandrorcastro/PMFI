using PMFI.Domain.Interfaces.Specifications;
using System.Linq.Expressions;

namespace PMFI.Application.Interfaces.Base
{

    public interface IAppServiceBase<TEntity,TEntityViewModel> where TEntity : class where TEntityViewModel : class
        {
                public Task<TEntityViewModel> GetById(int id);
                public Task<TEntityViewModel> GetById(long id);

                public Task<IEnumerable<TEntityViewModel>> ListAsync();
                public Task<IEnumerable<TEntityViewModel>> ListAsync(Expression<Func<TEntity, bool>> predicate);
                public Task<IEnumerable<TEntityViewModel>> ListAsync(ISpecificationBase<TEntityViewModel> spec);
                public Task<int> AddAsync(TEntityViewModel  entityViewModel);
                public void DeleteAsync(TEntityViewModel entityViewModel);
                public Task<int> EditAsync(TEntityViewModel entityViewModel);
        }
   
}
