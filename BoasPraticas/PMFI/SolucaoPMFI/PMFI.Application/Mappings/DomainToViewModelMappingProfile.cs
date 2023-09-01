

using AutoMapper;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;

namespace PMFI.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() {

            CreateMap<Uf,UfViewModel>();
            CreateMap<Pais, PaisViewModel>();
            CreateMap<Cidade, CidadeViewModel>();


        }
    }
}
