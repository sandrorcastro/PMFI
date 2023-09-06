using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class GIIGSystemDBContext : DbContext
    {
        public GIIGSystemDBContext()
        {
        }

        public GIIGSystemDBContext(DbContextOptions<GIIGSystemDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbGerAgendaTarefa> TbGerAgendaTarefas { get; set; } = null!;
        public virtual DbSet<TbGerAplicativo> TbGerAplicativos { get; set; } = null!;
        public virtual DbSet<TbSegChavesPublica> TbSegChavesPublicas { get; set; } = null!;
        public virtual DbSet<TbSegEmpresasGoverno> TbSegEmpresasGovernos { get; set; } = null!;
        public virtual DbSet<TbSegFormulario> TbSegFormularios { get; set; } = null!;
        public virtual DbSet<TbSegFormularioTipo> TbSegFormularioTipos { get; set; } = null!;
        public virtual DbSet<TbSegFormulariosComentario> TbSegFormulariosComentarios { get; set; } = null!;
        public virtual DbSet<TbSegGruposServico> TbSegGruposServicos { get; set; } = null!;
        public virtual DbSet<TbSegLogAcesso> TbSegLogAcessos { get; set; } = null!;
        public virtual DbSet<TbSegLogAutenticacao> TbSegLogAutenticacaos { get; set; } = null!;
        public virtual DbSet<TbSegModulo> TbSegModulos { get; set; } = null!;
        public virtual DbSet<TbSegModulosGruposServico> TbSegModulosGruposServicos { get; set; } = null!;
        public virtual DbSet<TbSegModulosPortal> TbSegModulosPortals { get; set; } = null!;
        public virtual DbSet<TbSegPerfisdeAcesso> TbSegPerfisdeAcessos { get; set; } = null!;
        public virtual DbSet<TbSegPerfisdeAcessoFormulario> TbSegPerfisdeAcessoFormularios { get; set; } = null!;
        public virtual DbSet<TbSegUsuario> TbSegUsuarios { get; set; } = null!;
        public virtual DbSet<TbSegUsuariosEmpresasModulo> TbSegUsuariosEmpresasModulos { get; set; } = null!;
        public virtual DbSet<TbSegUsuariosParametro> TbSegUsuariosParametros { get; set; } = null!;
        public virtual DbSet<TbSysFormulariosAtalho> TbSysFormulariosAtalhos { get; set; } = null!;
        public virtual DbSet<TbSysLogDado> TbSysLogDados { get; set; } = null!;
        public virtual DbSet<TbSysLogDadosTemp> TbSysLogDadosTemps { get; set; } = null!;
        public virtual DbSet<TbSysModulosAtualizaco> TbSysModulosAtualizacoes { get; set; } = null!;
        public virtual DbSet<TbSysPaginasEstado> TbSysPaginasEstados { get; set; } = null!;
        public virtual DbSet<TbSysParametro> TbSysParametros { get; set; } = null!;
        public virtual DbSet<TbSysRelatoriosChamada> TbSysRelatoriosChamadas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=GIIGSystemDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbGerAgendaTarefa>(entity =>
            {
                entity.HasKey(e => e.IdTarefa);

                entity.ToTable("tbGerAgendaTarefas");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.DsTarefa)
                    .IsUnicode(false)
                    .HasColumnName("dsTarefa");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTermino");

                entity.Property(e => e.NmTarefa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmTarefa");
            });

            modelBuilder.Entity<TbGerAplicativo>(entity =>
            {
                entity.HasKey(e => e.IdAplicativo);

                entity.ToTable("tbGerAplicativos");

                entity.Property(e => e.DsLink)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLink");

                entity.Property(e => e.DsModulo)
                    .HasMaxLength(150)
                    .HasColumnName("dsModulo");

                entity.Property(e => e.DsTitulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTitulo");

                entity.Property(e => e.NrHeigth).HasColumnName("nrHeigth");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbGerAplicativos)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK_tbGerAplicativos_tbSegModulos");

                entity.HasMany(d => d.DsLogins)
                    .WithMany(p => p.IdAplicativos)
                    .UsingEntity<Dictionary<string, object>>(
                        "TbGerAplicativosUsuario",
                        l => l.HasOne<TbSegUsuario>().WithMany().HasForeignKey("DsLogin").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbGerAplicativosUsuarios_tbSegUsuarios"),
                        r => r.HasOne<TbGerAplicativo>().WithMany().HasForeignKey("IdAplicativo").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tbGerAplicativosUsuarios_tbGerAplicativos"),
                        j =>
                        {
                            j.HasKey("IdAplicativo", "DsLogin");

                            j.ToTable("tbGerAplicativosUsuarios");

                            j.IndexerProperty<string>("DsLogin").HasMaxLength(50).IsUnicode(false).HasColumnName("dsLogin");
                        });
            });

            modelBuilder.Entity<TbSegChavesPublica>(entity =>
            {
                entity.HasKey(e => e.IdChavePublica);

                entity.ToTable("tbSegChavesPublicas");

                entity.Property(e => e.IdChavePublica).HasColumnName("idChavePublica");

                entity.Property(e => e.DsChavePublica)
                    .IsUnicode(false)
                    .HasColumnName("dsChavePublica");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtCriacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCriacao");
            });

            modelBuilder.Entity<TbSegEmpresasGoverno>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("tbSegEmpresasGoverno");

                entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

                entity.Property(e => e.DsTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsTipo");

                entity.Property(e => e.NmEmpresa)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("nmEmpresa");

                entity.Property(e => e.NrCnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCNPJ")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbSegFormulario>(entity =>
            {
                entity.HasKey(e => e.IdForm);

                entity.ToTable("tbSegFormularios");

                entity.Property(e => e.IdForm).ValueGeneratedNever();

                entity.Property(e => e.DsEnderecoForm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsEnderecoForm");

                entity.Property(e => e.DsForm)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("dsForm");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.FlChecaPermissao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flChecaPermissao")
                    .IsFixedLength();

                entity.Property(e => e.FlEmManutencao)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flEmManutencao")
                    .IsFixedLength()
                    .HasComment("Indica se o formulário está em manutenção bloqueando o acesso a ele");

                entity.Property(e => e.NmArquivo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nmArquivo");

                entity.Property(e => e.NmForm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmForm");

                entity.HasOne(d => d.IdFormTipoNavigation)
                    .WithMany(p => p.TbSegFormularios)
                    .HasForeignKey(d => d.IdFormTipo)
                    .HasConstraintName("FK_tbSegFormularios_tbSegFormularioTipos");

                entity.HasOne(d => d.IdGrupoServicoNavigation)
                    .WithMany(p => p.TbSegFormularios)
                    .HasForeignKey(d => d.IdGrupoServico)
                    .HasConstraintName("FK_tbSegFormularios_tbSegGruposServicos");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbSegFormularios)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK_tbSegFormularios_tbSegModulos");
            });

            modelBuilder.Entity<TbSegFormularioTipo>(entity =>
            {
                entity.HasKey(e => e.IdFormTipo);

                entity.ToTable("tbSegFormularioTipos");

                entity.Property(e => e.NmFormTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmFormTipo");
            });

            modelBuilder.Entity<TbSegFormulariosComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentario);

                entity.ToTable("tbSegFormulariosComentarios");

                entity.Property(e => e.DsComentario)
                    .IsUnicode(false)
                    .HasColumnName("dsComentario");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsResposta)
                    .IsUnicode(false)
                    .HasColumnName("dsResposta");

                entity.Property(e => e.DtComentario)
                    .HasColumnType("datetime")
                    .HasColumnName("dtComentario");
            });

            modelBuilder.Entity<TbSegGruposServico>(entity =>
            {
                entity.HasKey(e => e.IdGrupoServico);

                entity.ToTable("tbSegGruposServicos");

                entity.Property(e => e.NmGrupoServico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmGrupoServico");
            });

            modelBuilder.Entity<TbSegLogAcesso>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbSegLogAcesso");

                entity.HasIndex(e => new { e.DtLogOut, e.IdLog, e.DsLogin }, "IX_dtLogOut_IdLog_dsLogin")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.DtLogOut, e.DtLogIn, e.DsLogin }, "IX_dtLogOut_dtLogIn_dsLogin")
                    .HasFillFactor(90);

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

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
            });

            modelBuilder.Entity<TbSegLogAutenticacao>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbSegLogAutenticacao");

                entity.HasIndex(e => new { e.DsLogin, e.DtOcorrencia }, "IX_tbSegLogAutenticacao")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DsLogin, "IX_tbSegLogAutenticacao_dsLogin_inc_dtOcorrencia_dsOcorrencia");

                entity.Property(e => e.DsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsIP");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

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
            });

            modelBuilder.Entity<TbSegModulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PK_tbSegModulo");

                entity.ToTable("tbSegModulos");

                entity.Property(e => e.DsModulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsModulo");

                entity.Property(e => e.FlMostrarLogin).HasColumnName("flMostrarLogin");

                entity.Property(e => e.NmModulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nmModulo");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbSegModulosGruposServico>(entity =>
            {
                entity.HasKey(e => new { e.IdModulo, e.IdGrupoServico });

                entity.ToTable("tbSegModulosGruposServico");
            });

            modelBuilder.Entity<TbSegModulosPortal>(entity =>
            {
                entity.HasKey(e => e.IdModulo);

                entity.ToTable("tbSegModulosPortal");

                entity.Property(e => e.IdModulo).ValueGeneratedNever();

                entity.Property(e => e.DsModulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsModulo");

                entity.Property(e => e.NmModulo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nmModulo");

                entity.Property(e => e.NrOrdem).HasColumnName("nrOrdem");
            });

            modelBuilder.Entity<TbSegPerfisdeAcesso>(entity =>
            {
                entity.HasKey(e => e.IdPerfilAcesso);

                entity.ToTable("tbSegPerfisdeAcesso");

                entity.Property(e => e.FlAdmin).HasColumnName("flAdmin");

                entity.Property(e => e.NmPerfilAcesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmPerfilAcesso");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbSegPerfisdeAcessos)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK_tbSegPerfisdeAcesso_tbSegModulos");
            });

            modelBuilder.Entity<TbSegPerfisdeAcessoFormulario>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfilAcesso, e.IdForm });

                entity.ToTable("tbSegPerfisdeAcessoFormularios");

                entity.Property(e => e.FlAlteracao).HasColumnName("flAlteracao");

                entity.Property(e => e.FlInclusao).HasColumnName("flInclusao");

                entity.Property(e => e.FlPermEspeciais).HasColumnName("flPermEspeciais");

                entity.Property(e => e.FlRemocao).HasColumnName("flRemocao");

                entity.HasOne(d => d.IdFormNavigation)
                    .WithMany(p => p.TbSegPerfisdeAcessoFormularios)
                    .HasForeignKey(d => d.IdForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegPerfisdeAcessoFormularios_tbSegFormularios");

                entity.HasOne(d => d.IdPerfilAcessoNavigation)
                    .WithMany(p => p.TbSegPerfisdeAcessoFormularios)
                    .HasForeignKey(d => d.IdPerfilAcesso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegPerfisdeAcessoFormularios_tbSegPerfilAcesso");
            });

            modelBuilder.Entity<TbSegUsuario>(entity =>
            {
                entity.HasKey(e => e.DsLogin)
                    .HasName("PK_tbSegUsuarios_1");

                entity.ToTable("tbSegUsuarios");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.BnSenha)
                    .HasMaxLength(50)
                    .HasColumnName("bnSenha");

                entity.Property(e => e.DsChavePublica)
                    .IsUnicode(false)
                    .HasColumnName("dsChavePublica");

                entity.Property(e => e.DsEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsEmail");

                entity.Property(e => e.DsFone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsFone");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DsSituacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dsSituacao");

                entity.Property(e => e.DtInativacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInativacao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtValidadeSenha)
                    .HasColumnType("datetime")
                    .HasColumnName("dtValidadeSenha");

                entity.Property(e => e.FlAdministrador)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flAdministrador")
                    .IsFixedLength()
                    .HasComment("Esse campo é utilizado para dar permissão automática para formulários cadastrados no sistema.");

                entity.Property(e => e.FlTipoInativo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flTipoInativo");

                entity.Property(e => e.NmUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmUsuario");

                entity.Property(e => e.NrCpfcnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("nrCPFCNPJ");

                entity.HasOne(d => d.IdEmpresaPadraoNavigation)
                    .WithMany(p => p.TbSegUsuarios)
                    .HasForeignKey(d => d.IdEmpresaPadrao)
                    .HasConstraintName("FK_tbSegUsuarios_tbSegEmpresaGoverno");
            });

            modelBuilder.Entity<TbSegUsuariosEmpresasModulo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.DsLogin, e.IdModulo, e.IdPerfilAcesso });

                entity.ToTable("tbSegUsuariosEmpresasModulo");

                entity.HasIndex(e => e.IdModulo, "IX_tbSegUsuariosEmpresasModulo_IdModulo");

                entity.HasIndex(e => e.DsLogin, "IX_tbSegUsuariosEmpresasModulo_dsLogin_inc_IdPerfilAcesso");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsLoginInclusao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLoginInclusao");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.DtVigenciaFim)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVigenciaFim");

                entity.Property(e => e.DtVigenciaIni)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVigenciaIni");

                entity.HasOne(d => d.DsLoginNavigation)
                    .WithMany(p => p.TbSegUsuariosEmpresasModulos)
                    .HasForeignKey(d => d.DsLogin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegUsuariosEmpresasModulo_tbSegUsuarios");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbSegUsuariosEmpresasModulos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegUsuariosEmpresasModulo_tbSegEmpresasGoverno");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.TbSegUsuariosEmpresasModulos)
                    .HasForeignKey(d => d.IdModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegUsuariosEmpresasModulo_tbSegModulos");

                entity.HasOne(d => d.IdPerfilAcessoNavigation)
                    .WithMany(p => p.TbSegUsuariosEmpresasModulos)
                    .HasForeignKey(d => d.IdPerfilAcesso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSegUsuariosEmpresasModulo_tbSegPerfilAcesso");
            });

            modelBuilder.Entity<TbSegUsuariosParametro>(entity =>
            {
                entity.HasKey(e => new { e.DsLogin, e.NmParametro });

                entity.ToTable("tbSegUsuariosParametros");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.NmParametro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmParametro");

                entity.Property(e => e.DsParametro)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("dsParametro");

                entity.Property(e => e.VlParametro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vlParametro");
            });

            modelBuilder.Entity<TbSysFormulariosAtalho>(entity =>
            {
                entity.HasKey(e => e.IdAtalho);

                entity.ToTable("tbSysFormulariosAtalhos");

                entity.Property(e => e.IdAtalho).ValueGeneratedNever();

                entity.Property(e => e.DsAccessKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsAccessKey");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");
            });

            modelBuilder.Entity<TbSysLogDado>(entity =>
            {
                entity.HasKey(e => e.IdLoDa);

                entity.ToTable("tbSysLogDados");

                entity.Property(e => e.DsEnderecoIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsEnderecoIP");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjetoOcorrencia)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetoOcorrencia");

                entity.Property(e => e.DsOperacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOperacao");

                entity.Property(e => e.DsTabelaAlias)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsTabelaAlias");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("dtOcorrencia");

                entity.Property(e => e.NmBanco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmBanco");

                entity.Property(e => e.NmTabela)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmTabela");
            });

            modelBuilder.Entity<TbSysLogDadosTemp>(entity =>
            {
                entity.HasKey(e => e.IdLoDa);

                entity.ToTable("tbSysLogDadosTemp");

                entity.Property(e => e.IdLoDa).ValueGeneratedNever();

                entity.Property(e => e.DsEnderecoIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsEnderecoIP");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DsObjetoOcorrencia)
                    .IsUnicode(false)
                    .HasColumnName("dsObjetoOcorrencia");

                entity.Property(e => e.DsOperacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dsOperacao");

                entity.Property(e => e.DsTabelaAlias)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsTabelaAlias");

                entity.Property(e => e.DtOcorrencia)
                    .HasColumnType("datetime")
                    .HasColumnName("dtOcorrencia");

                entity.Property(e => e.NmBanco)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmBanco");

                entity.Property(e => e.NmTabela)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nmTabela");
            });

            modelBuilder.Entity<TbSysModulosAtualizaco>(entity =>
            {
                entity.HasKey(e => e.IdAtualizacao);

                entity.ToTable("tbSysModulosAtualizacoes");

                entity.Property(e => e.DsLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dsLogin");

                entity.Property(e => e.DtAtualizacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAtualizacao");
            });

            modelBuilder.Entity<TbSysPaginasEstado>(entity =>
            {
                entity.HasKey(e => e.IdPage);

                entity.ToTable("tbSysPaginasEstados");

                entity.Property(e => e.IdPage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtAlteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAlteracao");

                entity.Property(e => e.VsState)
                    .IsUnicode(false)
                    .HasColumnName("vsState");
            });

            modelBuilder.Entity<TbSysParametro>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdParametro });

                entity.ToTable("tbSysParametros");

                entity.Property(e => e.IdSistema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdParametro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsParametro)
                    .IsUnicode(false)
                    .HasColumnName("dsParametro");

                entity.Property(e => e.DsRotina)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dsRotina");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.VlParametro)
                    .IsUnicode(false)
                    .HasColumnName("vlParametro");
            });

            modelBuilder.Entity<TbSysRelatoriosChamada>(entity =>
            {
                entity.HasKey(e => e.IdReport);

                entity.ToTable("tbSysRelatoriosChamadas");

                entity.Property(e => e.IdReport)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VlParameters)
                    .IsUnicode(false)
                    .HasColumnName("vlParameters");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
