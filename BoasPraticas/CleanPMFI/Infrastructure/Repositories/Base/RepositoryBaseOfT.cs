using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Filters;
using Domain.Interfaces.Base;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Specifications;
using Domain.Pagination;
using Infrastructure.Context;
using Infrastructure.Evaluators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading;

namespace Infrastructure.Repositories.Base;

/// <inheritdoc/>
public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly DbContext _dbContext;
   // private readonly ISpecificationEvaluator _specificationEvaluator;
    private readonly AutoMapper.IConfigurationProvider _configurationProvider;
    public  ISpecificationEvaluator Evaluator { get; }
    /*  public RepositoryBase(DbContext dbContext) : this(dbContext, SpecificationEvaluator.Default)
      {
      }*/

    /// <inheritdoc/>
    //  protected RepositoryBase(DbContext dbContext, IMapper mapper) : this(dbContext, AppSpecificationEvaluator.Instance, mapper) { }

    public RepositoryBase(DbContext dbContext)  { }
    public RepositoryBase(DbContext dbContext, IMapper mapper) : this(dbContext, SpecificationEvaluator.Default, mapper) { }

    public RepositoryBase(DbContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper)
    {
        _dbContext = dbContext;
        Evaluator = specificationEvaluator;
        _configurationProvider = mapper.ConfigurationProvider;
    }

    /// <inheritdoc/>
    public virtual async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().Add(entity);

        await SaveChangesAsync(cancellationToken);

        return entity;
    }

    /// <inheritdoc/>
    public virtual async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().AddRange(entities);

        await SaveChangesAsync(cancellationToken);

        return entities;
    }

    /// <inheritdoc/>
    public virtual async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().Update(entity);

        await SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().UpdateRange(entities);

        await SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().Remove(entity);

        await SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        _dbContext.Set<T>().RemoveRange(entities);

        await SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
    {
        return await _dbContext.Set<T>().FindAsync(new object[] { id }, cancellationToken: cancellationToken);
    }

    /// <inheritdoc/>
    [Obsolete]
    public virtual async Task<T?> GetBySpecAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    [Obsolete]
    public virtual async Task<TResult?> GetBySpecAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<T, TResult> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification).SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().ToListAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        var queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

        return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();
    }

    /// <inheritdoc/>
    public virtual async Task<List<TResult>> ListAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
    {
        var queryResult = await ApplySpecification(specification).ToListAsync(cancellationToken);

        return specification.PostProcessingAction == null ? queryResult : specification.PostProcessingAction(queryResult).ToList();
    }

    /// <inheritdoc/>
    public virtual async Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).CountAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().CountAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await ApplySpecification(specification, true).AnyAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task<bool> AnyAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().AnyAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public virtual IAsyncEnumerable<T> AsAsyncEnumerable(ISpecification<T> specification)
    {
        return ApplySpecification(specification).AsAsyncEnumerable();
    }

    /// <summary>
    /// Filters the entities  of <typeparamref name="T"/>, to those that match the encapsulated query logic of the
    /// <paramref name="specification"/>.
    /// </summary>
    /// <param name="specification">The encapsulated query logic.</param>
    /// <returns>The filtered entities as an <see cref="IQueryable{T}"/>.</returns>
    public virtual IQueryable<T> ApplySpecification(ISpecification<T> specification, bool evaluateCriteriaOnly = false)
    {

        //return await repository.ProjectToListAsync<TResult>(specification, filter, cancellationToken);
        return Evaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), specification, evaluateCriteriaOnly);
        //return Evaluator.GetQuery(_dbContext.Set<T>(), specification, evaluateCriteriaOnly);
    }

    /// <summary>
    /// Filters all entities of <typeparamref name="T" />, that matches the encapsulated query logic of the
    /// <paramref name="specification"/>, from the database.
    /// <para>
    /// Projects each entity into a new form, being <typeparamref name="TResult" />.
    /// </para>
    /// </summary>
    /// <typeparam name="TResult">The type of the value returned by the projection.</typeparam>
    /// <param name="specification">The encapsulated query logic.</param>
    /// <returns>The filtered projected entities as an <see cref="IQueryable{T}"/>.</returns>
    public virtual IQueryable<TResult> ApplySpecification<TResult>(ISpecification<T, TResult> specification)
    {
        //return _specificationEvaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), specification);
        return Evaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), specification);
        //return Evaluator.GetQuery(_dbContext.Set<T>(), specification);
    }

    public virtual async Task<T?> FindAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
    {
        return await _dbContext.Set<T>().FindAsync(new object[] { id }, cancellationToken: cancellationToken);
    }

    public async Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
    {
        return await ApplySpecification(specification).ProjectTo<TResult>(_configurationProvider).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken)
    {

        return await ApplySpecification(specification).ProjectTo<TResult>(_configurationProvider).ToListAsync(cancellationToken);


        //throw new NotImplementedException();
    }

    public async Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken)
    {
        var count = await ApplySpecification(specification).CountAsync(cancellationToken);
        var pagination = new Pagination(count, filter);
        var data = await ApplySpecification(specification).Skip(pagination.Skip).Take(pagination.Take).ProjectTo<TResult>(_configurationProvider).ToListAsync(cancellationToken);
        return new PagedResponse<TResult>(data, pagination);


        // throw new NotImplementedException();
    }
}
