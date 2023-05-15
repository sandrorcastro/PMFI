using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;
namespace MVC.ViewComponents
{
    public class PaginationViewComponent : ViewComponent
    {
        public PaginationViewComponent() {}
        public async Task<IViewComponentResult> InvokeAsync(IPaginatedList values, Dictionary<string,string> routeData=null)
        {
            return View("Default",new PaginationViewModel(){List = values, RouteData =routeData});
        }
    }
}
