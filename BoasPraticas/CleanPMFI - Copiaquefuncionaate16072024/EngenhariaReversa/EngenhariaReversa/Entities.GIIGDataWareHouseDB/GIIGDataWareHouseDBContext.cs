using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class GIIGDataWareHouseDBContext : DbContext
    {
        public GIIGDataWareHouseDBContext()
        {
        }

        public GIIGDataWareHouseDBContext(DbContextOptions<GIIGDataWareHouseDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlmoxDfornecedor> AlmoxDfornecedors { get; set; } = null!;
        public virtual DbSet<AlmoxDitem> AlmoxDitems { get; set; } = null!;
        public virtual DbSet<AlmoxDservidor> AlmoxDservidors { get; set; } = null!;
        public virtual DbSet<AlmoxDtempo> AlmoxDtempos { get; set; } = null!;
        public virtual DbSet<AlmoxDunidade> AlmoxDunidades { get; set; } = null!;
        public virtual DbSet<AlmoxFmovimentaco> AlmoxFmovimentacoes { get; set; } = null!;
        public virtual DbSet<AlmoxFsaldo> AlmoxFsaldos { get; set; } = null!;
        public virtual DbSet<ContabilResumoDgrupo> ContabilResumoDgrupos { get; set; } = null!;
        public virtual DbSet<ContabilResumoDtipoValore> ContabilResumoDtipoValores { get; set; } = null!;
        public virtual DbSet<ContabilResumoFvalore> ContabilResumoFvalores { get; set; } = null!;
        public virtual DbSet<ContabilidadeDcategoriaReceitum> ContabilidadeDcategoriaReceita { get; set; } = null!;
        public virtual DbSet<ContabilidadeDdesdobramento> ContabilidadeDdesdobramentos { get; set; } = null!;
        public virtual DbSet<ContabilidadeDgrupoReceitum> ContabilidadeDgrupoReceita { get; set; } = null!;
        public virtual DbSet<ContabilidadeDorigemReceitum> ContabilidadeDorigemReceita { get; set; } = null!;
        public virtual DbSet<ContabilidadeDreceitum> ContabilidadeDreceita { get; set; } = null!;
        public virtual DbSet<ContabilidadeDtempo> ContabilidadeDtempos { get; set; } = null!;
        public virtual DbSet<ContabilidadeDtipoOperacao> ContabilidadeDtipoOperacaos { get; set; } = null!;
        public virtual DbSet<ContabilidadeFvalore> ContabilidadeFvalores { get; set; } = null!;
        public virtual DbSet<DEmpresa> DEmpresas { get; set; } = null!;
        public virtual DbSet<DServico> DServicos { get; set; } = null!;
        public virtual DbSet<DUltimaAtualizacao> DUltimaAtualizacaos { get; set; } = null!;
        public virtual DbSet<FArrecadadoIssgrupoServico> FArrecadadoIssgrupoServicos { get; set; } = null!;
        public virtual DbSet<FArrecadadoIssservico> FArrecadadoIssservicos { get; set; } = null!;
        public virtual DbSet<FMetaIss> FMetaIsses { get; set; } = null!;
        public virtual DbSet<FinanceiroDcontaBanco> FinanceiroDcontaBancos { get; set; } = null!;
        public virtual DbSet<FinanceiroDfonte> FinanceiroDfontes { get; set; } = null!;
        public virtual DbSet<FinanceiroDorgao> FinanceiroDorgaos { get; set; } = null!;
        public virtual DbSet<FinanceiroDreceitum> FinanceiroDreceita { get; set; } = null!;
        public virtual DbSet<FinanceiroDtempo> FinanceiroDtempos { get; set; } = null!;
        public virtual DbSet<FinanceiroDunidade> FinanceiroDunidades { get; set; } = null!;
        public virtual DbSet<FinanceiroFvaloresLiquidacao> FinanceiroFvaloresLiquidacaos { get; set; } = null!;
        public virtual DbSet<FinanceiroFvaloresPagamento> FinanceiroFvaloresPagamentos { get; set; } = null!;
        public virtual DbSet<FinanceiroFvaloresReceitum> FinanceiroFvaloresReceita { get; set; } = null!;
        public virtual DbSet<LicitacaoDmodalidade> LicitacaoDmodalidades { get; set; } = null!;
        public virtual DbSet<LicitacaoDorgao> LicitacaoDorgaos { get; set; } = null!;
        public virtual DbSet<LicitacaoDtempo> LicitacaoDtempos { get; set; } = null!;
        public virtual DbSet<LicitacaoFvalore> LicitacaoFvalores { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDcredor> OrcamentoDespesaDcredors { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDfonte> OrcamentoDespesaDfontes { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDfuncao> OrcamentoDespesaDfuncaos { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDnaturezaDespesa> OrcamentoDespesaDnaturezaDespesas { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDorgao> OrcamentoDespesaDorgaos { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDprograma> OrcamentoDespesaDprogramas { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDprojetoAtividade> OrcamentoDespesaDprojetoAtividades { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDsubFuncao> OrcamentoDespesaDsubFuncaos { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDtempo> OrcamentoDespesaDtempos { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaDunidade> OrcamentoDespesaDunidades { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaFvalore> OrcamentoDespesaFvalores { get; set; } = null!;
        public virtual DbSet<OrcamentoDespesaFvaloresCredore> OrcamentoDespesaFvaloresCredores { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaDfonte> OrcamentoReceitaDfontes { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaDorgao> OrcamentoReceitaDorgaos { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaDreceitum> OrcamentoReceitaDreceita { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaDtempo> OrcamentoReceitaDtempos { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaDunidade> OrcamentoReceitaDunidades { get; set; } = null!;
        public virtual DbSet<OrcamentoReceitaFvalore> OrcamentoReceitaFvalores { get; set; } = null!;
        public virtual DbSet<PatrimonioDbem> PatrimonioDbems { get; set; } = null!;
        public virtual DbSet<PatrimonioDtempo> PatrimonioDtempos { get; set; } = null!;
        public virtual DbSet<PatrimonioDunidade> PatrimonioDunidades { get; set; } = null!;
        public virtual DbSet<PatrimonioFvaloresBaixa> PatrimonioFvaloresBaixas { get; set; } = null!;
        public virtual DbSet<PatrimonioFvaloresBen> PatrimonioFvaloresBens { get; set; } = null!;
        public virtual DbSet<PatrimonioFvaloresDepreciacao> PatrimonioFvaloresDepreciacaos { get; set; } = null!;
        public virtual DbSet<TabLogAtualizacao> TabLogAtualizacaos { get; set; } = null!;
        public virtual DbSet<TabMe> TabMes { get; set; } = null!;
        public virtual DbSet<TabPermisso> TabPermissoes { get; set; } = null!;
        public virtual DbSet<TabPermissoesMov> TabPermissoesMovs { get; set; } = null!;
        public virtual DbSet<TabRelatorio> TabRelatorios { get; set; } = null!;
        public virtual DbSet<TabRelatoriosGrupo> TabRelatoriosGrupos { get; set; } = null!;
        public virtual DbSet<TabRelatoriosVersao> TabRelatoriosVersaos { get; set; } = null!;
        public virtual DbSet<TribBancosDbanco> TribBancosDbancos { get; set; } = null!;
        public virtual DbSet<TribBancosDempresa> TribBancosDempresas { get; set; } = null!;
        public virtual DbSet<TribBancosFdividum> TribBancosFdivida { get; set; } = null!;
        public virtual DbSet<TribCadastrodCategorium> TribCadastrodCategoria { get; set; } = null!;
        public virtual DbSet<TribCadastrodGrupoTributo> TribCadastrodGrupoTributos { get; set; } = null!;
        public virtual DbSet<TribCadastrodLoteamento> TribCadastrodLoteamentos { get; set; } = null!;
        public virtual DbSet<TribCadastrodPacabamentoExternoE> TribCadastrodPacabamentoExternoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPacabamentoInternoE> TribCadastrodPacabamentoInternoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPagrupamentoE> TribCadastrodPagrupamentoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPcalcadaT> TribCadastrodPcalcadaTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPcoberturaE> TribCadastrodPcoberturaEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPcondicaoT> TribCadastrodPcondicaoTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPcondominioResidE> TribCadastrodPcondominioResidEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPesquadriasE> TribCadastrodPesquadriasEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPestadoConservacaoE> TribCadastrodPestadoConservacaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPestruturaE> TribCadastrodPestruturaEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPforroE> TribCadastrodPforroEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPfundoValeT> TribCadastrodPfundoValeTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPimovelRuralT> TribCadastrodPimovelRuralTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPincidenciaEdificacaoE> TribCadastrodPincidenciaEdificacaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPincidenciaTerrenoT> TribCadastrodPincidenciaTerrenoTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPinstalacaoEletricaE> TribCadastrodPinstalacaoEletricaEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPlimiteTestadaT> TribCadastrodPlimiteTestadaTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPlocalizacaoT> TribCadastrodPlocalizacaoTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPocupacaoEdificacaoE> TribCadastrodPocupacaoEdificacaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPocupacaoTerrenoT> TribCadastrodPocupacaoTerrenoTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPparedeE> TribCadastrodPparedeEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPpatrimonioT> TribCadastrodPpatrimonioTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPpedologiaT> TribCadastrodPpedologiaTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPpisoE> TribCadastrodPpisoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPposicaoE> TribCadastrodPposicaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPsituacaoE> TribCadastrodPsituacaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPtipoConstrucaoE> TribCadastrodPtipoConstrucaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPtopografiaT> TribCadastrodPtopografiaTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPusoE> TribCadastrodPusoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPutilizacaoE> TribCadastrodPutilizacaoEs { get; set; } = null!;
        public virtual DbSet<TribCadastrodPvegetacaoT> TribCadastrodPvegetacaoTs { get; set; } = null!;
        public virtual DbSet<TribCadastrodRegiao> TribCadastrodRegiaos { get; set; } = null!;
        public virtual DbSet<TribCadastrodRegiaoLoteamento> TribCadastrodRegiaoLoteamentos { get; set; } = null!;
        public virtual DbSet<TribCadastrodTipoBaixa> TribCadastrodTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribCadastrodTipoDividum> TribCadastrodTipoDivida { get; set; } = null!;
        public virtual DbSet<TribCadastrodTipoTributo> TribCadastrodTipoTributos { get; set; } = null!;
        public virtual DbSet<TribCadastrofDivida> TribCadastrofDividas { get; set; } = null!;
        public virtual DbSet<TribCadastrofInscrico> TribCadastrofInscricoes { get; set; } = null!;
        public virtual DbSet<TribEmpresasdAtividade> TribEmpresasdAtividades { get; set; } = null!;
        public virtual DbSet<TribEmpresasdBairro> TribEmpresasdBairros { get; set; } = null!;
        public virtual DbSet<TribEmpresasdCaracteristica> TribEmpresasdCaracteristicas { get; set; } = null!;
        public virtual DbSet<TribEmpresasdCidade> TribEmpresasdCidades { get; set; } = null!;
        public virtual DbSet<TribEmpresasdConstituicao> TribEmpresasdConstituicaos { get; set; } = null!;
        public virtual DbSet<TribEmpresasdLogradouro> TribEmpresasdLogradouros { get; set; } = null!;
        public virtual DbSet<TribEmpresasdRegime> TribEmpresasdRegimes { get; set; } = null!;
        public virtual DbSet<TribEmpresasdServico> TribEmpresasdServicos { get; set; } = null!;
        public virtual DbSet<TribEmpresasdSituacao> TribEmpresasdSituacaos { get; set; } = null!;
        public virtual DbSet<TribEmpresasdTipoBaixa> TribEmpresasdTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribEmpresasdTipoEmpresa> TribEmpresasdTipoEmpresas { get; set; } = null!;
        public virtual DbSet<TribEmpresasdTipoTributo> TribEmpresasdTipoTributos { get; set; } = null!;
        public virtual DbSet<TribEmpresasfDivida> TribEmpresasfDividas { get; set; } = null!;
        public virtual DbSet<TribEmpresasfEmpresa> TribEmpresasfEmpresas { get; set; } = null!;
        public virtual DbSet<TribEmpresasfEmpresasAtividade> TribEmpresasfEmpresasAtividades { get; set; } = null!;
        public virtual DbSet<TribEmpresasfEmpresasServico> TribEmpresasfEmpresasServicos { get; set; } = null!;
        public virtual DbSet<TribIptudAno> TribIptudAnos { get; set; } = null!;
        public virtual DbSet<TribIptudTipoBaixa> TribIptudTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribIptudTipoTributo> TribIptudTipoTributos { get; set; } = null!;
        public virtual DbSet<TribIptufArrecadadoAno> TribIptufArrecadadoAnos { get; set; } = null!;
        public virtual DbSet<TribIptufResumoAno> TribIptufResumoAnos { get; set; } = null!;
        public virtual DbSet<TribIptufResumoTipoBaixa> TribIptufResumoTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribIptufResumoTipoTributo> TribIptufResumoTipoTributos { get; set; } = null!;
        public virtual DbSet<TribIssqndCnae> TribIssqndCnaes { get; set; } = null!;
        public virtual DbSet<TribIssqndEmpresa> TribIssqndEmpresas { get; set; } = null!;
        public virtual DbSet<TribIssqndRegime> TribIssqndRegimes { get; set; } = null!;
        public virtual DbSet<TribIssqndServico> TribIssqndServicos { get; set; } = null!;
        public virtual DbSet<TribIssqnfArrecadado> TribIssqnfArrecadados { get; set; } = null!;
        public virtual DbSet<TribNfsehomologadadEmpresa> TribNfsehomologadadEmpresas { get; set; } = null!;
        public virtual DbSet<TribNfsehomologadadRegime> TribNfsehomologadadRegimes { get; set; } = null!;
        public virtual DbSet<TribNfsehomologadafNota> TribNfsehomologadafNotas { get; set; } = null!;
        public virtual DbSet<TribRefisdLeisDesconto> TribRefisdLeisDescontos { get; set; } = null!;
        public virtual DbSet<TribRefisfArrecadado> TribRefisfArrecadados { get; set; } = null!;
        public virtual DbSet<TribRefisfAtraso> TribRefisfAtrasos { get; set; } = null!;
        public virtual DbSet<TribRefisfQtdeLeisDesconto> TribRefisfQtdeLeisDescontos { get; set; } = null!;
        public virtual DbSet<TribTributosdGrupoTipoBaixa> TribTributosdGrupoTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribTributosdGrupoTributo> TribTributosdGrupoTributos { get; set; } = null!;
        public virtual DbSet<TribTributosdTipoBaixa> TribTributosdTipoBaixas { get; set; } = null!;
        public virtual DbSet<TribTributosdTipoDividum> TribTributosdTipoDivida { get; set; } = null!;
        public virtual DbSet<TribTributosdTipoTributo> TribTributosdTipoTributos { get; set; } = null!;
        public virtual DbSet<TribTributosfResumoTributo> TribTributosfResumoTributos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=GIIGDataWareHouseDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=Gilberto.gc;Password=Couto2408@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<AlmoxDfornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.ToTable("AlmoxDFornecedor");

                entity.Property(e => e.IdFornecedor).ValueGeneratedNever();

                entity.Property(e => e.NmForcededor)
                    .IsUnicode(false)
                    .HasColumnName("nmForcededor");

                entity.Property(e => e.NrCpfcnpj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrCPFCNPJ");
            });

            modelBuilder.Entity<AlmoxDitem>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("AlmoxDItem");

                entity.Property(e => e.IdItem).ValueGeneratedNever();

                entity.Property(e => e.DsItem)
                    .IsUnicode(false)
                    .HasColumnName("dsItem");
            });

            modelBuilder.Entity<AlmoxDservidor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlmoxDServidor");

                entity.Property(e => e.NmServidor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmServidor");
            });

            modelBuilder.Entity<AlmoxDtempo>(entity =>
            {
                entity.HasKey(e => e.IdTempo);

                entity.ToTable("AlmoxDTempo");

                entity.Property(e => e.IdTempo).ValueGeneratedNever();

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<AlmoxDunidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidade);

                entity.ToTable("AlmoxDUnidade");

                entity.Property(e => e.IdUnidade).ValueGeneratedNever();

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");
            });

            modelBuilder.Entity<AlmoxFmovimentaco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlmoxFMovimentacoes");

                entity.Property(e => e.NrQtdeEntrada)
                    .HasColumnType("money")
                    .HasColumnName("nrQtdeEntrada");

                entity.Property(e => e.NrQtdeSaida)
                    .HasColumnType("money")
                    .HasColumnName("nrQtdeSaida");

                entity.Property(e => e.TpOrigem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tpOrigem")
                    .IsFixedLength();
            });

            modelBuilder.Entity<AlmoxFsaldo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AlmoxFSaldo");

                entity.Property(e => e.NrSaldo)
                    .HasColumnType("money")
                    .HasColumnName("nrSaldo");
            });

            modelBuilder.Entity<ContabilResumoDgrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilResumoDGrupo");

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.NmGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmGrupo");
            });

            modelBuilder.Entity<ContabilResumoDtipoValore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilResumoDTipoValores");

                entity.Property(e => e.IdTipoValor).HasColumnName("idTipoValor");

                entity.Property(e => e.NmTipoValor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoValor");
            });

            modelBuilder.Entity<ContabilResumoFvalore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilResumoFValores");

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.IdTipoValor).HasColumnName("idTipoValor");

                entity.Property(e => e.VlArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadado");
            });

            modelBuilder.Entity<ContabilidadeDcategoriaReceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDCategoriaReceita");

                entity.Property(e => e.CdCategoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cdCategoria")
                    .IsFixedLength();

                entity.Property(e => e.NmCategoria)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmCategoria");
            });

            modelBuilder.Entity<ContabilidadeDdesdobramento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDDesdobramento");

                entity.Property(e => e.CdDesdobramento)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("cdDesdobramento");

                entity.Property(e => e.DsDesdobramento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsDesdobramento");
            });

            modelBuilder.Entity<ContabilidadeDgrupoReceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDGrupoReceita");

                entity.Property(e => e.CdGrupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdGrupo")
                    .IsFixedLength();

                entity.Property(e => e.NmGrupo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmGrupo");
            });

            modelBuilder.Entity<ContabilidadeDorigemReceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDOrigemReceita");

                entity.Property(e => e.CdOrigem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdOrigem")
                    .IsFixedLength();

                entity.Property(e => e.NmOrigem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrigem");
            });

            modelBuilder.Entity<ContabilidadeDreceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDReceita");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");
            });

            modelBuilder.Entity<ContabilidadeDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<ContabilidadeDtipoOperacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeDTipoOperacao");

                entity.Property(e => e.DsTipoOperacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoOperacao");
            });

            modelBuilder.Entity<ContabilidadeFvalore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContabilidadeFValores");

                entity.Property(e => e.CdCategoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cdCategoria")
                    .IsFixedLength();

                entity.Property(e => e.CdDesdobramento)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("cdDesdobramento");

                entity.Property(e => e.CdGrupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdGrupo")
                    .IsFixedLength();

                entity.Property(e => e.CdOrigem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdOrigem")
                    .IsFixedLength();

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.VlArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadado");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");

                entity.Property(e => e.VlReestimativa)
                    .HasColumnType("money")
                    .HasColumnName("vlReestimativa");
            });

            modelBuilder.Entity<DEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dEmpresas");

                entity.Property(e => e.DsCme)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsCME");

                entity.Property(e => e.DsCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dsCPFCNPJ");

                entity.Property(e => e.DsNomeFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNomeFantasia");

                entity.Property(e => e.IdEmpresa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idEmpresa");
            });

            modelBuilder.Entity<DServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dServicos");

                entity.Property(e => e.IdServico)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idServico");

                entity.Property(e => e.NmServico)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nmServico");

                entity.Property(e => e.NrServico)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrServico");
            });

            modelBuilder.Entity<DUltimaAtualizacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dUltimaAtualizacao");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAtualizacao");
            });

            modelBuilder.Entity<FArrecadadoIssgrupoServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fArrecadadoISSGrupoServico");

                entity.Property(e => e.DtBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtBaixa");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdServico).HasColumnName("idServico");

                entity.Property(e => e.NrQtdeNotas).HasColumnName("nrQtdeNotas");

                entity.Property(e => e.VlArrecadadoExercicio)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoExercicio");

                entity.Property(e => e.VlArrecadadoForaExercicio)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoForaExercicio");

                entity.Property(e => e.VlArrecadadoTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoTotal");
            });

            modelBuilder.Entity<FArrecadadoIssservico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fArrecadadoISSServico");

                entity.Property(e => e.DtBaixa)
                    .HasColumnType("datetime")
                    .HasColumnName("dtBaixa");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdServico).HasColumnName("idServico");

                entity.Property(e => e.NrQtdeNotas).HasColumnName("nrQtdeNotas");

                entity.Property(e => e.VlArrecadadoExercicio)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoExercicio");

                entity.Property(e => e.VlArrecadadoForaExercicio)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoForaExercicio");

                entity.Property(e => e.VlArrecadadoTotal)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadadoTotal");
            });

            modelBuilder.Entity<FMetaIss>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fMetaISS");

                entity.Property(e => e.NrAno)
                    .HasColumnType("datetime")
                    .HasColumnName("nrAno");

                entity.Property(e => e.VlMeta)
                    .HasColumnType("money")
                    .HasColumnName("vlMeta");
            });

            modelBuilder.Entity<FinanceiroDcontaBanco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDContaBanco");

                entity.Property(e => e.DsContaBanco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsContaBanco");

                entity.Property(e => e.Idconta)
                    .HasMaxLength(10)
                    .HasColumnName("IDConta")
                    .IsFixedLength();

                entity.Property(e => e.NrContaBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrContaBanco");
            });

            modelBuilder.Entity<FinanceiroDfonte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDFonte");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte")
                    .IsFixedLength();

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");
            });

            modelBuilder.Entity<FinanceiroDorgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDOrgao");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.DsSigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSigla")
                    .IsFixedLength();

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");
            });

            modelBuilder.Entity<FinanceiroDreceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDReceita");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");
            });

            modelBuilder.Entity<FinanceiroDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<FinanceiroDunidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroDUnidade");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.DsSigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSigla")
                    .IsFixedLength();

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");
            });

            modelBuilder.Entity<FinanceiroFvaloresLiquidacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroFValoresLiquidacao");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte")
                    .IsFixedLength();

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.VlLiquidadoPendente)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidadoPendente");
            });

            modelBuilder.Entity<FinanceiroFvaloresPagamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroFValoresPagamento");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte")
                    .IsFixedLength();

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.VlPagamento)
                    .HasColumnType("money")
                    .HasColumnName("vlPagamento");
            });

            modelBuilder.Entity<FinanceiroFvaloresReceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceiroFValoresReceita");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte")
                    .IsFixedLength();

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.VlReceita)
                    .HasColumnType("money")
                    .HasColumnName("vlReceita");
            });

            modelBuilder.Entity<LicitacaoDmodalidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LicitacaoDModalidade");

                entity.Property(e => e.DsModalidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsModalidade");
            });

            modelBuilder.Entity<LicitacaoDorgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LicitacaoDOrgao");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.DsSigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSigla")
                    .IsFixedLength();

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");
            });

            modelBuilder.Entity<LicitacaoDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LicitacaoDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<LicitacaoFvalore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LicitacaoFValores");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.DsNaturezaProcedimento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsNaturezaProcedimento");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.VlLicitado)
                    .HasColumnType("money")
                    .HasColumnName("vlLicitado");

                entity.Property(e => e.VlMaximo)
                    .HasColumnType("money")
                    .HasColumnName("vlMaximo");
            });

            modelBuilder.Entity<OrcamentoDespesaDcredor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDCredor");

                entity.Property(e => e.NmCredor)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nmCredor");

                entity.Property(e => e.NrCpfcnpj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nrCPFCNPJ");
            });

            modelBuilder.Entity<OrcamentoDespesaDfonte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDFonte");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");
            });

            modelBuilder.Entity<OrcamentoDespesaDfuncao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDFuncao");

                entity.Property(e => e.CdFuncao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdFuncao")
                    .IsFixedLength();

                entity.Property(e => e.NmFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmFuncao");
            });

            modelBuilder.Entity<OrcamentoDespesaDnaturezaDespesa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDNaturezaDespesa");

                entity.Property(e => e.CdNaturezaDespesa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdNaturezaDespesa");

                entity.Property(e => e.DsNaturezaDespesa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNaturezaDespesa");
            });

            modelBuilder.Entity<OrcamentoDespesaDorgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDOrgao");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");
            });

            modelBuilder.Entity<OrcamentoDespesaDprograma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDPrograma");

                entity.Property(e => e.CdPrograma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cdPrograma")
                    .IsFixedLength();

                entity.Property(e => e.NmPrograma)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmPrograma");
            });

            modelBuilder.Entity<OrcamentoDespesaDprojetoAtividade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDProjetoAtividade");

                entity.Property(e => e.CdProjetoAtividade)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdProjetoAtividade")
                    .IsFixedLength();

                entity.Property(e => e.NmProjetoAtividade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmProjetoAtividade");
            });

            modelBuilder.Entity<OrcamentoDespesaDsubFuncao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDSubFuncao");

                entity.Property(e => e.CdSubFuncao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdSubFuncao")
                    .IsFixedLength();

                entity.Property(e => e.NmSubFuncao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmSubFuncao");
            });

            modelBuilder.Entity<OrcamentoDespesaDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<OrcamentoDespesaDunidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaDUnidade");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");
            });

            modelBuilder.Entity<OrcamentoDespesaFvalore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaFValores");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdFuncao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cdFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdNaturezaDespesa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdNaturezaDespesa");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.CdPrograma)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cdPrograma")
                    .IsFixedLength();

                entity.Property(e => e.CdProjetoAtividade)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdProjetoAtividade")
                    .IsFixedLength();

                entity.Property(e => e.CdSubFuncao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdSubFuncao")
                    .IsFixedLength();

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.VlExecutado)
                    .HasColumnType("money")
                    .HasColumnName("vlExecutado");

                entity.Property(e => e.VlLiquidado)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidado");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("vlPago");
            });

            modelBuilder.Entity<OrcamentoDespesaFvaloresCredore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoDespesaFValoresCredores");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.VlEmpenhado)
                    .HasColumnType("money")
                    .HasColumnName("vlEmpenhado");

                entity.Property(e => e.VlLiquidado)
                    .HasColumnType("money")
                    .HasColumnName("vlLiquidado");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("vlPago");
            });

            modelBuilder.Entity<OrcamentoReceitaDfonte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaDFonte");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.DsFonte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsFonte");
            });

            modelBuilder.Entity<OrcamentoReceitaDorgao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaDOrgao");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.NmOrgao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmOrgao");
            });

            modelBuilder.Entity<OrcamentoReceitaDreceitum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaDReceita");

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.DsReceita)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsReceita");
            });

            modelBuilder.Entity<OrcamentoReceitaDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<OrcamentoReceitaDunidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaDUnidade");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");
            });

            modelBuilder.Entity<OrcamentoReceitaFvalore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrcamentoReceitaFValores");

                entity.Property(e => e.CdFonte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cdFonte");

                entity.Property(e => e.CdOrgao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cdOrgao")
                    .IsFixedLength();

                entity.Property(e => e.CdReceita)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cdReceita");

                entity.Property(e => e.CdUnidade)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cdUnidade")
                    .IsFixedLength();

                entity.Property(e => e.VlArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadado");

                entity.Property(e => e.VlOrcado)
                    .HasColumnType("money")
                    .HasColumnName("vlOrcado");
            });

            modelBuilder.Entity<PatrimonioDbem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioDBem");

                entity.Property(e => e.DsBem)
                    .IsUnicode(false)
                    .HasColumnName("dsBem");
            });

            modelBuilder.Entity<PatrimonioDtempo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioDTempo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrDia).HasColumnName("nrDia");

                entity.Property(e => e.NrMes).HasColumnName("nrMes");
            });

            modelBuilder.Entity<PatrimonioDunidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioDUnidade");

                entity.Property(e => e.NmUnidade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmUnidade");
            });

            modelBuilder.Entity<PatrimonioFvaloresBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioFValoresBaixa");

                entity.Property(e => e.VlBaixado)
                    .HasColumnType("money")
                    .HasColumnName("vlBaixado");
            });

            modelBuilder.Entity<PatrimonioFvaloresBen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioFValoresBens");

                entity.Property(e => e.VlAtualizado)
                    .HasColumnType("money")
                    .HasColumnName("vlAtualizado");

                entity.Property(e => e.VlEntrada)
                    .HasColumnType("money")
                    .HasColumnName("vlEntrada");
            });

            modelBuilder.Entity<PatrimonioFvaloresDepreciacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatrimonioFValoresDepreciacao");

                entity.Property(e => e.VlDepreciacao)
                    .HasColumnType("money")
                    .HasColumnName("vlDepreciacao");
            });

            modelBuilder.Entity<TabLogAtualizacao>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tabLogAtualizacao");

                entity.Property(e => e.IdLog).HasColumnName("idLog");

                entity.Property(e => e.DsObservacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsObservacao");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAtualizacao");

                entity.Property(e => e.FlAtualizado).HasColumnName("flAtualizado");
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

            modelBuilder.Entity<TabPermisso>(entity =>
            {
                entity.HasKey(e => new { e.IdRelatorio, e.DsLogin });

                entity.ToTable("tabPermissoes");

                entity.Property(e => e.IdRelatorio).HasColumnName("idRelatorio");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");
            });

            modelBuilder.Entity<TabPermissoesMov>(entity =>
            {
                entity.HasKey(e => e.IdPermissoesMov);

                entity.ToTable("tabPermissoesMov");

                entity.Property(e => e.IdPermissoesMov).HasColumnName("idPermissoesMov");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsTipoMov)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoMov")
                    .IsFixedLength();

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.IdRelatorio).HasColumnName("idRelatorio");

                entity.HasOne(d => d.IdRelatorioNavigation)
                    .WithMany(p => p.TabPermissoesMovs)
                    .HasForeignKey(d => d.IdRelatorio)
                    .HasConstraintName("FK_tabPermissoesMov_tabRelatorios");
            });

            modelBuilder.Entity<TabRelatorio>(entity =>
            {
                entity.HasKey(e => e.IdRelatorio);

                entity.ToTable("tabRelatorios");

                entity.Property(e => e.IdRelatorio).HasColumnName("idRelatorio");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsRelatorio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRelatorio");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlAtivo).HasColumnName("flAtivo");

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.NmRelatorio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmRelatorio");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.TabRelatorios)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_tabRelatorios_tabRelatoriosGrupo");
            });

            modelBuilder.Entity<TabRelatoriosGrupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("tabRelatoriosGrupo");

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.DsGrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsGrupo");
            });

            modelBuilder.Entity<TabRelatoriosVersao>(entity =>
            {
                entity.HasKey(e => e.IdVersao);

                entity.ToTable("tabRelatoriosVersao");

                entity.Property(e => e.IdVersao).HasColumnName("idVersao");

                entity.Property(e => e.DsEndereco)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dsEndereco");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsSenha)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dsSenha");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.IdRelatorio).HasColumnName("idRelatorio");

                entity.HasOne(d => d.IdRelatorioNavigation)
                    .WithMany(p => p.TabRelatoriosVersaos)
                    .HasForeignKey(d => d.IdRelatorio)
                    .HasConstraintName("FK_tabRelatoriosVersao_tabRelatorios");
            });

            modelBuilder.Entity<TribBancosDbanco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribBancosDBanco");

                entity.Property(e => e.IdBanco).HasColumnName("idBanco");

                entity.Property(e => e.Nmbanco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmbanco");
            });

            modelBuilder.Entity<TribBancosDempresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribBancosDEmpresa");

                entity.Property(e => e.DsEndereco)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dsEndereco");

                entity.Property(e => e.IdBanco).HasColumnName("idBanco");

                entity.Property(e => e.NmRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmRazaoSocial");

                entity.Property(e => e.NrCme).HasColumnName("nrCME");

                entity.Property(e => e.NrCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCPFCNPJ");
            });

            modelBuilder.Entity<TribBancosFdividum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribBancosFDivida");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NrCme).HasColumnName("nrCME");

                entity.Property(e => e.VlArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadado");
            });

            modelBuilder.Entity<TribCadastrodCategorium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.NmCategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmCategoria");
            });

            modelBuilder.Entity<TribCadastrodGrupoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodGrupoTributo");

                entity.Property(e => e.IdGrupoTributo).HasColumnName("idGrupoTributo");

                entity.Property(e => e.NmGrupoTributo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nmGrupoTributo");
            });

            modelBuilder.Entity<TribCadastrodLoteamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodLoteamento");

                entity.Property(e => e.IdLoteamento).HasColumnName("idLoteamento");

                entity.Property(e => e.NmLoteamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmLoteamento");
            });

            modelBuilder.Entity<TribCadastrodPacabamentoExternoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPAcabamentoExternoE");

                entity.Property(e => e.IdPacabamentoExterno).HasColumnName("idPAcabamentoExterno");

                entity.Property(e => e.NmPacabamentoExterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPAcabamentoExterno");
            });

            modelBuilder.Entity<TribCadastrodPacabamentoInternoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPAcabamentoInternoE");

                entity.Property(e => e.IdPacabamentoInterno).HasColumnName("idPAcabamentoInterno");

                entity.Property(e => e.NmPacabamentoInterno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPAcabamentoInterno");
            });

            modelBuilder.Entity<TribCadastrodPagrupamentoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPAgrupamentoE");

                entity.Property(e => e.IdPagrupamento).HasColumnName("idPAgrupamento");

                entity.Property(e => e.NmPagrupamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPAgrupamento");
            });

            modelBuilder.Entity<TribCadastrodPcalcadaT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPCalcadaT");

                entity.Property(e => e.IdPcalcada).HasColumnName("idPCalcada");

                entity.Property(e => e.NmPcalcada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPCalcada");
            });

            modelBuilder.Entity<TribCadastrodPcoberturaE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPCoberturaE");

                entity.Property(e => e.IdPcobertura).HasColumnName("idPCobertura");

                entity.Property(e => e.NmPcobertura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPCobertura");
            });

            modelBuilder.Entity<TribCadastrodPcondicaoT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPCondicaoT");

                entity.Property(e => e.IdPcondicao).HasColumnName("idPCondicao");

                entity.Property(e => e.NmPcondicao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPCondicao");
            });

            modelBuilder.Entity<TribCadastrodPcondominioResidE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPCondominioResidE");

                entity.Property(e => e.IdPcondominioResid).HasColumnName("idPCondominioResid");

                entity.Property(e => e.NmPcondominioResid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPCondominioResid");
            });

            modelBuilder.Entity<TribCadastrodPesquadriasE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPEsquadriasE");

                entity.Property(e => e.IdPesquadrias).HasColumnName("idPEsquadrias");

                entity.Property(e => e.NmPesquadrias)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPEsquadrias");
            });

            modelBuilder.Entity<TribCadastrodPestadoConservacaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPEstadoConservacaoE");

                entity.Property(e => e.IdPestadoConservacao).HasColumnName("idPEstadoConservacao");

                entity.Property(e => e.NmPestadoConservacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPEstadoConservacao");
            });

            modelBuilder.Entity<TribCadastrodPestruturaE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPEstruturaE");

                entity.Property(e => e.IdPestrutura).HasColumnName("idPEstrutura");

                entity.Property(e => e.NmPestrutura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPEstrutura");
            });

            modelBuilder.Entity<TribCadastrodPforroE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPForroE");

                entity.Property(e => e.IdPforro).HasColumnName("idPForro");

                entity.Property(e => e.NmPforro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPForro");
            });

            modelBuilder.Entity<TribCadastrodPfundoValeT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPFundoValeT");

                entity.Property(e => e.IdPfundoVale).HasColumnName("idPFundoVale");

                entity.Property(e => e.NmPfundoVale)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPFundoVale");
            });

            modelBuilder.Entity<TribCadastrodPimovelRuralT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPImovelRuralT");

                entity.Property(e => e.IdPimovelRural).HasColumnName("idPImovelRural");

                entity.Property(e => e.NmPimovelRural)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPImovelRural");
            });

            modelBuilder.Entity<TribCadastrodPincidenciaEdificacaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPIncidenciaEdificacaoE");

                entity.Property(e => e.IdPincidenciaEdificacao).HasColumnName("idPIncidenciaEdificacao");

                entity.Property(e => e.NmPincidenciaEdificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPIncidenciaEdificacao");
            });

            modelBuilder.Entity<TribCadastrodPincidenciaTerrenoT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPIncidenciaTerrenoT");

                entity.Property(e => e.IdPincidenciaTerreno).HasColumnName("idPIncidenciaTerreno");

                entity.Property(e => e.NmPincidenciaTerreno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPIncidenciaTerreno");
            });

            modelBuilder.Entity<TribCadastrodPinstalacaoEletricaE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPInstalacaoEletricaE");

                entity.Property(e => e.IdPinstalacaoEletrica).HasColumnName("idPInstalacaoEletrica");

                entity.Property(e => e.NmPinstalacaoEletrica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPInstalacaoEletrica");
            });

            modelBuilder.Entity<TribCadastrodPlimiteTestadaT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPLimiteTestadaT");

                entity.Property(e => e.IdPlimiteTestada).HasColumnName("idPLimiteTestada");

                entity.Property(e => e.NmPlimiteTestada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPLimiteTestada");
            });

            modelBuilder.Entity<TribCadastrodPlocalizacaoT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPLocalizacaoT");

                entity.Property(e => e.IdPlocalizacao).HasColumnName("idPLocalizacao");

                entity.Property(e => e.NmPlocalizacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPLocalizacao");
            });

            modelBuilder.Entity<TribCadastrodPocupacaoEdificacaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPOcupacaoEdificacaoE");

                entity.Property(e => e.IdPocupacaoEdificacao).HasColumnName("idPOcupacaoEdificacao");

                entity.Property(e => e.NmPocupacaoEdificacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPOcupacaoEdificacao");
            });

            modelBuilder.Entity<TribCadastrodPocupacaoTerrenoT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPOcupacaoTerrenoT");

                entity.Property(e => e.IdPocupacaoTerreno).HasColumnName("idPOcupacaoTerreno");

                entity.Property(e => e.NmPocupacaoTerreno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPOcupacaoTerreno");
            });

            modelBuilder.Entity<TribCadastrodPparedeE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPParedeE");

                entity.Property(e => e.IdPparede).HasColumnName("idPParede");

                entity.Property(e => e.NmPparede)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPParede");
            });

            modelBuilder.Entity<TribCadastrodPpatrimonioT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPPatrimonioT");

                entity.Property(e => e.IdPpatrimonio).HasColumnName("idPPatrimonio");

                entity.Property(e => e.NmPpatrimonio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPPatrimonio");
            });

            modelBuilder.Entity<TribCadastrodPpedologiaT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPPedologiaT");

                entity.Property(e => e.IdPpedologia).HasColumnName("idPPedologia");

                entity.Property(e => e.NmPpedologia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPPedologia");
            });

            modelBuilder.Entity<TribCadastrodPpisoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPPisoE");

                entity.Property(e => e.IdPpiso).HasColumnName("idPPiso");

                entity.Property(e => e.NmPpiso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPPiso");
            });

            modelBuilder.Entity<TribCadastrodPposicaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPPosicaoE");

                entity.Property(e => e.IdPposicao).HasColumnName("idPPosicao");

                entity.Property(e => e.NmPposicao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPPosicao");
            });

            modelBuilder.Entity<TribCadastrodPsituacaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPSituacaoE");

                entity.Property(e => e.IdPsituacao).HasColumnName("idPSituacao");

                entity.Property(e => e.NmPsituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPSituacao");
            });

            modelBuilder.Entity<TribCadastrodPtipoConstrucaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPTipoConstrucaoE");

                entity.Property(e => e.IdPtipoConstrucao).HasColumnName("idPTipoConstrucao");

                entity.Property(e => e.NmPtipoConstrucao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPTipoConstrucao");
            });

            modelBuilder.Entity<TribCadastrodPtopografiaT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPTopografiaT");

                entity.Property(e => e.IdPtopografia).HasColumnName("idPTopografia");

                entity.Property(e => e.NmPtopografia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPTopografia");
            });

            modelBuilder.Entity<TribCadastrodPusoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPUsoE");

                entity.Property(e => e.IdPuso).HasColumnName("idPUso");

                entity.Property(e => e.NmPuso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPUso");
            });

            modelBuilder.Entity<TribCadastrodPutilizacaoE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPUtilizacaoE");

                entity.Property(e => e.IdPutilizacao).HasColumnName("idPUtilizacao");

                entity.Property(e => e.NmPutilizacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPUtilizacao");
            });

            modelBuilder.Entity<TribCadastrodPvegetacaoT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodPVegetacaoT");

                entity.Property(e => e.IdPvegetacao).HasColumnName("idPVegetacao");

                entity.Property(e => e.NmPvegetacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPVegetacao");
            });

            modelBuilder.Entity<TribCadastrodRegiao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodRegiao");

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");

                entity.Property(e => e.NmRegiao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmRegiao");
            });

            modelBuilder.Entity<TribCadastrodRegiaoLoteamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodRegiaoLoteamento");

                entity.Property(e => e.IdLoteamento).HasColumnName("idLoteamento");

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");
            });

            modelBuilder.Entity<TribCadastrodTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodTipoBaixa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.NmTipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoBaixa");
            });

            modelBuilder.Entity<TribCadastrodTipoDividum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdTipoDivida).HasColumnName("idTipoDivida");

                entity.Property(e => e.NmTipoDivida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoDivida");
            });

            modelBuilder.Entity<TribCadastrodTipoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribCadastrodTipoTributo");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NmTipoTributo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoTributo");
            });

            modelBuilder.Entity<TribCadastrofDivida>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EdificacaoId).HasColumnName("EdificacaoID");

                entity.Property(e => e.IdGrupoTributo).HasColumnName("idGrupoTributo");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.IdTipoDivida).HasColumnName("idTipoDivida");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("vlValorDivida");
            });

            modelBuilder.Entity<TribCadastrofInscrico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DsCaracteristica)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsCaracteristica");

                entity.Property(e => e.DsPossuiDividaPendente)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dsPossuiDividaPendente");

                entity.Property(e => e.DsPossuiDividaSuspensa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dsPossuiDividaSuspensa");

                entity.Property(e => e.DsResponsavel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsResponsavel");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.EdificacaoId).HasColumnName("EdificacaoID");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdLoteamento).HasColumnName("idLoteamento");

                entity.Property(e => e.IdPacabamentoExterno).HasColumnName("idPAcabamentoExterno");

                entity.Property(e => e.IdPacabamentoInterno).HasColumnName("idPAcabamentoInterno");

                entity.Property(e => e.IdPagrupamento).HasColumnName("idPAgrupamento");

                entity.Property(e => e.IdPcalcada).HasColumnName("idPCalcada");

                entity.Property(e => e.IdPcobertura).HasColumnName("idPCobertura");

                entity.Property(e => e.IdPcondicao).HasColumnName("idPCondicao");

                entity.Property(e => e.IdPcondominioResid).HasColumnName("idPCondominioResid");

                entity.Property(e => e.IdPesquadrias).HasColumnName("idPEsquadrias");

                entity.Property(e => e.IdPestadoConservacao).HasColumnName("idPEstadoConservacao");

                entity.Property(e => e.IdPestrutura).HasColumnName("idPEstrutura");

                entity.Property(e => e.IdPforro).HasColumnName("idPForro");

                entity.Property(e => e.IdPfundoVale).HasColumnName("idPFundoVale");

                entity.Property(e => e.IdPimovelRural).HasColumnName("idPImovelRural");

                entity.Property(e => e.IdPincidenciaEdificacao).HasColumnName("idPIncidenciaEdificacao");

                entity.Property(e => e.IdPincidenciaTerreno).HasColumnName("idPIncidenciaTerreno");

                entity.Property(e => e.IdPinstalacaoEletrica).HasColumnName("idPInstalacaoEletrica");

                entity.Property(e => e.IdPlimiteTestada).HasColumnName("idPLimiteTestada");

                entity.Property(e => e.IdPlocalizacao).HasColumnName("idPLocalizacao");

                entity.Property(e => e.IdPocupacaoEdificacao).HasColumnName("idPOcupacaoEdificacao");

                entity.Property(e => e.IdPocupacaoTerreno).HasColumnName("idPOcupacaoTerreno");

                entity.Property(e => e.IdPparede).HasColumnName("idPParede");

                entity.Property(e => e.IdPpatrimonio).HasColumnName("idPPatrimonio");

                entity.Property(e => e.IdPpedologia).HasColumnName("idPPedologia");

                entity.Property(e => e.IdPpiso).HasColumnName("idPPiso");

                entity.Property(e => e.IdPposicao).HasColumnName("idPPosicao");

                entity.Property(e => e.IdPsituacao).HasColumnName("idPSituacao");

                entity.Property(e => e.IdPtipoConstrucao).HasColumnName("idPTipoConstrucao");

                entity.Property(e => e.IdPtopografia).HasColumnName("idPTopografia");

                entity.Property(e => e.IdPuso).HasColumnName("idPUso");

                entity.Property(e => e.IdPutilizacao).HasColumnName("idPUtilizacao");

                entity.Property(e => e.IdPvegetacao).HasColumnName("idPVegetacao");

                entity.Property(e => e.IdRegiao).HasColumnName("idRegiao");

                entity.Property(e => e.InscricaoImobiliaria)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.VlAreaConstruida)
                    .HasColumnType("money")
                    .HasColumnName("vlAreaConstruida");

                entity.Property(e => e.VlAreaTerreno)
                    .HasColumnType("money")
                    .HasColumnName("vlAreaTerreno");
            });

            modelBuilder.Entity<TribEmpresasdAtividade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdAtividade");

                entity.Property(e => e.DsAtividade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsAtividade");

                entity.Property(e => e.IdAtividade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idAtividade");
            });

            modelBuilder.Entity<TribEmpresasdBairro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdBairro");

                entity.Property(e => e.DsBairro)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dsBairro");

                entity.Property(e => e.IdBairro).HasColumnName("idBairro");
            });

            modelBuilder.Entity<TribEmpresasdCaracteristica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdCaracteristica");

                entity.Property(e => e.DsCaracteristica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsCaracteristica");

                entity.Property(e => e.IdCaracteristica).HasColumnName("idCaracteristica");
            });

            modelBuilder.Entity<TribEmpresasdCidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdCidade");

                entity.Property(e => e.DsCidade)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("dsCidade");

                entity.Property(e => e.IdCidade).HasColumnName("idCidade");
            });

            modelBuilder.Entity<TribEmpresasdConstituicao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdConstituicao");

                entity.Property(e => e.DsConstituicao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsConstituicao");

                entity.Property(e => e.IdConstituicao).HasColumnName("idConstituicao");
            });

            modelBuilder.Entity<TribEmpresasdLogradouro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdLogradouro");

                entity.Property(e => e.DsNomeLogradouro)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("dsNomeLogradouro");

                entity.Property(e => e.DsTipoLogradouro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoLogradouro");

                entity.Property(e => e.IdLogradouro).HasColumnName("idLogradouro");
            });

            modelBuilder.Entity<TribEmpresasdRegime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdRegime");

                entity.Property(e => e.DsRegime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsRegime");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");
            });

            modelBuilder.Entity<TribEmpresasdServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdServico");

                entity.Property(e => e.DsServico)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("dsServico");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("idServico");
            });

            modelBuilder.Entity<TribEmpresasdSituacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdSituacao");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");
            });

            modelBuilder.Entity<TribEmpresasdTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdTipoBaixa");

                entity.Property(e => e.DsTipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoBaixa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");
            });

            modelBuilder.Entity<TribEmpresasdTipoEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdTipoEmpresa");

                entity.Property(e => e.DsTipoEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoEmpresa");

                entity.Property(e => e.IdTipoEmpresa).HasColumnName("idTipoEmpresa");
            });

            modelBuilder.Entity<TribEmpresasdTipoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasdTipoTributo");

                entity.Property(e => e.DsTipoTributo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoTributo");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");
            });

            modelBuilder.Entity<TribEmpresasfDivida>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdCmcempresa).HasColumnName("idCMCEmpresa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlArrecadado");

                entity.Property(e => e.VlLancado)
                    .HasColumnType("money")
                    .HasColumnName("vlLancado");

                entity.Property(e => e.VlOutros)
                    .HasColumnType("money")
                    .HasColumnName("vlOutros");

                entity.Property(e => e.VlPendente)
                    .HasColumnType("money")
                    .HasColumnName("vlPendente");
            });

            modelBuilder.Entity<TribEmpresasfEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DsCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dsCNPJCPF");

                entity.Property(e => e.DsDomicilioTributario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dsDomicilioTributario")
                    .IsFixedLength();

                entity.Property(e => e.DsEnquadraSimples)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("dsEnquadraSimples")
                    .IsFixedLength();

                entity.Property(e => e.DsNomeFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsNomeFantasia");

                entity.Property(e => e.DsNumeroEndereco)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsNumeroEndereco");

                entity.Property(e => e.DsRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRazaoSocial");

                entity.Property(e => e.DsTipoPrestacao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoPrestacao");

                entity.Property(e => e.IdBairro).HasColumnName("idBairro");

                entity.Property(e => e.IdCaracteristica).HasColumnName("idCaracteristica");

                entity.Property(e => e.IdCidade).HasColumnName("idCidade");

                entity.Property(e => e.IdCmcempresa).HasColumnName("idCMCEmpresa");

                entity.Property(e => e.IdConstituicao).HasColumnName("idConstituicao");

                entity.Property(e => e.IdLogradouro).HasColumnName("idLogradouro");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");

                entity.Property(e => e.IdSituacao).HasColumnName("idSituacao");

                entity.Property(e => e.IdTipoEmpresa).HasColumnName("idTipoEmpresa");
            });

            modelBuilder.Entity<TribEmpresasfEmpresasAtividade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasfEmpresasAtividade");

                entity.Property(e => e.IdAtividade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("idAtividade");

                entity.Property(e => e.IdCmcempresa).HasColumnName("idCMCEmpresa");
            });

            modelBuilder.Entity<TribEmpresasfEmpresasServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribEmpresasfEmpresasServico");

                entity.Property(e => e.IdCmcempresa).HasColumnName("idCMCEmpresa");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("idServico");
            });

            modelBuilder.Entity<TribIptudAno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUdAno");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");
            });

            modelBuilder.Entity<TribIptudTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUdTipoBaixa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.NmTipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoBaixa");
            });

            modelBuilder.Entity<TribIptudTipoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUdTipoTributo");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NmTipoTributo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmTipoTributo");
            });

            modelBuilder.Entity<TribIptufArrecadadoAno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUfArrecadadoAno");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.NrQtdeContribuintesNaoPagaram).HasColumnName("nrQtdeContribuintesNaoPagaram");

                entity.Property(e => e.NrQtdeContribuintesPagoCotaUnica).HasColumnName("nrQtdeContribuintesPagoCotaUnica");

                entity.Property(e => e.NrQtdeContribuintesPagoDemaisParcelas).HasColumnName("nrQtdeContribuintesPagoDemaisParcelas");

                entity.Property(e => e.NrQtdeInscricoesNaoPagaram).HasColumnName("nrQtdeInscricoesNaoPagaram");

                entity.Property(e => e.NrQtdeInscricoesPagoCotaUnica).HasColumnName("nrQtdeInscricoesPagoCotaUnica");

                entity.Property(e => e.NrQtdeInscricoesPagoDemaisParcelas).HasColumnName("nrQtdeInscricoesPagoDemaisParcelas");

                entity.Property(e => e.VlValorPagoCotaUnica)
                    .HasColumnType("money")
                    .HasColumnName("vlValorPagoCotaUnica");

                entity.Property(e => e.VlValorPagoDemaisParcelas)
                    .HasColumnType("money")
                    .HasColumnName("vlValorPagoDemaisParcelas");

                entity.Property(e => e.VlValorTotalPago)
                    .HasColumnType("money")
                    .HasColumnName("vlValorTotalPago");
            });

            modelBuilder.Entity<TribIptufResumoAno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUfResumoAno");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("vlValorDivida");
            });

            modelBuilder.Entity<TribIptufResumoTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUfResumoTipoBaixa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("vlValorDivida");
            });

            modelBuilder.Entity<TribIptufResumoTipoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribIPTUfResumoTipoTributo");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.NrAno).HasColumnName("nrAno");

                entity.Property(e => e.VlValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("vlValorDivida");
            });

            modelBuilder.Entity<TribIssqndCnae>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribISSQNdCNAE");

                entity.Property(e => e.DsCnae)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsCNAE");

                entity.Property(e => e.IdCnae)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idCNAE");
            });

            modelBuilder.Entity<TribIssqndEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribISSQNdEmpresa");

                entity.Property(e => e.DsCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dsCNPJCPF");

                entity.Property(e => e.DsRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRazaoSocial");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");

                entity.Property(e => e.NrCmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nrCMC");
            });

            modelBuilder.Entity<TribIssqndRegime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribISSQNdRegime");

                entity.Property(e => e.DsRegime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsRegime");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");
            });

            modelBuilder.Entity<TribIssqndServico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribISSQNdServico");

                entity.Property(e => e.DsServico)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("dsServico");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idServico");
            });

            modelBuilder.Entity<TribIssqnfArrecadado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribISSQNfArrecadado");

                entity.Property(e => e.IdCnae)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idCNAE");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdServico)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("idServico");

                entity.Property(e => e.NrAnoCompetencia).HasColumnName("nrAnoCompetencia");

                entity.Property(e => e.NrMesCompetencia).HasColumnName("nrMesCompetencia");

                entity.Property(e => e.VlValorArrecadado)
                    .HasColumnType("money")
                    .HasColumnName("vlValorArrecadado");
            });

            modelBuilder.Entity<TribNfsehomologadadEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribNFSEHomologadadEmpresa");

                entity.Property(e => e.DsCnpjcpf)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dsCNPJCPF");

                entity.Property(e => e.DsRazaoSocial)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRazaoSocial");

                entity.Property(e => e.DtHomologado)
                    .HasColumnType("date")
                    .HasColumnName("dtHomologado");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");

                entity.Property(e => e.NrCmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nrCMC");
            });

            modelBuilder.Entity<TribNfsehomologadadRegime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribNFSEHomologadadRegime");

                entity.Property(e => e.DsNomeRegime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsNomeRegime");

                entity.Property(e => e.IdRegime).HasColumnName("idRegime");
            });

            modelBuilder.Entity<TribNfsehomologadafNota>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribNFSEHomologadafNotas");

                entity.Property(e => e.DtCompetencia)
                    .HasColumnType("date")
                    .HasColumnName("dtCompetencia");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.NrQtdeNotas).HasColumnName("nrQtdeNotas");

                entity.Property(e => e.VlValorNotas)
                    .HasColumnType("money")
                    .HasColumnName("vlValorNotas");
            });

            modelBuilder.Entity<TribRefisdLeisDesconto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribRefisdLeisDesconto");

                entity.Property(e => e.DsLei)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLei");

                entity.Property(e => e.IdLei).HasColumnName("idLei");
            });

            modelBuilder.Entity<TribRefisfArrecadado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribRefisfArrecadado");

                entity.Property(e => e.DsTipoCadastro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCadastro");

                entity.Property(e => e.IdLei).HasColumnName("idLei");

                entity.Property(e => e.VlCorrecao)
                    .HasColumnType("money")
                    .HasColumnName("vlCorrecao");

                entity.Property(e => e.VlDesconto)
                    .HasColumnType("money")
                    .HasColumnName("vlDesconto");

                entity.Property(e => e.VlJuros)
                    .HasColumnType("money")
                    .HasColumnName("vlJuros");

                entity.Property(e => e.VlMulta)
                    .HasColumnType("money")
                    .HasColumnName("vlMulta");

                entity.Property(e => e.VlMultaDa)
                    .HasColumnType("money")
                    .HasColumnName("vlMultaDA");

                entity.Property(e => e.VlPago)
                    .HasColumnType("money")
                    .HasColumnName("vlPago");

                entity.Property(e => e.VlPrincipal)
                    .HasColumnType("money")
                    .HasColumnName("vlPrincipal");
            });

            modelBuilder.Entity<TribRefisfAtraso>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DsTipoCadastro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCadastro");

                entity.Property(e => e.IdLei).HasColumnName("idLei");

                entity.Property(e => e.NrParcelas).HasColumnName("nrParcelas");

                entity.Property(e => e.NrParcelasEmAtraso).HasColumnName("nrParcelasEmAtraso");

                entity.Property(e => e.NrTap).HasColumnName("nrTAP");
            });

            modelBuilder.Entity<TribRefisfQtdeLeisDesconto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribRefisfQtdeLeisDesconto");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.DsTipoCadastro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoCadastro");

                entity.Property(e => e.IdLei).HasColumnName("idLei");

                entity.Property(e => e.NrParcelas).HasColumnName("nrParcelas");

                entity.Property(e => e.NrQtdeParcelamentos).HasColumnName("nrQtdeParcelamentos");
            });

            modelBuilder.Entity<TribTributosdGrupoTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribTributosdGrupoTipoBaixa");

                entity.Property(e => e.DsGrupoTipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsGrupoTipoBaixa");

                entity.Property(e => e.IdGrupoTipoBaixa).HasColumnName("idGrupoTipoBaixa");
            });

            modelBuilder.Entity<TribTributosdGrupoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DsGrupoTributo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("dsGrupoTributo");

                entity.Property(e => e.IdGrupoTributo).HasColumnName("idGrupoTributo");
            });

            modelBuilder.Entity<TribTributosdTipoBaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribTributosdTipoBaixa");

                entity.Property(e => e.DsTipoBaixa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoBaixa");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");
            });

            modelBuilder.Entity<TribTributosdTipoDividum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DsTipoDivida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoDivida");

                entity.Property(e => e.IdTipoDivida).HasColumnName("idTipoDivida");
            });

            modelBuilder.Entity<TribTributosdTipoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TribTributosdTipoTributo");

                entity.Property(e => e.DsTipoTributo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsTipoTributo");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");
            });

            modelBuilder.Entity<TribTributosfResumoTributo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdGrupoTipoBaixa).HasColumnName("idGrupoTipoBaixa");

                entity.Property(e => e.IdGrupoTributo).HasColumnName("idGrupoTributo");

                entity.Property(e => e.IdTipoBaixa).HasColumnName("idTipoBaixa");

                entity.Property(e => e.IdTipoDivida).HasColumnName("idTipoDivida");

                entity.Property(e => e.IdTipoTributo).HasColumnName("idTipoTributo");

                entity.Property(e => e.VlValorDivida)
                    .HasColumnType("money")
                    .HasColumnName("vlValorDivida");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
