using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Application.Services;
using Domain.Interfaces.Base;

namespace Application.Services
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        public CidadeAppService(IServiceBase<Cidade> _serviceBase) : base(_serviceBase)
        {
        }
    }
}
