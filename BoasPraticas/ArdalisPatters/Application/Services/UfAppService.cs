using Application.Interfaces;
using Application.Services;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class UfAppService : AppServiceBase<Uf,UfViewModel>, IUfAppService
    {
        public UfAppService(IServiceBase<Uf> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
