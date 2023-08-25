
using AutoMapper;
using PMFI.Application.Interfaces;
using PMFI.Application.Services.Base;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Services;

namespace PMFI.Application.Services
{
    public class CidadeAppService : AppServiceBase<Cidade,CidadeViewModel>, ICidadeAppService
    {
        public CidadeAppService(IServiceBase<Cidade> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
