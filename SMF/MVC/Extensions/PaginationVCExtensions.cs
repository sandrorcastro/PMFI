using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Configuration;

/*

using Microsoft.Identity.Client;
using MVC.ViewModels;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
*/
using MVC.Models;

namespace MVC.Extensions
{
    public static class PaginationVCExtensions
    {
        public static async Task<PaginatedList<T>> ToPagedListVC<T>(this IQueryable<T> source, int page = 1, int pageSize = AppConfig.PageSize) where T : class
        {
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, page, pageSize);
        }

        public static async Task<PaginatedList<TResult>> ToPagedListVC<T, TResult>(this IQueryable<T> source,Func<T, TResult> selectFunc,int page = 1,int pageSize = AppConfig.PageSize) where TResult : class where T : class
        {
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<TResult>(items.Select(selectFunc).ToList(), count, page, pageSize);
        }
    }
}
