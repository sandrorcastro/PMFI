using Domain.Entities;
using Application.Services;
using Application.ViewModels;
using Application.Interfaces;
using Domain.Interfaces.Services;
using AutoMapper;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class PaisAppService : AppServiceBase<Pais,PaisViewModel>, IPaisAppService
    {
        public PaisAppService(IServiceBase<Pais> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
