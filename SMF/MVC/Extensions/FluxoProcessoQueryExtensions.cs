using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class FluxoProcessoQueryExtensions
    {
        public static IQueryable<FluxoProcesso> Filter(this IQueryable<FluxoProcesso> query, string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Include(tp=>tp.TipoProcesso);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
                return query.Where(s => s.FluxoProcessoId == long.Parse(filter)).Include(tp => tp.TipoProcesso);
            }
            else
            {
                filter = filter.ToLower();
                return query.Where(fp=> fp.TipoProcesso.Descricao.Contains(filter) || fp.Descricao.Contains(filter))
                                    .Include(tp => tp.TipoProcesso);
            }
        }

        public static IQueryable<FluxoProcesso> OrderBy(this IQueryable<FluxoProcesso> query, string name, SortDirection? direction = SortDirection.Asc)
        {
            Expression<Func<FluxoProcesso, object>> exp = name /*? ToLower()*/ switch
            {
                "FluxoProcessoId" => x => x.FluxoProcessoId,
                "TipoProcesso" => x => x.TipoProcessoId
                
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<FluxoProcesso> Permissao(this IQueryable<FluxoProcesso> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
