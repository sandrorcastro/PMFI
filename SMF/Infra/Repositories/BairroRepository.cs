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
    public class BairroRepository : RepositoryBase<Bairro>, IBairroRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public BairroRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public BairroRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Bairro> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSBairros.Where(p => p.Descricao == descricao);
            //}
        }
    }
}
