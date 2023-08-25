
using AutoMapper;
using PMFI.Application.Interfaces;
using PMFI.Application.Services.Base;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Services;

namespace PMFI.Application.Services
{
    public class PaisAppService : AppServiceBase<Pais,PaisViewModel>, IPaisAppService
    {
        public PaisAppService(IServiceBase<Pais> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
