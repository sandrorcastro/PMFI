using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class EconomiaRepository : RepositoryBase<Economia>, IEconomiaRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //private readonly ContextoAplicacao contexto;
        //public EconomiaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { /*this.contexto = contexto;*/}
        public EconomiaRepository(ContextoAplicacao contexto) : base(contexto) { /*this.contexto = contexto;*/}
        public void UpdateEconomiaTemProcessos(Economia economia)
        {
            try
            {
              //  using (var Db = contexto.CreateDbContext())
                //{

                    economia.TemProcessos = true;
                    contexto.dbSEconomias.Attach(economia);
                    contexto.Entry(economia).Property(e => e.TemProcessos).IsModified = true;
                    contexto.SaveChanges();
                //economia.TemProcessos = true;
                //contexto.dbsEconomias.Attach(economia);
                //contexto.Entry(economia).Property(e => e.TemProcessos).IsModified = true;
                //contexto.SaveChanges();
                //}


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    
}
