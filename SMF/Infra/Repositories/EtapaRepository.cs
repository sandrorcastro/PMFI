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
    public class EtapaRepository : RepositoryBase<Etapa>, IEtapaRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public EtapaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public EtapaRepository(ContextoAplicacao contexto) : base(contexto) { }
        public Etapa GetById(long ProcessoId, long ImovelId, long EconomiaId,int TipoEtapaId, int SituacaoEtapaId)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSEtapas.Where(e => e.ProcessoId == ProcessoId
                                           && e.ImovelId == ImovelId
                                           && e.EconomiaId == EconomiaId
                                           && e.TipoEtapaId == TipoEtapaId
                                           && e.SituacaoEtapaId == SituacaoEtapaId)
                                    .Include(s => s.Servidor)
                                    .Include(p => p.Pessoa)
                                    .Include(e => e.Endereco).FirstOrDefault();
            //}
        }


    }
}
