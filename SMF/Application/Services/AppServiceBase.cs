
using Application.Interfaces.Base;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    //public class AppServiceBase<TEntity> :  IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }
        public TEntity GetById(long id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IQueryable<TEntity> GetTodos()
        {
            
                return _serviceBase.GetTodos();

            
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetTodos().Where(predicate).AsQueryable();
        }

        public TEntity GetRelacoes(Func<TEntity, bool> predicate)
        {
            return _serviceBase.GetRelacoes(predicate);
        }

        public TEntity Find(Func<TEntity, bool> predicate)
        {
            return _serviceBase.Find(predicate);
        }   
        public TEntity Find(params object[] key)
        {
            return _serviceBase.Find(key);
        }

        public void SalvarTodos()
        {
            _serviceBase.SalvarTodos();
        }

        public void Remove(Func<TEntity, bool> predicate)
        {
            _serviceBase.Remove(predicate);
        }
        

    }
}
