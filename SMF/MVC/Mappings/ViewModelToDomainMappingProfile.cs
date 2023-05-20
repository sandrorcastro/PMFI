
using AutoMapper;
using Domain.Entities;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
          //  CreateMap<TipoPessoaViewModel, PaginatedList<TipoPessoa>>();
          //  CreateMap<TipoPessoaViewModel, IQueryable<TipoPessoa>>();
          //  CreateMap<IEnumerable<TipoPessoaViewModel>, IQueryable<TipoPessoa>>();
//            CreateMap<TipoPessoaViewModel,TipoPessoa>();
           
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ImovelViewModel, Imovel>();
            //         CreateMap<PessoaFisicaViewModel,PessoaFisica>();
            //       CreateMap<PessoaJuridicaViewModel,PessoaJuridica>();

            //     CreateMap<PessoaViewModel, PessoaFisica>();
            //   CreateMap<PessoaViewModel, PessoaJuridica>();

            // CreateMap<PessoaFisicaViewModel, Pessoa>();
            // CreateMap<PessoaJuridicaViewModel, Pessoa>();

            //    CreateMap<EnderecoPessoaViewModel, EnderecoPessoa>();
            // CreateMap<EnderecoEntidadeViewModel, EnderecoEntidade>();
            //    CreateMap<EnderecoRepositoyI, Endereco>();

            // CreateMap<EnderecoViewModel, Endereco>();
            //            CreateMap<EnderecoViewModelX, IQueryable<Endereco>>();
            //            CreateMap<IQueryable<EnderecoViewModelX>, Endereco >();
            //            CreateMap<IQueryable<EnderecoViewModelX>, IQueryable<Endereco>>();
            //            CreateMap<IQueryable<IServiceViewModel<Endereco,EnderecoViewModelX>>, IQueryable<Endereco>>();
            //CreateMap<typeof(IServiceViewModel<>),typeof(Endereco)>();
            //CreateMap<RegiaoViewModel, Regiao>();


            //           CreateMap<PaginatedList<EnderecoRepositoyI>, Endereco>();
            //           CreateMap<PaginatedList<Endereco>, Endereco>();

            //CreateMap<BairroViewModel, Bairro>();
            // CreateMap<CidadeViewModel, Cidade>();
            // CreateMap<PaisViewModel, Pais>();
             CreateMap<LogradouroViewModel, Logradouro>();
            // CreateMap<TipoLogradouroViewModel, TipoLogradouro>();
            // CreateMap<EstadoViewModel, Estado>();
            // CreateMap<DDDViewModel, DDD>();

             CreateMap<EtapaViewModel, Etapa>();
            // CreateMap<PaginatedListVC<Etapa>,Etapa>();
            // CreateMap<PaginatedListVC<EtapaViewModel>,Etapa>();
            //CreateMap<EtapaViewModel, IEnumerable<Etapa>>();
            //CreateMap<PaginatedListVC<Etapa>, IEnumerable<Etapa>>();
            //CreateMap<PaginatedListVC<EtapaViewModel>, IEnumerable<Etapa>>();
            //CreateMap<PaginatedListVC<EtapaViewModel>, PaginatedListVC<Etapa>>();





            //  CreateMap<AutuarViewModel, Etapa>();
            // CreateMap<NotificacaoViewModel, Etapa>();

            //CreateMap<EtapaViewModel, Notificacao2ViewModel>();
            // -CreateMap<ImovelViewModel, Notificacao2ViewModel>();
            //       CreateMap<Notificacao2ViewModel, Etapa>();
            //      
            // CreateMap<ImovelViewModel, Imovel>();

            //      CreateMap<TipoResponsabilidadeViewModel, TipoResponsabilidade>();

                    CreateMap<EconomiaViewModel, Economia>();
            //      CreateMap<EconomiaPessoaViewModel,EconomiaPessoa>();
            /*     //       CreateMap<NotificacaoViewModel, Economia>();

            //            CreateMap<EconomiaPessoaViewModel, EconomiaPessoa>();
              //          CreateMap<NotificacaoViewModel, EconomiaPessoa>();

                //        CreateMap<EconomiaPessoaViewModel, EconomiaPessoa>();
                  //      CreateMap<NotificacaoViewModel, EconomiaPessoa>();
            */
            CreateMap<ProcessoViewModel, Processo>();
            CreateMap<FluxoProcessoViewModel, FluxoProcesso>();
                 CreateMap<TipoProcessoViewModel, TipoProcesso>();
            //   CreateMap<SituacaoProcessoViewModel, SituacaoProcesso>();
             CreateMap<TipoEtapaViewModel, TipoEtapa>();
            // CreateMap<SituacaoEtapaViewModel, SituacaoEtapa>();
            // CreateMap<ServidorViewModel, Servidor>();
            // CreateMap<ImageViewModel, Image>();
            // CreateMap<PerspectivaViewModel, Perspectiva>();
            //CreateMap<IncrementoTabelasViewModel, IncrementoTabelas>();
            //CreateMap<TextoAutuacaoViewModel, TextoAutuacao>();
            /*        //  CreateMap<NotificacaoViewModel, Processo>();

                      //CreateMap<NotificacaoViewModel, TipoProcesso>();

                    //  CreateMap<NotificacaoViewModel, TipoEtapa>();

                     // CreateMap<NotificacaoViewModel, SituacaoProcesso>();

                     // CreateMap<NotificacaoViewModel, SituacaoEtapa>();

                      //CreateMap<NotificacaoViewModel, Servidor>();

                     // CreateMap<NotificacaoViewModel, IncrementoTabelas>();

                     // CreateMap<NotificacaoViewModel, Image>();

                      */

        }

    }
}
