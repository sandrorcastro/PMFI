

using AutoMapper;
using PMFI.Application.Interfaces.Base;
using PMFI.Domain.Interfaces.Base;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Interfaces.Specifications;
using System;
using System.Linq.Expressions;

namespace PMFI.Application.Services.Base
{
    //public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    public class AppServiceBase<TEntity,TEntityViewModel> : IAppServiceBase<TEntity, TEntityViewModel> where TEntity : class where TEntityViewModel : class
    {
        private readonly IServiceBase<TEntity> serviceBase;
        private readonly IMapper  mapper;



        public AppServiceBase(IServiceBase<TEntity> _serviceBase, IMapper _mapper)
        //public AppServiceBase(IServiceBase<TEntity> _serviceBase)
        {
            serviceBase = _serviceBase;
            mapper = _mapper;
        }

        public async Task<int> AddAsync(TEntityViewModel entityViewModel)
        {
            try
            {
                var entity = mapper.Map<TEntity>(entityViewModel);
                return await serviceBase.AddAsync(entity);
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAsync(TEntityViewModel entityViewModel)
        {
            try
            {
                var entity = mapper.Map<TEntity>(entityViewModel);
                serviceBase.DeleteAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
           // serviceBase.Dispose();
        }

        public async Task<int> EditAsync(TEntityViewModel entityViewModel)
        {
            try
            {
                var entity = mapper.Map<TEntity>(entityViewModel);
                return await serviceBase.EditAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntityViewModel> GetById(int id)
        {
            try
            {
                return mapper.Map<TEntityViewModel>( await serviceBase.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async  Task<TEntityViewModel> GetById(long id)
        {
            try
            {
                return mapper.Map<TEntityViewModel>(await serviceBase.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntityViewModel>> ListAsync()
        {
            try
            {   
                return mapper.Map<IEnumerable<TEntityViewModel>>( await serviceBase.ListAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntityViewModel>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return mapper.Map<IEnumerable<TEntityViewModel>>(await serviceBase.ListAsync(predicate));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<TEntityViewModel>> ListAsync(ISpecificationBase<TEntityViewModel> spec)
        {
            throw new NotImplementedException();
        }
    }
}
