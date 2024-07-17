using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Entities.NFSEDB
{
    public partial class NFSEDBContext : DbContext
    {
        public NFSEDBContext()
        {
        }

        public NFSEDBContext(DbContextOptions<NFSEDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoIncrementSequence> AutoIncrementSequences { get; set; } = null!;
        public virtual DbSet<CadastroContribuinte> CadastroContribuintes { get; set; } = null!;
        public virtual DbSet<CadastroEmpresa> CadastroEmpresas { get; set; } = null!;
        public virtual DbSet<CampoOutrasInfSemMsgTributacaoFora> CampoOutrasInfSemMsgTributacaoForas { get; set; } = null!;
        public virtual DbSet<CredenciamentoEmpresa> CredenciamentoEmpresas { get; set; } = null!;
        public virtual DbSet<Declaracao> Declaracaos { get; set; } = null!;
        public virtual DbSet<DeclaracaoSemMovimentoBaixaPendente> DeclaracaoSemMovimentoBaixaPendentes { get; set; } = null!;
        public virtual DbSet<Declaraco> Declaracoes { get; set; } = null!;
        public virtual DbSet<DeclaracoesComEncerramentosDuplicado> DeclaracoesComEncerramentosDuplicados { get; set; } = null!;
        public virtual DbSet<DesifBalanceteAnaliticoMensal> DesifBalanceteAnaliticoMensals { get; set; } = null!;
        public virtual DbSet<DesifCodigosTributacao> DesifCodigosTributacaos { get; set; } = null!;
        public virtual DbSet<DesifCodigosTributacaoMunicipio> DesifCodigosTributacaoMunicipios { get; set; } = null!;
        public virtual DbSet<DesifCosif> DesifCosifs { get; set; } = null!;
        public virtual DbSet<DesifDemApuRecTribIssqnsubtitulo> DesifDemApuRecTribIssqnsubtitulos { get; set; } = null!;
        public virtual DbSet<DesifDemonstrativoIssqnmensalRecolher> DesifDemonstrativoIssqnmensalRecolhers { get; set; } = null!;
        public virtual DbSet<DesifDemonstrativoPartidasLancamentosContabei> DesifDemonstrativoPartidasLancamentosContabeis { get; set; } = null!;
        public virtual DbSet<DesifDemonstrativoRateioResultadosInterno> DesifDemonstrativoRateioResultadosInternos { get; set; } = null!;
        public virtual DbSet<DesifEventosContabeisContasResultado> DesifEventosContabeisContasResultados { get; set; } = null!;
        public virtual DbSet<DesifIdentificacaoDeclaracao> DesifIdentificacaoDeclaracaos { get; set; } = null!;
        public virtual DbSet<DesifIdentificacaoDependencium> DesifIdentificacaoDependencia { get; set; } = null!;
        public virtual DbSet<DesifIdentificacaoServicosRemuneracaoVariavel> DesifIdentificacaoServicosRemuneracaoVariavels { get; set; } = null!;
        public virtual DbSet<DesifPlanoGeralContasComentado> DesifPlanoGeralContasComentados { get; set; } = null!;
        public virtual DbSet<DesifServicosRemuneracaoVariavel> DesifServicosRemuneracaoVariavels { get; set; } = null!;
        public virtual DbSet<DesifTarifasServicosInstituicao> DesifTarifasServicosInstituicaos { get; set; } = null!;
        public virtual DbSet<DesifTipoInstituicao> DesifTipoInstituicaos { get; set; } = null!;
        public virtual DbSet<Divergencium> Divergencia { get; set; } = null!;
        public virtual DbSet<Dividas1Real> Dividas1Reals { get; set; } = null!;
        public virtual DbSet<DividasBaixaDecSimplesIssqnretido> DividasBaixaDecSimplesIssqnretidos { get; set; } = null!;
        public virtual DbSet<DividasIssqnRetidoBaixaSimple> DividasIssqnRetidoBaixaSimples { get; set; } = null!;
        public virtual DbSet<DividasPendentesDuplicada> DividasPendentesDuplicadas { get; set; } = null!;
        public virtual DbSet<DividasPendentesRetidaNaFonteValorZero> DividasPendentesRetidaNaFonteValorZeros { get; set; } = null!;
        public virtual DbSet<DividasReplicada> DividasReplicadas { get; set; } = null!;
        public virtual DbSet<DividasTemp> DividasTemps { get; set; } = null!;
        public virtual DbSet<EmpresasBaixadasPosRevisao> EmpresasBaixadasPosRevisaos { get; set; } = null!;
        public virtual DbSet<EmpresasHomologacao> EmpresasHomologacaos { get; set; } = null!;
        public virtual DbSet<Encerramento> Encerramentos { get; set; } = null!;
        public virtual DbSet<EncerramentoDividaMaior> EncerramentoDividaMaiors { get; set; } = null!;
        public virtual DbSet<EncerramentoDividaMenor> EncerramentoDividaMenors { get; set; } = null!;
        public virtual DbSet<EncerramentoProprioComDividaMaiorQueDec> EncerramentoProprioComDividaMaiorQueDecs { get; set; } = null!;
        public virtual DbSet<EncerramentoPropriosSemDivida> EncerramentoPropriosSemDividas { get; set; } = null!;
        public virtual DbSet<EncerramentoRetidoSemDividum> EncerramentoRetidoSemDivida { get; set; } = null!;
        public virtual DbSet<EncerramentoSemDividum> EncerramentoSemDivida { get; set; } = null!;
        public virtual DbSet<EncerramentosAjustado> EncerramentosAjustados { get; set; } = null!;
        public virtual DbSet<EncerramentosAjustados10cent> EncerramentosAjustados10cents { get; set; } = null!;
        public virtual DbSet<EncerramentosAjustados5cent> EncerramentosAjustados5cents { get; set; } = null!;
        public virtual DbSet<EncerramentosNdevemGerarDivida> EncerramentosNdevemGerarDividas { get; set; } = null!;
        public virtual DbSet<GuiaAvulsa> GuiaAvulsas { get; set; } = null!;
        public virtual DbSet<GuiaAvulsaAnexo> GuiaAvulsaAnexos { get; set; } = null!;
        public virtual DbSet<ListaDividasAlterada> ListaDividasAlteradas { get; set; } = null!;
        public virtual DbSet<NfseTblAtualizaTabela> NfseTblAtualizaTabelas { get; set; } = null!;
        public virtual DbSet<NfseTblBeneficio> NfseTblBeneficios { get; set; } = null!;
        public virtual DbSet<NfseTblBoleto> NfseTblBoletos { get; set; } = null!;
        public virtual DbSet<NfseTblBoletoNfse> NfseTblBoletoNfses { get; set; } = null!;
        public virtual DbSet<NfseTblCategorium> NfseTblCategoria { get; set; } = null!;
        public virtual DbSet<NfseTblCep> NfseTblCeps { get; set; } = null!;
        public virtual DbSet<NfseTblChat> NfseTblChats { get; set; } = null!;
        public virtual DbSet<NfseTblChatUsuarioLogado> NfseTblChatUsuarioLogados { get; set; } = null!;
        public virtual DbSet<NfseTblCidade> NfseTblCidades { get; set; } = null!;
        public virtual DbSet<NfseTblCliente> NfseTblClientes { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeClasse> NfseTblCnaeClasses { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeDivisao> NfseTblCnaeDivisaos { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeGrupo> NfseTblCnaeGrupos { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeSecao> NfseTblCnaeSecaos { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeServico> NfseTblCnaeServicos { get; set; } = null!;
        public virtual DbSet<NfseTblCnaeSubclasse> NfseTblCnaeSubclasses { get; set; } = null!;
        public virtual DbSet<NfseTblConfiguracao> NfseTblConfiguracaos { get; set; } = null!;
        public virtual DbSet<NfseTblContaNota> NfseTblContaNotas { get; set; } = null!;
        public virtual DbSet<NfseTblContaSocio> NfseTblContaSocios { get; set; } = null!;
        public virtual DbSet<NfseTblContador> NfseTblContadors { get; set; } = null!;
        public virtual DbSet<NfseTblContribuinte> NfseTblContribuintes { get; set; } = null!;
        public virtual DbSet<NfseTblContribuintesBeneficio> NfseTblContribuintesBeneficios { get; set; } = null!;
        public virtual DbSet<NfseTblContum> NfseTblConta { get; set; } = null!;
        public virtual DbSet<NfseTblCredenciamento> NfseTblCredenciamentos { get; set; } = null!;
        public virtual DbSet<NfseTblCronograma> NfseTblCronogramas { get; set; } = null!;
        public virtual DbSet<NfseTblCronogramaServico> NfseTblCronogramaServicos { get; set; } = null!;
        public virtual DbSet<NfseTblDa> NfseTblDas { get; set; } = null!;
        public virtual DbSet<NfseTblDasContum> NfseTblDasConta { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoAuto> NfseTblDeclaracaoAutos { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoExtravio> NfseTblDeclaracaoExtravios { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoExtravioNfse> NfseTblDeclaracaoExtravioNfses { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoPendente> NfseTblDeclaracaoPendentes { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoSemIncidenciaNfse> NfseTblDeclaracaoSemIncidenciaNfses { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoSemIncidencium> NfseTblDeclaracaoSemIncidencia { get; set; } = null!;
        public virtual DbSet<NfseTblDeclaracaoSemMovimento> NfseTblDeclaracaoSemMovimentos { get; set; } = null!;
        public virtual DbSet<NfseTblEcfIntervencao> NfseTblEcfIntervencaos { get; set; } = null!;
        public virtual DbSet<NfseTblEcfLacre> NfseTblEcfLacres { get; set; } = null!;
        public virtual DbSet<NfseTblEcfMarca> NfseTblEcfMarcas { get; set; } = null!;
        public virtual DbSet<NfseTblEcfModelo> NfseTblEcfModelos { get; set; } = null!;
        public virtual DbSet<NfseTblEcfTipo> NfseTblEcfTipos { get; set; } = null!;
        public virtual DbSet<NfseTblEcfVersaosoftware> NfseTblEcfVersaosoftwares { get; set; } = null!;
        public virtual DbSet<NfseTblEleicaoDetalhe> NfseTblEleicaoDetalhes { get; set; } = null!;
        public virtual DbSet<NfseTblEleicaoHeader> NfseTblEleicaoHeaders { get; set; } = null!;
        public virtual DbSet<NfseTblEleicoesCandidato> NfseTblEleicoesCandidatos { get; set; } = null!;
        public virtual DbSet<NfseTblEleicoesLote> NfseTblEleicoesLotes { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresa> NfseTblEmpresas { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaCnae> NfseTblEmpresaCnaes { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaContrato> NfseTblEmpresaContratos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaContratosAnexo> NfseTblEmpresaContratosAnexos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaContratosHomologacao> NfseTblEmpresaContratosHomologacaos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaContratosNfse> NfseTblEmpresaContratosNfses { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaContratosServico> NfseTblEmpresaContratosServicos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaIncentivoFiscal> NfseTblEmpresaIncentivoFiscals { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaNaturezaOperaco> NfseTblEmpresaNaturezaOperacoes { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaPerfil> NfseTblEmpresaPerfils { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaPerfilHistorico> NfseTblEmpresaPerfilHistoricos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaRegime> NfseTblEmpresaRegimes { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaRegimeHistorico> NfseTblEmpresaRegimeHistoricos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaRelacionada> NfseTblEmpresaRelacionadas { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaServico> NfseTblEmpresaServicos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaServicoDeducao> NfseTblEmpresaServicoDeducaos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaServicoNaturezaOperacao> NfseTblEmpresaServicoNaturezaOperacaos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaSubstitutoHistorico> NfseTblEmpresaSubstitutoHistoricos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaTipoRelacao> NfseTblEmpresaTipoRelacaos { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaTipoTomadore> NfseTblEmpresaTipoTomadores { get; set; } = null!;
        public virtual DbSet<NfseTblEmpresaTributo> NfseTblEmpresaTributos { get; set; } = null!;
        public virtual DbSet<NfseTblEncerramento> NfseTblEncerramentos { get; set; } = null!;
        public virtual DbSet<NfseTblEncerramentoBoleto> NfseTblEncerramentoBoletos { get; set; } = null!;
        public virtual DbSet<NfseTblEncerramentoConta> NfseTblEncerramentoContas { get; set; } = null!;
        public virtual DbSet<NfseTblErroSemMovimento> NfseTblErroSemMovimentos { get; set; } = null!;
        public virtual DbSet<NfseTblFaq> NfseTblFaqs { get; set; } = null!;
        public virtual DbSet<NfseTblFaqGrupo> NfseTblFaqGrupos { get; set; } = null!;
        public virtual DbSet<NfseTblFaqResplike> NfseTblFaqResplikes { get; set; } = null!;
        public virtual DbSet<NfseTblFaqResposta> NfseTblFaqRespostas { get; set; } = null!;
        public virtual DbSet<NfseTblFaqUsuario> NfseTblFaqUsuarios { get; set; } = null!;
        public virtual DbSet<NfseTblFeriado> NfseTblFeriados { get; set; } = null!;
        public virtual DbSet<NfseTblFiss> NfseTblFisses { get; set; } = null!;
        public virtual DbSet<NfseTblFormHelp> NfseTblFormHelps { get; set; } = null!;
        public virtual DbSet<NfseTblFormHelpImg> NfseTblFormHelpImgs { get; set; } = null!;
        public virtual DbSet<NfseTblGrupoAcesso> NfseTblGrupoAcessos { get; set; } = null!;
        public virtual DbSet<NfseTblGrupoAcessoUsuario> NfseTblGrupoAcessoUsuarios { get; set; } = null!;
        public virtual DbSet<NfseTblHistoricoAlteraco> NfseTblHistoricoAlteracoes { get; set; } = null!;
        public virtual DbSet<NfseTblHomologacao> NfseTblHomologacaos { get; set; } = null!;
        public virtual DbSet<NfseTblHomologacaoTomador> NfseTblHomologacaoTomadors { get; set; } = null!;
        public virtual DbSet<NfseTblIncentivoFiscal> NfseTblIncentivoFiscals { get; set; } = null!;
        public virtual DbSet<NfseTblIncentivoFiscalServico> NfseTblIncentivoFiscalServicos { get; set; } = null!;
        public virtual DbSet<NfseTblLog> NfseTblLogs { get; set; } = null!;
        public virtual DbSet<NfseTblLogAcao> NfseTblLogAcaos { get; set; } = null!;
        public virtual DbSet<NfseTblLogAcaoTipo> NfseTblLogAcaoTipos { get; set; } = null!;
        public virtual DbSet<NfseTblLogDeclaracaoAuto> NfseTblLogDeclaracaoAutos { get; set; } = null!;
        public virtual DbSet<NfseTblMalaDiretaEnvio> NfseTblMalaDiretaEnvios { get; set; } = null!;
        public virtual DbSet<NfseTblMalaDiretum> NfseTblMalaDireta { get; set; } = null!;
        public virtual DbSet<NfseTblMensagem> NfseTblMensagems { get; set; } = null!;
        public virtual DbSet<NfseTblMenuHelp> NfseTblMenuHelps { get; set; } = null!;
        public virtual DbSet<NfseTblMotivoCancelamento> NfseTblMotivoCancelamentos { get; set; } = null!;
        public virtual DbSet<NfseTblNaturezaOperacao> NfseTblNaturezaOperacaos { get; set; } = null!;
        public virtual DbSet<NfseTblNaturezaOperacaoServico> NfseTblNaturezaOperacaoServicos { get; set; } = null!;
        public virtual DbSet<NfseTblNf> NfseTblNfs { get; set; } = null!;
        public virtual DbSet<NfseTblNfsArquivo> NfseTblNfsArquivos { get; set; } = null!;
        public virtual DbSet<NfseTblNfse> NfseTblNfses { get; set; } = null!;
        public virtual DbSet<NfseTblNfseDesconto> NfseTblNfseDescontos { get; set; } = null!;
        public virtual DbSet<NfseTblNfseLiquidadum> NfseTblNfseLiquidada { get; set; } = null!;
        public virtual DbSet<NfseTblNfseNum> NfseTblNfseNums { get; set; } = null!;
        public virtual DbSet<NfseTblNfsePrestador> NfseTblNfsePrestadors { get; set; } = null!;
        public virtual DbSet<NfseTblPainelMensagem> NfseTblPainelMensagems { get; set; } = null!;
        public virtual DbSet<NfseTblParametroTexto> NfseTblParametroTextos { get; set; } = null!;
        public virtual DbSet<NfseTblPedAlteraRegime> NfseTblPedAlteraRegimes { get; set; } = null!;
        public virtual DbSet<NfseTblPedCancelamento> NfseTblPedCancelamentos { get; set; } = null!;
        public virtual DbSet<NfseTblPedCancelamentoAnexo> NfseTblPedCancelamentoAnexos { get; set; } = null!;
        public virtual DbSet<NfseTblPedIncluirServico> NfseTblPedIncluirServicos { get; set; } = null!;
        public virtual DbSet<NfseTblPedServicosIncluso> NfseTblPedServicosInclusos { get; set; } = null!;
        public virtual DbSet<NfseTblPedSubstituicao> NfseTblPedSubstituicaos { get; set; } = null!;
        public virtual DbSet<NfseTblPerfil> NfseTblPerfils { get; set; } = null!;
        public virtual DbSet<NfseTblPlacar> NfseTblPlacars { get; set; } = null!;
        public virtual DbSet<NfseTblReciboRetencao> NfseTblReciboRetencaos { get; set; } = null!;
        public virtual DbSet<NfseTblReciboRetencaoNota> NfseTblReciboRetencaoNotas { get; set; } = null!;
        public virtual DbSet<NfseTblRegime> NfseTblRegimes { get; set; } = null!;
        public virtual DbSet<NfseTblRegimeAliquota> NfseTblRegimeAliquotas { get; set; } = null!;
        public virtual DbSet<NfseTblRegra> NfseTblRegras { get; set; } = null!;
        public virtual DbSet<NfseTblRegrasErro> NfseTblRegrasErros { get; set; } = null!;
        public virtual DbSet<NfseTblRelcomparativoemissaonotum> NfseTblRelcomparativoemissaonota { get; set; } = null!;
        public virtual DbSet<NfseTblRp> NfseTblRps { get; set; } = null!;
        public virtual DbSet<NfseTblRpsImpresso> NfseTblRpsImpressos { get; set; } = null!;
        public virtual DbSet<NfseTblRpssub> NfseTblRpssubs { get; set; } = null!;
        public virtual DbSet<NfseTblServico> NfseTblServicos { get; set; } = null!;
        public virtual DbSet<NfseTblTipoDeclaracao> NfseTblTipoDeclaracaos { get; set; } = null!;
        public virtual DbSet<NfseTblTipoDesconto> NfseTblTipoDescontos { get; set; } = null!;
        public virtual DbSet<NfseTblTipoTomador> NfseTblTipoTomadors { get; set; } = null!;
        public virtual DbSet<NfseTblTributo> NfseTblTributos { get; set; } = null!;
        public virtual DbSet<NfseTblUsuario> NfseTblUsuarios { get; set; } = null!;
        public virtual DbSet<NfseTblUsuarioMensagem> NfseTblUsuarioMensagems { get; set; } = null!;
        public virtual DbSet<NfseTblVideo> NfseTblVideos { get; set; } = null!;
        public virtual DbSet<NfseTblWsSemaforo> NfseTblWsSemaforos { get; set; } = null!;
        public virtual DbSet<NotasEmitida> NotasEmitidas { get; set; } = null!;
        public virtual DbSet<RpsTblLogerro> RpsTblLogerros { get; set; } = null!;
        public virtual DbSet<RpsTblRp> RpsTblRps { get; set; } = null!;
        public virtual DbSet<RpsTblRpsmsgerro> RpsTblRpsmsgerros { get; set; } = null!;
        public virtual DbSet<SysAutoIncrement> SysAutoIncrements { get; set; } = null!;
        public virtual DbSet<SystTblControle> SystTblControles { get; set; } = null!;
        public virtual DbSet<TabMe> TabMes { get; set; } = null!;
        public virtual DbSet<TmpCnpjCandidato> TmpCnpjCandidatos { get; set; } = null!;
        public virtual DbSet<TmpEncerramentoConferencium> TmpEncerramentoConferencia { get; set; } = null!;
        public virtual DbSet<TmpNfseTblEmpresaPerfil> TmpNfseTblEmpresaPerfils { get; set; } = null!;
        public virtual DbSet<ViewCavalodetroium> ViewCavalodetroia { get; set; } = null!;
        public virtual DbSet<ViewDividasGeradasVencimentoErrado> ViewDividasGeradasVencimentoErrados { get; set; } = null!;
        public virtual DbSet<ViewNfseIssRetidoLctoTributo9> ViewNfseIssRetidoLctoTributo9s { get; set; } = null!;
        public virtual DbSet<ViewNotasFiscaisDivergenciaValorIssLancado> ViewNotasFiscaisDivergenciaValorIssLancados { get; set; } = null!;
        public virtual DbSet<ViewNotasFiscaisDivergenciaValorSemLcto> ViewNotasFiscaisDivergenciaValorSemLctos { get; set; } = null!;
        public virtual DbSet<VwDimAtividadeIssMenor5> VwDimAtividadeIssMenor5s { get; set; } = null!;
        public virtual DbSet<VwDimEmpresaIssAliquotamenor5> VwDimEmpresaIssAliquotamenor5s { get; set; } = null!;
        public virtual DbSet<VwDimEmpresaSimplesNacionalNfse> VwDimEmpresaSimplesNacionalNfses { get; set; } = null!;
        public virtual DbSet<VwFatoArrecadacaoIssMenor5> VwFatoArrecadacaoIssMenor5s { get; set; } = null!;
        public virtual DbSet<VwFatoSimplesNacionalNfse> VwFatoSimplesNacionalNfses { get; set; } = null!;
        public virtual DbSet<VwMegaDataContribuinte> VwMegaDataContribuintes { get; set; } = null!;
        public virtual DbSet<VwMegaDataNotasFiscai> VwMegaDataNotasFiscais { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=NFSEDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<AutoIncrementSequence>(entity =>
            {
                entity.HasKey(e => new { e.Sttabela, e.Nuano })
                    .HasName("PK__SYST_TBL__03A6D88E59063A47");

                entity.ToTable("AutoIncrementSequence");

                entity.Property(e => e.Sttabela)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STTABELA");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Nucodigo).HasColumnName("NUCODIGO");
            });

            modelBuilder.Entity<CadastroContribuinte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CadastroContribuintes");

                entity.Property(e => e.BairroContribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Contribuinte");

                entity.Property(e => e.BairroCorrespondenciaContribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Correspondencia_Contribuinte");

                entity.Property(e => e.CepContribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Contribuinte")
                    .IsFixedLength();

                entity.Property(e => e.CepCorrespondenciaContribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Correspondencia_Contribuinte");

                entity.Property(e => e.CidadeCorrespondenciaContribuinte).HasColumnName("Cidade_Correspondencia_Contribuinte");

                entity.Property(e => e.ComplementoContribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Contribuinte");

                entity.Property(e => e.ComplementoCorrespondenciaContribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Correspondencia_Contribuinte");

                entity.Property(e => e.CpfCnpjContador)
                    .HasMaxLength(14)
                    .HasColumnName("CPF_CNPJ_Contador")
                    .IsFixedLength();

                entity.Property(e => e.CpfCnpjContribuinte)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Contribuinte");

                entity.Property(e => e.Crc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRC");

                entity.Property(e => e.DataCadastroContribuinte)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Cadastro_Contribuinte");

                entity.Property(e => e.DtAberturaEmpresa)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Abertura_Empresa");

                entity.Property(e => e.Dtadesaosubstituto)
                    .HasColumnType("datetime")
                    .HasColumnName("DTADESAOSUBSTITUTO");

                entity.Property(e => e.EmailContribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Email_Contribuinte");

                entity.Property(e => e.EndCorrespondenciaContribuinte)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("End_Correspondencia_Contribuinte");

                entity.Property(e => e.EnderecoContador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Contador");

                entity.Property(e => e.IdCidade).HasColumnName("Id_Cidade");

                entity.Property(e => e.IdContribuinte).HasColumnName("Id_Contribuinte");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.IdEmpresaMatriz).HasColumnName("Id_Empresa_Matriz");

                entity.Property(e => e.IdRegime).HasColumnName("Id_Regime");

                entity.Property(e => e.ImContribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IM_Contribuinte");

                entity.Property(e => e.NomeContador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Contador");

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Contribuinte");

                entity.Property(e => e.NumCorrespondenciaContribuinte)
                    .HasMaxLength(10)
                    .HasColumnName("Num_Correspondencia_Contribuinte")
                    .IsFixedLength();

                entity.Property(e => e.NumFaxContribuinte)
                    .HasMaxLength(17)
                    .HasColumnName("Num_Fax_Contribuinte")
                    .IsFixedLength();

                entity.Property(e => e.NumeroContribuinte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Contribuinte");

                entity.Property(e => e.NumeroProcessoAbertura)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Processo_Abertura");

                entity.Property(e => e.RuaContribuinte)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("Rua_Contribuinte");

                entity.Property(e => e.SiteContribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Site_Contribuinte");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SituacaoContribuinte)
                    .HasMaxLength(1)
                    .HasColumnName("Situacao_Contribuinte")
                    .IsFixedLength();

                entity.Property(e => e.SubTributacao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Tributacao");

                entity.Property(e => e.TelefoneContador)
                    .HasMaxLength(17)
                    .HasColumnName("Telefone_Contador")
                    .IsFixedLength();

                entity.Property(e => e.TelefoneContribuinte)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("Telefone_Contribuinte");

                entity.Property(e => e.TipoContribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Contribuinte");

                entity.Property(e => e.Tributacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CadastroEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CadastroEmpresas");

                entity.Property(e => e.AliquotaPrincipalHistorico)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("Aliquota_Principal_Historico");

                entity.Property(e => e.AliquotaServico)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("Aliquota_Servico");

                entity.Property(e => e.BaseLegalServico)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Base_Legal_Servico");

                entity.Property(e => e.CpfCnpjContadorEmpresa)
                    .HasMaxLength(14)
                    .HasColumnName("CPF_CNPJ_Contador_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.Cpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPFCNPJ");

                entity.Property(e => e.CrcEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRC_EMPRESA");

                entity.Property(e => e.DescricaoOperacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Operacao");

                entity.Property(e => e.DescricaoServico)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Servico");

                entity.Property(e => e.DtAberturaEmpresa)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Abertura_Empresa");

                entity.Property(e => e.DtEntradaHistorico)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Entrada_Historico");

                entity.Property(e => e.DtSaidaHistorico)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Saida_Historico");

                entity.Property(e => e.IdCnaeSubClasseEmpresa)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Id_CNAE_Sub_Classe_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.IdContribuinte).HasColumnName("Id_Contribuinte");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.IdHistoricoEmpresa).HasColumnName("Id_Historico_Empresa");

                entity.Property(e => e.IdMatrizEmpresa).HasColumnName("Id_Matriz Empresa");

                entity.Property(e => e.IdOperacao).HasColumnName("Id_Operacao");

                entity.Property(e => e.IdOperacaoEmpresaEmpresa).HasColumnName("Id_Operacao_Empresa_Empresa");

                entity.Property(e => e.IdServicoEmpresa)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Servico_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.IdUsuarioEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_Usuario_Empresa");

                entity.Property(e => e.MotivoEmpresa)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Motivo_Empresa");

                entity.Property(e => e.NaturezaEspecialOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Natureza_Especial_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.NaturezaPadraoOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Natureza_Padrao_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.NomeContadorEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome_Contador_Empresa");

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NumProcessoAberturaEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Num_Processo_Abertura_Empresa");

                entity.Property(e => e.ObrigaRetencaoForaServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Obriga_Retencao_Fora_Servico")
                    .IsFixedLength();

                entity.Property(e => e.ObrigaRetencaoMunServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Obriga_Retencao_Mun_Servico")
                    .IsFixedLength();

                entity.Property(e => e.RequolimentoMunicipioServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Requolimento_Municipio_Servico")
                    .IsFixedLength();

                entity.Property(e => e.RuaContadorEmpresa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Rua_Contador_Empresa");

                entity.Property(e => e.ServidorForaOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Servidor_Fora_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.SofreReducaoServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sofre_Reducao_Servico")
                    .IsFixedLength();

                entity.Property(e => e.SubTributacaoEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Tributacao_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.TelefoneContadorEmpresa)
                    .HasMaxLength(17)
                    .HasColumnName("Telefone_Contador_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.TipoPessoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoTributacaoEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Tributacao_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.ValorEstimadoHistorico)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Estimado_Historico");

                entity.Property(e => e.ValorMensalHistorico)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Mensal_Historico");

                entity.Property(e => e.VetadoServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Vetado_Servico")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CampoOutrasInfSemMsgTributacaoFora>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CampoOutrasInf_Sem_Msg_TributacaoFora");

                entity.Property(e => e.PrestadorCmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PrestadorCMC");

                entity.Property(e => e.PrestadorCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PrestadorCNPJ");

                entity.Property(e => e.PrestadorRazaoSocial)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Totalnotas).HasColumnName("TOTALNOTAS");
            });

            modelBuilder.Entity<CredenciamentoEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CredenciamentoEmpresas");

                entity.Property(e => e.BairroCorrespondenciaCotribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Correspondencia_Cotribuinte");

                entity.Property(e => e.BairroCotribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Bairro_Cotribuinte");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CepCorrespondenciaCotribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Correspondencia_Cotribuinte");

                entity.Property(e => e.CepCotribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP_Cotribuinte")
                    .IsFixedLength();

                entity.Property(e => e.CidadeCorrespondenciaCotribuinte).HasColumnName("Cidade_Correspondencia_Cotribuinte");

                entity.Property(e => e.CmcCotribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Cotribuinte");

                entity.Property(e => e.ComplementoCorrespondenciaCotribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Complemento_Correspondencia_Cotribuinte");

                entity.Property(e => e.ConplementoCotribuinte)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Conplemento_Cotribuinte");

                entity.Property(e => e.CpfCnpjContadorEmpresa)
                    .HasMaxLength(14)
                    .HasColumnName("CPF_CNPJ_Contador_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.CpfCnpjContribuinte)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Contribuinte");

                entity.Property(e => e.CrcEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRC_Empresa");

                entity.Property(e => e.DtAberturaEmpresa)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Abertura_Empresa");

                entity.Property(e => e.DtCadastroCotribuinte)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Cadastro_Cotribuinte");

                entity.Property(e => e.DtDescredenciamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Descredenciamento");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Inclusao");

                entity.Property(e => e.EmailCotribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Email_Cotribuinte");

                entity.Property(e => e.EnderecoContadorEmpresa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Contador_Empresa");

                entity.Property(e => e.EnderecoCorrespondenciaCotribuinte)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Correspondencia_Cotribuinte");

                entity.Property(e => e.FoneCotribuinte)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("Fone_Cotribuinte");

                entity.Property(e => e.IdCidadeContribuinte).HasColumnName("Id_Cidade_Contribuinte");

                entity.Property(e => e.IdContribuinte).HasColumnName("Id_Contribuinte");

                entity.Property(e => e.IdCredenciamento).HasColumnName("Id_Credenciamento");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.IdMatrizEmpresa).HasColumnName("Id_Matriz_Empresa");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Id_Usuario");

                entity.Property(e => e.Idcontribuinte1).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.IeCotribuinte)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IE_Cotribuinte");

                entity.Property(e => e.IiCotribuinte)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("II_Cotribuinte");

                entity.Property(e => e.NmContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("Nm_Contribuinte");

                entity.Property(e => e.NomeContadorEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Contador_Empresa");

                entity.Property(e => e.NumProcessoAberturaEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Num_Processo_Abertura_Empresa");

                entity.Property(e => e.NumeroCorrespondenciaCotribuinte)
                    .HasMaxLength(10)
                    .HasColumnName("Numero_Correspondencia_Cotribuinte")
                    .IsFixedLength();

                entity.Property(e => e.NumeroCotribuinte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Cotribuinte");

                entity.Property(e => e.RuaCotribuinte)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("Rua_Cotribuinte");

                entity.Property(e => e.SimNacionalEmpresa)
                    .HasMaxLength(10)
                    .HasColumnName("Sim Nacional Empresa")
                    .IsFixedLength();

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SituacaoEmpresa)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Situacao_Empresa");

                entity.Property(e => e.Stfax)
                    .HasMaxLength(17)
                    .HasColumnName("STFAX")
                    .IsFixedLength();

                entity.Property(e => e.SubTributarioEmpresa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Sub. Tributario Empresa");

                entity.Property(e => e.TelefoneContadorEmpresa)
                    .HasMaxLength(17)
                    .HasColumnName("Telefone_Contador_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.TipoContribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Contribuinte");
            });

            modelBuilder.Entity<Declaracao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("declaracao");

                entity.Property(e => e.Declaracao1).HasColumnName("declaracao");
            });

            modelBuilder.Entity<DeclaracaoSemMovimentoBaixaPendente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeclaracaoSemMovimentoBaixaPendente");

                entity.Property(e => e.Baixa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Declaracao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DtDeclaracao).HasColumnType("datetime");

                entity.Property(e => e.Prestador)
                    .HasMaxLength(137)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Declaraco>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Declaracoes");

                entity.Property(e => e.CpfCnpjcontribuinte)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJContribuinte");

                entity.Property(e => e.DataPagamento).HasColumnType("date");

                entity.Property(e => e.DtCompetencia).HasColumnType("datetime");

                entity.Property(e => e.DtLcto).HasColumnType("datetime");

                entity.Property(e => e.Erros).IsUnicode(false);

                entity.Property(e => e.IdcontaEstorno).HasColumnName("IDContaEstorno");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUsuario");

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Regime)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Servico)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SituacaoNota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_Status")
                    .IsFixedLength();

                entity.Property(e => e.TipoConta)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeclaracao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAdministrador)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIssretido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("ValorISSRetido");

                entity.Property(e => e.ValorServico).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ValorTotal).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.ValorTotalIss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("ValorTotalISS");
            });

            modelBuilder.Entity<DeclaracoesComEncerramentosDuplicado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("declaracoesComEncerramentosDuplicados");

                entity.Property(e => e.Idconta).HasColumnName("idconta");
            });

            modelBuilder.Entity<DesifBalanceteAnaliticoMensal>(entity =>
            {
                entity.HasKey(e => e.Idbalanamen);

                entity.ToTable("DESIF_BalanceteAnaliticoMensal");

                entity.Property(e => e.Idbalanamen)
                    .ValueGeneratedNever()
                    .HasColumnName("IDBALANAMEN");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("date")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Idconta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDCONTA");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Stcoddepende)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STCODDEPENDE");

                entity.Property(e => e.Vlcredito)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLCREDITO");

                entity.Property(e => e.Vldebito)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLDEBITO");

                entity.Property(e => e.Vlsaldofinal)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLSALDOFINAL");

                entity.Property(e => e.Vlsaldoinicial)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLSALDOINICIAL");
            });

            modelBuilder.Entity<DesifCodigosTributacao>(entity =>
            {
                entity.HasKey(e => e.Stcodtribdesif);

                entity.ToTable("DESIF_CodigosTributacao");

                entity.Property(e => e.Stcodtribdesif)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("STCODTRIBDESIF");

                entity.Property(e => e.Stdesctrib)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCTRIB");

                entity.Property(e => e.Stsubitemlista).HasColumnName("STSUBITEMLISTA");
            });

            modelBuilder.Entity<DesifCodigosTributacaoMunicipio>(entity =>
            {
                entity.HasKey(e => e.Idcodtribmuni);

                entity.ToTable("DESIF_CodigosTributacaoMunicipio");

                entity.Property(e => e.Idcodtribmuni)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCODTRIBMUNI");

                entity.Property(e => e.Dtfimvigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTFIMVIGENCIA");

                entity.Property(e => e.Dtinivigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINIVIGENCIA");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Nualiquota)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("NUALIQUOTA");

                entity.Property(e => e.Stcodtribdesif)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("STCODTRIBDESIF");
            });

            modelBuilder.Entity<DesifCosif>(entity =>
            {
                entity.HasKey(e => e.Idcontacosif);

                entity.ToTable("DESIF_COSIF");

                entity.Property(e => e.Idcontacosif)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCONTACOSIF");

                entity.Property(e => e.Dtcriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCRIACAO");

                entity.Property(e => e.Dtextinsao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEXTINSAO");

                entity.Property(e => e.Idcontasup).HasColumnName("IDCONTASUP");

                entity.Property(e => e.Stdescfuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCFUNCAO");

                entity.Property(e => e.Stnomeconta)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STNOMECONTA");
            });

            modelBuilder.Entity<DesifDemApuRecTribIssqnsubtitulo>(entity =>
            {
                entity.HasKey(e => e.Iddemapurectribisssub);

                entity.ToTable("DESIF_DemApuRecTribISSQNSubtitulo");

                entity.Property(e => e.Iddemapurectribisssub)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDEMAPURECTRIBISSSUB");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Nualiquota)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("NUALIQUOTA");

                entity.Property(e => e.Numotivonaoexig).HasColumnName("NUMOTIVONAOEXIG");

                entity.Property(e => e.Nuprocnaoexig)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUPROCNAOEXIG");

                entity.Property(e => e.Stcoddepende)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STCODDEPENDE");

                entity.Property(e => e.Stcodtribdesif)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("STCODTRIBDESIF");

                entity.Property(e => e.Stdescdeducao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCDEDUCAO");

                entity.Property(e => e.Stdescincentfisc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCINCENTFISC");

                entity.Property(e => e.Stsubtitulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STSUBTITULO");

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vlcreditomens)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLCREDITOMENS");

                entity.Property(e => e.Vldebitomens)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLDEBITOMENS");

                entity.Property(e => e.Vldeducaoreceita)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLDEDUCAORECEITA");

                entity.Property(e => e.Vlincentivofisc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLINCENTIVOFISC");

                entity.Property(e => e.Vlreceita)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLRECEITA");
            });

            modelBuilder.Entity<DesifDemonstrativoIssqnmensalRecolher>(entity =>
            {
                entity.HasKey(e => e.Iddemissmenrec);

                entity.ToTable("DESIF_DemonstrativoISSQNMensalRecolher");

                entity.Property(e => e.Iddemissmenrec)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDEMISSMENREC");

                entity.Property(e => e.Dtcompcredito)
                    .HasColumnType("date")
                    .HasColumnName("DTCOMPCREDITO");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Nualiquota)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("NUALIQUOTA");

                entity.Property(e => e.Numotivonaoexig).HasColumnName("NUMOTIVONAOEXIG");

                entity.Property(e => e.Nuprocnaoexig)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUPROCNAOEXIG");

                entity.Property(e => e.Stcnpj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJ")
                    .IsFixedLength();

                entity.Property(e => e.Stcodtribdesif)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("STCODTRIBDESIF");

                entity.Property(e => e.Stdesccompensa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCCOMPENSA");

                entity.Property(e => e.Stdescdedu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCDEDU");

                entity.Property(e => e.Stdescincentfisc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCINCENTFISC");

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vlcredcompensa)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLCREDCOMPENSA");

                entity.Property(e => e.Vldeddeccons)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLDEDDECCONS");

                entity.Property(e => e.Vldeddecsub)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLDEDDECSUB");

                entity.Property(e => e.Vlincentfiscsub)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLINCENTFISCSUB");

                entity.Property(e => e.Vlincentivofisc)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLINCENTIVOFISC");

                entity.Property(e => e.Vlissqn)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLISSQN");

                entity.Property(e => e.Vlissqnretido)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLISSQNRETIDO");

                entity.Property(e => e.Vlissrecolher)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLISSRECOLHER");

                entity.Property(e => e.Vlissrecolhido)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLISSRECOLHIDO");

                entity.Property(e => e.Vlorigemcred)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLORIGEMCRED");

                entity.Property(e => e.Vlrecdeccons)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLRECDECCONS");
            });

            modelBuilder.Entity<DesifDemonstrativoPartidasLancamentosContabei>(entity =>
            {
                entity.HasKey(e => e.Iddemparlancon);

                entity.ToTable("DESIF_DemonstrativoPartidasLancamentosContabeis");

                entity.Property(e => e.Iddemparlancon)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDEMPARLANCON");

                entity.Property(e => e.Dtlancamento)
                    .HasColumnType("date")
                    .HasColumnName("DTLANCAMENTO");

                entity.Property(e => e.Idcidadecontab).HasColumnName("IDCIDADECONTAB");

                entity.Property(e => e.Idcidadevinculo).HasColumnName("IDCIDADEVINCULO");

                entity.Property(e => e.Idcodigoevento).HasColumnName("IDCODIGOEVENTO");

                entity.Property(e => e.Idlancamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDLANCAMENTO");

                entity.Property(e => e.Nutipopartida).HasColumnName("NUTIPOPARTIDA");

                entity.Property(e => e.Stcnpjcontab)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJCONTAB");

                entity.Property(e => e.Sthistpartida)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STHISTPARTIDA");

                entity.Property(e => e.Stsubtitulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STSUBTITULO");

                entity.Property(e => e.Vlparlancamento)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLPARLANCAMENTO");
            });

            modelBuilder.Entity<DesifDemonstrativoRateioResultadosInterno>(entity =>
            {
                entity.HasKey(e => e.Iddemratrec)
                    .HasName("PK_DESIF_DemonstrativoRateioReceitas");

                entity.ToTable("DESIF_DemonstrativoRateioResultadosInternos");

                entity.Property(e => e.Iddemratrec)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDEMRATREC");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("date")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Idcodigoevento).HasColumnName("IDCODIGOEVENTO");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Nutipopartida).HasColumnName("NUTIPOPARTIDA");

                entity.Property(e => e.Stcoddepende)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STCODDEPENDE");

                entity.Property(e => e.Stdescrateio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRATEIO");

                entity.Property(e => e.Vlrateio)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("VLRATEIO");
            });

            modelBuilder.Entity<DesifEventosContabeisContasResultado>(entity =>
            {
                entity.HasKey(e => e.Idcodigoevento);

                entity.ToTable("DESIF_EventosContabeisContasResultado");

                entity.Property(e => e.Idcodigoevento).HasColumnName("IDCODIGOEVENTO");

                entity.Property(e => e.Idtipoevento).HasColumnName("IDTIPOEVENTO");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<DesifIdentificacaoDeclaracao>(entity =>
            {
                entity.HasKey(e => e.Iddeclaracao);

                entity.ToTable("DESIF_IdentificacaoDeclaracao");

                entity.Property(e => e.Iddeclaracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idtipoinstituicao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDTIPOINSTITUICAO")
                    .IsFixedLength();

                entity.Property(e => e.Idversao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDVERSAO");

                entity.Property(e => e.Numodulodec).HasColumnName("NUMODULODEC");

                entity.Property(e => e.Nuprotdec).HasColumnName("NUPROTDEC");

                entity.Property(e => e.Nutipoarredonda).HasColumnName("NUTIPOARREDONDA");

                entity.Property(e => e.Nutipoconsolida).HasColumnName("NUTIPOCONSOLIDA");

                entity.Property(e => e.Nutipodec).HasColumnName("NUTIPODEC");

                entity.Property(e => e.Stanomesfimcomp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STANOMESFIMCOMP");

                entity.Property(e => e.Stanomesinicomp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STANOMESINICOMP");

                entity.Property(e => e.Stcnpj)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJ");

                entity.Property(e => e.Stcnpjresprecolhe)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJRESPRECOLHE");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<DesifIdentificacaoDependencium>(entity =>
            {
                entity.HasKey(e => e.Iddependencia);

                entity.ToTable("DESIF_IdentificacaoDependencia");

                entity.Property(e => e.Iddependencia)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDEPENDENCIA");

                entity.Property(e => e.Dtfimparaliza)
                    .HasColumnType("date")
                    .HasColumnName("DTFIMPARALIZA");

                entity.Property(e => e.Dtiniparaliza)
                    .HasColumnType("date")
                    .HasColumnName("DTINIPARALIZA");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Nuindinscmun).HasColumnName("NUINDINSCMUN");

                entity.Property(e => e.Nutipodepende).HasColumnName("NUTIPODEPENDE");

                entity.Property(e => e.Stcnpjproprio)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJPROPRIO");

                entity.Property(e => e.Stcnpjunificado)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJUNIFICADO");

                entity.Property(e => e.Stcoddepende)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STCODDEPENDE");

                entity.Property(e => e.Stcontabpropia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONTABPROPIA")
                    .IsFixedLength();

                entity.Property(e => e.Stenddepende)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STENDDEPENDE");
            });

            modelBuilder.Entity<DesifIdentificacaoServicosRemuneracaoVariavel>(entity =>
            {
                entity.HasKey(e => e.Idserremvar);

                entity.ToTable("DESIF_IdentificacaoServicosRemuneracaoVariavel");

                entity.Property(e => e.Idserremvar)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSERREMVAR");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Idservremvar)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVREMVAR");

                entity.Property(e => e.Stdesccomple)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCCOMPLE");

                entity.Property(e => e.Stsubtitulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STSUBTITULO");
            });

            modelBuilder.Entity<DesifPlanoGeralContasComentado>(entity =>
            {
                entity.HasKey(e => e.Idpgcc)
                    .HasName("PK_DESIF_PlanoGeralContasComentado_1");

                entity.ToTable("DESIF_PlanoGeralContasComentado");

                entity.Property(e => e.Idpgcc)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPGCC");

                entity.Property(e => e.Idconta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDCONTA");

                entity.Property(e => e.Idcontacosif).HasColumnName("IDCONTACOSIF");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Stcodtribdesif)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("STCODTRIBDESIF");

                entity.Property(e => e.Stcontasupe)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STCONTASUPE");

                entity.Property(e => e.Stdescconta)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("STDESCCONTA");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<DesifServicosRemuneracaoVariavel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DESIF_ServicosRemuneracaoVariavel");

                entity.Property(e => e.Idserremvar)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDSERREMVAR");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stobrdescom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOBRDESCOM")
                    .IsFixedLength();

                entity.Property(e => e.Stservico)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STSERVICO");
            });

            modelBuilder.Entity<DesifTarifasServicosInstituicao>(entity =>
            {
                entity.HasKey(e => e.Idtarserins);

                entity.ToTable("DESIF_TarifasServicosInstituicao");

                entity.Property(e => e.Idtarserins)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTARSERINS");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Stdesctarifa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STDESCTARIFA");

                entity.Property(e => e.Stidtarifa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STIDTARIFA");

                entity.Property(e => e.Stsubtitulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STSUBTITULO");
            });

            modelBuilder.Entity<DesifTipoInstituicao>(entity =>
            {
                entity.HasKey(e => e.Idtipoinstituicao)
                    .HasName("PK_DESIF_Titulos");

                entity.ToTable("DESIF_TipoInstituicao");

                entity.Property(e => e.Idtipoinstituicao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDTIPOINSTITUICAO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Sttarifaobrigatoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTARIFAOBRIGATORIA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Divergencium>(entity =>
            {
                entity.HasKey(e => e.Conta);

                entity.Property(e => e.Conta)
                    .ValueGeneratedNever()
                    .HasColumnName("conta");

                entity.Property(e => e.Credito)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("credito");

                entity.Property(e => e.Debito)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("debito");

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("valorDeclarado");
            });

            modelBuilder.Entity<Dividas1Real>(entity =>
            {
                entity.HasKey(e => e.Idencerramento);

                entity.ToTable("Dividas1Real");

                entity.Property(e => e.Idencerramento)
                    .ValueGeneratedNever()
                    .HasColumnName("idencerramento");
            });

            modelBuilder.Entity<DividasBaixaDecSimplesIssqnretido>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DividasBaixaDecSimplesISSQNRetido");

                entity.Property(e => e.DividaValor).HasColumnType("money");

                entity.Property(e => e.PrestadorCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PrestadorCNPJ");

                entity.Property(e => e.PrestadorNome)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TomadorCpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TomadorCPF/CNPJ");

                entity.Property(e => e.TomadorNome)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DividasIssqnRetidoBaixaSimple>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Dividas_ISSQN_retido baixa_simples");

                entity.Property(e => e.DividaValor).HasColumnType("money");

                entity.Property(e => e.PrestadorCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PrestadorCNPJ");

                entity.Property(e => e.PrestadorNome)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TomadorCpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TomadorCPF/CNPJ");

                entity.Property(e => e.TomadorNome)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DividasPendentesDuplicada>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DividasPendentesDuplicadas");

                entity.Property(e => e.ConCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ConCNPJCPF")
                    .IsFixedLength();

                entity.Property(e => e.ConNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivEmpId).HasColumnName("DivEmpID");

                entity.Property(e => e.EmprDivValor).HasColumnType("money");

                entity.Property(e => e.TipoBxNome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");
            });

            modelBuilder.Entity<DividasPendentesRetidaNaFonteValorZero>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DividasPendentesRetidaNaFonteValorZero");

                entity.Property(e => e.Divempid).HasColumnName("divempid");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idencerramento).HasColumnName("IDENCERRAMENTO");

                entity.Property(e => e.TipoBxId).HasColumnName("TipoBxID");

                entity.Property(e => e.TipoBxNome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<DividasReplicada>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");
            });

            modelBuilder.Entity<DividasTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dividasTemp");

                entity.Property(e => e.Cmc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cmc");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Idbaixa).HasColumnName("idbaixa");

                entity.Property(e => e.Iddivida).HasColumnName("iddivida");

                entity.Property(e => e.Idtributo).HasColumnName("idtributo");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Nomebaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomebaixa");

                entity.Property(e => e.Nometributo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nometributo");

                entity.Property(e => e.Razaosocial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("razaosocial");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("valor");

                entity.Property(e => e.Vencimento)
                    .HasColumnType("date")
                    .HasColumnName("vencimento");
            });

            modelBuilder.Entity<EmpresasBaixadasPosRevisao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmpresasBaixadasPosRevisao");

                entity.Property(e => e.AnteriorAreaConstr).HasColumnType("money");

                entity.Property(e => e.BairroId).HasColumnName("BairroID");

                entity.Property(e => e.ConId).HasColumnName("ConID");

                entity.Property(e => e.ContadorId).HasColumnName("ContadorID");

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.EmprAlvaraEventual)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprAreaAberta).HasColumnType("money");

                entity.Property(e => e.EmprAtividadeContratoSocial)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EmprCaracId).HasColumnName("EmprCaracID");

                entity.Property(e => e.EmprCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EmprCEP");

                entity.Property(e => e.EmprCnpjextensao)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("EmprCNPJExtensao")
                    .IsFixedLength();

                entity.Property(e => e.EmprComDiversoes)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprComExplosivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprComGas)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprComplemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmprConstitId).HasColumnName("EmprConstitID");

                entity.Property(e => e.EmprDataInscricao).HasColumnType("datetime");

                entity.Property(e => e.EmprDomicilioTributario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprDtFinCadastro).HasColumnType("datetime");

                entity.Property(e => e.EmprEnderecoNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprEnqSimples)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprOrigemDuc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("EmprOrigemDUC")
                    .IsFixedLength();

                entity.Property(e => e.EmprRegJuntaComData).HasColumnType("datetime");

                entity.Property(e => e.EmprRestricoes).HasColumnType("text");

                entity.Property(e => e.EmprSituacaoId).HasColumnName("EmprSituacaoID");

                entity.Property(e => e.EmprSubstituto)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmprTipoId).HasColumnName("EmprTipoID");

                entity.Property(e => e.EstabGrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LogradId).HasColumnName("LogradID");

                entity.Property(e => e.UsuarioInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpresasHomologacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmpresasHomologacao");

                entity.Property(e => e.Cmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC");

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ");

                entity.Property(e => e.DataHomologacao).HasColumnType("datetime");

                entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                entity.Property(e => e.DataLiberacao).HasColumnType("date");

                entity.Property(e => e.IdContribuinte).HasColumnName("Id_Contribuinte");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPessoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Encerramento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Encerramentos");

                entity.Property(e => e.Aliquota).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.AnoDividaEmpresa).HasColumnName("Ano_Divida_Empresa");

                entity.Property(e => e.BaseCalculo)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Base_Calculo");

                entity.Property(e => e.CidadePrestacao)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Prestacao");

                entity.Property(e => e.CidadeTomador)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Tomador");

                entity.Property(e => e.CmcEmpresa).HasColumnName("CMC_Empresa");

                entity.Property(e => e.CmcTomador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Tomador")
                    .IsFixedLength();

                entity.Property(e => e.CnpjPrestador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Prestador");

                entity.Property(e => e.CpfCnpjContribuinte)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Contribuinte")
                    .IsFixedLength();

                entity.Property(e => e.DataGeracaoDivida)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Geracao_Divida");

                entity.Property(e => e.DataVencimentoDivida)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Vencimento_Divida");

                entity.Property(e => e.EmprDivDataBaixa).HasColumnType("datetime");

                entity.Property(e => e.IdBaixa).HasColumnName("Id_Baixa");

                entity.Property(e => e.IdDivida).HasColumnName("Id_Divida");

                entity.Property(e => e.IdDividaEmpresa).HasColumnName("Id_Divida_Empresa");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Servico")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoTributo).HasColumnName("Id_Tipo_Tributo");

                entity.Property(e => e.IssRetido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Iss_Retido")
                    .IsFixedLength();

                entity.Property(e => e.MesDividaEmpresa).HasColumnName("Mes_Divida_Empresa");

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Contribuinte");

                entity.Property(e => e.NomePrestador)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Prestador");

                entity.Property(e => e.NrDeclaracao).HasColumnName("Nr_Declaracao");

                entity.Property(e => e.NrEncerramento).HasColumnName("NR_Encerramento");

                entity.Property(e => e.NrNotaFiscal).HasColumnName("NR_Nota_Fiscal");

                entity.Property(e => e.RegimeNota)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Regime_Nota");

                entity.Property(e => e.RegimePrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Regime_Prestador");

                entity.Property(e => e.TipoDeclaracao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Declaracao");

                entity.Property(e => e.TipoNomeBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Nome_Baixa");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBaixaDividaEmpresa)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Baixa_Divida_Empresa");

                entity.Property(e => e.ValorDividaEmpresa)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Divida_Empresa");

                entity.Property(e => e.VlIssRetido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Vl_Iss_Retido");

                entity.Property(e => e.VlLiquido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Vl_Liquido");

                entity.Property(e => e.VlServicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Vl_Servicos");

                entity.Property(e => e.VlTotalIss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Vl_Total_ISS");
            });

            modelBuilder.Entity<EncerramentoDividaMaior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EncerramentoDividaMaior");

                entity.Property(e => e.Idconta).HasColumnName("idconta");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Idregime).HasColumnName("idregime");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalDivida)
                    .HasColumnType("money")
                    .HasColumnName("totalDivida");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentoDividaMenor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EncerramentoDividaMenor");

                entity.Property(e => e.Idconta).HasColumnName("idconta");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Idregime).HasColumnName("idregime");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalDivida)
                    .HasColumnType("money")
                    .HasColumnName("totalDivida");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentoProprioComDividaMaiorQueDec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EncerramentoProprioComDividaMaiorQueDec");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Idregime).HasColumnName("idregime");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalDivida)
                    .HasColumnType("money")
                    .HasColumnName("totalDivida");

                entity.Property(e => e.VlDeclarado).HasColumnType("money");
            });

            modelBuilder.Entity<EncerramentoPropriosSemDivida>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idconta).HasColumnName("idconta");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Idregime).HasColumnName("idregime");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalDivida)
                    .HasColumnType("money")
                    .HasColumnName("totalDivida");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentoRetidoSemDividum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idconta).HasColumnName("idconta");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Idregime).HasColumnName("idregime");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TotalDivida)
                    .HasColumnType("money")
                    .HasColumnName("totalDivida");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentoSemDividum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encerramentoSemDivida");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idencerramento).HasColumnName("IDENCERRAMENTO");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<EncerramentosAjustado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encerramentosAjustados");

                entity.Property(e => e.DivEmpId).HasColumnName("DivEmpID");

                entity.Property(e => e.EmprDivDataGeracao).HasColumnType("datetime");

                entity.Property(e => e.EmprDivObs)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivOrigemLancamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivValor).HasColumnType("money");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TipoBxId).HasColumnName("TipoBxID");

                entity.Property(e => e.TipoBxNome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioInclusao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentosAjustados10cent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encerramentosAjustados10cents");

                entity.Property(e => e.DivEmpId).HasColumnName("DivEmpID");

                entity.Property(e => e.EmprDivDataGeracao).HasColumnType("datetime");

                entity.Property(e => e.EmprDivObs)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivOrigemLancamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivValor).HasColumnType("money");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TipoBxId).HasColumnName("TipoBxID");

                entity.Property(e => e.TipoBxNome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioInclusao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentosAjustados5cent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encerramentosAjustados5cents");

                entity.Property(e => e.DivEmpId).HasColumnName("DivEmpID");

                entity.Property(e => e.EmprDivDataGeracao).HasColumnType("datetime");

                entity.Property(e => e.EmprDivObs)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivOrigemLancamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmprDivValor).HasColumnType("money");

                entity.Property(e => e.Idencerramento).HasColumnName("idencerramento");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.TipoBxId).HasColumnName("TipoBxID");

                entity.Property(e => e.TipoBxNome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");

                entity.Property(e => e.TipoTribNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioInclusao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vltotal)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<EncerramentosNdevemGerarDivida>(entity =>
            {
                entity.HasKey(e => e.Idencerramento);

                entity.ToTable("EncerramentosNDevemGerarDividas");

                entity.Property(e => e.Idencerramento)
                    .ValueGeneratedNever()
                    .HasColumnName("IDENCERRAMENTO");
            });

            modelBuilder.Entity<GuiaAvulsa>(entity =>
            {
                entity.ToTable("GuiaAvulsa");

                entity.HasIndex(e => e.Docdividaid, "IX_GuiaAvulsa_DOCDIVIDAID");

                entity.HasIndex(e => e.Docnumero, "IX_GuiaAvulsa_DOCNUMERO");

                entity.HasIndex(e => e.Resdocumento, "IX_GuiaAvulsa_RESDOCUMENTO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Docaliquota)
                    .HasColumnType("money")
                    .HasColumnName("DOCALIQUOTA");

                entity.Property(e => e.Docdata)
                    .HasColumnType("date")
                    .HasColumnName("DOCDATA");

                entity.Property(e => e.Docdividaid).HasColumnName("DOCDIVIDAID");

                entity.Property(e => e.Docidcidade).HasColumnName("DOCIDCIDADE");

                entity.Property(e => e.Docidservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DOCIDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Docnumero).HasColumnName("DOCNUMERO");

                entity.Property(e => e.Docresponsavel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCRESPONSAVEL")
                    .IsFixedLength();

                entity.Property(e => e.Docsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCSITUACAO")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                entity.Property(e => e.Doctipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCTIPO")
                    .IsFixedLength();

                entity.Property(e => e.Doctprecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCTPRECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.Documentoadicional)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTOADICIONAL");

                entity.Property(e => e.Docvlbasecalculo)
                    .HasColumnType("money")
                    .HasColumnName("DOCVLBASECALCULO");

                entity.Property(e => e.Docvldeducao)
                    .HasColumnType("money")
                    .HasColumnName("DOCVLDEDUCAO");

                entity.Property(e => e.Docvlissqn)
                    .HasColumnType("money")
                    .HasColumnName("DOCVLISSQN");

                entity.Property(e => e.Docvlservico)
                    .HasColumnType("money")
                    .HasColumnName("DOCVLSERVICO");

                entity.Property(e => e.Nomeadicional)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOMEADICIONAL");

                entity.Property(e => e.Resbairro)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("RESBAIRRO");

                entity.Property(e => e.Rescep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESCEP");

                entity.Property(e => e.Rescomplemento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESCOMPLEMENTO");

                entity.Property(e => e.Resdocumento)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RESDOCUMENTO");

                entity.Property(e => e.Resemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESEMAIL");

                entity.Property(e => e.Residcidade).HasColumnName("RESIDCIDADE");

                entity.Property(e => e.Reslogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESLOGRADOURO");

                entity.Property(e => e.Resmotivocancelamento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RESMOTIVOCANCELAMENTO");

                entity.Property(e => e.Resnome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESNOME");

                entity.Property(e => e.Resnumpredial).HasColumnName("RESNUMPREDIAL");

                entity.Property(e => e.Restelefone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("RESTELEFONE");

                entity.HasOne(d => d.DocidservicoNavigation)
                    .WithMany(p => p.GuiaAvulsas)
                    .HasForeignKey(d => d.Docidservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaAvulsa_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<GuiaAvulsaAnexo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Arqanexo).HasColumnName("ARQANEXO");

                entity.Property(e => e.Arqext)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ARQEXT");

                entity.Property(e => e.Idguia).HasColumnName("IDGUIA");

                entity.HasOne(d => d.IdguiaNavigation)
                    .WithMany(p => p.GuiaAvulsaAnexos)
                    .HasForeignKey(d => d.Idguia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuiaAvulsaAnexos_GUIAAVULSA");
            });

            modelBuilder.Entity<ListaDividasAlterada>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdDivida)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NfseTblAtualizaTabela>(entity =>
            {
                entity.HasKey(e => e.Idatualizacao);

                entity.ToTable("NFSE_TBL_ATUALIZA_TABELAS");

                entity.Property(e => e.Idatualizacao).HasColumnName("IDATUALIZACAO");

                entity.Property(e => e.Dtexecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEXECUCAO");

                entity.Property(e => e.Dtregistro)
                    .HasColumnType("datetime")
                    .HasColumnName("DTREGISTRO");

                entity.Property(e => e.Idregistro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDREGISTRO");

                entity.Property(e => e.Idregistrofk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDREGISTROFK");

                entity.Property(e => e.Stoperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOPERACAO")
                    .IsFixedLength();

                entity.Property(e => e.Storigem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STORIGEM");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblBeneficio>(entity =>
            {
                entity.ToTable("NFSE_TBL_BENEFICIOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Vldesconto)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCONTO");
            });

            modelBuilder.Entity<NfseTblBoleto>(entity =>
            {
                entity.HasKey(e => e.Stnossonumero)
                    .HasName("PK__NFSE_TBL__E940A5A17F60ED59");

                entity.ToTable("NFSE_TBL_BOLETO");

                entity.Property(e => e.Stnossonumero)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("STNOSSONUMERO");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("date")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Dtvencimento)
                    .HasColumnType("date")
                    .HasColumnName("DTVENCIMENTO");

                entity.Property(e => e.Stcodigobarra)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCODIGOBARRA");

                entity.Property(e => e.Stlinhadigitavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STLINHADIGITAVEL");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<NfseTblBoletoNfse>(entity =>
            {
                entity.HasKey(e => new { e.Stnossonumero, e.Idnfse })
                    .HasName("PK__NFSE_TBL__BAC8C06803317E3D");

                entity.ToTable("NFSE_TBL_BOLETO_NFSE");

                entity.Property(e => e.Stnossonumero)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("STNOSSONUMERO");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");
            });

            modelBuilder.Entity<NfseTblCategorium>(entity =>
            {
                entity.HasKey(e => e.Idcategoria);

                entity.ToTable("NFSE_TBL_CATEGORIA");

                entity.Property(e => e.Idcategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCep>(entity =>
            {
                entity.HasKey(e => e.Idcep)
                    .HasName("PK__NFSE_TBL__91A91DBD07020F21");

                entity.ToTable("NFSE_TBL_CEP");

                entity.HasIndex(e => e.Stcep, "IDX_NFSE_TBL_CEP_STCEP")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idcidade, "IX_NFSE_TBL_CEP_IDCIDADE");

                entity.HasIndex(e => e.Stlogradourocompleto, "IX_NFSE_TBL_CEP_STLOGRADOUROCOMPLETO");

                entity.Property(e => e.Idcep)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCEP");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Stbairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STBAIRRO");

                entity.Property(e => e.Stcep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stcidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCIDADE");

                entity.Property(e => e.Stcomplemento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCOMPLEMENTO");

                entity.Property(e => e.Stlogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STLOGRADOURO");

                entity.Property(e => e.Stlogradourocompleto)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("STLOGRADOUROCOMPLETO");

                entity.Property(e => e.Sttipologradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOLOGRADOURO");
            });

            modelBuilder.Entity<NfseTblChat>(entity =>
            {
                entity.HasKey(e => e.Idchat);

                entity.ToTable("NFSE_TBL_CHAT");

                entity.Property(e => e.Idchat)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCHAT");

                entity.Property(e => e.Dtenviomsg)
                    .HasColumnType("datetime")
                    .HasColumnName("DTENVIOMSG");

                entity.Property(e => e.Dtrecebimentomsg)
                    .HasColumnType("datetime")
                    .HasColumnName("DTRECEBIMENTOMSG");

                entity.Property(e => e.Stmensagem)
                    .IsUnicode(false)
                    .HasColumnName("STMENSAGEM");

                entity.Property(e => e.Stusuariodestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIODESTINO");

                entity.Property(e => e.Stusuarioremetente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIOREMETENTE");
            });

            modelBuilder.Entity<NfseTblChatUsuarioLogado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_CHAT_USUARIO_LOGADO");

                entity.Property(e => e.Stusuariologado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIOLOGADO");
            });

            modelBuilder.Entity<NfseTblCidade>(entity =>
            {
                entity.HasKey(e => e.Idcidade);

                entity.ToTable("NFSE_TBL_CIDADE");

                entity.HasIndex(e => e.Stcodigoibge, "IDX_CIDADE_STCODIGOIBGE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Stnome, "IX_NFSE_TBL_CIDADE");

                entity.HasIndex(e => new { e.Idcidade, e.Stcodigoibge }, "IX_NFSE_TBL_CIDADE_IDCIDADE_STCODIGOIBGE");

                entity.HasIndex(e => new { e.Stcodigoibge, e.Idcidade, e.Stnome, e.Stuf }, "IX_NFSE_TBL_CIDADE_STCODIGOIBGE_IDCIDADE_STNOME_STUF");

                entity.Property(e => e.Idcidade)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCIDADE");

                entity.Property(e => e.Stcodigoibge).HasColumnName("STCODIGOIBGE");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stuf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STUF")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblCliente>(entity =>
            {
                entity.HasKey(e => e.Idcliente);

                entity.ToTable("NFSE_TBL_CLIENTE");

                entity.HasIndex(e => e.Stcpfcnpj, "IDX_CPFCPNPJ");

                entity.HasIndex(e => e.Idcidade, "IX_NFSE_TBL_CLIENTE_IDDICADE");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_CLIENTE_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_CLIENTE_IDEMPRESA_inc");

                entity.Property(e => e.Idcliente)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCLIENTE");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Stcep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.Stemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STEMAIL");

                entity.Property(e => e.StenderecoBairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_BAIRRO");

                entity.Property(e => e.StenderecoComplemento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_COMPLEMENTO");

                entity.Property(e => e.StenderecoLogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_LOGR");

                entity.Property(e => e.StenderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_NUMERO");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttelefone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("STTELEFONE");

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblClientes)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CLIENTE_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblCnaeClasse>(entity =>
            {
                entity.HasKey(e => e.IdcnaeClasse);

                entity.ToTable("NFSE_TBL_CNAE_CLASSE");

                entity.Property(e => e.IdcnaeClasse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_CLASSE")
                    .IsFixedLength();

                entity.Property(e => e.IdcnaeGrupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCnaeDivisao>(entity =>
            {
                entity.HasKey(e => e.IdcnaeDivisao)
                    .HasName("PK__NFSE_TBL__A6FD2B031273C1CD");

                entity.ToTable("NFSE_TBL_CNAE_DIVISAO");

                entity.Property(e => e.IdcnaeDivisao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_DIVISAO")
                    .IsFixedLength();

                entity.Property(e => e.IdcnaeSecao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SECAO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCnaeGrupo>(entity =>
            {
                entity.HasKey(e => e.IdcnaeGrupo)
                    .HasName("PK__NFSE_TBL__DB595207164452B1");

                entity.ToTable("NFSE_TBL_CNAE_GRUPO");

                entity.Property(e => e.IdcnaeGrupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_GRUPO")
                    .IsFixedLength();

                entity.Property(e => e.IdcnaeDivisao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_DIVISAO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCnaeSecao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_CNAE_SECAO");

                entity.Property(e => e.IdcnaeSecao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SECAO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCnaeServico>(entity =>
            {
                entity.HasKey(e => new { e.IdcnaeSubclasse, e.Idservico });

                entity.ToTable("NFSE_TBL_CNAE_SERVICOS");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblCnaeSubclasse>(entity =>
            {
                entity.HasKey(e => e.IdcnaeSubclasse)
                    .HasName("PK__NFSE_TBL__988B52501B0907CE");

                entity.ToTable("NFSE_TBL_CNAE_SUBCLASSE");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.IdcnaeClasse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_CLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Stativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATIVO")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblConfiguracao>(entity =>
            {
                entity.HasKey(e => e.Stcnpj)
                    .HasName("PK__NFSE_TBL__51B0BB9D1ED998B2");

                entity.ToTable("NFSE_TBL_CONFIGURACAO");

                entity.HasIndex(e => e.Idcidade, "IX_NFSE_TBL_CONFIGURACAO_IDCIDADE");

                entity.Property(e => e.Stcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJ");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Imlogo).HasColumnName("IMLOGO");

                entity.Property(e => e.Stcep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stdepartamento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STDEPARTAMENTO");

                entity.Property(e => e.Stemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STEMAIL");

                entity.Property(e => e.StenderecoBairro)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_BAIRRO");

                entity.Property(e => e.StenderecoComplemento)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_COMPLEMENTO");

                entity.Property(e => e.StenderecoLogr)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_LOGR");

                entity.Property(e => e.StenderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_NUMERO");

                entity.Property(e => e.Sthomepage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STHOMEPAGE");

                entity.Property(e => e.Stprefeitura)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STPREFEITURA");

                entity.Property(e => e.Stsecretaria)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STSECRETARIA");

                entity.Property(e => e.Sttelefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTELEFONE");
            });

            modelBuilder.Entity<NfseTblContaNota>(entity =>
            {
                entity.HasKey(e => new { e.Idconta, e.Idnfse });

                entity.ToTable("NFSE_TBL_CONTA_NOTAS");

                entity.HasIndex(e => e.Idnfse, "IDNFSE");

                entity.HasIndex(e => e.Stsituacao, "IDX_SITUACAO");

                entity.HasIndex(e => e.Idnfse, "IX_IDNFSE");

                entity.HasIndex(e => new { e.Idconta, e.Stsituacao }, "IX_NFSE_TBL_CONTA_NOTAS_IDCONTA_STSITUACAO");

                entity.HasIndex(e => e.Idconta, "IX_NFSE_TBL_CONTA_NOTAS_IDCONTA_inc_IDNFSE");

                entity.HasIndex(e => new { e.Idnfse, e.Stsituacao }, "IX_NFSE_TBL_CONTA_NOTAS_IDNFSE_STSITUACAO");

                entity.HasIndex(e => e.Stsituacao, "NFSE_TBL_CONTA_NOTAS_IDX_CONTA_NTOA");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.IdnfseSubstituta).HasColumnName("IDNFSE_SUBSTITUTA");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength()
                    .HasComment("C=Canelada; S=Substituída; N=Normal");

                entity.HasOne(d => d.IdcontaNavigation)
                    .WithMany(p => p.NfseTblContaNota)
                    .HasForeignKey(d => d.Idconta)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_NOTAS_NFSE_TBL_CONTA");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblContaNota)
                    .HasForeignKey(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_NOTAS_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblContaSocio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_CONTA_SOCIOS");

                entity.HasIndex(e => new { e.Idconta, e.Idempresasocio }, "IDX_CONTA_SOCIO");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Idempresasocio).HasColumnName("IDEMPRESASOCIO");

                entity.HasOne(d => d.IdcontaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idconta)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_SOCIOS_NFSE_TBL_CONTA");

                entity.HasOne(d => d.IdempresasocioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idempresasocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_SOCIOS_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblContador>(entity =>
            {
                entity.HasKey(e => e.Stcrc)
                    .HasName("PK__NFSE_TBL__E2468CC422AA2996");

                entity.ToTable("NFSE_TBL_CONTADOR");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_CONTADOR_IDCONTRIBUINTE");

                entity.Property(e => e.Stcrc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STCRC");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblContribuinte>(entity =>
            {
                entity.HasKey(e => e.Idcontribuinte)
                    .HasName("PK__NFSE_TBL__DB71A471276EDEB3");

                entity.ToTable("NFSE_TBL_CONTRIBUINTE");

                entity.HasIndex(e => e.Idcidade, "IDCIDADE");

                entity.HasIndex(e => e.Stim, "IDX_IM");

                entity.HasIndex(e => e.Stnome, "IDX_NOME");

                entity.HasIndex(e => new { e.Idcontribuinte, e.Stcpfcnpj, e.Idcidade, e.Stnome }, "IX_NFSE_TBL_CONTRIBUINTE");

                entity.HasIndex(e => e.Conid, "IX_NFSE_TBL_CONTRIBUINTE_CONID");

                entity.HasIndex(e => e.Idcidadecorresp, "IX_NFSE_TBL_CONTRIBUINTE_IDCIDADECORRESP");

                entity.HasIndex(e => new { e.Idcontribuinte, e.Stnome, e.Stim }, "IX_NFSE_TBL_CONTRIBUINTE_IDCONTRIBUINTE_STNOME_STIM");

                entity.HasIndex(e => new { e.Stcpfcnpj, e.Idcontribuinte, e.Stnome }, "IX_NFSE_TBL_CONTRIBUINTE_STCPFCNPJ_IDCONTRIBUINTE_STNOME");

                entity.HasIndex(e => new { e.Stcpfcnpj, e.Idcontribuinte }, "IX_NFSE_TBL_CONTRIBUINTE_STCPFCNPJ_IDCONTRIBUINTE_inc_STNOME");

                entity.HasIndex(e => new { e.Stim, e.Idcontribuinte, e.Stcpfcnpj }, "IX_NFSE_TBL_CONTRIBUINTE_STIM_IDCONTRIBUINTE_STCPFCNPJ");

                entity.HasIndex(e => e.Stcpfcnpj, "STCPFCNPJ")
                    .HasFillFactor(90);

                entity.Property(e => e.Idcontribuinte)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Cadorigem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CADORIGEM");

                entity.Property(e => e.Conid).HasColumnName("CONID");

                entity.Property(e => e.Dtcadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCADASTRO");

                entity.Property(e => e.Idcidade).HasColumnName("IDCIDADE");

                entity.Property(e => e.Idcidadecorresp).HasColumnName("IDCIDADECORRESP");

                entity.Property(e => e.Stcep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stcepcorresp)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEPCORRESP");

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.Stemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STEMAIL");

                entity.Property(e => e.Stendbairrocorresp)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDBAIRROCORRESP");

                entity.Property(e => e.Stendcomplcorresp)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDCOMPLCORRESP");

                entity.Property(e => e.Stendcorresp)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STENDCORRESP");

                entity.Property(e => e.StenderecoBairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_BAIRRO");

                entity.Property(e => e.StenderecoComplemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_COMPLEMENTO");

                entity.Property(e => e.StenderecoLogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_LOGR");

                entity.Property(e => e.StenderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_NUMERO");

                entity.Property(e => e.Stfax)
                    .HasMaxLength(17)
                    .HasColumnName("STFAX")
                    .IsFixedLength();

                entity.Property(e => e.Stie)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIE");

                entity.Property(e => e.Stii)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("STII");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stnumcorresp)
                    .HasMaxLength(10)
                    .HasColumnName("STNUMCORRESP")
                    .IsFixedLength();

                entity.Property(e => e.Stobrigarecad).HasColumnName("STOBRIGARECAD");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttelefone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("STTELEFONE");

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblContribuintesBeneficio>(entity =>
            {
                entity.ToTable("NFSE_TBL_CONTRIBUINTES_BENEFICIOS");

                entity.HasIndex(e => e.Idbeneficio, "IX_NFSE_TBL_CONTRIBUINTES_BENEFICIOS_IDBENEFICIO");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_CONTRIBUINTES_BENEFICIOS_IDCONTRIBUINTE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Idbeneficio).HasColumnName("IDBENEFICIO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                entity.HasOne(d => d.IdbeneficioNavigation)
                    .WithMany(p => p.NfseTblContribuintesBeneficios)
                    .HasForeignKey(d => d.Idbeneficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CONTRIBUINTES_BENEFICIOS_NFSE_TBL_BENEFICIOS");

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblContribuintesBeneficios)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CONTRIBUINTES_BENEFICIOS_NFSE_TBL_CONTRIBUINTE");
            });

            modelBuilder.Entity<NfseTblContum>(entity =>
            {
                entity.HasKey(e => e.Idconta);

                entity.ToTable("NFSE_TBL_CONTA");

                entity.HasIndex(e => e.Idcontaestorno, "IDX_CONTAESTORNO");

                entity.HasIndex(e => new { e.Idempresa, e.Idconta, e.Numescompetencia, e.Nuanocompetencia }, "IX_NFSE_TBL_CONTA");

                entity.HasIndex(e => new { e.Idempresa, e.Numescompetencia, e.Nuanocompetencia, e.Sttipo, e.Idcontaestorno, e.Ststatus, e.Idconta, e.Dtdatalcto }, "IX_NFSE_TBL_CONTA_28_1129771082__K2_K4_K5_K7_K13_K15_K1_K6_3_8_9_10_11_12_14_16");

                entity.HasIndex(e => e.Idcontaestorno, "IX_NFSE_TBL_CONTA_IDCONTAESTORNO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_CONTA_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_CONTA_IDUSUARIO")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuarioadm, "IX_NFSE_TBL_CONTA_IDUSUARIOADM");

                entity.HasIndex(e => new { e.Numescompetencia, e.Nuanocompetencia, e.Sttiporecolhimento, e.Idconta }, "IX_NFSE_TBL_CONTA_NUMESCOMPETENCIA_NUANOCOMPETENCIA_STTIPORECOLHIMENTO_IDCONTA");

                entity.HasIndex(e => new { e.Stsituacao, e.Idconta }, "IX_NFSE_TBL_CONTA_STSITUACAO_IDCONTA");

                entity.HasIndex(e => e.Stsituacao, "IX_NFSE_TBL_CONTA_STSITUACAO_inc_IDCONTA_IDEMPRESA");

                entity.HasIndex(e => new { e.Ststatus, e.Idempresa, e.Dtdatalcto }, "IX_NFSE_TBL_CONTA_STSTATUS_IDEMPRESA_DTDATALCTO");

                entity.HasIndex(e => e.Idcontaestorno, "NFSE_TBL_CONTA_ESTORNO_IDX_NFSE_DECLARADA_CONTA_ESTORNADA");

                entity.Property(e => e.Idconta)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCONTA");

                entity.Property(e => e.Dtdatalcto)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATALCTO");

                entity.Property(e => e.Dtdatapagamento)
                    .HasColumnType("date")
                    .HasColumnName("DTDATAPAGAMENTO");

                entity.Property(e => e.Idcontaestorno).HasColumnName("IDCONTAESTORNO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO")
                    .HasComment("ATENÇÃO! Este atributo está temporariamente como varchar por causa de uma cagada q o Antônio fez.. mas como conversado com o Godoy, isso será corrigido mais a frente");

                entity.Property(e => e.Idusuarioadm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOADM")
                    .HasComment("Usuário da plataforma Giig");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Sterros)
                    .IsUnicode(false)
                    .HasColumnName("STERROS");

                entity.Property(e => e.Stobservacao)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Ststatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO")
                    .IsFixedLength()
                    .HasComment("Crédito / Débito");

                entity.Property(e => e.Sttipodeclaracao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPODECLARACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO")
                    .IsFixedLength();

                entity.Property(e => e.Vltotal)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTAL");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblConta)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_NFSE_TBL_EMPRESA1");

                entity.HasMany(d => d.Iddeclaracaoapuracaos)
                    .WithMany(p => p.Idconta)
                    .UsingEntity<Dictionary<string, object>>(
                        "NfseTblContaDeclaracaoApuracao",
                        l => l.HasOne<DesifIdentificacaoDeclaracao>().WithMany().HasForeignKey("Iddeclaracaoapuracao").HasConstraintName("FK_NFSE_TBL_CONTA_DECLARACAO_APURACAO_DESIF_IdentificacaoDeclaracao"),
                        r => r.HasOne<NfseTblContum>().WithMany().HasForeignKey("Idconta").HasConstraintName("FK_NFSE_TBL_CONTA_DECLARACAO_APURACAO_NFSE_TBL_CONTA"),
                        j =>
                        {
                            j.HasKey("Idconta", "Iddeclaracaoapuracao");

                            j.ToTable("NFSE_TBL_CONTA_DECLARACAO_APURACAO");

                            j.IndexerProperty<int>("Idconta").HasColumnName("IDCONTA");

                            j.IndexerProperty<int>("Iddeclaracaoapuracao").HasColumnName("IDDECLARACAOAPURACAO");
                        });
            });

            modelBuilder.Entity<NfseTblCredenciamento>(entity =>
            {
                entity.HasKey(e => e.Idcredenciamento);

                entity.ToTable("NFSE_TBL_CREDENCIAMENTO");

                entity.HasIndex(e => new { e.Idempresa, e.Idcontribuinte }, "IDX_EMPRESA_CONTRIBUINTE");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_CREDENCIAMENTO_IDCONTRIBUINTE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_CREDENCIAMENTO_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_CREDENCIAMENTO_IDUSUARIO")
                    .HasFillFactor(90);

                entity.Property(e => e.Idcredenciamento)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCREDENCIAMENTO");

                entity.Property(e => e.Dtdescred)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDESCRED");

                entity.Property(e => e.Dtinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINCLUSAO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Idusuarioincluido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOINCLUIDO");

                entity.Property(e => e.Stcargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCARGO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblCredenciamentos)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CREDENCIAMENTO_NFSE_TBL_CONTRIBUINTE");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblCredenciamentos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CREDENCIAMENTO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblCredenciamentos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CREDENCIAMENTO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblCronograma>(entity =>
            {
                entity.HasKey(e => e.Idcronograma);

                entity.ToTable("NFSE_TBL_CRONOGRAMA");

                entity.Property(e => e.Idcronograma)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCRONOGRAMA");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("date")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblCronogramaServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_CRONOGRAMA_SERVICOS");

                entity.Property(e => e.Idcronograma).HasColumnName("IDCRONOGRAMA");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdcronogramaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idcronograma)
                    .HasConstraintName("FK_NFSE_TBL_CRONOGRAMA_SERVICOS_NFSE_TBL_CRONOGRAMA");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_CRONOGRAMA_SERVICOS_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblDa>(entity =>
            {
                entity.HasKey(e => e.Iddas);

                entity.ToTable("NFSE_TBL_DAS");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_DAS_IDEMPRESA");

                entity.Property(e => e.Iddas)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDAS");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("date")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Dtdeclaracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDECLARACAO");

                entity.Property(e => e.Dtlimiteacolh)
                    .HasColumnType("date")
                    .HasColumnName("DTLIMITEACOLH");

                entity.Property(e => e.Dtpagamento)
                    .HasColumnType("date")
                    .HasColumnName("DTPAGAMENTO");

                entity.Property(e => e.Dtvencimento)
                    .HasColumnType("date")
                    .HasColumnName("DTVENCIMENTO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Numes).HasColumnName("NUMES");

                entity.Property(e => e.Nunumerodoc)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("NUNUMERODOC");

                entity.Property(e => e.Pcaliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PCALIQUOTA");

                entity.Property(e => e.Stcnpjresponsavel)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCNPJRESPONSAVEL");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vljuroencargo)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLJUROENCARGO");

                entity.Property(e => e.Vlmulta)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLMULTA");

                entity.Property(e => e.Vlprincipal)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLPRINCIPAL");

                entity.Property(e => e.Vlreceitabruta)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLRECEITABRUTA");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<NfseTblDasContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_DAS_CONTA");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Iddas).HasColumnName("IDDAS");

                entity.HasOne(d => d.IdcontaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idconta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_DAS_CONTA_NFSE_TBL_CONTA");

                entity.HasOne(d => d.IddasNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Iddas)
                    .HasConstraintName("FK_NFSE_TBL_DAS_CONTA_NFSE_TBL_DAS");
            });

            modelBuilder.Entity<NfseTblDeclaracaoAuto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_DECLARACAO_AUTO");

                entity.HasIndex(e => new { e.Idlogdecauto, e.Iddeclaracao, e.Idencerramento, e.Idempresa }, "IX_NFSE_TBL_DECLARACAO_AUTO");

                entity.HasIndex(e => e.Iddeclaracao, "IX_NFSE_TBL_DECLARACAO_AUTO_IDDECLARACAO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_DECLARACAO_AUTO_IDEMPRESA");

                entity.HasIndex(e => e.Idencerramento, "IX_NFSE_TBL_DECLARACAO_AUTO_IDENCERRAMENTO");

                entity.HasIndex(e => e.Idlogdecauto, "IX_NFSE_TBL_DECLARACAO_AUTO_IDLOGDECAUTO");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idencerramento).HasColumnName("IDENCERRAMENTO");

                entity.Property(e => e.Idlogdecauto).HasColumnName("IDLOGDECAUTO");

                entity.HasOne(d => d.IddeclaracaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Iddeclaracao)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_AUTO_NFSE_TBL_CONTA1");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_AUTO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdencerramentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idencerramento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_AUTO_NFSE_TBL_ENCERRAMENTO");

                entity.HasOne(d => d.IdlogdecautoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idlogdecauto)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_AUTO_NFSE_TBL_LOG_DECLARACAO_AUTO");
            });

            modelBuilder.Entity<NfseTblDeclaracaoExtravio>(entity =>
            {
                entity.HasKey(e => e.Iddecextravio);

                entity.ToTable("NFSE_TBL_DECLARACAO_EXTRAVIO");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_DECLARACAO_EXTRAVIO_IDCONTRIBUINTE");

                entity.HasIndex(e => e.Idtipodec, "IX_NFSE_TBL_DECLARACAO_EXTRAVIO_IDTIPODEC");

                entity.Property(e => e.Iddecextravio)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDECEXTRAVIO");

                entity.Property(e => e.Barquivocompr).HasColumnName("BARQUIVOCOMPR");

                entity.Property(e => e.Dtcomprovante)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCOMPROVANTE");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Dtextravio)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEXTRAVIO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idtipodec).HasColumnName("IDTIPODEC");

                entity.Property(e => e.Stnmarquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STNMARQUIVO");

                entity.Property(e => e.Stobservacoes)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACOES");

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoExtravios)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_EXTRAVIO_NFSE_TBL_CONTRIBUINTE");
            });

            modelBuilder.Entity<NfseTblDeclaracaoExtravioNfse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_DECLARACAO_EXTRAVIO_NFSE");

                entity.Property(e => e.Iddecextravio).HasColumnName("IDDECEXTRAVIO");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.HasOne(d => d.IddecextravioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Iddecextravio)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_EXTRAVIO_NFSE_NFSE_TBL_DECLARACAO_EXTRAVIO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_EXTRAVIO_NFSE_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblDeclaracaoPendente>(entity =>
            {
                entity.HasKey(e => e.Iddeclaracaopendente);

                entity.ToTable("NFSE_TBL_DECLARACAO_PENDENTE");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_DECLARACAO_PENDENTE_IDEMPRESA");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_DECLARACAO_PENDENTE_IDNFSE");

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_DECLARACAO_PENDENTE_IDREGIME");

                entity.Property(e => e.Iddeclaracaopendente).HasColumnName("IDDECLARACAOPENDENTE");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Dtpagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPAGAMENTO");

                entity.Property(e => e.Flprocessado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLPROCESSADO")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idregime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDREGIME")
                    .IsFixedLength();

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nunumero).HasColumnName("NUNUMERO");

                entity.Property(e => e.Stenviaporemail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENVIAPOREMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Stissretido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STISSRETIDO")
                    .IsFixedLength();

                entity.Property(e => e.Strecolheiss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECOLHEISS")
                    .IsFixedLength();

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttompessoatipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTOMPESSOATIPO")
                    .IsFixedLength();

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotaliss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALISS");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoPendentes)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_PENDENTE_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoPendentes)
                    .HasForeignKey(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_PENDENTE_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblDeclaracaoSemIncidenciaNfse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE");

                entity.HasIndex(e => new { e.Iddeclaracao, e.Idnfse }, "IX_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE");

                entity.HasIndex(e => e.Iddeclaracao, "IX_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_IDDECLARACAO");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_IDNFSE");

                entity.Property(e => e.Iddeclaracao).HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.HasOne(d => d.IddeclaracaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Iddeclaracao)
                    .HasConstraintName("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblDeclaracaoSemIncidencium>(entity =>
            {
                entity.HasKey(e => e.Iddeclaracao)
                    .HasName("PK__NFSE_TBL__AD6FC92C5BB889C0");

                entity.ToTable("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_IDEMPRESA");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_IDUSUARIO");

                entity.Property(e => e.Iddeclaracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Numes).HasColumnName("NUMES");

                entity.Property(e => e.Stdeclaracao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STDECLARACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoSemIncidencia)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoSemIncidencia)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("NFSE_TBL_DECLARACAO_SEM_INCIDENCIA_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblDeclaracaoSemMovimento>(entity =>
            {
                entity.HasKey(e => e.Iddeclaracao);

                entity.ToTable("NFSE_TBL_DECLARACAO_SEM_MOVIMENTO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idtipodeclaracao, "IX_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_IDTIPODECLARACAO");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_IDUSUARIO")
                    .HasFillFactor(90);

                entity.Property(e => e.Iddeclaracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDECLARACAO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idtipodeclaracao).HasColumnName("IDTIPODECLARACAO");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Numes).HasColumnName("NUMES");

                entity.Property(e => e.Stdeclaracao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STDECLARACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoSemMovimentos)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdtipodeclaracaoNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoSemMovimentos)
                    .HasForeignKey(d => d.Idtipodeclaracao)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_NFSE_TBL_TIPO_DECLARACAO");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblDeclaracaoSemMovimentos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblEcfIntervencao>(entity =>
            {
                entity.HasKey(e => e.Idecfint)
                    .HasName("PK_NFSE_TBL_INTERVENCAO_ECF");

                entity.ToTable("NFSE_TBL_ECF_INTERVENCAO");

                entity.Property(e => e.Idecfint)
                    .ValueGeneratedNever()
                    .HasColumnName("IDECFINT");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idempresacred).HasColumnName("IDEMPRESACRED");

                entity.Property(e => e.Idmotinterven).HasColumnName("IDMOTINTERVEN");

                entity.Property(e => e.Idtipomodelo).HasColumnName("IDTIPOMODELO");

                entity.Property(e => e.Idversoftbasico).HasColumnName("IDVERSOFTBASICO");

                entity.Property(e => e.Nucooantes).HasColumnName("NUCOOANTES");

                entity.Property(e => e.Nucooapos).HasColumnName("NUCOOAPOS");

                entity.Property(e => e.Nucroantes).HasColumnName("NUCROANTES");

                entity.Property(e => e.Nucroapos).HasColumnName("NUCROAPOS");

                entity.Property(e => e.Nucrzantes).HasColumnName("NUCRZANTES");

                entity.Property(e => e.Nucrzapos).HasColumnName("NUCRZAPOS");

                entity.Property(e => e.Nufabricacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUFABRICACAO");

                entity.Property(e => e.Nuordemseque).HasColumnName("NUORDEMSEQUE");

                entity.Property(e => e.Nuserie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUSERIE");

                entity.Property(e => e.Nutotalgeraantes).HasColumnName("NUTOTALGERAANTES");

                entity.Property(e => e.Nutotalgeraapos).HasColumnName("NUTOTALGERAAPOS");

                entity.Property(e => e.Stobservacoes)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACOES");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblEcfLacre>(entity =>
            {
                entity.HasKey(e => e.Idlacre);

                entity.ToTable("NFSE_TBL_ECF_LACRE");

                entity.Property(e => e.Idlacre)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLACRE");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idecfint).HasColumnName("IDECFINT");

                entity.Property(e => e.Idtipolacre).HasColumnName("IDTIPOLACRE");

                entity.Property(e => e.Stlacrecoloc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STLACRECOLOC");

                entity.Property(e => e.Stlacreremov)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STLACREREMOV");
            });

            modelBuilder.Entity<NfseTblEcfMarca>(entity =>
            {
                entity.HasKey(e => e.Idmarca);

                entity.ToTable("NFSE_TBL_ECF_MARCA");

                entity.Property(e => e.Idmarca)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMARCA");

                entity.Property(e => e.Stmarca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STMARCA");
            });

            modelBuilder.Entity<NfseTblEcfModelo>(entity =>
            {
                entity.HasKey(e => e.Idmodelo);

                entity.ToTable("NFSE_TBL_ECF_MODELO");

                entity.Property(e => e.Idmodelo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMODELO");

                entity.Property(e => e.Idmarca).HasColumnName("IDMARCA");

                entity.Property(e => e.Stmodelo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STMODELO");

                entity.HasOne(d => d.IdmarcaNavigation)
                    .WithMany(p => p.NfseTblEcfModelos)
                    .HasForeignKey(d => d.Idmarca)
                    .HasConstraintName("FK_NFSE_TBL_ECF_MODELO_NFSE_TBL_ECF_MARCA");
            });

            modelBuilder.Entity<NfseTblEcfTipo>(entity =>
            {
                entity.HasKey(e => e.Idtipo);

                entity.ToTable("NFSE_TBL_ECF_TIPO");

                entity.Property(e => e.Idtipo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTIPO");

                entity.Property(e => e.Idmodelo).HasColumnName("IDMODELO");

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO");
            });

            modelBuilder.Entity<NfseTblEcfVersaosoftware>(entity =>
            {
                entity.HasKey(e => e.Idversao);

                entity.ToTable("NFSE_TBL_ECF_VERSAOSOFTWARE");

                entity.Property(e => e.Idversao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDVERSAO");

                entity.Property(e => e.Idtipo).HasColumnName("IDTIPO");

                entity.Property(e => e.Stversao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STVERSAO");
            });

            modelBuilder.Entity<NfseTblEleicaoDetalhe>(entity =>
            {
                entity.HasKey(e => e.Ideleicao);

                entity.ToTable("NFSE_TBL_ELEICAO_DETALHE");

                entity.HasIndex(e => new { e.Idarquivo, e.Cnpj }, "IX_NFSE_TBL_ELEICAO_DETALHE_IDARQUIVO_CNPJ");

                entity.HasIndex(e => e.Idarquivo, "IX_NFSE_TBL_ELEICAO_DETALHE_IDARQUIVO_inc_CNPJ");

                entity.Property(e => e.Ideleicao).HasColumnName("IDELEICAO");

                entity.Property(e => e.CnaePrincipal)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("CNAE_PRINCIPAL");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.DataInsercao)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_INSERCAO");

                entity.Property(e => e.Idarquivo).HasColumnName("IDARQUIVO");

                entity.Property(e => e.NaturezaJuridica)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NATUREZA_JURIDICA");

                entity.Property(e => e.Nome)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.TipoPrestador)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRESTADOR")
                    .IsFixedLength();

                entity.HasOne(d => d.IdarquivoNavigation)
                    .WithMany(p => p.NfseTblEleicaoDetalhes)
                    .HasForeignKey(d => d.Idarquivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_ELEICAO_DETALHE_NFSE_TBL_ELEICAO_HEADER");
            });

            modelBuilder.Entity<NfseTblEleicaoHeader>(entity =>
            {
                entity.HasKey(e => e.Idarquivo)
                    .HasName("PK_NFSE_TBL_ARQUIVO_ELEICAO");

                entity.ToTable("NFSE_TBL_ELEICAO_HEADER");

                entity.Property(e => e.Idarquivo).HasColumnName("IDARQUIVO");

                entity.Property(e => e.DataGeracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_GERACAO");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                entity.Property(e => e.NomeLeiaute)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_LEIAUTE");

                entity.Property(e => e.Versao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VERSAO");
            });

            modelBuilder.Entity<NfseTblEleicoesCandidato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_ELEICOES_CANDIDATOS");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<NfseTblEleicoesLote>(entity =>
            {
                entity.ToTable("NFSE_TBL_ELEICOES_LOTES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bnarquivo).HasColumnName("BNARQUIVO");

                entity.Property(e => e.Dtgeracao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTGERACAO");

                entity.Property(e => e.Nulote).HasColumnName("NULOTE");

                entity.Property(e => e.Nuloteremcorrec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NULOTEREMCORREC")
                    .IsFixedLength();

                entity.Property(e => e.Nuprotocolo).HasColumnName("NUPROTOCOLO");

                entity.Property(e => e.Nuremessa).HasColumnName("NUREMESSA");

                entity.Property(e => e.Nuremessacorrec).HasColumnName("NUREMESSACORREC");

                entity.Property(e => e.Sttipoarquivo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOARQUIVO");

                entity.Property(e => e.Stusuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIO");
            });

            modelBuilder.Entity<NfseTblEmpresa>(entity =>
            {
                entity.HasKey(e => e.Idempresa)
                    .HasName("PK__NFSE_TBL__DAD77F8E2F10007B");

                entity.ToTable("NFSE_TBL_EMPRESA");

                entity.HasIndex(e => e.Idcontribuinte, "IDCONTRIBUINTE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_DECLARACAO_SEM_MOVIMENTO_IDREGIME")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idempresa, e.Idregime, e.Idcontribuinte }, "IX_NFSE_TBL_EMPRESA");

                entity.HasIndex(e => e.Idempresamatriz, "IX_NFSE_TBL_EMPRESA_IDEMPRESAMATRIZ");

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_EMPRESA_IDREGIME");

                entity.HasIndex(e => e.Stsubtributario, "STSUBTRIBUTARIO");

                entity.Property(e => e.Idempresa)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEMPRESA");

                entity.Property(e => e.Dtabertura)
                    .HasColumnType("datetime")
                    .HasColumnName("DTABERTURA");

                entity.Property(e => e.Dtadesaosubstituto)
                    .HasColumnType("datetime")
                    .HasColumnName("DTADESAOSUBSTITUTO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idempresamatriz).HasColumnName("IDEMPRESAMATRIZ");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Nuprocabertura)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUPROCABERTURA");

                entity.Property(e => e.Stcontadorcpfcnpj)
                    .HasMaxLength(14)
                    .HasColumnName("STCONTADORCPFCNPJ")
                    .IsFixedLength();

                entity.Property(e => e.Stcontadorend)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STCONTADOREND");

                entity.Property(e => e.Stcontadornome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCONTADORNOME");

                entity.Property(e => e.Stcontadortel)
                    .HasMaxLength(17)
                    .HasColumnName("STCONTADORTEL")
                    .IsFixedLength();

                entity.Property(e => e.Stcrc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STCRC");

                entity.Property(e => e.Stobrigarecad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOBRIGARECAD")
                    .IsFixedLength();

                entity.Property(e => e.Stoptsimnac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOPTSIMNAC")
                    .IsFixedLength();

                entity.Property(e => e.Stpejudipu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STPEJUDIPU")
                    .IsFixedLength();

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stsubtributario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSUBTRIBUTARIO")
                    .IsFixedLength();

                entity.Property(e => e.Sttptributacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTPTRIBUTACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblEmpresas)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_NFSE_TBL_CONTRIBUINTE");
            });

            modelBuilder.Entity<NfseTblEmpresaCnae>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.IdcnaeSubclasse })
                    .HasName("PK__NFSE_TBL__C35FCAAB33D4B598");

                entity.ToTable("NFSE_TBL_EMPRESA_CNAE");

                entity.HasIndex(e => new { e.Idempresa, e.IdcnaeSubclasse }, "IDX_EMPRESA_CNAE");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.DataFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dataFinal");

                entity.Property(e => e.DataInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("dataInicial");

                entity.HasOne(d => d.IdcnaeSubclasseNavigation)
                    .WithMany(p => p.NfseTblEmpresaCnaes)
                    .HasForeignKey(d => d.IdcnaeSubclasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CNAE_NFSE_TBL_CNAE_SUBCLASSE");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaCnaes)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CNAE_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblEmpresaContrato>(entity =>
            {
                entity.HasKey(e => e.Idempcont);

                entity.ToTable("NFSE_TBL_EMPRESA_CONTRATOS");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_CONTRATOS_IDEMPRESA");

                entity.HasIndex(e => e.Idendcidade, "IX_NFSE_TBL_EMPRESA_CONTRATOS_IDENDCIDADE");

                entity.Property(e => e.Idempcont)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEMPCONT");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idendcidade).HasColumnName("IDENDCIDADE");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nuendnumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUENDNUMERO")
                    .IsFixedLength();

                entity.Property(e => e.Nunumerocont)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUNUMEROCONT");

                entity.Property(e => e.Stdescricao)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stendbairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDBAIRRO");

                entity.Property(e => e.Stendcep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STENDCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stendcomplemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDCOMPLEMENTO");

                entity.Property(e => e.Stendlogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STENDLOGR");

                entity.Property(e => e.Stresponsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STRESPONSAVEL");

                entity.Property(e => e.Sttomcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STTOMCPFCNPJ");

                entity.Property(e => e.Sttomrazaosocial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STTOMRAZAOSOCIAL");

                entity.Property(e => e.Sttomtelefone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("STTOMTELEFONE");

                entity.Property(e => e.Stunidadeeconomica)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STUNIDADEECONOMICA")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdendcidadeNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratos)
                    .HasForeignKey(d => d.Idendcidade)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_NFSE_TBL_CIDADE");
            });

            modelBuilder.Entity<NfseTblEmpresaContratosAnexo>(entity =>
            {
                entity.HasKey(e => e.Idempconanexo);

                entity.ToTable("NFSE_TBL_EMPRESA_CONTRATOS_ANEXOS");

                entity.HasIndex(e => e.Idempcont, "IX_NFSE_TBL_EMPRESA_CONTRATOS_ANEXOS_IDEMPCONT");

                entity.Property(e => e.Idempconanexo).HasColumnName("IDEMPCONANEXO");

                entity.Property(e => e.Binarquivo).HasColumnName("BINARQUIVO");

                entity.Property(e => e.Dtanexo)
                    .HasColumnType("datetime")
                    .HasColumnName("DTANEXO");

                entity.Property(e => e.Idempcont).HasColumnName("IDEMPCONT");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stextensao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STEXTENSAO");

                entity.HasOne(d => d.IdempcontNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratosAnexos)
                    .HasForeignKey(d => d.Idempcont)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_ANEXOS_NFSE_TBL_EMPRESA_CONTRATOS");
            });

            modelBuilder.Entity<NfseTblEmpresaContratosHomologacao>(entity =>
            {
                entity.HasKey(e => e.Idempconthomo);

                entity.ToTable("NFSE_TBL_EMPRESA_CONTRATOS_HOMOLOGACAO");

                entity.Property(e => e.Idempconthomo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEMPCONTHOMO");

                entity.Property(e => e.Dtavaliacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTAVALIACAO");

                entity.Property(e => e.Dtexecucaofim)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEXECUCAOFIM");

                entity.Property(e => e.Dtexecucaoini)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEXECUCAOINI");

                entity.Property(e => e.Dtsolicitacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSOLICITACAO");

                entity.Property(e => e.Idempcont).HasColumnName("IDEMPCONT");

                entity.Property(e => e.Idusuarioavaliou)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOAVALIOU");

                entity.Property(e => e.Idusuariosolicitou)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOSOLICITOU");

                entity.Property(e => e.Nutipovigencia).HasColumnName("NUTIPOVIGENCIA");

                entity.Property(e => e.Stparecer)
                    .IsUnicode(false)
                    .HasColumnName("STPARECER");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO")
                    .IsFixedLength();

                entity.Property(e => e.Vlservico)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICO");

                entity.HasOne(d => d.IdusuariosolicitouNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratosHomologacaos)
                    .HasForeignKey(d => d.Idusuariosolicitou)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_HOMOLOGACAO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblEmpresaContratosNfse>(entity =>
            {
                entity.HasKey(e => new { e.Idnfse, e.Idempconthomo });

                entity.ToTable("NFSE_TBL_EMPRESA_CONTRATOS_NFSE");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idempconthomo).HasColumnName("IDEMPCONTHOMO");
            });

            modelBuilder.Entity<NfseTblEmpresaContratosServico>(entity =>
            {
                entity.HasKey(e => new { e.Idempcont, e.Idservico })
                    .HasName("PK__NFSE_TBL__5B4F78196E0C4425");

                entity.ToTable("NFSE_TBL_EMPRESA_CONTRATOS_SERVICOS");

                entity.Property(e => e.Idempcont).HasColumnName("IDEMPCONT");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Stpermite)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STPERMITE")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempcontNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratosServicos)
                    .HasForeignKey(d => d.Idempcont)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_SERVICOS_NFSE_TBL_EMPRESA_CONTRATOS");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany(p => p.NfseTblEmpresaContratosServicos)
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_CONTRATOS_SERVICOS_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblEmpresaIncentivoFiscal>(entity =>
            {
                entity.HasKey(e => e.Idempincfisc);

                entity.ToTable("NFSE_TBL_EMPRESA_INCENTIVO_FISCAL");

                entity.Property(e => e.Idempincfisc)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEMPINCFISC");

                entity.Property(e => e.Datainclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAINCLUSAO");

                entity.Property(e => e.Dtvigenciafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DTVIGENCIAFINAL");

                entity.Property(e => e.Dtvigenciainicial)
                    .HasColumnType("datetime")
                    .HasColumnName("DTVIGENCIAINICIAL");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idincentivo).HasColumnName("IDINCENTIVO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Staliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("STALIQUOTA");

                entity.Property(e => e.Stobservacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<NfseTblEmpresaNaturezaOperaco>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.Idoperacao });

                entity.ToTable("NFSE_TBL_EMPRESA_NATUREZA_OPERACOES");

                entity.HasIndex(e => new { e.Idempresa, e.Idoperacao }, "IDX_EMPRESA_OPERACAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaNaturezaOperacos)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_NATUREZA_OPERACOES_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblEmpresaPerfil>(entity =>
            {
                entity.HasKey(e => e.Idperfil);

                entity.ToTable("NFSE_TBL_EMPRESA_PERFIL");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_PERFIL_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idempresa, e.Idperfil }, "IX_NFSE_TBL_EMPRESA_PERFIL_IDEMPRESA_IDPERFIL");

                entity.HasIndex(e => new { e.Idempresa, e.Idperfil, e.Stnomefantasia }, "IX_NFSE_TBL_EMPRESA_PERFIL_IDEMPRESA_IDPERFIL_STNOMEFANTASIA_inc_IMLOGO");

                entity.Property(e => e.Idperfil)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPERFIL");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Imlogo).HasColumnName("IMLOGO");

                entity.Property(e => e.StautorizaContadorRps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAUTORIZA_CONTADOR_RPS")
                    .IsFixedLength();

                entity.Property(e => e.StcontatoEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_EMAIL");

                entity.Property(e => e.StcontatoNome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_NOME");

                entity.Property(e => e.StcontatoTelefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_TELEFONE");

                entity.Property(e => e.Stemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STEMAIL");

                entity.Property(e => e.Stfraseseguranca)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STFRASESEGURANCA");

                entity.Property(e => e.Stincentivadorcultural)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINCENTIVADORCULTURAL")
                    .IsFixedLength();

                entity.Property(e => e.Stnomefantasia)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STNOMEFANTASIA");

                entity.Property(e => e.Stobservacoes)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACOES");

                entity.Property(e => e.Strazaosocial)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STRAZAOSOCIAL");

                entity.Property(e => e.Stresume)
                    .HasColumnType("text")
                    .HasColumnName("STRESUME");

                entity.Property(e => e.Stsite)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STSITE");

                entity.Property(e => e.Sttipoempresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOEMPRESA")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaPerfils)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_PERFIL_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblEmpresaPerfilHistorico>(entity =>
            {
                entity.HasKey(e => e.Idempperhis);

                entity.ToTable("NFSE_TBL_EMPRESA_PERFIL_HISTORICO");

                entity.HasIndex(e => e.Idperfil, "IDX_IDPERFIL");

                entity.Property(e => e.Idempperhis).HasColumnName("IDEMPPERHIS");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idperfil).HasColumnName("IDPERFIL");

                entity.Property(e => e.Imlogo).HasColumnName("IMLOGO");
            });

            modelBuilder.Entity<NfseTblEmpresaRegime>(entity =>
            {
                entity.HasKey(e => e.IdempresaSn)
                    .HasName("PK__NFSE_TBL__7C90D09837A5467C");

                entity.ToTable("NFSE_TBL_EMPRESA_REGIME");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_REGIME_IDEMPRESA");

                entity.Property(e => e.IdempresaSn)
                    .ValueGeneratedNever()
                    .HasColumnName("IDEMPRESA_SN");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Stregime)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STREGIME")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblEmpresaRegimeHistorico>(entity =>
            {
                entity.HasKey(e => e.Idhistorico)
                    .HasName("IDHISTORICO")
                    .IsClustered(false);

                entity.ToTable("NFSE_TBL_EMPRESA_REGIME_HISTORICO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_REGIME_HISTORICO_IDEMPRESA");

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_EMPRESA_REGIME_HISTORICO_IDREGIME");

                entity.Property(e => e.Idhistorico).HasColumnName("IDHISTORICO");

                entity.Property(e => e.Aliqprincipal)
                    .HasColumnType("numeric(5, 2)")
                    .HasColumnName("ALIQPRINCIPAL");

                entity.Property(e => e.Dtentrada)
                    .HasColumnType("datetime")
                    .HasColumnName("DTENTRADA");

                entity.Property(e => e.Dtsaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSAIDA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Vlestimado)
                    .HasColumnType("money")
                    .HasColumnName("VLESTIMADO");

                entity.Property(e => e.Vlmensal)
                    .HasColumnType("money")
                    .HasColumnName("VLMENSAL");
            });

            modelBuilder.Entity<NfseTblEmpresaRelacionada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_EMPRESA_RELACIONADAS");

                entity.HasIndex(e => new { e.Idempresa, e.Idempresarelacionada, e.Idtiporelacao }, "IX_NFSE_TBL_EMPRESA_RELACIONADAS");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_RELACIONADAS_IDEMPRESA");

                entity.HasIndex(e => e.Idempresarelacionada, "IX_NFSE_TBL_EMPRESA_RELACIONADAS_IDEMPRESARELACIONADA");

                entity.HasIndex(e => e.Idtiporelacao, "IX_NFSE_TBL_EMPRESA_RELACIONADAS_IDTIPORELACAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idempresarelacionada).HasColumnName("IDEMPRESARELACIONADA");

                entity.Property(e => e.Idtiporelacao).HasColumnName("IDTIPORELACAO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SOCIOS_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdempresarelacionadaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idempresarelacionada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SOCIOS_NFSE_TBL_EMPRESASOCIOS");

                entity.HasOne(d => d.IdtiporelacaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idtiporelacao)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_RELACIONADOS_NFSE_TBL_EMPRESA_TIPO_RELACAO");
            });

            modelBuilder.Entity<NfseTblEmpresaServico>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.Idservico })
                    .HasName("PK__NFSE_TBL__DF8099173B75D760");

                entity.ToTable("NFSE_TBL_EMPRESA_SERVICO");

                entity.HasIndex(e => e.Idempresa, "IDX_EMPRESA");

                entity.HasIndex(e => new { e.Idempresa, e.Idservico }, "IDX_EMPRESA_SERVICO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.DataFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dataFinal");

                entity.Property(e => e.DataInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("dataInicial");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaServicos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SERVICO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany(p => p.NfseTblEmpresaServicos)
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SERVICO_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblEmpresaServicoDeducao>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.Idservico });

                entity.ToTable("NFSE_TBL_EMPRESA_SERVICO_DEDUCAO");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_EMPRESA_PERFIL_IDUSUARIO")
                    .HasFillFactor(90);

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Binarquivo).HasColumnName("BINARQUIVO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stmotivo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("STMOTIVO");

                entity.Property(e => e.Stnomearquivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STNOMEARQUIVO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttipoarquivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOARQUIVO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaServicoDeducaos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SERVICO_DEDUCAO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany(p => p.NfseTblEmpresaServicoDeducaos)
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_SERVICO_DEDUCAO_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblEmpresaServicoNaturezaOperacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_EMPRESA_SERVICO_NATUREZA_OPERACAO");

                entity.HasIndex(e => e.Idempresa, "IX_IDEEMPRESA");

                entity.HasIndex(e => e.Idoperacao, "IX_IDOPERACAO");

                entity.HasIndex(e => e.Idservico, "IX_IDSERVICO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NFSE_TBL___IDEMP__4E5E8EA2");

                entity.HasOne(d => d.IdoperacaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idoperacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NFSE_TBL___IDOPE__5046D714");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NFSE_TBL___IDSER__4F52B2DB");
            });

            modelBuilder.Entity<NfseTblEmpresaSubstitutoHistorico>(entity =>
            {
                entity.HasKey(e => e.Idalteracao)
                    .HasName("PK_NFSE_TBL_EMPRESA_ALTERACOES");

                entity.ToTable("NFSE_TBL_EMPRESA_SUBSTITUTO_HISTORICO");

                entity.HasIndex(e => e.Issubstituto, "IX_NFSE_TBL_EMPRESA_SUBSTITUTO_HISTORICO_ISSUBSTITUTO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_SUSTITUTO_HISTORICO_IDEMPRESA");

                entity.Property(e => e.Idalteracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDALTERACAO");

                entity.Property(e => e.Dtentrada)
                    .HasColumnType("datetime")
                    .HasColumnName("DTENTRADA");

                entity.Property(e => e.Dtsaida)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSAIDA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Issubstituto).HasColumnName("ISSUBSTITUTO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaSubstitutoHistoricos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_ALTERACOES_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblEmpresaTipoRelacao>(entity =>
            {
                entity.HasKey(e => e.Idtiporelacao);

                entity.ToTable("NFSE_TBL_EMPRESA_TIPO_RELACAO");

                entity.Property(e => e.Idtiporelacao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTIPORELACAO");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblEmpresaTipoTomadore>(entity =>
            {
                entity.HasKey(e => new { e.Idtipotomador, e.Idempresa });

                entity.ToTable("NFSE_TBL_EMPRESA_TIPO_TOMADORES");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_EMPRESA_TIPO_TOMADORES_IDEMPRESA_inc_IDTIPOTOMADOR_STMOTIVO");

                entity.Property(e => e.Idtipotomador).HasColumnName("IDTIPOTOMADOR");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Stmotivo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("STMOTIVO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEmpresaTipoTomadores)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_TIPO_TOMADORES_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdtipotomadorNavigation)
                    .WithMany(p => p.NfseTblEmpresaTipoTomadores)
                    .HasForeignKey(d => d.Idtipotomador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_EMPRESA_TIPO_TOMADORES_NFSE_TBL_TIPO_TOMADOR");
            });

            modelBuilder.Entity<NfseTblEmpresaTributo>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.Idtributo })
                    .HasName("PK__NFSE_TBL__6ADA8B7D1A1FD08D");

                entity.ToTable("NFSE_TBL_EMPRESA_TRIBUTOS");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idtributo).HasColumnName("IDTRIBUTO");

                entity.Property(e => e.Aliquota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("ALIQUOTA");
            });

            modelBuilder.Entity<NfseTblEncerramento>(entity =>
            {
                entity.HasKey(e => e.Idencerramento);

                entity.ToTable("NFSE_TBL_ENCERRAMENTO");

                entity.HasIndex(e => e.Iddivida, "IX_NFSE_TBL_ENCERRAMENTO_IDDIVIDA");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_ENCERRAMENTO_IDEMPRESA");

                entity.HasIndex(e => e.Idtipobaixa, "IX_NFSE_TBL_ENCERRAMENTO_IDTIPOBAIXA");

                entity.HasIndex(e => e.Idtipotributo, "IX_NFSE_TBL_ENCERRAMENTO_IDTIPOTRIBUTO");

                entity.HasIndex(e => new { e.Numescompetencia, e.Nuanocompetencia, e.Idusuario }, "IX_NFSE_TBL_ENCERRAMENTO_NUMESCOMP_NUANOCOMP_IDUSUARIO");

                entity.HasIndex(e => e.Stsituacao, "IX_NFSE_TBL_ENCERRAMENTO_STSITUACAO_IDENCERRAMENTO");

                entity.Property(e => e.Idencerramento)
                    .ValueGeneratedNever()
                    .HasColumnName("IDENCERRAMENTO");

                entity.Property(e => e.Dtlancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTLANCAMENTO");

                entity.Property(e => e.Dtvencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTVENCIMENTO");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idtipobaixa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IDTIPOBAIXA")
                    .IsFixedLength();

                entity.Property(e => e.Idtipotributo).HasColumnName("IDTIPOTRIBUTO");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttipodivida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPODIVIDA")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblEncerramentos)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_ENCERRAMENTO_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblEncerramentoBoleto>(entity =>
            {
                entity.HasKey(e => new { e.Idencerramento, e.Bolenossonumero })
                    .HasName("PK_NFSE_TBL_ENCERRAMENTO_BOLETOS_1");

                entity.ToTable("NFSE_TBL_ENCERRAMENTO_BOLETOS");

                entity.Property(e => e.Idencerramento).HasColumnName("IDENCERRAMENTO");

                entity.Property(e => e.Bolenossonumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOLENOSSONUMERO");

                entity.Property(e => e.Dsmotcancelamento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DSMOTCANCELAMENTO");

                entity.Property(e => e.Dtcancelamento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCANCELAMENTO");

                entity.Property(e => e.Dtimpressao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTIMPRESSAO");

                entity.Property(e => e.Dtvencimento)
                    .HasColumnType("date")
                    .HasColumnName("DTVENCIMENTO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Vltotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("VLTOTAL");

                entity.HasOne(d => d.IdencerramentoNavigation)
                    .WithMany(p => p.NfseTblEncerramentoBoletos)
                    .HasForeignKey(d => d.Idencerramento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_ENCERRAMENTO_BOLETOS_NFSE_TBL_ENCERRAMENTO");
            });

            modelBuilder.Entity<NfseTblEncerramentoConta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_ENCERRAMENTO_CONTAS");

                entity.HasIndex(e => e.Idconta, "IDCONTA");

                entity.HasIndex(e => e.Idconta, "IX_IDCONTA");

                entity.HasIndex(e => e.Idencerramento, "IX_NFSE_TBL_ENCERRAMENTO_CONTAS_IDENCERRAMENTO");

                entity.HasIndex(e => new { e.Idencerramento, e.Idconta }, "IX_NFSE_TBL_ENCERRAMENTO_CONTAS_IDENCERRAMENTO_IDCONTA");

                entity.Property(e => e.Idconta).HasColumnName("IDCONTA");

                entity.Property(e => e.Idencerramento).HasColumnName("IDENCERRAMENTO");

                entity.HasOne(d => d.IdcontaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idconta)
                    .HasConstraintName("FK_NFSE_TBL_CONTA_NFSE_TBL_ENCERRAMENTO_CONTAS");

                entity.HasOne(d => d.IdencerramentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idencerramento)
                    .HasConstraintName("FK_NFSE_TBL_ENCERRAMENTO_CONTAS_NFSE_TBL_ENCERRAMENTO");
            });

            modelBuilder.Entity<NfseTblErroSemMovimento>(entity =>
            {
                entity.HasKey(e => e.Iderro);

                entity.ToTable("NFSE_TBL_ERRO_SEM_MOVIMENTO");

                entity.Property(e => e.Iderro)
                    .ValueGeneratedNever()
                    .HasColumnName("IDERRO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.Property(e => e.Numes).HasColumnName("NUMES");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblErroSemMovimentos)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_ERRO_SEM_MOVIMENTO_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblFaq>(entity =>
            {
                entity.HasKey(e => e.Idfaq);

                entity.ToTable("NFSE_TBL_FAQ");

                entity.Property(e => e.Idfaq).HasColumnName("IDFAQ");

                entity.Property(e => e.Idfaqgrupo).HasColumnName("IDFAQGRUPO");

                entity.Property(e => e.Nuordem).HasColumnName("NUORDEM");

                entity.Property(e => e.Stform)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STFORM");

                entity.Property(e => e.Stsolucao)
                    .IsUnicode(false)
                    .HasColumnName("STSOLUCAO");

                entity.Property(e => e.Sttitulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STTITULO");
            });

            modelBuilder.Entity<NfseTblFaqGrupo>(entity =>
            {
                entity.HasKey(e => e.Idfaqgrupo);

                entity.ToTable("NFSE_TBL_FAQ_GRUPO");

                entity.Property(e => e.Idfaqgrupo).HasColumnName("IDFAQGRUPO");

                entity.Property(e => e.Nuordem).HasColumnName("NUORDEM");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<NfseTblFaqResplike>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_FAQ_RESPLIKES");

                entity.Property(e => e.Flajudou)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLAJUDOU")
                    .IsFixedLength();

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idresposta).HasColumnName("IDRESPOSTA");
            });

            modelBuilder.Entity<NfseTblFaqResposta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_FAQ_RESPOSTAS");

                entity.Property(e => e.Dtinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINCLUSAO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idfaq).HasColumnName("IDFAQ");

                entity.Property(e => e.Stresposta)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("STRESPOSTA");
            });

            modelBuilder.Entity<NfseTblFaqUsuario>(entity =>
            {
                entity.ToTable("NFSE_TBL_FAQ_USUARIOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Isadmin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISADMIN")
                    .IsFixedLength();

                entity.Property(e => e.Senha)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SENHA");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");
            });

            modelBuilder.Entity<NfseTblFeriado>(entity =>
            {
                entity.HasKey(e => e.Idferiado);

                entity.ToTable("NFSE_TBL_FERIADOS");

                entity.HasIndex(e => e.Data, "IX_NFSE_TBL_FERIADOS_DATA");

                entity.Property(e => e.Idferiado).HasColumnName("IDFERIADO");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("DATA");

                entity.Property(e => e.Nudia).HasColumnName("NUDIA");

                entity.Property(e => e.Numes).HasColumnName("NUMES");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<NfseTblFiss>(entity =>
            {
                entity.HasKey(e => e.Idfiss)
                    .HasName("IDFISS")
                    .IsClustered(false);

                entity.ToTable("NFSE_TBL_FISS");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_FISS_IDCONTRIBUINTE");

                entity.HasIndex(e => e.Iddivida, "IX_NFSE_TBL_FISS_IDDIVIDA");

                entity.HasIndex(e => e.Idmunicipioestabelecimento, "IX_NFSE_TBL_FISS_IDMUNICIPIOESTABELECIDO");

                entity.Property(e => e.Idfiss).HasColumnName("IDFISS");

                entity.Property(e => e.Aliquota)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("ALIQUOTA");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("date")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idmunicipioestabelecimento).HasColumnName("IDMUNICIPIOESTABELECIMENTO");

                entity.Property(e => e.Issretido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSRETIDO")
                    .IsFixedLength();

                entity.Property(e => e.Nunumero).HasColumnName("NUNUMERO");

                entity.Property(e => e.Stresponsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STRESPONSAVEL");

                entity.Property(e => e.Sttipodocumento)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STTIPODOCUMENTO");

                entity.Property(e => e.Vlbasecalculoissqn)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VLBASECALCULOISSQN");

                entity.Property(e => e.Vlissqn)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VLISSQN");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("VLTOTAL");
            });

            modelBuilder.Entity<NfseTblFormHelp>(entity =>
            {
                entity.HasKey(e => e.Idform);

                entity.ToTable("NFSE_TBL_FORM_HELP");

                entity.Property(e => e.Idform).HasColumnName("IDForm");

                entity.Property(e => e.Idmenu).HasColumnName("IDMenu");

                entity.Property(e => e.SttextoExplicativo)
                    .IsUnicode(false)
                    .HasColumnName("STTextoExplicativo");

                entity.HasOne(d => d.IdmenuNavigation)
                    .WithMany(p => p.NfseTblFormHelps)
                    .HasForeignKey(d => d.Idmenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_FORM_HELP_NFSE_TBL_MENU_HELP");
            });

            modelBuilder.Entity<NfseTblFormHelpImg>(entity =>
            {
                entity.HasKey(e => e.Idimg);

                entity.ToTable("NFSE_TBL_FORM_HELP_IMG");

                entity.Property(e => e.Idimg).HasColumnName("IDImg");

                entity.Property(e => e.Idform).HasColumnName("IDForm");

                entity.Property(e => e.Imhelp).HasColumnName("IMHelp");

                entity.Property(e => e.NmImagem)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NfseTblGrupoAcesso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_GRUPO_ACESSO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_GRUPO_ACESSO_IDEMPRESA")
                    .IsClustered();

                entity.HasIndex(e => e.Idgrupoacess, "IX_NFSE_TBL_GRUPO_ACESSO_IDGRUPOACESSO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idgrupoacess).HasColumnName("IDGRUPOACESS");

                entity.Property(e => e.Stcadaliquota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCADALIQUOTA")
                    .IsFixedLength();

                entity.Property(e => e.Stcancelanfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCANCELANFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stcancelarboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCANCELARBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stconapumeniss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONAPUMENISS")
                    .IsFixedLength();

                entity.Property(e => e.Stcondemcontab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONDEMCONTAB")
                    .IsFixedLength();

                entity.Property(e => e.Stcondemparlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONDEMPARLAN")
                    .IsFixedLength();

                entity.Property(e => e.Stconinfcommun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONINFCOMMUN")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultaextrato)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTAEXTRATO")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultaloterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTALOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfseemitida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSEEMITIDA")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfseporrps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSEPORRPS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfserecebida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSERECEBIDA")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultarboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTARBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultasituloterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTASITULOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stcredencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCREDENCIA")
                    .IsFixedLength();

                entity.Property(e => e.Stcriagrupos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCRIAGRUPOS")
                    .IsFixedLength();

                entity.Property(e => e.Stdecapumeniss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECAPUMENISS")
                    .IsFixedLength();

                entity.Property(e => e.Stdecdemcontab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECDEMCONTAB")
                    .IsFixedLength();

                entity.Property(e => e.Stdecdemparlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECDEMPARLAN")
                    .IsFixedLength();

                entity.Property(e => e.Stdecinfcommun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECINFCOMMUN")
                    .IsFixedLength();

                entity.Property(e => e.Stdeclaracoes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECLARACOES")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stemitenfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEMITENFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stemitirboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEMITIRBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stencerracompetencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENCERRACOMPETENCIA")
                    .IsFixedLength();

                entity.Property(e => e.Stenvialoterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENVIALOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stexportanfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEXPORTANFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stexportanfserecebidas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEXPORTANFSERECEBIDAS")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Stgerarlivrofiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STGERARLIVROFISCAL")
                    .IsFixedLength();

                entity.Property(e => e.Sthomologacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STHOMOLOGACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stimprimenfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STIMPRIMENFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stimprimirboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STIMPRIMIRBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stintervenecf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINTERVENECF")
                    .IsFixedLength();

                entity.Property(e => e.Strecibos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECIBOS")
                    .IsFixedLength();

                entity.Property(e => e.Stsubstituinfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSUBSTITUINFSE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblGrupoAcessoUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_GRUPO_ACESSO_USUARIOS");

                entity.HasIndex(e => new { e.Idgrupoacess, e.Idusuario }, "IX_NFSE_TBL_GRUPO_ACESSO_USUARIOS");

                entity.HasIndex(e => e.Idgrupoacess, "IX_NFSE_TBL_GRUPO_ACESSO_USUARIOS_IDGRUPOACESS");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_GRUPO_ACESSO_USUARIOS_IDUSUARIO");

                entity.Property(e => e.Idgrupoacess).HasColumnName("IDGRUPOACESS");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");
            });

            modelBuilder.Entity<NfseTblHistoricoAlteraco>(entity =>
            {
                entity.HasKey(e => e.Idhistoricoalteracao);

                entity.ToTable("NFSE_TBL_HISTORICO_ALTERACOES");

                entity.HasIndex(e => e.Idregistro, "IX_NFSE_TBL_HISTORICO_ALTERACOES_IDREGISTRO");

                entity.HasIndex(e => e.Nuprotocolo, "IX_NFSE_TBL_HISTORICO_ALTERACOES_NUMPROTOCOLO");

                entity.Property(e => e.Idhistoricoalteracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDHISTORICOALTERACAO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Dtprotocolizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPROTOCOLIZACAO");

                entity.Property(e => e.Idregistro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDREGISTRO");

                entity.Property(e => e.Nuprotocolo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUPROTOCOLO");

                entity.Property(e => e.Stmetadadoregistroafter)
                    .IsUnicode(false)
                    .HasColumnName("STMETADADOREGISTROAFTER");

                entity.Property(e => e.Stmetadadoregistrobefore)
                    .IsUnicode(false)
                    .HasColumnName("STMETADADOREGISTROBEFORE");

                entity.Property(e => e.Stparecer)
                    .IsUnicode(false)
                    .HasColumnName("STPARECER");

                entity.Property(e => e.Sttabela)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTABELA");

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO");

                entity.Property(e => e.Stusuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIO");
            });

            modelBuilder.Entity<NfseTblHomologacao>(entity =>
            {
                entity.HasKey(e => e.Idhomologacao)
                    .HasName("PK_NFSE_TBL_HOMOLOGACOES");

                entity.ToTable("NFSE_TBL_HOMOLOGACAO");

                entity.HasIndex(e => e.Idempresa, "IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Stsituacao, "IDX_STSITUACAO");

                entity.HasIndex(e => e.Stsituacao, "IX_NFSE_TBL_HOMOLOGACAO_STSITUACAO_inc_IDEMPRESA");

                entity.HasIndex(e => e.Stsituacao, "IX_NFSE_TBL_HOMOLOGACAO_STSITUACAO_inc_IDEMPRESA_DTDATA");

                entity.Property(e => e.Idhomologacao).HasColumnName("IDHOMOLOGACAO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Dtdatahomologacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATAHOMOLOGACAO");

                entity.Property(e => e.Dtliberacaoacesso)
                    .HasColumnType("date")
                    .HasColumnName("DTLIBERACAOACESSO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Isrecad).HasColumnName("ISRECAD");

                entity.Property(e => e.Stmotivo)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("STMOTIVO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblHomologacaos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_HOMOLOGACAO_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblHomologacaoTomador>(entity =>
            {
                entity.HasKey(e => e.IdhomologaTom);

                entity.ToTable("NFSE_TBL_HOMOLOGACAO_TOMADOR");

                entity.HasIndex(e => e.Idcontribuinte, "IX_NFSE_TBL_HOMOLOGACAO_TOMADOR_IDCONTRIBUINTE")
                    .HasFillFactor(90);

                entity.Property(e => e.IdhomologaTom)
                    .ValueGeneratedNever()
                    .HasColumnName("IDHOMOLOGA_TOM");

                entity.Property(e => e.Dtdatahomologacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATAHOMOLOGACAO");

                entity.Property(e => e.Dtdatasoli)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATASOLI");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stmotivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STMOTIVO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblHomologacaoTomadors)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .HasConstraintName("FK_NFSE_TBL_HOMOLOGACAO_TOMADOR_NFSE_TBL_CONTRIBUINTE");
            });

            modelBuilder.Entity<NfseTblIncentivoFiscal>(entity =>
            {
                entity.HasKey(e => e.Idincentivo);

                entity.ToTable("NFSE_TBL_INCENTIVO_FISCAL");

                entity.Property(e => e.Idincentivo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDINCENTIVO");

                entity.Property(e => e.Dtfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DTFINAL");

                entity.Property(e => e.Dtinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINCLUSAO");

                entity.Property(e => e.Dtinicial)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINICIAL");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stusuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUSUARIO");
            });

            modelBuilder.Entity<NfseTblIncentivoFiscalServico>(entity =>
            {
                entity.HasKey(e => new { e.Idincentivo, e.Idservico });

                entity.ToTable("NFSE_TBL_INCENTIVO_FISCAL_SERVICOS");

                entity.Property(e => e.Idincentivo).HasColumnName("IDINCENTIVO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Staliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("STALIQUOTA");
            });

            modelBuilder.Entity<NfseTblLog>(entity =>
            {
                entity.HasKey(e => e.Idlog);

                entity.ToTable("NFSE_TBL_LOG");

                entity.HasIndex(e => e.Idusuario, "IDUSUARIO")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idusuario, e.Idempresa }, "IDUSUARIO_EMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idusuario, e.Idempresa, e.Dtdata }, "IDX_USUARIO_EMPRESA_DATA");

                entity.HasIndex(e => e.Dtdata, "ID_DATA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_LOG_IDEMPRESA_inc_IDLOG");

                entity.Property(e => e.Idlog)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLOG");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Staction)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STACTION");

                entity.Property(e => e.Stcontroller)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STCONTROLLER");

                entity.Property(e => e.Sturl)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STURL");

                entity.Property(e => e.Sturlanterior)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STURLANTERIOR");

                entity.Property(e => e.Stuseragent)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STUSERAGENT");

                entity.Property(e => e.Stuserhostaddress)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STUSERHOSTADDRESS");

                entity.Property(e => e.Stuserhostname)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("STUSERHOSTNAME");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblLogs)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_LOG_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblLogs)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NFSE_TBL_LOG_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblLogAcao>(entity =>
            {
                entity.HasKey(e => e.Idlogacao);

                entity.ToTable("NFSE_TBL_LOG_ACAO");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_LOG_ACAO_IDEMPRESA");

                entity.HasIndex(e => e.Idlogacaotipo, "IX_NFSE_TBL_LOG_ACAO_IDLOGACAOTIPO");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_LOG_ACAO_IDUSUARIO");

                entity.Property(e => e.Idlogacao).HasColumnName("IDLOGACAO");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idlogacaotipo).HasColumnName("IDLOGACAOTIPO");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stlog)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STLOG");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblLogAcaos)
                    .HasForeignKey(d => d.Idempresa)
                    .HasConstraintName("FK_NFSE_TBL_LOG_ACAO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdlogacaotipoNavigation)
                    .WithMany(p => p.NfseTblLogAcaos)
                    .HasForeignKey(d => d.Idlogacaotipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_LOG_ACAO_NFSE_TBL_LOG_ACAO_TIPO");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblLogAcaos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_LOG_ACAO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblLogAcaoTipo>(entity =>
            {
                entity.HasKey(e => e.Idlogacaotipo);

                entity.ToTable("NFSE_TBL_LOG_ACAO_TIPO");

                entity.Property(e => e.Idlogacaotipo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLOGACAOTIPO");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<NfseTblLogDeclaracaoAuto>(entity =>
            {
                entity.HasKey(e => e.Idlogdecauto);

                entity.ToTable("NFSE_TBL_LOG_DECLARACAO_AUTO");

                entity.Property(e => e.Idlogdecauto)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLOGDECAUTO");

                entity.Property(e => e.Dthorafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORAFINAL");

                entity.Property(e => e.Dthorainicial)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORAINICIAL");

                entity.Property(e => e.Nuanocompetencia).HasColumnName("NUANOCOMPETENCIA");

                entity.Property(e => e.Numescompetencia).HasColumnName("NUMESCOMPETENCIA");

                entity.Property(e => e.Stmensagem)
                    .IsUnicode(false)
                    .HasColumnName("STMENSAGEM");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO");

                entity.Property(e => e.Sttiporecolhimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPORECOLHIMENTO");
            });

            modelBuilder.Entity<NfseTblMalaDiretaEnvio>(entity =>
            {
                entity.HasKey(e => e.Idmaladiretaenvio);

                entity.ToTable("NFSE_TBL_MALA_DIRETA_ENVIO");

                entity.Property(e => e.Idmaladiretaenvio)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMALADIRETAENVIO");

                entity.Property(e => e.Dtenvio)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DTENVIO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idmaladireta).HasColumnName("IDMALADIRETA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stemailempresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STEMAILEMPRESA");
            });

            modelBuilder.Entity<NfseTblMalaDiretum>(entity =>
            {
                entity.HasKey(e => e.Idmaladireta);

                entity.ToTable("NFSE_TBL_MALA_DIRETA");

                entity.Property(e => e.Idmaladireta)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMALADIRETA");

                entity.Property(e => e.Dtinclusao)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DTINCLUSAO");

                entity.Property(e => e.Idtexto).HasColumnName("IDTEXTO");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stdescricao)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");
            });

            modelBuilder.Entity<NfseTblMensagem>(entity =>
            {
                entity.HasKey(e => e.Idmensagem)
                    .HasName("PK__NFSE_TBL__0A16FD2F3F466844");

                entity.ToTable("NFSE_TBL_MENSAGEM");

                entity.Property(e => e.Idmensagem)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMENSAGEM");

                entity.Property(e => e.Dtenvio)
                    .HasColumnType("datetime")
                    .HasColumnName("DTENVIO");

                entity.Property(e => e.Dtrecebimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTRECEBIMENTO");

                entity.Property(e => e.Idmensagemref).HasColumnName("IDMENSAGEMREF");

                entity.Property(e => e.Idtipomsg).HasColumnName("IDTIPOMSG");

                entity.Property(e => e.Idusuariodestino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIODESTINO");

                entity.Property(e => e.Idusuarioenvio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOENVIO");

                entity.Property(e => e.Stmensagem)
                    .IsUnicode(false)
                    .HasColumnName("STMENSAGEM");

                entity.Property(e => e.Stregistro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STREGISTRO");

                entity.Property(e => e.Sttabela)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTABELA");

                entity.Property(e => e.Sttitulo)
                    .IsUnicode(false)
                    .HasColumnName("STTITULO");
            });

            modelBuilder.Entity<NfseTblMenuHelp>(entity =>
            {
                entity.HasKey(e => e.Idmenu);

                entity.ToTable("NFSE_TBL_MENU_HELP");

                entity.Property(e => e.Idmenu).HasColumnName("IDMenu");

                entity.Property(e => e.NmForm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NfseTblMotivoCancelamento>(entity =>
            {
                entity.HasKey(e => e.Idmotcan);

                entity.ToTable("NFSE_TBL_MOTIVO_CANCELAMENTO");

                entity.Property(e => e.Idmotcan)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMOTCAN");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stinformanfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINFORMANFSE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblNaturezaOperacao>(entity =>
            {
                entity.HasKey(e => e.Idoperacao);

                entity.ToTable("NFSE_TBL_NATUREZA_OPERACAO");

                entity.Property(e => e.Idoperacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDOPERACAO");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stexigibsuspensa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEXIGIBSUSPENSA")
                    .IsFixedLength();

                entity.Property(e => e.Stgeraobrigacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STGERAOBRIGACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stnatopeespecial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STNATOPEESPECIAL")
                    .IsFixedLength();

                entity.Property(e => e.Stnatopepadrao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STNATOPEPADRAO")
                    .IsFixedLength();

                entity.Property(e => e.Stservforamuni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSERVFORAMUNI")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblNaturezaOperacaoServico>(entity =>
            {
                entity.HasKey(e => new { e.Idoperacao, e.Idservico });

                entity.ToTable("NFSE_TBL_NATUREZA_OPERACAO_SERVICOS");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany(p => p.NfseTblNaturezaOperacaoServicos)
                    .HasForeignKey(d => d.Idservico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_NATUREZA_OPERACAO_SERVICOS_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblNf>(entity =>
            {
                entity.HasKey(e => e.Idnfseintermunicipal)
                    .HasName("PK_NFSE_TBL_NFSE_AVULSA");

                entity.ToTable("NFSE_TBL_NFS");

                entity.Property(e => e.Idnfseintermunicipal).HasColumnName("IDNFSEINTERMUNICIPAL");

                entity.Property(e => e.Art)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ART")
                    .IsFixedLength();

                entity.Property(e => e.Cei)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CEI")
                    .IsFixedLength();

                entity.Property(e => e.CnaeSubclasse)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Dtpagamento)
                    .HasColumnType("date")
                    .HasColumnName("DTPAGAMENTO");

                entity.Property(e => e.Dtvencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DTVENCIMENTO");

                entity.Property(e => e.Idcidadeservico).HasColumnName("IDCIDADESERVICO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idnfsarquivo).HasColumnName("IDNFSARQUIVO");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO")
                    .IsFixedLength();

                entity.Property(e => e.Outrasinf)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("OUTRASINF");

                entity.Property(e => e.Pcaliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PCALIQUOTA");

                entity.Property(e => e.PrestBairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("PREST_BAIRRO");

                entity.Property(e => e.PrestCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PREST_CEP")
                    .IsFixedLength();

                entity.Property(e => e.PrestCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PREST_CNPJ");

                entity.Property(e => e.PrestCompl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PREST_COMPL");

                entity.Property(e => e.PrestIdcidade).HasColumnName("PREST_IDCIDADE");

                entity.Property(e => e.PrestLogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("PREST_LOGR");

                entity.Property(e => e.PrestNome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PREST_NOME");

                entity.Property(e => e.PrestNumpredial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREST_NUMPREDIAL")
                    .IsFixedLength();

                entity.Property(e => e.RpsNumero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RPS_NUMERO")
                    .IsFixedLength();

                entity.Property(e => e.RpsSerie)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("RPS_SERIE")
                    .IsFixedLength();

                entity.Property(e => e.RpsTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RPS_TIPO")
                    .IsFixedLength();

                entity.Property(e => e.Serie)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SERIE")
                    .IsFixedLength();

                entity.Property(e => e.Servdescricao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SERVDESCRICAO");

                entity.Property(e => e.Stissretido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STISSRETIDO")
                    .IsFixedLength();

                entity.Property(e => e.Strecolheiss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECOLHEISS")
                    .IsFixedLength();

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stunideco)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STUNIDECO")
                    .IsFixedLength();

                entity.Property(e => e.TercCmc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TERC_CMC")
                    .IsFixedLength();

                entity.Property(e => e.TercCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TERC_CNPJ");

                entity.Property(e => e.TercNome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("TERC_NOME");

                entity.Property(e => e.Vlbasecalc)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLBASECALC");

                entity.Property(e => e.Vlcofins)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLCOFINS");

                entity.Property(e => e.Vlcsll)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLCSLL");

                entity.Property(e => e.Vldeducoes)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDEDUCOES");

                entity.Property(e => e.Vldesccond)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCCOND");

                entity.Property(e => e.Vldescincond)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCINCOND");

                entity.Property(e => e.Vlinss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLINSS");

                entity.Property(e => e.Vliof)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLIOF");

                entity.Property(e => e.Vlir)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLIR");

                entity.Property(e => e.Vlissqn)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLISSQN");

                entity.Property(e => e.Vlissqnretido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLISSQNRETIDO");

                entity.Property(e => e.Vlpis)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLPIS");

                entity.Property(e => e.Vlretencoes)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLRETENCOES");

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotalliquido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALLIQUIDO");
            });

            modelBuilder.Entity<NfseTblNfsArquivo>(entity =>
            {
                entity.HasKey(e => e.Idnfsarquivo);

                entity.ToTable("NFSE_TBL_NFS_ARQUIVO");

                entity.Property(e => e.Idnfsarquivo)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSARQUIVO");

                entity.Property(e => e.Binarquivo).HasColumnName("BINARQUIVO");

                entity.Property(e => e.Dtenvio)
                    .HasColumnType("datetime")
                    .HasColumnName("DTENVIO");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Sterros)
                    .IsUnicode(false)
                    .HasColumnName("STERROS");

                entity.Property(e => e.Ststatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSTATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblNfse>(entity =>
            {
                entity.HasKey(e => e.Idnfse)
                    .HasName("PK__NFSE_TBL__38865C9446E78A0C");

                entity.ToTable("NFSE_TBL_NFSE");

                entity.HasIndex(e => e.Dtcompetencia, "DTCOMPETENCIA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Dtdata, "DTDATA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Stsituacao, "IDX_SITUACAO_EMPRESA_COMPETENCIA");

                entity.HasIndex(e => e.Idregime, "ID_ENCERRAMENTO_AUTOMATICO_BAS");

                entity.HasIndex(e => new { e.Dtdata, e.Idnfse, e.Nunumero }, "IX_NFSE_TBL_DTDATA_IDNFSE_NUNUMERO");

                entity.HasIndex(e => new { e.Idnfse, e.Stsituacao, e.IdtomIdcidade, e.Idservico, e.Idempresa, e.Nunumero, e.Dtdata, e.Vlbasecalculo, e.Vltotalliquido, e.Pcaliquota, e.Vltotaliss, e.Stissretido, e.Vlservicos, e.SttomCpfcnpj, e.SttomNome }, "IX_NFSE_TBL_NFSE");

                entity.HasIndex(e => new { e.Dtcompetencia, e.Vlservicos, e.Vltotaliss, e.Stissretido, e.Stsituacao, e.IdpreIdcidade, e.Vltotalliquido, e.Pcaliquota, e.Idservico }, "IX_NFSE_TBL_NFSE_21_749245724__K10_K34_K30_K22_K54_K14_K32_K18_K17_1_2_3_36");

                entity.HasIndex(e => new { e.Idempresa, e.Dtcompetencia, e.Idnfse, e.IdpreIdcidade, e.Vltotalliquido, e.Vlservicos, e.Pcaliquota, e.Vltotaliss, e.Idservico, e.Stissretido, e.Stsituacao }, "IX_NFSE_TBL_NFSE_21_749245724__K2_K10_K1_K14_K32_K34_K18_K30_K17_K22_K54_3_36");

                entity.HasIndex(e => new { e.Dtcompetencia, e.Idnfse, e.Stsituacao, e.Idempresa, e.Idregime, e.Nunumero }, "IX_NFSE_TBL_NFSE_DTCOMPETENCIA_IDNFSE_STSITUACAO_IDEMPRESA_IDREGIME_NUNUMERO");

                entity.HasIndex(e => new { e.Dtdata, e.Nunumero, e.Idnfse }, "IX_NFSE_TBL_NFSE_DTDATA_NUNUMERO_IDNFSE");

                entity.HasIndex(e => e.IdcnaeSubclasse, "IX_NFSE_TBL_NFSE_IDCNAE_SUBCLASSE");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_NFSE_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idempresa, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_IDEMPRESA_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.Idempresa, e.Idnfse, e.Dtdata }, "IX_NFSE_TBL_NFSE_IDEMPRESA_IDNFSE_DTDATA");

                entity.HasIndex(e => new { e.Idempresa, e.Idnfse, e.SttomNome, e.SttomEmail, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_IDEMPRESA_IDNFSE_STTOM_NOME_STTOM_EMAIL_STTOM_CPFCNPJ");

                entity.HasIndex(e => new { e.Idempresa, e.Nunumero }, "IX_NFSE_TBL_NFSE_IDEMPRESA_NUNUMERO_inc_IDNFSE");

                entity.HasIndex(e => new { e.Idempresa, e.Stissretido, e.Nunumero }, "IX_NFSE_TBL_NFSE_IDEMPRESA_STISSRETIDO_NUNUMERO");

                entity.HasIndex(e => new { e.Idempresa, e.Stsituacao }, "IX_NFSE_TBL_NFSE_IDEMPRESA_STSITUACAO_inc_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.Idempresa, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_IDEMPRESA_STTOM_CPFCNPJ");

                entity.HasIndex(e => new { e.Idempresa, e.SttomCpfcnpj, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_IDEMPRESA_STTOM_CPFCNPJ_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.Idempresa, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_IDEMPRESA_STTOM_CPFCNPJ_inc_IDNFSE");

                entity.HasIndex(e => e.Idnfsesubst, "IX_NFSE_TBL_NFSE_IDNFSESUBST");

                entity.HasIndex(e => new { e.Idnfse, e.Idregime, e.IdpresIdcidade, e.StpreCpfcnpj, e.Stissretido, e.Dtdata }, "IX_NFSE_TBL_NFSE_IDNFSE_IDREGIME_IDPRES_IDCIDADE_STPRE_CPFCNPJ_STISSRETIDO_DTDATA");

                entity.HasIndex(e => new { e.Idnfse, e.Stsituacao, e.Idservico, e.Stissretido, e.Idregime }, "IX_NFSE_TBL_NFSE_IDNFSE_STSITUACAO__IDSERVICO_STISSRETIDO_IDREGIME");

                entity.HasIndex(e => e.Idoperacao, "IX_NFSE_TBL_NFSE_IDOPERACAO")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IdpreIdcidade, "IX_NFSE_TBL_NFSE_IDPRE_IDCIDADE");

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_NFSE_IDREGIME");

                entity.HasIndex(e => e.Idservico, "IX_NFSE_TBL_NFSE_IDSERVICO");

                entity.HasIndex(e => e.IdtomIdcidade, "IX_NFSE_TBL_NFSE_IDTOM_IDCIDADE");

                entity.HasIndex(e => new { e.Nunumero, e.StpreCpfcnpj, e.StpreIm }, "IX_NFSE_TBL_NFSE_NUNUMERO_STPRE_CPFCNPJ_STPRE_IM");

                entity.HasIndex(e => new { e.Nunumero, e.SttomCpfcnpj, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_NUNUMERO_STTOM_CPFCNPJ_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.Stissretido, e.Stsituacao, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_STISSRETIDO_STSITUACAO_STTOM_CPFCNPJ");

                entity.HasIndex(e => new { e.Stissretido, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_STISSRETIDO_STTOM_CPFCNPJ");

                entity.HasIndex(e => new { e.Stissretido, e.SttomPessoaTipo }, "IX_NFSE_TBL_NFSE_STISSRETIDO_STTOM_PESSOA_TIPO");

                entity.HasIndex(e => e.StpreCpfcnpj, "IX_NFSE_TBL_NFSE_STPRE_CPFCNPJ");

                entity.HasIndex(e => e.StpreIm, "IX_NFSE_TBL_NFSE_STPRE_IM");

                entity.HasIndex(e => e.StpreIm, "IX_NFSE_TBL_NFSE_STPRE_IM_inc_NUNUMERO_DTDATA_STOPSIMP_DTCOMP_STOUTRAINF_SERVDESCR");

                entity.HasIndex(e => new { e.Stsituacao, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_STSITUACAO_DTCOMPETENCIA_inc_IDSERVICO");

                entity.HasIndex(e => new { e.Stsituacao, e.SttomCpfcnpj }, "IX_NFSE_TBL_NFSE_STSITUACAO_STTOM_CPFCNPJ");

                entity.HasIndex(e => e.SttomCpfcnpj, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ");

                entity.HasIndex(e => new { e.SttomCpfcnpj, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.SttomCpfcnpj, e.Idempresa, e.Idnfse, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_IDEMPRESA_IDNFSE_DTCOMPETENCIA");

                entity.HasIndex(e => new { e.SttomCpfcnpj, e.Idempresa, e.Idnfse, e.SttomNome }, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_IDEMPRESA_IDNFSE_STTOM_NOME");

                entity.HasIndex(e => new { e.SttomCpfcnpj, e.Idservico, e.Idnfse }, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_IDSERVICO_IDNFSE");

                entity.HasIndex(e => new { e.SttomCpfcnpj, e.StpreCpfcnpj, e.Dtcompetencia }, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_STPRE_CPFCNPJ_DTCOMPETENCIA");

                entity.HasIndex(e => e.SttomCpfcnpj, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_inc_DTCOMPETENCIA");

                entity.HasIndex(e => e.SttomCpfcnpj, "IX_NFSE_TBL_NFSE_STTOM_CPFCNPJ_inc_IDNFSE_IDCNAE_SUBCLASSE");

                entity.HasIndex(e => new { e.Stissretido, e.Stsituacao, e.SttomCpfcnpj }, "IX_STTOM_CPFCNPJ_STSITUACAO_STISSRETIDO");

                entity.HasIndex(e => new { e.Stissretido, e.Stsituacao }, "NFSE_TBL_NFSE_IDX_EMPRESA_NOTAS_SITUACAO");

                entity.HasIndex(e => e.Stcodigo, "NFSE_TBL_NFSE_IDX_STCODIGO");

                entity.HasIndex(e => new { e.Idempresa, e.Stissretido, e.Stsituacao }, "NFSE_TBL_NFSE_NOTAS_PENDETES_DECLARACAO");

                entity.HasIndex(e => e.Nunumero, "NUMERO_NFSE")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.StpreCpfcnpj, e.Dtcompetencia, e.Idnfse, e.IdpreIdcidade, e.IdpresIdcidade, e.IdtomIdcidade }, "_dta_index_NFSE_TBL_NFSE_28_1679345047__K58_K10_K1_K14_K66_K44_2_3_4_5_6_7_8_9_11_12_13_15_16_17_18_19_20_21_22_23_24_25_26_27_");

                entity.HasIndex(e => new { e.Stissretido, e.Stsituacao }, "nfse_idx_consulta_notas_n_declaradas");

                entity.Property(e => e.Idnfse)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSE");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Idempincfisc).HasColumnName("IDEMPINCFISC");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idnfsesubst).HasColumnName("IDNFSESUBST");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.Property(e => e.IdpreIdcidade).HasColumnName("IDPRE_IDCIDADE");

                entity.Property(e => e.IdpresIdcidade).HasColumnName("IDPRES_IDCIDADE");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.IdtomIdcidade).HasColumnName("IDTOM_IDCIDADE");

                entity.Property(e => e.Idusuarioinclusao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOINCLUSAO");

                entity.Property(e => e.NucodigomunicipioOrgaogerador).HasColumnName("NUCODIGOMUNICIPIO_ORGAOGERADOR");

                entity.Property(e => e.Nunumero).HasColumnName("NUNUMERO");

                entity.Property(e => e.Pcaliquota)
                    .HasColumnType("numeric(14, 5)")
                    .HasColumnName("PCALIQUOTA");

                entity.Property(e => e.Stcei)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCEI");

                entity.Property(e => e.Stcodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STCODIGO");

                entity.Property(e => e.Stcodigotributacaomunicipio)
                    .HasMaxLength(20)
                    .HasColumnName("STCODIGOTRIBUTACAOMUNICIPIO")
                    .IsFixedLength();

                entity.Property(e => e.Stenviaporemail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENVIAPOREMAIL")
                    .IsFixedLength();

                entity.Property(e => e.StincentivadorCultural)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINCENTIVADOR_CULTURAL")
                    .IsFixedLength();

                entity.Property(e => e.StintCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STINT_CPFCNPJ");

                entity.Property(e => e.StintIm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STINT_IM")
                    .IsFixedLength();

                entity.Property(e => e.StintNome)
                    .HasMaxLength(115)
                    .IsUnicode(false)
                    .HasColumnName("STINT_NOME");

                entity.Property(e => e.Stissretido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STISSRETIDO")
                    .IsFixedLength();

                entity.Property(e => e.Stnumeroart)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STNUMEROART");

                entity.Property(e => e.Stobservacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.Property(e => e.Stoptantesimplesnacional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOPTANTESIMPLESNACIONAL")
                    .IsFixedLength();

                entity.Property(e => e.Stoutrasinf)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("STOUTRASINF");

                entity.Property(e => e.StpreCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_CEP");

                entity.Property(e => e.StpreCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_CPFCNPJ");

                entity.Property(e => e.StpreEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_EMAIL");

                entity.Property(e => e.StpreEndbairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_ENDBAIRRO");

                entity.Property(e => e.StpreEndcomplemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_ENDCOMPLEMENTO");

                entity.Property(e => e.StpreEndlogradouro)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_ENDLOGRADOURO");

                entity.Property(e => e.StpreEndnumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_ENDNUMERO");

                entity.Property(e => e.StpreIm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_IM");

                entity.Property(e => e.StpreNomefantasia)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_NOMEFANTASIA");

                entity.Property(e => e.StpreRazaosocial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_RAZAOSOCIAL");

                entity.Property(e => e.StpreTelefone)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("STPRE_TELEFONE");

                entity.Property(e => e.Strecolheiss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECOLHEISS")
                    .IsFixedLength();

                entity.Property(e => e.Stserie)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STSERIE")
                    .IsFixedLength();

                entity.Property(e => e.StservicoDescricao)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("STSERVICO_DESCRICAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.SttomCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_CEP")
                    .IsFixedLength();

                entity.Property(e => e.SttomCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_CPFCNPJ");

                entity.Property(e => e.SttomEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_EMAIL");

                entity.Property(e => e.SttomEndBairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_END_BAIRRO");

                entity.Property(e => e.SttomEndComplemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_END_COMPLEMENTO");

                entity.Property(e => e.SttomEndLogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_END_LOGR");

                entity.Property(e => e.SttomEndNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_END_NUMERO");

                entity.Property(e => e.SttomIm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_IM")
                    .IsFixedLength();

                entity.Property(e => e.SttomNome)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_NOME");

                entity.Property(e => e.SttomPessoaTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_PESSOA_TIPO")
                    .IsFixedLength();

                entity.Property(e => e.SttomTelefone)
                    .HasMaxLength(17)
                    .HasColumnName("STTOM_TELEFONE")
                    .IsFixedLength();

                entity.Property(e => e.Stunideco)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STUNIDECO")
                    .IsFixedLength();

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vlcofins)
                    .HasColumnType("numeric(14, 5)")
                    .HasColumnName("VLCOFINS");

                entity.Property(e => e.Vlcredito)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLCREDITO");

                entity.Property(e => e.Vlcsll)
                    .HasColumnType("numeric(14, 5)")
                    .HasColumnName("VLCSLL");

                entity.Property(e => e.Vldeducoes)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDEDUCOES");

                entity.Property(e => e.Vldesccondicionado)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCCONDICIONADO");

                entity.Property(e => e.Vldescincondicionado)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCINCONDICIONADO");

                entity.Property(e => e.Vlinss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLINSS");

                entity.Property(e => e.Vliof)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLIOF");

                entity.Property(e => e.Vlir)
                    .HasColumnType("numeric(14, 5)")
                    .HasColumnName("VLIR");

                entity.Property(e => e.Vlissretido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLISSRETIDO");

                entity.Property(e => e.Vloutrasretencoes)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLOUTRASRETENCOES");

                entity.Property(e => e.Vlpis)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLPIS");

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotaliss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALISS");

                entity.Property(e => e.Vltotalliquido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALLIQUIDO");
            });

            modelBuilder.Entity<NfseTblNfseDesconto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_NFSE_DESCONTO");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_NFSE_DESCONTO_IDNFSE")
                    .IsClustered();

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idtipodesconto).HasColumnName("IDTIPODESCONTO");

                entity.Property(e => e.Streferencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STREFERENCIA");

                entity.Property(e => e.Vlcamporeferente)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLCAMPOREFERENTE");

                entity.Property(e => e.Vldesconto)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLDESCONTO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_NFSE_DESCONTO_NFSE_TBL_NFSE");

                entity.HasOne(d => d.IdtipodescontoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idtipodesconto)
                    .HasConstraintName("FK_NFSE_TBL_NFSE_DESCONTO_NFSE_TBL_TIPO_DESCONTO");
            });

            modelBuilder.Entity<NfseTblNfseLiquidadum>(entity =>
            {
                entity.HasKey(e => e.Idnfse)
                    .HasName("PK_NSFE_TBL_NFSE_LIQUIDADA");

                entity.ToTable("NFSE_TBL_NFSE_LIQUIDADA");

                entity.HasIndex(e => e.Idliquidacao, "IX_NFSE_TBL_NFSE_LIQUIDADA_IDLIQUIDACAO");

                entity.Property(e => e.Idnfse)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSE");

                entity.Property(e => e.Idliquidacao).HasColumnName("IDLIQUIDACAO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithOne(p => p.NfseTblNfseLiquidadum)
                    .HasForeignKey<NfseTblNfseLiquidadum>(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NSFE_TBL_NFSE_LIQUIDADA_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblNfseNum>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.Nunumero, e.Nuano })
                    .HasName("PK__NFSE_TBL__DAD77F8E4AB81AF0");

                entity.ToTable("NFSE_TBL_NFSE_NUM");

                entity.HasIndex(e => new { e.Idempresa, e.Nunumero, e.Nuano }, "IDX_NUMERO_ANO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Nunumero).HasColumnName("NUNUMERO");

                entity.Property(e => e.Nuano).HasColumnName("NUANO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblNfseNums)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_NFSE_NUM_NFSE_TBL_EMPRESA");
            });

            modelBuilder.Entity<NfseTblNfsePrestador>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_NFSE_PRESTADOR");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_NFSE_PRESTADOR_IDNFSE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.NucidadeIbge, "IX_NFSE_TBL_NFSE_PRESTADOR_NUCIDADE_IBGE");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.NucidadeIbge).HasColumnName("NUCIDADE_IBGE");

                entity.Property(e => e.Stbairro)
                    .HasMaxLength(60)
                    .HasColumnName("STBAIRRO")
                    .IsFixedLength();

                entity.Property(e => e.Stcep)
                    .HasMaxLength(8)
                    .HasColumnName("STCEP")
                    .IsFixedLength();

                entity.Property(e => e.Stcomplemento)
                    .HasMaxLength(60)
                    .HasColumnName("STCOMPLEMENTO")
                    .IsFixedLength();

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .HasColumnName("STCPFCNPJ")
                    .IsFixedLength();

                entity.Property(e => e.Stemail)
                    .HasMaxLength(80)
                    .HasColumnName("STEMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Stendereco)
                    .HasMaxLength(125)
                    .HasColumnName("STENDERECO")
                    .IsFixedLength();

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM")
                    .IsFixedLength();

                entity.Property(e => e.StnomeFantasia)
                    .HasMaxLength(60)
                    .HasColumnName("STNOME_FANTASIA")
                    .IsFixedLength();

                entity.Property(e => e.Stnumero)
                    .HasMaxLength(10)
                    .HasColumnName("STNUMERO")
                    .IsFixedLength();

                entity.Property(e => e.StrazaoSocial)
                    .HasMaxLength(115)
                    .HasColumnName("STRAZAO_SOCIAL")
                    .IsFixedLength();

                entity.Property(e => e.Sttelefone)
                    .HasMaxLength(15)
                    .HasColumnName("STTELEFONE")
                    .IsFixedLength();

                entity.Property(e => e.Stuf)
                    .HasMaxLength(2)
                    .HasColumnName("STUF")
                    .IsFixedLength();

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_NFSE_PRESTADOR_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblPainelMensagem>(entity =>
            {
                entity.HasKey(e => e.Idmensagem);

                entity.ToTable("NFSE_TBL_PAINEL_MENSAGEM");

                entity.Property(e => e.Idmensagem)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMENSAGEM");

                entity.Property(e => e.Dtfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("DTFINAL");

                entity.Property(e => e.Dtinicial)
                    .HasColumnType("datetime")
                    .HasColumnName("DTINICIAL");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Stmensagem)
                    .IsUnicode(false)
                    .HasColumnName("STMENSAGEM");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Sttitulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STTITULO");
            });

            modelBuilder.Entity<NfseTblParametroTexto>(entity =>
            {
                entity.HasKey(e => e.Idparam)
                    .HasName("PK_NFSE_TBL_PARAMETRIZACAO_TEXTO");

                entity.ToTable("NFSE_TBL_PARAMETRO_TEXTO");

                entity.Property(e => e.Idparam)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPARAM");

                entity.Property(e => e.Idform).HasColumnName("IDFORM");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Sttexto)
                    .IsUnicode(false)
                    .HasColumnName("STTEXTO");
            });

            modelBuilder.Entity<NfseTblPedAlteraRegime>(entity =>
            {
                entity.HasKey(e => e.Idpedido);

                entity.ToTable("NFSE_TBL_PED_ALTERA_REGIME");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_PED_ALTERA_REGIME_IDEMPRESA");

                entity.HasIndex(e => e.Idregime, "IX_NFSE_TBL_PED_ALTERA_REGIME_IDREGIME");

                entity.Property(e => e.Idpedido)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPEDIDO");

                entity.Property(e => e.Dtparecer)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPARECER");

                entity.Property(e => e.Dtsolicitacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTSOLICITACAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stfiscal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STFISCAL");

                entity.Property(e => e.Stituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stobservacao)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.Property(e => e.Stparecer)
                    .IsUnicode(false)
                    .HasColumnName("STPARECER");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblPedAlteraRegimes)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_PED_ALTERA_REGIME_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblPedAlteraRegimes)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_PED_ALTERA_REGIME_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblPedCancelamento>(entity =>
            {
                entity.HasKey(e => e.Idcancelamento);

                entity.ToTable("NFSE_TBL_PED_CANCELAMENTO");

                entity.HasIndex(e => e.Idmotcan, "IX_NFSE_TBL_PED_CANCELAMENTO_IDMOTCAN")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_PED_CANCELAMENTO_IDNFSE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idnfseref, "IX_NFSE_TBL_PED_CANCELAMENTO_IDNFSEREF");

                entity.HasIndex(e => new { e.Idnfse, e.Idcancelamento, e.Dthorasolicitacao, e.Idusuarioavaliou }, "IX_NFSE_TBL_PED_CANCELAMENTO_IDNFSE_IDCANCEL_DTSOLIC_IDUSU");

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_PED_CANCELAMENTO_IDUSUARIO")
                    .HasFillFactor(90);

                entity.Property(e => e.Idcancelamento)
                    .ValueGeneratedNever()
                    .HasColumnName("IDCANCELAMENTO");

                entity.Property(e => e.Dthoraconfirmacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORACONFIRMACAO");

                entity.Property(e => e.Dthorasolicitacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORASOLICITACAO");

                entity.Property(e => e.Idmotcan).HasColumnName("IDMOTCAN");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idnfseref).HasColumnName("IDNFSEREF");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Idusuarioavaliou)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOAVALIOU");

                entity.Property(e => e.Stdescmotcan)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STDESCMOTCAN");

                entity.Property(e => e.Stobsavaliacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STOBSAVALIACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdmotcanNavigation)
                    .WithMany(p => p.NfseTblPedCancelamentos)
                    .HasForeignKey(d => d.Idmotcan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_PED_CANCELAMENTO_NFSE_TBL_MOTIVO_CANCELAMENTO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblPedCancelamentos)
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_PED_CANCELAMENTO_NFSE_TBL_NFSE");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblPedCancelamentos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_PED_CANCELAMENTO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblPedCancelamentoAnexo>(entity =>
            {
                entity.HasKey(e => e.Idanexo);

                entity.ToTable("NFSE_TBL_PED_CANCELAMENTO_ANEXOS");

                entity.HasIndex(e => e.Idcancelamento, "IX_NFSE_TBL_PED_CANCELAMENTO_ANEXOS_IDCANCELAMENTO");

                entity.Property(e => e.Idanexo).HasColumnName("IDANEXO");

                entity.Property(e => e.Anexo).HasColumnName("ANEXO");

                entity.Property(e => e.Idcancelamento).HasColumnName("IDCANCELAMENTO");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");
            });

            modelBuilder.Entity<NfseTblPedIncluirServico>(entity =>
            {
                entity.HasKey(e => e.Idpedido);

                entity.ToTable("NFSE_TBL_PED_INCLUIR_SERVICOS");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_PED_INCLUIR_SERVICOS_IDEMPRESA");

                entity.Property(e => e.Idpedido)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPEDIDO");

                entity.Property(e => e.Dtparecer)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPARECER");

                entity.Property(e => e.Dtpedido)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPEDIDO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stfiscal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STFISCAL");

                entity.Property(e => e.Stobservacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.Property(e => e.Stparecer)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STPARECER");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblPedServicosIncluso>(entity =>
            {
                entity.HasKey(e => new { e.Idservico, e.Idpedido })
                    .HasName("pk_ServicoPedido");

                entity.ToTable("NFSE_TBL_PED_SERVICOS_INCLUSOS");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Idpedido).HasColumnName("IDPEDIDO");
            });

            modelBuilder.Entity<NfseTblPedSubstituicao>(entity =>
            {
                entity.HasKey(e => e.Idnupedsubs);

                entity.ToTable("NFSE_TBL_PED_SUBSTITUICAO");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_PED_SUBSTITUICAO_IDNFSE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_PED_SUBSTITUICAO_IDUSUARIO")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuarioconfirmou, "IX_NFSE_TBL_PED_SUBSTITUICAO_IDUSUARIOCONFIRMOU");

                entity.Property(e => e.Idnupedsubs)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNUPEDSUBS");

                entity.Property(e => e.Dthoraconfirmacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORACONFIRMACAO");

                entity.Property(e => e.Dthorasolicitacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTHORASOLICITACAO");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Idusuarioconfirmou)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIOCONFIRMOU")
                    .HasComment("Id do usuário no administrativo que efetuou a liberação");

                entity.Property(e => e.Stobsavaliacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STOBSAVALIACAO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblPedSubstituicaos)
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_PED_SUBSTITUICAO_NFSE_TBL_NFSE");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblPedSubstituicaos)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("FK_NFSE_TBL_PED_SUBSTITUICAO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblPerfil>(entity =>
            {
                entity.HasKey(e => e.Idperfil);

                entity.ToTable("NFSE_TBL_PERFIL");

                entity.HasIndex(e => e.Idempresa, "IX_NFSE_TBL_PERFIL_IDEMPRESA")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_PERFIL_IDUSUARIO")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idempresa, e.Idusuario, e.Idperfil }, "_dta_index_NFSE_TBL_PERFIL_19_1823345560__K2_K3_K1_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_");

                entity.Property(e => e.Idperfil)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPERFIL");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stcadaliquota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCADALIQUOTA")
                    .IsFixedLength();

                entity.Property(e => e.Stcancelanfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCANCELANFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stcancelarboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCANCELARBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stcargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCARGO");

                entity.Property(e => e.Stconapumeniss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONAPUMENISS")
                    .IsFixedLength();

                entity.Property(e => e.Stcondemcontab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONDEMCONTAB")
                    .IsFixedLength();

                entity.Property(e => e.Stcondemparlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONDEMPARLAN")
                    .IsFixedLength();

                entity.Property(e => e.Stconinfcommun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONINFCOMMUN")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultaextrato)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTAEXTRATO")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultaloterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTALOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfseemitida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSEEMITIDA")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfseporrps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSEPORRPS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultanfserecebida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTANFSERECEBIDA")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultarboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTARBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stconsultasituloterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCONSULTASITULOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stcredencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCREDENCIA")
                    .IsFixedLength();

                entity.Property(e => e.Stcriagrupos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCRIAGRUPOS")
                    .IsFixedLength();

                entity.Property(e => e.Stdecapumeniss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECAPUMENISS")
                    .IsFixedLength();

                entity.Property(e => e.Stdecdemcontab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECDEMCONTAB")
                    .IsFixedLength();

                entity.Property(e => e.Stdecdemparlan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECDEMPARLAN")
                    .IsFixedLength();

                entity.Property(e => e.Stdecinfcommun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECINFCOMMUN")
                    .IsFixedLength();

                entity.Property(e => e.Stdeclaracoes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDECLARACOES")
                    .IsFixedLength();

                entity.Property(e => e.Stemitenfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEMITENFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stemitirboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEMITIRBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stencerracompetencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENCERRACOMPETENCIA")
                    .IsFixedLength();

                entity.Property(e => e.Stenvialoterps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STENVIALOTERPS")
                    .IsFixedLength();

                entity.Property(e => e.Stexportanfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEXPORTANFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stexportanfserecebidas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STEXPORTANFSERECEBIDAS")
                    .IsFixedLength();

                entity.Property(e => e.Stgerarlivrofiscal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STGERARLIVROFISCAL")
                    .IsFixedLength();

                entity.Property(e => e.Sthomologacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STHOMOLOGACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stimprimenfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STIMPRIMENFSE")
                    .IsFixedLength();

                entity.Property(e => e.Stimprimirboletos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STIMPRIMIRBOLETOS")
                    .IsFixedLength();

                entity.Property(e => e.Stintervenecf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINTERVENECF")
                    .IsFixedLength();

                entity.Property(e => e.Strecibos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECIBOS")
                    .IsFixedLength();

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stsubstituinfse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSUBSTITUINFSE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblPlacar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_PLACAR");

                entity.Property(e => e.Dtcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCARGA");

                entity.Property(e => e.Numautorizadaemissao).HasColumnName("NUMAUTORIZADAEMISSAO");

                entity.Property(e => e.Numnfseemitidas).HasColumnName("NUMNFSEEMITIDAS");

                entity.Property(e => e.Numsolicitaramcredencial).HasColumnName("NUMSOLICITARAMCREDENCIAL");

                entity.Property(e => e.Numtomadorescadastro).HasColumnName("NUMTOMADORESCADASTRO");
            });

            modelBuilder.Entity<NfseTblReciboRetencao>(entity =>
            {
                entity.HasKey(e => e.IdreciboRetencao)
                    .HasName("PK_NFSE_TBL_DECLARACAO_RETENCAO");

                entity.ToTable("NFSE_TBL_RECIBO_RETENCAO");

                entity.HasIndex(e => e.Dtdataemissao, "IX_NFSE_TBL_RECIBO_RETENCAO_DTDATAEMISSAO");

                entity.HasIndex(e => e.Idnfse, "IX_NFSE_TBL_RECIBO_RETENCAO_IDNFSE")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idusuario, "IX_NFSE_TBL_RECIBO_RETENCAO_IDUSUARIO")
                    .HasFillFactor(90);

                entity.Property(e => e.IdreciboRetencao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDRECIBO_RETENCAO");

                entity.Property(e => e.Dtdataemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATAEMISSAO");

                entity.Property(e => e.Dtdataexpiracao)
                    .HasColumnType("date")
                    .HasColumnName("DTDATAEXPIRACAO");

                entity.Property(e => e.Dtparecer)
                    .HasColumnType("datetime")
                    .HasColumnName("DTPARECER");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblReciboRetencaos)
                    .HasForeignKey(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_RETENCAO_NFSE_TBL_NFSE");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.NfseTblReciboRetencaos)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("FK_NFSE_TBL_DECLARACAO_RETENCAO_NFSE_TBL_USUARIO");
            });

            modelBuilder.Entity<NfseTblReciboRetencaoNota>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NFSE_TBL_RECIBO_RETENCAO_NOTAS");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Idrecibo).HasColumnName("IDRECIBO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_RECIBO_RETENCAO_NOTAS_NFSE_TBL_NFSE");

                entity.HasOne(d => d.IdreciboNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idrecibo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_RECIBO_RETENCAO_NOTAS_NFSE_TBL_RECIBO_RETENCAO");
            });

            modelBuilder.Entity<NfseTblRegime>(entity =>
            {
                entity.HasKey(e => e.Idregime);

                entity.ToTable("NFSE_TBL_REGIME");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Flativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FLATIVO")
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.Nuordem).HasColumnName("NUORDEM");

                entity.Property(e => e.Stdescregime)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("STDESCREGIME");

                entity.Property(e => e.Stgeradam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STGERADAM")
                    .IsFixedLength();

                entity.Property(e => e.Stnomeregime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STNOMEREGIME");

                entity.Property(e => e.Stsimpnac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSIMPNAC")
                    .IsFixedLength();

                entity.Property(e => e.Sttipoaliquota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOALIQUOTA")
                    .IsFixedLength();

                entity.Property(e => e.Sttomretemiss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTOMRETEMISS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblRegimeAliquota>(entity =>
            {
                entity.HasKey(e => new { e.Idregime, e.Nuvalini, e.Nuvalfim });

                entity.ToTable("NFSE_TBL_REGIME_ALIQUOTAS");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Nuvalini)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("NUVALINI");

                entity.Property(e => e.Nuvalfim)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("NUVALFIM");

                entity.Property(e => e.Nrordem).HasColumnName("NRORDEM");

                entity.Property(e => e.Nualiqcofins)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("NUALIQCOFINS");

                entity.Property(e => e.Nualiqcsll)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("NUALIQCSLL");

                entity.Property(e => e.Nualiqiss)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("NUALIQISS");

                entity.Property(e => e.Nualiqpis)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("NUALIQPIS");

                entity.HasOne(d => d.IdregimeNavigation)
                    .WithMany(p => p.NfseTblRegimeAliquota)
                    .HasForeignKey(d => d.Idregime)
                    .HasConstraintName("FK_NFSE_TBL_REGIME_ALIQUOTAS_NFSE_TBL_REGIME");
            });

            modelBuilder.Entity<NfseTblRegra>(entity =>
            {
                entity.HasKey(e => e.Idregra);

                entity.ToTable("NFSE_TBL_REGRAS");

                entity.HasIndex(e => e.Sttpchecagem, "IX_NFSE_TBL_REGRAS_STTPCHECAGEM");

                entity.Property(e => e.Idregra)
                    .ValueGeneratedNever()
                    .HasColumnName("IDREGRA");

                entity.Property(e => e.Nusequencia).HasColumnName("NUSEQUENCIA");

                entity.Property(e => e.Stdescricao)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stformula)
                    .IsUnicode(false)
                    .HasColumnName("STFORMULA");

                entity.Property(e => e.Sttpchecagem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STTPCHECAGEM");

                entity.Property(e => e.Stvlretorno)
                    .IsUnicode(false)
                    .HasColumnName("STVLRETORNO");
            });

            modelBuilder.Entity<NfseTblRegrasErro>(entity =>
            {
                entity.HasKey(e => e.Iderro);

                entity.ToTable("NFSE_TBL_REGRAS_ERROS");

                entity.HasIndex(e => e.Idregra, "IX_NFSE_TBL_REGRAS_ERROS_IDREGRA");

                entity.Property(e => e.Iderro).HasColumnName("IDERRO");

                entity.Property(e => e.Dterro)
                    .HasColumnType("datetime")
                    .HasColumnName("DTERRO");

                entity.Property(e => e.Idregra).HasColumnName("IDREGRA");

                entity.Property(e => e.Sterro)
                    .IsUnicode(false)
                    .HasColumnName("STERRO");

                entity.Property(e => e.Stnfse)
                    .IsUnicode(false)
                    .HasColumnName("STNFSE");

                entity.HasOne(d => d.IdregraNavigation)
                    .WithMany(p => p.NfseTblRegrasErros)
                    .HasForeignKey(d => d.Idregra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_REGRAS_ERROS_NFSE_TBL_REGRAS");
            });

            modelBuilder.Entity<NfseTblRelcomparativoemissaonotum>(entity =>
            {
                entity.HasKey(e => e.Idnfse)
                    .HasName("PK__NFSE_TBL__RELCOMPARATIVOEMISSAONOTA");

                entity.ToTable("NFSE_TBL_RELCOMPARATIVOEMISSAONOTA");

                entity.Property(e => e.Idnfse)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSE");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Datahomologacao)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAHOMOLOGACAO");

                entity.Property(e => e.Dtcompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DTCOMPETENCIA");

                entity.Property(e => e.Emprsituacaodescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPRSITUACAODESCRICAO");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idnfsecontratos).HasColumnName("IDNFSECONTRATOS");

                entity.Property(e => e.Idoperacao).HasColumnName("IDOPERACAO");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Situacaohomologacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAOHOMOLOGACAO")
                    .IsFixedLength();

                entity.Property(e => e.Stcepcontribuinte)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("STCEPCONTRIBUINTE")
                    .IsFixedLength();

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.StenderecoBairro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_BAIRRO");

                entity.Property(e => e.StenderecoLogr)
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_LOGR");

                entity.Property(e => e.StenderecoNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STENDERECO_NUMERO");

                entity.Property(e => e.Stim)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STIM");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stnomecidade)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STNOMECIDADE");

                entity.Property(e => e.Stsituacaonf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAONF")
                    .IsFixedLength();

                entity.Property(e => e.SttomCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_CPFCNPJ");

                entity.Property(e => e.Stufcidade)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STUFCIDADE")
                    .IsFixedLength();

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotaliss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALISS");
            });

            modelBuilder.Entity<NfseTblRp>(entity =>
            {
                entity.HasKey(e => e.Idnfse)
                    .HasName("PK_NFS_TBL_RPS");

                entity.ToTable("NFSE_TBL_RPS");

                entity.HasIndex(e => new { e.Idnfse, e.Numero }, "IDNFSE_NUMERO")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Idnfse, "IDX_NFSE");

                entity.HasIndex(e => new { e.Numero, e.Serie }, "IX_NFSE_TBL_RPS_NUMERO_SERIE");

                entity.HasIndex(e => new { e.Numero, e.Tipo, e.Serie, e.Idnfse }, "IX_NFSE_TBL_RPS_NUMERO_TIPO_SERIE_IDNFSE");

                entity.HasIndex(e => new { e.RpsNumeprot, e.Idnfse }, "IX_NFSE_TBL_RPS_RPS_NUMEPROT_IDNFSE_inc_NUMERO_SERIE_TIPO");

                entity.HasIndex(e => e.RpsNumeprot, "IX_RPS_NUMEPROT");

                entity.Property(e => e.Idnfse)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSE");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.RpsNumeprot).HasColumnName("RPS_NUMEPROT");

                entity.Property(e => e.Serie)
                    .HasMaxLength(5)
                    .HasColumnName("SERIE")
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithOne(p => p.NfseTblRp)
                    .HasForeignKey<NfseTblRp>(d => d.Idnfse)
                    .HasConstraintName("FK_NFS_TBL_RPS_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblRpsImpresso>(entity =>
            {
                entity.HasKey(e => e.Idrpsimpresso);

                entity.ToTable("NFSE_TBL_RPS_IMPRESSO");

                entity.Property(e => e.Idrpsimpresso).HasColumnName("IDRPSIMPRESSO");

                entity.Property(e => e.Dtemissao)
                    .HasColumnType("datetime")
                    .HasColumnName("DTEMISSAO");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idnfse).HasColumnName("IDNFSE");

                entity.Property(e => e.Nunumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUNUMERO");

                entity.Property(e => e.Stserie)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STSERIE");

                entity.Property(e => e.Sttipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STTIPO");

                entity.HasOne(d => d.IdempresaNavigation)
                    .WithMany(p => p.NfseTblRpsImpressos)
                    .HasForeignKey(d => d.Idempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_RPS_IMPRESSO_NFSE_TBL_EMPRESA");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithMany(p => p.NfseTblRpsImpressos)
                    .HasForeignKey(d => d.Idnfse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFSE_TBL_RPS_IMPRESSO_NFSE_TBL_NFSE");
            });

            modelBuilder.Entity<NfseTblRpssub>(entity =>
            {
                entity.HasKey(e => e.Idnfse);

                entity.ToTable("NFSE_TBL_RPSSUBS");

                entity.Property(e => e.Idnfse)
                    .ValueGeneratedNever()
                    .HasColumnName("IDNFSE");

                entity.Property(e => e.Idnfsesub).HasColumnName("IDNFSESUB");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.RpsNumeprot).HasColumnName("RPS_NUMEPROT");

                entity.Property(e => e.Serie)
                    .HasMaxLength(5)
                    .HasColumnName("SERIE")
                    .IsFixedLength();

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.IdnfseNavigation)
                    .WithOne(p => p.NfseTblRpssub)
                    .HasForeignKey<NfseTblRpssub>(d => d.Idnfse)
                    .HasConstraintName("FK_NFSE_TBL_RPSSUBS_NFSE_TBL_RPSSUBS");
            });

            modelBuilder.Entity<NfseTblServico>(entity =>
            {
                entity.HasKey(e => e.Idservico)
                    .HasName("PK__NFSE_TBL__557E69914E88ABD4");

                entity.ToTable("NFSE_TBL_SERVICO");

                entity.HasIndex(e => e.Idservico, "IDX_SERVICO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Staliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("STALIQUOTA");

                entity.Property(e => e.Stbaselegal)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STBASELEGAL");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stobrigaretencaofora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOBRIGARETENCAOFORA")
                    .IsFixedLength();

                entity.Property(e => e.Stobrigaretencaonomunicipio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOBRIGARETENCAONOMUNICIPIO")
                    .IsFixedLength();

                entity.Property(e => e.Strecolhemuni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRECOLHEMUNI")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Stsofrededucao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSOFREDEDUCAO")
                    .IsFixedLength();

                entity.Property(e => e.Stvetado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STVETADO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblTipoDeclaracao>(entity =>
            {
                entity.HasKey(e => e.Idtipodeclaracao);

                entity.ToTable("NFSE_TBL_TIPO_DECLARACAO");

                entity.HasIndex(e => e.Idtipobaixa, "IX_NFSE_TBL_TIPO_DECLARACAO_IDTIPOBAIXA");

                entity.Property(e => e.Idtipodeclaracao)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTIPODECLARACAO");

                entity.Property(e => e.Idtipobaixa).HasColumnName("IDTIPOBAIXA");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stinformacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STINFORMACAO");
            });

            modelBuilder.Entity<NfseTblTipoDesconto>(entity =>
            {
                entity.HasKey(e => e.Idtipodesconto);

                entity.ToTable("NFSE_TBL_TIPO_DESCONTO");

                entity.HasIndex(e => e.Idservico, "IX_NFSE_TBL_TIPO_DESCONTO_IDSERVICO");

                entity.Property(e => e.Idtipodesconto)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTIPODESCONTO");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Stcamporesultado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STCAMPORESULTADO");

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stformato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STFORMATO");

                entity.Property(e => e.Stformula)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STFORMULA");

                entity.Property(e => e.Stobservacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACAO");

                entity.HasOne(d => d.IdservicoNavigation)
                    .WithMany(p => p.NfseTblTipoDescontos)
                    .HasForeignKey(d => d.Idservico)
                    .HasConstraintName("FK_NFSE_TBL_TIPO_DESCONTO_NFSE_TBL_SERVICO");
            });

            modelBuilder.Entity<NfseTblTipoTomador>(entity =>
            {
                entity.HasKey(e => e.Idtipotomador);

                entity.ToTable("NFSE_TBL_TIPO_TOMADOR");

                entity.Property(e => e.Idtipotomador)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTIPOTOMADOR");

                entity.Property(e => e.Stcadcontrib)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STCADCONTRIB")
                    .IsFixedLength();

                entity.Property(e => e.Stdesccamponome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCCAMPONOME");

                entity.Property(e => e.Stdocobrigatorio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STDOCOBRIGATORIO")
                    .IsFixedLength();

                entity.Property(e => e.Stinformacao)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STINFORMACAO");

                entity.Property(e => e.Stnome)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.Stnometipodoc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STNOMETIPODOC");

                entity.Property(e => e.Stretemiss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STRETEMISS")
                    .IsFixedLength();

                entity.Property(e => e.Stsigla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSIGLA")
                    .IsFixedLength();

                entity.Property(e => e.Sttipotompadrao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOTOMPADRAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblTributo>(entity =>
            {
                entity.ToTable("NFSE_TBL_TRIBUTOS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Idcamporef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDCAMPOREF");

                entity.Property(e => e.Nome)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<NfseTblUsuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario);

                entity.ToTable("NFSE_TBL_USUARIO");

                entity.HasIndex(e => e.Idcontribuinte, "IDCONTRIBUINTE")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Idcontribuinte, e.Idusuario }, "IX_NFSE_TBL_USUARIO_IDCONTRIBUINTE_IDUSUARIO");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Atualizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATUALIZADO")
                    .IsFixedLength();

                entity.Property(e => e.Dtvalidadesenha)
                    .HasColumnType("date")
                    .HasColumnName("DTVALIDADESENHA");

                entity.Property(e => e.Idcontribuinte).HasColumnName("IDCONTRIBUINTE");

                entity.Property(e => e.Stsenha)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STSENHA");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();

                entity.HasOne(d => d.IdcontribuinteNavigation)
                    .WithMany(p => p.NfseTblUsuarios)
                    .HasForeignKey(d => d.Idcontribuinte)
                    .HasConstraintName("FK_NFSE_TBL_USUARIO_NFSE_TBL_CONTRIBUINTE");
            });

            modelBuilder.Entity<NfseTblUsuarioMensagem>(entity =>
            {
                entity.HasKey(e => new { e.Idmensagem, e.Idusuario })
                    .HasName("PK__NFSE_TBL__8394BF855535A963");

                entity.ToTable("NFSE_TBL_USUARIO_MENSAGEM");

                entity.Property(e => e.Idmensagem).HasColumnName("IDMENSAGEM");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.Stsituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSITUACAO")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NfseTblVideo>(entity =>
            {
                entity.ToTable("NFSE_TBL_VIDEOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Arqbin)
                    .HasMaxLength(10)
                    .HasColumnName("ARQBIN")
                    .IsFixedLength();

                entity.Property(e => e.Arqnome)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ARQNOME");

                entity.Property(e => e.Arqseq).HasColumnName("ARQSEQ");

                entity.Property(e => e.Arqtipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARQTIPO");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITULO");
            });

            modelBuilder.Entity<NfseTblWsSemaforo>(entity =>
            {
                entity.HasKey(e => e.Cpfcnpj)
                    .HasName("CPFCNPJ")
                    .IsClustered(false);

                entity.ToTable("NFSE_TBL_WS_SEMAFORO");

                entity.Property(e => e.Cpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPFCNPJ");
            });

            modelBuilder.Entity<NotasEmitida>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NotasEmitidas");

                entity.Property(e => e.AliquotaNota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("Aliquota_Nota");

                entity.Property(e => e.AliquotaServico)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("Aliquota_Servico");

                entity.Property(e => e.AnoCompetencia).HasColumnName("ano_Competencia");

                entity.Property(e => e.BaseCalculoNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Base_Calculo_Nota");

                entity.Property(e => e.CeiNota)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CEI_Nota");

                entity.Property(e => e.Cmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC");

                entity.Property(e => e.Cmctomador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMCTomador")
                    .IsFixedLength();

                entity.Property(e => e.CodIbeCidadePrestacaoServico)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBE_Cidade_Prestacao_Servico")
                    .IsFixedLength();

                entity.Property(e => e.CodIbeCidadePrestador)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBE_Cidade_Prestador")
                    .IsFixedLength();

                entity.Property(e => e.CodIbeCidadeTomador)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Cod_IBE_Cidade_Tomador")
                    .IsFixedLength();

                entity.Property(e => e.CofinsNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Cofins_Nota");

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ");

                entity.Property(e => e.Cpfcnpjtomador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPFCNPJTomador");

                entity.Property(e => e.CrcContribuinteEmpresa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRC_Contribuinte_Empresa");

                entity.Property(e => e.CreditoNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Credito_Nota");

                entity.Property(e => e.CsllNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("CSLL_Nota");

                entity.Property(e => e.DataCompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Competencia");

                entity.Property(e => e.DataNota)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Nota");

                entity.Property(e => e.DeducoesNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Deducoes_Nota");

                entity.Property(e => e.DescontoCondicionadoNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Desconto_Condicionado_Nota");

                entity.Property(e => e.DescontoIncondicionadoNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Desconto_Incondicionado_Nota");

                entity.Property(e => e.DescricaoRegime)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Regime");

                entity.Property(e => e.DescricaoServiço)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Descricao_Serviço");

                entity.Property(e => e.EmailNota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Email_Nota")
                    .IsFixedLength();

                entity.Property(e => e.EspecialNaturezaOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Especial_Natureza_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.ExigeSuspensaNaturezaOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Exige_Suspensa_Natureza_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.IdCidadePrestacaoServico).HasColumnName("Id_Cidade_Prestacao_Servico");

                entity.Property(e => e.IdCidadePrestador).HasColumnName("Id_Cidade_Prestador");

                entity.Property(e => e.IdCidadeTomador).HasColumnName("Id_Cidade_Tomador");

                entity.Property(e => e.IdContribuinteEmpresa).HasColumnName("Id_Contribuinte_Empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.IdIdentificadorNota)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Identificador_Nota");

                entity.Property(e => e.IdMunGeradorNota).HasColumnName("Id_Mun_Gerador_Nota");

                entity.Property(e => e.IdNaturezaOperacao).HasColumnName("Id_Natureza_Operacao");

                entity.Property(e => e.IdNaturezaOperacaoNota).HasColumnName("Id_Natureza_Operacao_Nota");

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");

                entity.Property(e => e.IdRegime1).HasColumnName("Id_Regime");

                entity.Property(e => e.IdServicoNota)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Servico_Nota")
                    .IsFixedLength();

                entity.Property(e => e.IdServiço)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Serviço")
                    .IsFixedLength();

                entity.Property(e => e.IdSubstitutoNota).HasColumnName("Id_Substituto_Nota");

                entity.Property(e => e.IdTributacaoMunicipioNota)
                    .HasMaxLength(20)
                    .HasColumnName("Id_Tributacao_Municipio_Nota")
                    .IsFixedLength();

                entity.Property(e => e.IdUsuarioInclusao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Id_Usuario_Inclusao");

                entity.Property(e => e.IdcnaeSubclasse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDCNAE_SUBCLASSE")
                    .IsFixedLength();

                entity.Property(e => e.IdpreIdcidade).HasColumnName("IDPRE_IDCIDADE");

                entity.Property(e => e.Idregime).HasColumnName("IDREGIME");

                entity.Property(e => e.InssNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("INSS_Nota");

                entity.Property(e => e.IofNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("IOF_Nota");

                entity.Property(e => e.IrNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("IR_Nota");

                entity.Property(e => e.IsRetidoNota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_Retido_Nota")
                    .IsFixedLength();

                entity.Property(e => e.MesCompetencia).HasColumnName("Mes_Competencia");

                entity.Property(e => e.NomeCidadePrestacaoServico)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Cidade_Prestacao_Servico");

                entity.Property(e => e.NomeCidadePrestador)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Cidade_Prestador");

                entity.Property(e => e.NomeCidadeTomador)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Cidade_Tomador");

                entity.Property(e => e.NomeContribuinte)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NomeTomador)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroArtigoNota)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Artigo_Nota");

                entity.Property(e => e.NumeroNota).HasColumnName("Numero_Nota");

                entity.Property(e => e.NumeroOrdemRegime).HasColumnName("Numero_Ordem_Regime");

                entity.Property(e => e.ObrigaRetencaoMunServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Obriga_Retencao_Mun_Servico")
                    .IsFixedLength();

                entity.Property(e => e.OutrasInformacoesNota)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Outras_Informacoes_Nota");

                entity.Property(e => e.OutrasRetencoesNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Outras_Retencoes_Nota");

                entity.Property(e => e.PadraoNaturezaOperacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Padrao_Natureza_Operacao")
                    .IsFixedLength();

                entity.Property(e => e.PisNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("PIS_Nota");

                entity.Property(e => e.RecolheIssInclusaoNota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Recolhe_ISS_Inclusao_Nota")
                    .IsFixedLength();

                entity.Property(e => e.RecolherServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Recolher_Servico")
                    .IsFixedLength();

                entity.Property(e => e.RegimeNota)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegimePrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicoDescricaoNota)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("Servico_Descricao_Nota");

                entity.Property(e => e.ServicosNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Servicos_Nota");

                entity.Property(e => e.SimNacionalEmpresa)
                    .HasMaxLength(10)
                    .HasColumnName("Sim_Nacional_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.SimplesNacionalNota)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Simples_Nacional_Nota");

                entity.Property(e => e.SimplesNacionalRegime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Simples_Nacional_Regime")
                    .IsFixedLength();

                entity.Property(e => e.SituacaoContribuinteEmpresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Situacao_Contribuinte_Empresa")
                    .IsFixedLength();

                entity.Property(e => e.SituacaoNota)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Situacao_Nota")
                    .IsFixedLength();

                entity.Property(e => e.SofreReducaoServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sofre_Reducao_Servico")
                    .IsFixedLength();

                entity.Property(e => e.Stdescricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDESCRICAO");

                entity.Property(e => e.Stobrigaretencaofora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STOBRIGARETENCAOFORA")
                    .IsFixedLength();

                entity.Property(e => e.Stservforamuni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STSERVFORAMUNI")
                    .IsFixedLength();

                entity.Property(e => e.TipoAliquotaRegime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Aliquota_Regime")
                    .IsFixedLength();

                entity.Property(e => e.TotalIssNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Total_ISS_Nota");

                entity.Property(e => e.TotalLiquidoNota)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("Total_Liquido_Nota");

                entity.Property(e => e.UfCidadePrestacaoServico)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Cidade_Prestacao_Servico")
                    .IsFixedLength();

                entity.Property(e => e.UfPrestador)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Prestador")
                    .IsFixedLength();

                entity.Property(e => e.UfTomador)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF_Tomador")
                    .IsFixedLength();

                entity.Property(e => e.VetadoServico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Vetado_Servico")
                    .IsFixedLength();

                entity.Property(e => e.Vlissretido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLISSRETIDO");
            });

            modelBuilder.Entity<RpsTblLogerro>(entity =>
            {
                entity.HasKey(e => e.Idlogerros);

                entity.ToTable("RPS_TBL_LOGERROS");

                entity.HasIndex(e => e.RpsNumerps, "IX_RPS_TBL_LOGERROS_RPS_NUMERPS");

                entity.HasIndex(e => e.RpsNumeprot, "IX_RPS_TBL_NUMEPROT_inc_IDLOGERRO_NUMRPS_DATAHORA_MSGERRO_STCODERR");

                entity.Property(e => e.Idlogerros).HasColumnName("IDLOGERROS");

                entity.Property(e => e.Dtdatahora)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATAHORA");

                entity.Property(e => e.RpsNumeprot).HasColumnName("RPS_NUMEPROT");

                entity.Property(e => e.RpsNumerps)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RPS_NUMERPS");

                entity.Property(e => e.Stcodigoerro)
                    .HasMaxLength(4)
                    .HasColumnName("STCODIGOERRO")
                    .IsFixedLength();

                entity.Property(e => e.Stmsgerro)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("STMSGERRO");
            });

            modelBuilder.Entity<RpsTblRp>(entity =>
            {
                entity.HasKey(e => e.RpsIdloterps)
                    .HasName("RPS_IDLOTERPS");

                entity.ToTable("RPS_TBL_RPS");

                entity.HasIndex(e => e.RpsCnpjprestador, "IDX_CNPJ");

                entity.HasIndex(e => e.RpsDataenvio, "IDX_DATAENVIO");

                entity.HasIndex(e => new { e.RpsIdloterps, e.RpsNumerolote, e.RpsCnpjprestador }, "IDX_GETLOTE");

                entity.HasIndex(e => e.RpsIm, "IDX_IM");

                entity.HasIndex(e => new { e.RpsNumerolote, e.RpsCnpjprestador, e.RpsIm }, "IDX_LOTE_CNPJ_IM");

                entity.HasIndex(e => e.RpsNumeprot, "IDX_NUMEPROT");

                entity.HasIndex(e => e.RpsNumerolote, "IDX_RPS_NUMEROLOTE");

                entity.HasIndex(e => new { e.RpsIm, e.RpsCnpjprestador, e.RpsIdloterps, e.RpsNumeprot }, "IX_NFSE_TBL_RPS_IM_CNPJPRE_IDLOTERPS_NUMEPROT_inc_SITLOTE");

                entity.HasIndex(e => new { e.RpsDataenvio, e.RpsSituacaoLote, e.RpsIdloterps }, "IX_RPS_TBL_RPS_DATAENVIO_SITLOTE_IDLOTERPS");

                entity.HasIndex(e => new { e.RpsIm, e.RpsCnpjprestador, e.RpsIdloterps }, "IX_RPS_TBL_RPS_IM_CNPJPRE_IDLOTERPS_inc_NUMLOTE");

                entity.HasIndex(e => new { e.RpsNumerolote, e.RpsCnpjprestador, e.RpsIm, e.RpsIdloterps, e.RpsNumeprot }, "IX_RPS_TBL_RPS_NUMLOTE_CNPJPRE_IM_IDLOTERPS_NUMPROT_inc_SITLOTE");

                entity.HasIndex(e => new { e.RpsNumerolote, e.RpsCnpjprestador, e.RpsIm, e.RpsSituacaoLote, e.RpsIdloterps }, "IX_RPS_TBL_RPS_NUMLOTE_CNPJPRE_IM_SITLOTE_IDLOTERPS");

                entity.HasIndex(e => new { e.RpsCnpjprestador, e.RpsIdloterps }, "IX_RPS_TBL_RPS_RPS_CNPJPRESTADOR_RPS_IDLOTERPS");

                entity.HasIndex(e => e.RpsCnpjprestador, "IX_RPS_TBL_RPS_RPS_CNPJPRE_IDLOTERPS_NUMEPROT_DTENVIO_DTPROC_NUMLOTE_IM_QTDERPS_SITLOTE");

                entity.HasIndex(e => e.RpsDataprocessamento, "IX_RPS_TBL_RPS_RPS_DATAPROCESSAMENTO_inc");

                entity.HasIndex(e => new { e.RpsNumeprot, e.RpsCnpjprestador, e.RpsIm, e.RpsIdloterps }, "IX_RPS_TBL_RPS_RPS_NUMEPROT_RPS_CNPJPRESTADOR_RPS_IM_RPS_IDLOTERPS");

                entity.HasIndex(e => e.RpsSituacaoLote, "IX_RPS_TBL_RPS_RPS_SITUACAO_LOTE_INC_RPS_IDLOTERPS");

                entity.HasIndex(e => new { e.RpsSituacaoLote, e.RpsIdloterps, e.RpsDataenvio }, "_dta_index_RPS_TBL_RPS_28_806293932__K10_K1_K3_2_6_8_9");

                entity.HasIndex(e => new { e.RpsIm, e.RpsCnpjprestador, e.RpsSituacaoLote, e.RpsIdloterps }, "_dta_index_RPS_TBL_RPS_28_806293932__K7_K6_K10_K1_2_3_4_5_8_9_11");

                entity.Property(e => e.RpsIdloterps)
                    .ValueGeneratedNever()
                    .HasColumnName("RPS_IDLOTERPS");

                entity.Property(e => e.RpsCnpjprestador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RPS_CNPJPRESTADOR")
                    .IsFixedLength();

                entity.Property(e => e.RpsDataenvio)
                    .HasColumnType("datetime")
                    .HasColumnName("RPS_DATAENVIO");

                entity.Property(e => e.RpsDataprocessamento)
                    .HasColumnType("datetime")
                    .HasColumnName("RPS_DATAPROCESSAMENTO");

                entity.Property(e => e.RpsIm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RPS_IM")
                    .IsFixedLength();

                entity.Property(e => e.RpsLoterps).HasColumnName("RPS_LOTERPS");

                entity.Property(e => e.RpsNumeprot).HasColumnName("RPS_NUMEPROT");

                entity.Property(e => e.RpsNumerolote).HasColumnName("RPS_NUMEROLOTE");

                entity.Property(e => e.RpsProtocoloantigo).HasColumnName("RPS_PROTOCOLOANTIGO");

                entity.Property(e => e.RpsQtderps).HasColumnName("RPS_QTDERPS");

                entity.Property(e => e.RpsSituacaoLote).HasColumnName("RPS_SITUACAO_LOTE");
            });

            modelBuilder.Entity<RpsTblRpsmsgerro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPS_TBL_RPSMSGERRO");

                entity.HasIndex(e => e.RpsIdloterps, "IX_RPS_TBL_RPSMSGERRO_RPS_IDLOTERPS")
                    .IsClustered();

                entity.Property(e => e.Nucodigoerro)
                    .HasMaxLength(5)
                    .HasColumnName("NUCODIGOERRO")
                    .IsFixedLength();

                entity.Property(e => e.Nunumerorps).HasColumnName("NUNUMERORPS");

                entity.Property(e => e.RpsIdloterps).HasColumnName("RPS_IDLOTERPS");
            });

            modelBuilder.Entity<SysAutoIncrement>(entity =>
            {
                entity.HasKey(e => e.SysTableName);

                entity.ToTable("sysAutoIncrement");

                entity.HasIndex(e => e.SysTableName, "IDX_NOMETABELA");

                entity.Property(e => e.SysTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sysTableName");

                entity.Property(e => e.SysTableKeyValue).HasColumnName("sysTableKeyValue");
            });

            modelBuilder.Entity<SystTblControle>(entity =>
            {
                entity.HasKey(e => e.Sttabela);

                entity.ToTable("SYST_TBL_CONTROLE");

                entity.HasIndex(e => e.Sttabela, "IX_SYST_TBL_CONTROLE");

                entity.Property(e => e.Sttabela)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STTABELA");

                entity.Property(e => e.Nucodigo).HasColumnName("NUCODIGO");
            });

            modelBuilder.Entity<TabMe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabMes");

                entity.Property(e => e.IdMes).HasColumnName("idMes");

                entity.Property(e => e.NmMes)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nmMes");
            });

            modelBuilder.Entity<TmpCnpjCandidato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_CNPJ_candidatos");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");
            });

            modelBuilder.Entity<TmpEncerramentoConferencium>(entity =>
            {
                entity.HasKey(e => e.Nunumero);

                entity.ToTable("tmp_Encerramento_Conferencia");

                entity.Property(e => e.Nunumero)
                    .ValueGeneratedNever()
                    .HasColumnName("NUNUMERO");

                entity.Property(e => e.Aliquota).HasColumnType("money");

                entity.Property(e => e.CidadePrestacaoServico).IsUnicode(false);

                entity.Property(e => e.CidadeTomador).IsUnicode(false);

                entity.Property(e => e.Cmctomador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CMCTomador");

                entity.Property(e => e.Cpfcnpjcontribuinte)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CPFCNPJContribuinte");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.IssRetido)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NomeContribuinte).IsUnicode(false);

                entity.Property(e => e.RegimeNota)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegimePrestador)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("money")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vlissretido)
                    .HasColumnType("money")
                    .HasColumnName("VLISSRETIDO");

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("money")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotaliss)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTALISS");

                entity.Property(e => e.Vltotalliquido)
                    .HasColumnType("money")
                    .HasColumnName("VLTOTALLIQUIDO");
            });

            modelBuilder.Entity<TmpNfseTblEmpresaPerfil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_NFSE_TBL_EMPRESA_PERFIL");

                entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");

                entity.Property(e => e.Idperfil).HasColumnName("IDPERFIL");

                entity.Property(e => e.Imlogo).HasColumnName("IMLOGO");

                entity.Property(e => e.StautorizaContadorRps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAUTORIZA_CONTADOR_RPS")
                    .IsFixedLength();

                entity.Property(e => e.StcontatoEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_EMAIL");

                entity.Property(e => e.StcontatoNome)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_NOME");

                entity.Property(e => e.StcontatoTelefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STCONTATO_TELEFONE");

                entity.Property(e => e.Stemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STEMAIL");

                entity.Property(e => e.Stfraseseguranca)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STFRASESEGURANCA");

                entity.Property(e => e.Stincentivadorcultural)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STINCENTIVADORCULTURAL")
                    .IsFixedLength();

                entity.Property(e => e.Stnomefantasia)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STNOMEFANTASIA");

                entity.Property(e => e.Stobservacoes)
                    .IsUnicode(false)
                    .HasColumnName("STOBSERVACOES");

                entity.Property(e => e.Strazaosocial)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STRAZAOSOCIAL");

                entity.Property(e => e.Stresume)
                    .HasColumnType("text")
                    .HasColumnName("STRESUME");

                entity.Property(e => e.Stsite)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("STSITE");

                entity.Property(e => e.Sttipoempresa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STTIPOEMPRESA")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewCavalodetroium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CAVALODETROIA");

                entity.Property(e => e.CidadePrestação)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade Prestação");

                entity.Property(e => e.CidadeTomador)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade Tomador");

                entity.Property(e => e.Dtdata)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDATA");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Idservico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDSERVICO")
                    .IsFixedLength();

                entity.Property(e => e.Nunumero).HasColumnName("NUNUMERO");

                entity.Property(e => e.Pcaliquota)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("PCALIQUOTA");

                entity.Property(e => e.RegimeNota)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Regime Nota");

                entity.Property(e => e.RegimePrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Regime Prestador");

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.Stissretido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STISSRETIDO")
                    .IsFixedLength();

                entity.Property(e => e.Stnome)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("STNOME");

                entity.Property(e => e.SttomIm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STTOM_IM")
                    .IsFixedLength();

                entity.Property(e => e.Tributo).HasColumnName("tributo");

                entity.Property(e => e.ValorDivida).HasColumnType("money");

                entity.Property(e => e.Vencimento).HasColumnType("datetime");

                entity.Property(e => e.Vlbasecalculo)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLBASECALCULO");

                entity.Property(e => e.Vlissretido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLISSRETIDO");

                entity.Property(e => e.Vlservicos)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLSERVICOS");

                entity.Property(e => e.Vltotaliss)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALISS");

                entity.Property(e => e.Vltotalliquido)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("VLTOTALLIQUIDO");
            });

            modelBuilder.Entity<ViewDividasGeradasVencimentoErrado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DividasGeradasVencimentoErrado");

                entity.Property(e => e.Cmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC");

                entity.Property(e => e.CodDecl).HasColumnName("Cod_Decl");

                entity.Property(e => e.CodDivida).HasColumnName("Cod_Divida");

                entity.Property(e => e.CompAno).HasColumnName("Comp_Ano");

                entity.Property(e => e.ComptMes).HasColumnName("Compt_Mes");

                entity.Property(e => e.Contribuinte)
                    .HasMaxLength(97)
                    .IsUnicode(false)
                    .HasColumnName("CONTRIBUINTE");

                entity.Property(e => e.DtBaixa)
                    .HasColumnType("date")
                    .HasColumnName("Dt_Baixa");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Lancamento");

                entity.Property(e => e.DtVencNfse)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Venc_NFSE");

                entity.Property(e => e.DtVencTribuno)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Venc_Tribuno");

                entity.Property(e => e.TpRecolhimento)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Tp_Recolhimento");

                entity.Property(e => e.VlDivida)
                    .HasColumnType("money")
                    .HasColumnName("Vl_Divida");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("Vl_Pago");
            });

            modelBuilder.Entity<ViewNfseIssRetidoLctoTributo9>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_NFSE_ISS_Retido_Lcto_Tributo_9");

                entity.Property(e => e.Aliquota).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.CidadePrestacaoServico)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Prestacao_Servico");

                entity.Property(e => e.CidadeTomador)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Cidade_Tomador");

                entity.Property(e => e.CmcPrestador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Prestador");

                entity.Property(e => e.CmcTomador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Tomador")
                    .IsFixedLength();

                entity.Property(e => e.CnpjPrestador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Prestador");

                entity.Property(e => e.CnpjTomador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Tomador");

                entity.Property(e => e.CodServico)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Servico")
                    .IsFixedLength();

                entity.Property(e => e.IssRetido)
                    .HasColumnType("money")
                    .HasColumnName("ISS_retido");

                entity.Property(e => e.NfseCompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("NFSe_Competencia");

                entity.Property(e => e.NfseData)
                    .HasColumnType("datetime")
                    .HasColumnName("NFSe_Data");

                entity.Property(e => e.NrEncerramento).HasColumnName("NR_Encerramento");

                entity.Property(e => e.NrNfse).HasColumnName("NR_NFSe");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RegimeTributacaoPrestador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Regime_Tributacao_Prestador");

                entity.Property(e => e.TipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_baixa");

                entity.Property(e => e.TotalIss)
                    .HasColumnType("money")
                    .HasColumnName("Total_ISS");

                entity.Property(e => e.Tributo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBaseCalc)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Base_Calc");

                entity.Property(e => e.ValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Divida");

                entity.Property(e => e.ValorNota)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Nota");
            });

            modelBuilder.Entity<ViewNotasFiscaisDivergenciaValorIssLancado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Notas_Fiscais_Divergencia_Valor_ISS_Lancado");

                entity.Property(e => e.AliquotaCorreta)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("Aliquota_correta");

                entity.Property(e => e.AliquotaInformada)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("Aliquota_informada");

                entity.Property(e => e.BaseCalculo)
                    .HasColumnType("money")
                    .HasColumnName("Base_Calculo");

                entity.Property(e => e.BaseCalculoRecalculado)
                    .HasColumnType("money")
                    .HasColumnName("Base_Calculo_Recalculado");

                entity.Property(e => e.CmcPrestador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Prestador");

                entity.Property(e => e.CmcTomador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Tomador")
                    .IsFixedLength();

                entity.Property(e => e.CnpjPrestador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Prestador");

                entity.Property(e => e.CpfCnpjTomador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Tomador");

                entity.Property(e => e.DataBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Baixa");

                entity.Property(e => e.DtEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_Emissao");

                entity.Property(e => e.Iddivida).HasColumnName("IDDIVIDA");

                entity.Property(e => e.Issqn)
                    .HasColumnType("money")
                    .HasColumnName("ISSQN");

                entity.Property(e => e.IssqnRecalculado)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("ISSQN_recalculado");

                entity.Property(e => e.NrNfse).HasColumnName("Nr_NFSE");

                entity.Property(e => e.RazaoSocialPrestador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("RazaoSocial_Prestador");

                entity.Property(e => e.RazaoSocialTomador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social_Tomador");

                entity.Property(e => e.SituacaoDivida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Situacao_divida");

                entity.Property(e => e.ValorServicos)
                    .HasColumnType("money")
                    .HasColumnName("Valor_Servicos");
            });

            modelBuilder.Entity<ViewNotasFiscaisDivergenciaValorSemLcto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Notas_Fiscais_Divergencia_Valor_Sem_Lcto");

                entity.Property(e => e.AliquotaCorreta)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("Aliquota_correta");

                entity.Property(e => e.AliquotaInformada)
                    .HasColumnType("numeric(4, 2)")
                    .HasColumnName("Aliquota_informada");

                entity.Property(e => e.BaseCalculo)
                    .HasColumnType("money")
                    .HasColumnName("Base_Calculo");

                entity.Property(e => e.BaseCalculoRecalculado)
                    .HasColumnType("money")
                    .HasColumnName("Base_Calculo_Recalculado");

                entity.Property(e => e.CmcPrestador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Prestador");

                entity.Property(e => e.CmcTom)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMC_Tom")
                    .IsFixedLength();

                entity.Property(e => e.CnpjPrestador)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Prestador");

                entity.Property(e => e.CpfCnpjTom)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF_CNPJ_Tom");

                entity.Property(e => e.DtEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("Dt_emissao");

                entity.Property(e => e.Issqn)
                    .HasColumnType("money")
                    .HasColumnName("ISSQN");

                entity.Property(e => e.IssqnRecalculado)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("ISSQN_recalculado");

                entity.Property(e => e.NrNfse).HasColumnName("Nr_NFSE");

                entity.Property(e => e.RazaoSocialPrestador)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social_Prestador");

                entity.Property(e => e.RazaoSocialTom)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Razao_Social_Tom");

                entity.Property(e => e.ValorServicos)
                    .HasColumnType("money")
                    .HasColumnName("Valor_servicos");
            });

            modelBuilder.Entity<VwDimAtividadeIssMenor5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_dim_atividade_iss_menor5");

                entity.Property(e => e.Cnae)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CNAE");

                entity.Property(e => e.GrupoDeServiço)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO DE SERVIÇO");
            });

            modelBuilder.Entity<VwDimEmpresaIssAliquotamenor5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_dim_empresa_iss_aliquotamenor5");

                entity.Property(e => e.Cme)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CME");

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF/CNPJ");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<VwDimEmpresaSimplesNacionalNfse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DIM_EMPRESA_SIMPLES_NACIONAL_NFSE");

                entity.Property(e => e.Cme)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CME");

                entity.Property(e => e.CpfCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF/CNPJ");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOME");
            });

            modelBuilder.Entity<VwFatoArrecadacaoIssMenor5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_fato_arrecadacao_iss_menor5");

                entity.Property(e => e.Aliquota)
                    .HasColumnType("numeric(14, 5)")
                    .HasColumnName("ALIQUOTA");

                entity.Property(e => e.Cnae)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CNAE");

                entity.Property(e => e.DataDaCompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA DA COMPETENCIA");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.Serviço)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SERVIÇO")
                    .IsFixedLength();

                entity.Property(e => e.ValorIssTotal)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("VALOR ISS TOTAL");
            });

            modelBuilder.Entity<VwFatoSimplesNacionalNfse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_FATO_SIMPLES_NACIONAL_NFSE");

                entity.Property(e => e.DataDaCompetencia)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA DA COMPETENCIA");

                entity.Property(e => e.Empresa).HasColumnName("EMPRESA");

                entity.Property(e => e.ValorIssTotal)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("VALOR ISS TOTAL");
            });

            modelBuilder.Entity<VwMegaDataContribuinte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMegaDataContribuintes");

                entity.Property(e => e.Cnaes)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("CNAES");

                entity.Property(e => e.CnpjContribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ_Contribuinte");

                entity.Property(e => e.CodigoTom)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Dtexportacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DTEXPORTACAO")
                    .IsFixedLength();

                entity.Property(e => e.EmailContribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Fim)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Inicio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vlrestimado)
                    .HasColumnType("money")
                    .HasColumnName("VLRESTIMADO");
            });

            modelBuilder.Entity<VwMegaDataNotasFiscai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMegaDataNotasFISCAIS");

                entity.Property(e => e.Aliquota)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("ALIQUOTA");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Basecalculo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("BASECALCULO");

                entity.Property(e => e.Cdverificacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CDVERIFICACAO");

                entity.Property(e => e.Cmeprestador)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMEPRESTADOR");

                entity.Property(e => e.Cpfcnpjtomador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CPFCNPJTOMADOR");

                entity.Property(e => e.Deducoes)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("DEDUCOES");

                entity.Property(e => e.Exigibilidade).HasColumnName("EXIGIBILIDADE");

                entity.Property(e => e.Issretido).HasColumnName("ISSRETIDO");

                entity.Property(e => e.Localtributacao).HasColumnName("LOCALTRIBUTACAO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Nometomador)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("NOMETOMADOR");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Servico116)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERVICO116");

                entity.Property(e => e.Situacao).HasColumnName("SITUACAO");

                entity.Property(e => e.Stcpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("STCPFCNPJ");

                entity.Property(e => e.Tom).HasColumnName("TOM");

                entity.Property(e => e.Vlriss)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("VLRISS");

                entity.Property(e => e.Vlrissretido)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("VLRISSRETIDO");

                entity.Property(e => e.Vlrservico)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("VLRSERVICO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
