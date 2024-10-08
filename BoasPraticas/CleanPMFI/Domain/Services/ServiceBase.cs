﻿using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;
using Domain.Pagination;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq.Expressions;

using Domain.Interfaces.Base;
namespace Domain.Services.Base
{
    
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;
        private readonly IServiceScopeFactory scopeFactory;

        public ServiceBase(IRepositoryBase<T> _repository)
        {
            repository = _repository;
        }
        public ServiceBase(IServiceScopeFactory _scopeFactory)
        {
            scopeFactory = _scopeFactory;
        }
        protected async Task<TResult> ExecuteInScopeAsync<TResult>(Func<DbContext, Task<TResult>> action)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DbContext>();
                return await action(context);
            }
        }
        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.AddAsync(entity, cancellationToken);
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.AddRangeAsync(entities, cancellationToken);
        }

        public Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.AnyAsync(specification, cancellationToken);
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return repository.AnyAsync(cancellationToken);
        }

        public IAsyncEnumerable<T> AsAsyncEnumerable(ISpecification<T> specification)
        {
            return repository.AsAsyncEnumerable(specification);
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.CountAsync(specification, cancellationToken);
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return repository.CountAsync(cancellationToken) ;
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.DeleteAsync(entity, cancellationToken);
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.DeleteRangeAsync(entities, cancellationToken);
        }

        public Task<T?> FindAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return repository.FindAsync<TId>(id, cancellationToken);
        }

        public Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.FirstOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.FirstOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return repository.GetByIdAsync<TId>(id, cancellationToken);
        }

        public Task<T?> GetBySpecAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            //return repository.GetByIdAsync(specification, cancellationToken);
            return repository.GetBySpecAsync(specification, cancellationToken);
        }

        public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.GetBySpecAsync<TResult>(specification, cancellationToken);
        }

    /*    public Task<T?> GetBySpecAsync(Expression<Func<T, bool>> specification, CancellationToken cancellationToken = default)
        {
            return repository.GetBySpecAsync(specification, cancellationToken);
        }*/

        public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return repository.ListAsync(cancellationToken);
        }

        public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.ListAsync(specification, cancellationToken);
        }

        public Task<List<TResult>> ListAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.ListAsync<TResult>(specification, cancellationToken);
        }

        public async Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await repository.ProjectToFirstOrDefaultAsync<TResult>(specification, cancellationToken); 
        }

        public async Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await repository.ProjectToListAsync<TResult>(specification, cancellationToken);
        }

        public async Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken)
        {
            //return await repository.ProjectToListAsync<TResult>(specification, filter, cancellationToken);
            return await repository.ProjectToListAsync<TResult>(specification, filter, cancellationToken);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return repository.SaveChangesAsync(cancellationToken);
        }

        public Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default)
        {
            return repository.SingleOrDefaultAsync(specification, cancellationToken);
        }

        public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            return repository.SingleOrDefaultAsync<TResult>(specification, cancellationToken);
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            return repository.UpdateAsync(entity, cancellationToken);
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            return repository.UpdateRangeAsync(entities, cancellationToken);
        }
        public async Task<DbSet<T>> GetDbSet() {
            return await  repository.GetDbSet();
        }


    }
}
