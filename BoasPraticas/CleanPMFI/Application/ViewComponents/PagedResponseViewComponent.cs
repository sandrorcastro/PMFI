using Domain.Pagination;

namespace Application.ViewComponents
{
    public class PagedResponseViewComponent<T> : ViewComponent
    {
        public PagedResponseViewComponent() {}
        public async Task<IViewComponentResult> InvokeAsync(PagedResponse<T> pageResponse)
        {
            return View("Default",new PagedResponseViewModel() { PagedResponse = pageResponse });
        }
    }
}
