using MVC.Models;

namespace MVC.ViewModels
{
    public class PaginationViewModel
    {
        public IPaginatedList? List { get; set; }
        public Dictionary<string,string>? RouteData { get; set; }
    }
}
