//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.Entities.DBProsiga;
//using Infrastructure.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Reflection.Emit;




namespace LancamentoDecenio
{
    public class ApplicationDbContext : DbContext 
    {
      //  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<TribDividasEmpresa> DividasEmpresas => Set<TribDividasEmpresa>();
        public DbSet<TribEmpresa> Empresas => Set<TribEmpresa>();
        public DbSet<SisParametro> SisParamettros => Set<SisParametro>();
        public DbSet<TribComposicaoDivEmpresa> ComposicaoDividasEmpresas => Set<TribComposicaoDivEmpresa>();
        //public DbSet<TribComposicaoDivEmpresa> ComposicaoDividasEmpresas { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new UfConfiguration());
            builder.Entity<CargasProcesso>().Ignore(c => c.CargaDivisao);
            builder.Entity<CargasProcesso>().Ignore(c => c.CargaDivisaoIdorigemNavigation);
            base.OnModelCreating(builder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=172.27.1.98;Initial Catalog=DBProsiga;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=usergiigteste;Password=PMFI@dien");
        }

    }
}