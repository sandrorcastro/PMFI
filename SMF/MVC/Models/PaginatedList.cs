using Microsoft.EntityFrameworkCore;
using MVC.ViewModels;

namespace MVC.Models
{
    public class PaginatedList<T> : List<T>, IPaginatedList where T:class
    {
        public PaginatedList() { }
        public PaginatedList(List<T> items, int count, int currentPage, int pageSize)
       // public PaginatedListVC(IQueryable<T> source, int count, int currentPage, int pageSize)
        //IQueryable<T> source
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalItems = count;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
            //AddRange(source);
        }

        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalItems { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int currentPage, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, currentPage, pageSize);
        }
    }
}
