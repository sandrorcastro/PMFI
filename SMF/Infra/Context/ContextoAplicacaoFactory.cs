using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class ContextoAplicacaoFactory : IDesignTimeDbContextFactory<ContextoAplicacao>
    {
        private readonly string connectionString;
     /*   public ContextoAplicacaoFactory(String _connectionString)
        {
            connectionString= _connectionString;
        }*/
        public ContextoAplicacao CreateDbContext(string[] args)
        {

            var TI102 = "Data Source=172.27.84.102;Initial Catalog=SMF_Processo;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=rpdesenv;Password=visual";
            var HSE = "Data Source=SANDRO-ASPIRE-4\\SQLEXPRESS;Initial Catalog=SMF_Processo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var HSS = "Data Source=localhost\\SQLSERVER;Initial Catalog=SMF_Processo;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=sqlserver";
            var DefaultConnection = HSS;

            var optionsBuilder = new DbContextOptionsBuilder<ContextoAplicacao>();
            //Home
            //optionsBuilder.UseSqlServer("Data Source=SANDRO-ASPIRE-4\\SQLEXPRESS;Initial Catalog=SMF_Processo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //SMTI
            //  optionsBuilder.UseSqlServer("Data Source=172.27.84.102;Initial Catalog=SMF_Processo;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=rpdesenv;Password=visual");
            //optionsBuilder.UseSqlServer(DefaultConnection);

            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer();

            //Local SQLSERVER
            //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLSERVER;Initial Catalog=SMF_Processo;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=sqlserver");
            return new ContextoAplicacao(optionsBuilder.Options);
        }
    }
}
