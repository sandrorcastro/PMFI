using AutoMapper;
using Domain.Entities;
using Application.ViewModels;
using Domain.Pagination;
using Application.ViewModels.NFSEDB;
using Domain.Entities.NFSEDB;

namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CidadeViewModel, Cidade>();
            CreateMap<PaisViewModel, Pais>();
            CreateMap<UfViewModel, Uf>();
            CreateMap<LogradouroViewModel, Logradouro>();
            CreateMap<TipoLogradouroViewModel, TipoLogradouro>();
            CreateMap<TribAlvDocumentoViewModel, TribAlvDocumento>();



            CreateMap<LayoutNotasFiscais_MegaData, NfseTblNfse>();


            //    CreateMap<PagedResponse<CidadeViewModel>,Cidade>();
            //    CreateMap<PagedResponse<List<CidadeViewModel>>, Cidade>();
            //    CreateMap<List<CidadeViewModel>,Cidade>();
        }

    }
}
