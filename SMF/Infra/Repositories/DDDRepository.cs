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
    public class DDDRepository : RepositoryBase<DDD>, IDDDRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public DDDRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public DDDRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<DDD> BuscarPorNumero(string numero)
        {
           // using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSDDDs.Where(p => p.CodigoDDD == numero);
            //}
        }
    }
}
