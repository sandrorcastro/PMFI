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
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Pais> dbPaises { get; set; }
        public DbSet<Cidade> dbCidades { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UfConfiguration());
            builder.ApplyConfiguration(new CidadeConfiguration());
            builder.ApplyConfiguration(new PaisConfiguration());
            //builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
       
    }
}