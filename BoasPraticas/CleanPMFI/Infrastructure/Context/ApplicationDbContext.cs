//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Diagnostics;
using System.Net.Http;


namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //public DbSet<Uf> Ufs { get; set; }
        public DbSet<Uf> Ufs => Set<Uf>();
        // public DbSet<Pais> Paises { get; set; }
        public DbSet<Pais> Paises => Set<Pais>();
        //public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cidade> Cidades => Set<Cidade>();
        public DbSet<Logradouro> Logradouros => Set<Logradouro>();
        public DbSet<TipoLogradouro> TiposLogradouros => Set<TipoLogradouro>();
        public DbSet<Endereco> Enderecos => Set<Endereco>();
        public DbSet<Regiao> Regioes => Set<Regiao>();
        public DbSet<Bairro> Bairros => Set<Bairro>();
        public DbSet<TribAlvDocumento> TribAlvDocumentos => Set<TribAlvDocumento>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UfConfiguration());
            builder.ApplyConfiguration(new CidadeConfiguration());
            builder.ApplyConfiguration(new PaisConfiguration());
            builder.ApplyConfiguration(new LogradouroConfiguration());
            builder.ApplyConfiguration(new TipoLogradouroConfiguration());
            builder.ApplyConfiguration(new EnderecoConfiguration());
            builder.ApplyConfiguration(new RegiaoConfiguration());
            builder.ApplyConfiguration(new BairroConfiguration());
            builder.ApplyConfiguration(new TribAlvDocumentoConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
       
    }
}