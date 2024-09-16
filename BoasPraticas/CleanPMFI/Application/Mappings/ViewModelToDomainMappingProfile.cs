using AutoMapper;
using Domain.Entities;
using Application.ViewModels;
using Domain.Pagination;
using Application.ViewModels.NFSEDB;
using Domain.Entities.NFSEDB;
using Domain.Entities.MegaData;
//using Application.ViewModels.MegaData;

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



         //   CreateMap<LayoutNotasFiscais_MegaData, NfseTblNfse>();
            //CreateMap<LayoutNFSE_MegaData, NfseTblNfse>();
           // CreateMap<NFSEViewModel, NfseTblNfse>();
            ////CreateMap<MegaData_NFSE_ViewModel, MegaData_NFSE>();


            //    CreateMap<PagedResponse<CidadeViewModel>,Cidade>();
            //    CreateMap<PagedResponse<List<CidadeViewModel>>, Cidade>();
            //    CreateMap<List<CidadeViewModel>,Cidade>();
            CreateMap<ViewModels.DBProsiga.ContribuinteViewModel, Domain.Entities.DBProsiga.Contribuinte>();
            CreateMap<Domain.Entities.DBProsiga.AutoNumAnoNumero, Domain.Entities.DBProsiga.AutoNumAnoNumero>();
        }

    }
}
