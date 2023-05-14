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
        public ContextoAplicacao CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextoAplicacao>();
            optionsBuilder.UseSqlServer("Data Source=SANDRO-ASPIRE-4\\SQLEXPRESS;Initial Catalog=SMF_Processo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new ContextoAplicacao(optionsBuilder.Options);
        }
    }
}
