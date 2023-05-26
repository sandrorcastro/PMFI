using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class EtapaQueryExtensions
    {
        public static IQueryable<Etapa> Filter(this IQueryable<Etapa> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Include(se=>se.SituacaoEtapa).Include(s=>s.Servidor).Include(p=>p.Pessoa).Take(1000);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
                return query.Where(s => //s.EtapaId == long.Parse(filter)
                                         s.ProcessoId == long.Parse(filter)
                                      //  || s.TipoEtapaId == long.Parse(filter)
                                        || s.SituacaoEtapaId == long.Parse(filter)
                                    
                                        || s.PessoaId == long.Parse(filter)
                                        || s.ServidorId == long.Parse(filter)

                                          ).Include(se => se.SituacaoEtapa).Include(s => s.Servidor).Include(p => p.Pessoa).Take(1000);
            }
            else
            {
                filter = filter.ToLower();
                return query.Where(s=> s.Ano.Contains(filter)
                                                                              //  || s.TipoEtapa.Descricao.Contains(filter)
                                                                                || s.SituacaoEtapa.Descricao.Contains(filter)
                                                                                || s.Servidor.Nome.Contains(filter)
                                                                                || s.Pessoa.Nome.Contains(filter))
                                        .Include(se => se.SituacaoEtapa).Include(s => s.Servidor).Include(p => p.Pessoa).Take(1000);
            }
        }

        public static IQueryable<Etapa> OrderBy(this IQueryable<Etapa> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Etapa, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.ProcessoId,
                "processoid" => x => x.ProcessoId,
               // "etapaid" => x => x.EtapaId,
              //  "tipoetapaid" => x => x.TipoEtapaId,
               // "tipoetapa" => x => x.TipoEtapa.Descricao,
                "situacaoetapaid" => x => x.SituacaoEtapaId,
                "situacaoetapa" => x => x.SituacaoEtapa.Descricao,
             
                "servidorid" => x => x.ServidorId,
                "datainicio" => x => x.DataInicio,
                "datafim" => x => x.DataFim,
                "pessoaid" => x => x.PessoaId,
                "pessoa" => x => x.Pessoa.Nome

            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        public static IQueryable<Etapa> Permissao(this IQueryable<Etapa> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }
    }
}
