﻿using Domain.Entities;
using Infra.EntityConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;
namespace Infra.Context
{
    public class ContextoAplicacao : IdentityDbContext<ApplicationUser, IdentityRole<long>, long> 
    //public class ContextoAplicacao : IdentityDbContext
    {
        public ContextoAplicacao(DbContextOptions<ContextoAplicacao> options): base(options){ }
     /*   public ContextoAplicacao CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextoAplicacao>();
            optionsBuilder.UseSqlServer("Data Source=SANDRO-ASPIRE-4\\SQLEXPRESS;Initial Catalog=SMF_Processo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new ContextoAplicacao(optionsBuilder.Options);
        }*/
     /*   private readonly string connectionString;
        
        public ContextoAplicacao(string _connectionString) {
            connectionString = _connectionString;
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(connectionString);
         }
     */
        public DbSet<Processo> dbSProcessos { get; set; }
        public DbSet<ObjetoProcesso> dbSObjetosProcesso { get; set; } = default!;
        public DbSet<Etapa> dbSEtapas { get; set; }
        public DbSet<Orgao> dbSOrgaos { get; set; }
       // public DbSet<Protocolo> dbSProtocolos { get; set; }
        public DbSet<Unidade> dbSUnidades { get; set; }
        public DbSet<Divisao> dbSDivisoes { get; set; }
        public DbSet<Local> dbSLocais { get; set; }
        public DbSet<TipoProcesso> dbSTiposProcesso { get; set; }
        public DbSet<SituacaoProcesso> dbSSituacoesProcesso { get; set; }
        public DbSet<TipoEtapa> dbSTiposEtapa { get; set; }
        public DbSet<SituacaoEtapa> dbSSituacoesEtapa { get; set; }

        public DbSet<TipoResponsabilidade> dbSTiposResponsabilidade { get; set; }
        public DbSet<Servidor> dbSServidores { get; set; }
        public DbSet<Endereco_Entidade> dbSEnderecos_Entidades { get; set; }
        public DbSet<Logradouro> dbSLogradouros { get; set; }
        public DbSet<TipoLogradouro> dbSTiposLogradouro { get; set; }
        public DbSet<Regiao> dbSRegioes { get; set; }
        public DbSet<Bairro> dbSBairros { get; set; }
        public DbSet<Cidade> dbSCidades { get; set; }
        public DbSet<Estado> dbSEstados { get; set; }
        public DbSet<Pais> dbSPaises { get; set; }
        public DbSet<Contato_Pessoa> dbSContatos_Pessoas { get; set; }
        public DbSet<Pessoa> dbSPessoas { get; set; }
        public DbSet<PessoaFisica> dbSPessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> dbSPessoasJuridicas { get; set; }
        public DbSet<TipoPessoa> dbSTiposPessoa { get; set; }
        public DbSet<Economia_Entidade> dbSEconomias_Entidades { get; set; }
        public DbSet<Imovel> dbSImoveis { get; set; }
        public DbSet<Economia> dbSEconomias { get; set; }
        public DbSet<DDD> dbSDDDs { get; set; } = default!;
        public DbSet<Endereco> dbSEnderecos { get; set; } = default!;
        public DbSet<FluxoProcesso> dbSFluxosProcesso { get; set; } = default!;
        public DbSet<Anexo> dbSAnexo { get; set; } = default!;
        public DbSet<IncrementoTabelas> dbSIncrementoTabelas { get; set; } = default!;
        public DbSet<Loteamento> dbSLoteamentos { get; set; } = default!;
        public DbSet<OperadoraTelefone> dbSOperadoraTelefoneS { get; set; } = default!;
public DbSet<Perspectiva> dbSPerspectivas { get; set; } = default!;
        public DbSet<PessoaFisica> dbSPessoasFisica { get; set; } = default!;
        public DbSet<PessoaJuridica> dbSPessoasJuridica { get; set; } = default!;
        public DbSet<RG> dbSRGs { get; set; } = default!;
        public DbSet<Telefone> dbSTelefones { get; set; } = default!;
        public DbSet<Contato> dbSContatos { get; set; } = default!;
        public DbSet<CNPJ> dbSCNPJs { get; set; } = default!;
        public DbSet<CPF> dbSCPFs { get; set; } = default!;
        public DbSet<DocumentoPessoa> dbSDocumentosPessoa { get; set; } = default!;
        public DbSet<TipoContato> dbSTiposContato { get; set; } = default!;
        public DbSet<TipoDocumento> dbSTiposDocumento { get; set; } = default!;
        public DbSet<TipoTelefone> dbSTiposTelefone { get; set; } = default!;
        public DbSet<Servidor_TipoProcesso> dbSServidores_TiposProcessos { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProcessoConfiguration());
            builder.ApplyConfiguration(new ObjetoProcessoConfiguration());
            builder.ApplyConfiguration(new EtapaConfiguration());
            //builder.ApplyConfiguration(new ProtocoloConfiguration());
            builder.ApplyConfiguration(new OrgaoConfiguration());
            builder.ApplyConfiguration(new UnidadeConfiguration());
            builder.ApplyConfiguration(new DivisaoConfiguration());
            builder.ApplyConfiguration(new LocalConfiguration());
            builder.ApplyConfiguration(new TipoProcessoConfiguration());
            builder.ApplyConfiguration(new SituacaoProcessoConfiguration());
            builder.ApplyConfiguration(new TipoEtapaConfiguration());
            builder.ApplyConfiguration(new SituacaoEtapaConfiguration());
            builder.ApplyConfiguration(new TipoResponsabilidadeConfiguration());
            builder.ApplyConfiguration(new TipoPessoaConfiguration());
            builder.ApplyConfiguration(new ServidorConfiguration());
            builder.ApplyConfiguration(new BairroConfiguration());
            builder.ApplyConfiguration(new CidadeConfiguration());
            builder.ApplyConfiguration(new ContatoConfiguration());
            builder.ApplyConfiguration(new EstadoConfiguration());
            builder.ApplyConfiguration(new LogradouroConfiguration());
            builder.ApplyConfiguration(new PaisConfiguration());
            builder.ApplyConfiguration(new RegiaoConfiguration());
            builder.ApplyConfiguration(new TipoLogradouroConfiguration());
            builder.ApplyConfiguration(new Endereco_EntidadeConfiguration());
            builder.ApplyConfiguration(new PessoaConfiguration());
            builder.ApplyConfiguration(new PessoaFisicaConfiguration());
            builder.ApplyConfiguration(new PessoaJuridicaConfiguration());
            builder.ApplyConfiguration(new Economia_EntidadeConfiguration());
            builder.ApplyConfiguration(new EconomiaConfiguration());
            builder.ApplyConfiguration(new ImovelConfiguration());
            builder.ApplyConfiguration(new Contato_PessoaConfiguration());
            builder.ApplyConfiguration(new DDDConfiguration());
            builder.ApplyConfiguration(new EnderecoConfiguration());
            builder.ApplyConfiguration(new FluxoProcessoConfiguration());
            builder.ApplyConfiguration(new AnexoConfiguration());
            builder.ApplyConfiguration(new IncrementoTabelasConfiguration());
            builder.ApplyConfiguration(new LoteamentoConfiguration());
            builder.ApplyConfiguration(new OperadoraTelefoneConfiguration());
            builder.ApplyConfiguration(new PerspectivaConfiguration());
            builder.ApplyConfiguration(new RGConfiguration());
            builder.ApplyConfiguration(new TelefoneConfiguration());
            builder.ApplyConfiguration(new CNPJConfiguration());
            builder.ApplyConfiguration(new CPFConfiguration());
            builder.ApplyConfiguration(new TipoContatoConfiguration());
            builder.ApplyConfiguration(new TipoDocumentoConfiguration());
            builder.ApplyConfiguration(new TipoTelefoneConfiguration());
            builder.ApplyConfiguration(new DocumentoPessoaConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new Servidor_TipoProcessoConfiguration());
            //builder.ApplyConfiguration(new Configuration());

            /*            foreach (var property in builder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(string)))
                        {
                            property.SetColumnType("varchar");
                        }*/
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataUltimaAlteracao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataUltimaAlteracao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataUltimaAlteracao").IsModified = true;
                }
            }
            return base.SaveChanges();
        }

        
    }
}