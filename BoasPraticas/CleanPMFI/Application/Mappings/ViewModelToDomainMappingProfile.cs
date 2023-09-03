using AutoMapper;
using Domain.Entities;
using Application.ViewModels;
using Domain.Pagination;

namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CidadeViewModel, Cidade>();
            CreateMap<PaisViewModel, Pais>();
            CreateMap<UfViewModel, Uf>();



            //    CreateMap<PagedResponse<CidadeViewModel>,Cidade>();
            //    CreateMap<PagedResponse<List<CidadeViewModel>>, Cidade>();
            //    CreateMap<List<CidadeViewModel>,Cidade>();
        }

    }
}
