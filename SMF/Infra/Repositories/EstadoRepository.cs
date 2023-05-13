using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class EstadoRepository : RepositoryBase<Estado>, IEstadoRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public EstadoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public EstadoRepository(ContextoAplicacao contexto) : base(contexto) { }

        public Estado BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSEstados.Where(p => p.Descricao == descricao).FirstOrDefault();
            //}
        }
        public Estado BuscarPorSigla(string sigla)
        {
          //  using (var Db = contexto.CreateDbContext())
           // {
                return contexto.dbSEstados.Where(p => p.Sigla == sigla).FirstOrDefault();
            //}
        }
    }
}
