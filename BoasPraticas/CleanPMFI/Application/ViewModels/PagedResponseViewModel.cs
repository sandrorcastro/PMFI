using Domain.Pagination;

namespace Application.ViewModels
{
    public class PagedResponseViewModel<T>
    {
       public PagedResponse<T> PagedResponse { get; set; }
        public PagedResponseViewModel(PagedResponse<T> pagedResponse) {
            PagedResponse = pagedResponse;
            Pagination = pagedResponse.Pagination;
            Data = pagedResponse.Data;
        }
        public T ViewModel { get; set; }
        public Pagination Pagination { get; }
        public List<T> Data { get; }

        public PagedResponseViewModel(List<T> data, Pagination pagination)
        {
            Data = data;
            Pagination = pagination;
        }
    }
}
