
using AutoMapper;
using Domain.Entities;
using MVC.Models;
using MVC.ViewModels;


namespace MVC.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() {

          //  CreateMap<TipoPessoa,TipoPessoaViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Imovel, ImovelViewModel>();

            // CreateMap<Pessoa, PessoaFisicaViewModel>();
            // CreateMap<Pessoa, PessoaJuridicaViewModel>();
            // CreateMap<PessoaFisica, PessoaViewModel>();
            // CreateMap<PessoaJuridica, PessoaViewModel>();

            // CreateMap<PessoaFisica, PessoaFisicaViewModel>();
            // CreateMap<PessoaJuridica, PessoaJuridicaViewModel>();

            //   CreateMap<EnderecoPessoa, EnderecoPessoaViewModel>();
            //CreateMap<EnderecoEntidade, EnderecoEntidadeViewModel>();
            //   CreateMap<Endereco, EnderecoRepositoyI>();


            //CreateMap<Endereco, EnderecoViewModel>();
            //   CreateMap<IQueryable<Endereco>, EnderecoViewModelX>();
            //   CreateMap<Endereco,IQueryable<EnderecoViewModelX>>();
            //   CreateMap<IQueryable<Endereco>, IQueryable<EnderecoViewModelX>>();
            //   CreateMap<IQueryable<Endereco>, IQueryable<IServiceViewModel<Endereco,EnderecoViewModelX>>>();







            //   CreateMap<Endereco, PaginatedList<EnderecoRepositoyI>>();
            //   CreateMap<Endereco, PaginatedList<Endereco>>();

            //CreateMap<Logradouro, LogradouroViewModel>();
            //CreateMap<TipoLogradouro, TipoLogradouroViewModel>();
            //CreateMap<PagedList<TipoLogradouro>, TipoLogradouroViewModel>();
            //CreateMap<Regiao, RegiaoViewModel>();

            //CreateMap<Estado, EstadoViewModel>();
            //CreateMap<Bairro, BairroViewModel>();
            // CreateMap<Cidade, CidadeViewModel>();
            // CreateMap<Pais, PaisViewModel>();
            //CreateMap<DDD, DDDViewModel>();
            //   CreateMap<Etapa, EtapaViewModel>();
            //  CreateMap<Etapa, AutuarViewModel>();

            // CreateMap<Notificacao2ViewModel, EtapaViewModel>();
            // CreateMap<Notificacao2ViewModel, ImovelViewModel>();
            //      CreateMap<Etapa, NotificacaoViewModel>();

            // CreateMap<Imovel, ImovelViewModel>();
            // CreateMap<TipoResponsabilidade, TipoResponsabilidadeViewModel>();

            //CreateMap<Economia, EconomiaViewModel>();

            // CreateMap<EconomiaPessoa, EconomiaPessoaViewModel>();
            /*    CreateMap<Economia, NotificacaoViewModel>();

                CreateMap<EconomiaPessoa, EconomiaPessoaViewModel>();
                CreateMap<EconomiaPessoa, NotificacaoViewModel>();
          */
                CreateMap<Etapa, EtapaViewModel>();
            //  CreateMap<Etapa, PaginatedListVC<Etapa>>();
            // CreateMap<Etapa, PaginatedListVC<EtapaViewModel>>();

            //CreateMap<IEnumerable<Etapa>, EtapaViewModel>();
            //CreateMap<IEnumerable<Etapa>, PaginatedListVC<Etapa>>();
            //CreateMap<IEnumerable<Etapa>, PaginatedListVC<EtapaViewModel>>();
            //CreateMap<PaginatedListVC<Etapa>, PaginatedListVC<EtapaViewModel>>();





            CreateMap<Processo, ProcessoViewModel>();
            CreateMap<FluxoProcesso, FluxoProcessoViewModel>();
             CreateMap<TipoProcesso, TipoProcessoViewModel>();
            //CreateMap<SituacaoProcesso, SituacaoProcessoViewModel>();
            //CreateMap<SituacaoEtapa, SituacaoEtapaViewModel>();
             CreateMap<TipoEtapa, TipoEtapaViewModel>();
            // CreateMap<Servidor, ServidorViewModel>();
            //CreateMap<Image, ImageViewModel>();
            //CreateMap<Perspectiva, PerspectivaViewModel>();
            //CreateMap<IncrementoTabelas, IncrementoTabelasViewModel>();
            //CreateMap<TextoAutuacao, TextoAutuacaoViewModel>();
            
 //                CreateMap<Processo, NotificacaoViewModel>();

   //              CreateMap<TipoProcesso, NotificacaoViewModel>();

     //            CreateMap<TipoEtapa, NotificacaoViewModel>();
     /*
                 CreateMap<SituacaoProcesso, NotificacaoViewModel>();

                 CreateMap<SituacaoEtapa, NotificacaoViewModel>();

                 CreateMap<Servidor, NotificacaoViewModel>();

                 CreateMap<IncrementoTabelas, NotificacaoViewModel>();

                 CreateMap<Image, NotificacaoViewModel>();

                 */

        }
    }
}
