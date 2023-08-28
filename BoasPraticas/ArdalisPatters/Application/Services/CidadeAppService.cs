using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Application.Services;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class CidadeAppService : AppServiceBase<Cidade,CidadeViewModel>, ICidadeAppService
    {
        public CidadeAppService(IServiceBase<Cidade> _serviceBase,IMapper mapper) : base(_serviceBase,mapper)
        {
        }
    }
}
