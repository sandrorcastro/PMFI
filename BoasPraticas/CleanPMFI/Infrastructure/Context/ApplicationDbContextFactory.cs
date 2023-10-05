using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Domain.Entities.NFSEDB;

namespace Infrastructure.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    //public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<NFSEDBContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            //var configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build(); 
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SEI;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme");
            //---optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PMFI;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme");
            //optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=DBProsiga;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
             optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=SRC-PMFI;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=rpdesenv;Password=visual");
             //optionsBuilder.UseSqlServer("Data Source=172.27.1.94;Initial Catalog=NFSEDB;Persist Security Info=false;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;User ID=gilberto.gc;Password=Couto2408@@");
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
            return new ApplicationDbContext(optionsBuilder.Options);
        }

       /* NFSEDBContext IDesignTimeDbContextFactory<NFSEDBContext>.CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }*/
    }
}

