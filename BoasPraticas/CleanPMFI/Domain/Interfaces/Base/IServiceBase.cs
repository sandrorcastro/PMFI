﻿using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Specifications;
using Domain.Pagination;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Domain.Interfaces.Base
{
    public interface IServiceBase<T> :IRepositoryBase<T>  where T : class
    {
        Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
        Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
        Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken);
        Task<DbSet<T>> GetDbSet();
      //  Task<TResult> ExecuteInScopeAsync<TResult>(Func<DbContext, Task<TResult>> action);
    }
}
