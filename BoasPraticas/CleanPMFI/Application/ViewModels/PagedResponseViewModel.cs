using Domain.Filters;
using Domain.Pagination;

namespace Application.ViewModels
{
    public class PagedResponseViewModel<T>
    {
        public PagedResponse<T> PagedResponse { get; set; }
        public BaseFilter Filter { get; set; }
        public PagedResponseViewModel(PagedResponse<T> pagedResponse) {
            PagedResponse = pagedResponse;
            Pagination = pagedResponse.Pagination;
            Data = pagedResponse.Data;
        }
        public PagedResponseViewModel(PagedResponse<T> pagedResponse,BaseFilter filter)
        {
            PagedResponse = pagedResponse;
            Pagination = pagedResponse.Pagination;
            Data = pagedResponse.Data;
            Filter = filter;
        }

        public T ViewModel { get; set; }
        public Pagination Pagination { get; }
        public List<T> Data { get; }

        public PagedResponseViewModel(List<T> data, Pagination pagination)
        {
            Data = data;
            Pagination = pagination;
        }
        public PagedResponseViewModel(List<T> data, Pagination pagination, BaseFilter filter)
        {
            Data = data;
            Pagination = pagination;
            Filter = filter;
        }
    }
}
