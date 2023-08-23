using Microsoft.EntityFrameworkCore;
using PMFI.Domain.Interfaces.Base;
using PMFI.Infra.Context;
using PMIFI.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PMFI.Infra.Repositories.Base
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private IDbContextFactory<ApplicationDbContext> contextFactory;
        public RepositoryBase(IDbContextFactory<ApplicationDbContext> _contextFactory)
        {
            this.contextFactory = _contextFactory;
        }
        public async Task<int> AddAsync(TEntity entity)
        {
            try
            {
                    using (var context = contextFactory.CreateDbContext())
                    {
                        await context.Set<TEntity>().AddAsync(entity);
                        return await context.SaveChangesAsync();
                    }
            }catch (DbException ex)
            {
                throw ex;
            }
        }
        public void DeleteAsync(TEntity entity)
        {
            try
            {
                    using (var context = contextFactory.CreateDbContext())
                    {
                        context.Set<TEntity>().Remove(entity);
                        context.SaveChanges();
                    }
            }
            catch (DbException ex)
            {
                throw ex;
            }

        }
        public void Dispose()
        {
                contextFactory.CreateDbContext().Dispose();
        }
        public async Task<int> EditAsync(TEntity entity)
        {
            try
            {            
                    using (var context = contextFactory.CreateDbContext())
                    {
                        context.Entry(entity).State = EntityState.Modified;
                        return await context.SaveChangesAsync();
                    }
            }catch (DbException ex)
            {
                throw ex;
            }
        }
        public async Task<TEntity> GetById(int id)
        {
            try
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    return await context.Set<TEntity>().FindAsync(id);
                }
            }catch(DbException ex)
            {
                throw ex;
            }
        }
        public async Task<TEntity> GetById(long id)
        {
            try
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    return await context.Set<TEntity>().FindAsync(id);
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            try
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    return await context.Set<TEntity>().ToListAsync();
                }
            }catch( DbException ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    return await context.Set<TEntity>().Where(predicate).ToListAsync();
                }

            }catch (DbException ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<TEntity>> ListAsync(ISpecificationBase<TEntity> spec)
        {
            throw new NotImplementedException();
        }
    }
}
