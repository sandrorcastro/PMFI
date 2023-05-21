using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;
using Twilio.TwiML.Voice;

namespace MVC.Extensions
{
   // [Authorize]
    public static class Economia_EntidadeQueryExtensions
    {
        public static IQueryable<Economia_Entidade> Filter(this IQueryable<Economia_Entidade> query, Func<Economia_Entidade, bool>  filter)
        {
            
            if (filter==null)
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Take(100).Include(p => p.Pessoa);
            }
            long number1 = 0;
            //  if (long.TryParse(filter, out number1))
            // {
            return query.Where(filter).AsQueryable();// .Include(p=>p.Pessoas).Include(e=>e.Enderecos);
            //}

        }
        public static IQueryable<Economia_Entidade> Filter(this IQueryable<Economia_Entidade> query, string filter)
        {

            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Take(100).Include(p => p.Pessoa);
            }
            long number1 = 0;
            //  if (long.TryParse(filter, out number1))
            // {
            return query.Where(s => s.ImovelId == long.Parse(filter)).Include(p => p.Pessoa);
            //}

        }



        

        public static IQueryable<Economia_Entidade> OrderBy(this IQueryable<Economia_Entidade> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Economia_Entidade, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.ImovelId,
                "imovelid" => x => x.ImovelId,
                "economiaid" => x => x.EconomiaId,
                "pessoaid"=> x => x.PessoaId

            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Economia_Entidade> Permissao(this IQueryable<Economia_Entidade> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
