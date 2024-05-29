
using Application.ViewModels;

using Application.ViewModels.MegaData;
using Application.ViewModels.NFSEDB;
using AutoMapper;
using Domain.Entities;

using Domain.Entities.MegaData;
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


            CreateMap<NfseTblNfse, LayoutNFSE_MegaData>();
            CreateMap<NfseTblNfse, LayoutNotasFiscais_MegaData>();
            CreateMap<NfseTblNfse, NFSEViewModel>();
            CreateMap<MegaData_NFSE, MegaData_NFSE_ViewModel>();

            

            CreateMap<Domain.Entities.DBProsiga.TribEdificaco, ViewModels.DBProsiga.TribEdificacoesViewModel>();
            CreateMap<Domain.Entities.DBProsiga.AutoNumAnoNumero, Domain.Entities.DBProsiga.AutoNumAnoNumero>();





        }
    }
}
