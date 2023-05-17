using Domain.Entities;
using Domain.Interfaces.Base;
using System;

namespace Domain.Services
{
     public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    //public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public IQueryable<TEntity> GetIQueryable()
        {
            try
            {
                return _repository.GetIQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IQueryable<TEntity> GetIQueryable(Func<TEntity, bool> predicate)
        {
            return _repository.GetIQueryable(predicate);
            
        }
        public IQueryable<TEntity> GetIQueryable(params object[] key)
        {
            return _repository.GetIQueryable(key);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public TEntity GetById(long id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
        /////////////////////////

        public IQueryable<TEntity> GetById()
        {
            return _repository.GetById();
        }
        public IQueryable<TEntity> GetById(Func<TEntity, bool> predicate)
        {
            return _repository.GetById(predicate);
        }
        public IQueryable<TEntity> GetById(params object[] key)
        {
            //return (IQueryable<TEntity>)contexto.Set<TEntity>().Find(key);
            return _repository.GetById(key);
        }
        public IQueryable<TEntity> GetTodos()
        {
            try
            {
                return _repository.GetTodos();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            try
            {
                return GetTodos().Where(predicate).AsQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TEntity GetRelacoes(Func<TEntity, bool> predicate)
        {
            try
            {
                return _repository.GetRelacoes(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TEntity Find(Func<TEntity, bool> predicate)
        {
            try
            {
                return _repository.Find(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Find(params object[] key)
        {
            try
            {

                return _repository.Find(key);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        public void SalvarTodos()
        {
            try
            {

                _repository.SalvarTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        public void Remove(Func<TEntity, bool> predicate)
        {
            try
            {

                _repository.Remove(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    
}
}
