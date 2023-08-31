using Microsoft.AspNetCore.Mvc;
using Domain.Pagination;
using Application.ViewModels;

namespace WEBMVC.ViewComponents
{
    [ViewComponent]
    public class PagedResponseViewComponent<T> : ViewComponent
    {
        public PagedResponseViewComponent() {}
        public async Task<IViewComponentResult> InvokeAsync(PagedResponse<T> pageResponse)
        {
            return  View("Default",new PagedResponseViewModel<T>( pageResponse ));
        }
    }
}
