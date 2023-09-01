
using AutoMapper;
using PMFI.Application.Interfaces;
using PMFI.Application.Services.Base;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Base;

namespace PMFI.Application.Services
{
    public class UfAppService : AppServiceBase<Uf,UfViewModel>, IUfAppService
    {
        public UfAppService(IServiceBase<Uf> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
