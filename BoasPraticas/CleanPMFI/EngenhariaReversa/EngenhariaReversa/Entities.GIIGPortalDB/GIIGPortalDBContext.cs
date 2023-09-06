using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class GIIGPortalDBContext : DbContext
    {
        public GIIGPortalDBContext()
        {
        }

        public GIIGPortalDBContext(DbContextOptions<GIIGPortalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAciInteressado> TbAciInteressados { get; set; } = null!;
        public virtual DbSet<TbAciSolicitacao> TbAciSolicitacaos { get; set; } = null!;
        public virtual DbSet<TbAciSolicitacaoAnexo> TbAciSolicitacaoAnexos { get; set; } = null!;
        public virtual DbSet<TbAciSolicitacaoDespacho> TbAciSolicitacaoDespachos { get; set; } = null!;
        public virtual DbSet<TbAciSolicitacaoDespachoAnexo> TbAciSolicitacaoDespachoAnexos { get; set; } = null!;
        public virtual DbSet<TbAciTipoRecebimento> TbAciTipoRecebimentos { get; set; } = null!;
        public virtual DbSet<TbAciTipoUnidade> TbAciTipoUnidades { get; set; } = null!;
        public virtual DbSet<TbAciUnidade> TbAciUnidades { get; set; } = null!;
        public virtual DbSet<TbForDownloadsFornecedor> TbForDownloadsFornecedors { get; set; } = null!;
        public virtual DbSet<TbForDownloadsLicitaco> TbForDownloadsLicitacoes { get; set; } = null!;
        public virtual DbSet<TbForDownloadsLicitacoesObjeto> TbForDownloadsLicitacoesObjetos { get; set; } = null!;
        public virtual DbSet<TbForFornecedore> TbForFornecedores { get; set; } = null!;
        public virtual DbSet<TbForLicitacoesParticipante> TbForLicitacoesParticipantes { get; set; } = null!;
        public virtual DbSet<TbForLogAcesso> TbForLogAcessos { get; set; } = null!;
        public virtual DbSet<TbForLogAutenticacao> TbForLogAutenticacaos { get; set; } = null!;
        public virtual DbSet<TbGerEmpresasGoverno> TbGerEmpresasGovernos { get; set; } = null!;
        public virtual DbSet<TbGerLogAcesso> TbGerLogAcessos { get; set; } = null!;
        public virtual DbSet<TbGerSistema> TbGerSistemas { get; set; } = null!;
        public virtual DbSet<TbGerTipoContato> TbGerTipoContatos { get; set; } = null!;
        public virtual DbSet<TbNavBanner> TbNavBanners { get; set; } = null!;
        public virtual DbSet<TbNavGrupoPerguntasFrequente> TbNavGrupoPerguntasFrequentes { get; set; } = null!;
        public virtual DbSet<TbNavLinkIten> TbNavLinkItens { get; set; } = null!;
        public virtual DbSet<TbNavLinkItensPermissao> TbNavLinkItensPermissaos { get; set; } = null!;
        public virtual DbSet<TbNavLinkModulo> TbNavLinkModulos { get; set; } = null!;
        public virtual DbSet<TbNavPaginasPadrao> TbNavPaginasPadraos { get; set; } = null!;
        public virtual DbSet<TbNavPerguntasFrequente> TbNavPerguntasFrequentes { get; set; } = null!;
        public virtual DbSet<TbNfseLayoutDefault> TbNfseLayoutDefaults { get; set; } = null!;
        public virtual DbSet<TbNfseLayoutDefaultPasso> TbNfseLayoutDefaultPassos { get; set; } = null!;
        public virtual DbSet<TbPubAgendaAutoridade> TbPubAgendaAutoridades { get; set; } = null!;
        public virtual DbSet<TbPubAgendaCompromisso> TbPubAgendaCompromissos { get; set; } = null!;
        public virtual DbSet<TbPubAgendaCompromissosDocumento> TbPubAgendaCompromissosDocumentos { get; set; } = null!;
        public virtual DbSet<TbPubArquivo> TbPubArquivos { get; set; } = null!;
        public virtual DbSet<TbPubArquivosListum> TbPubArquivosLista { get; set; } = null!;
        public virtual DbSet<TbPubCategoria> TbPubCategorias { get; set; } = null!;
        public virtual DbSet<TbPubErrosExecucaoFonteDado> TbPubErrosExecucaoFonteDados { get; set; } = null!;
        public virtual DbSet<TbPubExibicaoPessoal> TbPubExibicaoPessoals { get; set; } = null!;
        public virtual DbSet<TbPubFonteDado> TbPubFonteDados { get; set; } = null!;
        public virtual DbSet<TbPubFonteDadosFiltro> TbPubFonteDadosFiltros { get; set; } = null!;
        public virtual DbSet<TbPubVisaoFonteDado> TbPubVisaoFonteDados { get; set; } = null!;
        public virtual DbSet<TbPubVisaoNotaRodape> TbPubVisaoNotaRodapes { get; set; } = null!;
        public virtual DbSet<TbTmpAdiantamentoDespesaOrigem> TbTmpAdiantamentoDespesaOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpAdiantamentoDespesaPti> TbTmpAdiantamentoDespesaPtis { get; set; } = null!;
        public virtual DbSet<TbTmpAgentesPublicosOrigem> TbTmpAgentesPublicosOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpAgentesPublicosPti> TbTmpAgentesPublicosPtis { get; set; } = null!;
        public virtual DbSet<TbTmpAlmoxarifado> TbTmpAlmoxarifados { get; set; } = null!;
        public virtual DbSet<TbTmpAlmoxarifadoPti> TbTmpAlmoxarifadoPtis { get; set; } = null!;
        public virtual DbSet<TbTmpApoioCargaPti> TbTmpApoioCargaPtis { get; set; } = null!;
        public virtual DbSet<TbTmpApoioCargaPti1> TbTmpApoioCargaPti1s { get; set; } = null!;
        public virtual DbSet<TbTmpApoioCargaPti2> TbTmpApoioCargaPti2s { get; set; } = null!;
        public virtual DbSet<TbTmpBensPatrimoniai> TbTmpBensPatrimoniais { get; set; } = null!;
        public virtual DbSet<TbTmpBensPatrimoniaisPti> TbTmpBensPatrimoniaisPtis { get; set; } = null!;
        public virtual DbSet<TbTmpCapConvAuxPrograma> TbTmpCapConvAuxProgramas { get; set; } = null!;
        public virtual DbSet<TbTmpContasCorrente> TbTmpContasCorrentes { get; set; } = null!;
        public virtual DbSet<TbTmpContrato> TbTmpContratos { get; set; } = null!;
        public virtual DbSet<TbTmpContratosAditivo> TbTmpContratosAditivos { get; set; } = null!;
        public virtual DbSet<TbTmpContratosOrigem> TbTmpContratosOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpContratosPti> TbTmpContratosPtis { get; set; } = null!;
        public virtual DbSet<TbTmpContratosV2> TbTmpContratosV2s { get; set; } = null!;
        public virtual DbSet<TbTmpCotacaoIten> TbTmpCotacaoItens { get; set; } = null!;
        public virtual DbSet<TbTmpDdrorigem> TbTmpDdrorigems { get; set; } = null!;
        public virtual DbSet<TbTmpDespesa> TbTmpDespesas { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaEmpPagarOrigem> TbTmpDespesaEmpPagarOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaEmpenhadum> TbTmpDespesaEmpenhada { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaExtra> TbTmpDespesaExtras { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaFornecedore> TbTmpDespesaFornecedores { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaLiquidadaOrigem> TbTmpDespesaLiquidadaOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaPaga> TbTmpDespesaPagas { get; set; } = null!;
        public virtual DbSet<TbTmpDespesaTransporteOrigem> TbTmpDespesaTransporteOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpDespesasCorona> TbTmpDespesasCoronas { get; set; } = null!;
        public virtual DbSet<TbTmpDiaria> TbTmpDiarias { get; set; } = null!;
        public virtual DbSet<TbTmpDiariasEmpenho> TbTmpDiariasEmpenhos { get; set; } = null!;
        public virtual DbSet<TbTmpDiariasOrigem> TbTmpDiariasOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpExtratoBancarioOrigem> TbTmpExtratoBancarioOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpFolhaPagamento> TbTmpFolhaPagamentos { get; set; } = null!;
        public virtual DbSet<TbTmpFolhaPagamentoAssistSocial> TbTmpFolhaPagamentoAssistSocials { get; set; } = null!;
        public virtual DbSet<TbTmpFolhaPagamentoAssistSocialCont> TbTmpFolhaPagamentoAssistSocialConts { get; set; } = null!;
        public virtual DbSet<TbTmpFolhaPagamentoBk> TbTmpFolhaPagamentoBks { get; set; } = null!;
        public virtual DbSet<TbTmpFolhaPagamentoOrigem> TbTmpFolhaPagamentoOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpInfoAdministrativaOrigem> TbTmpInfoAdministrativaOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpLicitacaoParticipante> TbTmpLicitacaoParticipantes { get; set; } = null!;
        public virtual DbSet<TbTmpLicitaco> TbTmpLicitacoes { get; set; } = null!;
        public virtual DbSet<TbTmpLicitacoesCorona> TbTmpLicitacoesCoronas { get; set; } = null!;
        public virtual DbSet<TbTmpLicitacoesOrigem> TbTmpLicitacoesOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpLicitacoesv2> TbTmpLicitacoesv2s { get; set; } = null!;
        public virtual DbSet<TbTmpNotasFiscaisDetalhesOrigem> TbTmpNotasFiscaisDetalhesOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpNotasFiscaisOrigem> TbTmpNotasFiscaisOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpNotasFiscaisPti> TbTmpNotasFiscaisPtis { get; set; } = null!;
        public virtual DbSet<TbTmpOrcReceita> TbTmpOrcReceitas { get; set; } = null!;
        public virtual DbSet<TbTmpOrcReceitasArrecadaAno> TbTmpOrcReceitasArrecadaAnos { get; set; } = null!;
        public virtual DbSet<TbTmpOrcReceitasMovimento> TbTmpOrcReceitasMovimentos { get; set; } = null!;
        public virtual DbSet<TbTmpPagamentosAssistSocial> TbTmpPagamentosAssistSocials { get; set; } = null!;
        public virtual DbSet<TbTmpPagamentosAssistSocialParceria> TbTmpPagamentosAssistSocialParcerias { get; set; } = null!;
        public virtual DbSet<TbTmpPassagen> TbTmpPassagens { get; set; } = null!;
        public virtual DbSet<TbTmpPublicidadeEmpenho> TbTmpPublicidadeEmpenhos { get; set; } = null!;
        public virtual DbSet<TbTmpPublicidadeEmpenhoCovid> TbTmpPublicidadeEmpenhoCovids { get; set; } = null!;
        public virtual DbSet<TbTmpQuadroFuncionalOrigem> TbTmpQuadroFuncionalOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpRazaoContabil> TbTmpRazaoContabils { get; set; } = null!;
        public virtual DbSet<TbTmpRazaoContabilOld> TbTmpRazaoContabilOlds { get; set; } = null!;
        public virtual DbSet<TbTmpRazaoContabilOld1> TbTmpRazaoContabilOld1s { get; set; } = null!;
        public virtual DbSet<TbTmpReceita> TbTmpReceitas { get; set; } = null!;
        public virtual DbSet<TbTmpReceitaArrecadaOrigem> TbTmpReceitaArrecadaOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpReceitasCovid> TbTmpReceitasCovids { get; set; } = null!;
        public virtual DbSet<TbTmpReceitasDdanovo> TbTmpReceitasDdanovos { get; set; } = null!;
        public virtual DbSet<TbTmpReceitasOrigem> TbTmpReceitasOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpReceitasSuporte> TbTmpReceitasSuportes { get; set; } = null!;
        public virtual DbSet<TbTmpServidoresCedido> TbTmpServidoresCedidos { get; set; } = null!;
        public virtual DbSet<TbTmpServidoresRecebido> TbTmpServidoresRecebidos { get; set; } = null!;
        public virtual DbSet<TbTmpServidoresTemporario> TbTmpServidoresTemporarios { get; set; } = null!;
        public virtual DbSet<TbTmpServidoresTemporariosOrigem> TbTmpServidoresTemporariosOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpSubvencoesAditivo> TbTmpSubvencoesAditivos { get; set; } = null!;
        public virtual DbSet<TbTmpSubvencoesSociai> TbTmpSubvencoesSociais { get; set; } = null!;
        public virtual DbSet<TbTmpSubvencoesSociaisOrigem> TbTmpSubvencoesSociaisOrigems { get; set; } = null!;
        public virtual DbSet<TbTmpSubvencoesSociaisPti> TbTmpSubvencoesSociaisPtis { get; set; } = null!;
        public virtual DbSet<TbTmpTransfVoluntariaOrigem> TbTmpTransfVoluntariaOrigems { get; set; } = null!;
        public virtual DbSet<VwDimReceita2ano> VwDimReceita2anos { get; set; } = null!;
        public virtual DbSet<VwFatArrecadacao2ano> VwFatArrecadacao2anos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGPortalDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<TbAciInteressado>(entity =>
            {
                entity.HasKey(e => e.IdInteressado);

                entity.ToTable("tbAciInteressados");

                entity.Property(e => e.IdInteressado).HasColumnName("idInteressado");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.IdProtocolo).HasColumnName("idProtocolo");

                entity.Property(e => e.NmInteressado)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmInteressado");

                entity.HasMany(d => d.IdUnidades)
                    .WithMany(p => p.IdInteressados)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbAciInteressadosUnidade",
                        l => l.HasOne<TbAciUnidade>().WithMany().HasForeignKey("IdUnidade").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbAciInteressadosUnidades_tbAciUnidades"),
                        r => r.HasOne<TbAciInteressado>().WithMany().HasForeignKey("IdInteressado").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbAciInteressadosUnidades_tbAciInteressados"),
                        j =>
                        {
                            j.HasKey("IdInteressado", "IdUnidade");

                            j.ToTable("tbAciInteressadosUnidades");

                            j.IndexerProperty<int>("IdInteressado").HasColumnName("idInteressado");

                            j.IndexerProperty<int>("IdUnidade").HasColumnName("idUnidade");
                        });
            });

            modelBuilder.Entity<TbAciSolicitacao>(entity =>
            {
                entity.HasKey(e => e.IdSolicitacao);

                entity.ToTable("tbAciSolicitacao");

                entity.HasIndex(e => e.IdInteressadoDespachoAtual, "IX_tbAciSolicitacao_idInteressadoDespachoAtual");

                entity.HasIndex(e => e.IdTipoRecebimento, "IX_tbAciSolicitacao_idTipoRecebimento");

                entity.Property(e => e.IdSolicitacao).HasColumnName("idSolicitacao");

                entity.Property(e => e.DsBairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsBairro");

                entity.Property(e => e.DsCep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dsCep");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsEspecificacaoPedido)
                    .IsUnicode(false)
                    .HasColumnName("dsEspecificacaoPedido");

                entity.Property(e => e.DsLogradouro)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsLogradouro");

                entity.Property(e => e.DsParecerFinal)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("dsParecerFinal");

                entity.Property(e => e.DsStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsStatus");

                entity.Property(e => e.DsTipoPessoa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoPessoa");

                entity.Property(e => e.DtSolicitcao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtSolicitcao");

                entity.Property(e => e.IdInteressadoDespachoAtual).HasColumnName("idInteressadoDespachoAtual");

                entity.Property(e => e.IdTipoRecebimento).HasColumnName("idTipoRecebimento");

                entity.Property(e => e.NmCidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmCidade");

                entity.Property(e => e.NmEstado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("nmEstado");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrPredial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nrPredial");

                entity.Property(e => e.NrSolicitacao).HasColumnName("nrSolicitacao");

                entity.Property(e => e.NrTelefones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nrTelefones");

                entity.Property(e => e.ProcAno).HasColumnName("procAno");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.Property(e => e.ProcSequencia).HasColumnName("procSequencia");

                entity.Property(e => e.TpRecebimento)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tpRecebimento");
            });

            modelBuilder.Entity<TbAciSolicitacaoAnexo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitacaoAnexo);

                entity.ToTable("tbAciSolicitacaoAnexo");

                entity.Property(e => e.IdSolicitacaoAnexo).HasColumnName("idSolicitacaoAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.IdSolicitacao).HasColumnName("idSolicitacao");

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");

                entity.HasOne(d => d.IdSolicitacaoNavigation)
                    .WithMany(p => p.TbAciSolicitacaoAnexos)
                    .HasForeignKey(d => d.IdSolicitacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAciSolicitacaoAnexo_tbAciSolicitacao");
            });

            modelBuilder.Entity<TbAciSolicitacaoDespacho>(entity =>
            {
                entity.HasKey(e => e.IdSolicitacaoDespacho);

                entity.ToTable("tbAciSolicitacaoDespacho");

                entity.HasIndex(e => e.IdInteressadoEmitente, "IX_tbAciSolicitacaoDespacho_idInteressadoEmitente");

                entity.HasIndex(e => e.IdInteressadoRecebedor, "IX_tbAciSolicitacaoDespacho_idInteressadoRecebedor");

                entity.HasIndex(e => e.IdSolicitacao, "IX_tbAciSolicitacaoDespacho_idSolicitacao");

                entity.Property(e => e.IdSolicitacaoDespacho).HasColumnName("idSolicitacaoDespacho");

                entity.Property(e => e.DsParecer)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("dsParecer");

                entity.Property(e => e.DtDespacho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDespacho");

                entity.Property(e => e.IdInteressadoEmitente).HasColumnName("idInteressadoEmitente");

                entity.Property(e => e.IdInteressadoRecebedor).HasColumnName("idInteressadoRecebedor");

                entity.Property(e => e.IdSolicitacao).HasColumnName("idSolicitacao");

                entity.HasOne(d => d.IdInteressadoRecebedorNavigation)
                    .WithMany(p => p.TbAciSolicitacaoDespachos)
                    .HasForeignKey(d => d.IdInteressadoRecebedor)
                    .HasConstraintName("FK_tbAciSolicitacaoDespacho_tbAciInteressados");

                entity.HasOne(d => d.IdSolicitacaoNavigation)
                    .WithMany(p => p.TbAciSolicitacaoDespachos)
                    .HasForeignKey(d => d.IdSolicitacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAciSolicitacaoDespacho_tbAciSolicitacao");
            });

            modelBuilder.Entity<TbAciSolicitacaoDespachoAnexo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitacaoDespachoAnexo);

                entity.ToTable("tbAciSolicitacaoDespachoAnexo");

                entity.HasIndex(e => e.IdSolicitacaoDespacho, "IX_tbAciSolicitacaoDespachoAnexo_idSolicitacaoDespacho");

                entity.Property(e => e.IdSolicitacaoDespachoAnexo).HasColumnName("idSolicitacaoDespachoAnexo");

                entity.Property(e => e.BnObjeto).HasColumnName("bnObjeto");

                entity.Property(e => e.DsExtencao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsExtencao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlEncaminhaSolicitante)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flEncaminhaSolicitante")
                    .IsFixedLength();

                entity.Property(e => e.IdSolicitacaoDespacho).HasColumnName("idSolicitacaoDespacho");

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");

                entity.HasOne(d => d.IdSolicitacaoDespachoNavigation)
                    .WithMany(p => p.TbAciSolicitacaoDespachoAnexos)
                    .HasForeignKey(d => d.IdSolicitacaoDespacho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbAciSolicitacaoDespachoAnexo_tbAciSolicitacaoDespacho");
            });

            modelBuilder.Entity<TbAciTipoRecebimento>(entity =>
            {
                entity.HasKey(e => e.IdTipoRecebimento);

                entity.ToTable("tbAciTipoRecebimento");

                entity.Property(e => e.IdTipoRecebimento).HasColumnName("idTipoRecebimento");

                entity.Property(e => e.CdTipoRecebimento).HasColumnName("cdTipoRecebimento");

                entity.Property(e => e.DsObservacoes)
                    .HasMaxLength(255)
                    .HasColumnName("dsObservacoes");

                entity.Property(e => e.DsTipoRecebimento)
                    .HasMaxLength(50)
                    .HasColumnName("dsTipoRecebimento");

                entity.Property(e => e.FlGeraCusto)
                    .HasMaxLength(1)
                    .HasColumnName("flGeraCusto")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbAciTipoUnidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidade);

                entity.ToTable("tbAciTipoUnidades");

                entity.Property(e => e.IdTipoUnidade).HasColumnName("idTipoUnidade");

                entity.Property(e => e.CdTipoUnidade).HasColumnName("cdTipoUnidade");

                entity.Property(e => e.DsTipoUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoUnidade");
            });

            modelBuilder.Entity<TbAciUnidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidade);

                entity.ToTable("tbAciUnidades");

                entity.HasIndex(e => e.IdInteressadoAtual, "IX_tbAciUnidades_idInteressadoAtual");

                entity.HasIndex(e => e.IdTipoUnidade, "IX_tbAciUnidades_idTipoUnidade");

                entity.Property(e => e.IdUnidade).HasColumnName("idUnidade");

                entity.Property(e => e.IdInteressadoAtual).HasColumnName("idInteressadoAtual");

                entity.Property(e => e.IdTipoUnidade).HasColumnName("idTipoUnidade");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrTelefones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nrTelefones");

                entity.HasOne(d => d.IdTipoUnidadeNavigation)
                    .WithMany(p => p.TbAciUnidades)
                    .HasForeignKey(d => d.IdTipoUnidade)
                    .HasConstraintName("FK_tbAciUnidades_tbAciTipoUnidades");
            });

            modelBuilder.Entity<TbForDownloadsFornecedor>(entity =>
            {
                entity.HasKey(e => new { e.IdFornecedor, e.IdLicitacao, e.IdObjeto });

                entity.ToTable("tbForDownloadsFornecedor");

                entity.Property(e => e.DtUltimoDowload)
                    .HasColumnType("datetime")
                    .HasColumnName("dtUltimoDowload");

                entity.Property(e => e.NrDownloads).HasColumnName("nrDownloads");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbForDownloadsFornecedors)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbForDownloadsFornecedor_tbForFornecedores");
            });

            modelBuilder.Entity<TbForDownloadsLicitaco>(entity =>
            {
                entity.HasKey(e => new { e.IdLicitacao, e.IdObjeto });

                entity.ToTable("tbForDownloadsLicitacoes");

                entity.Property(e => e.DtMaxDownload)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMaxDownload");

                entity.HasOne(d => d.IdObjetoNavigation)
                    .WithMany(p => p.TbForDownloadsLicitacos)
                    .HasForeignKey(d => d.IdObjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbForDownloadsLicitacoes_tbForDownloadsLicitacoesObjetos");
            });

            modelBuilder.Entity<TbForDownloadsLicitacoesObjeto>(entity =>
            {
                entity.HasKey(e => e.IdObjeto);

                entity.ToTable("tbForDownloadsLicitacoesObjetos");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(255)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.NmObjeto)
                    .HasMaxLength(50)
                    .HasColumnName("nmObjeto");
            });

            modelBuilder.Entity<TbForFornecedore>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.ToTable("tbForFornecedores");

                entity.HasIndex(e => e.IdEndereco, "IX_tbForFornecedores_idEndereco");

                entity.Property(e => e.BnSenha)
                    .HasMaxLength(50)
                    .HasColumnName("bnSenha");

                entity.Property(e => e.DsAtividade)
                    .IsUnicode(false)
                    .HasColumnName("dsAtividade");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsSite)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsSite");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.DsTipoPessoa)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoPessoa");

                entity.Property(e => e.FlAssociadoSindicato)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flAssociadoSindicato")
                    .IsFixedLength();

                entity.Property(e => e.FlClientesAreaPublica)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flClientesAreaPublica")
                    .IsFixedLength();

                entity.Property(e => e.IdEndereco).HasColumnName("idEndereco");

                entity.Property(e => e.NmBairro)
                    .HasMaxLength(200)
                    .HasColumnName("nmBairro");

                entity.Property(e => e.NmCidade)
                    .HasMaxLength(200)
                    .HasColumnName("nmCidade");

                entity.Property(e => e.NmFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmFantasia");

                entity.Property(e => e.NmLogradouro)
                    .HasMaxLength(200)
                    .HasColumnName("nmLogradouro");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmPessoaResponsavel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoaResponsavel");

                entity.Property(e => e.NmUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("nmUF")
                    .IsFixedLength();

                entity.Property(e => e.NrCelular)
                    .HasMaxLength(15)
                    .HasColumnName("nrCelular");

                entity.Property(e => e.NrCep)
                    .HasMaxLength(8)
                    .HasColumnName("nrCep");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrFax)
                    .HasMaxLength(15)
                    .HasColumnName("nrFax");

                entity.Property(e => e.NrPredial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nrPredial");

                entity.Property(e => e.NrRegistroJuntaComercial)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrRegistroJuntaComercial");

                entity.Property(e => e.NrRgIe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrRg_IE");

                entity.Property(e => e.NrTelefone)
                    .HasMaxLength(15)
                    .HasColumnName("nrTelefone");
            });

            modelBuilder.Entity<TbForLicitacoesParticipante>(entity =>
            {
                entity.HasKey(e => new { e.IdLicitacao, e.IdFornecedor });

                entity.ToTable("tbForLicitacoesParticipantes");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbForLicitacoesParticipantes)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbForLicitacoesParticipantes_tbForFornecedores");
            });

            modelBuilder.Entity<TbForLogAcesso>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbForLogAcesso");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsSessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSessionID");

                entity.Property(e => e.DtLogIn)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLogIn");

                entity.Property(e => e.DtLogOut)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLogOut");

                entity.Property(e => e.DtUltInteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtUltInteracao");

                entity.Property(e => e.NmForm)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("nmForm");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");
            });

            modelBuilder.Entity<TbForLogAutenticacao>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbForLogAutenticacao");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsOcorrencia)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("dsOcorrencia");

                entity.Property(e => e.DsSessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSessionID");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("dtOcorrencia");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");
            });

            modelBuilder.Entity<TbGerEmpresasGoverno>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.IdSistema });

                entity.ToTable("tbGerEmpresasGoverno");

                entity.Property(e => e.Idempresa).HasColumnName("IDEmpresa");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsEndereco)
                    .HasMaxLength(200)
                    .HasColumnName("dsEndereco");

                entity.Property(e => e.DsEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsEstado");

                entity.Property(e => e.DsExtensaoLogo)
                    .HasMaxLength(50)
                    .HasColumnName("dsExtensaoLogo");

                entity.Property(e => e.DsFax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsFax");

                entity.Property(e => e.DsFone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsFone");

                entity.Property(e => e.DsNomeLogo)
                    .HasMaxLength(50)
                    .HasColumnName("dsNomeLogo");

                entity.Property(e => e.DsPagina)
                    .IsUnicode(false)
                    .HasColumnName("dsPagina");

                entity.Property(e => e.DsTelAtendimento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsTelAtendimento");

                entity.Property(e => e.DsTipoEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoEmpresa")
                    .HasComment("Se é Prefeitura/Câmara/Autarquia/Previência");

                entity.Property(e => e.DslinkAtendimentoCidadao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dslinkAtendimentoCidadao");

                entity.Property(e => e.ImLogoGrande)
                    .HasColumnType("image")
                    .HasColumnName("imLogoGrande");

                entity.Property(e => e.ImLogoPequena)
                    .HasColumnType("image")
                    .HasColumnName("imLogoPequena");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");
            });

            modelBuilder.Entity<TbGerLogAcesso>(entity =>
            {
                entity.HasKey(e => e.IdLogAcesso);

                entity.ToTable("tbGerLogAcessos");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbGerLogAcessos_IdEmpresa");

                entity.HasIndex(e => e.IdLinkItem, "IX_tbGerLogAcessos_IdLinkItem");

                entity.HasIndex(e => e.IdSistema, "IX_tbGerLogAcessos_IdSistema");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsUrl)
                    .HasMaxLength(255)
                    .HasColumnName("dsUrl");

                entity.Property(e => e.DtAcesso)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAcesso");

                entity.Property(e => e.NmNavegador).HasColumnName("nmNavegador");
            });

            modelBuilder.Entity<TbGerSistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema)
                    .HasName("PK_tbGerSisitemas");

                entity.ToTable("tbGerSistemas");

                entity.Property(e => e.DsSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSistema");
            });

            modelBuilder.Entity<TbGerTipoContato>(entity =>
            {
                entity.HasKey(e => e.IdTipoContato);

                entity.ToTable("tbGerTipoContato");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbGerTipoContato_IdEmpresa");

                entity.HasIndex(e => e.IdSistema, "IX_tbGerTipoContato_IdSistema");

                entity.Property(e => e.IdTipoContato).HasColumnName("idTipoContato");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(150)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsTipoContato)
                    .HasMaxLength(50)
                    .HasColumnName("dsTipoContato");

                entity.Property(e => e.NrEnvios).HasColumnName("nrEnvios");
            });

            modelBuilder.Entity<TbNavBanner>(entity =>
            {
                entity.HasKey(e => e.IdBanner);

                entity.ToTable("tbNavBanners");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbNavBanners_IdEmpresa");

                entity.HasIndex(e => e.IdSistema, "IX_tbNavBanners_IdSistema");

                entity.Property(e => e.BnBanner)
                    .HasColumnType("image")
                    .HasColumnName("bnBanner");

                entity.Property(e => e.DsExtensaoBanner)
                    .HasMaxLength(5)
                    .HasColumnName("dsExtensaoBanner");

                entity.Property(e => e.DsLink)
                    .HasMaxLength(150)
                    .HasColumnName("dsLink");

                entity.Property(e => e.DsNomeBanner)
                    .HasMaxLength(50)
                    .HasColumnName("dsNomeBanner");

                entity.Property(e => e.FlVisivel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flVisivel")
                    .IsFixedLength();

                entity.Property(e => e.NrAltura).HasColumnName("nrAltura");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbNavGrupoPerguntasFrequente>(entity =>
            {
                entity.HasKey(e => e.IdGrupoPerguntaFrequente);

                entity.ToTable("tbNavGrupoPerguntasFrequentes");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbNavGrupoPerguntasFrequentes_IdEmpresa");

                entity.HasIndex(e => e.IdSistema, "IX_tbNavGrupoPerguntasFrequentes_IdSistema");

                entity.Property(e => e.DsGrupoPerguntaFrequente)
                    .HasMaxLength(50)
                    .HasColumnName("dsGrupoPerguntaFrequente");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbNavLinkIten>(entity =>
            {
                entity.HasKey(e => e.IdLinkItem)
                    .HasName("PK_tbNavLinkItem");

                entity.ToTable("tbNavLinkItens");

                entity.HasIndex(e => e.IdLinkModulo, "IX_tbNavLinkItens_IdLinkModulo");

                entity.Property(e => e.DsLinkItem)
                    .HasMaxLength(300)
                    .HasColumnName("dsLinkItem");

                entity.Property(e => e.DsTituloPagina)
                    .HasMaxLength(100)
                    .HasColumnName("dsTituloPagina");

                entity.Property(e => e.Dslink)
                    .HasMaxLength(400)
                    .HasColumnName("dslink");

                entity.Property(e => e.FlManutencao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flManutencao")
                    .IsFixedLength();

                entity.Property(e => e.FlUsaPaginaPadrao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flUsaPaginaPadrao")
                    .IsFixedLength();

                entity.Property(e => e.FlVisivel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flVisivel")
                    .IsFixedLength();

                entity.Property(e => e.NmLinkItem)
                    .HasMaxLength(300)
                    .HasColumnName("nmLinkItem");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");

                entity.Property(e => e.NrVisualizacoes).HasColumnName("nrVisualizacoes");

                entity.HasOne(d => d.IdLinkModuloNavigation)
                    .WithMany(p => p.TbNavLinkItens)
                    .HasForeignKey(d => d.IdLinkModulo)
                    .HasConstraintName("FK_tbNavLinkItem_tbNavLinkModulos");
            });

            modelBuilder.Entity<TbNavLinkItensPermissao>(entity =>
            {
                entity.HasKey(e => new { e.IdLinkItem, e.DsLogin });

                entity.ToTable("tbNavLinkItensPermissao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .HasColumnName("dsLogin");

                entity.HasOne(d => d.IdLinkItemNavigation)
                    .WithMany(p => p.TbNavLinkItensPermissaos)
                    .HasForeignKey(d => d.IdLinkItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbNavLinkItensPermissao_tbNavLinkItens");
            });

            modelBuilder.Entity<TbNavLinkModulo>(entity =>
            {
                entity.HasKey(e => e.IdLinkModulo);

                entity.ToTable("tbNavLinkModulos");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbNavLinkModulos_IdEmpresa");

                entity.HasIndex(e => e.IdSistema, "IX_tbNavLinkModulos_IdSistema");

                entity.Property(e => e.FlExibiMapa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flExibiMapa")
                    .IsFixedLength();

                entity.Property(e => e.FlVerificaAutenticacao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flVerificaAutenticacao")
                    .IsFixedLength();

                entity.Property(e => e.FlVisivel)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flVisivel")
                    .IsFixedLength();

                entity.Property(e => e.NmLinkModulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmLinkModulo");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbNavPaginasPadrao>(entity =>
            {
                entity.HasKey(e => e.IdPaginaPadrao)
                    .HasName("PK_tbNavPaginaPadrao");

                entity.ToTable("tbNavPaginasPadrao");

                entity.HasIndex(e => e.IdLinkItem, "IX_tbNavPaginasPadrao_idLinkItem");

                entity.Property(e => e.DsCorpoPagina).HasColumnName("dsCorpoPagina");

                entity.Property(e => e.FlUsaTituloPagina)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flUsaTituloPagina")
                    .IsFixedLength();

                entity.HasOne(d => d.IdLinkItemNavigation)
                    .WithMany(p => p.TbNavPaginasPadraos)
                    .HasForeignKey(d => d.IdLinkItem)
                    .HasConstraintName("FK_tbNavPaginaPadrao_tbNavLinkItens");
            });

            modelBuilder.Entity<TbNavPerguntasFrequente>(entity =>
            {
                entity.HasKey(e => e.IdPerguntaFrequente);

                entity.ToTable("tbNavPerguntasFrequentes");

                entity.HasIndex(e => e.IdGrupoPerguntaFrequente, "IX_tbNavPerguntasFrequentes_IdGrupoPerguntaFrequente");

                entity.Property(e => e.DsPergunta)
                    .HasMaxLength(400)
                    .HasColumnName("dsPergunta");

                entity.Property(e => e.DsResposta).HasColumnName("dsResposta");

                entity.Property(e => e.NrPergunta).HasColumnName("nrPergunta");

                entity.HasOne(d => d.IdGrupoPerguntaFrequenteNavigation)
                    .WithMany(p => p.TbNavPerguntasFrequentes)
                    .HasForeignKey(d => d.IdGrupoPerguntaFrequente)
                    .HasConstraintName("FK_tbNavPerguntasFrequentes_tbNavGrupoPerguntasFrequentes");
            });

            modelBuilder.Entity<TbNfseLayoutDefault>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdEmpresa })
                    .HasName("PK_tbNfseLayoutDefault_1");

                entity.ToTable("tbNfseLayoutDefault");

                entity.Property(e => e.DsTextoPrincipal).HasColumnName("dsTextoPrincipal");

                entity.Property(e => e.DsTituloPrincipal)
                    .HasMaxLength(255)
                    .HasColumnName("dsTituloPrincipal");

                entity.Property(e => e.LnkSistemaNfse)
                    .HasMaxLength(255)
                    .HasColumnName("lnkSistemaNfse");
            });

            modelBuilder.Entity<TbNfseLayoutDefaultPasso>(entity =>
            {
                entity.HasKey(e => e.IdLayoutDefaultPassos);

                entity.ToTable("tbNfseLayoutDefaultPassos");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbNfseLayoutDefaultPassos_IdEmpresa");

                entity.HasIndex(e => e.IdSistema, "IX_tbNfseLayoutDefaultPassos_IdSistema");

                entity.Property(e => e.BnImagem)
                    .HasColumnType("image")
                    .HasColumnName("bnImagem");

                entity.Property(e => e.DsExtensaoImagem)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("dsExtensaoImagem")
                    .IsFixedLength();

                entity.Property(e => e.DsPasso).HasColumnName("dsPasso");

                entity.Property(e => e.DsTituloPasso)
                    .HasMaxLength(100)
                    .HasColumnName("dsTituloPasso");

                entity.Property(e => e.NmImagem)
                    .HasMaxLength(100)
                    .HasColumnName("nmImagem");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbPubAgendaAutoridade>(entity =>
            {
                entity.HasKey(e => e.IdAutoridade);

                entity.ToTable("tbPubAgendaAutoridades");

                entity.Property(e => e.IdAutoridade).HasColumnName("idAutoridade");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.FlAtivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flAtivo")
                    .IsFixedLength();

                entity.Property(e => e.NmAutoridade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmAutoridade");
            });

            modelBuilder.Entity<TbPubAgendaCompromisso>(entity =>
            {
                entity.HasKey(e => e.IdAgendaCompromisso);

                entity.ToTable("tbPubAgendaCompromissos");

                entity.HasIndex(e => e.IdAutoridade, "IX_tbPubAgendaCompromissos_idAutoridade");

                entity.Property(e => e.IdAgendaCompromisso).HasColumnName("idAgendaCompromisso");

                entity.Property(e => e.DsAssuntos)
                    .HasMaxLength(500)
                    .HasColumnName("dsAssuntos");

                entity.Property(e => e.DsLocal)
                    .HasMaxLength(50)
                    .HasColumnName("dsLocal");

                entity.Property(e => e.DsObjetivo)
                    .HasMaxLength(500)
                    .HasColumnName("dsObjetivo");

                entity.Property(e => e.DsParticipantes)
                    .HasMaxLength(500)
                    .HasColumnName("dsParticipantes");

                entity.Property(e => e.DsResultados)
                    .HasMaxLength(500)
                    .HasColumnName("dsResultados");

                entity.Property(e => e.DsTipoPessoa)
                    .HasMaxLength(20)
                    .HasColumnName("dsTipoPessoa");

                entity.Property(e => e.DtCompromisso)
                    .HasColumnType("date")
                    .HasColumnName("dtCompromisso");

                entity.Property(e => e.HrInicial).HasColumnName("hrInicial");

                entity.Property(e => e.IdAutoridade).HasColumnName("idAutoridade");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .HasColumnName("nmPessoa");

                entity.HasOne(d => d.IdAutoridadeNavigation)
                    .WithMany(p => p.TbPubAgendaCompromissos)
                    .HasForeignKey(d => d.IdAutoridade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPubAgendaCompromissos_tbPubAgendaAutoridades");
            });

            modelBuilder.Entity<TbPubAgendaCompromissosDocumento>(entity =>
            {
                entity.HasKey(e => e.IdAgendaCompromissoDocumento);

                entity.ToTable("tbPubAgendaCompromissosDocumentos");

                entity.HasIndex(e => e.IdAgendaCompromisso, "IX_tbPubAgendaCompromissosDocumentos_idAgendaCompromisso");

                entity.Property(e => e.IdAgendaCompromissoDocumento).HasColumnName("idAgendaCompromissoDocumento");

                entity.Property(e => e.BnArquivo).HasColumnName("bnArquivo");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.ExtArquivo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("extArquivo")
                    .IsFixedLength();

                entity.Property(e => e.IdAgendaCompromisso).HasColumnName("idAgendaCompromisso");

                entity.Property(e => e.NmArquivo)
                    .HasMaxLength(50)
                    .HasColumnName("nmArquivo");

                entity.Property(e => e.NmDocumento)
                    .HasMaxLength(50)
                    .HasColumnName("nmDocumento");

                entity.HasOne(d => d.IdAgendaCompromissoNavigation)
                    .WithMany(p => p.TbPubAgendaCompromissosDocumentos)
                    .HasForeignKey(d => d.IdAgendaCompromisso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPubAgendaCompromissosDocumentos_tbPubAgendaCompromissos");
            });

            modelBuilder.Entity<TbPubArquivo>(entity =>
            {
                entity.HasKey(e => e.IdArquivo);

                entity.ToTable("tbPubArquivos");

                entity.HasIndex(e => e.IdCategoria, "IX_tbPubArquivos_IdCategoria");

                entity.HasIndex(e => e.IdEmpresa, "IX_tbPubArquivos_IdEmpresa");

                entity.HasIndex(e => new { e.NrMesCompetencia, e.NrAnoCompetencia, e.IdCategoria, e.IdEmpresa }, "IX_tbPubArquivos_nrMesCompetencia_nrAnoCompetencia_IdCategoria_IdEmpresa");

                entity.Property(e => e.BnArquivo)
                    .HasColumnType("image")
                    .HasColumnName("bnArquivo");

                entity.Property(e => e.DsArquivo)
                    .HasMaxLength(100)
                    .HasColumnName("dsArquivo");

                entity.Property(e => e.DsExtensaoArquivo)
                    .HasMaxLength(5)
                    .HasColumnName("dsExtensaoArquivo");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsNomeArquivo)
                    .HasMaxLength(70)
                    .HasColumnName("dsNomeArquivo");

                entity.Property(e => e.DtPublicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPublicacao");

                entity.Property(e => e.NrAnoCompetencia).HasColumnName("nrAnoCompetencia");

                entity.Property(e => e.NrMesCompetencia).HasColumnName("nrMesCompetencia");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TbPubArquivos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_tbPubArquivos_tbPubCategorias");
            });

            modelBuilder.Entity<TbPubArquivosListum>(entity =>
            {
                entity.HasKey(e => e.IdArquivo);

                entity.ToTable("tbPubArquivosLista");

                entity.HasIndex(e => e.IdLinkItem, "IX_tbPubArquivosLista_IdLinkItem");

                entity.HasIndex(e => e.IdSistema, "IX_tbPubArquivosLista_IdSistema");

                entity.Property(e => e.BnArquivo)
                    .HasColumnType("image")
                    .HasColumnName("bnArquivo");

                entity.Property(e => e.DsArquivo)
                    .HasMaxLength(500)
                    .HasColumnName("dsArquivo");

                entity.Property(e => e.DsExtensaoArquivo)
                    .HasMaxLength(5)
                    .HasColumnName("dsExtensaoArquivo");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsNomeArquivo)
                    .HasMaxLength(350)
                    .HasColumnName("dsNomeArquivo");

                entity.Property(e => e.DtPublicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPublicacao");

                entity.Property(e => e.NmArquivo)
                    .HasMaxLength(250)
                    .HasColumnName("nmArquivo");
            });

            modelBuilder.Entity<TbPubCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK_tbPubCategoria");

                entity.ToTable("tbPubCategorias");

                entity.HasIndex(e => e.IdLinkItem, "IX_tbPubCategorias_IdLinkItem");

                entity.Property(e => e.DsCategoria)
                    .HasMaxLength(300)
                    .HasColumnName("dsCategoria");

                entity.Property(e => e.FlPadrao).HasColumnName("flPadrao");

                entity.Property(e => e.NmCategoria)
                    .HasMaxLength(50)
                    .HasColumnName("nmCategoria");

                entity.HasOne(d => d.IdLinkItemNavigation)
                    .WithMany(p => p.TbPubCategoria)
                    .HasForeignKey(d => d.IdLinkItem)
                    .HasConstraintName("FK_tbPubCategoria_tbNavLinkItens");
            });

            modelBuilder.Entity<TbPubErrosExecucaoFonteDado>(entity =>
            {
                entity.HasKey(e => e.IdErro);

                entity.ToTable("tbPubErrosExecucaoFonteDados");

                entity.Property(e => e.IdErro).HasColumnName("idErro");

                entity.Property(e => e.DsErro).HasColumnName("dsErro");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");
            });

            modelBuilder.Entity<TbPubExibicaoPessoal>(entity =>
            {
                entity.HasKey(e => new { e.Idempresa, e.IdSistema })
                    .HasName("PK_tbPubExibicaoInfPessoal");

                entity.ToTable("tbPubExibicaoPessoal");

                entity.Property(e => e.Idempresa).HasColumnName("IDEmpresa");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.Dslogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dslogin");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<TbPubFonteDado>(entity =>
            {
                entity.HasKey(e => e.IdFonteDados)
                    .HasName("PK_tbGraFonteDados");

                entity.ToTable("tbPubFonteDados");

                entity.Property(e => e.DsFonteDados)
                    .IsUnicode(false)
                    .HasColumnName("dsFonteDados");

                entity.Property(e => e.NmFonteDados)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmFonteDados");

                entity.Property(e => e.NmProvider)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmProvider");

                entity.Property(e => e.NmTemporyTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTemporyTable");

                entity.Property(e => e.NrDiasAtualizacao).HasColumnName("nrDiasAtualizacao");
            });

            modelBuilder.Entity<TbPubFonteDadosFiltro>(entity =>
            {
                entity.HasKey(e => e.IdFonteDadosFiltro);

                entity.ToTable("tbPubFonteDadosFiltros");

                entity.HasIndex(e => e.IdFonteDados, "IX_tbPubFonteDadosFiltros_IdFonteDados");

                entity.Property(e => e.DsAliasCampos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsAliasCampos");

                entity.Property(e => e.DsCampos)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dsCampos");

                entity.Property(e => e.DsRotuloControle)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dsRotuloControle");

                entity.Property(e => e.DsTipoCampos)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCampos");

                entity.Property(e => e.DsTipoFiltro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoFiltro");

                entity.Property(e => e.FlObrigatorio)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flObrigatorio")
                    .IsFixedLength();

                entity.Property(e => e.FlRodape)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flRodape")
                    .IsFixedLength();

                entity.Property(e => e.FlUsaLike)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flUsaLike")
                    .IsFixedLength();

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");

                entity.Property(e => e.NrTamanhosCampos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nrTamanhosCampos");

                entity.Property(e => e.VlPadrao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vlPadrao");

                entity.HasOne(d => d.IdFonteDadosNavigation)
                    .WithMany(p => p.TbPubFonteDadosFiltros)
                    .HasForeignKey(d => d.IdFonteDados)
                    .HasConstraintName("FK_tbPubFonteDadosFiltros_tbPubFonteDados");
            });

            modelBuilder.Entity<TbPubVisaoFonteDado>(entity =>
            {
                entity.HasKey(e => e.IdVisao)
                    .HasName("PK_tbGraVisaoFonteDados");

                entity.ToTable("tbPubVisaoFonteDados");

                entity.HasIndex(e => e.IdFonteDados, "IX_tbPubVisaoFonteDados_IdFonteDados");

                entity.HasIndex(e => e.IdLinkItem, "IX_tbPubVisaoFonteDados_IdLinkItem");

                entity.Property(e => e.DsCamposNaoNulosSomatoria)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsCamposNaoNulosSomatoria");

                entity.Property(e => e.DsCamposSomatoria)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsCamposSomatoria");

                entity.Property(e => e.DsQuery)
                    .IsUnicode(false)
                    .HasColumnName("dsQuery");

                entity.Property(e => e.DsUrlAnexo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsUrlAnexo");

                entity.Property(e => e.DsUrlChamada)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsUrlChamada");

                entity.Property(e => e.DsVisao)
                    .IsUnicode(false)
                    .HasColumnName("dsVisao");

                entity.Property(e => e.FlPagina)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flPagina")
                    .IsFixedLength();

                entity.Property(e => e.FlUsaWhere)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flUsaWhere")
                    .IsFixedLength();

                entity.Property(e => e.NmVisao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmVisao");

                entity.Property(e => e.NrGridWidth).HasColumnName("nrGridWidth");

                entity.Property(e => e.NrQtdPagina).HasColumnName("nrQtdPagina");

                entity.HasOne(d => d.IdFonteDadosNavigation)
                    .WithMany(p => p.TbPubVisaoFonteDados)
                    .HasForeignKey(d => d.IdFonteDados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPubVisaoFonteDados_tbPubFonteDados");

                entity.HasOne(d => d.IdLinkItemNavigation)
                    .WithMany(p => p.TbPubVisaoFonteDados)
                    .HasForeignKey(d => d.IdLinkItem)
                    .HasConstraintName("FK_tbPubVisaoFonteDados_tbNavLinkItens");

                entity.HasMany(d => d.IdFonteDadosFiltros)
                    .WithMany(p => p.IdVisaos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbPubVisaoFiltro",
                        l => l.HasOne<TbPubFonteDadosFiltro>().WithMany().HasForeignKey("IdFonteDadosFiltro").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbPubVisaoFiltros_tbPubFonteDadosFiltros"),
                        r => r.HasOne<TbPubVisaoFonteDado>().WithMany().HasForeignKey("IdVisao").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbPubVisaoFiltros_tbPubVisaoFonteDados"),
                        j =>
                        {
                            j.HasKey("IdVisao", "IdFonteDadosFiltro");

                            j.ToTable("tbPubVisaoFiltros");
                        });
            });

            modelBuilder.Entity<TbPubVisaoNotaRodape>(entity =>
            {
                entity.HasKey(e => e.IdNotaRodape)
                    .HasName("PK_tbPubVisaoNotaRodape_1");

                entity.ToTable("tbPubVisaoNotaRodape");

                entity.Property(e => e.IdNotaRodape).ValueGeneratedNever();

                entity.Property(e => e.DsNotaRodape)
                    .IsUnicode(false)
                    .HasColumnName("dsNotaRodape");
            });

            modelBuilder.Entity<TbTmpAdiantamentoDespesaOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAdiantamentoDespesaOrigem");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.DataEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEmpenho");

                entity.Property(e => e.DataLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataLiquidacao");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Justificativa)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.Matricula).HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NumeroEmpenho)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("numeroEmpenho");

                entity.Property(e => e.NumeroLiquidacao).HasColumnName("numeroLiquidacao");

                entity.Property(e => e.NumeroPagamento).HasColumnName("numeroPagamento");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<TbTmpAdiantamentoDespesaPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAdiantamentoDespesaPTI");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.DataEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEmpenho");

                entity.Property(e => e.DataLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataLiquidacao");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Justificativa)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NumeroEmpenho)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("numeroEmpenho");

                entity.Property(e => e.NumeroLiquidacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("numeroLiquidacao");

                entity.Property(e => e.NumeroPagamento)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("numeroPagamento");

                entity.Property(e => e.Valor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<TbTmpAgentesPublicosOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAgentesPublicosOrigem");

                entity.Property(e => e.Adicional)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("adicional");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Beneficio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("beneficio");

                entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.DataAlocacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAlocacao");

                entity.Property(e => e.DataDispensa)
                    .HasColumnType("datetime")
                    .HasColumnName("dataDispensa");

                entity.Property(e => e.DecimoTerceiro)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("decimoTerceiro");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.EncargoEspecial).HasColumnName("encargoEspecial");

                entity.Property(e => e.Ferias)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ferias");

                entity.Property(e => e.Gratificacao)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("gratificacao");

                entity.Property(e => e.HorasExtras).HasColumnName("horasExtras");

                entity.Property(e => e.Irrf)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("irrf");

                entity.Property(e => e.LocalLotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("localLotacao");

                entity.Property(e => e.Matricula).HasColumnName("matricula");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.OutrasVantagens)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("outrasVantagens");

                entity.Property(e => e.OutrosDescontos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("outrosDescontos");

                entity.Property(e => e.Previdencia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("previdencia");

                entity.Property(e => e.Remuneracao)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("remuneracao");

                entity.Property(e => e.RemuneracaoTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("remuneracaoTotal");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.VinculoEmpregaticio)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vinculoEmpregaticio");
            });

            modelBuilder.Entity<TbTmpAgentesPublicosPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAgentesPublicosPTI");

                entity.Property(e => e.CargaHoraria).HasColumnName("cargaHoraria");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.DataAlocacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAlocacao");

                entity.Property(e => e.DataDispensa)
                    .HasColumnType("datetime")
                    .HasColumnName("dataDispensa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LocalLotacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("localLotacao");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Remuneracao)
                    .HasColumnType("money")
                    .HasColumnName("remuneracao");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.VinculoEmpregaticio)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("vinculoEmpregaticio");
            });

            modelBuilder.Entity<TbTmpAlmoxarifado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAlmoxarifado");

                entity.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Produto)
                    .IsUnicode(false)
                    .HasColumnName("produto");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("money")
                    .HasColumnName("quantidade");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unidade");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("money")
                    .HasColumnName("valorUnitario");
            });

            modelBuilder.Entity<TbTmpAlmoxarifadoPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpAlmoxarifadoPTI");

                entity.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Produto)
                    .IsUnicode(false)
                    .HasColumnName("produto");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("money")
                    .HasColumnName("quantidade");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unidade");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("money")
                    .HasColumnName("valorUnitario");
            });

            modelBuilder.Entity<TbTmpApoioCargaPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpApoioCargaPTI");

                entity.Property(e => e.IdApoio).HasColumnName("idApoio");
            });

            modelBuilder.Entity<TbTmpApoioCargaPti1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpApoioCargaPTI_1");

                entity.Property(e => e.IdApoio).HasColumnName("idApoio");
            });

            modelBuilder.Entity<TbTmpApoioCargaPti2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpApoioCargaPTI_2");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("agencia");

                entity.Property(e => e.Banco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("banco");

                entity.Property(e => e.Conta)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("conta");

                entity.Property(e => e.IdApoio).HasColumnName("idApoio");

                entity.Property(e => e.SaldoContabil)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saldoContabil");

                entity.Property(e => e.SaldoExtrato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saldoExtrato");
            });

            modelBuilder.Entity<TbTmpBensPatrimoniai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpBensPatrimoniais");

                entity.Property(e => e.CentroCusto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("centroCusto");

                entity.Property(e => e.DataAquisicao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAquisicao");

                entity.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.IdBensPatrimoniais)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idBensPatrimoniais");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("orgao");

                entity.Property(e => e.Placa).HasColumnName("placa");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("responsavel");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.TipoAquisicao)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("tipoAquisicao");

                entity.Property(e => e.TipoNatureza)
                    .HasMaxLength(113)
                    .IsUnicode(false)
                    .HasColumnName("tipoNatureza");

                entity.Property(e => e.ValorAquisicao)
                    .HasColumnType("money")
                    .HasColumnName("valorAquisicao");
            });

            modelBuilder.Entity<TbTmpBensPatrimoniaisPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpBensPatrimoniaisPTI");

                entity.Property(e => e.CentroCusto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("centroCusto");

                entity.Property(e => e.DataAquisicao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAquisicao");

                entity.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("orgao");

                entity.Property(e => e.Placa).HasColumnName("placa");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("responsavel");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.TipoAquisicao)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("tipoAquisicao");

                entity.Property(e => e.TipoNatureza)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipoNatureza");

                entity.Property(e => e.ValorAquisicao)
                    .HasColumnType("money")
                    .HasColumnName("valorAquisicao");
            });

            modelBuilder.Entity<TbTmpCapConvAuxPrograma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpCapConvAuxPrograma");

                entity.Property(e => e.CdCap).HasColumnName("cdCap");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsOrgaoRepassador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsOrgaoRepassador");

                entity.Property(e => e.DsRecurso)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRecurso");

                entity.Property(e => e.DsTipoRecurso)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoRecurso");

                entity.Property(e => e.DtCelebracaoTermo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCelebracaoTermo");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioVigencia");

                entity.Property(e => e.DtTerminoVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTerminoVigencia");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrDoe).HasColumnName("nrDoe");

                entity.Property(e => e.NrTermo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrTermo");

                entity.Property(e => e.TipoConvenio)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.VlContraPartida)
                    .HasColumnType("money")
                    .HasColumnName("vlContraPartida");

                entity.Property(e => e.VlPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("vlPrevisto");

                entity.Property(e => e.VlRecebido).HasColumnType("money");
            });

            modelBuilder.Entity<TbTmpContasCorrente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpContasCorrente");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Banco)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdCc).HasColumnName("IdCC");

                entity.Property(e => e.NmCc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmCC");

                entity.Property(e => e.NrCc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrCC");
            });

            modelBuilder.Entity<TbTmpContrato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpContratos");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdTipoAtoContratual).HasColumnName("cdTipoAtoContratual");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoContrato");

                entity.Property(e => e.DtAssinatura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAssinatura");

                entity.Property(e => e.DtContrato)
                    .HasColumnType("datetime")
                    .HasColumnName("dtContrato");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioPrazo");

                entity.Property(e => e.DtNovaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dtNovaTermino");

                entity.Property(e => e.DtTerminoPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTerminoPrazo");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoLicitacao).HasColumnName("nrAnoLicitacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.TipoAtoContratual)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlContrato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vlContrato");
            });

            modelBuilder.Entity<TbTmpContratosAditivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpContratosAditivos");

                entity.Property(e => e.CdTipoAtoContratual).HasColumnName("cdTipoAtoContratual");

                entity.Property(e => e.DsMotivo)
                    .IsUnicode(false)
                    .HasColumnName("dsMotivo");

                entity.Property(e => e.DsTipoAditivo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoAditivo");

                entity.Property(e => e.DsTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoContrato");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtNovaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dtNovaTermino");

                entity.Property(e => e.DtPublicacaoTermo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPublicacaoTermo");

                entity.Property(e => e.DtTermo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTermo");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmTipoAtoContratual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoAtoContratual");

                entity.Property(e => e.NrAditivo).HasColumnName("nrAditivo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.TipoAtoContratual)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.VlAditivo)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivo");

                entity.Property(e => e.VlAtualizadoContrato)
                    .HasColumnType("money")
                    .HasColumnName("vlAtualizadoContrato");
            });

            modelBuilder.Entity<TbTmpContratosOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpContratosOrigem");

                entity.Property(e => e.Administrador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("administrador");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdTipoAtoContratual).HasColumnName("cdTipoAtoContratual");

                entity.Property(e => e.CodigoLicitacao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigoLicitacao");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoContrato");

                entity.Property(e => e.DtAssinatura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAssinatura");

                entity.Property(e => e.DtContrato)
                    .HasColumnType("datetime")
                    .HasColumnName("dtContrato");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioPrazo");

                entity.Property(e => e.DtNovaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dtNovaTermino");

                entity.Property(e => e.DtTerminoPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTerminoPrazo");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoLicitacao).HasColumnName("nrAnoLicitacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.NumeroAditivoVigente).HasColumnName("numeroAditivoVigente");

                entity.Property(e => e.SetorFiscalizacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("setorFiscalizacao");

                entity.Property(e => e.TipoAtoContratual)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSituacaoContrato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tipoSituacaoContrato");

                entity.Property(e => e.ValorDoContratoOriginal)
                    .HasColumnType("money")
                    .HasColumnName("valorDoContratoOriginal");

                entity.Property(e => e.ValorDoTermoAditivo)
                    .HasColumnType("money")
                    .HasColumnName("valorDoTermoAditivo");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlContrato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vlContrato");
            });

            modelBuilder.Entity<TbTmpContratosPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpContratosPTI");

                entity.Property(e => e.Administrador)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("administrador");

                entity.Property(e => e.CodigoContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigoContrato");

                entity.Property(e => e.CodigoLicitacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoLicitacao");

                entity.Property(e => e.Contratada)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("contratada");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("dataInicio");

                entity.Property(e => e.DataTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dataTermino");

                entity.Property(e => e.DiasAvencer).HasColumnName("diasAVencer");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NumeroAditivoVigente).HasColumnName("numeroAditivoVigente");

                entity.Property(e => e.NumeroEmpenho).HasColumnName("numeroEmpenho");

                entity.Property(e => e.NumeroProcessos).HasColumnName("numeroProcessos");

                entity.Property(e => e.PrazoVigencia).HasColumnName("prazoVigencia");

                entity.Property(e => e.SetorFiscalizacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("setorFiscalizacao");

                entity.Property(e => e.TipoSituacaoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoSituacaoContrato");

                entity.Property(e => e.ValorDoContratoOriginal)
                    .HasColumnType("money")
                    .HasColumnName("valorDoContratoOriginal");

                entity.Property(e => e.ValorDoTermoAditivo)
                    .HasColumnType("money")
                    .HasColumnName("valorDoTermoAditivo");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");
            });

            modelBuilder.Entity<TbTmpContratosV2>(entity =>
            {
                entity.HasKey(e => new { e.IdContrato, e.NrCnpjcpf });

                entity.ToTable("tbTmpContratosV2");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdTipoAtoContratual).HasColumnName("cdTipoAtoContratual");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoContrato");

                entity.Property(e => e.DtContrato)
                    .HasColumnType("datetime")
                    .HasColumnName("dtContrato");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioPrazo");

                entity.Property(e => e.DtNovaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dtNovaTermino");

                entity.Property(e => e.DtTerminoPrazo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTerminoPrazo");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoLicitacao).HasColumnName("nrAnoLicitacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.TipoAtoContratual)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlContrato)
                    .HasColumnType("money")
                    .HasColumnName("vlContrato");
            });

            modelBuilder.Entity<TbTmpCotacaoIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpCotacaoItens");

                entity.Property(e => e.DsItem)
                    .IsUnicode(false)
                    .HasColumnName("dsItem");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DtEdital)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEdital");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmUnidadeMedida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidadeMedida");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.NrLote).HasColumnName("nrLote");

                entity.Property(e => e.NrQuantidade)
                    .HasColumnType("money")
                    .HasColumnName("nrQuantidade");

                entity.Property(e => e.VlrFechado)
                    .HasColumnType("money")
                    .HasColumnName("vlrFechado");
            });

            modelBuilder.Entity<TbTmpDdrorigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDDROrigem");

                entity.Property(e => e.CategEconomica)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.Cdfonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdfonte");

                entity.Property(e => e.DsAcao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsAcao");

                entity.Property(e => e.DsNatDespesa)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DsQdd)
                    .IsUnicode(false)
                    .HasColumnName("dsQDD");

                entity.Property(e => e.Dsfonte)
                    .IsUnicode(false)
                    .HasColumnName("dsfonte");

                entity.Property(e => e.ElementoDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EmpenhadoPeriodo).HasColumnType("money");

                entity.Property(e => e.EstornoLiquidadoPeriodo).HasColumnType("money");

                entity.Property(e => e.Funcional)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fundo).IsUnicode(false);

                entity.Property(e => e.GrupoNatureza)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Idfonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idfonte");

                entity.Property(e => e.LiquidadoPeriodo).HasColumnType("money");

                entity.Property(e => e.Modalidade)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.ValorEstornadoPagamentoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornadoPagamentoPeriodo");

                entity.Property(e => e.ValorPagamentoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("valorPagamentoPeriodo");

                entity.Property(e => e.VlAlteracaoOrc)
                    .HasColumnType("money")
                    .HasColumnName("vlAlteracaoOrc");

                entity.Property(e => e.VlBloqueadoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlBloqueadoAno");

                entity.Property(e => e.VlBloqueadoAnoManual)
                    .HasColumnType("money")
                    .HasColumnName("vlBloqueadoAnoManual");

                entity.Property(e => e.VlBloqueadoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlBloqueadoPeriodo");

                entity.Property(e => e.VlConsignacaoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlConsignacaoAno");

                entity.Property(e => e.VlConsignacaoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlConsignacaoPeriodo");

                entity.Property(e => e.VlEstornoConsignacaoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlEstornoConsignacaoAno");

                entity.Property(e => e.VlEstornoConsignacaoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlEstornoConsignacaoPeriodo");

                entity.Property(e => e.VlEstornoEmpenhoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlEstornoEmpenhoPeriodo");

                entity.Property(e => e.VlLiquidadoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidadoAno");

                entity.Property(e => e.VlLiquidadoPeriodoLiquido)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidadoPeriodoLiquido");

                entity.Property(e => e.VlPagoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlPagoAno");

                entity.Property(e => e.VlPagoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlPagoPeriodo");

                entity.Property(e => e.VlPagoRetencao)
                    .HasColumnType("money")
                    .HasColumnName("vlPagoRetencao");

                entity.Property(e => e.VlPagoRetencaoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlPagoRetencaoAno");

                entity.Property(e => e.VlRealizadoAno)
                    .HasColumnType("money")
                    .HasColumnName("vlRealizadoAno");

                entity.Property(e => e.VlRealizadoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlRealizadoPeriodo");

                entity.Property(e => e.VlRms)
                    .HasColumnType("money")
                    .HasColumnName("vlRMS");

                entity.Property(e => e.VlSolicitacaoEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlSolicitacaoEmpenho");

                entity.Property(e => e.VlTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlTotal");
            });

            modelBuilder.Entity<TbTmpDespesa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesas");

                entity.Property(e => e.CdAcao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdAcao");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdFuncao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdPrograma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cdPrograma")
                    .IsFixedLength();

                entity.Property(e => e.CdSubFuncao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdSubFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.DsAcao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsAcao");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");

                entity.Property(e => e.DsFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFuncao");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsNatDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DsSubFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsSubFuncao");

                entity.Property(e => e.DsTipoEmpenho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoEmpenho");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoLicitacao).HasColumnName("nrAnoLicitacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrEditalOrigem)
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasColumnName("nrEditalOrigem");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(261)
                    .IsUnicode(false);

                entity.Property(e => e.Unidade)
                    .HasMaxLength(259)
                    .IsUnicode(false);

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlrAnulado).HasColumnType("money");

                entity.Property(e => e.VlrCancelado).HasColumnType("money");

                entity.Property(e => e.VlrConsignado).HasColumnType("money");

                entity.Property(e => e.VlrDevolvido).HasColumnType("money");

                entity.Property(e => e.VlrEstornoConsig).HasColumnType("money");

                entity.Property(e => e.VlrLiquidação).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");

                entity.Property(e => e.VlrSaldoPagar)
                    .HasColumnType("money")
                    .HasColumnName("vlrSaldoPagar");
            });

            modelBuilder.Entity<TbTmpDespesaEmpPagarOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaEmpPagarOrigem");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.Fonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fonte");

                entity.Property(e => e.IdDespesaEmpPagar).ValueGeneratedOnAdd();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.SaldoPagar)
                    .HasColumnType("money")
                    .HasColumnName("saldoPagar");
            });

            modelBuilder.Entity<TbTmpDespesaEmpenhadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaEmpenhada");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.IdDespesaEmpenhada).ValueGeneratedOnAdd();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.ValorEmpenhado)
                    .HasColumnType("money")
                    .HasColumnName("valorEmpenhado");

                entity.Property(e => e.ValorEstornado)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornado");

                entity.Property(e => e.ValorLiquido)
                    .HasColumnType("money")
                    .HasColumnName("valorLiquido");

                entity.Property(e => e.ValorRevertido)
                    .HasColumnType("money")
                    .HasColumnName("valorRevertido");
            });

            modelBuilder.Entity<TbTmpDespesaExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaExtra");

                entity.Property(e => e.CdGrupo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdGrupo");

                entity.Property(e => e.DsGrupo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dsGrupo");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DtDespesa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDespesa");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmFantasia");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrSequencia).HasColumnName("nrSequencia");

                entity.Property(e => e.TotalEstorno)
                    .HasColumnType("money")
                    .HasColumnName("totalEstorno");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.Property(e => e.VlDespesa)
                    .HasColumnType("money")
                    .HasColumnName("vlDespesa");

                entity.Property(e => e.VlTotalEstornoPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlTotalEstornoPagamento");
            });

            modelBuilder.Entity<TbTmpDespesaFornecedore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaFornecedores");

                entity.Property(e => e.CdCredito)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdCredito");

                entity.Property(e => e.CdDebito)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdDebito");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.DsCredito)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsCredito");

                entity.Property(e => e.DsDebito)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsDebito");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSerie");

                entity.Property(e => e.DsTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoContrato");

                entity.Property(e => e.DtDespesa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDespesa");

                entity.Property(e => e.DtDespesaOrigem)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDespesaOrigem");

                entity.Property(e => e.DtDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDocumento");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPagamento");

                entity.Property(e => e.DtVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVencimento");

                entity.Property(e => e.EstConsg).HasColumnType("money");

                entity.Property(e => e.EstornoLiquidacaoDocumento).HasColumnType("money");

                entity.Property(e => e.NmFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmFantasia");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmTipoDoctoFiscal)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoDoctoFiscal");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAnoContrato).HasColumnName("nrAnoContrato");

                entity.Property(e => e.NrAnoDespesa).HasColumnName("nrAnoDespesa");

                entity.Property(e => e.NrAnoDespesaOrigem).HasColumnName("nrAnoDespesaOrigem");

                entity.Property(e => e.NrAnolicitacao).HasColumnName("nrAnolicitacao");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.NrDespesa).HasColumnName("nrDespesa");

                entity.Property(e => e.NrDespesaOrigem).HasColumnName("nrDespesaOrigem");

                entity.Property(e => e.NrDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrDocumento");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.TpDespesa)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("tpDespesa");

                entity.Property(e => e.VlConsignadoDocto)
                    .HasColumnType("money")
                    .HasColumnName("vlConsignadoDocto");

                entity.Property(e => e.VlDespesa)
                    .HasColumnType("money")
                    .HasColumnName("vlDespesa");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("money")
                    .HasColumnName("vlDocumento");

                entity.Property(e => e.VlEstornoDespesa)
                    .HasColumnType("money")
                    .HasColumnName("vlEstornoDespesa");

                entity.Property(e => e.VlEstornoPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlEstornoPagamento");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamento");

                entity.Property(e => e.VlPagamentoDocto)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamentoDocto");
            });

            modelBuilder.Entity<TbTmpDespesaLiquidadaOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaLiquidadaOrigem");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.IdDespesaLiquidada).ValueGeneratedOnAdd();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.ValorEstornadoOrcamento)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornadoOrcamento");

                entity.Property(e => e.ValorEstornadoPagar)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornadoPagar");

                entity.Property(e => e.ValorLiquidadoOrcamento)
                    .HasColumnType("money")
                    .HasColumnName("valorLiquidadoOrcamento");

                entity.Property(e => e.ValorLiquidadoPagar)
                    .HasColumnType("money")
                    .HasColumnName("valorLiquidadoPagar");

                entity.Property(e => e.ValorLiquido)
                    .HasColumnType("money")
                    .HasColumnName("valorLiquido");
            });

            modelBuilder.Entity<TbTmpDespesaPaga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaPagas");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.IdDespesaPagas).ValueGeneratedOnAdd();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.ValorEstornadoOrcamento)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornadoOrcamento");

                entity.Property(e => e.ValorEstornadoPagar)
                    .HasColumnType("money")
                    .HasColumnName("valorEstornadoPagar");

                entity.Property(e => e.ValorLiquido)
                    .HasColumnType("money")
                    .HasColumnName("valorLiquido");

                entity.Property(e => e.ValorPagoOrcamento)
                    .HasColumnType("money")
                    .HasColumnName("valorPagoOrcamento");

                entity.Property(e => e.ValorPagoPagar)
                    .HasColumnType("money")
                    .HasColumnName("valorPagoPagar");
            });

            modelBuilder.Entity<TbTmpDespesaTransporteOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesaTransporteOrigem");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.DataEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEmpenho");

                entity.Property(e => e.DataLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataLiquidacao");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.MotivoViagem)
                    .IsUnicode(false)
                    .HasColumnName("motivoViagem");

                entity.Property(e => e.NomeBeneficiario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nomeBeneficiario");

                entity.Property(e => e.NomeCredor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nomeCredor");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NumeroEmpenho)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("numeroEmpenho");

                entity.Property(e => e.NumeroLiquidacao).HasColumnName("numeroLiquidacao");

                entity.Property(e => e.NumeroPagamento).HasColumnName("numeroPagamento");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(261)
                    .IsUnicode(false)
                    .HasColumnName("orgao");

                entity.Property(e => e.TipoGasto)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("tipoGasto");

                entity.Property(e => e.ValorGasto)
                    .HasColumnType("money")
                    .HasColumnName("valorGasto");
            });

            modelBuilder.Entity<TbTmpDespesasCorona>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDespesasCorona");

                entity.Property(e => e.CdAcao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdAcao");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdFuncao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdPrograma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cdPrograma")
                    .IsFixedLength();

                entity.Property(e => e.CdSubFuncao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdSubFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.DsAcao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsAcao");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");

                entity.Property(e => e.DsFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFuncao");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsNatDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DsSubFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsSubFuncao");

                entity.Property(e => e.DsTipoEmpenho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoEmpenho");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoLicitacao).HasColumnName("nrAnoLicitacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrEditalOrigem)
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasColumnName("nrEditalOrigem");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(261)
                    .IsUnicode(false);

                entity.Property(e => e.Unidade)
                    .HasMaxLength(259)
                    .IsUnicode(false);

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlrAnulado).HasColumnType("money");

                entity.Property(e => e.VlrCancelado).HasColumnType("money");

                entity.Property(e => e.VlrConsignado).HasColumnType("money");

                entity.Property(e => e.VlrDevolvido).HasColumnType("money");

                entity.Property(e => e.VlrEstornoConsig).HasColumnType("money");

                entity.Property(e => e.VlrLiquidação).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");

                entity.Property(e => e.VlrSaldoPagar)
                    .HasColumnType("money")
                    .HasColumnName("vlrSaldoPagar");
            });

            modelBuilder.Entity<TbTmpDiaria>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDiarias");

                entity.Property(e => e.DsDestino)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("dsDestino");

                entity.Property(e => e.DsObjetivo)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivo");

                entity.Property(e => e.DsTipoLocomocao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoLocomocao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtFim)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFim");

                entity.Property(e => e.DtInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicio");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrDiarias)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("nrDiarias");

                entity.Property(e => e.VlTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlTotal");

                entity.Property(e => e.VlUnitario)
                    .HasColumnType("money")
                    .HasColumnName("vlUnitario");
            });

            modelBuilder.Entity<TbTmpDiariasEmpenho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDiariasEmpenhos");

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsNatDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLiquidacao");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPagamento");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("matricula");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NrQtde)
                    .HasColumnType("money")
                    .HasColumnName("nrQtde");

                entity.Property(e => e.OrgaoEmpenho)
                    .HasMaxLength(261)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlLiquidacao)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidacao");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamento");

                entity.Property(e => e.VlTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlTotal");

                entity.Property(e => e.VlUnitario)
                    .HasColumnType("money")
                    .HasColumnName("vlUnitario");
            });

            modelBuilder.Entity<TbTmpDiariasOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpDiariasOrigem");

                entity.Property(e => e.DataLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataLiquidacao");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.DsDestino)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("dsDestino");

                entity.Property(e => e.DsObjetivo)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivo");

                entity.Property(e => e.DsTipoLocomocao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoLocomocao");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtFim)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFim");

                entity.Property(e => e.DtInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicio");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAnoEmpenho).HasColumnName("nrAnoEmpenho");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrDiarias)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("nrDiarias");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NumeroLiquidacao).HasColumnName("numeroLiquidacao");

                entity.Property(e => e.NumeroPagamento).HasColumnName("numeroPagamento");

                entity.Property(e => e.VlTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlTotal");

                entity.Property(e => e.VlTotalPassagem)
                    .HasColumnType("money")
                    .HasColumnName("vlTotalPassagem");

                entity.Property(e => e.VlUnitario)
                    .HasColumnType("money")
                    .HasColumnName("vlUnitario");
            });

            modelBuilder.Entity<TbTmpExtratoBancarioOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpExtratoBancarioOrigem");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("agencia");

                entity.Property(e => e.Banco)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("banco");

                entity.Property(e => e.Conta)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("conta");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.SaldoContabil)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saldoContabil");

                entity.Property(e => e.SaldoExtrato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saldoExtrato");

                entity.Property(e => e.TipoLancamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipoLancamento");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<TbTmpFolhaPagamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFolhaPagamento");

                entity.Property(e => e.AbonoPermanencia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Adicionais).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Admissao).HasColumnType("datetime");

                entity.Property(e => e.Beneficios).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CargoComissao).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.DataDispensa).HasColumnType("datetime");

                entity.Property(e => e.Decimo13Adiantamento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Descontos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescontosFacultativos).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DescontosObrigatorios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Escala)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ferias).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gratificacoes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImpostoRenda).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.OutrasIndenizacoes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Previdencia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Regime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RemuneracaoBruta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemuneracaoLiquida).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalarioBase).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Secretaria)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VantagensPessoais).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VantagensTransitorias).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vencimentos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VerbasVariaveis).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbTmpFolhaPagamentoAssistSocial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFolhaPagamentoAssistSocial");

                entity.Property(e => e.BlocoPrograma)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CdProvento)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cdProvento");

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Fonte)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Funcao)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Lotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MesCompetencia).HasColumnName("mesCompetencia");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Vencimentos).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbTmpFolhaPagamentoAssistSocialCont>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFolhaPagamentoAssistSocialCont");

                entity.Property(e => e.BlocoPrograma)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.DsNatDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.MesCompetencia).HasColumnName("mesCompetencia");

                entity.Property(e => e.NmCc)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nmCC");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrCC");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrContrato).HasColumnName("nrContrato");

                entity.Property(e => e.ValorAtualizado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorAtualizado");

                entity.Property(e => e.ValorPago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlContrato)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vlContrato");
            });

            modelBuilder.Entity<TbTmpFolhaPagamentoBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFolhaPagamentoBK");

                entity.Property(e => e.AbonoPermanencia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Adicionais).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Admissao).HasColumnType("datetime");

                entity.Property(e => e.Beneficios).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CargoComissao).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimo13Adiantamento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Descontos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DescontosFacultativos).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DescontosObrigatorios).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ferias).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gratificacoes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Lotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.OutrasIndenizacoes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Regime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RemuneracaoBruta).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemuneracaoLiquida).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalarioBase).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VantagensPessoais).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VantagensTransitorias).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vencimentos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VerbasVariaveis).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbTmpFolhaPagamentoOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpFolhaPagamentoOrigem");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Descontos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Lotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFuncionariosCargo).HasColumnName("numeroFuncionariosCargo");

                entity.Property(e => e.RemuneracaoBruta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("remuneracaoBruta");

                entity.Property(e => e.RemuneracaoLiquida)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("remuneracaoLiquida");

                entity.Property(e => e.Secretaria)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("secretaria");
            });

            modelBuilder.Entity<TbTmpInfoAdministrativaOrigem>(entity =>
            {
                entity.ToTable("tbTmpInfoAdministrativaOrigem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.DataInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataInclusao");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NumCargosComissaoCriados).HasColumnName("numCargosComissaoCriados");

                entity.Property(e => e.NumCargosComissaoPreenchidos).HasColumnName("numCargosComissaoPreenchidos");

                entity.Property(e => e.NumCargosEfetivosCriados).HasColumnName("numCargosEfetivosCriados");

                entity.Property(e => e.NumCargosEfetivosPreenchidos).HasColumnName("numCargosEfetivosPreenchidos");

                entity.Property(e => e.NumEmpregosPublicosCriados).HasColumnName("numEmpregosPublicosCriados");

                entity.Property(e => e.NumEmpregosPublicosPreenchidos).HasColumnName("numEmpregosPublicosPreenchidos");
            });

            modelBuilder.Entity<TbTmpLicitacaoParticipante>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpLicitacaoParticipantes");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DtEdital)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEdital");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");
            });

            modelBuilder.Entity<TbTmpLicitaco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpLicitacoes");

                entity.Property(e => e.DsClassificacaoObjeto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsClassificacaoObjeto");

                entity.Property(e => e.DsHoraAbertura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsHoraAbertura");

                entity.Property(e => e.DsHoraJulgamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsHoraJulgamento");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsNaturezaProcedimento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsNaturezaProcedimento");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsRegimeExecucao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dsRegimeExecucao");

                entity.Property(e => e.DsTipoAvaliacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoAvaliacao");

                entity.Property(e => e.DtAbertura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAbertura");

                entity.Property(e => e.DtEdital)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEdital");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtJulgamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtJulgamento");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmSetorCompra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmSetorCompra");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.VlMaximo)
                    .HasColumnType("money")
                    .HasColumnName("vlMaximo");

                entity.Property(e => e.VlMinimo)
                    .HasColumnType("money")
                    .HasColumnName("vlMinimo");
            });

            modelBuilder.Entity<TbTmpLicitacoesCorona>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpLicitacoesCorona");

                entity.Property(e => e.CdNatDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdNatDespesa");

                entity.Property(e => e.DsClassificacaoObjeto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsClassificacaoObjeto");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsRegimeExecucao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dsRegimeExecucao");

                entity.Property(e => e.DsTipoAvaliacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoAvaliacao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.Nrano).HasColumnName("nrano");

                entity.Property(e => e.VlMaximo)
                    .HasColumnType("money")
                    .HasColumnName("vlMaximo");
            });

            modelBuilder.Entity<TbTmpLicitacoesOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpLicitacoesOrigem");

                entity.Property(e => e.DataAbertura)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAbertura");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Justificativa)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.TipoEstagioLicitacao)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("tipoEstagioLicitacao");

                entity.Property(e => e.TipoModalidade)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tipoModalidade");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");
            });

            modelBuilder.Entity<TbTmpLicitacoesv2>(entity =>
            {
                entity.HasKey(e => e.IdLicitacao)
                    .HasName("PK__tbTmpLic__AA9DE6850E58732A");

                entity.ToTable("tbTmpLicitacoesv2");

                entity.Property(e => e.IdLicitacao).ValueGeneratedNever();

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");

                entity.Property(e => e.DsObjeto)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DtAbertura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAbertura");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtPublicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPublicacao");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrLicitacao).HasColumnName("nrLicitacao");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpNotasFiscaisDetalhesOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpNotasFiscaisDetalhesOrigem");

                entity.Property(e => e.CodigoNotaFiscal)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("codigoNotaFiscal");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.IdNotasFiscaisDetalhes)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idNotasFiscaisDetalhes");

                entity.Property(e => e.Idempenho).HasColumnName("idempenho");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.MaterialServico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("material_servico");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.Produto)
                    .IsUnicode(false)
                    .HasColumnName("produto");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("money")
                    .HasColumnName("quantidade");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("money")
                    .HasColumnName("valorUnitario");
            });

            modelBuilder.Entity<TbTmpNotasFiscaisOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpNotasFiscaisOrigem");

                entity.Property(e => e.CnpjFornecedor)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpjFornecedor");

                entity.Property(e => e.CodigoNotaFiscal)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("codigoNotaFiscal");

                entity.Property(e => e.DataEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEmissao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.IdNotasFiscais)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idNotasFiscais");

                entity.Property(e => e.Idempenho).HasColumnName("idempenho");

                entity.Property(e => e.Idpessoa).HasColumnName("idpessoa");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numeroSerie");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");
            });

            modelBuilder.Entity<TbTmpNotasFiscaisPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpNotasFiscaisPTI");

                entity.Property(e => e.CodigoNotaFiscal)
                    .HasMaxLength(130)
                    .IsUnicode(false)
                    .HasColumnName("codigoNotaFiscal");

                entity.Property(e => e.IdApoio).HasColumnName("idApoio");
            });

            modelBuilder.Entity<TbTmpOrcReceita>(entity =>
            {
                entity.HasKey(e => e.IdReceita)
                    .HasName("PK_tbOrcReceitas");

                entity.ToTable("tbTmpOrcReceitas");

                entity.Property(e => e.IdReceita).ValueGeneratedNever();

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DsEspecificacao)
                    .IsUnicode(false)
                    .HasColumnName("dsEspecificacao");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.DsTipoReceitaPadrao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoReceitaPadrao");

                entity.Property(e => e.DtCadastro)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCadastro");

                entity.Property(e => e.DtDesativacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDesativacao");

                entity.Property(e => e.FlReceitaIntraOrcamentaria)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flReceitaIntraOrcamentaria")
                    .IsFixedLength();

                entity.Property(e => e.FlReceitaPadrao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flReceitaPadrao")
                    .IsFixedLength();

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.HasOne(d => d.IdReceitaNivelSuperNavigation)
                    .WithMany(p => p.InverseIdReceitaNivelSuperNavigation)
                    .HasForeignKey(d => d.IdReceitaNivelSuper)
                    .HasConstraintName("FK_tbTmpOrcReceitas_tbOrcReceitas");
            });

            modelBuilder.Entity<TbTmpOrcReceitasArrecadaAno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpOrcReceitasArrecadaAno");

                entity.Property(e => e.Abril).HasColumnType("money");

                entity.Property(e => e.Acumulado).HasColumnType("money");

                entity.Property(e => e.Agosto).HasColumnType("money");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.Dezembro).HasColumnType("money");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Fevereiro).HasColumnType("money");

                entity.Property(e => e.Janeiro).HasColumnType("money");

                entity.Property(e => e.Julho).HasColumnType("money");

                entity.Property(e => e.Junho).HasColumnType("money");

                entity.Property(e => e.Maio).HasColumnType("money");

                entity.Property(e => e.Março).HasColumnType("money");

                entity.Property(e => e.Novembro).HasColumnType("money");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.Outubro).HasColumnType("money");

                entity.Property(e => e.Setembro).HasColumnType("money");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VlCorrigido)
                    .HasColumnType("money")
                    .HasColumnName("vlCorrigido");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");
            });

            modelBuilder.Entity<TbTmpOrcReceitasMovimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpOrcReceitasMovimento");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.DsUnidadeOrcamentaria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dsUnidadeOrcamentaria");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.FlReceitaIntraOrcamentaria)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flReceitaIntraOrcamentaria")
                    .IsFixedLength();

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.OrgaoRepassador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");
            });

            modelBuilder.Entity<TbTmpPagamentosAssistSocial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpPagamentosAssistSocial");

                entity.Property(e => e.CdContaContabil)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdContaContabil");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.DsContaContabil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaContabil");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsRecurso)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRecurso");

                entity.Property(e => e.DsSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSerie");

                entity.Property(e => e.DtDespesa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDespesa");

                entity.Property(e => e.DtDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDocumento");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLiquidacao");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPagamento");

                entity.Property(e => e.DtVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVencimento");

                entity.Property(e => e.EmpHistorico).IsUnicode(false);

                entity.Property(e => e.Iddotacao).HasColumnName("IDDotacao");

                entity.Property(e => e.MesCompetencia).HasColumnName("mesCompetencia");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmTipoDocFinanceiro)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoDocFinanceiro");

                entity.Property(e => e.NmTipoDoctoFiscal)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoDoctoFiscal");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoDespesa).HasColumnName("nrAnoDespesa");

                entity.Property(e => e.NrAnoLiquidacao).HasColumnName("nrAnoLiquidacao");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrDespesa).HasColumnName("nrDespesa");

                entity.Property(e => e.NrDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrDocumento");

                entity.Property(e => e.NrDocumentoFiscal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrDocumentoFiscal");

                entity.Property(e => e.NrSequencia).HasColumnName("nrSequencia");

                entity.Property(e => e.NrSequenciaLiquidacao).HasColumnName("nrSequenciaLiquidacao");

                entity.Property(e => e.SqAnualPgto).HasColumnName("sqAnualPgto");

                entity.Property(e => e.TipoDespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VlAnulado)
                    .HasColumnType("money")
                    .HasColumnName("vlAnulado");

                entity.Property(e => e.VlDocumento)
                    .HasColumnType("money")
                    .HasColumnName("vlDocumento");

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamento");

                entity.Property(e => e.VlPagamentoDocto)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamentoDocto");

                entity.Property(e => e.VlRetencoes)
                    .HasColumnType("money")
                    .HasColumnName("vlRetencoes");

                entity.Property(e => e.VlRetencoesDocto)
                    .HasColumnType("money")
                    .HasColumnName("vlRetencoesDocto");
            });

            modelBuilder.Entity<TbTmpPagamentosAssistSocialParceria>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpPagamentosAssistSocialParcerias");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsRecurso)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRecurso");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPagamento");

                entity.Property(e => e.MesCompetencia).HasColumnName("mesCompetencia");

                entity.Property(e => e.NmCc)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nmCC");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrAnoSubvencao).HasColumnName("nrAnoSubvencao");

                entity.Property(e => e.NrCc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nrCC");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrSequencia)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("nrSequencia");

                entity.Property(e => e.NrTermo).HasColumnName("nrTermo");

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamento");

                entity.Property(e => e.VlPagamentoDocto)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamentoDocto");

                entity.Property(e => e.VlPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("vlPrevisto");
            });

            modelBuilder.Entity<TbTmpPassagen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpPassagens");

                entity.Property(e => e.Cdnatdespesa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("cdnatdespesa");

                entity.Property(e => e.DsDestino)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("dsDestino");

                entity.Property(e => e.DsNatDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNatDespesa");

                entity.Property(e => e.DsObjetivo)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetivo");

                entity.Property(e => e.DsTipoLocomocao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoLocomocao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtFim)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFim");

                entity.Property(e => e.DtInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicio");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrDiarias)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("nrDiarias");

                entity.Property(e => e.VlTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlTotal");

                entity.Property(e => e.VlUnitario)
                    .HasColumnType("money")
                    .HasColumnName("vlUnitario");
            });

            modelBuilder.Entity<TbTmpPublicidadeEmpenho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpPublicidadeEmpenho");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.ConsigLiq).HasColumnType("money");

                entity.Property(e => e.DescontoLiq).HasColumnType("money");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLiquidacao");

                entity.Property(e => e.EstExt).HasColumnType("money");

                entity.Property(e => e.EstLiq).HasColumnType("money");

                entity.Property(e => e.EstPagLiq).HasColumnType("money");

                entity.Property(e => e.Iddotacao).HasColumnName("IDDotacao");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NrSequencia).HasColumnName("nrSequencia");

                entity.Property(e => e.PagoLiq).HasColumnType("money");

                entity.Property(e => e.Rms)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RMS");

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlLiquidacao)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidacao");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("vlPago");

                entity.Property(e => e.VlReversao)
                    .HasColumnType("money")
                    .HasColumnName("vlReversao");

                entity.Property(e => e.VlrAnulado).HasColumnType("money");

                entity.Property(e => e.VlrCancelado).HasColumnType("money");

                entity.Property(e => e.VlrConsignado).HasColumnType("money");

                entity.Property(e => e.VlrDevolvido).HasColumnType("money");

                entity.Property(e => e.VlrEstornoConsig).HasColumnType("money");

                entity.Property(e => e.VlrLiquidação).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");
            });

            modelBuilder.Entity<TbTmpPublicidadeEmpenhoCovid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpPublicidadeEmpenhoCovid");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.ConsigLiq).HasColumnType("money");

                entity.Property(e => e.DescontoLiq).HasColumnType("money");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DtEmpenho)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEmpenho");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLiquidacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLiquidacao");

                entity.Property(e => e.EstExt).HasColumnType("money");

                entity.Property(e => e.EstLiq).HasColumnType("money");

                entity.Property(e => e.EstPagLiq).HasColumnType("money");

                entity.Property(e => e.Iddotacao).HasColumnName("IDDotacao");

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrEmpenho).HasColumnName("nrEmpenho");

                entity.Property(e => e.NrSequencia).HasColumnName("nrSequencia");

                entity.Property(e => e.PagoLiq).HasColumnType("money");

                entity.Property(e => e.Rms)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("RMS");

                entity.Property(e => e.VlEmpenho)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenho");

                entity.Property(e => e.VlLiquidacao)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidacao");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("vlPago");

                entity.Property(e => e.VlReversao)
                    .HasColumnType("money")
                    .HasColumnName("vlReversao");

                entity.Property(e => e.VlrAnulado).HasColumnType("money");

                entity.Property(e => e.VlrCancelado).HasColumnType("money");

                entity.Property(e => e.VlrConsignado).HasColumnType("money");

                entity.Property(e => e.VlrDevolvido).HasColumnType("money");

                entity.Property(e => e.VlrEstornoConsig).HasColumnType("money");

                entity.Property(e => e.VlrLiquidação).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");
            });

            modelBuilder.Entity<TbTmpQuadroFuncionalOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpQuadroFuncionalOrigem");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DataAlocacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAlocacao");

                entity.Property(e => e.DataDispensa).HasColumnName("dataDispensa");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.FormaInvestidura)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("formaInvestidura");

                entity.Property(e => e.HorarioTrabalho)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("horarioTrabalho");

                entity.Property(e => e.LocalLotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("localLotacao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSituacao)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("tipoSituacao");
            });

            modelBuilder.Entity<TbTmpRazaoContabil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpRazaoContabil");

                entity.Property(e => e.CdContaContabil)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdContaContabil");

                entity.Property(e => e.DsContaContabil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaContabil");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsOrigem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOrigem");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLancamento");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.NrSequencial).HasColumnName("nrSequencial");

                entity.Property(e => e.Nrano).HasColumnName("nrano");

                entity.Property(e => e.ValorEntrada).HasColumnType("money");

                entity.Property(e => e.ValorSaida).HasColumnType("money");

                entity.Property(e => e.VlSaldoInicial)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicial");

                entity.Property(e => e.VlSaldoInicialContaCont)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicialContaCont");
            });

            modelBuilder.Entity<TbTmpRazaoContabilOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpRazaoContabil_OLD");

                entity.Property(e => e.CdContaContabil)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdContaContabil");

                entity.Property(e => e.DsContaContabil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaContabil");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsOrigem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOrigem");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLancamento");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.NrSequencial).HasColumnName("nrSequencial");

                entity.Property(e => e.Nrano).HasColumnName("nrano");

                entity.Property(e => e.ValorEntrada).HasColumnType("money");

                entity.Property(e => e.ValorSaida).HasColumnType("money");

                entity.Property(e => e.VlSaldoInicial)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicial");

                entity.Property(e => e.VlSaldoInicialContaCont)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicialContaCont");
            });

            modelBuilder.Entity<TbTmpRazaoContabilOld1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpRazaoContabil_OLD1");

                entity.Property(e => e.CdContaContabil)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("cdContaContabil");

                entity.Property(e => e.DsContaContabil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaContabil");

                entity.Property(e => e.DsHistorico)
                    .IsUnicode(false)
                    .HasColumnName("dsHistorico");

                entity.Property(e => e.DsOrigem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOrigem");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLancamento");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.NrSequencial).HasColumnName("nrSequencial");

                entity.Property(e => e.Nrano).HasColumnName("nrano");

                entity.Property(e => e.ValorEntrada).HasColumnType("money");

                entity.Property(e => e.ValorSaida).HasColumnType("money");

                entity.Property(e => e.VlSaldoInicial)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicial");

                entity.Property(e => e.VlSaldoInicialContaCont)
                    .HasColumnType("money")
                    .HasColumnName("vlSaldoInicialContaCont");
            });

            modelBuilder.Entity<TbTmpReceita>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitas");

                entity.Property(e => e.Abril).HasColumnType("money");

                entity.Property(e => e.Acumulado).HasColumnType("money");

                entity.Property(e => e.Agosto).HasColumnType("money");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.Dezembro).HasColumnType("money");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Fevereiro).HasColumnType("money");

                entity.Property(e => e.Janeiro).HasColumnType("money");

                entity.Property(e => e.Julho).HasColumnType("money");

                entity.Property(e => e.Junho).HasColumnType("money");

                entity.Property(e => e.Maio).HasColumnType("money");

                entity.Property(e => e.Março).HasColumnType("money");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.Novembro).HasColumnType("money");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(263)
                    .IsUnicode(false);

                entity.Property(e => e.Outubro).HasColumnType("money");

                entity.Property(e => e.Setembro).HasColumnType("money");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Unidade)
                    .HasMaxLength(261)
                    .IsUnicode(false);

                entity.Property(e => e.VlCorrigido)
                    .HasColumnType("money")
                    .HasColumnName("vlCorrigido");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");
            });

            modelBuilder.Entity<TbTmpReceitaArrecadaOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitaArrecadaOrigem");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.IdReceitaArrecadada).ValueGeneratedOnAdd();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.ValorArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("valorArrecadado");

                entity.Property(e => e.ValorPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("valorPrevisto");
            });

            modelBuilder.Entity<TbTmpReceitasCovid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitasCovid");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.DsContaContabil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaContabil");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");

                entity.Property(e => e.DsHistoricoMovimento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsHistoricoMovimento");

                entity.Property(e => e.DsOrgaoRepassador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsOrgaoRepassador");

                entity.Property(e => e.DsRecurso)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRecurso");

                entity.Property(e => e.DsTipoOperacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoOperacao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtLancamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtLancamento");

                entity.Property(e => e.VlLancadoFonte)
                    .HasColumnType("money")
                    .HasColumnName("vlLancadoFonte");
            });

            modelBuilder.Entity<TbTmpReceitasDdanovo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitasDDANovo");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(263)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(261)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlArrecadadoMes)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoMes");

                entity.Property(e => e.VlArrecadadoPeriodo)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoPeriodo");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");

                entity.Property(e => e.VlReestimado1)
                    .HasColumnType("money")
                    .HasColumnName("vlReestimado1");

                entity.Property(e => e.VlReestimado2)
                    .HasColumnType("money")
                    .HasColumnName("vlReestimado2");
            });

            modelBuilder.Entity<TbTmpReceitasOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitasOrigem");

                entity.Property(e => e.Acumulado).HasColumnType("money");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VlCorrigido)
                    .HasColumnType("money")
                    .HasColumnName("vlCorrigido");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");
            });

            modelBuilder.Entity<TbTmpReceitasSuporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpReceitasSuporte");

                entity.Property(e => e.Abril).HasColumnType("money");

                entity.Property(e => e.Acumulado).HasColumnType("money");

                entity.Property(e => e.Agosto).HasColumnType("money");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.Dezembro).HasColumnType("money");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");

                entity.Property(e => e.Fevereiro).HasColumnType("money");

                entity.Property(e => e.Janeiro).HasColumnType("money");

                entity.Property(e => e.Julho).HasColumnType("money");

                entity.Property(e => e.Junho).HasColumnType("money");

                entity.Property(e => e.Maio).HasColumnType("money");

                entity.Property(e => e.Março).HasColumnType("money");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.Novembro).HasColumnType("money");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(263)
                    .IsUnicode(false);

                entity.Property(e => e.Outubro).HasColumnType("money");

                entity.Property(e => e.Setembro).HasColumnType("money");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Unidade)
                    .HasMaxLength(261)
                    .IsUnicode(false);

                entity.Property(e => e.VlCorrigido)
                    .HasColumnType("money")
                    .HasColumnName("vlCorrigido");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");
            });

            modelBuilder.Entity<TbTmpServidoresCedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpServidoresCedidos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DataAlocacao).HasColumnType("datetime");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Escala)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula).HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoDestino)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpServidoresRecebido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpServidoresRecebidos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DataAlocacao).HasColumnType("datetime");

                entity.Property(e => e.Datnot)
                    .HasColumnType("datetime")
                    .HasColumnName("datnot");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Escala)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula).HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OrgaoDestino)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipnot).HasColumnName("tipnot");
            });

            modelBuilder.Entity<TbTmpServidoresTemporario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpServidoresTemporarios");

                entity.Property(e => e.Admissao).HasColumnType("datetime");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodCargo)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("codCargo");

                entity.Property(e => e.CodLotacao)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("codLotacao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Escala)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lotacao)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoContrato)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Regime)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpServidoresTemporariosOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpServidoresTemporariosOrigem");

                entity.Property(e => e.CargaHoraria)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cargaHoraria");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.DataAlocacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataAlocacao");

                entity.Property(e => e.DataDispensa)
                    .HasColumnType("datetime")
                    .HasColumnName("dataDispensa");

                entity.Property(e => e.FormaInvestidura)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("formaInvestidura");

                entity.Property(e => e.HorarioTrabalho)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("horarioTrabalho");

                entity.Property(e => e.IdServTemporario)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idServTemporario");

                entity.Property(e => e.LocalLotacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("localLotacao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<TbTmpSubvencoesAditivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpSubvencoesAditivos");

                entity.Property(e => e.CdSubvencaoSocial).HasColumnName("cdSubvencaoSocial");

                entity.Property(e => e.Dotacao)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.DsAditivoObjeto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsAditivoObjeto");

                entity.Property(e => e.DsTipoExecucao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoExecucao");

                entity.Property(e => e.DsTpEntidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpEntidade");

                entity.Property(e => e.DtAditivo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAditivo");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtVencimentoConvenio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVencimentoConvenio");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAditivo).HasColumnName("nrAditivo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");
            });

            modelBuilder.Entity<TbTmpSubvencoesSociai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpSubvencoesSociais");

                entity.Property(e => e.CdSubvencaoSocial).HasColumnName("cdSubvencaoSocial");

                entity.Property(e => e.Dotacao)
                    .HasMaxLength(307)
                    .IsUnicode(false);

                entity.Property(e => e.DsLeiAutorizatoria)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("dsLeiAutorizatoria");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoExecucao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoExecucao");

                entity.Property(e => e.DsTpEntidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpEntidade");

                entity.Property(e => e.DsUnidadeMedida)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsUnidadeMedida");

                entity.Property(e => e.DtCelebracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCelebracao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioConvenio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioConvenio");

                entity.Property(e => e.DtPrazoFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPrazoFinal");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrQtdPrevista).HasColumnName("nrQtdPrevista");

                entity.Property(e => e.TpResultadoConclusivo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tpResultadoConclusivo");

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlEmpenhado).HasColumnType("money");

                entity.Property(e => e.VlPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("vlPrevisto");

                entity.Property(e => e.VlrEstornoPagamento).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");

                entity.Property(e => e.Órgão)
                    .HasMaxLength(261)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpSubvencoesSociaisOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpSubvencoesSociaisOrigem");

                entity.Property(e => e.CdSubvencaoSocial).HasColumnName("cdSubvencaoSocial");

                entity.Property(e => e.Dotacao)
                    .HasMaxLength(307)
                    .IsUnicode(false);

                entity.Property(e => e.DsLeiAutorizatoria)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("dsLeiAutorizatoria");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoExecucao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoExecucao");

                entity.Property(e => e.DsTpEntidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpEntidade");

                entity.Property(e => e.DsUnidadeMedida)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsUnidadeMedida");

                entity.Property(e => e.DtCelebracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCelebracao");

                entity.Property(e => e.DtExecucao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtExecucao");

                entity.Property(e => e.DtInicioConvenio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioConvenio");

                entity.Property(e => e.DtPrazoFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPrazoFinal");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrQtdPrevista).HasColumnName("nrQtdPrevista");

                entity.Property(e => e.NumeroAditivoVigente).HasColumnName("numeroAditivoVigente");

                entity.Property(e => e.TpResultadoConclusivo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tpResultadoConclusivo");

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlContrapartida)
                    .HasColumnType("money")
                    .HasColumnName("vlContrapartida");

                entity.Property(e => e.VlEmpenhado).HasColumnType("money");

                entity.Property(e => e.VlPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("vlPrevisto");

                entity.Property(e => e.VlrEstornoPagamento).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");

                entity.Property(e => e.Órgão)
                    .HasMaxLength(261)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpSubvencoesSociaisPti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpSubvencoesSociaisPTI");

                entity.Property(e => e.CdSubvencaoSocial).HasColumnName("cdSubvencaoSocial");

                entity.Property(e => e.Dotacao)
                    .HasMaxLength(307)
                    .IsUnicode(false);

                entity.Property(e => e.DsLeiAutorizatoria)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("dsLeiAutorizatoria");

                entity.Property(e => e.DsObjeto)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("dsObjeto");

                entity.Property(e => e.DsTipoExecucao)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoExecucao");

                entity.Property(e => e.DsTpEntidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTpEntidade");

                entity.Property(e => e.DsUnidadeMedida)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsUnidadeMedida");

                entity.Property(e => e.DtCelebracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCelebracao");

                entity.Property(e => e.DtInicioConvenio)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInicioConvenio");

                entity.Property(e => e.DtPrazoFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("dtPrazoFinal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NmPessoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPessoa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ");

                entity.Property(e => e.NrCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJCPF");

                entity.Property(e => e.NrQtdPrevista).HasColumnName("nrQtdPrevista");

                entity.Property(e => e.NumeroAditivoVigente).HasColumnName("numeroAditivoVigente");

                entity.Property(e => e.TpResultadoConclusivo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tpResultadoConclusivo");

                entity.Property(e => e.VlAditivos)
                    .HasColumnType("money")
                    .HasColumnName("vlAditivos");

                entity.Property(e => e.VlContrapartida)
                    .HasColumnType("money")
                    .HasColumnName("vlContrapartida");

                entity.Property(e => e.VlEmpenhado).HasColumnType("money");

                entity.Property(e => e.VlPrevisto)
                    .HasColumnType("money")
                    .HasColumnName("vlPrevisto");

                entity.Property(e => e.VlrEstornoPagamento).HasColumnType("money");

                entity.Property(e => e.VlrPagamento).HasColumnType("money");

                entity.Property(e => e.Órgão)
                    .HasMaxLength(261)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTmpTransfVoluntariaOrigem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbTmpTransfVoluntariaOrigem");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAtualizacao");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<VwDimReceita2ano>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_DIM_RECEITA_2ANOS");

                entity.Property(e => e.Receita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RECEITA");
            });

            modelBuilder.Entity<VwFatArrecadacao2ano>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_FAT_ARRECADACAO_2ANOS");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Receita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RECEITA");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.Property(e => e.ValorAcumulado)
                    .HasColumnType("money")
                    .HasColumnName("VALOR ACUMULADO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
