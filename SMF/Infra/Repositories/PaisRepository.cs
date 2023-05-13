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
    public class PaisRepository : RepositoryBase<Pais>, IPaisRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public PaisRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public PaisRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Pais> BuscarPorDescricao(string nome)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPaises.Where(p => p.Nome == nome);
            //}
        }
    }
}
