using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class ProcessoQueryExtensions
    {
        public static IQueryable<Processo> Filter(this IQueryable<Processo> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Include(tp=>tp.TipoProcesso).Include(se=>se.SituacaoProcesso).Take(1000);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
                return query.Where(s =>  s.SituacaoProcessoId == long.Parse(filter)

                                          ).Include(tp => tp.TipoProcesso).Include(se => se.SituacaoProcesso).Take(1000) ;
            }
            else
            {
                filter = filter.ToLower();
                return query.Where(s => s.TipoProcesso.Descricao.Contains(filter)).Include(tp => tp.TipoProcesso).Include(se => se.SituacaoProcesso).Take(1000);


            }
        }

        public static IQueryable<Processo> OrderBy(this IQueryable<Processo> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Processo, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.ProcessoId,
                //"processoid" => x => x.SequenciaNumerica,
                "tipoprocesso" => x => x.TipoProcesso.Descricao,
                "tipoprocessoid" => x => x.TipoProcessoId ,
                "situacaoprocessoid" => x => x.SituacaoProcessoId,
                "situacaoprocesso" => x => x.SituacaoProcesso.Descricao
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Processo> Permissao(this IQueryable<Etapa> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
