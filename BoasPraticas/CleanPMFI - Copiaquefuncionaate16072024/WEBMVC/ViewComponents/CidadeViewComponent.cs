using Microsoft.AspNetCore.Mvc;
using Domain.Pagination;
using Application.ViewModels;
namespace WEBMVC.ViewComponents
{
    public class CidadeViewComponent :ViewComponent
    {
        public CidadeViewComponent() { }
        public async Task<IViewComponentResult> InvokeAsync(PagedResponse<CidadeViewModel> pageResponse)
        {
          //  return View("Default", new PagedResponseViewModel<CidadeViewModel>(pageResponse));
            return  View("Default", new PagedResponseViewModel<CidadeViewModel>(pageResponse));
        }

    }
}
