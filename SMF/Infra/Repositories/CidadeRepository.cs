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
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public CidadeRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public CidadeRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Cidade> BuscarPorDescricao(string nome)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSCidades.Where(p => p.Descricao == nome);
            //}
        }
    }
}
