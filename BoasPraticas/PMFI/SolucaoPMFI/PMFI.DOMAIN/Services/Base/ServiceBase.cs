
using PMFI.Domain.Interfaces.Base;
using PMIFI.Domain.Interfaces.Base;
using System;
using System.Linq.Expressions;

namespace PMFI.Domain.Services.Base
{
    //public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> _repository)
        {
            repository = _repository;
        }


        public async Task<int> AddAsync(TEntity entity)
        {
            try
            {
                return await repository.AddAsync(entity);
            }catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void DeleteAsync(TEntity entity)
        {
            try
            {
               repository.DeleteAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<int> EditAsync(TEntity entity)
        {
            try
            {
                return await repository.EditAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetById(long id)
        {
            try
            {
                return await repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            try
            {
                return await repository.ListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await repository.ListAsync(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<TEntity>> ListAsync(ISpecificationBase<TEntity> spec)
        {
            throw new NotImplementedException();
        }
    }
}
