using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class GIIGProtocoloDBContext : DbContext
    {
        public GIIGProtocoloDBContext()
        {
        }

        public GIIGProtocoloDBContext(DbContextOptions<GIIGProtocoloDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CargasProcesso> CargasProcessos { get; set; } = null!;
        public virtual DbSet<Cidade> Cidades { get; set; } = null!;
        public virtual DbSet<CtuInscricaoImobiliarium> CtuInscricaoImobiliaria { get; set; } = null!;
        public virtual DbSet<CtuPautaPresenca> CtuPautaPresencas { get; set; } = null!;
        public virtual DbSet<CtuPautum> CtuPauta { get; set; } = null!;
        public virtual DbSet<CtuProcessosPautum> CtuProcessosPauta { get; set; } = null!;
        public virtual DbSet<Recebimento> Recebimentos { get; set; } = null!;
        public virtual DbSet<SysAutoIncrement> SysAutoIncrements { get; set; } = null!;
        public virtual DbSet<SysAutoIncrementSequence> SysAutoIncrementSequences { get; set; } = null!;
        public virtual DbSet<TabAgendum> TabAgenda { get; set; } = null!;
        public virtual DbSet<TabAnexo> TabAnexos { get; set; } = null!;
        public virtual DbSet<TabAnexo1> TabAnexos1 { get; set; } = null!;
        public virtual DbSet<TabArqGerArquivo> TabArqGerArquivos { get; set; } = null!;
        public virtual DbSet<TabArqGerDocumento> TabArqGerDocumentos { get; set; } = null!;
        public virtual DbSet<TabArquivo> TabArquivos { get; set; } = null!;
        public virtual DbSet<TabAssunto> TabAssuntos { get; set; } = null!;
        public virtual DbSet<TabAtributo> TabAtributos { get; set; } = null!;
        public virtual DbSet<TabAtributoMovimento> TabAtributoMovimentos { get; set; } = null!;
        public virtual DbSet<TabAtributoProcesso> TabAtributoProcessos { get; set; } = null!;
        public virtual DbSet<TabBarra> TabBarras { get; set; } = null!;
        public virtual DbSet<TabBoleto> TabBoletos { get; set; } = null!;
        public virtual DbSet<TabCapa> TabCapas { get; set; } = null!;
        public virtual DbSet<TabCep> TabCeps { get; set; } = null!;
        public virtual DbSet<TabCidade> TabCidades { get; set; } = null!;
        public virtual DbSet<TabConfiguraPortal> TabConfiguraPortals { get; set; } = null!;
        public virtual DbSet<TabDocumentoTipo> TabDocumentoTipos { get; set; } = null!;
        public virtual DbSet<TabDocumentoTipoAssunto> TabDocumentoTipoAssuntos { get; set; } = null!;
        public virtual DbSet<TabFuncionario> TabFuncionarios { get; set; } = null!;
        public virtual DbSet<TabLogTransferenciaCadastro> TabLogTransferenciaCadastros { get; set; } = null!;
        public virtual DbSet<TabMensagem> TabMensagems { get; set; } = null!;
        public virtual DbSet<TabMensagemDestino> TabMensagemDestinos { get; set; } = null!;
        public virtual DbSet<TabMensagemRespostum> TabMensagemResposta { get; set; } = null!;
        public virtual DbSet<TabModelo> TabModelos { get; set; } = null!;
        public virtual DbSet<TabModeloAssunto> TabModeloAssuntos { get; set; } = null!;
        public virtual DbSet<TabMovimento> TabMovimentos { get; set; } = null!;
        public virtual DbSet<TabMovimentoParecer> TabMovimentoParecers { get; set; } = null!;
        public virtual DbSet<TabPessoa> TabPessoas { get; set; } = null!;
        public virtual DbSet<TabPrioridade> TabPrioridades { get; set; } = null!;
        public virtual DbSet<TabProcesso> TabProcessos { get; set; } = null!;
        public virtual DbSet<TabProcessoInteressado> TabProcessoInteressados { get; set; } = null!;
        public virtual DbSet<TabProcessoNotificaco> TabProcessoNotificacoes { get; set; } = null!;
        public virtual DbSet<TabProcessoStatus> TabProcessoStatuses { get; set; } = null!;
        public virtual DbSet<TabProcessoVinculo> TabProcessoVinculos { get; set; } = null!;
        public virtual DbSet<TabProtocolo> TabProtocolos { get; set; } = null!;
        public virtual DbSet<TabRoteiro> TabRoteiros { get; set; } = null!;
        public virtual DbSet<TabTipoAgendaAnexo> TabTipoAgendaAnexos { get; set; } = null!;
        public virtual DbSet<TabTipoAgendaDocumento> TabTipoAgendaDocumentos { get; set; } = null!;
        public virtual DbSet<TabTipoAgendum> TabTipoAgenda { get; set; } = null!;
        public virtual DbSet<TabUnidade> TabUnidades { get; set; } = null!;
        public virtual DbSet<TabUnidadeTipo> TabUnidadeTipos { get; set; } = null!;
        public virtual DbSet<TabUsuarioAssunto> TabUsuarioAssuntos { get; set; } = null!;
        public virtual DbSet<Tabteste> Tabtestes { get; set; } = null!;
        public virtual DbSet<TbParametrosProcesso> TbParametrosProcessos { get; set; } = null!;
        public virtual DbSet<Tbgrupo> Tbgrupos { get; set; } = null!;
        public virtual DbSet<Tbparametro> Tbparametros { get; set; } = null!;
        public virtual DbSet<Tbprocessoalertaavisado> Tbprocessoalertaavisados { get; set; } = null!;
        public virtual DbSet<Tbsubgrupo> Tbsubgrupos { get; set; } = null!;
        public virtual DbSet<Tbunidadeusuario> Tbunidadeusuarios { get; set; } = null!;
        public virtual DbSet<ViewProtocoloweb2do> ViewProtocoloweb2dos { get; set; } = null!;
        public virtual DbSet<VwDashBoardProcess> VwDashBoardProcesses { get; set; } = null!;
        public virtual DbSet<VwProcessosPautum> VwProcessosPauta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=GIIGProtocoloDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CargasProcesso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CargasProcesso");

                entity.Property(e => e.CargaData).HasColumnType("datetime");

                entity.Property(e => e.CargaDespacho).HasColumnType("text");

                entity.Property(e => e.CargaDivisaoId).HasColumnName("CargaDivisaoID");

                entity.Property(e => e.CargaDivisaoIdorigem).HasColumnName("CargaDivisaoIDOrigem");

                entity.Property(e => e.CargaId).HasColumnName("CargaID");

                entity.Property(e => e.CargaProcId).HasColumnName("CargaProcID");

                entity.Property(e => e.CargaPublicoDivisao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cidade");

                entity.Property(e => e.CidNome)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cidNome");

                entity.Property(e => e.CidadeId).HasColumnName("cidadeId");
            });

            modelBuilder.Entity<CtuInscricaoImobiliarium>(entity =>
            {
                entity.ToTable("ctu_inscricao_imobiliaria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.IdProcesso).HasColumnName("id_processo");

                entity.Property(e => e.InscricaoImobiliaria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscricao_imobiliaria");
            });

            modelBuilder.Entity<CtuPautaPresenca>(entity =>
            {
                entity.ToTable("ctu_pauta_presenca");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataHora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_hora");

                entity.Property(e => e.IdPauta).HasColumnName("id_pauta");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            });

            modelBuilder.Entity<CtuPautum>(entity =>
            {
                entity.ToTable("ctu_pauta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ata)
                    .HasColumnType("text")
                    .HasColumnName("ata");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ativo")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.CodPauta)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cod_pauta");

                entity.Property(e => e.DataHoraCriado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_hora_criado");

                entity.Property(e => e.DataReuniao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_reuniao");

                entity.Property(e => e.Finalizado).HasColumnName("finalizado");
            });

            modelBuilder.Entity<CtuProcessosPautum>(entity =>
            {
                entity.ToTable("ctu_processos_pauta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bairro");

                entity.Property(e => e.ConsideracoesGerais)
                    .HasColumnType("text")
                    .HasColumnName("consideracoes_gerais");

                entity.Property(e => e.DataHomologacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_homologacao");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Final)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("final");

                entity.Property(e => e.Homologado).HasColumnName("homologado");

                entity.Property(e => e.IdPauta).HasColumnName("id_pauta");

                entity.Property(e => e.IdProcesso).HasColumnName("id_processo");

                entity.Property(e => e.InscricaoImobiliaria)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inscricao_imobiliaria");

                entity.Property(e => e.Legislacao)
                    .HasColumnType("text")
                    .HasColumnName("legislacao");

                entity.Property(e => e.Local)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("local");

                entity.Property(e => e.ResponsavelTecnico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("responsavel_tecnico");

                entity.Property(e => e.Resposta)
                    .HasColumnType("text")
                    .HasColumnName("resposta");

                entity.Property(e => e.Unanimidade).HasColumnName("unanimidade");

                entity.Property(e => e.UsuarioHomologacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_homologacao");

                entity.Property(e => e.Zona)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("zona");
            });

            modelBuilder.Entity<Recebimento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RecCargaId).HasColumnName("RecCargaID");

                entity.Property(e => e.RecData).HasColumnType("datetime");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.RecIdrecebimento).HasColumnName("RecIDRecebimento");

                entity.Property(e => e.RecServidorId).HasColumnName("RecServidorID");

                entity.Property(e => e.RecSituacao)
                    .HasMaxLength(15)
                    .IsUnicode(false);
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

            modelBuilder.Entity<SysAutoIncrementSequence>(entity =>
            {
                entity.HasKey(e => new { e.SysTableName, e.SysYear });

                entity.ToTable("sysAutoIncrementSequence");

                entity.Property(e => e.SysTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sysTableName");

                entity.Property(e => e.SysYear).HasColumnName("sysYear");

                entity.Property(e => e.SysTableSequence).HasColumnName("sysTableSequence");
            });

            modelBuilder.Entity<TabAgendum>(entity =>
            {
                entity.HasKey(e => e.AgenId);

                entity.ToTable("tabAgenda");

                entity.Property(e => e.AgenId)
                    .ValueGeneratedNever()
                    .HasColumnName("agenId");

                entity.Property(e => e.AgenAtendido).HasColumnName("agenAtendido");

                entity.Property(e => e.AgenData)
                    .HasColumnType("date")
                    .HasColumnName("agenData");

                entity.Property(e => e.AgenHora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("agenHora");

                entity.Property(e => e.AgenSequencia).HasColumnName("agenSequencia");

                entity.Property(e => e.AgenTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("agenTipo")
                    .IsFixedLength();

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.TpAgId).HasColumnName("tpAgId");

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabAgenda)
                    .HasForeignKey(d => d.PessId)
                    .HasConstraintName("FK_tabAgenda_tabPessoa");

                entity.HasOne(d => d.TpAg)
                    .WithMany(p => p.TabAgenda)
                    .HasForeignKey(d => d.TpAgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabAgenda_tabTipoAgenda");
            });

            modelBuilder.Entity<TabAnexo>(entity =>
            {
                entity.HasKey(e => e.AnexId);

                entity.ToTable("tabAnexo");

                entity.HasIndex(e => e.MoviId, "IX_tabAnexo_moviId");

                entity.HasIndex(e => e.TipoDocId, "IX_tabAnexo_tipoDocId");

                entity.Property(e => e.AnexId)
                    .ValueGeneratedNever()
                    .HasColumnName("anexId");

                entity.Property(e => e.AnexArquivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("anexArquivo");

                entity.Property(e => e.AnexContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("anexContentType");

                entity.Property(e => e.AnexData)
                    .HasColumnType("datetime")
                    .HasColumnName("anexData");

                entity.Property(e => e.AnexDescricao)
                    .IsUnicode(false)
                    .HasColumnName("anexDescricao");

                entity.Property(e => e.AnexFlAtivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("anexFlAtivo")
                    .HasDefaultValueSql("('Sim')")
                    .IsFixedLength();

                entity.Property(e => e.AnexNumeroFolhas).HasColumnName("anexNumeroFolhas");

                entity.Property(e => e.AnexObjeto).HasColumnName("anexObjeto");

                entity.Property(e => e.AnexPublico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("anexPublico")
                    .IsFixedLength();

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.MoviId).HasColumnName("moviId");

                entity.Property(e => e.TipoDocId).HasColumnName("tipoDocId");

                entity.HasOne(d => d.Movi)
                    .WithMany(p => p.TabAnexos)
                    .HasForeignKey(d => d.MoviId)
                    .HasConstraintName("FK_tabAnexo_tabMovimento");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.TabAnexos)
                    .HasForeignKey(d => d.TipoDocId)
                    .HasConstraintName("FK_tabAnexo_tabDocumentoTipo");
            });

            modelBuilder.Entity<TabAnexo1>(entity =>
            {
                entity.HasKey(e => e.AneId);

                entity.ToTable("tabAnexos");

                entity.Property(e => e.AneId)
                    .ValueGeneratedNever()
                    .HasColumnName("aneId");

                entity.Property(e => e.AneContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("aneContentType");

                entity.Property(e => e.AneExtensao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("aneExtensao");

                entity.Property(e => e.AneObjeto).HasColumnName("aneObjeto");

                entity.HasMany(d => d.Mens)
                    .WithMany(p => p.Anes)
                    .UsingEntity<Dictionary<string, object>>(
                        "TabMensagemAnexo",
                        l => l.HasOne<TabMensagem>().WithMany().HasForeignKey("MensId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabMensagemAnexos_tabMensagemAnexos"),
                        r => r.HasOne<TabAnexo1>().WithMany().HasForeignKey("AneId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabMensagemAnexos_tabAnexos"),
                        j =>
                        {
                            j.HasKey("AneId", "MensId");

                            j.ToTable("tabMensagemAnexos");

                            j.IndexerProperty<int>("AneId").HasColumnName("aneId");

                            j.IndexerProperty<long>("MensId").HasColumnName("mensId");
                        });
            });

            modelBuilder.Entity<TabArqGerArquivo>(entity =>
            {
                entity.HasKey(e => e.ArquivoId);

                entity.ToTable("tabArqGerArquivo");

                entity.Property(e => e.ArquivoId)
                    .ValueGeneratedNever()
                    .HasColumnName("arquivoId");

                entity.Property(e => e.Alvara)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("alvara");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Bloco)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("bloco");

                entity.Property(e => e.Caixa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("caixa");

                entity.Property(e => e.Cmc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cmc");

                entity.Property(e => e.Corredor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("corredor");

                entity.Property(e => e.Cpfcnpj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cpfcnpj");

                entity.Property(e => e.DataEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("dataEntrada");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataPagamento");

                entity.Property(e => e.DocumentoAnexo).HasColumnName("documentoAnexo");

                entity.Property(e => e.DocumentoAnexoData)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("documentoAnexoData");

                entity.Property(e => e.DocumentoId).HasColumnName("documentoId");

                entity.Property(e => e.Especie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("especie");

                entity.Property(e => e.FormatoDocumentoAnexo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("formatoDocumentoAnexo");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.InformacaoAdicional)
                    .HasColumnType("text")
                    .HasColumnName("informacaoAdicional");

                entity.Property(e => e.InicioAtividades)
                    .HasColumnType("date")
                    .HasColumnName("inicioAtividades");

                entity.Property(e => e.InscricaoImobiliaria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscricaoImobiliaria");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Numero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numero");

                entity.Property(e => e.Orgao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orgao");

                entity.Property(e => e.PrazoGuarda)
                    .HasColumnType("datetime")
                    .HasColumnName("prazoGuarda");

                entity.Property(e => e.Razaosocial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("razaosocial");

                entity.Property(e => e.Sala)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sala");

                entity.Property(e => e.TipoArquivo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipoArquivo");

                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.TabArqGerArquivos)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabArqGerArquivo_tabArqGerDocumento");

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.TabArqGerArquivos)
                    .HasForeignKey(d => d.FuncId)
                    .HasConstraintName("FK_funcId_arquivoFuncId");
            });

            modelBuilder.Entity<TabArqGerDocumento>(entity =>
            {
                entity.HasKey(e => e.DocumentoId);

                entity.ToTable("tabArqGerDocumento");

                entity.Property(e => e.DocumentoId)
                    .ValueGeneratedNever()
                    .HasColumnName("documentoId");

                entity.Property(e => e.DocumentoNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("documentoNome");
            });

            modelBuilder.Entity<TabArquivo>(entity =>
            {
                entity.HasKey(e => e.ArquId);

                entity.ToTable("tabArquivo");

                entity.HasIndex(e => e.FuncId, "IX_tabArquivo_funcId");

                entity.HasIndex(e => e.ProcId, "IX_tabArquivo_procId");

                entity.Property(e => e.ArquId)
                    .ValueGeneratedNever()
                    .HasColumnName("arquId");

                entity.Property(e => e.ArquBloco)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("arquBloco");

                entity.Property(e => e.ArquCaixa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("arquCaixa");

                entity.Property(e => e.ArquCorredor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("arquCorredor");

                entity.Property(e => e.ArquDataArq)
                    .HasColumnType("datetime")
                    .HasColumnName("arquDataArq");

                entity.Property(e => e.ArquDataDes)
                    .HasColumnType("datetime")
                    .HasColumnName("arquDataDes");

                entity.Property(e => e.ArquDespacho)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arquDespacho");

                entity.Property(e => e.ArquDocumentoAnexo).HasColumnName("arquDocumentoAnexo");

                entity.Property(e => e.ArquDocumentoAnexoData)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("arquDocumentoAnexoData");

                entity.Property(e => e.ArquFormatoDocumentoAnexo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("arquFormatoDocumentoAnexo");

                entity.Property(e => e.ArquLocal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arquLocal");

                entity.Property(e => e.ArquPrazoGuarda)
                    .HasColumnType("datetime")
                    .HasColumnName("arquPrazoGuarda");

                entity.Property(e => e.ArquSala)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("arquSala");

                entity.Property(e => e.ArquStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("arquStatus")
                    .IsFixedLength()
                    .HasComment("Contem a situação do arquivamento 'N' Normal e 'C' Cancelado");

                entity.Property(e => e.ArquTipoArquivo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("arquTipoArquivo");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.TabArquivos)
                    .HasForeignKey(d => d.FuncId)
                    .HasConstraintName("FK_tabArquivo_tabFuncionario");

                entity.HasOne(d => d.Proc)
                    .WithMany(p => p.TabArquivos)
                    .HasForeignKey(d => d.ProcId)
                    .HasConstraintName("FK_tabArquivo_tabProcesso");
            });

            modelBuilder.Entity<TabAssunto>(entity =>
            {
                entity.HasKey(e => e.AssuId);

                entity.ToTable("tabAssunto");

                entity.HasIndex(e => e.AssuNome, "IX_tabAssunto_assuNome");

                entity.Property(e => e.AssuId)
                    .ValueGeneratedNever()
                    .HasColumnName("assuId");

                entity.Property(e => e.AssuDescricao)
                    .IsUnicode(false)
                    .HasColumnName("assuDescricao");

                entity.Property(e => e.AssuFlAtivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("assuFlAtivo")
                    .HasDefaultValueSql("('Sim')")
                    .IsFixedLength();

                entity.Property(e => e.AssuFlUsaPortal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("assuFlUsaPortal")
                    .IsFixedLength();

                entity.Property(e => e.AssuNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assuNome");

                entity.Property(e => e.Dsextensaoadicional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsextensaoadicional")
                    .HasComment("Extensões adicionais que podem ser enviadas além de PDF para este assunto.");

                entity.Property(e => e.Idsubgrupo).HasColumnName("idsubgrupo");

                entity.Property(e => e.UnidIdPadrao).HasColumnName("unidIdPadrao");
            });

            modelBuilder.Entity<TabAtributo>(entity =>
            {
                entity.HasKey(e => e.AtriId);

                entity.ToTable("tabAtributo");

                entity.HasIndex(e => e.AtriNome, "IX_tabAtributo_atriNome");

                entity.Property(e => e.AtriId)
                    .ValueGeneratedNever()
                    .HasColumnName("atriId");

                entity.Property(e => e.AtriDescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("atriDescricao");

                entity.Property(e => e.AtriNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atriNome");

                entity.Property(e => e.AtriTamanho).HasColumnName("atriTamanho");

                entity.Property(e => e.AtriTipo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("atriTipo");

                entity.HasMany(d => d.Assus)
                    .WithMany(p => p.Atris)
                    .UsingEntity<Dictionary<string, object>>(
                        "TabAtributoAssunto",
                        l => l.HasOne<TabAssunto>().WithMany().HasForeignKey("AssuId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabAtributoAssunto_tabAssunto"),
                        r => r.HasOne<TabAtributo>().WithMany().HasForeignKey("AtriId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabAtributoAssunto_tabAtributo"),
                        j =>
                        {
                            j.HasKey("AtriId", "AssuId");

                            j.ToTable("tabAtributoAssunto");

                            j.IndexerProperty<int>("AtriId").HasColumnName("atriId");

                            j.IndexerProperty<short>("AssuId").HasColumnName("assuId");
                        });

                entity.HasMany(d => d.Rotes)
                    .WithMany(p => p.Atris)
                    .UsingEntity<Dictionary<string, object>>(
                        "TabAtributoRoteiro",
                        l => l.HasOne<TabRoteiro>().WithMany().HasForeignKey("RoteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabAtributoRoteiro_tabRoteiro"),
                        r => r.HasOne<TabAtributo>().WithMany().HasForeignKey("AtriId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabAtributoRoteiro_tabAtributo"),
                        j =>
                        {
                            j.HasKey("AtriId", "RoteId");

                            j.ToTable("tabAtributoRoteiro");

                            j.IndexerProperty<int>("AtriId").HasColumnName("atriId");

                            j.IndexerProperty<short>("RoteId").HasColumnName("roteId");
                        });
            });

            modelBuilder.Entity<TabAtributoMovimento>(entity =>
            {
                entity.HasKey(e => new { e.AtriId, e.MoviId });

                entity.ToTable("tabAtributoMovimento");

                entity.Property(e => e.AtriId).HasColumnName("atriId");

                entity.Property(e => e.MoviId).HasColumnName("moviId");

                entity.Property(e => e.AtmvValor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("atmvValor");

                entity.HasOne(d => d.Atri)
                    .WithMany(p => p.TabAtributoMovimentos)
                    .HasForeignKey(d => d.AtriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabAtributoMovimento_tabAtributo");

                entity.HasOne(d => d.Movi)
                    .WithMany(p => p.TabAtributoMovimentos)
                    .HasForeignKey(d => d.MoviId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabAtributoMovimento_tabMovimento");
            });

            modelBuilder.Entity<TabAtributoProcesso>(entity =>
            {
                entity.HasKey(e => new { e.AtriId, e.ProcId });

                entity.ToTable("tabAtributoProcesso");

                entity.Property(e => e.AtriId).HasColumnName("atriId");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.Property(e => e.AtprValor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("atprValor");

                entity.HasOne(d => d.Atri)
                    .WithMany(p => p.TabAtributoProcessos)
                    .HasForeignKey(d => d.AtriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabAtributoProcesso_tabAtributo");

                entity.HasOne(d => d.Proc)
                    .WithMany(p => p.TabAtributoProcessos)
                    .HasForeignKey(d => d.ProcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabAtributoProcesso_tabProcesso");
            });

            modelBuilder.Entity<TabBarra>(entity =>
            {
                entity.HasKey(e => e.BarrId);

                entity.ToTable("tabBarra");

                entity.Property(e => e.BarrId)
                    .ValueGeneratedNever()
                    .HasColumnName("barrId");

                entity.Property(e => e.BarrImage).HasColumnName("barrImage");
            });

            modelBuilder.Entity<TabBoleto>(entity =>
            {
                entity.HasKey(e => e.BoleId);

                entity.ToTable("tabBoleto");

                entity.HasIndex(e => e.MoviId, "IX_tabBoleto_moviId");

                entity.Property(e => e.BoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("boleId");

                entity.Property(e => e.BoleData)
                    .HasColumnType("datetime")
                    .HasColumnName("boleData");

                entity.Property(e => e.BoleImage)
                    .HasColumnType("image")
                    .HasColumnName("boleImage");

                entity.Property(e => e.BoleNossoNumero)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("boleNossoNumero");

                entity.Property(e => e.BoleObservacao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("boleObservacao");

                entity.Property(e => e.BoleSacado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("boleSacado");

                entity.Property(e => e.BoleSituacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("boleSituacao");

                entity.Property(e => e.BoleValorBoleto)
                    .HasColumnType("money")
                    .HasColumnName("boleValorBoleto");

                entity.Property(e => e.BoleVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("boleVencimento");

                entity.Property(e => e.MoviId).HasColumnName("moviId");
            });

            modelBuilder.Entity<TabCapa>(entity =>
            {
                entity.ToTable("tabCapas");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.FlAtiva).HasColumnName("flAtiva");

                entity.Property(e => e.NomeRelatorio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TextoDescritivo).HasColumnType("text");

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabCapas)
                    .HasForeignKey(d => d.AssuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Capas_Assunto");
            });

            modelBuilder.Entity<TabCep>(entity =>
            {
                entity.HasKey(e => e.CepId);

                entity.ToTable("tabCEP");

                entity.HasIndex(e => e.CepCep, "IX_tabCEP_CEP");

                entity.HasIndex(e => e.CidaId, "IX_tabCEP_cidaId");

                entity.HasIndex(e => e.CidaId, "IX_tabCEP_cidaId_inc_CEP_TipoLograd_Lograd_Ender_Bairro");

                entity.Property(e => e.CepId)
                    .ValueGeneratedNever()
                    .HasColumnName("cepId");

                entity.Property(e => e.CepBairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cepBairro");

                entity.Property(e => e.CepCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("cepCEP")
                    .IsFixedLength();

                entity.Property(e => e.CepComplemento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cepComplemento");

                entity.Property(e => e.CepLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cepLogradouro");

                entity.Property(e => e.CepTipoLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cepTipoLogradouro");

                entity.Property(e => e.CidaId).HasColumnName("cidaId");

                entity.HasOne(d => d.Cida)
                    .WithMany(p => p.TabCeps)
                    .HasForeignKey(d => d.CidaId)
                    .HasConstraintName("FK_tabCEP_tabCidade");
            });

            modelBuilder.Entity<TabCidade>(entity =>
            {
                entity.HasKey(e => e.CidaId);

                entity.ToTable("tabCidade");

                entity.HasIndex(e => e.CidaNome, "IX_tabCidade_cidaNome");

                entity.Property(e => e.CidaId)
                    .ValueGeneratedNever()
                    .HasColumnName("cidaId");

                entity.Property(e => e.CidaNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cidaNome");

                entity.Property(e => e.CidaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cidaUF")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TabConfiguraPortal>(entity =>
            {
                entity.HasKey(e => e.ConfId);

                entity.ToTable("tabConfiguraPortal");

                entity.HasIndex(e => e.AssuId, "IX_tabConfiguraPortal_assuId");

                entity.HasIndex(e => e.UnidId, "IX_tabConfiguraPortal_unidId");

                entity.Property(e => e.ConfId)
                    .ValueGeneratedNever()
                    .HasColumnName("confId");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.ConfGerarTaxa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("confGerarTaxa")
                    .IsFixedLength();

                entity.Property(e => e.ConfValorTaxa)
                    .HasColumnType("money")
                    .HasColumnName("confValorTaxa");

                entity.Property(e => e.UnidId).HasColumnName("unidId");
            });

            modelBuilder.Entity<TabDocumentoTipo>(entity =>
            {
                entity.HasKey(e => e.TipoDocId);

                entity.ToTable("tabDocumentoTipo");

                entity.HasIndex(e => e.TipoDocNome, "IX_tabDocumentoTipo_tipoDocNome");

                entity.Property(e => e.TipoDocId)
                    .ValueGeneratedNever()
                    .HasColumnName("tipoDocId");

                entity.Property(e => e.Bnmodelo).HasColumnName("bnmodelo");

                entity.Property(e => e.Contenttype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("contenttype");

                entity.Property(e => e.Flmultiplosarquivos)
                    .HasColumnName("flmultiplosarquivos")
                    .HasComment("Indica se pode ser enviado mais de uma vez o mesmo arquivo para o documento.");

                entity.Property(e => e.Nmarquivo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmarquivo");

                entity.Property(e => e.TipoDocFlAtivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocFlAtivo")
                    .HasDefaultValueSql("('Sim')")
                    .IsFixedLength();

                entity.Property(e => e.TipoDocNome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocNome");
            });

            modelBuilder.Entity<TabDocumentoTipoAssunto>(entity =>
            {
                entity.HasKey(e => new { e.TipoDocId, e.AssuId });

                entity.ToTable("tabDocumentoTipoAssunto");

                entity.Property(e => e.TipoDocId).HasColumnName("tipoDocId");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.DtasDescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dtasDescricao");

                entity.Property(e => e.DtasTipoDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dtasTipoDocumento");

                entity.Property(e => e.IsDocObrigatorio)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("isDocObrigatorio")
                    .HasDefaultValueSql("('Sim')")
                    .IsFixedLength();

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabDocumentoTipoAssuntos)
                    .HasForeignKey(d => d.AssuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabDocumentoTipoAssunto_tabAssunto");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.TabDocumentoTipoAssuntos)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabDocumentoTipoAssunto_tabDocumentoTipo");
            });

            modelBuilder.Entity<TabFuncionario>(entity =>
            {
                entity.HasKey(e => e.FuncId);

                entity.ToTable("tabFuncionario");

                entity.HasIndex(e => e.FuncMatricula, "IX_tabFuncionario_funcMatricula");

                entity.HasIndex(e => e.FuncNome, "IX_tabFuncionario_funcNome");

                entity.HasIndex(e => e.FuncUsuario, "IX_tabFuncionario_funcUsuario_inc_funcNome");

                entity.HasIndex(e => e.UnidId, "IX_tabFuncionario_unidId");

                entity.Property(e => e.FuncId)
                    .ValueGeneratedNever()
                    .HasColumnName("funcId");

                entity.Property(e => e.FuncAlowAlter).HasColumnName("funcAlowAlter");

                entity.Property(e => e.FuncAlowDespachar).HasColumnName("funcAlowDespachar");

                entity.Property(e => e.FuncAtivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("funcAtivo")
                    .IsFixedLength();

                entity.Property(e => e.FuncCargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("funcCargo");

                entity.Property(e => e.FuncEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funcEmail");

                entity.Property(e => e.FuncFuncao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("funcFuncao");

                entity.Property(e => e.FuncMatricula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("funcMatricula");

                entity.Property(e => e.FuncNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("funcNome");

                entity.Property(e => e.FuncPerfil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funcPerfil");

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

                entity.Property(e => e.FuncSenha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("funcSenha");

                entity.Property(e => e.FuncSenhaDespacho)
                    .HasMaxLength(50)
                    .HasColumnName("funcSenhaDespacho");

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

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.Unid)
                    .WithMany(p => p.TabFuncionarios)
                    .HasForeignKey(d => d.UnidId)
                    .HasConstraintName("FK_tabFuncionario_tabUnidade");
            });

            modelBuilder.Entity<TabLogTransferenciaCadastro>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tabLogTransferenciaCadastro");

                entity.Property(e => e.LogId)
                    .ValueGeneratedNever()
                    .HasColumnName("logId");

                entity.Property(e => e.DataExclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dataExclusao");

                entity.Property(e => e.DeletarOrigem)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("deletarOrigem")
                    .IsFixedLength();

                entity.Property(e => e.DestinoId).HasColumnName("destinoId");

                entity.Property(e => e.OrigemId).HasColumnName("origemId");

                entity.Property(e => e.RegistroDestino)
                    .HasColumnType("text")
                    .HasColumnName("registroDestino");

                entity.Property(e => e.RegistroOrigem)
                    .HasColumnType("text")
                    .HasColumnName("registroOrigem");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tabela");

                entity.Property(e => e.TabelasAfetadas)
                    .HasColumnType("text")
                    .HasColumnName("tabelasAfetadas");

                entity.Property(e => e.TransferenciaDe)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("transferenciaDe");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<TabMensagem>(entity =>
            {
                entity.HasKey(e => e.MensId);

                entity.ToTable("tabMensagem");

                entity.HasIndex(e => e.FuncId, "IX_tabMensagem_funcId");

                entity.Property(e => e.MensId)
                    .ValueGeneratedNever()
                    .HasColumnName("mensId");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.MensData)
                    .HasColumnType("datetime")
                    .HasColumnName("mensData");

                entity.Property(e => e.MensFiltroDestino)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mensFiltroDestino");

                entity.Property(e => e.MensMensagem)
                    .IsUnicode(false)
                    .HasColumnName("mensMensagem");

                entity.Property(e => e.MensStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mensStatus")
                    .IsFixedLength();

                entity.Property(e => e.MensTitulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mensTitulo");

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.TabMensagems)
                    .HasForeignKey(d => d.FuncId)
                    .HasConstraintName("FK_tabMensagem_tabFuncionario");
            });

            modelBuilder.Entity<TabMensagemDestino>(entity =>
            {
                entity.HasKey(e => new { e.MensId, e.FuncId });

                entity.ToTable("tabMensagemDestino");

                entity.Property(e => e.MensId).HasColumnName("mensId");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.MedeData)
                    .HasColumnType("datetime")
                    .HasColumnName("medeData");

                entity.Property(e => e.MedeStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("medeStatus")
                    .IsFixedLength();

                entity.HasOne(d => d.Func)
                    .WithMany(p => p.TabMensagemDestinos)
                    .HasForeignKey(d => d.FuncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabMensagemDestino_tabFuncionario");

                entity.HasOne(d => d.Mens)
                    .WithMany(p => p.TabMensagemDestinos)
                    .HasForeignKey(d => d.MensId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabMensagemDestino_tabMensagem");
            });

            modelBuilder.Entity<TabMensagemRespostum>(entity =>
            {
                entity.HasKey(e => e.RespId);

                entity.ToTable("tabMensagemResposta");

                entity.Property(e => e.RespId)
                    .ValueGeneratedNever()
                    .HasColumnName("respId");

                entity.Property(e => e.FuncId).HasColumnName("funcId");

                entity.Property(e => e.MensId).HasColumnName("mensId");

                entity.Property(e => e.RespData)
                    .HasColumnType("datetime")
                    .HasColumnName("respData");

                entity.Property(e => e.RespDescricao)
                    .IsUnicode(false)
                    .HasColumnName("respDescricao");

                entity.HasOne(d => d.TabMensagemDestino)
                    .WithMany(p => p.TabMensagemResposta)
                    .HasForeignKey(d => new { d.MensId, d.FuncId })
                    .HasConstraintName("FK_tabMensagemResposta_tabMensagemDestino");

                entity.HasMany(d => d.Anes)
                    .WithMany(p => p.Resps)
                    .UsingEntity<Dictionary<string, object>>(
                        "TabMensagemRespostaAnexo",
                        l => l.HasOne<TabAnexo1>().WithMany().HasForeignKey("AneId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabMensagemRespostaAnexo_tabAnexos"),
                        r => r.HasOne<TabMensagemRespostum>().WithMany().HasForeignKey("RespId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tabMensagemRespostaAnexo_tabMensagemResposta"),
                        j =>
                        {
                            j.HasKey("RespId", "AneId");

                            j.ToTable("tabMensagemRespostaAnexo");

                            j.IndexerProperty<int>("RespId").HasColumnName("respId");

                            j.IndexerProperty<int>("AneId").HasColumnName("aneId");
                        });
            });

            modelBuilder.Entity<TabModelo>(entity =>
            {
                entity.HasKey(e => e.ModeId);

                entity.ToTable("tabModelo");

                entity.HasIndex(e => e.ModeNome, "IX_tabModelo_modeNome");

                entity.Property(e => e.ModeId)
                    .ValueGeneratedNever()
                    .HasColumnName("modeId");

                entity.Property(e => e.ModeDescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("modeDescricao");

                entity.Property(e => e.ModeModelo)
                    .HasColumnType("text")
                    .HasColumnName("modeModelo");

                entity.Property(e => e.ModeNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modeNome");

                entity.Property(e => e.ModeVersao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modeVersao");
            });

            modelBuilder.Entity<TabModeloAssunto>(entity =>
            {
                entity.HasKey(e => new { e.ModeId, e.AssuId });

                entity.ToTable("tabModeloAssunto");

                entity.Property(e => e.ModeId).HasColumnName("modeId");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.MoasDescricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("moasDescricao");

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabModeloAssuntos)
                    .HasForeignKey(d => d.AssuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabModeloAssunto_tabAssunto");

                entity.HasOne(d => d.Mode)
                    .WithMany(p => p.TabModeloAssuntos)
                    .HasForeignKey(d => d.ModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabModeloAssunto_tabModelo");
            });

            modelBuilder.Entity<TabMovimento>(entity =>
            {
                entity.HasKey(e => e.MoviId);

                entity.ToTable("tabMovimento");

                entity.HasIndex(e => e.FuncDespachou, "IX_tabMovimento_Func_Despachou");

                entity.HasIndex(e => e.FuncPrivado, "IX_tabMovimento_Func_Privado");

                entity.HasIndex(e => e.FuncRecebeu, "IX_tabMovimento_Func_Recebeu");

                entity.HasIndex(e => new { e.MoviFuncExcluiu, e.ProcId, e.MoviId, e.MoviNulo, e.UnidId, e.MoviDespachado, e.MoviRecebido, e.FuncPrivado }, "IX_tabMovimento_moviFuncExcluiu_procId_moviId_moviNulo_unidId_moviDespachado_moviRecebido_funcPrivado");

                entity.HasIndex(e => new { e.MoviNulo, e.MoviFuncExcluiu }, "IX_tabMovimento_moviNulo_moviFuncExcluiu_inc_movId_procId");

                entity.HasIndex(e => e.ProcId, "IX_tabMovimento_procId");

                entity.HasIndex(e => e.UnidId, "IX_tabMovimento_unidId");

                entity.HasIndex(e => new { e.UnidId, e.MoviRecebido, e.MoviDespachado }, "IX_tabMovimento_unidId_moviRecebido_moviDespachado");

                entity.HasIndex(e => new { e.UnidId, e.ProcId, e.MoviId, e.MoviFuncExcluiu, e.MoviNulo, e.MoviDespachado, e.MoviRecebido, e.FuncPrivado }, "IX_tabMovimento_unidId_procId_moviId_moviFuncExcluiu_moviNulo_moviDespachado_moviRecebido_funcPrivado");

                entity.HasIndex(e => new { e.ProcId, e.MoviId, e.MoviNulo }, "_dta_index_tabMovimento_5_446624634__K3_K1_K13");

                entity.HasIndex(e => new { e.ProcId, e.MoviId, e.UnidId }, "_dta_index_tabMovimento_5_446624634__K3_K1_K4_2_5_6_8");

                entity.Property(e => e.MoviId)
                    .ValueGeneratedNever()
                    .HasColumnName("moviId");

                entity.Property(e => e.Dtassinatura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtassinatura");

                entity.Property(e => e.FuncDespachou).HasColumnName("funcDespachou");

                entity.Property(e => e.FuncPrivado).HasColumnName("funcPrivado");

                entity.Property(e => e.FuncRecebeu).HasColumnName("funcRecebeu");

                entity.Property(e => e.MoviData)
                    .HasColumnType("datetime")
                    .HasColumnName("moviData");

                entity.Property(e => e.MoviDataExcluido)
                    .HasColumnType("datetime")
                    .HasColumnName("moviDataExcluido");

                entity.Property(e => e.MoviDespachado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("moviDespachado")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.MoviFuncExcluiu).HasColumnName("moviFuncExcluiu");

                entity.Property(e => e.MoviIdAnterior).HasColumnName("moviIdAnterior");

                entity.Property(e => e.MoviNulo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("moviNulo")
                    .IsFixedLength();

                entity.Property(e => e.MoviParecer)
                    .IsUnicode(false)
                    .HasColumnName("moviParecer");

                entity.Property(e => e.MoviParecerExcluiu)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("moviParecerExcluiu");

                entity.Property(e => e.MoviRecebido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("moviRecebido")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.MoviRecebidoData)
                    .HasColumnType("datetime")
                    .HasColumnName("moviRecebidoData");

                entity.Property(e => e.MoviTipoAcesso)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("moviTipoAcesso")
                    .IsFixedLength()
                    .HasComment("(Público, Privado)");

                entity.Property(e => e.NrPaginas).HasColumnName("nrPaginas");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.FuncDespachouNavigation)
                    .WithMany(p => p.TabMovimentoFuncDespachouNavigations)
                    .HasForeignKey(d => d.FuncDespachou)
                    .HasConstraintName("FK_tabMovimento_tabFuncionario1");

                entity.HasOne(d => d.FuncRecebeuNavigation)
                    .WithMany(p => p.TabMovimentoFuncRecebeuNavigations)
                    .HasForeignKey(d => d.FuncRecebeu)
                    .HasConstraintName("FK_tabMovimento_tabFuncionario");

                entity.HasOne(d => d.MoviIdAnteriorNavigation)
                    .WithMany(p => p.InverseMoviIdAnteriorNavigation)
                    .HasForeignKey(d => d.MoviIdAnterior)
                    .HasConstraintName("FK_tabMovimento_tabMovimento");

                entity.HasOne(d => d.Proc)
                    .WithMany(p => p.TabMovimentos)
                    .HasForeignKey(d => d.ProcId)
                    .HasConstraintName("FK_tabMovimento_tabProcesso");

                entity.HasOne(d => d.Unid)
                    .WithMany(p => p.TabMovimentos)
                    .HasForeignKey(d => d.UnidId)
                    .HasConstraintName("FK_tabMovimento_tabUnidade");
            });

            modelBuilder.Entity<TabMovimentoParecer>(entity =>
            {
                entity.HasKey(e => e.MovParecerId);

                entity.ToTable("tabMovimentoParecer");

                entity.Property(e => e.MovParecerId)
                    .ValueGeneratedNever()
                    .HasColumnName("movParecerId");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsParcer)
                    .IsUnicode(false)
                    .HasColumnName("dsParcer");

                entity.Property(e => e.DtParecer)
                    .HasColumnType("datetime")
                    .HasColumnName("dtParecer");

                entity.Property(e => e.FuncPrivado).HasColumnName("funcPrivado");

                entity.Property(e => e.MoviId).HasColumnName("moviId");

                entity.Property(e => e.MoviTipoAcesso)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("moviTipoAcesso")
                    .IsFixedLength()
                    .HasComment("(Público, Privado)");

                entity.Property(e => e.UnidId).HasColumnName("unidId");
            });

            modelBuilder.Entity<TabPessoa>(entity =>
            {
                entity.HasKey(e => e.PessId)
                    .HasName("PK_tabRequerente");

                entity.ToTable("tabPessoa");

                entity.HasIndex(e => e.CidaId, "IX_tabPessoa_cidaId");

                entity.HasIndex(e => e.PessCpfcnpj, "IX_tabRequerente_requCPFCNPJ");

                entity.HasIndex(e => e.PessNome, "IX_tabRequerente_requNome");

                entity.HasIndex(e => e.PessId, "_dta_index_tabPessoa_5_1134627085__K1_3");

                entity.Property(e => e.PessId)
                    .ValueGeneratedNever()
                    .HasColumnName("pessId");

                entity.Property(e => e.CidaId).HasColumnName("cidaId");

                entity.Property(e => e.CidaOrigemId).HasColumnName("cidaOrigemId");

                entity.Property(e => e.ConId).HasColumnName("ConID");

                entity.Property(e => e.PessBairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessBairro");

                entity.Property(e => e.PessCep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessCEP");

                entity.Property(e => e.PessComplemento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessComplemento");

                entity.Property(e => e.PessCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("pessCPFCNPJ");

                entity.Property(e => e.PessDataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("pessDataNascimento");

                entity.Property(e => e.PessEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessEmail");

                entity.Property(e => e.PessEstadoCivil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pessEstadoCivil");

                entity.Property(e => e.PessFone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pessFone");

                entity.Property(e => e.PessLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessLogradouro");

                entity.Property(e => e.PessNome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pessNome");

                entity.Property(e => e.PessNomeMae)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessNomeMae");

                entity.Property(e => e.PessNumero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessNumero");

                entity.Property(e => e.PessProfissao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pessProfissao");

                entity.Property(e => e.PessRg)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pessRG");

                entity.Property(e => e.PessTipo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessTipo")
                    .IsFixedLength();

                entity.Property(e => e.PessTipoLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessTipoLogradouro");

                entity.Property(e => e.PessTituloEleitor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pessTituloEleitor");

                entity.HasOne(d => d.Cida)
                    .WithMany(p => p.TabPessoas)
                    .HasForeignKey(d => d.CidaId)
                    .HasConstraintName("FK_tabRequerente_tabCidade");
            });

            modelBuilder.Entity<TabPrioridade>(entity =>
            {
                entity.HasKey(e => e.PrioId);

                entity.ToTable("tabPrioridade");

                entity.HasIndex(e => e.PrioNome, "IX_tabPrioridade_prioNome");

                entity.Property(e => e.PrioId).HasColumnName("prioId");

                entity.Property(e => e.PrioCor)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("prioCor")
                    .IsFixedLength();

                entity.Property(e => e.PrioNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prioNome");

                entity.Property(e => e.PrioPadrao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("prioPadrao")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TabProcesso>(entity =>
            {
                entity.HasKey(e => e.ProcId);

                entity.ToTable("tabProcesso");

                entity.HasIndex(e => e.AssuId, "IX_tabProcesso_assuId");

                entity.HasIndex(e => new { e.AssuId, e.IdSolicitacao }, "IX_tabProcesso_assuId_idSolicitacao");

                entity.HasIndex(e => new { e.AssuId, e.ProcData }, "IX_tabProcesso_assuId_procData");

                entity.HasIndex(e => e.PrioId, "IX_tabProcesso_prioId");

                entity.HasIndex(e => new { e.ProcAno, e.AssuId }, "IX_tabProcesso_procAno_assuId");

                entity.HasIndex(e => new { e.ProcAno, e.AssuId, e.ProcStatus }, "IX_tabProcesso_procAno_assuId_procStatus");

                entity.HasIndex(e => new { e.ProcAno, e.ProcData, e.AssuId }, "IX_tabProcesso_procAno_procData_assuId");

                entity.HasIndex(e => e.ProcData, "IX_tabProcesso_procData");

                entity.HasIndex(e => new { e.ProcId, e.ProcStatus, e.PrioId, e.AssuId, e.PessId }, "IX_tabProcesso_procId_procStatus_prioId_assuId_pessId");

                entity.HasIndex(e => new { e.ProcSequencia, e.ProcStatus }, "IX_tabProcesso_procSequencia_procStatus");

                entity.HasIndex(e => e.PessId, "IX_tabProcesso_requId");

                entity.HasIndex(e => new { e.ProcId, e.ProcStatus, e.PrioId, e.AssuId, e.PessId }, "_dta_index_tabProcesso_5_1282103608__K1_K10_K9_K5_K7_2_3_4_6");

                entity.Property(e => e.ProcId)
                    .ValueGeneratedNever()
                    .HasColumnName("procId");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.BarrId).HasColumnName("barrId");

                entity.Property(e => e.Dslinkpublico)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("dslinkpublico");

                entity.Property(e => e.IdSolicitacao).HasColumnName("idSolicitacao");

                entity.Property(e => e.NrPaginas).HasColumnName("nrPaginas");

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.PrioId).HasColumnName("prioId");

                entity.Property(e => e.ProcAno).HasColumnName("procAno");

                entity.Property(e => e.ProcComplemento)
                    .IsUnicode(false)
                    .HasColumnName("procComplemento");

                entity.Property(e => e.ProcData)
                    .HasColumnType("datetime")
                    .HasColumnName("procData");

                entity.Property(e => e.ProcPublicoWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("procPublicoWeb")
                    .IsFixedLength();

                entity.Property(e => e.ProcSequencia).HasColumnName("procSequencia");

                entity.Property(e => e.ProcStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("procStatus")
                    .IsFixedLength()
                    .HasComment("Contem o status do processo\r\nTR -> Tramite\r\nTI -> Tramite Indeferido\r\nTD -> Tramite Deferido\r\nAR -> Arquivado\r\nAI -> Arquivado Indeferido\r\nAD -> Arquivado Deferido\r\nJP -> Juntado por apensação\r\nJX -> Juntado por anexação\r\n");

                entity.Property(e => e.ProcTempoEstimado).HasColumnName("procTempoEstimado");

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabProcessos)
                    .HasForeignKey(d => d.AssuId)
                    .HasConstraintName("FK_tabProcesso_tabAssunto");

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabProcessos)
                    .HasForeignKey(d => d.PessId)
                    .HasConstraintName("FK_tabProcesso_tabRequerente");

                entity.HasOne(d => d.Prio)
                    .WithMany(p => p.TabProcessos)
                    .HasForeignKey(d => d.PrioId)
                    .HasConstraintName("FK_tabProcesso_tabPrioridade");
            });

            modelBuilder.Entity<TabProcessoInteressado>(entity =>
            {
                entity.HasKey(e => e.InteId);

                entity.ToTable("tabProcessoInteressado");

                entity.HasIndex(e => e.PessId, "IX_tabProcessoInteressado_pessId");

                entity.HasIndex(e => e.ProcId, "IX_tabProcessoInteressado_procId");

                entity.Property(e => e.InteId)
                    .ValueGeneratedNever()
                    .HasColumnName("inteId");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabProcessoInteressados)
                    .HasForeignKey(d => d.PessId)
                    .HasConstraintName("FK_tabProcessoInteressado_tabPessoa");

                entity.HasOne(d => d.Proc)
                    .WithMany(p => p.TabProcessoInteressados)
                    .HasForeignKey(d => d.ProcId)
                    .HasConstraintName("FK_tabProcessoInteressado_tabProcesso");
            });

            modelBuilder.Entity<TabProcessoNotificaco>(entity =>
            {
                entity.HasKey(e => e.ProcNotificacaoId);

                entity.ToTable("tabProcessoNotificacoes");

                entity.Property(e => e.ProcNotificacaoId)
                    .ValueGeneratedNever()
                    .HasColumnName("procNotificacaoId");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ativo")
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.HasOne(d => d.Proc)
                    .WithMany(p => p.TabProcessoNotificacos)
                    .HasForeignKey(d => d.ProcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabProcessoNotificacoes_tabProcesso");
            });

            modelBuilder.Entity<TabProcessoStatus>(entity =>
            {
                entity.HasKey(e => e.ProcStatusSigla);

                entity.ToTable("tabProcessoStatus");

                entity.Property(e => e.ProcStatusSigla)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("procStatusSigla")
                    .IsFixedLength();

                entity.Property(e => e.ProcStatusNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("procStatusNome");
            });

            modelBuilder.Entity<TabProcessoVinculo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabProcessoVinculo");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dsStatus")
                    .IsFixedLength();

                entity.Property(e => e.DtVinculo)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVinculo");

                entity.Property(e => e.IdProcPrincipal).HasColumnName("idProcPrincipal");

                entity.Property(e => e.IdProcVinculado).HasColumnName("idProcVinculado");
            });

            modelBuilder.Entity<TabProtocolo>(entity =>
            {
                entity.HasKey(e => e.ProtId);

                entity.ToTable("tabProtocolo");

                entity.HasIndex(e => e.BarrId, "IX_tabProtocolo_barrId");

                entity.HasIndex(e => e.MoviId, "IX_tabProtocolo_moviId");

                entity.HasIndex(e => e.ProtSequencia, "IX_tabProtocolo_protSequencial");

                entity.HasIndex(e => e.PessId, "IX_tabProtocolo_requId");

                entity.HasIndex(e => e.TipoDocId, "IX_tabProtocolo_tipoDocId");

                entity.Property(e => e.ProtId)
                    .ValueGeneratedNever()
                    .HasColumnName("protId");

                entity.Property(e => e.BarrId).HasColumnName("barrId");

                entity.Property(e => e.MoviId).HasColumnName("moviId");

                entity.Property(e => e.PessId).HasColumnName("pessId");

                entity.Property(e => e.ProtAno).HasColumnName("protAno");

                entity.Property(e => e.ProtComentario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("protComentario");

                entity.Property(e => e.ProtContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("protContentType");

                entity.Property(e => e.ProtData)
                    .HasColumnType("datetime")
                    .HasColumnName("protData");

                entity.Property(e => e.ProtDocumento).HasColumnName("protDocumento");

                entity.Property(e => e.ProtNumeroFolhas).HasColumnName("protNumeroFolhas");

                entity.Property(e => e.ProtSequencia).HasColumnName("protSequencia");

                entity.Property(e => e.ProtTipoDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("protTipoDocumento");

                entity.Property(e => e.TipoDocId).HasColumnName("tipoDocId");

                entity.HasOne(d => d.Movi)
                    .WithMany(p => p.TabProtocolos)
                    .HasForeignKey(d => d.MoviId)
                    .HasConstraintName("FK_tabProtocolo_tabMovimento");

                entity.HasOne(d => d.Pess)
                    .WithMany(p => p.TabProtocolos)
                    .HasForeignKey(d => d.PessId)
                    .HasConstraintName("FK_tabProtocolo_tabRequerente");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.TabProtocolos)
                    .HasForeignKey(d => d.TipoDocId)
                    .HasConstraintName("FK_tabProtocolo_tabDocumentoTipo");
            });

            modelBuilder.Entity<TabRoteiro>(entity =>
            {
                entity.HasKey(e => e.RoteId);

                entity.ToTable("tabRoteiro");

                entity.HasIndex(e => e.AssuId, "IX_tabRoteiro_assuId");

                entity.HasIndex(e => e.UnidId, "IX_tabRoteiro_unidId");

                entity.Property(e => e.RoteId)
                    .ValueGeneratedNever()
                    .HasColumnName("roteId");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.RoteOrdem).HasColumnName("roteOrdem");

                entity.Property(e => e.RoteParecerPadrao)
                    .IsUnicode(false)
                    .HasColumnName("roteParecerPadrao");

                entity.Property(e => e.RoteTarefas)
                    .IsUnicode(false)
                    .HasColumnName("roteTarefas");

                entity.Property(e => e.RoteTempoEspecifico).HasColumnName("roteTempoEspecifico");

                entity.Property(e => e.RoteTempoEstimado).HasColumnName("roteTempoEstimado");

                entity.Property(e => e.UnidId).HasColumnName("unidId");

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabRoteiros)
                    .HasForeignKey(d => d.AssuId)
                    .HasConstraintName("FK_tabRoteiro_tabAssunto");

                entity.HasOne(d => d.Unid)
                    .WithMany(p => p.TabRoteiros)
                    .HasForeignKey(d => d.UnidId)
                    .HasConstraintName("FK_tabRoteiro_tabUnidade");
            });

            modelBuilder.Entity<TabTipoAgendaAnexo>(entity =>
            {
                entity.HasKey(e => e.IdAnexo);

                entity.ToTable("tabTipoAgendaAnexo");

                entity.Property(e => e.IdAnexo)
                    .ValueGeneratedNever()
                    .HasColumnName("idAnexo");

                entity.Property(e => e.NmAnexo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmAnexo");

                entity.Property(e => e.NmExtensao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmExtensao");

                entity.Property(e => e.ObjAnexo)
                    .HasColumnType("image")
                    .HasColumnName("objAnexo");

                entity.Property(e => e.TpAgId).HasColumnName("tpAgId");
            });

            modelBuilder.Entity<TabTipoAgendaDocumento>(entity =>
            {
                entity.HasKey(e => new { e.TipoDocId, e.TpAgId });

                entity.ToTable("tabTipoAgendaDocumento");

                entity.Property(e => e.TipoDocId).HasColumnName("tipoDocId");

                entity.Property(e => e.TpAgId).HasColumnName("tpAgId");
            });

            modelBuilder.Entity<TabTipoAgendum>(entity =>
            {
                entity.HasKey(e => e.TpAgId);

                entity.ToTable("tabTipoAgenda");

                entity.Property(e => e.TpAgId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpAgId");

                entity.Property(e => e.TpAgDtFinal)
                    .HasColumnType("datetime")
                    .HasColumnName("tpAgDtFinal");

                entity.Property(e => e.TpAgDtFinalAgendamento)
                    .HasColumnType("datetime")
                    .HasColumnName("tpAgDtFinalAgendamento");

                entity.Property(e => e.TpAgDtInicial)
                    .HasColumnType("datetime")
                    .HasColumnName("tpAgDtInicial");

                entity.Property(e => e.TpAgDtInicialAgendamento)
                    .HasColumnType("datetime")
                    .HasColumnName("tpAgDtInicialAgendamento");

                entity.Property(e => e.TpAgHrFimTarde)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tpAgHrFimTarde");

                entity.Property(e => e.TpAgHrInicioManha)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tpAgHrInicioManha");

                entity.Property(e => e.TpAgHrInicioTarde)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tpAgHrInicioTarde");

                entity.Property(e => e.TpAgMinIntervalo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tpAgMinIntervalo");

                entity.Property(e => e.TpAgNome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tpAgNome");

                entity.Property(e => e.TpAgQtdeGuiches).HasColumnName("tpAgQtdeGuiches");

                entity.Property(e => e.TpAgQtdeManha).HasColumnName("tpAgQtdeManha");

                entity.Property(e => e.TpAgQtdeTarde).HasColumnName("tpAgQtdeTarde");

                entity.Property(e => e.TpAgTexto)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("tpAgTexto");

                entity.Property(e => e.TpAghrFimManha)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("tpAghrFimManha");
            });

            modelBuilder.Entity<TabUnidade>(entity =>
            {
                entity.HasKey(e => e.UnidId);

                entity.ToTable("tabUnidade");

                entity.HasIndex(e => e.TipoUnidId, "IX_tabUnidade_tipoUnidId");

                entity.HasIndex(e => e.Unidhierarquia, "IX_tabUnidade_unidHierarquia");

                entity.HasIndex(e => e.UnidNome, "IX_tabUnidade_unidNome");

                entity.HasIndex(e => e.UnidSigla, "IX_tabUnidade_unidSigla");

                entity.Property(e => e.UnidId)
                    .ValueGeneratedNever()
                    .HasColumnName("unidId");

                entity.Property(e => e.Cidtbxulc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cidtbxulc");

                entity.Property(e => e.TipoUnidId).HasColumnName("tipoUnidId");

                entity.Property(e => e.UnidDescricao)
                    .IsUnicode(false)
                    .HasColumnName("unidDescricao");

                entity.Property(e => e.UnidFlAtivo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("unidFlAtivo")
                    .HasDefaultValueSql("('Sim')")
                    .IsFixedLength();

                entity.Property(e => e.UnidNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unidNome");

                entity.Property(e => e.UnidSigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unidSigla");

                entity.Property(e => e.Unidhierarquia).HasColumnName("unidhierarquia");

                entity.HasOne(d => d.TipoUnid)
                    .WithMany(p => p.TabUnidades)
                    .HasForeignKey(d => d.TipoUnidId)
                    .HasConstraintName("FK_tabUnidade_tabUnidadeTipo");

                entity.HasOne(d => d.UnidhierarquiaNavigation)
                    .WithMany(p => p.InverseUnidhierarquiaNavigation)
                    .HasForeignKey(d => d.Unidhierarquia)
                    .HasConstraintName("FK_tabUnidade_tabUnidade");
            });

            modelBuilder.Entity<TabUnidadeTipo>(entity =>
            {
                entity.HasKey(e => e.TipoUnidId);

                entity.ToTable("tabUnidadeTipo");

                entity.Property(e => e.TipoUnidId).HasColumnName("tipoUnidId");

                entity.Property(e => e.TipoUnidNivel).HasColumnName("tipoUnidNivel");

                entity.Property(e => e.TipoUnidNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tipoUnidNome");
            });

            modelBuilder.Entity<TabUsuarioAssunto>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.AssuId });

                entity.ToTable("tabUsuarioAssunto");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.HasOne(d => d.Assu)
                    .WithMany(p => p.TabUsuarioAssuntos)
                    .HasForeignKey(d => d.AssuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tabUsuarioAssunto_tabAssunto");
            });

            modelBuilder.Entity<Tabteste>(entity =>
            {
                entity.ToTable("tabteste");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<TbParametrosProcesso>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbParametrosProcesso");

                entity.Property(e => e.IdAssunto).HasColumnName("idAssunto");

                entity.Property(e => e.IdParametro).HasColumnName("idParametro");

                entity.Property(e => e.IdPrioridade).HasColumnName("idPrioridade");

                entity.Property(e => e.IdUnidadePadrao).HasColumnName("idUnidadePadrao");

                entity.Property(e => e.NmParametro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmParametro");
            });

            modelBuilder.Entity<Tbgrupo>(entity =>
            {
                entity.HasKey(e => e.Idgrupo);

                entity.ToTable("tbgrupo");

                entity.Property(e => e.Idgrupo)
                    .ValueGeneratedNever()
                    .HasColumnName("idgrupo");

                entity.Property(e => e.Nmgrupo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmgrupo");
            });

            modelBuilder.Entity<Tbparametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbparametro");

                entity.Property(e => e.Dsparametro)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("dsparametro");

                entity.Property(e => e.Dsvalor)
                    .HasMaxLength(4098)
                    .IsUnicode(false)
                    .HasColumnName("dsvalor");

                entity.Property(e => e.Fladmin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fladmin")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Flvalores)
                    .IsUnicode(false)
                    .HasColumnName("flvalores");

                entity.Property(e => e.Nmparametro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmparametro");
            });

            modelBuilder.Entity<Tbprocessoalertaavisado>(entity =>
            {
                entity.HasKey(e => new { e.ProcId, e.MoviId, e.Idusuario });

                entity.ToTable("tbprocessoalertaavisado");

                entity.Property(e => e.ProcId).HasColumnName("procID");

                entity.Property(e => e.MoviId).HasColumnName("moviID");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Dtleitura)
                    .HasColumnType("datetime")
                    .HasColumnName("dtleitura");
            });

            modelBuilder.Entity<Tbsubgrupo>(entity =>
            {
                entity.HasKey(e => e.Idsubgrupo);

                entity.ToTable("tbsubgrupo");

                entity.Property(e => e.Idsubgrupo)
                    .ValueGeneratedNever()
                    .HasColumnName("idsubgrupo");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.Property(e => e.Nmsubgrupo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nmsubgrupo");
            });

            modelBuilder.Entity<Tbunidadeusuario>(entity =>
            {
                entity.HasKey(e => e.Idunidadeusuario);

                entity.ToTable("tbunidadeusuario");

                entity.Property(e => e.Idunidadeusuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idunidadeusuario");

                entity.Property(e => e.Dtexclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtexclusao");

                entity.Property(e => e.Dtinclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtinclusao");

                entity.Property(e => e.Flativo).HasColumnName("flativo");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Idusuarioexclusao).HasColumnName("idusuarioexclusao");

                entity.Property(e => e.Idusuarioinclusao).HasColumnName("idusuarioinclusao");

                entity.Property(e => e.UnidId).HasColumnName("unidID");
            });

            modelBuilder.Entity<ViewProtocoloweb2do>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Protocoloweb2do");

                entity.Property(e => e.AssuNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assuNome");

                entity.Property(e => e.CidaNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cidaNome");

                entity.Property(e => e.CidaUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cidaUF")
                    .IsFixedLength();

                entity.Property(e => e.PessBairro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessBairro");

                entity.Property(e => e.PessCep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pessCEP");

                entity.Property(e => e.PessCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("pessCPFCNPJ");

                entity.Property(e => e.PessFone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pessFone");

                entity.Property(e => e.PessLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessLogradouro");

                entity.Property(e => e.PessNome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pessNome");

                entity.Property(e => e.PessTipoLogradouro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pessTipoLogradouro");

                entity.Property(e => e.ProcAno).HasColumnName("procAno");

                entity.Property(e => e.ProcComplemento)
                    .IsUnicode(false)
                    .HasColumnName("procComplemento");

                entity.Property(e => e.ProcData)
                    .HasColumnType("datetime")
                    .HasColumnName("procData");

                entity.Property(e => e.ProcId).HasColumnName("procId");

                entity.Property(e => e.ProcSequencia).HasColumnName("procSequencia");
            });

            modelBuilder.Entity<VwDashBoardProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDashBoardProcess");

                entity.Property(e => e.Assunto)
                    .HasMaxLength(111)
                    .IsUnicode(false);

                entity.Property(e => e.DataEntrada).HasColumnType("datetime");

                entity.Property(e => e.DespachadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnviadoPara)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdProcesso).HasColumnName("idProcesso");

                entity.Property(e => e.RecebidoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Requerente)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoMovimento).HasColumnType("datetime");

                entity.Property(e => e.UnidadeAtual)
                    .HasMaxLength(111)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwProcessosPautum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ProcessosPauta");

                entity.Property(e => e.AssuId).HasColumnName("assuId");

                entity.Property(e => e.AssuNome)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assuNome");

                entity.Property(e => e.PessCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("pessCPFCNPJ");

                entity.Property(e => e.PessNome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pessNome");

                entity.Property(e => e.ProcAno).HasColumnName("procAno");

                entity.Property(e => e.ProcComplemento)
                    .IsUnicode(false)
                    .HasColumnName("procComplemento");

                entity.Property(e => e.ProcData)
                    .HasColumnType("datetime")
                    .HasColumnName("procData");

                entity.Property(e => e.ProcSequencia).HasColumnName("procSequencia");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
