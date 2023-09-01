


using AutoMapper;
using PMFI.Application.ViewModels;
using PMFI.Domain.Entities;

namespace PMFI.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UfViewModel, Uf>();
            CreateMap<PaisViewModel, Pais>();
            CreateMap<CidadeViewModel, Cidade>();


        }

    }
}
