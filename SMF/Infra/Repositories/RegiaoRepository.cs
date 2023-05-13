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
    public class RegiaoRepository : RepositoryBase<Regiao>, IRegiaoRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public RegiaoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public RegiaoRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Regiao> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSRegioes.Where(p => p.Descricao == descricao);
            //}
        }
    }
}
