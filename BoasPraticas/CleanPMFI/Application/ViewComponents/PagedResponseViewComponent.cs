using Domain.Pagination;

namespace Application.ViewComponents
{
    public class PagedResponseViewComponent<T> : ViewComponent
    {
        public PagedResponseViewComponent() {}
        public async Task<IViewComponentResult> InvokeAsync(PagedResponse<T> page, Dictionary<string,string> routeData=null)
        {
            return View("Default",new PagedesponseViewModel(){List = values, RouteData =routeData});
        }
    }
}
