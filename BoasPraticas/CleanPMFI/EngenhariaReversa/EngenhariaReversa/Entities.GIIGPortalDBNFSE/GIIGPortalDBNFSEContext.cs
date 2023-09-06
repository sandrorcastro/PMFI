using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGPortalDBNFSE
{
    public partial class GIIGPortalDBNFSEContext : DbContext
    {
        public GIIGPortalDBNFSEContext()
        {
        }

        public GIIGPortalDBNFSEContext(DbContextOptions<GIIGPortalDBNFSEContext> options)
            : base(options)
        {
        }

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
        public virtual DbSet<TbNavLinkModulo> TbNavLinkModulos { get; set; } = null!;
        public virtual DbSet<TbNavPaginasPadrao> TbNavPaginasPadraos { get; set; } = null!;
        public virtual DbSet<TbNavPerguntasFrequente> TbNavPerguntasFrequentes { get; set; } = null!;
        public virtual DbSet<TbNfseLayoutDefault> TbNfseLayoutDefaults { get; set; } = null!;
        public virtual DbSet<TbNfseLayoutDefaultPasso> TbNfseLayoutDefaultPassos { get; set; } = null!;
        public virtual DbSet<TbPubArquivo> TbPubArquivos { get; set; } = null!;
        public virtual DbSet<TbPubArquivosListum> TbPubArquivosLista { get; set; } = null!;
        public virtual DbSet<TbPubCategoria> TbPubCategorias { get; set; } = null!;
        public virtual DbSet<TbPubFonteDado> TbPubFonteDados { get; set; } = null!;
        public virtual DbSet<TbPubFonteDadosFiltro> TbPubFonteDadosFiltros { get; set; } = null!;
        public virtual DbSet<TbPubVisaoFonteDado> TbPubVisaoFonteDados { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGPortalDBNFSE;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

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

                entity.Property(e => e.DsTipoEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoEmpresa")
                    .HasComment("Se é Prefeitura/Câmara/Autarquia/Previência");

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

                entity.Property(e => e.DsLinkItem).HasColumnName("dsLinkItem");

                entity.Property(e => e.DsTituloPagina)
                    .HasMaxLength(50)
                    .HasColumnName("dsTituloPagina");

                entity.Property(e => e.Dslink)
                    .HasMaxLength(150)
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
                    .HasMaxLength(50)
                    .HasColumnName("nmLinkItem");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");

                entity.Property(e => e.NrVisualizacoes).HasColumnName("nrVisualizacoes");

                entity.HasOne(d => d.IdLinkModuloNavigation)
                    .WithMany(p => p.TbNavLinkItens)
                    .HasForeignKey(d => d.IdLinkModulo)
                    .HasConstraintName("FK_tbNavLinkItem_tbNavLinkModulos");
            });

            modelBuilder.Entity<TbNavLinkModulo>(entity =>
            {
                entity.HasKey(e => e.IdLinkModulo);

                entity.ToTable("tbNavLinkModulos");

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
                    .HasMaxLength(30)
                    .HasColumnName("nmLinkModulo");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbNavPaginasPadrao>(entity =>
            {
                entity.HasKey(e => e.IdPaginaPadrao)
                    .HasName("PK_tbNavPaginaPadrao");

                entity.ToTable("tbNavPaginasPadrao");

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

            modelBuilder.Entity<TbPubArquivo>(entity =>
            {
                entity.HasKey(e => e.IdArquivo);

                entity.ToTable("tbPubArquivos");

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
                    .HasMaxLength(50)
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

                entity.Property(e => e.DsQuery)
                    .IsUnicode(false)
                    .HasColumnName("dsQuery");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
