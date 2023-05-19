using MVC.Models;
using System.ComponentModel;

namespace MVC.ViewModels
{
    public class PaginatedListViewModel<TEntity> : PaginatedList<TEntity> where TEntity : class
    {
       
    }
}
