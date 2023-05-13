using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class LogradouroRepository : RepositoryBase<Logradouro>, ILogradouroRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public LogradouroRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public LogradouroRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Logradouro> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSLogradouros.Where(p => p.Descricao == descricao);
            //}
        }
    }
}
