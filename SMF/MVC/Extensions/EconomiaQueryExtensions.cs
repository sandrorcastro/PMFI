using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class EconomiaQueryExtensions
    {
        public static IQueryable<Economia> Filter(this IQueryable<Economia> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Take(100).Include(p => p.Pessoas).Include(e => e.Enderecos);
            }
            long number1 = 0;
          //  if (long.TryParse(filter, out number1))
           // {
                return query.Where(s => s.ImovelId == long.Parse(filter) ).Include(p=>p.Pessoas).Include(e=>e.Enderecos);
            //}
            
        }

        public static IQueryable<Economia> OrderBy(this IQueryable<Economia> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Economia, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.ImovelId,
                "imovelid" => x => x.ImovelId,
                "economiaid" => x => x.EconomiaId

            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Economia> Permissao(this IQueryable<Economia> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
