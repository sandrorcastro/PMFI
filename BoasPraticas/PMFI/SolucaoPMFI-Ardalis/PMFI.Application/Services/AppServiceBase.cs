

using AutoMapper;
using PMFI.Application.Interfaces.Base;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Interfaces.Specifications;
using System;
using System.Linq.Expressions;

namespace PMFI.Application.Services
{
    //public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    public class AppServiceBase<TEntity, TEntityViewModel> : IAppServiceBase<TEntity, TEntityViewModel> where TEntity : class where TEntityViewModel : class
    {
        private readonly IServiceBase<TEntity> serviceBase;
        private readonly IMapper mapper;
        public AppServiceBase(IServiceBase<TEntity> _serviceBase, IMapper _mapper)
        {
            serviceBase = _serviceBase;
            mapper = _mapper;
        }

        public async Task<TEntityViewModel> AddAsync(TEntityViewModel entityViewModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntityViewModel>> AddRangeAsync(IEnumerable<TEntityViewModel> entitiesViewModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntityViewModel entityViewModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<TEntityViewModel> entitiesViewModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityViewModel?> FirstOrDefaultAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityViewModel?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            throw new NotImplementedException();
        }

        public Task<TEntityViewModel?> GetBySpecAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntityViewModel>> ListAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntityViewModel>> ListAsync(ISpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> ListAsync<TResult>(ISpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityViewModel?> SingleOrDefaultAsync(ISingleResultSpecification<TEntityViewModel> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<TEntityViewModel, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntityViewModel entityViewModel, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<TEntityViewModel> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
