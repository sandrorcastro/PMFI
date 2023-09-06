using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class GIIGConsultaPreviaDBContext : DbContext
    {
        public GIIGConsultaPreviaDBContext()
        {
        }

        public GIIGConsultaPreviaDBContext(DbContextOptions<GIIGConsultaPreviaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Smma> Smmas { get; set; } = null!;
        public virtual DbSet<SysAutoIncrement> SysAutoIncrements { get; set; } = null!;
        public virtual DbSet<TabCnaeunidade> TabCnaeunidades { get; set; } = null!;
        public virtual DbSet<TabConfiguracao> TabConfiguracaos { get; set; } = null!;
        public virtual DbSet<TabConsultaAnexo> TabConsultaAnexos { get; set; } = null!;
        public virtual DbSet<TabConsultaAviso> TabConsultaAvisos { get; set; } = null!;
        public virtual DbSet<TabConsultaCnae> TabConsultaCnaes { get; set; } = null!;
        public virtual DbSet<TabConsultaDado> TabConsultaDados { get; set; } = null!;
        public virtual DbSet<TabConsultaDesdobramento> TabConsultaDesdobramentos { get; set; } = null!;
        public virtual DbSet<TabConsultaDocumento> TabConsultaDocumentos { get; set; } = null!;
        public virtual DbSet<TabConsultaDocumentoPergunta> TabConsultaDocumentoPerguntas { get; set; } = null!;
        public virtual DbSet<TabConsultaImpressao> TabConsultaImpressaos { get; set; } = null!;
        public virtual DbSet<TabConsultaResposta> TabConsultaRespostas { get; set; } = null!;
        public virtual DbSet<TabConsultaTipo> TabConsultaTipos { get; set; } = null!;
        public virtual DbSet<TabConsultaUnidadeDividum> TabConsultaUnidadeDivida { get; set; } = null!;
        public virtual DbSet<TabConsultum> TabConsulta { get; set; } = null!;
        public virtual DbSet<TabContribuintePermissao> TabContribuintePermissaos { get; set; } = null!;
        public virtual DbSet<TabDesdobramento> TabDesdobramentos { get; set; } = null!;
        public virtual DbSet<TabDocumento> TabDocumentos { get; set; } = null!;
        public virtual DbSet<TabDocumentoCnae> TabDocumentoCnaes { get; set; } = null!;
        public virtual DbSet<TabDocumentoCnaetipoContribuinte> TabDocumentoCnaetipoContribuintes { get; set; } = null!;
        public virtual DbSet<TabFuncionario> TabFuncionarios { get; set; } = null!;
        public virtual DbSet<TabTipoContribuinte> TabTipoContribuintes { get; set; } = null!;
        public virtual DbSet<TabTipoInstalacao> TabTipoInstalacaos { get; set; } = null!;
        public virtual DbSet<TabTipoInstalacaoTipoContribuinte> TabTipoInstalacaoTipoContribuintes { get; set; } = null!;
        public virtual DbSet<TabUnidade> TabUnidades { get; set; } = null!;
        public virtual DbSet<TribParamClassificacaoReceitum> TribParamClassificacaoReceita { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGConsultaPreviaDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<Smma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smma");

                entity.Property(e => e.Cnae)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNAE");

                entity.Property(e => e.Coluna10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 10");

                entity.Property(e => e.Coluna11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 11");

                entity.Property(e => e.Coluna12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 12");

                entity.Property(e => e.Coluna13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coluna 13");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Graurisco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRAURISCO");

                entity.Property(e => e.Las)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAS");

                entity.Property(e => e.LpLiLo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LP-LI-LO");

                entity.Property(e => e.Orgaosexternos)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ORGAOSEXTERNOS");

                entity.Property(e => e.Perguntas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PERGUNTAS");

                entity.Property(e => e.Pgrs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGRS");

                entity.Property(e => e.Pgrss)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PGRSS");

                entity.Property(e => e.Tcgrs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCGRS");
            });

            modelBuilder.Entity<SysAutoIncrement>(entity =>
            {
                entity.HasKey(e => e.SysTableName);

                entity.ToTable("sysAutoIncrement");

                entity.Property(e => e.SysTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sysTableName");

                entity.Property(e => e.SysTableKeyValue).HasColumnName("sysTableKeyValue");
            });

            modelBuilder.Entity<TabCnaeunidade>(entity =>
            {
                entity.HasKey(e => e.IdFluxo)
                    .HasName("PK__tabCNAEU__1BE0F0FD3864608B");

                entity.ToTable("tabCNAEUnidade");

                entity.Property(e => e.IdFluxo).HasColumnName("idFluxo");

                entity.Property(e => e.IdDesdobramento).HasColumnName("idDesdobramento");

                entity.Property(e => e.SubCid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("subCid");

                entity.Property(e => e.UnidId).HasColumnName("unidId");
            });

            modelBuilder.Entity<TabConfiguracao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabConfiguracao");

                entity.Property(e => e.HeaderRelatorio).HasColumnType("text");
            });

            modelBuilder.Entity<TabConsultaAnexo>(entity =>
            {
                entity.HasKey(e => e.CoanId);

                entity.ToTable("tabConsultaAnexo");

                entity.Property(e => e.CoanId)
                    .ValueGeneratedNever()
                    .HasColumnName("coanId");

                entity.Property(e => e.CoanAnexo).HasColumnName("coanAnexo");

                entity.Property(e => e.CoanContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coanContentType");

                entity.Property(e => e.CoanDescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("coanDescricao");

                entity.Property(e => e.CoanExtensao)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("coanExtensao");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.HasOne(d => d.Cons)
                    .WithMany(p => p.TabConsultaAnexos)
                    .HasForeignKey(d => d.ConsId)
                    .HasConstraintName("FK_tabConsultaAnexo_tabConsulta");
            });

            modelBuilder.Entity<TabConsultaAviso>(entity =>
            {
                entity.HasKey(e => e.CoavId);

                entity.ToTable("tabConsultaAviso");

                entity.Property(e => e.CoavId)
                    .ValueGeneratedNever()
                    .HasColumnName("coavId");

                entity.Property(e => e.CoavAviso)
                    .IsUnicode(false)
                    .HasColumnName("coavAviso");

                entity.Property(e => e.CoavData)
                    .HasColumnType("datetime")
                    .HasColumnName("coavData");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.Cons)
                    .WithMany(p => p.TabConsultaAvisos)
                    .HasForeignKey(d => d.ConsId)
                    .HasConstraintName("FK_tabConsultaAviso_tabConsulta");

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.TabConsultaAvisos)
                    .HasForeignKey(d => d.FuncId)
                    .HasConstraintName("FK_tabConsultaAviso_tabFuncionario");

                entity.HasOne(d => d.Unid)
                    .WithMany(p => p.TabConsultaAvisos)
                    .HasForeignKey(d => d.UnidId)
                    .HasConstraintName("FK_tabConsultaAviso_tabUnidade");
            });

            modelBuilder.Entity<TabConsultaCnae>(entity =>
            {
                entity.HasKey(e => e.ConsCnaeid);

                entity.ToTable("tabConsultaCNAE");

                entity.HasIndex(e => e.ConsId, "IX_tabConsultaCNAE_consId");

                entity.HasIndex(e => new { e.ConsId, e.ConsStatus }, "IX_tabConsultaCNAE_consId_consStatus_inc_consParecer");

                entity.HasIndex(e => e.ConsId, "IX_tabConsultaCNAE_consId_inc_consPermissao");

                entity.HasIndex(e => new { e.ConsId, e.SubCid }, "IX_tabConsultaCNAE_consId_subCId");

                entity.HasIndex(e => new { e.ConsId, e.UnidId }, "IX_tabConsultaCNAE_consId_unidId");

                entity.HasIndex(e => new { e.ConsId, e.UnidId, e.ConsStatus }, "IX_tabConsultaCNAE_consId_unidId_consStatus");

                entity.HasIndex(e => new { e.ConsId, e.UnidId }, "IX_tabConsultaCNAE_consId_unidId_inc_consStatus");

                entity.HasIndex(e => new { e.ConsId, e.UnidId }, "IX_tabConsultaCNAE_consId_unidId_inc_subCId_consStatus");

                entity.HasIndex(e => new { e.ConsId, e.UnidId, e.SubCid }, "IX_tabConsultaCNAE_consId_unidId_subCId");

                entity.HasIndex(e => e.UnidId, "IX_tabConsultaCNAE_unidId");

                entity.HasIndex(e => new { e.UnidId, e.ConsStatus }, "IX_tabConsultaCNAE_unidId_consStatus_inc_consId");

                entity.HasIndex(e => e.UnidId, "IX_tabConsultaCNAE_unidId_inc_consId_consStatus");

                entity.Property(e => e.ConsCnaeid)
                    .ValueGeneratedNever()
                    .HasColumnName("consCNAEId");

                entity.Property(e => e.ConsDtParecer)
                    .HasColumnType("datetime")
                    .HasColumnName("consDtParecer");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.ConsParecer)
                    .IsUnicode(false)
                    .HasColumnName("consParecer");

                entity.Property(e => e.ConsPermissao)
                    .IsUnicode(false)
                    .HasColumnName("consPermissao");

                entity.Property(e => e.ConsStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("consStatus")
                    .IsFixedLength();

                entity.Property(e => e.FlAtividadePrincipal)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flAtividadePrincipal")
                    .IsFixedLength();

                entity.Property(e => e.FlExercenoEndereco)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flExercenoEndereco")
                    .IsFixedLength();

                entity.Property(e => e.SubCid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("subCId")
                    .IsFixedLength();

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.Cons)
                    .WithMany(p => p.TabConsultaCnaes)
                    .HasForeignKey(d => d.ConsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabConsultaCNAE_tabConsulta");
            });

            modelBuilder.Entity<TabConsultaDado>(entity =>
            {
                entity.HasKey(e => e.CodaId);

                entity.ToTable("tabConsultaDado");

                entity.HasIndex(e => new { e.CodaInscricao, e.CodaRequerenteCnpjcpf }, "IX_tabConsultaDado_codaInscricao_codaRequerenteCNPJCPF");

                entity.HasIndex(e => e.ConsId, "IX_tabConsultaDado_consId_inc_codaCEP_codaEnd_codaReq_codaFonCont_codaAreaCob_codaReqCNPJCPF");

                entity.HasIndex(e => e.ConsId, "IX_tabConsultaDado_consId_inc_codaRequerente");

                entity.Property(e => e.CodaId)
                    .ValueGeneratedNever()
                    .HasColumnName("codaId");

                entity.Property(e => e.CodaAreaCoberta)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("codaAreaCoberta");

                entity.Property(e => e.CodaAreaDescoberta)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("codaAreaDescoberta");

                entity.Property(e => e.CodaAtividade)
                    .IsUnicode(false)
                    .HasColumnName("codaAtividade");

                entity.Property(e => e.CodaCep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("codaCEP");

                entity.Property(e => e.CodaContador)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaContador");

                entity.Property(e => e.CodaEndereco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaEndereco");

                entity.Property(e => e.CodaFoneContato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codaFoneContato");

                entity.Property(e => e.CodaFundos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("codaFundos");

                entity.Property(e => e.CodaInformacao)
                    .IsUnicode(false)
                    .HasColumnName("codaInformacao");

                entity.Property(e => e.CodaInscricao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("codaInscricao");

                entity.Property(e => e.CodaNome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaNome");

                entity.Property(e => e.CodaNumeroPav).HasColumnName("codaNumeroPav");

                entity.Property(e => e.CodaProprietario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaProprietario");

                entity.Property(e => e.CodaRequerente)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaRequerente");

                entity.Property(e => e.CodaRequerenteCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("codaRequerenteCNPJCPF");

                entity.Property(e => e.CodaTransversais)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("codaTransversais");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.IdAtividadePrincipal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idAtividadePrincipal");

                entity.Property(e => e.IdTipoContribuinte).HasColumnName("idTipoContribuinte");

                entity.Property(e => e.IdTipoInstalacao).HasColumnName("idTipoInstalacao");

                entity.Property(e => e.VlTipoInstalacao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vlTipoInstalacao");

                entity.HasOne(d => d.Cons)
                    .WithMany(p => p.TabConsultaDados)
                    .HasForeignKey(d => d.ConsId)
                    .HasConstraintName("FK_tabConsultaDado_tabConsulta");

                entity.HasOne(d => d.IdTipoContribuinteNavigation)
                    .WithMany(p => p.TabConsultaDados)
                    .HasForeignKey(d => d.IdTipoContribuinte)
                    .HasConstraintName("FK_tabConsultaDado_tabTipoContribuinte");
            });

            modelBuilder.Entity<TabConsultaDesdobramento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabConsultaDesdobramento");

                entity.Property(e => e.ConsCnaeid).HasColumnName("consCNAEId");

                entity.Property(e => e.IdDesdobramento).HasColumnName("idDesdobramento");
            });

            modelBuilder.Entity<TabConsultaDocumento>(entity =>
            {
                entity.HasKey(e => new { e.ConsId, e.DocuId })
                    .HasName("PK_tabConsultaDocumento_1");

                entity.ToTable("tabConsultaDocumento");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.DocuId).HasColumnName("docuId");

                entity.Property(e => e.CodoDataEntrega)
                    .HasColumnType("date")
                    .HasColumnName("codoDataEntrega");

                entity.Property(e => e.CodoObs)
                    .IsUnicode(false)
                    .HasColumnName("codoObs");

                entity.Property(e => e.CodoStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("codoStatus")
                    .IsFixedLength();

                entity.HasOne(d => d.Cons)
                    .WithMany(p => p.TabConsultaDocumentos)
                    .HasForeignKey(d => d.ConsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabConsultaDocumento_tabConsulta");

                entity.HasOne(d => d.Docu)
                    .WithMany(p => p.TabConsultaDocumentos)
                    .HasForeignKey(d => d.DocuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabConsultaDocumento_tabDocumento");
            });

            modelBuilder.Entity<TabConsultaDocumentoPergunta>(entity =>
            {
                entity.HasKey(e => e.Idtabela);

                entity.ToTable("tabConsultaDocumentoPerguntas");

                entity.Property(e => e.Idtabela).HasColumnName("idtabela");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.DocuId).HasColumnName("docuId");

                entity.Property(e => e.Dspergunta)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dspergunta");

                entity.Property(e => e.Dsresposta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsresposta");
            });

            modelBuilder.Entity<TabConsultaImpressao>(entity =>
            {
                entity.HasKey(e => new { e.ConsId, e.UnidId });

                entity.ToTable("tabConsultaImpressao");

                entity.Property(e => e.ConsId).HasColumnName("ConsID");

                entity.Property(e => e.UnidId).HasColumnName("UnidID");
            });

            modelBuilder.Entity<TabConsultaResposta>(entity =>
            {
                entity.HasKey(e => e.ConsIdResposta);

                entity.ToTable("tabConsultaRespostas");

                entity.HasIndex(e => e.ConsId, "IX_tabConsultaRespostas_consId");

                entity.Property(e => e.ConsIdResposta).HasColumnName("consIdResposta");

                entity.Property(e => e.ConsDataResposta)
                    .HasColumnType("datetime")
                    .HasColumnName("consDataResposta")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ConsDataSolicitacao)
                    .HasColumnType("date")
                    .HasColumnName("consDataSolicitacao");

                entity.Property(e => e.ConsId).HasColumnName("consId");

                entity.Property(e => e.ConsInscricao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("consInscricao");

                entity.Property(e => e.ConsLocalizador)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("consLocalizador");

                entity.Property(e => e.ConsMotivo)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("consMotivo");

                entity.Property(e => e.DsArquivoXmlorigem)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("dsArquivoXMLOrigem");

                entity.Property(e => e.DscodigoretornoWs)
                    .IsUnicode(false)
                    .HasColumnName("dscodigoretornoWS");

                entity.Property(e => e.FlConsultaDeferida)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flConsultaDeferida")
                    .IsFixedLength();

                entity.Property(e => e.Fldomiciliotributario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("fldomiciliotributario")
                    .IsFixedLength();

                entity.Property(e => e.Flenviarnovamente)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flenviarnovamente")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TabConsultaTipo>(entity =>
            {
                entity.HasKey(e => e.TipoId);

                entity.ToTable("tabConsultaTipo");

                entity.Property(e => e.TipoId)
                    .ValueGeneratedNever()
                    .HasColumnName("tipoId");

                entity.Property(e => e.TextoCompRodape)
                    .HasColumnType("text")
                    .HasColumnName("textoCompRodape");

                entity.Property(e => e.TextoCompTitulo)
                    .HasColumnType("text")
                    .HasColumnName("textoCompTitulo");

                entity.Property(e => e.TipoRodape)
                    .HasColumnType("text")
                    .HasColumnName("tipoRodape");

                entity.Property(e => e.TipoTexto1)
                    .HasColumnType("text")
                    .HasColumnName("tipoTexto1");

                entity.Property(e => e.TipoTexto2)
                    .HasColumnType("text")
                    .HasColumnName("tipoTexto2");

                entity.Property(e => e.TipoTitulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipoTitulo");
            });

            modelBuilder.Entity<TabConsultaUnidadeDividum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabConsultaUnidadeDivida");

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.Property(e => e.IdDivida).HasColumnName("idDivida");

                entity.Property(e => e.IdUnidade).HasColumnName("idUnidade");
            });

            modelBuilder.Entity<TabConsultum>(entity =>
            {
                entity.HasKey(e => e.ConsId);

                entity.ToTable("tabConsulta");

                entity.HasIndex(e => new { e.ConsInscricao, e.ConsData }, "IX_tabConsulta")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ConsLocalizador, "IX_tabConsulta_1");

                entity.HasIndex(e => e.IdDivida, "IX_tabConsulta_2");

                entity.HasIndex(e => new { e.ConsData, e.FlIntegradoDuc }, "IX_tabConsulta_consData_flIntegradoDUC_inc_consid_Inscr_nrLoca_domtrib");

                entity.HasIndex(e => e.ConsLocalizador, "IX_tabConsulta_consLocalizador");

                entity.HasIndex(e => new { e.ConsStatus, e.ConsLocalizador }, "IX_tabConsulta_consStatus_inc_consId_consInscr_consData_flDomTrib_flrespXMLnov");

                entity.HasIndex(e => new { e.ConsStatus, e.ConsLocalizador }, "IX_tabConsulta_consStatus_inc_consId_consInscr_consData_flrespXMLnov");

                entity.Property(e => e.ConsId)
                    .ValueGeneratedNever()
                    .HasColumnName("consId");

                entity.Property(e => e.ConsCodigoBarra)
                    .HasColumnType("image")
                    .HasColumnName("consCodigoBarra");

                entity.Property(e => e.ConsData)
                    .HasColumnType("date")
                    .HasColumnName("consData");

                entity.Property(e => e.ConsIdNovo).HasColumnName("consIdNovo");

                entity.Property(e => e.ConsImpressa).HasColumnName("consImpressa");

                entity.Property(e => e.ConsInscricao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("consInscricao");

                entity.Property(e => e.ConsLocalizador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("consLocalizador");

                entity.Property(e => e.ConsObservacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("consObservacao");

                entity.Property(e => e.ConsStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("consStatus")
                    .IsFixedLength();

                entity.Property(e => e.DsArquivoXmlorigem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsArquivoXMLOrigem");

                entity.Property(e => e.DsZoneamento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsZoneamento");

                entity.Property(e => e.DtDeferimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtDeferimento");

                entity.Property(e => e.FlDomicilioTributario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flDomicilioTributario")
                    .IsFixedLength();

                entity.Property(e => e.FlIndeferidoSomenteJunta)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flIndeferidoSomenteJunta")
                    .IsFixedLength();

                entity.Property(e => e.FlIntegradoDuc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flIntegradoDUC")
                    .IsFixedLength();

                entity.Property(e => e.FlrespostaXmlnovamente)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flrespostaXMLnovamente")
                    .IsFixedLength();

                entity.Property(e => e.IdDivida).HasColumnName("idDivida");

                entity.Property(e => e.IdZoneamento).HasColumnName("idZoneamento");

                entity.Property(e => e.TipoId).HasColumnName("tipoId");

                entity.Property(e => e.VlLatitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vlLatitude");

                entity.Property(e => e.VlLongitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vlLongitude");
            });

            modelBuilder.Entity<TabContribuintePermissao>(entity =>
            {
                entity.HasKey(e => e.ContPermId);

                entity.ToTable("tabContribuintePermissao");

                entity.HasIndex(e => new { e.ProcAno, e.ProcNumero }, "IX_tabContribuintePermissao");

                entity.HasIndex(e => e.ConsInscricao, "IX_tabContribuintePermissao_1");

                entity.Property(e => e.ContPermId)
                    .ValueGeneratedNever()
                    .HasColumnName("contPermId");

                entity.Property(e => e.ConsInscricao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("consInscricao");

                entity.Property(e => e.ConsPermissao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("consPermissao");

                entity.Property(e => e.DataHora)
                    .HasColumnType("datetime")
                    .HasColumnName("data_hora");

                entity.Property(e => e.IdTipoContribuinte).HasColumnName("idTipoContribuinte");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("motivo");

                entity.Property(e => e.ProcAno).HasColumnName("procAno");

                entity.Property(e => e.ProcNumero).HasColumnName("procNumero");

                entity.Property(e => e.SubCid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("subCId")
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdTipoContribuinteNavigation)
                    .WithMany(p => p.TabContribuintePermissaos)
                    .HasForeignKey(d => d.IdTipoContribuinte)
                    .HasConstraintName("FK_tabContribuintePermissao_tabTipoContribuinte");
            });

            modelBuilder.Entity<TabDesdobramento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabDesdobramento");

                entity.Property(e => e.DsDesdobramento)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsDesdobramento");

                entity.Property(e => e.IdDesdobramento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idDesdobramento");

                entity.Property(e => e.SubCid)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("subCid");
            });

            modelBuilder.Entity<TabDocumento>(entity =>
            {
                entity.HasKey(e => e.DocuId);

                entity.ToTable("tabDocumento");

                entity.HasIndex(e => e.DocuNome, "IX_tabDocumento_docuNome");

                entity.Property(e => e.DocuId)
                    .ValueGeneratedNever()
                    .HasColumnName("docuId");

                entity.Property(e => e.DocuNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("docuNome");

                entity.Property(e => e.DocuObrigatorio)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("docuObrigatorio")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TabDocumentoCnae>(entity =>
            {
                entity.HasKey(e => new { e.SubCid, e.DocuId });

                entity.ToTable("tabDocumentoCNAE");

                entity.Property(e => e.SubCid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("subCId")
                    .IsFixedLength();

                entity.Property(e => e.DocuId).HasColumnName("docuId");

                entity.Property(e => e.DosuObs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dosuObs");

                entity.Property(e => e.DosuTipo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dosuTipo");

                entity.HasOne(d => d.Docu)
                    .WithMany(p => p.TabDocumentoCnaes)
                    .HasForeignKey(d => d.DocuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabDocumentoCNAE_tabDocumento");
            });

            modelBuilder.Entity<TabDocumentoCnaetipoContribuinte>(entity =>
            {
                entity.HasKey(e => e.IdDocCnaeTipoContrib);

                entity.ToTable("tabDocumentoCNAETipoContribuinte");

                entity.Property(e => e.IdDocCnaeTipoContrib)
                    .ValueGeneratedNever()
                    .HasColumnName("idDocCnaeTipoContrib");

                entity.Property(e => e.DocuId).HasColumnName("docuId");

                entity.Property(e => e.IdTipoContribuinte).HasColumnName("idTipoContribuinte");

                entity.Property(e => e.SubCid)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("subCId")
                    .IsFixedLength();

                entity.HasOne(d => d.Docu)
                    .WithMany(p => p.TabDocumentoCnaetipoContribuintes)
                    .HasForeignKey(d => d.DocuId)
                    .HasConstraintName("FK_tabDocumentoCNAETipoContribuinte_tabDocumento");
            });

            modelBuilder.Entity<TabFuncionario>(entity =>
            {
                entity.HasKey(e => e.FuncId);

                entity.ToTable("tabFuncionario");

                entity.HasIndex(e => e.FuncNome, "IX_tabFuncionario_funcNome");

                entity.HasIndex(e => e.FuncUsuario, "IX_tabFuncionario_funcUsuario");

                entity.HasIndex(e => e.UnidId, "IX_tabFuncionario_unidId");

                entity.Property(e => e.FuncId)
                    .ValueGeneratedNever()
                    .HasColumnName("funcId");

                entity.Property(e => e.FuncEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funcEmail");

                entity.Property(e => e.FuncMatricula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funcMatricula");

                entity.Property(e => e.FuncNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("funcNome");

                entity.Property(e => e.FuncRecebeEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("funcRecebeEmail")
                    .IsFixedLength();

                entity.Property(e => e.FuncResponsavel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("funcResponsavel")
                    .IsFixedLength();

                entity.Property(e => e.FuncUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("funcUsuario");

                entity.Property(e => e.FuncUsuarioSituacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("funcUsuarioSituacao")
                    .IsFixedLength()
                    .HasComment("(A = Ativo, B = Bloqueado)");

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.Unid)
                    .WithMany(p => p.TabFuncionarios)
                    .HasForeignKey(d => d.UnidId)
                    .HasConstraintName("FK_tabFuncionario_tabUnidade");
            });

            modelBuilder.Entity<TabTipoContribuinte>(entity =>
            {
                entity.HasKey(e => e.IdTipoContribuinte);

                entity.ToTable("tabTipoContribuinte");

                entity.Property(e => e.IdTipoContribuinte)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoContribuinte");

                entity.Property(e => e.FlFormalizarTipoContribuinte)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flFormalizarTipoContribuinte")
                    .HasDefaultValueSql("('Não')")
                    .IsFixedLength();

                entity.Property(e => e.NmTipoContribuinte)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoContribuinte");

                entity.HasMany(d => d.Docus)
                    .WithMany(p => p.IdTipoContribuintes)
                    .UsingEntity<Dictionary<string, object>>(
                        "TabTipoContribuinteDocumento",
                        l => l.HasOne<TabDocumento>().WithMany().HasForeignKey("DocuId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabTipoContribuinteDocumento_tabDocumento"),
                        r => r.HasOne<TabTipoContribuinte>().WithMany().HasForeignKey("IdTipoContribuinte").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabTipoContribuinteDocumento_tabTipoContribuinte"),
                        j =>
                        {
                            j.HasKey("IdTipoContribuinte", "DocuId");

                            j.ToTable("tabTipoContribuinteDocumento");

                            j.IndexerProperty<short>("IdTipoContribuinte").HasColumnName("idTipoContribuinte");

                            j.IndexerProperty<int>("DocuId").HasColumnName("docuId");
                        });
            });

            modelBuilder.Entity<TabTipoInstalacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabTipoInstalacao");

                entity.Property(e => e.DsLabelCampoAdicional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLabelCampoAdicional");

                entity.Property(e => e.FlCampoAdicional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flCampoAdicional")
                    .IsFixedLength();

                entity.Property(e => e.FlTipoCampo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("flTipoCampo")
                    .IsFixedLength();

                entity.Property(e => e.IdTipoInstalacao).HasColumnName("idTipoInstalacao");

                entity.Property(e => e.NmTipoInstalacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoInstalacao");

                entity.Property(e => e.VlCampo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vlCampo");
            });

            modelBuilder.Entity<TabTipoInstalacaoTipoContribuinte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabTipoInstalacaoTipoContribuinte");

                entity.Property(e => e.IdTipoContribuinte).HasColumnName("idTipoContribuinte");

                entity.Property(e => e.IdTipoInstalacao).HasColumnName("idTipoInstalacao");
            });

            modelBuilder.Entity<TabUnidade>(entity =>
            {
                entity.HasKey(e => e.UnidId);

                entity.ToTable("tabUnidade");

                entity.Property(e => e.UnidId)
                    .ValueGeneratedNever()
                    .HasColumnName("unidId");

                entity.Property(e => e.UnidContato)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidContato");

                entity.Property(e => e.UnidEndereco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unidEndereco");

                entity.Property(e => e.UnidNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidNome");

                entity.Property(e => e.UnidSigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unidSigla");

                entity.Property(e => e.UninrTelefone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("uninrTelefone");
            });

            modelBuilder.Entity<TribParamClassificacaoReceitum>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassReceitaVlrCorrecao)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrDesconto)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrDevolucao)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrJuros)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrMulta)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrMultaDa)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassReceitaVlrMultaDA");

                entity.Property(e => e.ClassReceitaVlrOutrasDeducoes)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrPrincipal)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClassReceitaVlrRenuncia)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDivId).HasColumnName("TipoDivID");

                entity.Property(e => e.TipoTribId).HasColumnName("TipoTribID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
