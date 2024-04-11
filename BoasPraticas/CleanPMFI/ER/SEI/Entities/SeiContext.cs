using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SEI.Entities;

public partial class SeiContext : DbContext
{
    public SeiContext()
    {
    }

    public SeiContext(DbContextOptions<SeiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcaoFederacao> AcaoFederacaos { get; set; }

    public virtual DbSet<Acesso> Acessos { get; set; }

    public virtual DbSet<AcessoExterno> AcessoExternos { get; set; }

    public virtual DbSet<AcessoFederacao> AcessoFederacaos { get; set; }

    public virtual DbSet<Acompanhamento> Acompanhamentos { get; set; }

    public virtual DbSet<AndamentoInstalacao> AndamentoInstalacaos { get; set; }

    public virtual DbSet<AndamentoMarcador> AndamentoMarcadors { get; set; }

    public virtual DbSet<AndamentoPlanoTrabalho> AndamentoPlanoTrabalhos { get; set; }

    public virtual DbSet<AndamentoSituacao> AndamentoSituacaos { get; set; }

    public virtual DbSet<Anexo> Anexos { get; set; }

    public virtual DbSet<Anotacao> Anotacaos { get; set; }

    public virtual DbSet<Arquivamento> Arquivamentos { get; set; }

    public virtual DbSet<ArquivoExtensao> ArquivoExtensaos { get; set; }

    public virtual DbSet<Assinante> Assinantes { get; set; }

    public virtual DbSet<Assinatura> Assinaturas { get; set; }

    public virtual DbSet<Assunto> Assuntos { get; set; }

    public virtual DbSet<AssuntoProxy> AssuntoProxies { get; set; }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Atributo> Atributos { get; set; }

    public virtual DbSet<AtributoAndamPlanoTrab> AtributoAndamPlanoTrabs { get; set; }

    public virtual DbSet<AtributoAndamento> AtributoAndamentos { get; set; }

    public virtual DbSet<AtributoInstalacao> AtributoInstalacaos { get; set; }

    public virtual DbSet<AuditoriaProtocolo> AuditoriaProtocolos { get; set; }

    public virtual DbSet<AvaliacaoDocumental> AvaliacaoDocumentals { get; set; }

    public virtual DbSet<Aviso> Avisos { get; set; }

    public virtual DbSet<BaseConhecimento> BaseConhecimentos { get; set; }

    public virtual DbSet<Bloco> Blocos { get; set; }

    public virtual DbSet<CampoPesquisa> CampoPesquisas { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CargoFuncao> CargoFuncaos { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cidade> Cidades { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<ConjuntoEstilo> ConjuntoEstilos { get; set; }

    public virtual DbSet<ConjuntoEstilosItem> ConjuntoEstilosItems { get; set; }

    public virtual DbSet<Contato> Contatos { get; set; }

    public virtual DbSet<ControleInterno> ControleInternos { get; set; }

    public virtual DbSet<ControlePrazo> ControlePrazos { get; set; }

    public virtual DbSet<ControleUnidade> ControleUnidades { get; set; }

    public virtual DbSet<Cpad> Cpads { get; set; }

    public virtual DbSet<CpadAvaliacao> CpadAvaliacaos { get; set; }

    public virtual DbSet<CpadComposicao> CpadComposicaos { get; set; }

    public virtual DbSet<CpadVersao> CpadVersaos { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<DocumentoConteudo> DocumentoConteudos { get; set; }

    public virtual DbSet<DocumentoGeracao> DocumentoGeracaos { get; set; }

    public virtual DbSet<Dominio> Dominios { get; set; }

    public virtual DbSet<EditalEliminacao> EditalEliminacaos { get; set; }

    public virtual DbSet<EditalEliminacaoConteudo> EditalEliminacaoConteudos { get; set; }

    public virtual DbSet<EditalEliminacaoErro> EditalEliminacaoErros { get; set; }

    public virtual DbSet<EmailGrupoEmail> EmailGrupoEmails { get; set; }

    public virtual DbSet<EmailSistema> EmailSistemas { get; set; }

    public virtual DbSet<EmailUnidade> EmailUnidades { get; set; }

    public virtual DbSet<EmailUtilizado> EmailUtilizados { get; set; }

    public virtual DbSet<Estatistica> Estatisticas { get; set; }

    public virtual DbSet<Estilo> Estilos { get; set; }

    public virtual DbSet<EtapaTrabalho> EtapaTrabalhos { get; set; }

    public virtual DbSet<Feed> Feeds { get; set; }

    public virtual DbSet<Feriado> Feriados { get; set; }

    public virtual DbSet<GrupoAcompanhamento> GrupoAcompanhamentos { get; set; }

    public virtual DbSet<GrupoBloco> GrupoBlocos { get; set; }

    public virtual DbSet<GrupoContato> GrupoContatos { get; set; }

    public virtual DbSet<GrupoEmail> GrupoEmails { get; set; }

    public virtual DbSet<GrupoFederacao> GrupoFederacaos { get; set; }

    public virtual DbSet<GrupoProtocoloModelo> GrupoProtocoloModelos { get; set; }

    public virtual DbSet<GrupoSerie> GrupoSeries { get; set; }

    public virtual DbSet<GrupoUnidade> GrupoUnidades { get; set; }

    public virtual DbSet<HipoteseLegal> HipoteseLegals { get; set; }

    public virtual DbSet<ImagemFormato> ImagemFormatos { get; set; }

    public virtual DbSet<InfraAgendamentoTarefa> InfraAgendamentoTarefas { get; set; }

    public virtual DbSet<InfraAuditorium> InfraAuditoria { get; set; }

    public virtual DbSet<InfraCaptcha> InfraCaptchas { get; set; }

    public virtual DbSet<InfraCaptchaTentativa> InfraCaptchaTentativas { get; set; }

    public virtual DbSet<InfraDadoUsuario> InfraDadoUsuarios { get; set; }

    public virtual DbSet<InfraErroPhp> InfraErroPhps { get; set; }

    public virtual DbSet<InfraLog> InfraLogs { get; set; }

    public virtual DbSet<InfraNavegador> InfraNavegadors { get; set; }

    public virtual DbSet<InfraParametro> InfraParametros { get; set; }

    public virtual DbSet<InfraRegraAuditoriaRecurso> InfraRegraAuditoriaRecursos { get; set; }

    public virtual DbSet<InfraRegraAuditorium> InfraRegraAuditoria { get; set; }

    public virtual DbSet<InfraSequencium> InfraSequencia { get; set; }

    public virtual DbSet<InstalacaoFederacao> InstalacaoFederacaos { get; set; }

    public virtual DbSet<ItemEtapa> ItemEtapas { get; set; }

    public virtual DbSet<Lembrete> Lembretes { get; set; }

    public virtual DbSet<Localizador> Localizadors { get; set; }

    public virtual DbSet<LugarLocalizador> LugarLocalizadors { get; set; }

    public virtual DbSet<Marcador> Marcadors { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<MonitoramentoServico> MonitoramentoServicos { get; set; }

    public virtual DbSet<NivelAcessoPermitido> NivelAcessoPermitidos { get; set; }

    public virtual DbSet<Notificacao> Notificacaos { get; set; }

    public virtual DbSet<Novidade> Novidades { get; set; }

    public virtual DbSet<Numeracao> Numeracaos { get; set; }

    public virtual DbSet<Observacao> Observacaos { get; set; }

    public virtual DbSet<OperacaoServico> OperacaoServicos { get; set; }

    public virtual DbSet<OrdenadorDespesa> OrdenadorDespesas { get; set; }

    public virtual DbSet<Orgao> Orgaos { get; set; }

    public virtual DbSet<OrgaoFederacao> OrgaoFederacaos { get; set; }

    public virtual DbSet<OrgaoHistorico> OrgaoHistoricos { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<ParametroAcaoFederacao> ParametroAcaoFederacaos { get; set; }

    public virtual DbSet<Participante> Participantes { get; set; }

    public virtual DbSet<Pesquisa> Pesquisas { get; set; }

    public virtual DbSet<PlanoTrabalho> PlanoTrabalhos { get; set; }

    public virtual DbSet<Procedimento> Procedimentos { get; set; }

    public virtual DbSet<Protocolo> Protocolos { get; set; }

    public virtual DbSet<ProtocoloFederacao> ProtocoloFederacaos { get; set; }

    public virtual DbSet<ProtocoloModelo> ProtocoloModelos { get; set; }

    public virtual DbSet<Publicacao> Publicacaos { get; set; }

    public virtual DbSet<PublicacaoLegado> PublicacaoLegados { get; set; }

    public virtual DbSet<ReaberturaProgramadum> ReaberturaProgramada { get; set; }

    public virtual DbSet<RelBlocoProtocolo> RelBlocoProtocolos { get; set; }

    public virtual DbSet<RelBlocoUnidade> RelBlocoUnidades { get; set; }

    public virtual DbSet<RelNotificacaoDocumento> RelNotificacaoDocumentos { get; set; }

    public virtual DbSet<RelProtocoloAssunto> RelProtocoloAssuntos { get; set; }

    public virtual DbSet<RelProtocoloAtributo> RelProtocoloAtributos { get; set; }

    public virtual DbSet<RelProtocoloProtocolo> RelProtocoloProtocolos { get; set; }

    public virtual DbSet<RelSecaoModCjEstilosItem> RelSecaoModCjEstilosItems { get; set; }

    public virtual DbSet<RelSecaoModeloEstilo> RelSecaoModeloEstilos { get; set; }

    public virtual DbSet<RelSerieAssunto> RelSerieAssuntos { get; set; }

    public virtual DbSet<RelTipoProcedimentoAssunto> RelTipoProcedimentoAssuntos { get; set; }

    public virtual DbSet<RelUnidadeTipoContato> RelUnidadeTipoContatos { get; set; }

    public virtual DbSet<RelUsuarioTipoPrioridade> RelUsuarioTipoPrioridades { get; set; }

    public virtual DbSet<RelUsuarioTipoProced> RelUsuarioTipoProceds { get; set; }

    public virtual DbSet<RelUsuarioUsuarioUnidade> RelUsuarioUsuarioUnidades { get; set; }

    public virtual DbSet<ReplicacaoFederacao> ReplicacaoFederacaos { get; set; }

    public virtual DbSet<RetornoProgramado> RetornoProgramados { get; set; }

    public virtual DbSet<SecaoDocumento> SecaoDocumentos { get; set; }

    public virtual DbSet<SecaoImprensaNacional> SecaoImprensaNacionals { get; set; }

    public virtual DbSet<SecaoModelo> SecaoModelos { get; set; }

    public virtual DbSet<SeqAcesso> SeqAcessos { get; set; }

    public virtual DbSet<SeqAcessoExterno> SeqAcessoExternos { get; set; }

    public virtual DbSet<SeqAcompanhamento> SeqAcompanhamentos { get; set; }

    public virtual DbSet<SeqAndamentoInstalacao> SeqAndamentoInstalacaos { get; set; }

    public virtual DbSet<SeqAndamentoMarcador> SeqAndamentoMarcadors { get; set; }

    public virtual DbSet<SeqAndamentoPlanoTrabalho> SeqAndamentoPlanoTrabalhos { get; set; }

    public virtual DbSet<SeqAndamentoSituacao> SeqAndamentoSituacaos { get; set; }

    public virtual DbSet<SeqAnexo> SeqAnexos { get; set; }

    public virtual DbSet<SeqAnotacao> SeqAnotacaos { get; set; }

    public virtual DbSet<SeqArquivoExtensao> SeqArquivoExtensaos { get; set; }

    public virtual DbSet<SeqAssinante> SeqAssinantes { get; set; }

    public virtual DbSet<SeqAssinatura> SeqAssinaturas { get; set; }

    public virtual DbSet<SeqAssunto> SeqAssuntos { get; set; }

    public virtual DbSet<SeqAssuntoProxy> SeqAssuntoProxies { get; set; }

    public virtual DbSet<SeqAtividade> SeqAtividades { get; set; }

    public virtual DbSet<SeqAtributo> SeqAtributos { get; set; }

    public virtual DbSet<SeqAtributoAndamPlanoTrab> SeqAtributoAndamPlanoTrabs { get; set; }

    public virtual DbSet<SeqAtributoAndamento> SeqAtributoAndamentos { get; set; }

    public virtual DbSet<SeqAtributoAndamentoSituaca> SeqAtributoAndamentoSituacas { get; set; }

    public virtual DbSet<SeqAtributoInstalacao> SeqAtributoInstalacaos { get; set; }

    public virtual DbSet<SeqAuditoriaProtocolo> SeqAuditoriaProtocolos { get; set; }

    public virtual DbSet<SeqAvaliacaoDocumental> SeqAvaliacaoDocumentals { get; set; }

    public virtual DbSet<SeqAviso> SeqAvisos { get; set; }

    public virtual DbSet<SeqBaseConhecimento> SeqBaseConhecimentos { get; set; }

    public virtual DbSet<SeqBloco> SeqBlocos { get; set; }

    public virtual DbSet<SeqCampoPesquisa> SeqCampoPesquisas { get; set; }

    public virtual DbSet<SeqCargo> SeqCargos { get; set; }

    public virtual DbSet<SeqCategorium> SeqCategoria { get; set; }

    public virtual DbSet<SeqCidade> SeqCidades { get; set; }

    public virtual DbSet<SeqComentario> SeqComentarios { get; set; }

    public virtual DbSet<SeqConjuntoEstilo> SeqConjuntoEstilos { get; set; }

    public virtual DbSet<SeqConjuntoEstilosItem> SeqConjuntoEstilosItems { get; set; }

    public virtual DbSet<SeqContato> SeqContatos { get; set; }

    public virtual DbSet<SeqControleInterno> SeqControleInternos { get; set; }

    public virtual DbSet<SeqControlePrazo> SeqControlePrazos { get; set; }

    public virtual DbSet<SeqControleUnidade> SeqControleUnidades { get; set; }

    public virtual DbSet<SeqCpad> SeqCpads { get; set; }

    public virtual DbSet<SeqCpadAvaliacao> SeqCpadAvaliacaos { get; set; }

    public virtual DbSet<SeqCpadComposicao> SeqCpadComposicaos { get; set; }

    public virtual DbSet<SeqCpadVersao> SeqCpadVersaos { get; set; }

    public virtual DbSet<SeqDocumento> SeqDocumentos { get; set; }

    public virtual DbSet<SeqDominio> SeqDominios { get; set; }

    public virtual DbSet<SeqEditalEliminacao> SeqEditalEliminacaos { get; set; }

    public virtual DbSet<SeqEditalEliminacaoConteudo> SeqEditalEliminacaoConteudos { get; set; }

    public virtual DbSet<SeqEditalEliminacaoErro> SeqEditalEliminacaoErros { get; set; }

    public virtual DbSet<SeqEmailGrupoEmail> SeqEmailGrupoEmails { get; set; }

    public virtual DbSet<SeqEmailSistema> SeqEmailSistemas { get; set; }

    public virtual DbSet<SeqEmailUnidade> SeqEmailUnidades { get; set; }

    public virtual DbSet<SeqEmailUtilizado> SeqEmailUtilizados { get; set; }

    public virtual DbSet<SeqEstatistica> SeqEstatisticas { get; set; }

    public virtual DbSet<SeqEstilo> SeqEstilos { get; set; }

    public virtual DbSet<SeqEtapaTrabalho> SeqEtapaTrabalhos { get; set; }

    public virtual DbSet<SeqFeed> SeqFeeds { get; set; }

    public virtual DbSet<SeqFeriado> SeqFeriados { get; set; }

    public virtual DbSet<SeqGrupoAcompanhamento> SeqGrupoAcompanhamentos { get; set; }

    public virtual DbSet<SeqGrupoBloco> SeqGrupoBlocos { get; set; }

    public virtual DbSet<SeqGrupoContato> SeqGrupoContatos { get; set; }

    public virtual DbSet<SeqGrupoEmail> SeqGrupoEmails { get; set; }

    public virtual DbSet<SeqGrupoFederacao> SeqGrupoFederacaos { get; set; }

    public virtual DbSet<SeqGrupoProtocoloModelo> SeqGrupoProtocoloModelos { get; set; }

    public virtual DbSet<SeqGrupoSerie> SeqGrupoSeries { get; set; }

    public virtual DbSet<SeqGrupoUnidade> SeqGrupoUnidades { get; set; }

    public virtual DbSet<SeqHipoteseLegal> SeqHipoteseLegals { get; set; }

    public virtual DbSet<SeqImagemFormato> SeqImagemFormatos { get; set; }

    public virtual DbSet<SeqInfraAuditorium> SeqInfraAuditoria { get; set; }

    public virtual DbSet<SeqInfraLog> SeqInfraLogs { get; set; }

    public virtual DbSet<SeqInfraNavegador> SeqInfraNavegadors { get; set; }

    public virtual DbSet<SeqItemEtapa> SeqItemEtapas { get; set; }

    public virtual DbSet<SeqLembrete> SeqLembretes { get; set; }

    public virtual DbSet<SeqLocalizador> SeqLocalizadors { get; set; }

    public virtual DbSet<SeqLugarLocalizador> SeqLugarLocalizadors { get; set; }

    public virtual DbSet<SeqMarcador> SeqMarcadors { get; set; }

    public virtual DbSet<SeqModelo> SeqModelos { get; set; }

    public virtual DbSet<SeqMonitoramentoServico> SeqMonitoramentoServicos { get; set; }

    public virtual DbSet<SeqNivelAcessoPermitido> SeqNivelAcessoPermitidos { get; set; }

    public virtual DbSet<SeqNotificacao> SeqNotificacaos { get; set; }

    public virtual DbSet<SeqNovidade> SeqNovidades { get; set; }

    public virtual DbSet<SeqNumeracao> SeqNumeracaos { get; set; }

    public virtual DbSet<SeqObservacao> SeqObservacaos { get; set; }

    public virtual DbSet<SeqOperacaoServico> SeqOperacaoServicos { get; set; }

    public virtual DbSet<SeqOrdenadorDespesa> SeqOrdenadorDespesas { get; set; }

    public virtual DbSet<SeqOrgaoHistorico> SeqOrgaoHistoricos { get; set; }

    public virtual DbSet<SeqPai> SeqPais { get; set; }

    public virtual DbSet<SeqParticipante> SeqParticipantes { get; set; }

    public virtual DbSet<SeqPesquisa> SeqPesquisas { get; set; }

    public virtual DbSet<SeqPlanoTrabalho> SeqPlanoTrabalhos { get; set; }

    public virtual DbSet<SeqProtocolo> SeqProtocolos { get; set; }

    public virtual DbSet<SeqProtocoloModelo> SeqProtocoloModelos { get; set; }

    public virtual DbSet<SeqPublicacao> SeqPublicacaos { get; set; }

    public virtual DbSet<SeqReaberturaProgramadum> SeqReaberturaProgramada { get; set; }

    public virtual DbSet<SeqRelProtocoloProtocolo> SeqRelProtocoloProtocolos { get; set; }

    public virtual DbSet<SeqRelUnidadeTipoContato> SeqRelUnidadeTipoContatos { get; set; }

    public virtual DbSet<SeqRetornoProgramado> SeqRetornoProgramados { get; set; }

    public virtual DbSet<SeqSecaoDocumento> SeqSecaoDocumentos { get; set; }

    public virtual DbSet<SeqSecaoImprensaNacional> SeqSecaoImprensaNacionals { get; set; }

    public virtual DbSet<SeqSecaoModelo> SeqSecaoModelos { get; set; }

    public virtual DbSet<SeqSerie> SeqSeries { get; set; }

    public virtual DbSet<SeqSeriePublicacao> SeqSeriePublicacaos { get; set; }

    public virtual DbSet<SeqSerieRestricao> SeqSerieRestricaos { get; set; }

    public virtual DbSet<SeqServico> SeqServicos { get; set; }

    public virtual DbSet<SeqSituacao> SeqSituacaos { get; set; }

    public virtual DbSet<SeqTabelaAssunto> SeqTabelaAssuntos { get; set; }

    public virtual DbSet<SeqTarefa> SeqTarefas { get; set; }

    public virtual DbSet<SeqTarjaAssinatura> SeqTarjaAssinaturas { get; set; }

    public virtual DbSet<SeqTextoPadraoInterno> SeqTextoPadraoInternos { get; set; }

    public virtual DbSet<SeqTipoConferencium> SeqTipoConferencia { get; set; }

    public virtual DbSet<SeqTipoContato> SeqTipoContatos { get; set; }

    public virtual DbSet<SeqTipoFormulario> SeqTipoFormularios { get; set; }

    public virtual DbSet<SeqTipoLocalizador> SeqTipoLocalizadors { get; set; }

    public virtual DbSet<SeqTipoPrioridade> SeqTipoPrioridades { get; set; }

    public virtual DbSet<SeqTipoProcedRestricao> SeqTipoProcedRestricaos { get; set; }

    public virtual DbSet<SeqTipoProcedimento> SeqTipoProcedimentos { get; set; }

    public virtual DbSet<SeqTipoSuporte> SeqTipoSuportes { get; set; }

    public virtual DbSet<SeqTitulo> SeqTitulos { get; set; }

    public virtual DbSet<SeqTratamento> SeqTratamentos { get; set; }

    public virtual DbSet<SeqUf> SeqUfs { get; set; }

    public virtual DbSet<SeqUnidadeHistorico> SeqUnidadeHistoricos { get; set; }

    public virtual DbSet<SeqUnidadePublicacao> SeqUnidadePublicacaos { get; set; }

    public virtual DbSet<SeqUpload> SeqUploads { get; set; }

    public virtual DbSet<SeqVeiculoImprensaNacional> SeqVeiculoImprensaNacionals { get; set; }

    public virtual DbSet<SeqVeiculoPublicacao> SeqVeiculoPublicacaos { get; set; }

    public virtual DbSet<SeqVersaoSecaoDocumento> SeqVersaoSecaoDocumentos { get; set; }

    public virtual DbSet<SeqVocativo> SeqVocativos { get; set; }

    public virtual DbSet<Serie> Series { get; set; }

    public virtual DbSet<SeriePublicacao> SeriePublicacaos { get; set; }

    public virtual DbSet<SerieRestricao> SerieRestricaos { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    public virtual DbSet<SinalizacaoFederacao> SinalizacaoFederacaos { get; set; }

    public virtual DbSet<Situacao> Situacaos { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TabelaAssunto> TabelaAssuntos { get; set; }

    public virtual DbSet<Tarefa> Tarefas { get; set; }

    public virtual DbSet<TarefaInstalacao> TarefaInstalacaos { get; set; }

    public virtual DbSet<TarefaPlanoTrabalho> TarefaPlanoTrabalhos { get; set; }

    public virtual DbSet<TarjaAssinatura> TarjaAssinaturas { get; set; }

    public virtual DbSet<TextoPadraoInterno> TextoPadraoInternos { get; set; }

    public virtual DbSet<TipoConferencium> TipoConferencia { get; set; }

    public virtual DbSet<TipoContato> TipoContatos { get; set; }

    public virtual DbSet<TipoFormulario> TipoFormularios { get; set; }

    public virtual DbSet<TipoLocalizador> TipoLocalizadors { get; set; }

    public virtual DbSet<TipoPrioridade> TipoPrioridades { get; set; }

    public virtual DbSet<TipoProcedRestricao> TipoProcedRestricaos { get; set; }

    public virtual DbSet<TipoProcedimento> TipoProcedimentos { get; set; }

    public virtual DbSet<TipoSuporte> TipoSuportes { get; set; }

    public virtual DbSet<Titulo> Titulos { get; set; }

    public virtual DbSet<Tratamento> Tratamentos { get; set; }

    public virtual DbSet<Uf> Ufs { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<UnidadeFederacao> UnidadeFederacaos { get; set; }

    public virtual DbSet<UnidadeHistorico> UnidadeHistoricos { get; set; }

    public virtual DbSet<UnidadePublicacao> UnidadePublicacaos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioFederacao> UsuarioFederacaos { get; set; }

    public virtual DbSet<VeiculoImprensaNacional> VeiculoImprensaNacionals { get; set; }

    public virtual DbSet<VeiculoPublicacao> VeiculoPublicacaos { get; set; }

    public virtual DbSet<VersaoSecaoDocumento> VersaoSecaoDocumentos { get; set; }

    public virtual DbSet<Vocativo> Vocativos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=sei;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcaoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdAcaoFederacao).HasName("pk_acao_federacao");

            entity.ToTable("acao_federacao");

            entity.Property(e => e.IdAcaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_acao_federacao");
            entity.Property(e => e.DthAcesso)
                .HasColumnType("datetime")
                .HasColumnName("dth_acesso");
            entity.Property(e => e.DthGeracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_geracao");
            entity.Property(e => e.IdDocumentoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_documento_federacao");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.IdOrgaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_orgao_federacao");
            entity.Property(e => e.IdProcedimentoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_procedimento_federacao");
            entity.Property(e => e.IdUnidadeFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_unidade_federacao");
            entity.Property(e => e.IdUsuarioFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_usuario_federacao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo).HasColumnName("sta_tipo");
        });

        modelBuilder.Entity<Acesso>(entity =>
        {
            entity.HasKey(e => e.IdAcesso).HasName("pk_acesso");

            entity.ToTable("acesso");

            entity.HasIndex(e => e.IdControleInterno, "fk_acesso_controle_interno");

            entity.HasIndex(e => e.IdProtocolo, "fk_acesso_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_acesso_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_acesso_usuario");

            entity.HasIndex(e => new { e.IdUnidade, e.IdUsuario, e.IdProtocolo, e.StaTipo }, "i01_acesso");

            entity.HasIndex(e => new { e.IdProtocolo, e.StaTipo }, "i02_acesso");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdUnidade, e.IdUsuario }, "i03_acesso");

            entity.Property(e => e.IdAcesso)
                .ValueGeneratedNever()
                .HasColumnName("id_acesso");
            entity.Property(e => e.IdControleInterno).HasColumnName("id_controle_interno");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdControleInternoNavigation).WithMany(p => p.Acessos)
                .HasForeignKey(d => d.IdControleInterno)
                .HasConstraintName("fk_acesso_controle_interno");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Acessos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Acessos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Acessos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_acesso_usuario");
        });

        modelBuilder.Entity<AcessoExterno>(entity =>
        {
            entity.HasKey(e => e.IdAcessoExterno).HasName("pk_acesso_externo");

            entity.ToTable("acesso_externo");

            entity.HasIndex(e => e.IdAtividade, "fk_acesso_externo_atividade");

            entity.HasIndex(e => e.IdDocumento, "fk_acesso_externo_documento");

            entity.HasIndex(e => e.IdParticipante, "fk_acesso_externo_participante");

            entity.HasIndex(e => new { e.StaTipo, e.IdDocumento }, "i04_acesso_externo");

            entity.HasIndex(e => new { e.StaTipo, e.SinInclusao }, "i05_acesso_externo");

            entity.HasIndex(e => new { e.StaTipo, e.DtaValidade }, "i06_acesso_externo");

            entity.HasIndex(e => new { e.IdDocumento, e.StaTipo, e.DtaValidade }, "i07_acesso_externo");

            entity.Property(e => e.IdAcessoExterno)
                .ValueGeneratedNever()
                .HasColumnName("id_acesso_externo");
            entity.Property(e => e.DtaValidade)
                .HasColumnType("datetime")
                .HasColumnName("dta_validade");
            entity.Property(e => e.DthVisualizacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_visualizacao");
            entity.Property(e => e.EmailDestinatario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_destinatario");
            entity.Property(e => e.EmailUnidade)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email_unidade");
            entity.Property(e => e.HashInterno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("hash_interno");
            entity.Property(e => e.IdAtividade).HasColumnName("id_atividade");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdParticipante).HasColumnName("id_participante");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinInclusao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_inclusao");
            entity.Property(e => e.SinProcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_processo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdAtividadeNavigation).WithMany(p => p.AcessoExternos)
                .HasForeignKey(d => d.IdAtividade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_externo_atividade");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.AcessoExternos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("fk_acesso_externo_documento");

            entity.HasOne(d => d.IdParticipanteNavigation).WithMany(p => p.AcessoExternos)
                .HasForeignKey(d => d.IdParticipante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_externo_participante");

            entity.HasMany(d => d.IdProtocolos).WithMany(p => p.IdAcessoExternos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelAcessoExtProtocolo",
                    r => r.HasOne<Protocolo>().WithMany()
                        .HasForeignKey("IdProtocolo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aces_ext_prot_protocolo"),
                    l => l.HasOne<AcessoExterno>().WithMany()
                        .HasForeignKey("IdAcessoExterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aces_ext_prot_aces_ext"),
                    j =>
                    {
                        j.HasKey("IdAcessoExterno", "IdProtocolo").HasName("pk_rel_acesso_ext_protocolo");
                        j.ToTable("rel_acesso_ext_protocolo");
                        j.HasIndex(new[] { "IdAcessoExterno" }, "fk_rel_aces_ext_prot_aces_ext");
                        j.HasIndex(new[] { "IdProtocolo" }, "fk_rel_aces_ext_prot_protocolo");
                        j.IndexerProperty<int>("IdAcessoExterno").HasColumnName("id_acesso_externo");
                        j.IndexerProperty<long>("IdProtocolo").HasColumnName("id_protocolo");
                    });

            entity.HasMany(d => d.IdSeries).WithMany(p => p.IdAcessoExternos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelAcessoExtSerie",
                    r => r.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aces_ext_serie_serie"),
                    l => l.HasOne<AcessoExterno>().WithMany()
                        .HasForeignKey("IdAcessoExterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aces_ext_serie_aces_ext"),
                    j =>
                    {
                        j.HasKey("IdAcessoExterno", "IdSerie").HasName("pk_rel_acesso_ext_serie");
                        j.ToTable("rel_acesso_ext_serie");
                        j.HasIndex(new[] { "IdAcessoExterno" }, "fk_rel_aces_ext_serie_aces_ext");
                        j.HasIndex(new[] { "IdSerie" }, "fk_rel_aces_ext_serie_serie");
                        j.IndexerProperty<int>("IdAcessoExterno").HasColumnName("id_acesso_externo");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                    });
        });

        modelBuilder.Entity<AcessoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdAcessoFederacao).HasName("pk_acesso_federacao");

            entity.ToTable("acesso_federacao");

            entity.HasIndex(e => e.IdDocumentoFederacao, "fk_acesso_fed_documento_fed");

            entity.HasIndex(e => e.IdInstalacaoFederacaoDest, "fk_acesso_fed_instal_fed_dest");

            entity.HasIndex(e => e.IdInstalacaoFederacaoRem, "fk_acesso_fed_instal_fed_rem");

            entity.HasIndex(e => e.IdOrgaoFederacaoDest, "fk_acesso_fed_orgao_fed_dest");

            entity.HasIndex(e => e.IdOrgaoFederacaoRem, "fk_acesso_fed_orgao_fed_rem");

            entity.HasIndex(e => e.IdProcedimentoFederacao, "fk_acesso_fed_procedimento_fed");

            entity.HasIndex(e => e.IdUnidadeFederacaoDest, "fk_acesso_fed_unidade_fed_dest");

            entity.HasIndex(e => e.IdUnidadeFederacaoRem, "fk_acesso_fed_unidade_fed_rem");

            entity.HasIndex(e => e.IdUsuarioFederacaoDest, "fk_acesso_fed_usuario_fed_dest");

            entity.HasIndex(e => e.IdUsuarioFederacaoRem, "fk_acesso_fed_usuario_fed_rem");

            entity.HasIndex(e => new { e.IdProcedimentoFederacao, e.IdInstalacaoFederacaoRem, e.IdInstalacaoFederacaoDest }, "i02_acesso_federacao");

            entity.HasIndex(e => new { e.IdProcedimentoFederacao, e.IdInstalacaoFederacaoDest }, "i03_acesso_federacao");

            entity.HasIndex(e => new { e.IdDocumentoFederacao, e.IdInstalacaoFederacaoRem, e.IdInstalacaoFederacaoDest }, "i04_acesso_federacao");

            entity.Property(e => e.IdAcessoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_acesso_federacao");
            entity.Property(e => e.DthCancelamento)
                .HasColumnType("datetime")
                .HasColumnName("dth_cancelamento");
            entity.Property(e => e.DthLiberacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_liberacao");
            entity.Property(e => e.IdDocumentoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_documento_federacao");
            entity.Property(e => e.IdInstalacaoFederacaoDest)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao_dest");
            entity.Property(e => e.IdInstalacaoFederacaoRem)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao_rem");
            entity.Property(e => e.IdOrgaoFederacaoDest)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_orgao_federacao_dest");
            entity.Property(e => e.IdOrgaoFederacaoRem)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_orgao_federacao_rem");
            entity.Property(e => e.IdProcedimentoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_procedimento_federacao");
            entity.Property(e => e.IdUnidadeFederacaoDest)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_unidade_federacao_dest");
            entity.Property(e => e.IdUnidadeFederacaoRem)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_unidade_federacao_rem");
            entity.Property(e => e.IdUsuarioFederacaoDest)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_usuario_federacao_dest");
            entity.Property(e => e.IdUsuarioFederacaoRem)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_usuario_federacao_rem");
            entity.Property(e => e.MotivoCancelamento)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("motivo_cancelamento");
            entity.Property(e => e.MotivoLiberacao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("motivo_liberacao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo).HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdDocumentoFederacaoNavigation).WithMany(p => p.AcessoFederacaoIdDocumentoFederacaoNavigations)
                .HasForeignKey(d => d.IdDocumentoFederacao)
                .HasConstraintName("fk_acesso_fed_documento_fed");

            entity.HasOne(d => d.IdInstalacaoFederacaoDestNavigation).WithMany(p => p.AcessoFederacaoIdInstalacaoFederacaoDestNavigations)
                .HasForeignKey(d => d.IdInstalacaoFederacaoDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_instal_fed_dest");

            entity.HasOne(d => d.IdInstalacaoFederacaoRemNavigation).WithMany(p => p.AcessoFederacaoIdInstalacaoFederacaoRemNavigations)
                .HasForeignKey(d => d.IdInstalacaoFederacaoRem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_instal_fed_rem");

            entity.HasOne(d => d.IdOrgaoFederacaoDestNavigation).WithMany(p => p.AcessoFederacaoIdOrgaoFederacaoDestNavigations)
                .HasForeignKey(d => d.IdOrgaoFederacaoDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_orgao_fed_dest");

            entity.HasOne(d => d.IdOrgaoFederacaoRemNavigation).WithMany(p => p.AcessoFederacaoIdOrgaoFederacaoRemNavigations)
                .HasForeignKey(d => d.IdOrgaoFederacaoRem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_orgao_fed_rem");

            entity.HasOne(d => d.IdProcedimentoFederacaoNavigation).WithMany(p => p.AcessoFederacaoIdProcedimentoFederacaoNavigations)
                .HasForeignKey(d => d.IdProcedimentoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_procedimento_fed");

            entity.HasOne(d => d.IdUnidadeFederacaoDestNavigation).WithMany(p => p.AcessoFederacaoIdUnidadeFederacaoDestNavigations)
                .HasForeignKey(d => d.IdUnidadeFederacaoDest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_unidade_fed_dest");

            entity.HasOne(d => d.IdUnidadeFederacaoRemNavigation).WithMany(p => p.AcessoFederacaoIdUnidadeFederacaoRemNavigations)
                .HasForeignKey(d => d.IdUnidadeFederacaoRem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acesso_fed_unidade_fed_rem");

            entity.HasOne(d => d.IdUsuarioFederacaoDestNavigation).WithMany(p => p.AcessoFederacaoIdUsuarioFederacaoDestNavigations)
                .HasForeignKey(d => d.IdUsuarioFederacaoDest)
                .HasConstraintName("fk_acesso_fed_usuario_fed_dest");

            entity.HasOne(d => d.IdUsuarioFederacaoRemNavigation).WithMany(p => p.AcessoFederacaoIdUsuarioFederacaoRemNavigations)
                .HasForeignKey(d => d.IdUsuarioFederacaoRem)
                .HasConstraintName("fk_acesso_fed_usuario_fed_rem");
        });

        modelBuilder.Entity<Acompanhamento>(entity =>
        {
            entity.HasKey(e => e.IdAcompanhamento).HasName("pk_acompanhamento");

            entity.ToTable("acompanhamento");

            entity.HasIndex(e => e.IdGrupoAcompanhamento, "fk_acompanhamento_grupo_acompa");

            entity.HasIndex(e => e.IdProtocolo, "fk_acompanhamento_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_acompanhamento_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_acompanhamento_usuario");

            entity.Property(e => e.IdAcompanhamento)
                .ValueGeneratedNever()
                .HasColumnName("id_acompanhamento");
            entity.Property(e => e.DthAlteracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_alteracao");
            entity.Property(e => e.IdGrupoAcompanhamento).HasColumnName("id_grupo_acompanhamento");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdxAcompanhamento)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("idx_acompanhamento");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observacao");
            entity.Property(e => e.TipoVisualizacao).HasColumnName("tipo_visualizacao");

            entity.HasOne(d => d.IdGrupoAcompanhamentoNavigation).WithMany(p => p.Acompanhamentos)
                .HasForeignKey(d => d.IdGrupoAcompanhamento)
                .HasConstraintName("fk_acompanhamento_grupo_acompa");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Acompanhamentos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acompanhamento_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Acompanhamentos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acompanhamento_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Acompanhamentos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_acompanhamento_usuario");
        });

        modelBuilder.Entity<AndamentoInstalacao>(entity =>
        {
            entity.HasKey(e => e.IdAndamentoInstalacao).HasName("pk_andamento_instalacao");

            entity.ToTable("andamento_instalacao");

            entity.HasIndex(e => e.IdTarefaInstalacao, "fk_and_inst_tarefa_inst");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_andamento_inst_inst_fed");

            entity.HasIndex(e => e.IdUnidade, "fk_andamento_inst_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_andamento_inst_usuario");

            entity.Property(e => e.IdAndamentoInstalacao)
                .ValueGeneratedNever()
                .HasColumnName("id_andamento_instalacao");
            entity.Property(e => e.DthEstado)
                .HasColumnType("datetime")
                .HasColumnName("dth_estado");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.IdTarefaInstalacao).HasColumnName("id_tarefa_instalacao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.AndamentoInstalacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_inst_inst_fed");

            entity.HasOne(d => d.IdTarefaInstalacaoNavigation).WithMany(p => p.AndamentoInstalacaos)
                .HasForeignKey(d => d.IdTarefaInstalacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_and_inst_tarefa_inst");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.AndamentoInstalacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_inst_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AndamentoInstalacaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_inst_usuario");
        });

        modelBuilder.Entity<AndamentoMarcador>(entity =>
        {
            entity.HasKey(e => e.IdAndamentoMarcador).HasName("pk_andamento_marcador");

            entity.ToTable("andamento_marcador");

            entity.HasIndex(e => e.IdMarcador, "fk_andamento_marcador_marcador");

            entity.HasIndex(e => e.IdProcedimento, "fk_andamento_marcador_proced");

            entity.HasIndex(e => e.IdUnidade, "fk_andamento_marcador_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_andamento_marcador_usuario");

            entity.HasIndex(e => new { e.IdMarcador, e.IdProcedimento, e.IdUnidade, e.SinUltimo }, "i01_andamento_marcador");

            entity.HasIndex(e => new { e.IdUnidade, e.IdProcedimento, e.SinUltimo }, "i02_andamento_marcador");

            entity.Property(e => e.IdAndamentoMarcador)
                .ValueGeneratedNever()
                .HasColumnName("id_andamento_marcador");
            entity.Property(e => e.DthExecucao)
                .HasColumnType("datetime")
                .HasColumnName("dth_execucao");
            entity.Property(e => e.IdMarcador).HasColumnName("id_marcador");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinUltimo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ultimo");
            entity.Property(e => e.StaOperacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_operacao");
            entity.Property(e => e.Texto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("texto");

            entity.HasOne(d => d.IdMarcadorNavigation).WithMany(p => p.AndamentoMarcadors)
                .HasForeignKey(d => d.IdMarcador)
                .HasConstraintName("fk_andamento_marcador_marcador");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.AndamentoMarcadors)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_marcador_proced");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.AndamentoMarcadors)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_marcador_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AndamentoMarcadors)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_marcador_usuario");
        });

        modelBuilder.Entity<AndamentoPlanoTrabalho>(entity =>
        {
            entity.HasKey(e => e.IdAndamentoPlanoTrabalho).HasName("pk_andamento_plano_trabalho");

            entity.ToTable("andamento_plano_trabalho");

            entity.HasIndex(e => e.IdTarefaPlanoTrabalho, "fk_and_plan_trab_tar_plan_trab");

            entity.HasIndex(e => e.IdPlanoTrabalho, "fk_andam_plano_trab_plano_trab");

            entity.HasIndex(e => e.IdProcedimento, "fk_andam_plano_trab_proced");

            entity.HasIndex(e => e.IdUnidadeOrigem, "fk_andam_plano_trab_uni_origem");

            entity.HasIndex(e => e.IdUsuarioOrigem, "fk_andam_plano_trab_usu_origem");

            entity.Property(e => e.IdAndamentoPlanoTrabalho)
                .ValueGeneratedNever()
                .HasColumnName("id_andamento_plano_trabalho");
            entity.Property(e => e.DthExecucao)
                .HasColumnType("datetime")
                .HasColumnName("dth_execucao");
            entity.Property(e => e.IdPlanoTrabalho).HasColumnName("id_plano_trabalho");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdTarefaPlanoTrabalho).HasColumnName("id_tarefa_plano_trabalho");
            entity.Property(e => e.IdUnidadeOrigem).HasColumnName("id_unidade_origem");
            entity.Property(e => e.IdUsuarioOrigem).HasColumnName("id_usuario_origem");
            entity.Property(e => e.StaSituacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_situacao");

            entity.HasOne(d => d.IdPlanoTrabalhoNavigation).WithMany(p => p.AndamentoPlanoTrabalhos)
                .HasForeignKey(d => d.IdPlanoTrabalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andam_plano_trab_plano_trab");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.AndamentoPlanoTrabalhos)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andam_plano_trab_proced");

            entity.HasOne(d => d.IdTarefaPlanoTrabalhoNavigation).WithMany(p => p.AndamentoPlanoTrabalhos)
                .HasForeignKey(d => d.IdTarefaPlanoTrabalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_and_plan_trab_tar_plan_trab");

            entity.HasOne(d => d.IdUnidadeOrigemNavigation).WithMany(p => p.AndamentoPlanoTrabalhos)
                .HasForeignKey(d => d.IdUnidadeOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andam_plano_trab_uni_origem");

            entity.HasOne(d => d.IdUsuarioOrigemNavigation).WithMany(p => p.AndamentoPlanoTrabalhos)
                .HasForeignKey(d => d.IdUsuarioOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andam_plano_trab_usu_origem");
        });

        modelBuilder.Entity<AndamentoSituacao>(entity =>
        {
            entity.HasKey(e => e.IdAndamentoSituacao).HasName("pk_andamento_situacao");

            entity.ToTable("andamento_situacao");

            entity.HasIndex(e => e.IdProcedimento, "fk_andam_situacao_procedimento");

            entity.HasIndex(e => e.IdSituacao, "fk_andam_situacao_situacao");

            entity.HasIndex(e => e.IdUnidade, "fk_andamento_situacao_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_andamento_situacao_usuario");

            entity.HasIndex(e => new { e.IdSituacao, e.IdProcedimento, e.IdUnidade, e.SinUltimo }, "i01_andamento_situacao");

            entity.Property(e => e.IdAndamentoSituacao)
                .ValueGeneratedNever()
                .HasColumnName("id_andamento_situacao");
            entity.Property(e => e.DthExecucao)
                .HasColumnType("datetime")
                .HasColumnName("dth_execucao");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdSituacao).HasColumnName("id_situacao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.SinUltimo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ultimo");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.AndamentoSituacaos)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andam_situacao_procedimento");

            entity.HasOne(d => d.IdSituacaoNavigation).WithMany(p => p.AndamentoSituacaos)
                .HasForeignKey(d => d.IdSituacao)
                .HasConstraintName("fk_andam_situacao_situacao");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.AndamentoSituacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_situacao_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AndamentoSituacaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_andamento_situacao_usuario");
        });

        modelBuilder.Entity<Anexo>(entity =>
        {
            entity.HasKey(e => e.IdAnexo).HasName("pk_anexo");

            entity.ToTable("anexo");

            entity.HasIndex(e => new { e.IdAnexo, e.SinAtivo }, "ak1_anexo").IsUnique();

            entity.HasIndex(e => e.IdBaseConhecimento, "fk_anexo_base_conhecimento");

            entity.HasIndex(e => e.IdProtocolo, "fk_anexo_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_anexo_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_anexo_usuario");

            entity.HasIndex(e => new { e.IdProtocolo, e.SinAtivo }, "i01_anexo");

            entity.HasIndex(e => e.DthInclusao, "i02_anexo");

            entity.Property(e => e.IdAnexo)
                .ValueGeneratedNever()
                .HasColumnName("id_anexo");
            entity.Property(e => e.DthInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dth_inclusao");
            entity.Property(e => e.Hash)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hash");
            entity.Property(e => e.IdBaseConhecimento).HasColumnName("id_base_conhecimento");
            entity.Property(e => e.IdProjeto).HasColumnName("id_projeto");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.Tamanho).HasColumnName("tamanho");

            entity.HasOne(d => d.IdBaseConhecimentoNavigation).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.IdBaseConhecimento)
                .HasConstraintName("fk_anexo_base_conhecimento");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.IdProtocolo)
                .HasConstraintName("fk_anexo_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_anexo_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Anexos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_anexo_usuario");
        });

        modelBuilder.Entity<Anotacao>(entity =>
        {
            entity.HasKey(e => e.IdAnotacao).HasName("pk_anotacao");

            entity.ToTable("anotacao");

            entity.HasIndex(e => e.IdProtocolo, "fk_anotacao_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_anotacao_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_anotacao_usuario");

            entity.HasIndex(e => new { e.IdUnidade, e.IdProtocolo, e.IdUsuario, e.SinPrioridade, e.StaAnotacao }, "i01_anotacao");

            entity.Property(e => e.IdAnotacao)
                .ValueGeneratedNever()
                .HasColumnName("id_anotacao");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthAnotacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_anotacao");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.SinPrioridade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_prioridade");
            entity.Property(e => e.StaAnotacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_anotacao");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Anotacaos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_anotacao_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Anotacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_anotacao_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Anotacaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_anotacao_usuario");
        });

        modelBuilder.Entity<Arquivamento>(entity =>
        {
            entity.HasKey(e => e.IdProtocolo).HasName("pk_arquivamento");

            entity.ToTable("arquivamento");

            entity.HasIndex(e => e.IdAtividadeArquivamento, "fk_arquiv_ativ_arquiv");

            entity.HasIndex(e => e.IdAtividadeCancelamento, "fk_arquiv_ativ_canc");

            entity.HasIndex(e => e.IdAtividadeDesarquivamento, "fk_arquiv_ativ_desarquiv");

            entity.HasIndex(e => e.IdAtividadeEliminacao, "fk_arquiv_ativ_eliminacao");

            entity.HasIndex(e => e.IdAtividadeRecebimento, "fk_arquiv_ativ_receb");

            entity.HasIndex(e => e.IdAtividadeSolicitacao, "fk_arquiv_ativ_solic_desarq");

            entity.HasIndex(e => e.IdLocalizador, "fk_arquivamento_localizador");

            entity.HasIndex(e => new { e.IdLocalizador, e.StaArquivamento }, "i07_arquivamento");

            entity.Property(e => e.IdProtocolo)
                .ValueGeneratedNever()
                .HasColumnName("id_protocolo");
            entity.Property(e => e.IdAtividadeArquivamento).HasColumnName("id_atividade_arquivamento");
            entity.Property(e => e.IdAtividadeCancelamento).HasColumnName("id_atividade_cancelamento");
            entity.Property(e => e.IdAtividadeDesarquivamento).HasColumnName("id_atividade_desarquivamento");
            entity.Property(e => e.IdAtividadeEliminacao).HasColumnName("id_atividade_eliminacao");
            entity.Property(e => e.IdAtividadeRecebimento).HasColumnName("id_atividade_recebimento");
            entity.Property(e => e.IdAtividadeSolicitacao).HasColumnName("id_atividade_solicitacao");
            entity.Property(e => e.IdLocalizador).HasColumnName("id_localizador");
            entity.Property(e => e.StaArquivamento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_arquivamento");
            entity.Property(e => e.StaEliminacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_eliminacao");

            entity.HasOne(d => d.IdAtividadeArquivamentoNavigation).WithMany(p => p.ArquivamentoIdAtividadeArquivamentoNavigations)
                .HasForeignKey(d => d.IdAtividadeArquivamento)
                .HasConstraintName("fk_arquiv_ativ_arquiv");

            entity.HasOne(d => d.IdAtividadeCancelamentoNavigation).WithMany(p => p.ArquivamentoIdAtividadeCancelamentoNavigations)
                .HasForeignKey(d => d.IdAtividadeCancelamento)
                .HasConstraintName("fk_arquiv_ativ_canc");

            entity.HasOne(d => d.IdAtividadeDesarquivamentoNavigation).WithMany(p => p.ArquivamentoIdAtividadeDesarquivamentoNavigations)
                .HasForeignKey(d => d.IdAtividadeDesarquivamento)
                .HasConstraintName("fk_arquiv_ativ_desarquiv");

            entity.HasOne(d => d.IdAtividadeEliminacaoNavigation).WithMany(p => p.ArquivamentoIdAtividadeEliminacaoNavigations)
                .HasForeignKey(d => d.IdAtividadeEliminacao)
                .HasConstraintName("fk_arquiv_ativ_eliminacao");

            entity.HasOne(d => d.IdAtividadeRecebimentoNavigation).WithMany(p => p.ArquivamentoIdAtividadeRecebimentoNavigations)
                .HasForeignKey(d => d.IdAtividadeRecebimento)
                .HasConstraintName("fk_arquiv_ativ_receb");

            entity.HasOne(d => d.IdAtividadeSolicitacaoNavigation).WithMany(p => p.ArquivamentoIdAtividadeSolicitacaoNavigations)
                .HasForeignKey(d => d.IdAtividadeSolicitacao)
                .HasConstraintName("fk_arquiv_ativ_solic_desarq");

            entity.HasOne(d => d.IdLocalizadorNavigation).WithMany(p => p.Arquivamentos)
                .HasForeignKey(d => d.IdLocalizador)
                .HasConstraintName("fk_arquivamento_localizador");

            entity.HasOne(d => d.IdProtocoloNavigation).WithOne(p => p.Arquivamento)
                .HasForeignKey<Arquivamento>(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_arquivamento_protocolo");
        });

        modelBuilder.Entity<ArquivoExtensao>(entity =>
        {
            entity.HasKey(e => e.IdArquivoExtensao).HasName("pk_arquivo_extensao");

            entity.ToTable("arquivo_extensao");

            entity.Property(e => e.IdArquivoExtensao)
                .ValueGeneratedNever()
                .HasColumnName("id_arquivo_extensao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Extensao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extensao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinInterface)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_interface");
            entity.Property(e => e.SinServico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_servico");
            entity.Property(e => e.TamanhoMaximo).HasColumnName("tamanho_maximo");
        });

        modelBuilder.Entity<Assinante>(entity =>
        {
            entity.HasKey(e => e.IdAssinante).HasName("pk_assinante");

            entity.ToTable("assinante");

            entity.HasIndex(e => e.IdOrgao, "fk_assinante_orgao");

            entity.Property(e => e.IdAssinante)
                .ValueGeneratedNever()
                .HasColumnName("id_assinante");
            entity.Property(e => e.CargoFuncao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cargo_funcao");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Assinantes)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assinante_orgao");
        });

        modelBuilder.Entity<Assinatura>(entity =>
        {
            entity.HasKey(e => e.IdAssinatura).HasName("pk_assinatura");

            entity.ToTable("assinatura");

            entity.HasIndex(e => new { e.IdDocumento, e.IdUsuario }, "ak1_assinatura").IsUnique();

            entity.HasIndex(e => e.IdAtividade, "fk_assinatura_atividade");

            entity.HasIndex(e => e.IdDocumento, "fk_assinatura_documento");

            entity.HasIndex(e => e.IdTarjaAssinatura, "fk_assinatura_tarja_assinatura");

            entity.HasIndex(e => e.IdUnidade, "fk_assinatura_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_assinatura_usuario_autentic");

            entity.HasIndex(e => e.Agrupador, "i01_assinatura");

            entity.HasIndex(e => new { e.IdDocumento, e.IdAtividade }, "i02_assinatura");

            entity.Property(e => e.IdAssinatura)
                .ValueGeneratedNever()
                .HasColumnName("id_assinatura");
            entity.Property(e => e.Agrupador)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("agrupador");
            entity.Property(e => e.Cpf).HasColumnName("cpf");
            entity.Property(e => e.IdAtividade).HasColumnName("id_atividade");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdTarjaAssinatura).HasColumnName("id_tarja_assinatura");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NumeroSerieCertificado)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("numero_serie_certificado");
            entity.Property(e => e.P7sBase64)
                .IsUnicode(false)
                .HasColumnName("p7s_base64");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaFormaAutenticacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_forma_autenticacao");
            entity.Property(e => e.Tratamento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tratamento");

            entity.HasOne(d => d.IdAtividadeNavigation).WithMany(p => p.Assinaturas)
                .HasForeignKey(d => d.IdAtividade)
                .HasConstraintName("fk_assinatura_atividade");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Assinaturas)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assinatura_documento");

            entity.HasOne(d => d.IdTarjaAssinaturaNavigation).WithMany(p => p.Assinaturas)
                .HasForeignKey(d => d.IdTarjaAssinatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assinatura_tarja_assinatura");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Assinaturas)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assinatura_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Assinaturas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assinatura_usuario_autentic");
        });

        modelBuilder.Entity<Assunto>(entity =>
        {
            entity.HasKey(e => e.IdAssunto).HasName("pk_assunto");

            entity.ToTable("assunto");

            entity.HasIndex(e => e.IdTabelaAssuntos, "fk_assunto_tabela_assuntos");

            entity.HasIndex(e => new { e.IdTabelaAssuntos, e.CodigoEstruturado, e.SinEstrutural, e.SinAtivo }, "i01_assunto");

            entity.Property(e => e.IdAssunto)
                .ValueGeneratedNever()
                .HasColumnName("id_assunto");
            entity.Property(e => e.CodigoEstruturado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_estruturado");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdTabelaAssuntos).HasColumnName("id_tabela_assuntos");
            entity.Property(e => e.IdxAssunto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("idx_assunto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observacao");
            entity.Property(e => e.PrazoCorrente).HasColumnName("prazo_corrente");
            entity.Property(e => e.PrazoIntermediario).HasColumnName("prazo_intermediario");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinEstrutural)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_estrutural");
            entity.Property(e => e.StaDestinacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_destinacao");

            entity.HasOne(d => d.IdTabelaAssuntosNavigation).WithMany(p => p.Assuntos)
                .HasForeignKey(d => d.IdTabelaAssuntos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assunto_tabela_assuntos");

            entity.HasMany(d => d.IdAssuntoDestinos).WithMany(p => p.IdAssuntoOrigems)
                .UsingEntity<Dictionary<string, object>>(
                    "MapeamentoAssunto",
                    r => r.HasOne<Assunto>().WithMany()
                        .HasForeignKey("IdAssuntoDestino")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_assunto_map_assunto_destino"),
                    l => l.HasOne<Assunto>().WithMany()
                        .HasForeignKey("IdAssuntoOrigem")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_assunto_map_assunto_origem"),
                    j =>
                    {
                        j.HasKey("IdAssuntoOrigem", "IdAssuntoDestino").HasName("pk_mapeamento_assunto");
                        j.ToTable("mapeamento_assunto");
                        j.HasIndex(new[] { "IdAssuntoDestino" }, "fk_assunto_map_assunto_destino");
                        j.HasIndex(new[] { "IdAssuntoOrigem" }, "fk_assunto_map_assunto_origem");
                        j.IndexerProperty<int>("IdAssuntoOrigem").HasColumnName("id_assunto_origem");
                        j.IndexerProperty<int>("IdAssuntoDestino").HasColumnName("id_assunto_destino");
                    });

            entity.HasMany(d => d.IdAssuntoOrigems).WithMany(p => p.IdAssuntoDestinos)
                .UsingEntity<Dictionary<string, object>>(
                    "MapeamentoAssunto",
                    r => r.HasOne<Assunto>().WithMany()
                        .HasForeignKey("IdAssuntoOrigem")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_assunto_map_assunto_origem"),
                    l => l.HasOne<Assunto>().WithMany()
                        .HasForeignKey("IdAssuntoDestino")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_assunto_map_assunto_destino"),
                    j =>
                    {
                        j.HasKey("IdAssuntoOrigem", "IdAssuntoDestino").HasName("pk_mapeamento_assunto");
                        j.ToTable("mapeamento_assunto");
                        j.HasIndex(new[] { "IdAssuntoDestino" }, "fk_assunto_map_assunto_destino");
                        j.HasIndex(new[] { "IdAssuntoOrigem" }, "fk_assunto_map_assunto_origem");
                        j.IndexerProperty<int>("IdAssuntoOrigem").HasColumnName("id_assunto_origem");
                        j.IndexerProperty<int>("IdAssuntoDestino").HasColumnName("id_assunto_destino");
                    });
        });

        modelBuilder.Entity<AssuntoProxy>(entity =>
        {
            entity.HasKey(e => e.IdAssuntoProxy).HasName("pk_assunto_proxy");

            entity.ToTable("assunto_proxy");

            entity.HasIndex(e => e.IdAssunto, "fk_assunto_proxy_assunto");

            entity.Property(e => e.IdAssuntoProxy)
                .ValueGeneratedNever()
                .HasColumnName("id_assunto_proxy");
            entity.Property(e => e.IdAssunto).HasColumnName("id_assunto");

            entity.HasOne(d => d.IdAssuntoNavigation).WithMany(p => p.AssuntoProxies)
                .HasForeignKey(d => d.IdAssunto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assunto_proxy_assunto");
        });

        modelBuilder.Entity<Atividade>(entity =>
        {
            entity.HasKey(e => e.IdAtividade).HasName("pk_atividade");

            entity.ToTable("atividade");

            entity.HasIndex(e => e.IdProtocolo, "fk_atividade_protocolo");

            entity.HasIndex(e => e.IdTarefa, "fk_atividade_tarefa");

            entity.HasIndex(e => e.IdUnidade, "fk_atividade_unidade");

            entity.HasIndex(e => e.IdUnidadeOrigem, "fk_atividade_unidade_origem");

            entity.HasIndex(e => e.IdUsuario, "fk_atividade_usuario");

            entity.HasIndex(e => e.IdUsuarioAtribuicao, "fk_atividade_usuario_atribuica");

            entity.HasIndex(e => e.IdUsuarioConclusao, "fk_atividade_usuario_conclusao");

            entity.HasIndex(e => e.IdUsuarioOrigem, "fk_atividade_usuario_origem");

            entity.HasIndex(e => e.IdUsuarioVisualizacao, "fk_atividade_usuario_visualiza");

            entity.HasIndex(e => new { e.IdAtividade, e.IdProtocolo, e.IdUnidade, e.IdUsuario, e.DthConclusao, e.SinInicial, e.IdUsuarioAtribuicao }, "i01_atividade");

            entity.HasIndex(e => new { e.IdAtividade, e.IdProtocolo, e.IdUnidade, e.IdUsuario, e.IdTarefa }, "i02_atividade");

            entity.HasIndex(e => new { e.IdUnidade, e.DthConclusao, e.SinInicial }, "i03_atividade");

            entity.HasIndex(e => new { e.IdUnidade, e.DthAbertura, e.IdTarefa }, "i04_atividade");

            entity.HasIndex(e => new { e.IdUnidade, e.IdProtocolo }, "i06_atividade");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdUnidadeOrigem, e.IdTarefa }, "i07_atividade");

            entity.HasIndex(e => new { e.IdUnidade, e.IdUsuario, e.IdProtocolo }, "i09_atividade");

            entity.HasIndex(e => new { e.DthAbertura, e.IdTarefa }, "i10_atividade");

            entity.HasIndex(e => new { e.IdUnidade, e.IdProtocolo, e.DthConclusao, e.IdUsuario, e.IdAtividade, e.IdUsuarioAtribuicao }, "i16_atividade");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdTarefa, e.IdUnidade, e.IdUnidadeOrigem }, "i17_atividade");

            entity.Property(e => e.IdAtividade)
                .ValueGeneratedNever()
                .HasColumnName("id_atividade");
            entity.Property(e => e.DtaPrazo)
                .HasColumnType("datetime")
                .HasColumnName("dta_prazo");
            entity.Property(e => e.DthAbertura)
                .HasColumnType("datetime")
                .HasColumnName("dth_abertura");
            entity.Property(e => e.DthConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dth_conclusao");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdTarefa).HasColumnName("id_tarefa");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUnidadeOrigem).HasColumnName("id_unidade_origem");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioAtribuicao).HasColumnName("id_usuario_atribuicao");
            entity.Property(e => e.IdUsuarioConclusao).HasColumnName("id_usuario_conclusao");
            entity.Property(e => e.IdUsuarioOrigem).HasColumnName("id_usuario_origem");
            entity.Property(e => e.IdUsuarioVisualizacao).HasColumnName("id_usuario_visualizacao");
            entity.Property(e => e.SinInicial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_inicial");
            entity.Property(e => e.TipoVisualizacao).HasColumnName("tipo_visualizacao");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atividade_protocolo");

            entity.HasOne(d => d.IdTarefaNavigation).WithMany(p => p.Atividades)
                .HasForeignKey(d => d.IdTarefa)
                .HasConstraintName("fk_atividade_tarefa");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.AtividadeIdUnidadeNavigations)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atividade_unidade");

            entity.HasOne(d => d.IdUnidadeOrigemNavigation).WithMany(p => p.AtividadeIdUnidadeOrigemNavigations)
                .HasForeignKey(d => d.IdUnidadeOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atividade_unidade_origem");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AtividadeIdUsuarioNavigations)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_atividade_usuario");

            entity.HasOne(d => d.IdUsuarioAtribuicaoNavigation).WithMany(p => p.AtividadeIdUsuarioAtribuicaoNavigations)
                .HasForeignKey(d => d.IdUsuarioAtribuicao)
                .HasConstraintName("fk_atividade_usuario_atribuica");

            entity.HasOne(d => d.IdUsuarioConclusaoNavigation).WithMany(p => p.AtividadeIdUsuarioConclusaoNavigations)
                .HasForeignKey(d => d.IdUsuarioConclusao)
                .HasConstraintName("fk_atividade_usuario_conclusao");

            entity.HasOne(d => d.IdUsuarioOrigemNavigation).WithMany(p => p.AtividadeIdUsuarioOrigemNavigations)
                .HasForeignKey(d => d.IdUsuarioOrigem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atividade_usuario_origem");

            entity.HasOne(d => d.IdUsuarioVisualizacaoNavigation).WithMany(p => p.AtividadeIdUsuarioVisualizacaoNavigations)
                .HasForeignKey(d => d.IdUsuarioVisualizacao)
                .HasConstraintName("fk_atividade_usuario_visualiza");
        });

        modelBuilder.Entity<Atributo>(entity =>
        {
            entity.HasKey(e => e.IdAtributo).HasName("pk_atributo");

            entity.ToTable("atributo");

            entity.HasIndex(e => e.IdTipoFormulario, "fk_atributo_tipo_formulario");

            entity.Property(e => e.IdAtributo)
                .ValueGeneratedNever()
                .HasColumnName("id_atributo");
            entity.Property(e => e.Decimais).HasColumnName("decimais");
            entity.Property(e => e.IdTipoFormulario).HasColumnName("id_tipo_formulario");
            entity.Property(e => e.Linhas).HasColumnName("linhas");
            entity.Property(e => e.Mascara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mascara");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.Rotulo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("rotulo");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinObrigatorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_obrigatorio");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sta_tipo");
            entity.Property(e => e.Tamanho).HasColumnName("tamanho");
            entity.Property(e => e.ValorMaximo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("valor_maximo");
            entity.Property(e => e.ValorMinimo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("valor_minimo");
            entity.Property(e => e.ValorPadrao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor_padrao");

            entity.HasOne(d => d.IdTipoFormularioNavigation).WithMany(p => p.Atributos)
                .HasForeignKey(d => d.IdTipoFormulario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atributo_tipo_formulario");
        });

        modelBuilder.Entity<AtributoAndamPlanoTrab>(entity =>
        {
            entity.HasKey(e => e.IdAtributoAndamPlanoTrab).HasName("pk_atributo_andam_plano_trab");

            entity.ToTable("atributo_andam_plano_trab");

            entity.HasIndex(e => e.IdAndamentoPlanoTrabalho, "fk_atr_and_pla_tra_and_pla_tra");

            entity.Property(e => e.IdAtributoAndamPlanoTrab)
                .ValueGeneratedNever()
                .HasColumnName("id_atributo_andam_plano_trab");
            entity.Property(e => e.Chave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("chave");
            entity.Property(e => e.IdAndamentoPlanoTrabalho).HasColumnName("id_andamento_plano_trabalho");
            entity.Property(e => e.IdOrigem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_origem");
            entity.Property(e => e.Valor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAndamentoPlanoTrabalhoNavigation).WithMany(p => p.AtributoAndamPlanoTrabs)
                .HasForeignKey(d => d.IdAndamentoPlanoTrabalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atr_and_pla_tra_and_pla_tra");
        });

        modelBuilder.Entity<AtributoAndamento>(entity =>
        {
            entity.HasKey(e => e.IdAtributoAndamento).HasName("pk_atributo_andamento");

            entity.ToTable("atributo_andamento");

            entity.HasIndex(e => e.IdAtividade, "fk_atributo_andamento_atividad");

            entity.HasIndex(e => new { e.IdAtividade, e.Nome, e.IdOrigem }, "i01_atributo_andamento");

            entity.HasIndex(e => new { e.Nome, e.IdOrigem }, "i02_atributo_andamento");

            entity.HasIndex(e => new { e.IdAtividade, e.IdAtributoAndamento }, "i04_atributo_andamento");

            entity.Property(e => e.IdAtributoAndamento)
                .ValueGeneratedNever()
                .HasColumnName("id_atributo_andamento");
            entity.Property(e => e.IdAtividade).HasColumnName("id_atividade");
            entity.Property(e => e.IdOrigem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_origem");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAtividadeNavigation).WithMany(p => p.AtributoAndamentos)
                .HasForeignKey(d => d.IdAtividade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atributo_andamento_atividad");
        });

        modelBuilder.Entity<AtributoInstalacao>(entity =>
        {
            entity.HasKey(e => e.IdAtributoInstalacao).HasName("pk_atributo_instalacao");

            entity.ToTable("atributo_instalacao");

            entity.HasIndex(e => e.IdAndamentoInstalacao, "fk_atributo_inst_andam_inst");

            entity.Property(e => e.IdAtributoInstalacao)
                .ValueGeneratedNever()
                .HasColumnName("id_atributo_instalacao");
            entity.Property(e => e.IdAndamentoInstalacao).HasColumnName("id_andamento_instalacao");
            entity.Property(e => e.IdOrigem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_origem");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAndamentoInstalacaoNavigation).WithMany(p => p.AtributoInstalacaos)
                .HasForeignKey(d => d.IdAndamentoInstalacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_atributo_inst_andam_inst");
        });

        modelBuilder.Entity<AuditoriaProtocolo>(entity =>
        {
            entity.HasKey(e => e.IdAuditoriaProtocolo).HasName("pk_auditoria_protocolo");

            entity.ToTable("auditoria_protocolo");

            entity.HasIndex(e => new { e.IdUsuario, e.IdProtocolo, e.Versao, e.DtaAuditoria, e.IdAnexo }, "i01_auditoria_protocolo");

            entity.Property(e => e.IdAuditoriaProtocolo)
                .ValueGeneratedNever()
                .HasColumnName("id_auditoria_protocolo");
            entity.Property(e => e.DtaAuditoria)
                .HasColumnType("datetime")
                .HasColumnName("dta_auditoria");
            entity.Property(e => e.IdAnexo).HasColumnName("id_anexo");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Versao).HasColumnName("versao");
        });

        modelBuilder.Entity<AvaliacaoDocumental>(entity =>
        {
            entity.HasKey(e => e.IdAvaliacaoDocumental).HasName("pk_avaliacao_documental");

            entity.ToTable("avaliacao_documental");

            entity.HasIndex(e => e.IdAssunto, "fk_avaliacao_doc_assunto");

            entity.HasIndex(e => e.IdAssuntoProxy, "fk_avaliacao_doc_assunto_proxy");

            entity.HasIndex(e => e.IdUnidade, "fk_avaliacao_doc_unidade");

            entity.HasIndex(e => e.IdProcedimento, "fk_avaliacao_documental_proced");

            entity.HasIndex(e => e.IdUsuario, "fk_avaliacao_documental_usu");

            entity.HasIndex(e => new { e.IdUsuario, e.DtaAvaliacao, e.StaAvaliacao }, "i04_avaliacao_documental");

            entity.Property(e => e.IdAvaliacaoDocumental)
                .ValueGeneratedNever()
                .HasColumnName("id_avaliacao_documental");
            entity.Property(e => e.DtaAvaliacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_avaliacao");
            entity.Property(e => e.IdAssunto).HasColumnName("id_assunto");
            entity.Property(e => e.IdAssuntoProxy).HasColumnName("id_assunto_proxy");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.StaAvaliacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_avaliacao");

            entity.HasOne(d => d.IdAssuntoNavigation).WithMany(p => p.AvaliacaoDocumentals)
                .HasForeignKey(d => d.IdAssunto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_avaliacao_doc_assunto");

            entity.HasOne(d => d.IdAssuntoProxyNavigation).WithMany(p => p.AvaliacaoDocumentals)
                .HasForeignKey(d => d.IdAssuntoProxy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_avaliacao_doc_assunto_proxy");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.AvaliacaoDocumentals)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_avaliacao_documental_proced");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.AvaliacaoDocumentals)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_avaliacao_doc_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AvaliacaoDocumentals)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_avaliacao_documental_usu");
        });

        modelBuilder.Entity<Aviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso).HasName("pk_aviso");

            entity.ToTable("aviso");

            entity.HasIndex(e => new { e.DthInicio, e.DthFim, e.SinLiberado }, "i01_aviso");

            entity.Property(e => e.IdAviso)
                .ValueGeneratedNever()
                .HasColumnName("id_aviso");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthFim)
                .HasColumnType("datetime")
                .HasColumnName("dth_fim");
            entity.Property(e => e.DthInicio)
                .HasColumnType("datetime")
                .HasColumnName("dth_inicio");
            entity.Property(e => e.Imagem)
                .IsUnicode(false)
                .HasColumnName("imagem");
            entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("link");
            entity.Property(e => e.SinLiberado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_liberado");
            entity.Property(e => e.StaAviso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_aviso");

            entity.HasMany(d => d.IdOrgaos).WithMany(p => p.IdAvisos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelAvisoOrgao",
                    r => r.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aviso_orgao_orgao"),
                    l => l.HasOne<Aviso>().WithMany()
                        .HasForeignKey("IdAviso")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_aviso_orgao_aviso"),
                    j =>
                    {
                        j.HasKey("IdAviso", "IdOrgao").HasName("pk_rel_aviso_orgao");
                        j.ToTable("rel_aviso_orgao");
                        j.HasIndex(new[] { "IdAviso" }, "fk_rel_aviso_orgao_aviso");
                        j.HasIndex(new[] { "IdOrgao" }, "fk_rel_aviso_orgao_orgao");
                        j.IndexerProperty<int>("IdAviso").HasColumnName("id_aviso");
                        j.IndexerProperty<int>("IdOrgao").HasColumnName("id_orgao");
                    });
        });

        modelBuilder.Entity<BaseConhecimento>(entity =>
        {
            entity.HasKey(e => e.IdBaseConhecimento).HasName("pk_base_conhecimento");

            entity.ToTable("base_conhecimento");

            entity.HasIndex(e => e.IdConjuntoEstilos, "fk_base_conhec_conj_estilos");

            entity.HasIndex(e => e.IdUsuarioGerador, "fk_base_conhec_usu_gerador");

            entity.HasIndex(e => e.IdUsuarioLiberacao, "fk_base_conhec_usu_liberacao");

            entity.HasIndex(e => e.IdUnidade, "fk_base_conhecimento_unidade");

            entity.HasIndex(e => e.IdBaseConhecimentoAgrupador, "i01_base_conhecimento");

            entity.HasIndex(e => new { e.IdUnidade, e.StaEstado }, "i02_base_conhecimento");

            entity.Property(e => e.IdBaseConhecimento)
                .ValueGeneratedNever()
                .HasColumnName("id_base_conhecimento");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthGeracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_geracao");
            entity.Property(e => e.DthLiberacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_liberacao");
            entity.Property(e => e.IdBaseConhecimentoAgrupador).HasColumnName("id_base_conhecimento_agrupador");
            entity.Property(e => e.IdBaseConhecimentoOrigem).HasColumnName("id_base_conhecimento_origem");
            entity.Property(e => e.IdConjuntoEstilos).HasColumnName("id_conjunto_estilos");
            entity.Property(e => e.IdDocumentoEdoc).HasColumnName("id_documento_edoc");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuarioGerador).HasColumnName("id_usuario_gerador");
            entity.Property(e => e.IdUsuarioLiberacao).HasColumnName("id_usuario_liberacao");
            entity.Property(e => e.StaDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_documento");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");

            entity.HasOne(d => d.IdConjuntoEstilosNavigation).WithMany(p => p.BaseConhecimentos)
                .HasForeignKey(d => d.IdConjuntoEstilos)
                .HasConstraintName("fk_base_conhec_conj_estilos");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.BaseConhecimentos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_base_conhecimento_unidade");

            entity.HasOne(d => d.IdUsuarioGeradorNavigation).WithMany(p => p.BaseConhecimentoIdUsuarioGeradorNavigations)
                .HasForeignKey(d => d.IdUsuarioGerador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_base_conhec_usu_gerador");

            entity.HasOne(d => d.IdUsuarioLiberacaoNavigation).WithMany(p => p.BaseConhecimentoIdUsuarioLiberacaoNavigations)
                .HasForeignKey(d => d.IdUsuarioLiberacao)
                .HasConstraintName("fk_base_conhec_usu_liberacao");
        });

        modelBuilder.Entity<Bloco>(entity =>
        {
            entity.HasKey(e => e.IdBloco).HasName("pk_bloco");

            entity.ToTable("bloco");

            entity.HasIndex(e => e.IdUnidade, "fk_bloco_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_bloco_usuario");

            entity.HasIndex(e => e.StaEstado, "i01_bloco");

            entity.HasIndex(e => new { e.IdUnidade, e.StaTipo, e.StaEstado }, "i02_bloco");

            entity.HasIndex(e => new { e.IdBloco, e.IdUnidade, e.StaTipo, e.StaEstado }, "i03_bloco");

            entity.HasIndex(e => new { e.IdBloco, e.StaEstado }, "i04_bloco");

            entity.HasIndex(e => new { e.IdBloco, e.StaEstado, e.StaTipo, e.IdUnidade, e.IdUsuario }, "ie1_bloco");

            entity.Property(e => e.IdBloco)
                .ValueGeneratedNever()
                .HasColumnName("id_bloco");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdxBloco)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("idx_bloco");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Blocos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Blocos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bloco_usuario");
        });

        modelBuilder.Entity<CampoPesquisa>(entity =>
        {
            entity.HasKey(e => e.IdCampoPesquisa).HasName("pk_campo_pesquisa");

            entity.ToTable("campo_pesquisa");

            entity.HasIndex(e => e.IdPesquisa, "fk_campo_pesquisa_pesquisa");

            entity.Property(e => e.IdCampoPesquisa)
                .ValueGeneratedNever()
                .HasColumnName("id_campo_pesquisa");
            entity.Property(e => e.Chave).HasColumnName("chave");
            entity.Property(e => e.IdPesquisa).HasColumnName("id_pesquisa");
            entity.Property(e => e.Valor)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdPesquisaNavigation).WithMany(p => p.CampoPesquisas)
                .HasForeignKey(d => d.IdPesquisa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_campo_pesquisa_pesquisa");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("pk_cargo");

            entity.ToTable("cargo");

            entity.HasIndex(e => e.IdTitulo, "fk_cargo_titulo");

            entity.HasIndex(e => e.IdTratamento, "fk_cargo_tratamento");

            entity.HasIndex(e => e.IdVocativo, "fk_cargo_vocativo");

            entity.HasIndex(e => new { e.IdCargo, e.SinAtivo }, "ie1_cargo");

            entity.Property(e => e.IdCargo)
                .ValueGeneratedNever()
                .HasColumnName("id_cargo");
            entity.Property(e => e.Expressao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("expressao");
            entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");
            entity.Property(e => e.IdTratamento).HasColumnName("id_tratamento");
            entity.Property(e => e.IdVocativo).HasColumnName("id_vocativo");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaGenero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_genero");

            entity.HasOne(d => d.IdTituloNavigation).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.IdTitulo)
                .HasConstraintName("fk_cargo_titulo");

            entity.HasOne(d => d.IdTratamentoNavigation).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.IdTratamento)
                .HasConstraintName("fk_cargo_tratamento");

            entity.HasOne(d => d.IdVocativoNavigation).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.IdVocativo)
                .HasConstraintName("fk_cargo_vocativo");
        });

        modelBuilder.Entity<CargoFuncao>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidade, e.IdCargoFuncao }).HasName("pk_cargo_funcao");

            entity.ToTable("cargo_funcao");

            entity.HasIndex(e => e.IdUnidade, "fk_cargo_funcao_unidade");

            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdCargoFuncao).HasColumnName("id_cargo_funcao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.CargoFuncaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cargo_funcao_unidade");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("pk_categoria");

            entity.ToTable("categoria");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnName("id_categoria");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Cidade>(entity =>
        {
            entity.HasKey(e => e.IdCidade).HasName("pk_cidade");

            entity.ToTable("cidade");

            entity.HasIndex(e => new { e.IdUf, e.Nome }, "ak1_cidade").IsUnique();

            entity.HasIndex(e => e.IdPais, "fk_cidade_pais");

            entity.HasIndex(e => e.IdUf, "fk_cidade_uf");

            entity.HasIndex(e => new { e.IdPais, e.IdUf, e.SinCapital, e.CodigoIbge }, "i01_cidade");

            entity.Property(e => e.IdCidade)
                .ValueGeneratedNever()
                .HasColumnName("id_cidade");
            entity.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdUf).HasColumnName("id_uf");
            entity.Property(e => e.Latitude)
                .HasColumnType("numeric(9, 6)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("numeric(9, 6)")
                .HasColumnName("longitude");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinCapital)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_capital");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Cidades)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("fk_cidade_pais");

            entity.HasOne(d => d.IdUfNavigation).WithMany(p => p.Cidades)
                .HasForeignKey(d => d.IdUf)
                .HasConstraintName("fk_cidade_uf");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("pk_comentario");

            entity.ToTable("comentario");

            entity.HasIndex(e => e.IdProcedimento, "fk_comentario_procedimento");

            entity.HasIndex(e => e.IdRelProtocoloProtocolo, "fk_comentario_rel_prot_prot");

            entity.HasIndex(e => e.IdUnidade, "fk_comentario_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_comentario_usuario");

            entity.HasIndex(e => new { e.IdProcedimento, e.IdRelProtocoloProtocolo }, "i01_comentario");

            entity.Property(e => e.IdComentario)
                .ValueGeneratedNever()
                .HasColumnName("id_comentario");
            entity.Property(e => e.Descricao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthComentario)
                .HasColumnType("datetime")
                .HasColumnName("dth_comentario");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdRelProtocoloProtocolo).HasColumnName("id_rel_protocolo_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comentario_procedimento");

            entity.HasOne(d => d.IdRelProtocoloProtocoloNavigation).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.IdRelProtocoloProtocolo)
                .HasConstraintName("fk_comentario_rel_prot_prot");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comentario_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comentario_usuario");
        });

        modelBuilder.Entity<ConjuntoEstilo>(entity =>
        {
            entity.HasKey(e => e.IdConjuntoEstilos).HasName("pk_conjunto_estilos");

            entity.ToTable("conjunto_estilos");

            entity.Property(e => e.IdConjuntoEstilos)
                .ValueGeneratedNever()
                .HasColumnName("id_conjunto_estilos");
            entity.Property(e => e.SinUltimo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ultimo");
        });

        modelBuilder.Entity<ConjuntoEstilosItem>(entity =>
        {
            entity.HasKey(e => e.IdConjuntoEstilosItem).HasName("pk_conjunto_estilos_item");

            entity.ToTable("conjunto_estilos_item");

            entity.HasIndex(e => e.IdConjuntoEstilos, "fk_conj_est_item_conj_est");

            entity.Property(e => e.IdConjuntoEstilosItem)
                .ValueGeneratedNever()
                .HasColumnName("id_conjunto_estilos_item");
            entity.Property(e => e.Formatacao)
                .IsUnicode(false)
                .HasColumnName("formatacao");
            entity.Property(e => e.IdConjuntoEstilos).HasColumnName("id_conjunto_estilos");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdConjuntoEstilosNavigation).WithMany(p => p.ConjuntoEstilosItems)
                .HasForeignKey(d => d.IdConjuntoEstilos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conj_est_item_conj_est");
        });

        modelBuilder.Entity<Contato>(entity =>
        {
            entity.HasKey(e => e.IdContato).HasName("pk_contato");

            entity.ToTable("contato");

            entity.HasIndex(e => e.IdCargo, "fk_contato_cargo");

            entity.HasIndex(e => e.IdCategoria, "fk_contato_categoria");

            entity.HasIndex(e => e.IdCidade, "fk_contato_cidade");

            entity.HasIndex(e => e.IdPais, "fk_contato_pais");

            entity.HasIndex(e => e.IdPaisPassaporte, "fk_contato_pais_passaporte");

            entity.HasIndex(e => e.IdTipoContato, "fk_contato_tipo_contato");

            entity.HasIndex(e => e.IdTitulo, "fk_contato_titulo");

            entity.HasIndex(e => e.IdUf, "fk_contato_uf");

            entity.HasIndex(e => e.IdUnidadeCadastro, "fk_contato_unidade_cadastro");

            entity.HasIndex(e => e.IdUsuarioCadastro, "fk_contato_usuario_cadastro");

            entity.HasIndex(e => new { e.IdTipoContato, e.Sigla, e.Nome, e.SinAtivo }, "i01_contato");

            entity.HasIndex(e => e.Cpf, "i02_contato");

            entity.HasIndex(e => e.Cnpj, "i03_contato");

            entity.HasIndex(e => new { e.Nome, e.SinAtivo, e.Sigla }, "i11_contato");

            entity.Property(e => e.IdContato)
                .ValueGeneratedNever()
                .HasColumnName("id_contato");
            entity.Property(e => e.Bairro)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Cnpj).HasColumnName("cnpj");
            entity.Property(e => e.Complemento)
                .HasMaxLength(130)
                .IsUnicode(false)
                .HasColumnName("complemento");
            entity.Property(e => e.Conjuge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("conjuge");
            entity.Property(e => e.Cpf).HasColumnName("cpf");
            entity.Property(e => e.DtaNascimento)
                .HasColumnType("datetime")
                .HasColumnName("dta_nascimento");
            entity.Property(e => e.DthCadastro)
                .HasColumnType("datetime")
                .HasColumnName("dth_cadastro");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(130)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Funcao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("funcao");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdCidade).HasColumnName("id_cidade");
            entity.Property(e => e.IdContatoAssociado).HasColumnName("id_contato_associado");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.IdPaisPassaporte).HasColumnName("id_pais_passaporte");
            entity.Property(e => e.IdTipoContato).HasColumnName("id_tipo_contato");
            entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");
            entity.Property(e => e.IdUf).HasColumnName("id_uf");
            entity.Property(e => e.IdUnidadeCadastro).HasColumnName("id_unidade_cadastro");
            entity.Property(e => e.IdUsuarioCadastro).HasColumnName("id_usuario_cadastro");
            entity.Property(e => e.IdxContato)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("idx_contato");
            entity.Property(e => e.Matricula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("matricula");
            entity.Property(e => e.MatriculaOab)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("matricula_oab");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NomeRegistroCivil)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_registro_civil");
            entity.Property(e => e.NomeSocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome_social");
            entity.Property(e => e.NumeroPassaporte)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numero_passaporte");
            entity.Property(e => e.Observacao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observacao");
            entity.Property(e => e.OrgaoExpedidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orgao_expedidor");
            entity.Property(e => e.Rg).HasColumnName("rg");
            entity.Property(e => e.Sigla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinEnderecoAssociado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_endereco_associado");
            entity.Property(e => e.SitioInternet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sitio_internet");
            entity.Property(e => e.StaGenero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_genero");
            entity.Property(e => e.StaNatureza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_natureza");
            entity.Property(e => e.TelefoneCelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefone_celular");
            entity.Property(e => e.TelefoneComercial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("telefone_comercial");
            entity.Property(e => e.TelefoneResidencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefone_residencial");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdCargo)
                .HasConstraintName("fk_contato_cargo");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("fk_contato_categoria");

            entity.HasOne(d => d.IdCidadeNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdCidade)
                .HasConstraintName("fk_contato_cidade");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.ContatoIdPaisNavigations)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("fk_contato_pais");

            entity.HasOne(d => d.IdPaisPassaporteNavigation).WithMany(p => p.ContatoIdPaisPassaporteNavigations)
                .HasForeignKey(d => d.IdPaisPassaporte)
                .HasConstraintName("fk_contato_pais_passaporte");

            entity.HasOne(d => d.IdTipoContatoNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdTipoContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contato_tipo_contato");

            entity.HasOne(d => d.IdTituloNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdTitulo)
                .HasConstraintName("fk_contato_titulo");

            entity.HasOne(d => d.IdUfNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdUf)
                .HasConstraintName("fk_contato_uf");

            entity.HasOne(d => d.IdUnidadeCadastroNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdUnidadeCadastro)
                .HasConstraintName("fk_contato_unidade_cadastro");

            entity.HasOne(d => d.IdUsuarioCadastroNavigation).WithMany(p => p.Contatos)
                .HasForeignKey(d => d.IdUsuarioCadastro)
                .HasConstraintName("fk_contato_usuario_cadastro");

            entity.HasMany(d => d.IdGrupoContatos).WithMany(p => p.IdContatos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelGrupoContato",
                    r => r.HasOne<GrupoContato>().WithMany()
                        .HasForeignKey("IdGrupoContato")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grupo_contato_grupo_con"),
                    l => l.HasOne<Contato>().WithMany()
                        .HasForeignKey("IdContato")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grupo_contato_contato"),
                    j =>
                    {
                        j.HasKey("IdContato", "IdGrupoContato").HasName("pk_rel_grupo_contato");
                        j.ToTable("rel_grupo_contato");
                        j.HasIndex(new[] { "IdContato" }, "fk_rel_grupo_contato_contato");
                        j.HasIndex(new[] { "IdGrupoContato" }, "fk_rel_grupo_contato_grupo_con");
                        j.IndexerProperty<int>("IdContato").HasColumnName("id_contato");
                        j.IndexerProperty<int>("IdGrupoContato").HasColumnName("id_grupo_contato");
                    });
        });

        modelBuilder.Entity<ControleInterno>(entity =>
        {
            entity.HasKey(e => e.IdControleInterno).HasName("pk_controle_interno");

            entity.ToTable("controle_interno");

            entity.Property(e => e.IdControleInterno)
                .ValueGeneratedNever()
                .HasColumnName("id_controle_interno");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");

            entity.HasMany(d => d.IdOrgaos).WithMany(p => p.IdControleInternos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelControleInternoOrgao",
                    r => r.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_interno_orgao"),
                    l => l.HasOne<ControleInterno>().WithMany()
                        .HasForeignKey("IdControleInterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_interno_org_id"),
                    j =>
                    {
                        j.HasKey("IdControleInterno", "IdOrgao").HasName("pk_rel_controle_interno_orgao");
                        j.ToTable("rel_controle_interno_orgao");
                        j.HasIndex(new[] { "IdControleInterno" }, "fk_rel_controle_interno_org_id");
                        j.HasIndex(new[] { "IdOrgao" }, "fk_rel_controle_interno_orgao");
                        j.IndexerProperty<int>("IdControleInterno").HasColumnName("id_controle_interno");
                        j.IndexerProperty<int>("IdOrgao").HasColumnName("id_orgao");
                    });

            entity.HasMany(d => d.IdUnidades).WithMany(p => p.IdControleInternos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelControleInternoUnidade",
                    r => r.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_int_unid_unid"),
                    l => l.HasOne<ControleInterno>().WithMany()
                        .HasForeignKey("IdControleInterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_int_unid_ci"),
                    j =>
                    {
                        j.HasKey("IdControleInterno", "IdUnidade").HasName("pk_rel_controle_interno_unid");
                        j.ToTable("rel_controle_interno_unidade");
                        j.HasIndex(new[] { "IdControleInterno" }, "fk_rel_controle_int_unid_ci");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_rel_controle_int_unid_unid");
                        j.IndexerProperty<int>("IdControleInterno").HasColumnName("id_controle_interno");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                    });
        });

        modelBuilder.Entity<ControlePrazo>(entity =>
        {
            entity.HasKey(e => e.IdControlePrazo).HasName("pkcontrole_prazo");

            entity.ToTable("controle_prazo");

            entity.HasIndex(e => e.IdProtocolo, "fk_controle_prazo_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_controle_prazo_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_controle_prazo_usuario");

            entity.HasIndex(e => new { e.IdUnidade, e.DtaPrazo, e.DtaConclusao }, "i01_controle_prazo");

            entity.HasIndex(e => new { e.IdUnidade, e.DtaPrazo }, "i02_controle_prazo");

            entity.HasIndex(e => new { e.IdUnidade, e.DtaConclusao }, "i03_controle_prazo");

            entity.Property(e => e.IdControlePrazo)
                .ValueGeneratedNever()
                .HasColumnName("id_controle_prazo");
            entity.Property(e => e.DtaConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dta_conclusao");
            entity.Property(e => e.DtaPrazo)
                .HasColumnType("datetime")
                .HasColumnName("dta_prazo");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.ControlePrazos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_controle_prazo_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.ControlePrazos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_controle_prazo_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ControlePrazos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_controle_prazo_usuario");
        });

        modelBuilder.Entity<ControleUnidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("controle_unidade");

            entity.Property(e => e.DthExecucao)
                .HasColumnType("datetime")
                .HasColumnName("dth_execucao");
            entity.Property(e => e.DthSnapshot)
                .HasColumnType("datetime")
                .HasColumnName("dth_snapshot");
            entity.Property(e => e.IdControleUnidade).HasColumnName("id_controle_unidade");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdSituacao).HasColumnName("id_situacao");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        });

        modelBuilder.Entity<Cpad>(entity =>
        {
            entity.HasKey(e => e.IdCpad).HasName("pk_cpad");

            entity.ToTable("cpad");

            entity.HasIndex(e => e.IdOrgao, "fk_cpad_orgao");

            entity.Property(e => e.IdCpad)
                .ValueGeneratedNever()
                .HasColumnName("id_cpad");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Cpads)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_orgao");
        });

        modelBuilder.Entity<CpadAvaliacao>(entity =>
        {
            entity.HasKey(e => e.IdCpadAvaliacao).HasName("pk_cpad_avaliacao");

            entity.ToTable("cpad_avaliacao");

            entity.HasIndex(e => e.IdAvaliacaoDocumental, "fk_cpad_avaliacao_aval_doc");

            entity.HasIndex(e => e.IdCpadComposicao, "fk_cpad_avaliacao_cpad_comp");

            entity.Property(e => e.IdCpadAvaliacao)
                .ValueGeneratedNever()
                .HasColumnName("id_cpad_avaliacao");
            entity.Property(e => e.DthAvaliacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_avaliacao");
            entity.Property(e => e.IdAvaliacaoDocumental).HasColumnName("id_avaliacao_documental");
            entity.Property(e => e.IdCpadComposicao).HasColumnName("id_cpad_composicao");
            entity.Property(e => e.Justificativa)
                .IsUnicode(false)
                .HasColumnName("justificativa");
            entity.Property(e => e.Motivo)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaCpadAvaliacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_cpad_avaliacao");

            entity.HasOne(d => d.IdAvaliacaoDocumentalNavigation).WithMany(p => p.CpadAvaliacaos)
                .HasForeignKey(d => d.IdAvaliacaoDocumental)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_avaliacao_aval_doc");

            entity.HasOne(d => d.IdCpadComposicaoNavigation).WithMany(p => p.CpadAvaliacaos)
                .HasForeignKey(d => d.IdCpadComposicao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_avaliacao_cpad_comp");
        });

        modelBuilder.Entity<CpadComposicao>(entity =>
        {
            entity.HasKey(e => e.IdCpadComposicao).HasName("pk_cpad_composicao");

            entity.ToTable("cpad_composicao");

            entity.HasIndex(e => e.IdCargo, "fk_cpad_composicao_cargo");

            entity.HasIndex(e => e.IdCpadVersao, "fk_cpad_composicao_cpad_versao");

            entity.HasIndex(e => e.IdUsuario, "fk_cpad_composicao_usuario");

            entity.Property(e => e.IdCpadComposicao)
                .ValueGeneratedNever()
                .HasColumnName("id_cpad_composicao");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdCpadVersao).HasColumnName("id_cpad_versao");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.SinPresidente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_presidente");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.CpadComposicaos)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_composicao_cargo");

            entity.HasOne(d => d.IdCpadVersaoNavigation).WithMany(p => p.CpadComposicaos)
                .HasForeignKey(d => d.IdCpadVersao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_composicao_cpad_versao");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CpadComposicaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_composicao_usuario");
        });

        modelBuilder.Entity<CpadVersao>(entity =>
        {
            entity.HasKey(e => e.IdCpadVersao).HasName("pk_cpad_versao");

            entity.ToTable("cpad_versao");

            entity.HasIndex(e => e.IdCpad, "fk_cpad_versao_cpad");

            entity.HasIndex(e => e.IdUnidade, "fk_cpad_versao_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_cpad_versao_usuario");

            entity.Property(e => e.IdCpadVersao)
                .ValueGeneratedNever()
                .HasColumnName("id_cpad_versao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthVersao)
                .HasColumnType("datetime")
                .HasColumnName("dth_versao");
            entity.Property(e => e.IdCpad).HasColumnName("id_cpad");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinEditavel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_editavel");

            entity.HasOne(d => d.IdCpadNavigation).WithMany(p => p.CpadVersaos)
                .HasForeignKey(d => d.IdCpad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cpad_versao_cpad");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.CpadVersaos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_cpad_versao_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CpadVersaos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_cpad_versao_usuario");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("pk_documento");

            entity.ToTable("documento");

            entity.HasIndex(e => new { e.IdDocumento, e.IdProcedimento }, "ak_documento").IsUnique();

            entity.HasIndex(e => e.IdConjuntoEstilos, "fk_documento_conjunto_estilos");

            entity.HasIndex(e => e.IdProcedimento, "fk_documento_procedimento");

            entity.HasIndex(e => e.IdSerie, "fk_documento_serie");

            entity.HasIndex(e => e.IdTipoConferencia, "fk_documento_tipo_conferencia");

            entity.HasIndex(e => e.IdTipoFormulario, "fk_documento_tipo_formulario");

            entity.HasIndex(e => e.IdUnidadeResponsavel, "fk_documento_unidade_responsav");

            entity.HasIndex(e => new { e.IdDocumento, e.IdDocumentoEdoc }, "i02_documento");

            entity.HasIndex(e => new { e.IdDocumento, e.IdSerie, e.IdTipoFormulario, e.StaDocumento }, "i03_documento");

            entity.HasIndex(e => new { e.Numero, e.IdSerie }, "i04_documento");

            entity.HasIndex(e => new { e.IdDocumento, e.SinArquivamento }, "i06_documento");

            entity.HasIndex(e => new { e.IdDocumento, e.SinVersoes }, "i07_documento");

            entity.HasIndex(e => e.IdSerie, "if5_documento");

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.DinValor)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("din_valor");
            entity.Property(e => e.IdConjuntoEstilos).HasColumnName("id_conjunto_estilos");
            entity.Property(e => e.IdDocumentoEdoc).HasColumnName("id_documento_edoc");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdTipoConferencia).HasColumnName("id_tipo_conferencia");
            entity.Property(e => e.IdTipoFormulario).HasColumnName("id_tipo_formulario");
            entity.Property(e => e.IdUnidadeResponsavel).HasColumnName("id_unidade_responsavel");
            entity.Property(e => e.NomeArvore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome_arvore");
            entity.Property(e => e.Numero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.SinArquivamento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_arquivamento");
            entity.Property(e => e.SinBloqueado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_bloqueado");
            entity.Property(e => e.SinVersoes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_versoes");
            entity.Property(e => e.StaDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_documento");
            entity.Property(e => e.StaEditor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_editor");

            entity.HasOne(d => d.IdConjuntoEstilosNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdConjuntoEstilos)
                .HasConstraintName("fk_documento_conjunto_estilos");

            entity.HasOne(d => d.IdDocumentoNavigation).WithOne(p => p.Documento)
                .HasForeignKey<Documento>(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_documento_protocolo");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_documento_procedimento");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_documento_serie");

            entity.HasOne(d => d.IdTipoConferenciaNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdTipoConferencia)
                .HasConstraintName("fk_documento_tipo_conferencia");

            entity.HasOne(d => d.IdTipoFormularioNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdTipoFormulario)
                .HasConstraintName("fk_documento_tipo_formulario");

            entity.HasOne(d => d.IdUnidadeResponsavelNavigation).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.IdUnidadeResponsavel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_documento_unidade_responsav");

            entity.HasMany(d => d.IdItemEtapas).WithMany(p => p.IdDocumentos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelItemEtapaDocumento",
                    r => r.HasOne<ItemEtapa>().WithMany()
                        .HasForeignKey("IdItemEtapa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_doc_item_etap"),
                    l => l.HasOne<Documento>().WithMany()
                        .HasForeignKey("IdDocumento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_doc_documento"),
                    j =>
                    {
                        j.HasKey("IdDocumento", "IdItemEtapa").HasName("pk_rel_item_etapa_documento");
                        j.ToTable("rel_item_etapa_documento");
                        j.HasIndex(new[] { "IdDocumento" }, "fk_rel_item_etap_doc_documento");
                        j.HasIndex(new[] { "IdItemEtapa" }, "fk_rel_item_etap_doc_item_etap");
                        j.IndexerProperty<long>("IdDocumento").HasColumnName("id_documento");
                        j.IndexerProperty<int>("IdItemEtapa").HasColumnName("id_item_etapa");
                    });
        });

        modelBuilder.Entity<DocumentoConteudo>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("pk_documento_conteudo");

            entity.ToTable("documento_conteudo");

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.ConteudoAssinatura)
                .IsUnicode(false)
                .HasColumnName("conteudo_assinatura");
            entity.Property(e => e.CrcAssinatura)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("crc_assinatura");
            entity.Property(e => e.QrCodeAssinatura)
                .IsUnicode(false)
                .HasColumnName("qr_code_assinatura");

            entity.HasOne(d => d.IdDocumentoNavigation).WithOne(p => p.DocumentoConteudo)
                .HasForeignKey<DocumentoConteudo>(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_doc_conteudo_documento");
        });

        modelBuilder.Entity<DocumentoGeracao>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("pk_documento_geracao");

            entity.ToTable("documento_geracao");

            entity.Property(e => e.IdDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_documento");
            entity.Property(e => e.IdDocumentoModelo).HasColumnName("id_documento_modelo");
            entity.Property(e => e.IdTextoPadraoInterno).HasColumnName("id_texto_padrao_interno");

            entity.HasOne(d => d.IdDocumentoNavigation).WithOne(p => p.DocumentoGeracao)
                .HasForeignKey<DocumentoGeracao>(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_documento_geracao_documento");
        });

        modelBuilder.Entity<Dominio>(entity =>
        {
            entity.HasKey(e => e.IdDominio).HasName("pk_dominio");

            entity.ToTable("dominio");

            entity.HasIndex(e => e.IdAtributo, "fk_dominio_atributo");

            entity.Property(e => e.IdDominio)
                .ValueGeneratedNever()
                .HasColumnName("id_dominio");
            entity.Property(e => e.IdAtributo).HasColumnName("id_atributo");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.Rotulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rotulo");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinPadrao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_padrao");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.Dominios)
                .HasForeignKey(d => d.IdAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dominio_atributo");
        });

        modelBuilder.Entity<EditalEliminacao>(entity =>
        {
            entity.HasKey(e => e.IdEditalEliminacao).HasName("pk_edital_eliminacao");

            entity.ToTable("edital_eliminacao");

            entity.HasIndex(e => e.IdDocumento, "fk_edital_eliminacao_documento");

            entity.HasIndex(e => e.IdProcedimento, "fk_edital_eliminacao_proced");

            entity.HasIndex(e => e.IdUnidade, "fk_edital_eliminacao_unidade");

            entity.Property(e => e.IdEditalEliminacao)
                .ValueGeneratedNever()
                .HasColumnName("id_edital_eliminacao");
            entity.Property(e => e.DtaPublicacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_publicacao");
            entity.Property(e => e.Especificacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("especificacao");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.StaEditalEliminacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_edital_eliminacao");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.EditalEliminacaos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("fk_edital_eliminacao_documento");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.EditalEliminacaos)
                .HasForeignKey(d => d.IdProcedimento)
                .HasConstraintName("fk_edital_eliminacao_proced");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.EditalEliminacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edital_eliminacao_unidade");
        });

        modelBuilder.Entity<EditalEliminacaoConteudo>(entity =>
        {
            entity.HasKey(e => e.IdEditalEliminacaoConteudo).HasName("pk_edital_eliminacao_conteudo");

            entity.ToTable("edital_eliminacao_conteudo");

            entity.HasIndex(e => e.IdUsuarioInclusao, "fk_edital_elim_cont_usu_inclus");

            entity.HasIndex(e => e.IdAvaliacaoDocumental, "fk_rel_aval_doc_ed_eli_av_doc");

            entity.HasIndex(e => e.IdEditalEliminacao, "fk_rel_aval_doc_ed_eli_ed_eli");

            entity.Property(e => e.IdEditalEliminacaoConteudo)
                .ValueGeneratedNever()
                .HasColumnName("id_edital_eliminacao_conteudo");
            entity.Property(e => e.DthInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dth_inclusao");
            entity.Property(e => e.IdAvaliacaoDocumental).HasColumnName("id_avaliacao_documental");
            entity.Property(e => e.IdEditalEliminacao).HasColumnName("id_edital_eliminacao");
            entity.Property(e => e.IdUsuarioInclusao).HasColumnName("id_usuario_inclusao");

            entity.HasOne(d => d.IdAvaliacaoDocumentalNavigation).WithMany(p => p.EditalEliminacaoConteudos)
                .HasForeignKey(d => d.IdAvaliacaoDocumental)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_aval_doc_ed_eli_av_doc");

            entity.HasOne(d => d.IdEditalEliminacaoNavigation).WithMany(p => p.EditalEliminacaoConteudos)
                .HasForeignKey(d => d.IdEditalEliminacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_aval_doc_ed_eli_ed_eli");

            entity.HasOne(d => d.IdUsuarioInclusaoNavigation).WithMany(p => p.EditalEliminacaoConteudos)
                .HasForeignKey(d => d.IdUsuarioInclusao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edital_elim_cont_usu_inclus");
        });

        modelBuilder.Entity<EditalEliminacaoErro>(entity =>
        {
            entity.HasKey(e => e.IdEditalEliminacaoErro).HasName("pk_edital_eliminacao_erro");

            entity.ToTable("edital_eliminacao_erro");

            entity.HasIndex(e => e.IdEditalEliminacaoConteudo, "fk_edit_elim_erro_edit_eli_con");

            entity.Property(e => e.IdEditalEliminacaoErro)
                .ValueGeneratedNever()
                .HasColumnName("id_edital_eliminacao_erro");
            entity.Property(e => e.DthErro)
                .HasColumnType("datetime")
                .HasColumnName("dth_erro");
            entity.Property(e => e.IdEditalEliminacaoConteudo).HasColumnName("id_edital_eliminacao_conteudo");
            entity.Property(e => e.TextoErro)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("texto_erro");

            entity.HasOne(d => d.IdEditalEliminacaoConteudoNavigation).WithMany(p => p.EditalEliminacaoErros)
                .HasForeignKey(d => d.IdEditalEliminacaoConteudo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_edit_elim_erro_edit_eli_con");
        });

        modelBuilder.Entity<EmailGrupoEmail>(entity =>
        {
            entity.HasKey(e => e.IdEmailGrupoEmail).HasName("pk_email_grupo_email");

            entity.ToTable("email_grupo_email");

            entity.HasIndex(e => e.IdGrupoEmail, "fk_email_grupo_email_grupo_em");

            entity.Property(e => e.IdEmailGrupoEmail)
                .ValueGeneratedNever()
                .HasColumnName("id_email_grupo_email");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdGrupoEmail).HasColumnName("id_grupo_email");
            entity.Property(e => e.IdxEmailGrupoEmail)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("idx_email_grupo_email");

            entity.HasOne(d => d.IdGrupoEmailNavigation).WithMany(p => p.EmailGrupoEmails)
                .HasForeignKey(d => d.IdGrupoEmail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_email_grupo_email_grupo_em");
        });

        modelBuilder.Entity<EmailSistema>(entity =>
        {
            entity.HasKey(e => e.IdEmailSistema).HasName("pk_email_sistema");

            entity.ToTable("email_sistema");

            entity.HasIndex(e => e.IdEmailSistemaModulo, "i01_email_sistema");

            entity.Property(e => e.IdEmailSistema)
                .ValueGeneratedNever()
                .HasColumnName("id_email_sistema");
            entity.Property(e => e.Assunto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("assunto");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.De)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("de");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEmailSistemaModulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_email_sistema_modulo");
            entity.Property(e => e.Para)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("para");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<EmailUnidade>(entity =>
        {
            entity.HasKey(e => e.IdEmailUnidade).HasName("pk_email_unidade");

            entity.ToTable("email_unidade");

            entity.HasIndex(e => e.IdUnidade, "fk_email_unidade_unidade");

            entity.Property(e => e.IdEmailUnidade)
                .ValueGeneratedNever()
                .HasColumnName("id_email_unidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.EmailUnidades)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_email_unidade_unidade");
        });

        modelBuilder.Entity<EmailUtilizado>(entity =>
        {
            entity.HasKey(e => e.IdEmailUtilizado).HasName("pk_email_utilizado");

            entity.ToTable("email_utilizado");

            entity.HasIndex(e => e.IdUnidade, "fk_email_utilizado_unidade");

            entity.Property(e => e.IdEmailUtilizado)
                .ValueGeneratedNever()
                .HasColumnName("id_email_utilizado");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.EmailUtilizados)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_email_utilizado_unidade");
        });

        modelBuilder.Entity<Estatistica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("estatisticas");

            entity.HasIndex(e => e.IdEstatisticas, "i01_estatisticas");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.DthAbertura)
                .HasColumnType("datetime")
                .HasColumnName("dth_abertura");
            entity.Property(e => e.DthConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dth_conclusao");
            entity.Property(e => e.DthSnapshot)
                .HasColumnType("datetime")
                .HasColumnName("dth_snapshot");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdEstatisticas).HasColumnName("id_estatisticas");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.TempoAberto).HasColumnName("tempo_aberto");
        });

        modelBuilder.Entity<Estilo>(entity =>
        {
            entity.HasKey(e => e.IdEstilo).HasName("pk_estilo");

            entity.ToTable("estilo");

            entity.Property(e => e.IdEstilo)
                .ValueGeneratedNever()
                .HasColumnName("id_estilo");
            entity.Property(e => e.Formatacao)
                .IsUnicode(false)
                .HasColumnName("formatacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<EtapaTrabalho>(entity =>
        {
            entity.HasKey(e => e.IdEtapaTrabalho).HasName("pk_etapa_trabalho");

            entity.ToTable("etapa_trabalho");

            entity.HasIndex(e => e.IdPlanoTrabalho, "fk_etapa_trab_plano_trab");

            entity.Property(e => e.IdEtapaTrabalho)
                .ValueGeneratedNever()
                .HasColumnName("id_etapa_trabalho");
            entity.Property(e => e.Descricao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdPlanoTrabalho).HasColumnName("id_plano_trabalho");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdPlanoTrabalhoNavigation).WithMany(p => p.EtapaTrabalhos)
                .HasForeignKey(d => d.IdPlanoTrabalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_etapa_trab_plano_trab");
        });

        modelBuilder.Entity<Feed>(entity =>
        {
            entity.HasKey(e => e.IdFeed).HasName("pk_feed");

            entity.ToTable("feed");

            entity.Property(e => e.IdFeed)
                .ValueGeneratedNever()
                .HasColumnName("id_feed");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
        });

        modelBuilder.Entity<Feriado>(entity =>
        {
            entity.HasKey(e => e.IdFeriado).HasName("pk_feriado");

            entity.ToTable("feriado");

            entity.HasIndex(e => e.IdOrgao, "fk_feriado_orgao");

            entity.Property(e => e.IdFeriado)
                .ValueGeneratedNever()
                .HasColumnName("id_feriado");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DtaFeriado)
                .HasColumnType("datetime")
                .HasColumnName("dta_feriado");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Feriados)
                .HasForeignKey(d => d.IdOrgao)
                .HasConstraintName("fk_feriado_orgao");
        });

        modelBuilder.Entity<GrupoAcompanhamento>(entity =>
        {
            entity.HasKey(e => e.IdGrupoAcompanhamento).HasName("pk_grupo_acompanhamento");

            entity.ToTable("grupo_acompanhamento");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_acompanhamento_unidad");

            entity.Property(e => e.IdGrupoAcompanhamento)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_acompanhamento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoAcompanhamentos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_acompanhamento_unidad");
        });

        modelBuilder.Entity<GrupoBloco>(entity =>
        {
            entity.HasKey(e => e.IdGrupoBloco).HasName("pk_grupo_bloco");

            entity.ToTable("grupo_bloco");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_bloco_unidade");

            entity.Property(e => e.IdGrupoBloco)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_bloco");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoBlocos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_bloco_unidade");

            entity.HasMany(d => d.IdUsuarios).WithMany(p => p.IdGrupoBlocos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelUsuarioGrupoBloco",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usu_grupo_bloco_usuario"),
                    l => l.HasOne<GrupoBloco>().WithMany()
                        .HasForeignKey("IdGrupoBloco")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usu_grupo_bloco_grp_blo"),
                    j =>
                    {
                        j.HasKey("IdGrupoBloco", "IdUsuario").HasName("pk_rel_usuario_grupo_bloco");
                        j.ToTable("rel_usuario_grupo_bloco");
                        j.HasIndex(new[] { "IdGrupoBloco" }, "fk_rel_usu_grupo_bloco_grp_blo");
                        j.HasIndex(new[] { "IdUsuario" }, "fk_rel_usu_grupo_bloco_usuario");
                        j.IndexerProperty<int>("IdGrupoBloco").HasColumnName("id_grupo_bloco");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("id_usuario");
                    });
        });

        modelBuilder.Entity<GrupoContato>(entity =>
        {
            entity.HasKey(e => e.IdGrupoContato).HasName("pk_grupo_contato");

            entity.ToTable("grupo_contato");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_contato_unidade");

            entity.Property(e => e.IdGrupoContato)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_contato");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoContatos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_contato_unidade");
        });

        modelBuilder.Entity<GrupoEmail>(entity =>
        {
            entity.HasKey(e => e.IdGrupoEmail).HasName("pk_grupo_email");

            entity.ToTable("grupo_email");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_email_unidade");

            entity.Property(e => e.IdGrupoEmail)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_email");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoEmails)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_email_unidade");
        });

        modelBuilder.Entity<GrupoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdGrupoFederacao).HasName("pk_grupo_federacao");

            entity.ToTable("grupo_federacao");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_federacao_unidade");

            entity.Property(e => e.IdGrupoFederacao)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_federacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoFederacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_federacao_unidade");

            entity.HasMany(d => d.IdOrgaoFederacaos).WithMany(p => p.IdGrupoFederacaos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelGrupoFedOrgaoFed",
                    r => r.HasOne<OrgaoFederacao>().WithMany()
                        .HasForeignKey("IdOrgaoFederacao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grp_fed_org_fed_org_fed"),
                    l => l.HasOne<GrupoFederacao>().WithMany()
                        .HasForeignKey("IdGrupoFederacao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grp_fed_org_fed_grp_fed"),
                    j =>
                    {
                        j.HasKey("IdGrupoFederacao", "IdOrgaoFederacao").HasName("pk_rel_grupo_fed_orgao_fed");
                        j.ToTable("rel_grupo_fed_orgao_fed");
                        j.HasIndex(new[] { "IdGrupoFederacao" }, "fk_rel_grp_fed_org_fed_grp_fed");
                        j.HasIndex(new[] { "IdOrgaoFederacao" }, "fk_rel_grp_fed_org_fed_org_fed");
                        j.IndexerProperty<int>("IdGrupoFederacao").HasColumnName("id_grupo_federacao");
                        j.IndexerProperty<string>("IdOrgaoFederacao")
                            .HasMaxLength(26)
                            .IsUnicode(false)
                            .HasColumnName("id_orgao_federacao");
                    });
        });

        modelBuilder.Entity<GrupoProtocoloModelo>(entity =>
        {
            entity.HasKey(e => e.IdGrupoProtocoloModelo).HasName("pk_grupo_protocolo_modelo");

            entity.ToTable("grupo_protocolo_modelo");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_protocolo_modelo_unid");

            entity.Property(e => e.IdGrupoProtocoloModelo)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_protocolo_modelo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoProtocoloModelos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_protocolo_modelo_unid");
        });

        modelBuilder.Entity<GrupoSerie>(entity =>
        {
            entity.HasKey(e => e.IdGrupoSerie).HasName("pk_grupo_serie");

            entity.ToTable("grupo_serie");

            entity.Property(e => e.IdGrupoSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_serie");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<GrupoUnidade>(entity =>
        {
            entity.HasKey(e => e.IdGrupoUnidade).HasName("pk_grupo_unidade");

            entity.ToTable("grupo_unidade");

            entity.HasIndex(e => e.IdUnidade, "fk_grupo_unidade_unidade");

            entity.Property(e => e.IdGrupoUnidade)
                .ValueGeneratedNever()
                .HasColumnName("id_grupo_unidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.GrupoUnidades)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grupo_unidade_unidade");
        });

        modelBuilder.Entity<HipoteseLegal>(entity =>
        {
            entity.HasKey(e => e.IdHipoteseLegal).HasName("pk_hipotese_legal");

            entity.ToTable("hipotese_legal");

            entity.Property(e => e.IdHipoteseLegal)
                .ValueGeneratedNever()
                .HasColumnName("id_hipotese_legal");
            entity.Property(e => e.BaseLegal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("base_legal");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaNivelAcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso");
        });

        modelBuilder.Entity<ImagemFormato>(entity =>
        {
            entity.HasKey(e => e.IdImagemFormato).HasName("pk_imagem_formato");

            entity.ToTable("imagem_formato");

            entity.Property(e => e.IdImagemFormato)
                .ValueGeneratedNever()
                .HasColumnName("id_imagem_formato");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Formato)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("formato");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<InfraAgendamentoTarefa>(entity =>
        {
            entity.HasKey(e => e.IdInfraAgendamentoTarefa).HasName("pk_infra_agendamento_tarefa");

            entity.ToTable("infra_agendamento_tarefa");

            entity.Property(e => e.IdInfraAgendamentoTarefa)
                .ValueGeneratedNever()
                .HasColumnName("id_infra_agendamento_tarefa");
            entity.Property(e => e.Comando)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("comando");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthUltimaConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dth_ultima_conclusao");
            entity.Property(e => e.DthUltimaExecucao)
                .HasColumnType("datetime")
                .HasColumnName("dth_ultima_execucao");
            entity.Property(e => e.EmailErro)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email_erro");
            entity.Property(e => e.Parametro)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("parametro");
            entity.Property(e => e.PeriodicidadeComplemento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("periodicidade_complemento");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinSucesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_sucesso");
            entity.Property(e => e.StaPeriodicidadeExecucao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_periodicidade_execucao");
        });

        modelBuilder.Entity<InfraAuditorium>(entity =>
        {
            entity.HasKey(e => e.IdInfraAuditoria).HasName("pk_infra_auditoria");

            entity.ToTable("infra_auditoria");

            entity.HasIndex(e => e.Recurso, "i01_infra_auditoria");

            entity.HasIndex(e => e.DthAcesso, "i02_infra_auditoria");

            entity.HasIndex(e => e.SiglaUsuario, "i03_infra_auditoria");

            entity.HasIndex(e => e.SiglaUnidade, "i04_infra_auditoria");

            entity.HasIndex(e => e.IdUsuario, "i05_infra_auditoria");

            entity.Property(e => e.IdInfraAuditoria)
                .ValueGeneratedNever()
                .HasColumnName("id_infra_auditoria");
            entity.Property(e => e.DescricaoUnidade)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao_unidade");
            entity.Property(e => e.DthAcesso)
                .HasColumnType("datetime")
                .HasColumnName("dth_acesso");
            entity.Property(e => e.IdOrgaoUnidade).HasColumnName("id_orgao_unidade");
            entity.Property(e => e.IdOrgaoUsuario).HasColumnName("id_orgao_usuario");
            entity.Property(e => e.IdOrgaoUsuarioEmulador).HasColumnName("id_orgao_usuario_emulador");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioEmulador).HasColumnName("id_usuario_emulador");
            entity.Property(e => e.Ip)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.NomeUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_usuario");
            entity.Property(e => e.NomeUsuarioEmulador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_usuario_emulador");
            entity.Property(e => e.Operacao)
                .IsUnicode(false)
                .HasColumnName("operacao");
            entity.Property(e => e.Recurso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recurso");
            entity.Property(e => e.Requisicao)
                .IsUnicode(false)
                .HasColumnName("requisicao");
            entity.Property(e => e.Servidor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("servidor");
            entity.Property(e => e.SiglaOrgaoUnidade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla_orgao_unidade");
            entity.Property(e => e.SiglaOrgaoUsuario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla_orgao_usuario");
            entity.Property(e => e.SiglaOrgaoUsuarioEmulador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla_orgao_usuario_emulador");
            entity.Property(e => e.SiglaUnidade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla_unidade");
            entity.Property(e => e.SiglaUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sigla_usuario");
            entity.Property(e => e.SiglaUsuarioEmulador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sigla_usuario_emulador");
            entity.Property(e => e.UserAgent)
                .IsUnicode(false)
                .HasColumnName("user_agent");
        });

        modelBuilder.Entity<InfraCaptcha>(entity =>
        {
            entity.HasKey(e => new { e.Identificacao, e.Dia, e.Mes, e.Ano }).HasName("pk_infra_captcha");

            entity.ToTable("infra_captcha");

            entity.Property(e => e.Identificacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identificacao");
            entity.Property(e => e.Dia).HasColumnName("dia");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Acertos).HasColumnName("acertos");
            entity.Property(e => e.Erros).HasColumnName("erros");
        });

        modelBuilder.Entity<InfraCaptchaTentativa>(entity =>
        {
            entity.HasKey(e => new { e.Identificacao, e.IdUsuarioOrigem }).HasName("pk_infra_captcha_tentativa");

            entity.ToTable("infra_captcha_tentativa");

            entity.Property(e => e.Identificacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identificacao");
            entity.Property(e => e.IdUsuarioOrigem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_usuario_origem");
            entity.Property(e => e.DthTentativa)
                .HasColumnType("datetime")
                .HasColumnName("dth_tentativa");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Tentativas).HasColumnName("tentativas");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("user_agent");
        });

        modelBuilder.Entity<InfraDadoUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.Nome }).HasName("pk_infra_dado_usuario");

            entity.ToTable("infra_dado_usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<InfraErroPhp>(entity =>
        {
            entity.HasKey(e => e.IdInfraErroPhp).HasName("pk_infra_erro_php");

            entity.ToTable("infra_erro_php");

            entity.Property(e => e.IdInfraErroPhp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("id_infra_erro_php");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("arquivo");
            entity.Property(e => e.DthCadastro)
                .HasColumnType("datetime")
                .HasColumnName("dth_cadastro");
            entity.Property(e => e.Erro)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("erro");
            entity.Property(e => e.Linha).HasColumnName("linha");
            entity.Property(e => e.StaTipo).HasColumnName("sta_tipo");
        });

        modelBuilder.Entity<InfraLog>(entity =>
        {
            entity.HasKey(e => e.IdInfraLog).HasName("pk_infra_log");

            entity.ToTable("infra_log");

            entity.HasIndex(e => new { e.StaTipo, e.DthLog }, "i01_infra_log");

            entity.Property(e => e.IdInfraLog)
                .ValueGeneratedNever()
                .HasColumnName("id_infra_log");
            entity.Property(e => e.DthLog)
                .HasColumnType("datetime")
                .HasColumnName("dth_log");
            entity.Property(e => e.Ip)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");
            entity.Property(e => e.TextoLog)
                .IsUnicode(false)
                .HasColumnName("texto_log");
        });

        modelBuilder.Entity<InfraNavegador>(entity =>
        {
            entity.HasKey(e => e.IdInfraNavegador).HasName("pk_infra_navegador");

            entity.ToTable("infra_navegador");

            entity.HasIndex(e => e.DthAcesso, "i01_infra_navegador");

            entity.Property(e => e.IdInfraNavegador)
                .ValueGeneratedNever()
                .HasColumnName("id_infra_navegador");
            entity.Property(e => e.DthAcesso)
                .HasColumnType("datetime")
                .HasColumnName("dth_acesso");
            entity.Property(e => e.Identificacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identificacao");
            entity.Property(e => e.Ip)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("user_agent");
            entity.Property(e => e.Versao)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<InfraParametro>(entity =>
        {
            entity.HasKey(e => e.Nome).HasName("pk_infra_parametro");

            entity.ToTable("infra_parametro");

            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<InfraRegraAuditoriaRecurso>(entity =>
        {
            entity.HasKey(e => new { e.IdInfraRegraAuditoria, e.Recurso }).HasName("pk_infra_regra_auditoria_rec");

            entity.ToTable("infra_regra_auditoria_recurso");

            entity.HasIndex(e => e.IdInfraRegraAuditoria, "fk_inf_reg_aud_rec_inf_reg_aud");

            entity.Property(e => e.IdInfraRegraAuditoria).HasColumnName("id_infra_regra_auditoria");
            entity.Property(e => e.Recurso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recurso");

            entity.HasOne(d => d.IdInfraRegraAuditoriaNavigation).WithMany(p => p.InfraRegraAuditoriaRecursos)
                .HasForeignKey(d => d.IdInfraRegraAuditoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inf_reg_aud_rec_inf_reg_aud");
        });

        modelBuilder.Entity<InfraRegraAuditorium>(entity =>
        {
            entity.HasKey(e => e.IdInfraRegraAuditoria).HasName("pk_infra_regra_auditoria");

            entity.ToTable("infra_regra_auditoria");

            entity.Property(e => e.IdInfraRegraAuditoria)
                .ValueGeneratedNever()
                .HasColumnName("id_infra_regra_auditoria");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<InfraSequencium>(entity =>
        {
            entity.HasKey(e => e.NomeTabela).HasName("pk_infra_sequencia");

            entity.ToTable("infra_sequencia");

            entity.HasIndex(e => new { e.NomeTabela, e.NumAtual, e.QtdIncremento, e.NumMaximo }, "i01_infra_sequencia");

            entity.Property(e => e.NomeTabela)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nome_tabela");
            entity.Property(e => e.NumAtual).HasColumnName("num_atual");
            entity.Property(e => e.NumMaximo).HasColumnName("num_maximo");
            entity.Property(e => e.QtdIncremento).HasColumnName("qtd_incremento");
        });

        modelBuilder.Entity<InstalacaoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdInstalacaoFederacao).HasName("pk_instalacao_federacao");

            entity.ToTable("instalacao_federacao");

            entity.HasIndex(e => e.Cnpj, "ak_cnjp").IsUnique();

            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.ChavePrivada)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("chave_privada");
            entity.Property(e => e.ChavePublicaLocal)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("chave_publica_local");
            entity.Property(e => e.ChavePublicaRemota)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("chave_publica_remota");
            entity.Property(e => e.Cnpj).HasColumnName("cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaAgendamento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_agendamento");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");
        });

        modelBuilder.Entity<ItemEtapa>(entity =>
        {
            entity.HasKey(e => e.IdItemEtapa).HasName("pk_item_etapa");

            entity.ToTable("item_etapa");

            entity.HasIndex(e => e.IdEtapaTrabalho, "fk_item_etapa_etapa_trabalho");

            entity.Property(e => e.IdItemEtapa)
                .ValueGeneratedNever()
                .HasColumnName("id_item_etapa");
            entity.Property(e => e.Descricao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEtapaTrabalho).HasColumnName("id_etapa_trabalho");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdEtapaTrabalhoNavigation).WithMany(p => p.ItemEtapas)
                .HasForeignKey(d => d.IdEtapaTrabalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_item_etapa_etapa_trabalho");
        });

        modelBuilder.Entity<Lembrete>(entity =>
        {
            entity.HasKey(e => e.IdLembrete).HasName("pk_lembrete");

            entity.ToTable("lembrete");

            entity.HasIndex(e => e.IdUsuario, "fk_lembrete_usuario");

            entity.Property(e => e.IdLembrete)
                .ValueGeneratedNever()
                .HasColumnName("id_lembrete");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.Cor)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cor");
            entity.Property(e => e.CorTexto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cor_texto");
            entity.Property(e => e.DthLembrete)
                .HasColumnType("datetime")
                .HasColumnName("dth_lembrete");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Largura).HasColumnName("largura");
            entity.Property(e => e.PosicaoX).HasColumnName("posicao_x");
            entity.Property(e => e.PosicaoY).HasColumnName("posicao_y");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Lembretes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lembrete_usuario");
        });

        modelBuilder.Entity<Localizador>(entity =>
        {
            entity.HasKey(e => e.IdLocalizador).HasName("pk_localizador");

            entity.ToTable("localizador");

            entity.HasIndex(e => new { e.IdUnidade, e.SeqLocalizador, e.IdTipoLocalizador }, "ak1_localizador").IsUnique();

            entity.HasIndex(e => e.IdLugarLocalizador, "fk_localizador_lugar_localizad");

            entity.HasIndex(e => e.IdTipoLocalizador, "fk_localizador_tipo_localizado");

            entity.HasIndex(e => e.IdTipoSuporte, "fk_localizador_tipo_suporte");

            entity.HasIndex(e => e.IdUnidade, "fk_localizador_unidade");

            entity.Property(e => e.IdLocalizador)
                .ValueGeneratedNever()
                .HasColumnName("id_localizador");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("complemento");
            entity.Property(e => e.IdLugarLocalizador).HasColumnName("id_lugar_localizador");
            entity.Property(e => e.IdTipoLocalizador).HasColumnName("id_tipo_localizador");
            entity.Property(e => e.IdTipoSuporte).HasColumnName("id_tipo_suporte");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.SeqLocalizador).HasColumnName("seq_localizador");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");

            entity.HasOne(d => d.IdLugarLocalizadorNavigation).WithMany(p => p.Localizadors)
                .HasForeignKey(d => d.IdLugarLocalizador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localizador_lugar_localizad");

            entity.HasOne(d => d.IdTipoLocalizadorNavigation).WithMany(p => p.Localizadors)
                .HasForeignKey(d => d.IdTipoLocalizador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localizador_tipo_localizado");

            entity.HasOne(d => d.IdTipoSuporteNavigation).WithMany(p => p.Localizadors)
                .HasForeignKey(d => d.IdTipoSuporte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localizador_tipo_suporte");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Localizadors)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localizador_unidade");
        });

        modelBuilder.Entity<LugarLocalizador>(entity =>
        {
            entity.HasKey(e => e.IdLugarLocalizador).HasName("pk_lugar_localizador");

            entity.ToTable("lugar_localizador");

            entity.HasIndex(e => new { e.Nome, e.IdUnidade }, "ak1_lugar_localizador").IsUnique();

            entity.HasIndex(e => e.IdUnidade, "fk_lugar_localizador_unidade");

            entity.Property(e => e.IdLugarLocalizador)
                .ValueGeneratedNever()
                .HasColumnName("id_lugar_localizador");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.LugarLocalizadors)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lugar_localizador_unidade");
        });

        modelBuilder.Entity<Marcador>(entity =>
        {
            entity.HasKey(e => e.IdMarcador).HasName("pk_marcador");

            entity.ToTable("marcador");

            entity.HasIndex(e => e.IdUnidade, "fk_marcador_unidade");

            entity.Property(e => e.IdMarcador)
                .ValueGeneratedNever()
                .HasColumnName("id_marcador");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaIcone)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("sta_icone");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Marcadors)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_marcador_unidade");

            entity.HasMany(d => d.IdUsuarios).WithMany(p => p.IdMarcadors)
                .UsingEntity<Dictionary<string, object>>(
                    "RelUsuarioMarcador",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usuario_marcad_usuario"),
                    l => l.HasOne<Marcador>().WithMany()
                        .HasForeignKey("IdMarcador")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usuario_marcad_marcad"),
                    j =>
                    {
                        j.HasKey("IdMarcador", "IdUsuario").HasName("pk_rel_usuario_marcad_usuario");
                        j.ToTable("rel_usuario_marcador");
                        j.HasIndex(new[] { "IdMarcador" }, "fk_rel_usuario_marcad_marcad");
                        j.HasIndex(new[] { "IdUsuario" }, "fk_rel_usuario_marcad_usuario");
                        j.IndexerProperty<int>("IdMarcador").HasColumnName("id_marcador");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("id_usuario");
                    });
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("pk_modelo");

            entity.ToTable("modelo");

            entity.Property(e => e.IdModelo)
                .ValueGeneratedNever()
                .HasColumnName("id_modelo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<MonitoramentoServico>(entity =>
        {
            entity.HasKey(e => e.IdMonitoramentoServico).HasName("pk_monitoramento_servico");

            entity.ToTable("monitoramento_servico");

            entity.HasIndex(e => e.IdServico, "fk_monitoram_servico_servico");

            entity.HasIndex(e => e.DthAcesso, "i01_monitoramento_servico");

            entity.HasIndex(e => e.Operacao, "i02_monitoramento_servico");

            entity.Property(e => e.IdMonitoramentoServico)
                .ValueGeneratedNever()
                .HasColumnName("id_monitoramento_servico");
            entity.Property(e => e.DthAcesso)
                .HasColumnType("datetime")
                .HasColumnName("dth_acesso");
            entity.Property(e => e.IdServico).HasColumnName("id_servico");
            entity.Property(e => e.IpAcesso)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("ip_acesso");
            entity.Property(e => e.Operacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("operacao");
            entity.Property(e => e.Servidor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("servidor");
            entity.Property(e => e.TempoExecucao).HasColumnName("tempo_execucao");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("user_agent");

            entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.MonitoramentoServicos)
                .HasForeignKey(d => d.IdServico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_monitoram_servico_servico");
        });

        modelBuilder.Entity<NivelAcessoPermitido>(entity =>
        {
            entity.HasKey(e => e.IdNivelAcessoPermitido).HasName("pk_nivel_acesso_permitido");

            entity.ToTable("nivel_acesso_permitido");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_nivel_acesso_perm_tipo_proc");

            entity.Property(e => e.IdNivelAcessoPermitido)
                .ValueGeneratedNever()
                .HasColumnName("id_nivel_acesso_permitido");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.StaNivelAcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.NivelAcessoPermitidos)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_nivel_acesso_perm_tipo_proc");
        });

        modelBuilder.Entity<Notificacao>(entity =>
        {
            entity.HasKey(e => e.IdNotificacao).HasName("pk_notificacao");

            entity.ToTable("notificacao");

            entity.HasIndex(e => e.IdAtividadeConfirmacao, "fk_notificacao_atividade_confi");

            entity.HasIndex(e => e.IdProcedimento, "fk_notificacao_procedimento");

            entity.HasIndex(e => e.IdUnidade, "fk_notificacao_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_notificacao_usuario");

            entity.Property(e => e.IdNotificacao)
                .ValueGeneratedNever()
                .HasColumnName("id_notificacao");
            entity.Property(e => e.DthGeracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_geracao");
            entity.Property(e => e.IdAtividadeConfirmacao).HasColumnName("id_atividade_confirmacao");
            entity.Property(e => e.IdProcedimento).HasColumnName("id_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdAtividadeConfirmacaoNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdAtividadeConfirmacao)
                .HasConstraintName("fk_notificacao_atividade_confi");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notificacao_procedimento");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notificacao_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notificacao_usuario");
        });

        modelBuilder.Entity<Novidade>(entity =>
        {
            entity.HasKey(e => e.IdNovidade).HasName("pk_novidade");

            entity.ToTable("novidade");

            entity.HasIndex(e => e.IdUsuario, "fk_novidade_usuario");

            entity.Property(e => e.IdNovidade)
                .ValueGeneratedNever()
                .HasColumnName("id_novidade");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthLiberacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_liberacao");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Novidades)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_novidade_usuario");
        });

        modelBuilder.Entity<Numeracao>(entity =>
        {
            entity.HasKey(e => e.IdNumeracao).HasName("pk_numeracao");

            entity.ToTable("numeracao");

            entity.HasIndex(e => new { e.Ano, e.IdSerie, e.IdOrgao, e.IdUnidade }, "ak_numeracao").IsUnique();

            entity.HasIndex(e => e.IdOrgao, "fk_numeracao_orgao");

            entity.HasIndex(e => e.IdSerie, "fk_numeracao_serie");

            entity.HasIndex(e => e.IdUnidade, "fk_numeracao_unidade");

            entity.Property(e => e.IdNumeracao)
                .ValueGeneratedNever()
                .HasColumnName("id_numeracao");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Sequencial).HasColumnName("sequencial");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Numeracaos)
                .HasForeignKey(d => d.IdOrgao)
                .HasConstraintName("fk_numeracao_orgao");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.Numeracaos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_numeracao_serie");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Numeracaos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_numeracao_unidade");
        });

        modelBuilder.Entity<Observacao>(entity =>
        {
            entity.HasKey(e => e.IdObservacao).HasName("pk_observacao");

            entity.ToTable("observacao");

            entity.HasIndex(e => new { e.IdUnidade, e.IdProtocolo }, "ak1_observacao").IsUnique();

            entity.HasIndex(e => e.IdProtocolo, "fk_observacao_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_observacao_unidade");

            entity.Property(e => e.IdObservacao)
                .ValueGeneratedNever()
                .HasColumnName("id_observacao");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdxObservacao)
                .IsUnicode(false)
                .HasColumnName("idx_observacao");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Observacaos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_observacao_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Observacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_observacao_unidade");
        });

        modelBuilder.Entity<OperacaoServico>(entity =>
        {
            entity.HasKey(e => e.IdOperacaoServico).HasName("pk_operacao_servico");

            entity.ToTable("operacao_servico");

            entity.HasIndex(e => e.IdSerie, "fk_oper_serv_serie");

            entity.HasIndex(e => e.IdServico, "fk_oper_serv_servico");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_oper_serv_tipo_proc");

            entity.HasIndex(e => e.IdUnidade, "fk_oper_serv_unidade");

            entity.Property(e => e.IdOperacaoServico)
                .ValueGeneratedNever()
                .HasColumnName("id_operacao_servico");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdServico).HasColumnName("id_servico");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.StaOperacaoServico).HasColumnName("sta_operacao_servico");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.OperacaoServicos)
                .HasForeignKey(d => d.IdSerie)
                .HasConstraintName("fk_oper_serv_serie");

            entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.OperacaoServicos)
                .HasForeignKey(d => d.IdServico)
                .HasConstraintName("fk_oper_serv_servico");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.OperacaoServicos)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .HasConstraintName("fk_oper_serv_tipo_proc");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.OperacaoServicos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_oper_serv_unidade");
        });

        modelBuilder.Entity<OrdenadorDespesa>(entity =>
        {
            entity.HasKey(e => e.IdOrdenadorDespesa).HasName("pk_ordenador_despesa");

            entity.ToTable("ordenador_despesa");

            entity.HasIndex(e => e.IdOrgao, "fk_ordenador_despesa_orgao");

            entity.HasIndex(e => e.IdUnidade, "fk_ordenador_despesa_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_ordenador_despesa_usuario");

            entity.Property(e => e.IdOrdenadorDespesa)
                .ValueGeneratedNever()
                .HasColumnName("id_ordenador_despesa");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.SinPadrao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_padrao");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.OrdenadorDespesas)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ordenador_despesa_orgao");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.OrdenadorDespesas)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ordenador_despesa_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.OrdenadorDespesas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ordenador_despesa_usuario");
        });

        modelBuilder.Entity<Orgao>(entity =>
        {
            entity.HasKey(e => e.IdOrgao).HasName("pk_orgao");

            entity.ToTable("orgao");

            entity.HasIndex(e => e.IdContato, "fk_orgao_contato");

            entity.HasIndex(e => e.IdOrgaoFederacao, "fk_orgao_orgao_federacao");

            entity.HasIndex(e => e.IdUnidade, "fk_orgao_unidade");

            entity.Property(e => e.IdOrgao)
                .ValueGeneratedNever()
                .HasColumnName("id_orgao");
            entity.Property(e => e.CodigoSei)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_sei");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdContato).HasColumnName("id_contato");
            entity.Property(e => e.IdOrgaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_orgao_federacao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdxOrgao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("idx_orgao");
            entity.Property(e => e.Numeracao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("numeracao");
            entity.Property(e => e.ServidorCorretorOrtografico)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("servidor_corretor_ortografico");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinConsultaProcessual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_consulta_processual");
            entity.Property(e => e.SinEnvioProcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_envio_processo");
            entity.Property(e => e.SinFederacaoEnvio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_federacao_envio");
            entity.Property(e => e.SinFederacaoRecebimento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_federacao_recebimento");
            entity.Property(e => e.SinPublicacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_publicacao");
            entity.Property(e => e.StaCorretorOrtografico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_corretor_ortografico");
            entity.Property(e => e.Timbre)
                .IsUnicode(false)
                .HasColumnName("timbre");

            entity.HasOne(d => d.IdContatoNavigation).WithMany(p => p.Orgaos)
                .HasForeignKey(d => d.IdContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orgao_contato");

            entity.HasOne(d => d.IdOrgaoFederacaoNavigation).WithMany(p => p.Orgaos)
                .HasForeignKey(d => d.IdOrgaoFederacao)
                .HasConstraintName("fk_orgao_orgao_federacao");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Orgaos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_orgao_unidade");

            entity.HasMany(d => d.IdOrgao1s).WithMany(p => p.IdOrgao2s)
                .UsingEntity<Dictionary<string, object>>(
                    "RelOrgaoPesquisa",
                    r => r.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao1")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_orgao_pesq_org_1"),
                    l => l.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao2")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_orgao_pesq_org_2"),
                    j =>
                    {
                        j.HasKey("IdOrgao1", "IdOrgao2").HasName("pk_rel_orgao_pesquisa");
                        j.ToTable("rel_orgao_pesquisa");
                        j.HasIndex(new[] { "IdOrgao1" }, "fk_rel_orgao_pesq_org_1");
                        j.HasIndex(new[] { "IdOrgao2" }, "fk_rel_orgao_pesq_org_2");
                        j.IndexerProperty<int>("IdOrgao1").HasColumnName("id_orgao_1");
                        j.IndexerProperty<int>("IdOrgao2").HasColumnName("id_orgao_2");
                    });

            entity.HasMany(d => d.IdOrgao2s).WithMany(p => p.IdOrgao1s)
                .UsingEntity<Dictionary<string, object>>(
                    "RelOrgaoPesquisa",
                    r => r.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao2")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_orgao_pesq_org_2"),
                    l => l.HasOne<Orgao>().WithMany()
                        .HasForeignKey("IdOrgao1")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_orgao_pesq_org_1"),
                    j =>
                    {
                        j.HasKey("IdOrgao1", "IdOrgao2").HasName("pk_rel_orgao_pesquisa");
                        j.ToTable("rel_orgao_pesquisa");
                        j.HasIndex(new[] { "IdOrgao1" }, "fk_rel_orgao_pesq_org_1");
                        j.HasIndex(new[] { "IdOrgao2" }, "fk_rel_orgao_pesq_org_2");
                        j.IndexerProperty<int>("IdOrgao1").HasColumnName("id_orgao_1");
                        j.IndexerProperty<int>("IdOrgao2").HasColumnName("id_orgao_2");
                    });
        });

        modelBuilder.Entity<OrgaoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdOrgaoFederacao).HasName("pk_orgao_federacao");

            entity.ToTable("orgao_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_orgao_fed_instalacao_fed");

            entity.Property(e => e.IdOrgaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_orgao_federacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.OrgaoFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orgao_fed_instalacao_fed");
        });

        modelBuilder.Entity<OrgaoHistorico>(entity =>
        {
            entity.HasKey(e => e.IdOrgaoHistorico).HasName("pk_orgao_historico");

            entity.ToTable("orgao_historico");

            entity.HasIndex(e => e.IdOrgao, "fk_orgao_historico_orgao");

            entity.HasIndex(e => new { e.DtaInicio, e.DtaFim, e.IdOrgao }, "i02_orgao_historico").IsUnique();

            entity.Property(e => e.IdOrgaoHistorico)
                .ValueGeneratedNever()
                .HasColumnName("id_orgao_historico");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DtaFim)
                .HasColumnType("datetime")
                .HasColumnName("dta_fim");
            entity.Property(e => e.DtaInicio)
                .HasColumnType("datetime")
                .HasColumnName("dta_inicio");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.OrgaoHistoricos)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orgao_historico_orgao");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("pk_pais");

            entity.ToTable("pais");

            entity.Property(e => e.IdPais)
                .ValueGeneratedNever()
                .HasColumnName("id_pais");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<ParametroAcaoFederacao>(entity =>
        {
            entity.HasKey(e => new { e.IdAcaoFederacao, e.Nome }).HasName("pk_parametro_acao_federacao");

            entity.ToTable("parametro_acao_federacao");

            entity.HasIndex(e => e.IdAcaoFederacao, "fk_param_acao_fed_acao_fed");

            entity.Property(e => e.IdAcaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_acao_federacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAcaoFederacaoNavigation).WithMany(p => p.ParametroAcaoFederacaos)
                .HasForeignKey(d => d.IdAcaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_param_acao_fed_acao_fed");
        });

        modelBuilder.Entity<Participante>(entity =>
        {
            entity.HasKey(e => e.IdParticipante).HasName("pk_participante");

            entity.ToTable("participante");

            entity.HasIndex(e => new { e.IdContato, e.IdProtocolo, e.StaParticipacao }, "ak1_participante").IsUnique();

            entity.HasIndex(e => e.IdContato, "fk_participante_contato");

            entity.HasIndex(e => e.IdProtocolo, "fk_participante_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_participante_unidade");

            entity.HasIndex(e => new { e.IdProtocolo, e.StaParticipacao }, "i01_participante");

            entity.Property(e => e.IdParticipante)
                .ValueGeneratedNever()
                .HasColumnName("id_participante");
            entity.Property(e => e.IdContato).HasColumnName("id_contato");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");
            entity.Property(e => e.StaParticipacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_participacao");

            entity.HasOne(d => d.IdContatoNavigation).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.IdContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_participante_contato");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_participante_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_participante_unidade");
        });

        modelBuilder.Entity<Pesquisa>(entity =>
        {
            entity.HasKey(e => e.IdPesquisa).HasName("pk_pesquisa");

            entity.ToTable("pesquisa");

            entity.HasIndex(e => e.IdUnidade, "fk_pesquisa_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_pesquisa_usuario");

            entity.Property(e => e.IdPesquisa)
                .ValueGeneratedNever()
                .HasColumnName("id_pesquisa");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Pesquisas)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_pesquisa_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Pesquisas)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pesquisa_usuario");
        });

        modelBuilder.Entity<PlanoTrabalho>(entity =>
        {
            entity.HasKey(e => e.IdPlanoTrabalho).HasName("pk_plano_trabalho");

            entity.ToTable("plano_trabalho");

            entity.Property(e => e.IdPlanoTrabalho)
                .ValueGeneratedNever()
                .HasColumnName("id_plano_trabalho");
            entity.Property(e => e.Descricao)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Procedimento>(entity =>
        {
            entity.HasKey(e => e.IdProcedimento).HasName("pk_procedimento");

            entity.ToTable("procedimento");

            entity.HasIndex(e => e.IdTipoPrioridade, "fk_proced_tipo_prioridade");

            entity.HasIndex(e => e.IdPlanoTrabalho, "fk_procedimento_plano_trabalho");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_procedimento_tipo_procedime");

            entity.HasIndex(e => e.DtaConclusao, "i01_procedimento");

            entity.HasIndex(e => e.DtaEliminacao, "i02_procedimento");

            entity.Property(e => e.IdProcedimento)
                .ValueGeneratedNever()
                .HasColumnName("id_procedimento");
            entity.Property(e => e.DtaConclusao)
                .HasColumnType("datetime")
                .HasColumnName("dta_conclusao");
            entity.Property(e => e.DtaEliminacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_eliminacao");
            entity.Property(e => e.IdPlanoTrabalho).HasColumnName("id_plano_trabalho");
            entity.Property(e => e.IdTipoPrioridade).HasColumnName("id_tipo_prioridade");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.SinCiencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ciencia");
            entity.Property(e => e.StaOuvidoria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_ouvidoria");

            entity.HasOne(d => d.IdPlanoTrabalhoNavigation).WithMany(p => p.Procedimentos)
                .HasForeignKey(d => d.IdPlanoTrabalho)
                .HasConstraintName("fk_procedimento_plano_trabalho");

            entity.HasOne(d => d.IdProcedimentoNavigation).WithOne(p => p.Procedimento)
                .HasForeignKey<Procedimento>(d => d.IdProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedimento_protocolo");

            entity.HasOne(d => d.IdTipoPrioridadeNavigation).WithMany(p => p.Procedimentos)
                .HasForeignKey(d => d.IdTipoPrioridade)
                .HasConstraintName("fk_proced_tipo_prioridade");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.Procedimentos)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedimento_tipo_procedime");
        });

        modelBuilder.Entity<Protocolo>(entity =>
        {
            entity.HasKey(e => e.IdProtocolo).HasName("pk_protocolo");

            entity.ToTable("protocolo");

            entity.HasIndex(e => new { e.IdProtocolo, e.StaProtocolo }, "ak1_protocolo").IsUnique();

            entity.HasIndex(e => e.ProtocoloFormatado, "ak2_protocolo").IsUnique();

            entity.HasIndex(e => e.IdHipoteseLegal, "fk_protocolo_hipotese_legal");

            entity.HasIndex(e => e.IdProtocoloFederacao, "fk_protocolo_protocolo_fed");

            entity.HasIndex(e => e.IdUnidadeGeradora, "fk_protocolo_unidade");

            entity.HasIndex(e => e.IdUsuarioGerador, "fk_protocolo_usuario");

            entity.HasIndex(e => new { e.IdUnidadeGeradora, e.StaProtocolo, e.DtaGeracao }, "i02_protocolo");

            entity.HasIndex(e => new { e.StaNivelAcessoGlobal, e.IdProtocolo, e.IdUnidadeGeradora, e.StaProtocolo, e.StaEstado }, "i03_protocolo");

            entity.HasIndex(e => new { e.StaProtocolo, e.DtaGeracao }, "i06_protocolo");

            entity.HasIndex(e => new { e.DtaInclusao, e.StaProtocolo, e.IdUnidadeGeradora }, "i07_protocolo");

            entity.HasIndex(e => new { e.ProtocoloFormatadoPesquisa, e.StaNivelAcessoGlobal, e.IdProtocolo }, "i10_protocolo");

            entity.HasIndex(e => new { e.StaProtocolo, e.StaNivelAcessoGlobal, e.IdProtocolo }, "i11_protocolo");

            entity.HasIndex(e => new { e.StaEstado, e.StaProtocolo, e.StaNivelAcessoGlobal, e.IdProtocolo }, "i12_protocolo");

            entity.HasIndex(e => new { e.IdProtocolo, e.StaProtocolo, e.IdUsuarioGerador, e.IdUnidadeGeradora, e.DtaGeracao }, "i13_protocolo");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdHipoteseLegal, e.IdUnidadeGeradora }, "i14_protocolo");

            entity.HasIndex(e => e.ProtocoloFormatadoPesquisa, "i15_protocolo");

            entity.HasIndex(e => e.ProtocoloFormatadoPesqInv, "i16_protocolo");

            entity.HasIndex(e => e.SinEliminado, "i17_protocolo");

            entity.HasIndex(e => new { e.IdProtocolo, e.StaProtocolo, e.StaEstado, e.DtaGeracao, e.IdUnidadeGeradora }, "ie1_protocolo");

            entity.HasIndex(e => e.IdProtocoloAgrupador, "if4_protocolo");

            entity.Property(e => e.IdProtocolo)
                .ValueGeneratedNever()
                .HasColumnName("id_protocolo");
            entity.Property(e => e.CodigoBarras)
                .IsUnicode(false)
                .HasColumnName("codigo_barras");
            entity.Property(e => e.Descricao)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DtaGeracao)
                .HasColumnType("datetime")
                .HasColumnName("dta_geracao");
            entity.Property(e => e.DtaInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dta_inclusao");
            entity.Property(e => e.IdHipoteseLegal).HasColumnName("id_hipotese_legal");
            entity.Property(e => e.IdProtocoloAgrupador).HasColumnName("id_protocolo_agrupador");
            entity.Property(e => e.IdProtocoloFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_protocolo_federacao");
            entity.Property(e => e.IdUnidadeGeradora).HasColumnName("id_unidade_geradora");
            entity.Property(e => e.IdUsuarioGerador).HasColumnName("id_usuario_gerador");
            entity.Property(e => e.ProtocoloFormatado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado");
            entity.Property(e => e.ProtocoloFormatadoPesqInv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado_pesq_inv");
            entity.Property(e => e.ProtocoloFormatadoPesquisa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado_pesquisa");
            entity.Property(e => e.SinEliminado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_eliminado");
            entity.Property(e => e.StaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_estado");
            entity.Property(e => e.StaGrauSigilo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_grau_sigilo");
            entity.Property(e => e.StaNivelAcessoGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso_global");
            entity.Property(e => e.StaNivelAcessoLocal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso_local");
            entity.Property(e => e.StaNivelAcessoOriginal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso_original");
            entity.Property(e => e.StaProtocolo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_protocolo");

            entity.HasOne(d => d.IdHipoteseLegalNavigation).WithMany(p => p.Protocolos)
                .HasForeignKey(d => d.IdHipoteseLegal)
                .HasConstraintName("fk_protocolo_hipotese_legal");

            entity.HasOne(d => d.IdProtocoloFederacaoNavigation).WithMany(p => p.Protocolos)
                .HasForeignKey(d => d.IdProtocoloFederacao)
                .HasConstraintName("fk_protocolo_protocolo_fed");

            entity.HasOne(d => d.IdUnidadeGeradoraNavigation).WithMany(p => p.Protocolos)
                .HasForeignKey(d => d.IdUnidadeGeradora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_unidade");

            entity.HasOne(d => d.IdUsuarioGeradorNavigation).WithMany(p => p.Protocolos)
                .HasForeignKey(d => d.IdUsuarioGerador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_usuario");
        });

        modelBuilder.Entity<ProtocoloFederacao>(entity =>
        {
            entity.HasKey(e => e.IdProtocoloFederacao).HasName("pk_protocolo_federacao");

            entity.ToTable("protocolo_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_protocolo_fed_inst_fed");

            entity.HasIndex(e => e.ProtocoloFormatado, "i01_protocolo_federacao");

            entity.HasIndex(e => e.ProtocoloFormatadoPesquisa, "i02_protocolo_federacao");

            entity.HasIndex(e => e.ProtocoloFormatadoPesqInv, "i03_protocolo_federacao");

            entity.Property(e => e.IdProtocoloFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_protocolo_federacao");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.ProtocoloFormatado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado");
            entity.Property(e => e.ProtocoloFormatadoPesqInv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado_pesq_inv");
            entity.Property(e => e.ProtocoloFormatadoPesquisa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado_pesquisa");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.ProtocoloFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_fed_inst_fed");
        });

        modelBuilder.Entity<ProtocoloModelo>(entity =>
        {
            entity.HasKey(e => e.IdProtocoloModelo).HasName("pk_protocolo_modelo");

            entity.ToTable("protocolo_modelo");

            entity.HasIndex(e => e.IdGrupoProtocoloModelo, "fk_prot_mod_grupo_prot_mod");

            entity.HasIndex(e => e.IdProtocolo, "fk_protocolo_modelo_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_protocolo_modelo_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_protocolo_modelo_usuario");

            entity.Property(e => e.IdProtocoloModelo)
                .ValueGeneratedNever()
                .HasColumnName("id_protocolo_modelo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DthAlteracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_alteracao");
            entity.Property(e => e.IdGrupoProtocoloModelo).HasColumnName("id_grupo_protocolo_modelo");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdxProtocoloModelo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("idx_protocolo_modelo");

            entity.HasOne(d => d.IdGrupoProtocoloModeloNavigation).WithMany(p => p.ProtocoloModelos)
                .HasForeignKey(d => d.IdGrupoProtocoloModelo)
                .HasConstraintName("fk_prot_mod_grupo_prot_mod");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.ProtocoloModelos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_modelo_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.ProtocoloModelos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_modelo_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ProtocoloModelos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_modelo_usuario");
        });

        modelBuilder.Entity<Publicacao>(entity =>
        {
            entity.HasKey(e => e.IdPublicacao).HasName("pk_publicacao");

            entity.ToTable("publicacao");

            entity.HasIndex(e => e.IdAtividade, "fk_publicacao_atividade");

            entity.HasIndex(e => e.IdDocumento, "fk_publicacao_documento").IsUnique();

            entity.HasIndex(e => e.IdSecaoIo, "fk_publicacao_secao_in");

            entity.HasIndex(e => e.IdUnidade, "fk_publicacao_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_publicacao_usuario");

            entity.HasIndex(e => e.IdVeiculoIo, "fk_publicacao_veiculo_in");

            entity.HasIndex(e => e.IdVeiculoPublicacao, "fk_publicacao_veiculo_public");

            entity.HasIndex(e => e.DtaPublicacao, "i01_publicacao");

            entity.HasIndex(e => new { e.IdUnidade, e.DtaPublicacao }, "i03_publicacao");

            entity.Property(e => e.IdPublicacao)
                .ValueGeneratedNever()
                .HasColumnName("id_publicacao");
            entity.Property(e => e.DtaDisponibilizacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_disponibilizacao");
            entity.Property(e => e.DtaPublicacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_publicacao");
            entity.Property(e => e.DtaPublicacaoIo)
                .HasColumnType("datetime")
                .HasColumnName("dta_publicacao_io");
            entity.Property(e => e.DthAgendamento)
                .HasColumnType("datetime")
                .HasColumnName("dth_agendamento");
            entity.Property(e => e.IdAtividade).HasColumnName("id_atividade");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdSecaoIo).HasColumnName("id_secao_io");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdVeiculoIo).HasColumnName("id_veiculo_io");
            entity.Property(e => e.IdVeiculoPublicacao).HasColumnName("id_veiculo_publicacao");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.PaginaIo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagina_io");
            entity.Property(e => e.Resumo)
                .IsUnicode(false)
                .HasColumnName("resumo");
            entity.Property(e => e.StaMotivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_motivo");

            entity.HasOne(d => d.IdAtividadeNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdAtividade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_atividade");

            entity.HasOne(d => d.IdDocumentoNavigation).WithOne(p => p.Publicacao)
                .HasForeignKey<Publicacao>(d => d.IdDocumento)
                .HasConstraintName("fk_publicacao_documento");

            entity.HasOne(d => d.IdSecaoIoNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdSecaoIo)
                .HasConstraintName("fk_publicacao_secao_in");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_usuario");

            entity.HasOne(d => d.IdVeiculoIoNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdVeiculoIo)
                .HasConstraintName("fk_publicacao_veiculo_in");

            entity.HasOne(d => d.IdVeiculoPublicacaoNavigation).WithMany(p => p.Publicacaos)
                .HasForeignKey(d => d.IdVeiculoPublicacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_veiculo_public");
        });

        modelBuilder.Entity<PublicacaoLegado>(entity =>
        {
            entity.HasKey(e => e.IdPublicacaoLegado).HasName("pk_publicacao_legado");

            entity.ToTable("publicacao_legado");

            entity.HasIndex(e => e.IdSecaoIo, "fk_public_legado_secao_imp_nac");

            entity.HasIndex(e => e.IdVeiculoPublicacao, "fk_public_legado_veic_public");

            entity.HasIndex(e => e.IdVeiculoIo, "fk_public_legado_veicu_imp_nac");

            entity.HasIndex(e => e.IdSerie, "fk_publicacao_legado_serie");

            entity.HasIndex(e => e.IdUnidade, "fk_publicacao_legado_unidade");

            entity.HasIndex(e => e.IdPublicacaoLegadoAgrupador, "i01_publicacao_legado");

            entity.HasIndex(e => new { e.IdOrgao, e.IdUnidade }, "i02_publicacao_legado");

            entity.HasIndex(e => new { e.IdOrgao, e.IdSerie }, "i03_publicacao_legado");

            entity.Property(e => e.IdPublicacaoLegado)
                .ValueGeneratedNever()
                .HasColumnName("id_publicacao_legado");
            entity.Property(e => e.ConteudoDocumento)
                .IsUnicode(false)
                .HasColumnName("conteudo_documento");
            entity.Property(e => e.DtaGeracao)
                .HasColumnType("datetime")
                .HasColumnName("dta_geracao");
            entity.Property(e => e.DtaPublicacao)
                .HasColumnType("datetime")
                .HasColumnName("dta_publicacao");
            entity.Property(e => e.DtaPublicacaoIo)
                .HasColumnType("datetime")
                .HasColumnName("dta_publicacao_io");
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_documento");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdPublicacaoLegadoAgrupador).HasColumnName("id_publicacao_legado_agrupador");
            entity.Property(e => e.IdSecaoIo).HasColumnName("id_secao_io");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdVeiculoIo).HasColumnName("id_veiculo_io");
            entity.Property(e => e.IdVeiculoPublicacao).HasColumnName("id_veiculo_publicacao");
            entity.Property(e => e.Numero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.PaginaIo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pagina_io");
            entity.Property(e => e.ProtocoloFormatado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("protocolo_formatado");
            entity.Property(e => e.Resumo)
                .IsUnicode(false)
                .HasColumnName("resumo");

            entity.HasOne(d => d.IdSecaoIoNavigation).WithMany(p => p.PublicacaoLegados)
                .HasForeignKey(d => d.IdSecaoIo)
                .HasConstraintName("fk_public_legado_secao_imp_nac");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.PublicacaoLegados)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_legado_serie");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.PublicacaoLegados)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_publicacao_legado_unidade");

            entity.HasOne(d => d.IdVeiculoIoNavigation).WithMany(p => p.PublicacaoLegados)
                .HasForeignKey(d => d.IdVeiculoIo)
                .HasConstraintName("fk_public_legado_veicu_imp_nac");

            entity.HasOne(d => d.IdVeiculoPublicacaoNavigation).WithMany(p => p.PublicacaoLegados)
                .HasForeignKey(d => d.IdVeiculoPublicacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_public_legado_veic_public");
        });

        modelBuilder.Entity<ReaberturaProgramadum>(entity =>
        {
            entity.HasKey(e => e.IdReaberturaProgramada).HasName("pk_reabertura_programada");

            entity.ToTable("reabertura_programada");

            entity.HasIndex(e => e.IdAtividade, "fk_reabertura_prog_atividade");

            entity.HasIndex(e => e.IdProtocolo, "fk_reabertura_prog_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_reabertura_prog_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_reabertura_prog_usuario");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdUnidade, e.DtaProgramada }, "i01_reabertura_programada");

            entity.HasIndex(e => new { e.DtaProgramada, e.DthProcessamento }, "i02_reabertura_programada");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdUnidade }, "i03_reabertura_programada");

            entity.HasIndex(e => new { e.IdProtocolo, e.IdUnidade, e.DthProcessamento, e.DthVisualizacao }, "i04_reabertura_programada");

            entity.Property(e => e.IdReaberturaProgramada)
                .ValueGeneratedNever()
                .HasColumnName("id_reabertura_programada");
            entity.Property(e => e.DtaProgramada)
                .HasColumnType("datetime")
                .HasColumnName("dta_programada");
            entity.Property(e => e.DthAlteracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_alteracao");
            entity.Property(e => e.DthProcessamento)
                .HasColumnType("datetime")
                .HasColumnName("dth_processamento");
            entity.Property(e => e.DthVisualizacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_visualizacao");
            entity.Property(e => e.Erro)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("erro");
            entity.Property(e => e.IdAtividade).HasColumnName("id_atividade");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdAtividadeNavigation).WithMany(p => p.ReaberturaProgramada)
                .HasForeignKey(d => d.IdAtividade)
                .HasConstraintName("fk_reabertura_prog_atividade");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.ReaberturaProgramada)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reabertura_prog_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.ReaberturaProgramada)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reabertura_prog_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ReaberturaProgramada)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_reabertura_prog_usuario");
        });

        modelBuilder.Entity<RelBlocoProtocolo>(entity =>
        {
            entity.HasKey(e => new { e.IdProtocolo, e.IdBloco }).HasName("pk_rel_bloco_protocolo");

            entity.ToTable("rel_bloco_protocolo");

            entity.HasIndex(e => e.IdBloco, "fk_rel_bloco_protocolo_bloco");

            entity.HasIndex(e => e.IdProtocolo, "fk_rel_bloco_protocolo_protoco");

            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.Anotacao)
                .IsUnicode(false)
                .HasColumnName("anotacao");
            entity.Property(e => e.IdxRelBlocoProtocolo)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("idx_rel_bloco_protocolo");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.RelBlocoProtocolos)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_bloco_protocolo_bloco");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.RelBlocoProtocolos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_bloco_protocolo_protoco");
        });

        modelBuilder.Entity<RelBlocoUnidade>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidade, e.IdBloco }).HasName("pk_rel_bloco_unidade");

            entity.ToTable("rel_bloco_unidade");

            entity.HasIndex(e => e.IdGrupoBloco, "fk_rel_blo_uni_grupo_bloco");

            entity.HasIndex(e => e.IdUsuarioAtribuicao, "fk_rel_blo_uni_usu_atribuicao");

            entity.HasIndex(e => e.IdUsuarioComentario, "fk_rel_blo_uni_usu_comentario");

            entity.HasIndex(e => e.IdUsuarioPrioridade, "fk_rel_blo_uni_usu_prioridade");

            entity.HasIndex(e => e.IdUsuarioRevisao, "fk_rel_blo_uni_usu_revisao");

            entity.HasIndex(e => e.IdBloco, "fk_rel_bloco_unidade_bloco");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_bloco_unidade_unidade");

            entity.HasIndex(e => new { e.IdBloco, e.IdUnidade, e.IdUsuarioAtribuicao }, "i05_rel_bloco_unidade");

            entity.HasIndex(e => new { e.IdBloco, e.IdUnidade, e.SinPrioridade, e.SinRevisao, e.SinComentario }, "i06_rel_bloco_unidade");

            entity.HasIndex(e => new { e.IdBloco, e.IdUnidade, e.IdUsuarioAtribuicao, e.SinPrioridade, e.SinRevisao, e.SinComentario }, "i07_rel_bloco_unidade");

            entity.HasIndex(e => new { e.IdBloco, e.IdUnidade, e.SinRetornado }, "i08_rel_bloco_unidade");

            entity.HasIndex(e => new { e.IdBloco, e.SinRetornado }, "if3_rel_bloco_unidade");

            entity.HasIndex(e => new { e.IdUnidade, e.SinRetornado }, "if4_rel_bloco_unidade");

            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdBloco).HasColumnName("id_bloco");
            entity.Property(e => e.DthComentario)
                .HasColumnType("datetime")
                .HasColumnName("dth_comentario");
            entity.Property(e => e.DthPrioridade)
                .HasColumnType("datetime")
                .HasColumnName("dth_prioridade");
            entity.Property(e => e.DthRevisao)
                .HasColumnType("datetime")
                .HasColumnName("dth_revisao");
            entity.Property(e => e.IdGrupoBloco).HasColumnName("id_grupo_bloco");
            entity.Property(e => e.IdUsuarioAtribuicao).HasColumnName("id_usuario_atribuicao");
            entity.Property(e => e.IdUsuarioComentario).HasColumnName("id_usuario_comentario");
            entity.Property(e => e.IdUsuarioPrioridade).HasColumnName("id_usuario_prioridade");
            entity.Property(e => e.IdUsuarioRevisao).HasColumnName("id_usuario_revisao");
            entity.Property(e => e.SinComentario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_comentario");
            entity.Property(e => e.SinPrioridade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_prioridade");
            entity.Property(e => e.SinRetornado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_retornado");
            entity.Property(e => e.SinRevisao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_revisao");
            entity.Property(e => e.TextoComentario)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("texto_comentario");

            entity.HasOne(d => d.IdBlocoNavigation).WithMany(p => p.RelBlocoUnidades)
                .HasForeignKey(d => d.IdBloco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_bloco_unidade_bloco");

            entity.HasOne(d => d.IdGrupoBlocoNavigation).WithMany(p => p.RelBlocoUnidades)
                .HasForeignKey(d => d.IdGrupoBloco)
                .HasConstraintName("fk_rel_blo_uni_grupo_bloco");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelBlocoUnidades)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_bloco_unidade_unidade");

            entity.HasOne(d => d.IdUsuarioAtribuicaoNavigation).WithMany(p => p.RelBlocoUnidadeIdUsuarioAtribuicaoNavigations)
                .HasForeignKey(d => d.IdUsuarioAtribuicao)
                .HasConstraintName("fk_rel_blo_uni_usu_atribuicao");

            entity.HasOne(d => d.IdUsuarioComentarioNavigation).WithMany(p => p.RelBlocoUnidadeIdUsuarioComentarioNavigations)
                .HasForeignKey(d => d.IdUsuarioComentario)
                .HasConstraintName("fk_rel_blo_uni_usu_comentario");

            entity.HasOne(d => d.IdUsuarioPrioridadeNavigation).WithMany(p => p.RelBlocoUnidadeIdUsuarioPrioridadeNavigations)
                .HasForeignKey(d => d.IdUsuarioPrioridade)
                .HasConstraintName("fk_rel_blo_uni_usu_prioridade");

            entity.HasOne(d => d.IdUsuarioRevisaoNavigation).WithMany(p => p.RelBlocoUnidadeIdUsuarioRevisaoNavigations)
                .HasForeignKey(d => d.IdUsuarioRevisao)
                .HasConstraintName("fk_rel_blo_uni_usu_revisao");
        });

        modelBuilder.Entity<RelNotificacaoDocumento>(entity =>
        {
            entity.HasKey(e => new { e.IdDocumento, e.IdNotificacao }).HasName("pk_rel_notificacao_documento");

            entity.ToTable("rel_notificacao_documento");

            entity.HasIndex(e => e.IdNotificacao, "fk_rel_notif_doc_documento");

            entity.HasIndex(e => e.IdDocumento, "fk_rel_notif_doc_notificacao");

            entity.HasIndex(e => new { e.IdDocumento, e.SinProcessada }, "i03_rel_notificacao_documento");

            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdNotificacao).HasColumnName("id_notificacao");
            entity.Property(e => e.SinProcessada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_processada");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.RelNotificacaoDocumentos)
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_notif_doc_notificacao");

            entity.HasOne(d => d.IdNotificacaoNavigation).WithMany(p => p.RelNotificacaoDocumentos)
                .HasForeignKey(d => d.IdNotificacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_notif_doc_documento");
        });

        modelBuilder.Entity<RelProtocoloAssunto>(entity =>
        {
            entity.HasKey(e => new { e.IdProtocolo, e.IdAssuntoProxy }).HasName("pk_rel_protocolo_assunto");

            entity.ToTable("rel_protocolo_assunto");

            entity.HasIndex(e => e.IdAssuntoProxy, "fk_rel_prot_assunto_assunto");

            entity.HasIndex(e => e.IdProtocolo, "fk_rel_prot_assunto_protocolo");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_protocolo_assunto_uni");

            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdAssuntoProxy).HasColumnName("id_assunto_proxy");
            entity.Property(e => e.IdProtocoloProcedimento).HasColumnName("id_protocolo_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");

            entity.HasOne(d => d.IdAssuntoProxyNavigation).WithMany(p => p.RelProtocoloAssuntos)
                .HasForeignKey(d => d.IdAssuntoProxy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_prot_assunto_assunto");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.RelProtocoloAssuntos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_prot_assunto_protocolo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelProtocoloAssuntos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_protocolo_assunto_uni");
        });

        modelBuilder.Entity<RelProtocoloAtributo>(entity =>
        {
            entity.HasKey(e => new { e.IdProtocolo, e.IdAtributo }).HasName("pk_rel_protocolo_atributo");

            entity.ToTable("rel_protocolo_atributo");

            entity.HasIndex(e => e.IdAtributo, "fk_rel_prot_atributo_atributo");

            entity.HasIndex(e => e.IdProtocolo, "fk_rel_prot_atributo_protocolo");

            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdAtributo).HasColumnName("id_atributo");
            entity.Property(e => e.Valor)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.RelProtocoloAtributos)
                .HasForeignKey(d => d.IdAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_prot_atributo_atributo");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.RelProtocoloAtributos)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_prot_atributo_protocolo");
        });

        modelBuilder.Entity<RelProtocoloProtocolo>(entity =>
        {
            entity.HasKey(e => e.IdRelProtocoloProtocolo).HasName("pk_rel_protocolo_protocolo");

            entity.ToTable("rel_protocolo_protocolo");

            entity.HasIndex(e => e.IdProtocolo1, "fk_protocolo_protocolo_1");

            entity.HasIndex(e => e.IdProtocolo2, "fk_protocolo_protocolo_2");

            entity.HasIndex(e => e.IdUsuario, "fk_rel_proc_doc_usuario");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_protocolo_protocolo_uni");

            entity.HasIndex(e => new { e.IdProtocolo2, e.IdProtocolo1, e.StaAssociacao }, "i01_rel_protocolo_protocolo");

            entity.Property(e => e.IdRelProtocoloProtocolo)
                .ValueGeneratedNever()
                .HasColumnName("id_rel_protocolo_protocolo");
            entity.Property(e => e.DthAssociacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_associacao");
            entity.Property(e => e.IdProtocolo1).HasColumnName("id_protocolo_1");
            entity.Property(e => e.IdProtocolo2).HasColumnName("id_protocolo_2");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");
            entity.Property(e => e.SinCiencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ciencia");
            entity.Property(e => e.StaAssociacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_associacao");

            entity.HasOne(d => d.IdProtocolo1Navigation).WithMany(p => p.RelProtocoloProtocoloIdProtocolo1Navigations)
                .HasForeignKey(d => d.IdProtocolo1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_protocolo_1");

            entity.HasOne(d => d.IdProtocolo2Navigation).WithMany(p => p.RelProtocoloProtocoloIdProtocolo2Navigations)
                .HasForeignKey(d => d.IdProtocolo2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_protocolo_protocolo_2");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelProtocoloProtocolos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_protocolo_protocolo_uni");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RelProtocoloProtocolos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_proc_doc_usuario");
        });

        modelBuilder.Entity<RelSecaoModCjEstilosItem>(entity =>
        {
            entity.HasKey(e => new { e.IdSecaoModelo, e.IdConjuntoEstilosItem }).HasName("pk_rel_secao_mod_cj_estilos_it");

            entity.ToTable("rel_secao_mod_cj_estilos_item");

            entity.HasIndex(e => e.IdConjuntoEstilosItem, "fk_re_secmod_cj_est_i_cj_est_i");

            entity.HasIndex(e => e.IdSecaoModelo, "fk_rel_secmod_cj_est_it_secmod");

            entity.Property(e => e.IdSecaoModelo).HasColumnName("id_secao_modelo");
            entity.Property(e => e.IdConjuntoEstilosItem).HasColumnName("id_conjunto_estilos_item");
            entity.Property(e => e.SinPadrao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_padrao");

            entity.HasOne(d => d.IdConjuntoEstilosItemNavigation).WithMany(p => p.RelSecaoModCjEstilosItems)
                .HasForeignKey(d => d.IdConjuntoEstilosItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_re_secmod_cj_est_i_cj_est_i");

            entity.HasOne(d => d.IdSecaoModeloNavigation).WithMany(p => p.RelSecaoModCjEstilosItems)
                .HasForeignKey(d => d.IdSecaoModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_secmod_cj_est_it_secmod");
        });

        modelBuilder.Entity<RelSecaoModeloEstilo>(entity =>
        {
            entity.HasKey(e => new { e.IdSecaoModelo, e.IdEstilo }).HasName("pk_rel_secao_modelo_estilo");

            entity.ToTable("rel_secao_modelo_estilo");

            entity.HasIndex(e => e.IdEstilo, "fk_rel_sec_mod_estilo_estilo");

            entity.HasIndex(e => e.IdSecaoModelo, "fk_rel_sec_mod_estilo_sec_mod");

            entity.Property(e => e.IdSecaoModelo).HasColumnName("id_secao_modelo");
            entity.Property(e => e.IdEstilo).HasColumnName("id_estilo");
            entity.Property(e => e.SinPadrao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_padrao");

            entity.HasOne(d => d.IdEstiloNavigation).WithMany(p => p.RelSecaoModeloEstilos)
                .HasForeignKey(d => d.IdEstilo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_sec_mod_estilo_estilo");

            entity.HasOne(d => d.IdSecaoModeloNavigation).WithMany(p => p.RelSecaoModeloEstilos)
                .HasForeignKey(d => d.IdSecaoModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_sec_mod_estilo_sec_mod");
        });

        modelBuilder.Entity<RelSerieAssunto>(entity =>
        {
            entity.HasKey(e => new { e.IdSerie, e.IdAssuntoProxy }).HasName("pk_rel_serie_assunto");

            entity.ToTable("rel_serie_assunto");

            entity.HasIndex(e => e.IdAssuntoProxy, "fk_rel_serie_assunto_assunto");

            entity.HasIndex(e => e.IdSerie, "fk_rel_serie_assunto_serie");

            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdAssuntoProxy).HasColumnName("id_assunto_proxy");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");

            entity.HasOne(d => d.IdAssuntoProxyNavigation).WithMany(p => p.RelSerieAssuntos)
                .HasForeignKey(d => d.IdAssuntoProxy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_serie_assunto_assunto");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.RelSerieAssuntos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_serie_assunto_serie");
        });

        modelBuilder.Entity<RelTipoProcedimentoAssunto>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoProcedimento, e.IdAssuntoProxy }).HasName("pk_rel_tipo_proced_assunto");

            entity.ToTable("rel_tipo_procedimento_assunto");

            entity.HasIndex(e => e.IdAssuntoProxy, "fk_rel_tipo_proc_assu_assunto");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_rel_tipo_proc_assu_tip_proc");

            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.IdAssuntoProxy).HasColumnName("id_assunto_proxy");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");

            entity.HasOne(d => d.IdAssuntoProxyNavigation).WithMany(p => p.RelTipoProcedimentoAssuntos)
                .HasForeignKey(d => d.IdAssuntoProxy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_tipo_proc_assu_assunto");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.RelTipoProcedimentoAssuntos)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_tipo_proc_assu_tip_proc");
        });

        modelBuilder.Entity<RelUnidadeTipoContato>(entity =>
        {
            entity.HasKey(e => e.IdRelUnidadeTipoContato).HasName("pk_rel_unidade_tipo_contato");

            entity.ToTable("rel_unidade_tipo_contato");

            entity.HasIndex(e => e.IdTipoContato, "fk_rel_unid_tip_cont_tip_cont");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_unid_tip_cont_unid");

            entity.HasIndex(e => new { e.IdUnidade, e.IdTipoContato, e.StaAcesso }, "i01_rel_unidade_tipo_contato");

            entity.Property(e => e.IdRelUnidadeTipoContato)
                .ValueGeneratedNever()
                .HasColumnName("id_rel_unidade_tipo_contato");
            entity.Property(e => e.IdTipoContato).HasColumnName("id_tipo_contato");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.StaAcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_acesso");

            entity.HasOne(d => d.IdTipoContatoNavigation).WithMany(p => p.RelUnidadeTipoContatos)
                .HasForeignKey(d => d.IdTipoContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_unid_tip_cont_tip_cont");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelUnidadeTipoContatos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_unid_tip_cont_unid");
        });

        modelBuilder.Entity<RelUsuarioTipoPrioridade>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidade, e.IdUsuario, e.IdTipoPrioridade }).HasName("pk_rel_usuario_tipo_prioridade");

            entity.ToTable("rel_usuario_tipo_prioridade");

            entity.HasIndex(e => e.IdTipoPrioridade, "fk_rel_uso_tipo_prio_tipo_prio");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_uso_tipo_prio_unid");

            entity.HasIndex(e => e.IdUsuario, "fk_rel_uso_tipo_prio_usuario");

            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdTipoPrioridade).HasColumnName("id_tipo_prioridade");

            entity.HasOne(d => d.IdTipoPrioridadeNavigation).WithMany(p => p.RelUsuarioTipoPrioridades)
                .HasForeignKey(d => d.IdTipoPrioridade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_uso_tipo_prio_tipo_prio");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelUsuarioTipoPrioridades)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_uso_tipo_prio_unid");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RelUsuarioTipoPrioridades)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_uso_tipo_prio_usuario");
        });

        modelBuilder.Entity<RelUsuarioTipoProced>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdTipoProcedimento, e.IdUnidade }).HasName("pk_rel_usuario_tipo_proced");

            entity.ToTable("rel_usuario_tipo_proced");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_rel_usu_tipo_proced_tipo_pr");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_usu_tipo_proced_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_rel_usu_tipo_proced_usu");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.RelUsuarioTipoProceds)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_tipo_proced_tipo_pr");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelUsuarioTipoProceds)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_tipo_proced_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RelUsuarioTipoProceds)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_tipo_proced_usu");
        });

        modelBuilder.Entity<RelUsuarioUsuarioUnidade>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdUsuarioAtribuicao, e.IdUnidade }).HasName("pk_rel_usuario_usuario_unidade");

            entity.ToTable("rel_usuario_usuario_unidade");

            entity.HasIndex(e => e.IdUnidade, "fk_rel_usu_usu_uni_unidade");

            entity.HasIndex(e => e.IdUsuarioAtribuicao, "fk_rel_usu_usu_uni_usu_atrib");

            entity.HasIndex(e => e.IdUsuario, "fk_rel_usu_usu_uni_usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdUsuarioAtribuicao).HasColumnName("id_usuario_atribuicao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.RelUsuarioUsuarioUnidades)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_usu_uni_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RelUsuarioUsuarioUnidadeIdUsuarioNavigations)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_usu_uni_usuario");

            entity.HasOne(d => d.IdUsuarioAtribuicaoNavigation).WithMany(p => p.RelUsuarioUsuarioUnidadeIdUsuarioAtribuicaoNavigations)
                .HasForeignKey(d => d.IdUsuarioAtribuicao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rel_usu_usu_uni_usu_atrib");
        });

        modelBuilder.Entity<ReplicacaoFederacao>(entity =>
        {
            entity.HasKey(e => e.IdReplicacaoFederacao).HasName("pk_replicacao_federacao");

            entity.ToTable("replicacao_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_replicacao_fed_inst_fed");

            entity.HasIndex(e => e.IdProtocoloFederacao, "fk_replicacao_fed_prot_fed");

            entity.Property(e => e.IdReplicacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_replicacao_federacao");
            entity.Property(e => e.DthCadastro)
                .HasColumnType("datetime")
                .HasColumnName("dth_cadastro");
            entity.Property(e => e.DthReplicacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_replicacao");
            entity.Property(e => e.Erro)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("erro");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.IdProtocoloFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_protocolo_federacao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo).HasColumnName("sta_tipo");
            entity.Property(e => e.Tentativa).HasColumnName("tentativa");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.ReplicacaoFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_replicacao_fed_inst_fed");

            entity.HasOne(d => d.IdProtocoloFederacaoNavigation).WithMany(p => p.ReplicacaoFederacaos)
                .HasForeignKey(d => d.IdProtocoloFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_replicacao_fed_prot_fed");
        });

        modelBuilder.Entity<RetornoProgramado>(entity =>
        {
            entity.HasKey(e => e.IdRetornoProgramado).HasName("pk_retorno_programado");

            entity.ToTable("retorno_programado");

            entity.HasIndex(e => e.IdAtividadeEnvio, "fk_ret_prog_ativ_envio");

            entity.HasIndex(e => e.IdAtividadeRetorno, "fk_ret_prog_ativ_retorno");

            entity.HasIndex(e => e.IdProtocolo, "fk_ret_programado_protocolo");

            entity.HasIndex(e => e.IdUnidadeEnvio, "fk_ret_programado_uni_envio");

            entity.HasIndex(e => e.IdUnidadeRetorno, "fk_ret_programado_uni_retorno");

            entity.HasIndex(e => e.IdUsuario, "fk_retorno_programado_usuario");

            entity.HasIndex(e => e.DtaProgramada, "i06_retorno_programado");

            entity.HasIndex(e => new { e.IdUnidadeEnvio, e.IdUnidadeRetorno, e.IdProtocolo, e.IdAtividadeRetorno }, "i07_retorno_programado");

            entity.HasIndex(e => new { e.IdUnidadeEnvio, e.IdUnidadeRetorno, e.DtaProgramada }, "i08_retorno_programado");

            entity.HasIndex(e => new { e.IdUnidadeEnvio, e.IdUnidadeRetorno, e.IdProtocolo }, "i09_retorno_programado");

            entity.Property(e => e.IdRetornoProgramado)
                .ValueGeneratedNever()
                .HasColumnName("id_retorno_programado");
            entity.Property(e => e.DtaProgramada)
                .HasColumnType("datetime")
                .HasColumnName("dta_programada");
            entity.Property(e => e.DthAlteracao)
                .HasColumnType("datetime")
                .HasColumnName("dth_alteracao");
            entity.Property(e => e.IdAtividadeEnvio).HasColumnName("id_atividade_envio");
            entity.Property(e => e.IdAtividadeRetorno).HasColumnName("id_atividade_retorno");
            entity.Property(e => e.IdProtocolo).HasColumnName("id_protocolo");
            entity.Property(e => e.IdUnidadeEnvio).HasColumnName("id_unidade_envio");
            entity.Property(e => e.IdUnidadeRetorno).HasColumnName("id_unidade_retorno");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdAtividadeEnvioNavigation).WithMany(p => p.RetornoProgramadoIdAtividadeEnvioNavigations)
                .HasForeignKey(d => d.IdAtividadeEnvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ret_prog_ativ_envio");

            entity.HasOne(d => d.IdAtividadeRetornoNavigation).WithMany(p => p.RetornoProgramadoIdAtividadeRetornoNavigations)
                .HasForeignKey(d => d.IdAtividadeRetorno)
                .HasConstraintName("fk_ret_prog_ativ_retorno");

            entity.HasOne(d => d.IdProtocoloNavigation).WithMany(p => p.RetornoProgramados)
                .HasForeignKey(d => d.IdProtocolo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ret_programado_protocolo");

            entity.HasOne(d => d.IdUnidadeEnvioNavigation).WithMany(p => p.RetornoProgramadoIdUnidadeEnvioNavigations)
                .HasForeignKey(d => d.IdUnidadeEnvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ret_programado_uni_envio");

            entity.HasOne(d => d.IdUnidadeRetornoNavigation).WithMany(p => p.RetornoProgramadoIdUnidadeRetornoNavigations)
                .HasForeignKey(d => d.IdUnidadeRetorno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ret_programado_uni_retorno");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RetornoProgramados)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_retorno_programado_usuario");
        });

        modelBuilder.Entity<SecaoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdSecaoDocumento).HasName("pk_secao_documento");

            entity.ToTable("secao_documento");

            entity.HasIndex(e => e.IdBaseConhecimento, "fk_secao_doc_base_conhecimento");

            entity.HasIndex(e => e.IdSecaoModelo, "fk_secao_doc_secao_mod");

            entity.HasIndex(e => e.IdDocumento, "fk_secao_documento_documento");

            entity.HasIndex(e => new { e.IdDocumento, e.IdBaseConhecimento, e.SinCabecalho, e.SinRodape }, "i01_secao_documento");

            entity.Property(e => e.IdSecaoDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_secao_documento");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.IdBaseConhecimento).HasColumnName("id_base_conhecimento");
            entity.Property(e => e.IdDocumento).HasColumnName("id_documento");
            entity.Property(e => e.IdSecaoModelo).HasColumnName("id_secao_modelo");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.SinAssinatura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_assinatura");
            entity.Property(e => e.SinCabecalho)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_cabecalho");
            entity.Property(e => e.SinDinamica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_dinamica");
            entity.Property(e => e.SinHtml)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_html");
            entity.Property(e => e.SinPrincipal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_principal");
            entity.Property(e => e.SinRodape)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_rodape");
            entity.Property(e => e.SinSomenteLeitura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_somente_leitura");

            entity.HasOne(d => d.IdBaseConhecimentoNavigation).WithMany(p => p.SecaoDocumentos)
                .HasForeignKey(d => d.IdBaseConhecimento)
                .HasConstraintName("fk_secao_doc_base_conhecimento");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.SecaoDocumentos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("fk_secao_documento_documento");

            entity.HasOne(d => d.IdSecaoModeloNavigation).WithMany(p => p.SecaoDocumentos)
                .HasForeignKey(d => d.IdSecaoModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_secao_doc_secao_mod");
        });

        modelBuilder.Entity<SecaoImprensaNacional>(entity =>
        {
            entity.HasKey(e => e.IdSecaoImprensaNacional).HasName("pk_secao_imprensa_nacional");

            entity.ToTable("secao_imprensa_nacional");

            entity.HasIndex(e => e.IdVeiculoImprensaNacional, "fk_secao_in_veiculo_in");

            entity.Property(e => e.IdSecaoImprensaNacional)
                .ValueGeneratedNever()
                .HasColumnName("id_secao_imprensa_nacional");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdVeiculoImprensaNacional).HasColumnName("id_veiculo_imprensa_nacional");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdVeiculoImprensaNacionalNavigation).WithMany(p => p.SecaoImprensaNacionals)
                .HasForeignKey(d => d.IdVeiculoImprensaNacional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_secao_in_veiculo_in");
        });

        modelBuilder.Entity<SecaoModelo>(entity =>
        {
            entity.HasKey(e => e.IdSecaoModelo).HasName("pk_secao_modelo");

            entity.ToTable("secao_modelo");

            entity.HasIndex(e => e.IdModelo, "fk_secao_modelo_modelo");

            entity.HasIndex(e => new { e.IdModelo, e.Ordem }, "i01_secao_modelo");

            entity.Property(e => e.IdSecaoModelo)
                .ValueGeneratedNever()
                .HasColumnName("id_secao_modelo");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Ordem).HasColumnName("ordem");
            entity.Property(e => e.SinAssinatura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_assinatura");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinCabecalho)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_cabecalho");
            entity.Property(e => e.SinDinamica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_dinamica");
            entity.Property(e => e.SinHtml)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_html");
            entity.Property(e => e.SinPrincipal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_principal");
            entity.Property(e => e.SinRodape)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_rodape");
            entity.Property(e => e.SinSomenteLeitura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_somente_leitura");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.SecaoModelos)
                .HasForeignKey(d => d.IdModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_secao_modelo_modelo");
        });

        modelBuilder.Entity<SeqAcesso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_acesso");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAcessoExterno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_acesso_externo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAcompanhamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_acompanhamento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAndamentoInstalacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_andamento_instalacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAndamentoMarcador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_andamento_marcador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAndamentoPlanoTrabalho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_andamento_plano_trabalho");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAndamentoSituacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_andamento_situacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAnexo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_anexo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAnotacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_anotacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqArquivoExtensao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_arquivo_extensao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAssinante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_assinante");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAssinatura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_assinatura");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAssunto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_assunto");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAssuntoProxy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_assunto_proxy");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtividade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atividade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtributo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atributo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtributoAndamPlanoTrab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atributo_andam_plano_trab");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtributoAndamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atributo_andamento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtributoAndamentoSituaca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atributo_andamento_situaca");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAtributoInstalacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_atributo_instalacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAuditoriaProtocolo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_auditoria_protocolo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAvaliacaoDocumental>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_avaliacao_documental");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqAviso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_aviso");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqBaseConhecimento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_base_conhecimento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqBloco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_bloco");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCampoPesquisa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_campo_pesquisa");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCargo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cargo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCategorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_categoria");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cidade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqComentario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_comentario");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqConjuntoEstilo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_conjunto_estilos");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqConjuntoEstilosItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_conjunto_estilos_item");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqContato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_contato");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqControleInterno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_controle_interno");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqControlePrazo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_controle_prazo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqControleUnidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_controle_unidade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCpad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cpad");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCpadAvaliacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cpad_avaliacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCpadComposicao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cpad_composicao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqCpadVersao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_cpad_versao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_documento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqDominio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_dominio");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEditalEliminacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_edital_eliminacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEditalEliminacaoConteudo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_edital_eliminacao_conteudo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEditalEliminacaoErro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_edital_eliminacao_erro");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEmailGrupoEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_email_grupo_email");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEmailSistema>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_email_sistema");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEmailUnidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_email_unidade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEmailUtilizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_email_utilizado");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEstatistica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_estatisticas");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEstilo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_estilo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqEtapaTrabalho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_etapa_trabalho");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqFeed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_feed");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqFeriado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_feriado");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoAcompanhamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_acompanhamento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoBloco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_bloco");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoContato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_contato");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_email");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoFederacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_federacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoProtocoloModelo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_protocolo_modelo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoSerie>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_serie");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqGrupoUnidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_grupo_unidade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqHipoteseLegal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_hipotese_legal");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqImagemFormato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_imagem_formato");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqInfraAuditorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_infra_auditoria");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqInfraLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_infra_log");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqInfraNavegador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_infra_navegador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqItemEtapa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_item_etapa");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqLembrete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_lembrete");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqLocalizador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_localizador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqLugarLocalizador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_lugar_localizador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqMarcador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_marcador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqModelo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_modelo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqMonitoramentoServico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_monitoramento_servico");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqNivelAcessoPermitido>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_nivel_acesso_permitido");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqNotificacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_notificacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqNovidade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_novidade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqNumeracao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_numeracao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqObservacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_observacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqOperacaoServico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_operacao_servico");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqOrdenadorDespesa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_ordenador_despesa");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqOrgaoHistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_orgao_historico");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqPai>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_pais");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqParticipante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_participante");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqPesquisa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_pesquisa");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqPlanoTrabalho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_plano_trabalho");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqProtocolo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_protocolo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqProtocoloModelo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_protocolo_modelo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqPublicacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_publicacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqReaberturaProgramadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_reabertura_programada");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqRelProtocoloProtocolo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_rel_protocolo_protocolo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqRelUnidadeTipoContato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_rel_unidade_tipo_contato");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqRetornoProgramado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_retorno_programado");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSecaoDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_secao_documento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSecaoImprensaNacional>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_secao_imprensa_nacional");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSecaoModelo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_secao_modelo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSerie>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_serie");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSeriePublicacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_serie_publicacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSerieRestricao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_serie_restricao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqServico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_servico");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqSituacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_situacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTabelaAssunto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tabela_assuntos");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTarefa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tarefa");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTarjaAssinatura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tarja_assinatura");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTextoPadraoInterno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_texto_padrao_interno");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoConferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_conferencia");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoContato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_contato");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoFormulario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_formulario");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoLocalizador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_localizador");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoPrioridade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_prioridade");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoProcedRestricao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_proced_restricao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoProcedimento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_procedimento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTipoSuporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tipo_suporte");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTitulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_titulo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqTratamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_tratamento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqUf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_uf");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqUnidadeHistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_unidade_historico");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqUnidadePublicacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_unidade_publicacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_upload");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqVeiculoImprensaNacional>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_veiculo_imprensa_nacional");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqVeiculoPublicacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_veiculo_publicacao");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqVersaoSecaoDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_versao_secao_documento");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<SeqVocativo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seq_vocativo");

            entity.Property(e => e.Campo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("campo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Serie>(entity =>
        {
            entity.HasKey(e => e.IdSerie).HasName("pk_serie");

            entity.ToTable("serie");

            entity.HasIndex(e => new { e.Nome, e.SinAtivo }, "ak1_serie").IsUnique();

            entity.HasIndex(e => e.IdGrupoSerie, "fk_serie_grupo_serie");

            entity.HasIndex(e => e.IdModelo, "fk_serie_modelo");

            entity.HasIndex(e => e.IdTipoFormulario, "fk_serie_tipo_formulario");

            entity.HasIndex(e => new { e.SinAtivo, e.StaAplicabilidade, e.SinInterno }, "i01_serie");

            entity.Property(e => e.IdSerie)
                .ValueGeneratedNever()
                .HasColumnName("id_serie");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdGrupoSerie).HasColumnName("id_grupo_serie");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.IdModeloEdoc).HasColumnName("id_modelo_edoc");
            entity.Property(e => e.IdTipoFormulario).HasColumnName("id_tipo_formulario");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAssinaturaPublicacao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_assinatura_publicacao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinDestinatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_destinatario");
            entity.Property(e => e.SinInteressado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_interessado");
            entity.Property(e => e.SinInterno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_interno");
            entity.Property(e => e.SinUsuarioExterno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_usuario_externo");
            entity.Property(e => e.SinValorMonetario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_valor_monetario");
            entity.Property(e => e.StaAplicabilidade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_aplicabilidade");
            entity.Property(e => e.StaNumeracao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_numeracao");

            entity.HasOne(d => d.IdGrupoSerieNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdGrupoSerie)
                .HasConstraintName("fk_serie_grupo_serie");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_serie_modelo");

            entity.HasOne(d => d.IdTipoFormularioNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdTipoFormulario)
                .HasConstraintName("fk_serie_tipo_formulario");

            entity.HasMany(d => d.IdControleInternos).WithMany(p => p.IdSeries)
                .UsingEntity<Dictionary<string, object>>(
                    "RelControleInternoSerie",
                    r => r.HasOne<ControleInterno>().WithMany()
                        .HasForeignKey("IdControleInterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_interno_se_ci"),
                    l => l.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_controle_interno_se_se"),
                    j =>
                    {
                        j.HasKey("IdSerie", "IdControleInterno").HasName("pk_rel_controle_interno_serie");
                        j.ToTable("rel_controle_interno_serie");
                        j.HasIndex(new[] { "IdControleInterno" }, "fk_rel_controle_interno_se_ci");
                        j.HasIndex(new[] { "IdSerie" }, "fk_rel_controle_interno_se_se");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                        j.IndexerProperty<int>("IdControleInterno").HasColumnName("id_controle_interno");
                    });

            entity.HasMany(d => d.IdItemEtapas).WithMany(p => p.IdSeries)
                .UsingEntity<Dictionary<string, object>>(
                    "RelItemEtapaSerie",
                    r => r.HasOne<ItemEtapa>().WithMany()
                        .HasForeignKey("IdItemEtapa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_ser_item_etap"),
                    l => l.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_ser_serie"),
                    j =>
                    {
                        j.HasKey("IdSerie", "IdItemEtapa").HasName("pk_rel_item_etapa_serie");
                        j.ToTable("rel_item_etapa_serie");
                        j.HasIndex(new[] { "IdItemEtapa" }, "fk_rel_item_etap_ser_item_etap");
                        j.HasIndex(new[] { "IdSerie" }, "fk_rel_item_etap_ser_serie");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                        j.IndexerProperty<int>("IdItemEtapa").HasColumnName("id_item_etapa");
                    });

            entity.HasMany(d => d.IdPlanoTrabalhos).WithMany(p => p.IdSeries)
                .UsingEntity<Dictionary<string, object>>(
                    "RelSeriePlanoTrabalho",
                    r => r.HasOne<PlanoTrabalho>().WithMany()
                        .HasForeignKey("IdPlanoTrabalho")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_serie_plano_trab_plano"),
                    l => l.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_serie_plano_trab_serie"),
                    j =>
                    {
                        j.HasKey("IdSerie", "IdPlanoTrabalho").HasName("pk_rel_serie_plano_trabalho");
                        j.ToTable("rel_serie_plano_trabalho");
                        j.HasIndex(new[] { "IdPlanoTrabalho" }, "fk_rel_serie_plano_trab_plano");
                        j.HasIndex(new[] { "IdSerie" }, "fk_rel_serie_plano_trab_serie");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                        j.IndexerProperty<int>("IdPlanoTrabalho").HasColumnName("id_plano_trabalho");
                    });

            entity.HasMany(d => d.IdUnidades).WithMany(p => p.IdSeries)
                .UsingEntity<Dictionary<string, object>>(
                    "SerieEscolha",
                    r => r.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_serie_escolha_unidade"),
                    l => l.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_serie_escolha_serie"),
                    j =>
                    {
                        j.HasKey("IdSerie", "IdUnidade").HasName("pk_serie_escolha");
                        j.ToTable("serie_escolha");
                        j.HasIndex(new[] { "IdSerie" }, "fk_serie_escolha_serie");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_serie_escolha_unidade");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                    });

            entity.HasMany(d => d.IdVeiculoPublicacaos).WithMany(p => p.IdSeries)
                .UsingEntity<Dictionary<string, object>>(
                    "RelSerieVeiculoPublicacao",
                    r => r.HasOne<VeiculoPublicacao>().WithMany()
                        .HasForeignKey("IdVeiculoPublicacao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_serie_veic_pub_veic_pub"),
                    l => l.HasOne<Serie>().WithMany()
                        .HasForeignKey("IdSerie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_serie_veic_pub_serie"),
                    j =>
                    {
                        j.HasKey("IdSerie", "IdVeiculoPublicacao").HasName("pk_rel_serie_veiculo_pub");
                        j.ToTable("rel_serie_veiculo_publicacao");
                        j.HasIndex(new[] { "IdSerie" }, "fk_rel_serie_veic_pub_serie");
                        j.HasIndex(new[] { "IdVeiculoPublicacao" }, "fk_rel_serie_veic_pub_veic_pub");
                        j.IndexerProperty<int>("IdSerie").HasColumnName("id_serie");
                        j.IndexerProperty<int>("IdVeiculoPublicacao").HasColumnName("id_veiculo_publicacao");
                    });
        });

        modelBuilder.Entity<SeriePublicacao>(entity =>
        {
            entity.HasKey(e => e.IdSeriePublicacao).HasName("pk_serie_publicacao");

            entity.ToTable("serie_publicacao");

            entity.HasIndex(e => e.IdOrgao, "fk_serie_publicacao_orgao");

            entity.HasIndex(e => e.IdSerie, "fk_serie_publicacao_serie");

            entity.Property(e => e.IdSeriePublicacao)
                .ValueGeneratedNever()
                .HasColumnName("id_serie_publicacao");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.SeriePublicacaos)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_serie_publicacao_orgao");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.SeriePublicacaos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_serie_publicacao_serie");
        });

        modelBuilder.Entity<SerieRestricao>(entity =>
        {
            entity.HasKey(e => e.IdSerieRestricao).HasName("pk_serie_restricao");

            entity.ToTable("serie_restricao");

            entity.HasIndex(e => e.IdOrgao, "fk_serie_restricao_orgao");

            entity.HasIndex(e => e.IdSerie, "fk_serie_restricao_serie");

            entity.HasIndex(e => e.IdUnidade, "fk_serie_restricao_unidade");

            entity.Property(e => e.IdSerieRestricao)
                .ValueGeneratedNever()
                .HasColumnName("id_serie_restricao");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdSerie).HasColumnName("id_serie");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.SerieRestricaos)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_serie_restricao_orgao");

            entity.HasOne(d => d.IdSerieNavigation).WithMany(p => p.SerieRestricaos)
                .HasForeignKey(d => d.IdSerie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_serie_restricao_serie");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.SerieRestricaos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_serie_restricao_unidade");
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.IdServico).HasName("pk_servico");

            entity.ToTable("servico");

            entity.HasIndex(e => e.IdUsuario, "fk_servico_usuario");

            entity.HasIndex(e => e.Crc, "i02_servico");

            entity.Property(e => e.IdServico)
                .ValueGeneratedNever()
                .HasColumnName("id_servico");
            entity.Property(e => e.ChaveAcesso)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("chave_acesso");
            entity.Property(e => e.Crc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("crc");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Identificacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identificacao");
            entity.Property(e => e.Servidor)
                .IsUnicode(false)
                .HasColumnName("servidor");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinChaveAcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_chave_acesso");
            entity.Property(e => e.SinLinkExterno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_link_externo");
            entity.Property(e => e.SinServidor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_servidor");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Servicos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_servico_usuario");
        });

        modelBuilder.Entity<SinalizacaoFederacao>(entity =>
        {
            entity.HasKey(e => new { e.IdInstalacaoFederacao, e.IdProtocoloFederacao, e.IdUnidade }).HasName("pk_sinalizacao_federacao");

            entity.ToTable("sinalizacao_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_sinalizacao_fed_inst_fed");

            entity.HasIndex(e => e.IdProtocoloFederacao, "fk_sinalizacao_fed_prot_fed");

            entity.HasIndex(e => e.IdUnidade, "fk_sinalizacao_fed_unidade");

            entity.HasIndex(e => new { e.IdProtocoloFederacao, e.IdUnidade, e.StaSinalizacao }, "i01_sinalizacao_federacao");

            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.IdProtocoloFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_protocolo_federacao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.DthSinalizacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_sinalizacao");
            entity.Property(e => e.StaSinalizacao).HasColumnName("sta_sinalizacao");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.SinalizacaoFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sinalizacao_fed_inst_fed");

            entity.HasOne(d => d.IdProtocoloFederacaoNavigation).WithMany(p => p.SinalizacaoFederacaos)
                .HasForeignKey(d => d.IdProtocoloFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sinalizacao_fed_prot_fed");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.SinalizacaoFederacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sinalizacao_fed_unidade");
        });

        modelBuilder.Entity<Situacao>(entity =>
        {
            entity.HasKey(e => e.IdSituacao).HasName("pk_situacao");

            entity.ToTable("situacao");

            entity.Property(e => e.IdSituacao)
                .ValueGeneratedNever()
                .HasColumnName("id_situacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sysdiagrams");

            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TabelaAssunto>(entity =>
        {
            entity.HasKey(e => e.IdTabelaAssuntos).HasName("pk_tabela_assuntos");

            entity.ToTable("tabela_assuntos");

            entity.Property(e => e.IdTabelaAssuntos)
                .ValueGeneratedNever()
                .HasColumnName("id_tabela_assuntos");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_atual");
        });

        modelBuilder.Entity<Tarefa>(entity =>
        {
            entity.HasKey(e => e.IdTarefa).HasName("pk_tarefa");

            entity.ToTable("tarefa");

            entity.HasIndex(e => e.IdTarefaModulo, "i01_tarefa");

            entity.Property(e => e.IdTarefa)
                .ValueGeneratedNever()
                .HasColumnName("id_tarefa");
            entity.Property(e => e.IdTarefaModulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_tarefa_modulo");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinConsultaProcessual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_consulta_processual");
            entity.Property(e => e.SinFecharAndamentosAbertos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_fechar_andamentos_abertos");
            entity.Property(e => e.SinHistoricoCompleto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_historico_completo");
            entity.Property(e => e.SinHistoricoResumido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_historico_resumido");
            entity.Property(e => e.SinLancarAndamentoFechado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_lancar_andamento_fechado");
            entity.Property(e => e.SinPermiteProcessoFechado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_permite_processo_fechado");
        });

        modelBuilder.Entity<TarefaInstalacao>(entity =>
        {
            entity.HasKey(e => e.IdTarefaInstalacao).HasName("pk_tarefa_instalacao");

            entity.ToTable("tarefa_instalacao");

            entity.Property(e => e.IdTarefaInstalacao)
                .ValueGeneratedNever()
                .HasColumnName("id_tarefa_instalacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TarefaPlanoTrabalho>(entity =>
        {
            entity.HasKey(e => e.IdTarefaPlanoTrabalho).HasName("pk_tarefa_plano_trabalho");

            entity.ToTable("tarefa_plano_trabalho");

            entity.Property(e => e.IdTarefaPlanoTrabalho)
                .ValueGeneratedNever()
                .HasColumnName("id_tarefa_plano_trabalho");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TarjaAssinatura>(entity =>
        {
            entity.HasKey(e => e.IdTarjaAssinatura).HasName("pk_tarja_assinatura");

            entity.ToTable("tarja_assinatura");

            entity.Property(e => e.IdTarjaAssinatura)
                .ValueGeneratedNever()
                .HasColumnName("id_tarja_assinatura");
            entity.Property(e => e.Logo)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTarjaAssinatura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tarja_assinatura");
            entity.Property(e => e.Texto)
                .IsUnicode(false)
                .HasColumnName("texto");
        });

        modelBuilder.Entity<TextoPadraoInterno>(entity =>
        {
            entity.HasKey(e => e.IdTextoPadraoInterno).HasName("pk_texto_padrao_interno");

            entity.ToTable("texto_padrao_interno");

            entity.HasIndex(e => e.IdConjuntoEstilos, "fk_texto_padrao_int_conj");

            entity.HasIndex(e => e.IdUnidade, "fk_texto_padrao_int_unid");

            entity.Property(e => e.IdTextoPadraoInterno)
                .ValueGeneratedNever()
                .HasColumnName("id_texto_padrao_interno");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdConjuntoEstilos).HasColumnName("id_conjunto_estilos");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdConjuntoEstilosNavigation).WithMany(p => p.TextoPadraoInternos)
                .HasForeignKey(d => d.IdConjuntoEstilos)
                .HasConstraintName("fk_texto_padrao_int_conj");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.TextoPadraoInternos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_texto_padrao_int_unid");
        });

        modelBuilder.Entity<TipoConferencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoConferencia).HasName("pk_tipo_conferencia");

            entity.ToTable("tipo_conferencia");

            entity.Property(e => e.IdTipoConferencia)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_conferencia");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<TipoContato>(entity =>
        {
            entity.HasKey(e => e.IdTipoContato).HasName("pk_tipo_contato");

            entity.ToTable("tipo_contato");

            entity.Property(e => e.IdTipoContato)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_contato");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_sistema");
            entity.Property(e => e.StaAcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_acesso");
        });

        modelBuilder.Entity<TipoFormulario>(entity =>
        {
            entity.HasKey(e => e.IdTipoFormulario).HasName("pk_tipo_formulario");

            entity.ToTable("tipo_formulario");

            entity.Property(e => e.IdTipoFormulario)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_formulario");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<TipoLocalizador>(entity =>
        {
            entity.HasKey(e => e.IdTipoLocalizador).HasName("pk_tipo_localizador");

            entity.ToTable("tipo_localizador");

            entity.HasIndex(e => new { e.Sigla, e.IdUnidade }, "ak1_tipo_localizador").IsUnique();

            entity.HasIndex(e => new { e.Nome, e.IdUnidade }, "ak_tipo_arquivo_nome").IsUnique();

            entity.HasIndex(e => e.IdUnidade, "fk_tipo_localizador_unidade");

            entity.Property(e => e.IdTipoLocalizador)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_localizador");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.TipoLocalizadors)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tipo_localizador_unidade");
        });

        modelBuilder.Entity<TipoPrioridade>(entity =>
        {
            entity.HasKey(e => e.IdTipoPrioridade).HasName("pk_tipo_prioridade");

            entity.ToTable("tipo_prioridade");

            entity.Property(e => e.IdTipoPrioridade)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_prioridade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<TipoProcedRestricao>(entity =>
        {
            entity.HasKey(e => e.IdTipoProcedRestricao).HasName("pk_tipo_proced_restricao");

            entity.ToTable("tipo_proced_restricao");

            entity.HasIndex(e => e.IdOrgao, "fk_tipo_proced_restr_orgao");

            entity.HasIndex(e => e.IdTipoProcedimento, "fk_tipo_proced_restr_tipo_proc");

            entity.HasIndex(e => e.IdUnidade, "fk_tipo_proced_restr_unidade");

            entity.Property(e => e.IdTipoProcedRestricao)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_proced_restricao");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdTipoProcedimento).HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.TipoProcedRestricaos)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tipo_proced_restr_orgao");

            entity.HasOne(d => d.IdTipoProcedimentoNavigation).WithMany(p => p.TipoProcedRestricaos)
                .HasForeignKey(d => d.IdTipoProcedimento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tipo_proced_restr_tipo_proc");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.TipoProcedRestricaos)
                .HasForeignKey(d => d.IdUnidade)
                .HasConstraintName("fk_tipo_proced_restr_unidade");
        });

        modelBuilder.Entity<TipoProcedimento>(entity =>
        {
            entity.HasKey(e => e.IdTipoProcedimento).HasName("pk_tipo_procedimento");

            entity.ToTable("tipo_procedimento");

            entity.HasIndex(e => e.IdHipoteseLegalSugestao, "fk_tipo_proced_hipotese_legal");

            entity.HasIndex(e => e.IdPlanoTrabalho, "fk_tipo_proced_plano_trabalho");

            entity.HasIndex(e => new { e.IdTipoProcedimento, e.SinAtivo }, "i01_tipo_procedimento");

            entity.HasIndex(e => new { e.SinOuvidoria, e.SinInterno, e.SinAtivo }, "i02_tipo_procedimento").IsDescending(false, false, true);

            entity.Property(e => e.IdTipoProcedimento)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_procedimento");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdHipoteseLegalSugestao).HasColumnName("id_hipotese_legal_sugestao");
            entity.Property(e => e.IdPlanoTrabalho).HasColumnName("id_plano_trabalho");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinIndividual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_individual");
            entity.Property(e => e.SinInterno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_interno");
            entity.Property(e => e.SinOuvidoria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ouvidoria");
            entity.Property(e => e.StaGrauSigiloSugestao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_grau_sigilo_sugestao");
            entity.Property(e => e.StaNivelAcessoSugestao)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_nivel_acesso_sugestao");

            entity.HasOne(d => d.IdHipoteseLegalSugestaoNavigation).WithMany(p => p.TipoProcedimentos)
                .HasForeignKey(d => d.IdHipoteseLegalSugestao)
                .HasConstraintName("fk_tipo_proced_hipotese_legal");

            entity.HasOne(d => d.IdPlanoTrabalhoNavigation).WithMany(p => p.TipoProcedimentos)
                .HasForeignKey(d => d.IdPlanoTrabalho)
                .HasConstraintName("fk_tipo_proced_plano_trabalho");

            entity.HasMany(d => d.IdBaseConhecimentos).WithMany(p => p.IdTipoProcedimentos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelBaseConhecTipoProced",
                    r => r.HasOne<BaseConhecimento>().WithMany()
                        .HasForeignKey("IdBaseConhecimento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_bc_tp_base_conhecimento"),
                    l => l.HasOne<TipoProcedimento>().WithMany()
                        .HasForeignKey("IdTipoProcedimento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_bc_tp_tipo_procedimento"),
                    j =>
                    {
                        j.HasKey("IdTipoProcedimento", "IdBaseConhecimento").HasName("pk_rel_base_conhec_tipo_proced");
                        j.ToTable("rel_base_conhec_tipo_proced");
                        j.HasIndex(new[] { "IdBaseConhecimento" }, "fk_rel_bc_tp_base_conhecimento");
                        j.HasIndex(new[] { "IdTipoProcedimento" }, "fk_rel_bc_tp_tipo_procedimento");
                        j.IndexerProperty<int>("IdTipoProcedimento").HasColumnName("id_tipo_procedimento");
                        j.IndexerProperty<int>("IdBaseConhecimento").HasColumnName("id_base_conhecimento");
                    });

            entity.HasMany(d => d.IdControleInternos).WithMany(p => p.IdTipoProcedimentos)
                .UsingEntity<Dictionary<string, object>>(
                    "RelControleInternoTipoProc",
                    r => r.HasOne<ControleInterno>().WithMany()
                        .HasForeignKey("IdControleInterno")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_contr_int_tipo_proc_ci"),
                    l => l.HasOne<TipoProcedimento>().WithMany()
                        .HasForeignKey("IdTipoProcedimento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_contr_int_t_tipo_proc"),
                    j =>
                    {
                        j.HasKey("IdTipoProcedimento", "IdControleInterno").HasName("pk_rel_controle_inter_tp_proc");
                        j.ToTable("rel_controle_interno_tipo_proc");
                        j.HasIndex(new[] { "IdTipoProcedimento" }, "fk_rel_contr_int_t_tipo_proc");
                        j.HasIndex(new[] { "IdControleInterno" }, "fk_rel_contr_int_tipo_proc_ci");
                        j.IndexerProperty<int>("IdTipoProcedimento").HasColumnName("id_tipo_procedimento");
                        j.IndexerProperty<int>("IdControleInterno").HasColumnName("id_controle_interno");
                    });

            entity.HasMany(d => d.IdUnidades).WithMany(p => p.IdTipoProcedimentos)
                .UsingEntity<Dictionary<string, object>>(
                    "TipoProcedimentoEscolha",
                    r => r.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_tipo_proc_escolha_unidade"),
                    l => l.HasOne<TipoProcedimento>().WithMany()
                        .HasForeignKey("IdTipoProcedimento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_tipo_proc_escolha_tipo_proc"),
                    j =>
                    {
                        j.HasKey("IdTipoProcedimento", "IdUnidade").HasName("pk_tipo_procedimento_escolha");
                        j.ToTable("tipo_procedimento_escolha");
                        j.HasIndex(new[] { "IdTipoProcedimento" }, "fk_tipo_proc_escolha_tipo_proc");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_tipo_proc_escolha_unidade");
                        j.IndexerProperty<int>("IdTipoProcedimento").HasColumnName("id_tipo_procedimento");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                    });
        });

        modelBuilder.Entity<TipoSuporte>(entity =>
        {
            entity.HasKey(e => e.IdTipoSuporte).HasName("pk_tipo_suporte");

            entity.ToTable("tipo_suporte");

            entity.HasIndex(e => e.Nome, "ak1_tipo_suporte").IsUnique();

            entity.Property(e => e.IdTipoSuporte)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_suporte");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Titulo>(entity =>
        {
            entity.HasKey(e => e.IdTitulo).HasName("pk_titulo");

            entity.ToTable("titulo");

            entity.Property(e => e.IdTitulo)
                .ValueGeneratedNever()
                .HasColumnName("id_titulo");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("abreviatura");
            entity.Property(e => e.Expressao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("expressao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Tratamento>(entity =>
        {
            entity.HasKey(e => e.IdTratamento).HasName("pk_tratamento");

            entity.ToTable("tratamento");

            entity.HasIndex(e => new { e.IdTratamento, e.SinAtivo }, "ie1_tratamento");

            entity.Property(e => e.IdTratamento)
                .ValueGeneratedNever()
                .HasColumnName("id_tratamento");
            entity.Property(e => e.Expressao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("expressao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        modelBuilder.Entity<Uf>(entity =>
        {
            entity.HasKey(e => e.IdUf).HasName("pk_uf");

            entity.ToTable("uf");

            entity.HasIndex(e => e.IdPais, "fk_uf_pais");

            entity.Property(e => e.IdUf)
                .ValueGeneratedNever()
                .HasColumnName("id_uf");
            entity.Property(e => e.CodigoIbge).HasColumnName("codigo_ibge");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Ufs)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_uf_pais");
        });

        modelBuilder.Entity<Unidade>(entity =>
        {
            entity.HasKey(e => e.IdUnidade).HasName("pk_unidade");

            entity.ToTable("unidade");

            entity.HasIndex(e => e.IdContato, "fk_unidade_contato");

            entity.HasIndex(e => e.IdOrgao, "fk_unidade_orgao");

            entity.HasIndex(e => e.IdUnidadeFederacao, "fk_unidade_unidade_federacao");

            entity.HasIndex(e => new { e.SinAtivo, e.IdOrgao, e.SinProtocolo, e.SinOuvidoria, e.SinEnvioProcesso }, "i01_unidade");

            entity.HasIndex(e => new { e.SinAtivo, e.Sigla }, "i02_unidade");

            entity.Property(e => e.IdUnidade)
                .ValueGeneratedNever()
                .HasColumnName("id_unidade");
            entity.Property(e => e.CodigoSei)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_sei");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdContato).HasColumnName("id_contato");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdOrigem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_origem");
            entity.Property(e => e.IdUnidadeFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_unidade_federacao");
            entity.Property(e => e.IdxUnidade)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("idx_unidade");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinArquivamento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_arquivamento");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinEnvioProcesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_envio_processo");
            entity.Property(e => e.SinMailPendencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_mail_pendencia");
            entity.Property(e => e.SinOuvidoria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ouvidoria");
            entity.Property(e => e.SinProtocolo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_protocolo");

            entity.HasOne(d => d.IdContatoNavigation).WithMany(p => p.Unidades)
                .HasForeignKey(d => d.IdContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_contato");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Unidades)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_orgao");

            entity.HasOne(d => d.IdUnidadeFederacaoNavigation).WithMany(p => p.Unidades)
                .HasForeignKey(d => d.IdUnidadeFederacao)
                .HasConstraintName("fk_unidade_unidade_federacao");

            entity.HasMany(d => d.IdAssinantes).WithMany(p => p.IdUnidades)
                .UsingEntity<Dictionary<string, object>>(
                    "RelAssinanteUnidade",
                    r => r.HasOne<Assinante>().WithMany()
                        .HasForeignKey("IdAssinante")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_assinante_uni_assinante"),
                    l => l.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_assinante_uni_unidade"),
                    j =>
                    {
                        j.HasKey("IdUnidade", "IdAssinante").HasName("pk_rel_assinante_unidade");
                        j.ToTable("rel_assinante_unidade");
                        j.HasIndex(new[] { "IdAssinante" }, "fk_rel_assinante_uni_assinante");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_rel_assinante_uni_unidade");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                        j.IndexerProperty<int>("IdAssinante").HasColumnName("id_assinante");
                    });

            entity.HasMany(d => d.IdGrupoUnidades).WithMany(p => p.IdUnidades)
                .UsingEntity<Dictionary<string, object>>(
                    "RelGrupoUnidadeUnidade",
                    r => r.HasOne<GrupoUnidade>().WithMany()
                        .HasForeignKey("IdGrupoUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grupo_unid_grupo_unid"),
                    l => l.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_grupo_unid_unidade"),
                    j =>
                    {
                        j.HasKey("IdUnidade", "IdGrupoUnidade").HasName("pk_rel_grupo_unidade_unidade");
                        j.ToTable("rel_grupo_unidade_unidade");
                        j.HasIndex(new[] { "IdGrupoUnidade" }, "fk_rel_grupo_unid_grupo_unid");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_rel_grupo_unid_unidade");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                        j.IndexerProperty<int>("IdGrupoUnidade").HasColumnName("id_grupo_unidade");
                    });

            entity.HasMany(d => d.IdItemEtapas).WithMany(p => p.IdUnidades)
                .UsingEntity<Dictionary<string, object>>(
                    "RelItemEtapaUnidade",
                    r => r.HasOne<ItemEtapa>().WithMany()
                        .HasForeignKey("IdItemEtapa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_uni_item_etap"),
                    l => l.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_item_etap_uni_unidade"),
                    j =>
                    {
                        j.HasKey("IdUnidade", "IdItemEtapa").HasName("pk_rel_item_etapa_unidade");
                        j.ToTable("rel_item_etapa_unidade");
                        j.HasIndex(new[] { "IdItemEtapa" }, "fk_rel_item_etap_uni_item_etap");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_rel_item_etap_uni_unidade");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                        j.IndexerProperty<int>("IdItemEtapa").HasColumnName("id_item_etapa");
                    });

            entity.HasMany(d => d.IdSituacaos).WithMany(p => p.IdUnidades)
                .UsingEntity<Dictionary<string, object>>(
                    "RelSituacaoUnidade",
                    r => r.HasOne<Situacao>().WithMany()
                        .HasForeignKey("IdSituacao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_situacao_unid_situacao"),
                    l => l.HasOne<Unidade>().WithMany()
                        .HasForeignKey("IdUnidade")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_situacao_unid_unidade"),
                    j =>
                    {
                        j.HasKey("IdUnidade", "IdSituacao").HasName("pk_rel_situacao_unidade");
                        j.ToTable("rel_situacao_unidade");
                        j.HasIndex(new[] { "IdSituacao" }, "fk_rel_situacao_unid_situacao");
                        j.HasIndex(new[] { "IdUnidade" }, "fk_rel_situacao_unid_unidade");
                        j.IndexerProperty<int>("IdUnidade").HasColumnName("id_unidade");
                        j.IndexerProperty<int>("IdSituacao").HasColumnName("id_situacao");
                    });
        });

        modelBuilder.Entity<UnidadeFederacao>(entity =>
        {
            entity.HasKey(e => e.IdUnidadeFederacao).HasName("pk_unidade_federacao");

            entity.ToTable("unidade_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_unidade_fed_instalacao_fed");

            entity.Property(e => e.IdUnidadeFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_unidade_federacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.UnidadeFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_fed_instalacao_fed");
        });

        modelBuilder.Entity<UnidadeHistorico>(entity =>
        {
            entity.HasKey(e => e.IdUnidadeHistorico).HasName("pk_unidade_historico");

            entity.ToTable("unidade_historico");

            entity.HasIndex(e => e.IdOrgao, "fk_unidade_historico_orgao");

            entity.HasIndex(e => e.IdUnidade, "fk_unidade_historico_unidade");

            entity.HasIndex(e => new { e.DtaInicio, e.DtaFim, e.IdUnidade }, "i02_unidade_historico").IsUnique();

            entity.Property(e => e.IdUnidadeHistorico)
                .ValueGeneratedNever()
                .HasColumnName("id_unidade_historico");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.DtaFim)
                .HasColumnType("datetime")
                .HasColumnName("dta_fim");
            entity.Property(e => e.DtaInicio)
                .HasColumnType("datetime")
                .HasColumnName("dta_inicio");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.Sigla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.UnidadeHistoricos)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_historico_orgao");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.UnidadeHistoricos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_historico_unidade");
        });

        modelBuilder.Entity<UnidadePublicacao>(entity =>
        {
            entity.HasKey(e => e.IdUnidadePublicacao).HasName("pk_unidade_publicacao");

            entity.ToTable("unidade_publicacao");

            entity.HasIndex(e => e.IdUnidade, "fk_unidade_publicacao_unidade");

            entity.Property(e => e.IdUnidadePublicacao)
                .ValueGeneratedNever()
                .HasColumnName("id_unidade_publicacao");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.UnidadePublicacaos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidade_publicacao_unidade");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_usuario");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.IdContato, "fk_usuario_contato");

            entity.HasIndex(e => e.IdOrgao, "fk_usuario_orgao");

            entity.HasIndex(e => e.IdUsuarioFederacao, "fk_usuario_usuario_federacao");

            entity.HasIndex(e => new { e.IdOrgao, e.StaTipo, e.Sigla, e.IdxUsuario, e.SinAtivo }, "i01_usuario");

            entity.HasIndex(e => new { e.IdContato, e.StaTipo }, "i02_usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.IdContato).HasColumnName("id_contato");
            entity.Property(e => e.IdOrgao).HasColumnName("id_orgao");
            entity.Property(e => e.IdOrigem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_origem");
            entity.Property(e => e.IdUsuarioFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_usuario_federacao");
            entity.Property(e => e.IdxUsuario)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("idx_usuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NomeRegistroCivil)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_registro_civil");
            entity.Property(e => e.NomeSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome_social");
            entity.Property(e => e.Senha)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("senha");
            entity.Property(e => e.Sigla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sigla");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");

            entity.HasOne(d => d.IdContatoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdContato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_contato");

            entity.HasOne(d => d.IdOrgaoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdOrgao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_orgao");

            entity.HasOne(d => d.IdUsuarioFederacaoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdUsuarioFederacao)
                .HasConstraintName("fk_usuario_usuario_federacao");

            entity.HasMany(d => d.IdGrupoAcompanhamentos).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "RelUsuarioGrupoAcomp",
                    r => r.HasOne<GrupoAcompanhamento>().WithMany()
                        .HasForeignKey("IdGrupoAcompanhamento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usu_grp_acomp_grp_acomp"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_rel_usu_grp_acomp_usuario"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdGrupoAcompanhamento").HasName("pk_rel_usuario_grupo_acomp");
                        j.ToTable("rel_usuario_grupo_acomp");
                        j.HasIndex(new[] { "IdGrupoAcompanhamento" }, "fk_rel_usu_grp_acomp_grp_acomp");
                        j.HasIndex(new[] { "IdUsuario" }, "fk_rel_usu_grp_acomp_usuario");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("id_usuario");
                        j.IndexerProperty<int>("IdGrupoAcompanhamento").HasColumnName("id_grupo_acompanhamento");
                    });
        });

        modelBuilder.Entity<UsuarioFederacao>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioFederacao).HasName("pk_usuario_federacao");

            entity.ToTable("usuario_federacao");

            entity.HasIndex(e => e.IdInstalacaoFederacao, "fk_usuario_fed_instalacao_fed");

            entity.Property(e => e.IdUsuarioFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_usuario_federacao");
            entity.Property(e => e.IdInstalacaoFederacao)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("id_instalacao_federacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sigla");

            entity.HasOne(d => d.IdInstalacaoFederacaoNavigation).WithMany(p => p.UsuarioFederacaos)
                .HasForeignKey(d => d.IdInstalacaoFederacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_fed_instalacao_fed");
        });

        modelBuilder.Entity<VeiculoImprensaNacional>(entity =>
        {
            entity.HasKey(e => e.IdVeiculoImprensaNacional).HasName("pk_veiculo_imprensa_nacional");

            entity.ToTable("veiculo_imprensa_nacional");

            entity.Property(e => e.IdVeiculoImprensaNacional)
                .ValueGeneratedNever()
                .HasColumnName("id_veiculo_imprensa_nacional");
            entity.Property(e => e.Descricao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Sigla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sigla");
        });

        modelBuilder.Entity<VeiculoPublicacao>(entity =>
        {
            entity.HasKey(e => e.IdVeiculoPublicacao).HasName("pk_veiculo_publicacao");

            entity.ToTable("veiculo_publicacao");

            entity.Property(e => e.IdVeiculoPublicacao)
                .ValueGeneratedNever()
                .HasColumnName("id_veiculo_publicacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
            entity.Property(e => e.SinExibirPesquisaInterna)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_exibir_pesquisa_interna");
            entity.Property(e => e.SinFonteFeriados)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_fonte_feriados");
            entity.Property(e => e.SinPermiteExtraordinaria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_permite_extraordinaria");
            entity.Property(e => e.StaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sta_tipo");
            entity.Property(e => e.WebService)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("web_service");
        });

        modelBuilder.Entity<VersaoSecaoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdVersaoSecaoDocumento).HasName("pk_versao_secao_documento");

            entity.ToTable("versao_secao_documento");

            entity.HasIndex(e => e.IdSecaoDocumento, "fk_versao_sec_doc_sec_doc");

            entity.HasIndex(e => e.IdUnidade, "fk_versao_secao_doc_unidade");

            entity.HasIndex(e => e.IdUsuario, "fk_versao_secao_doc_usuario");

            entity.HasIndex(e => new { e.IdSecaoDocumento, e.Versao }, "i01_versao_secao_documento");

            entity.Property(e => e.IdVersaoSecaoDocumento)
                .ValueGeneratedNever()
                .HasColumnName("id_versao_secao_documento");
            entity.Property(e => e.Conteudo)
                .IsUnicode(false)
                .HasColumnName("conteudo");
            entity.Property(e => e.DthAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("dth_atualizacao");
            entity.Property(e => e.IdSecaoDocumento).HasColumnName("id_secao_documento");
            entity.Property(e => e.IdUnidade).HasColumnName("id_unidade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.SinUltima)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ultima");
            entity.Property(e => e.Versao).HasColumnName("versao");

            entity.HasOne(d => d.IdSecaoDocumentoNavigation).WithMany(p => p.VersaoSecaoDocumentos)
                .HasForeignKey(d => d.IdSecaoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_versao_sec_doc_sec_doc");

            entity.HasOne(d => d.IdUnidadeNavigation).WithMany(p => p.VersaoSecaoDocumentos)
                .HasForeignKey(d => d.IdUnidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_versao_secao_doc_unidade");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.VersaoSecaoDocumentos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_versao_secao_doc_usuario");
        });

        modelBuilder.Entity<Vocativo>(entity =>
        {
            entity.HasKey(e => e.IdVocativo).HasName("pk_vocativo");

            entity.ToTable("vocativo");

            entity.HasIndex(e => new { e.IdVocativo, e.SinAtivo }, "ie1_vocativo");

            entity.Property(e => e.IdVocativo)
                .ValueGeneratedNever()
                .HasColumnName("id_vocativo");
            entity.Property(e => e.Expressao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("expressao");
            entity.Property(e => e.SinAtivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sin_ativo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
