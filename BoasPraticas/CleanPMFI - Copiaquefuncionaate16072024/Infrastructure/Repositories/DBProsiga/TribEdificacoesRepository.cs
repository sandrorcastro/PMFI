using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.DBProsiga
{
    public class TribEdificacoesRepository : RepositoryBase<TribEdificaco>, ITribEdificacoesRepository
    {
        public TribEdificacoesRepository(DBProsigaContext context) : base(context) { }
        public TribEdificacoesRepository(DBProsigaContext _contextFactory,IMapper mapper) : base(_contextFactory,mapper) { }
        public TribEdificacoesRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }

        public async  Task<TribEdificaco> GetByInscricaoImobiliaria(string? inscricao)
        {
            return await _dbContext.Set<TribEdificaco>().Where(e=>e.InscricaoImobiliaria==inscricao!).FirstOrDefaultAsync();  //   .FindAsync(inscricao);
            //return await _dbContext.TribEdificacoes.Where(e => e.InscricaoImobiliaria == inscricao!).FirstOrDefaultAsync();  //   .FindAsync(inscricao);
                                                                                                                                    //TribEdificacoes.Where(e => e.InscricaoImobiliaria == inscricao);
        }
    }
}
