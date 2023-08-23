

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace PMFI.Infra.Context
{
    public class SegurancaDbContextFactory : IDesignTimeDbContextFactory<SegurancaDbContext>
    {
        public IHttpContextAccessor HttpContext { get; }
        public SegurancaDbContext CreateDbContext(string[] args)
        {
           /* var configuration = new ConfigurationBuilder()
          .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
          .AddJsonFile("appsettings.json")
          .Build();*/ 
            var optionsBuilder = new DbContextOptionsBuilder<SegurancaDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SEG;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme");
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
            return new SegurancaDbContext(optionsBuilder.Options,HttpContext);
        }
    }
}
