
using Application.ViewModels;
using Application.ViewModels.NFSEDB;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Pagination;

namespace Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() {

          //  CreateMap<TipoPessoa,TipoPessoaViewModel>();
            CreateMap<Cidade, CidadeViewModel>();
            CreateMap<Pais, PaisViewModel>();
            CreateMap<Uf, UfViewModel>();
            CreateMap<Logradouro, LogradouroViewModel>();
            CreateMap<TipoLogradouro, TipoLogradouroViewModel>();
            CreateMap<TribAlvDocumento, TribAlvDocumentoViewModel>();



            CreateMap<NfseTblNfse, LayoutNotasFiscais_MegaData>();
            CreateMap<NfseTblNfse, NFSEViewModel>();


        }
    }
}
