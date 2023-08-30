
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Pagination;

namespace Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() {

          //  CreateMap<TipoPessoa,TipoPessoaViewModel>();
            CreateMap<Cidade, CidadeViewModel>();
            CreateMap<Cidade, PagedResponse<CidadeViewModel>>();
            CreateMap<Cidade, PagedResponse<List<CidadeViewModel>>>();
            CreateMap<Cidade, List<CidadeViewModel>>();

        }
    }
}
