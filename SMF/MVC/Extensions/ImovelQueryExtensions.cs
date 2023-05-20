using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class ImovelQueryExtensions
    {
        public static IQueryable<Imovel> Filter(this IQueryable<Imovel> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Take(100).Include(e=>e.Economias).Include(e=>e.Enderecos);
            }
            long number1 = 0;
            //if (long.TryParse(filter, out number1))
            //{
                return query.Where(s => s.ImovelId == long.Parse(filter) ).Include(e => e.Economias).Include(e => e.Enderecos);
            //}
            
        }

        public static IQueryable<Imovel> OrderBy(this IQueryable<Imovel> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Imovel, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.ImovelId,
                "imovelid" => x => x.ImovelId
                
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Imovel> Permissao(this IQueryable<Imovel> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
