using PMFI.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PMIFI.Domain.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public Task<TEntity> GetById(int id);
        public Task<TEntity> GetById(long id);

        public Task<IEnumerable<TEntity>> ListAsync();
        public Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate);
        public Task<IEnumerable<TEntity>> ListAsync(ISpecificationBase<TEntity> spec);
        public Task<int> AddAsync(TEntity entity);
        public void DeleteAsync(TEntity entity);
        public Task<int> EditAsync(TEntity entity);
    }
}
