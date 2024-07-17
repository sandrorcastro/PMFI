namespace Domain.Pagination;

public class PagedResponse<T>
{
    public T ViewModel { get; set; }
    public Pagination Pagination { get; }
    public List<T> Data { get; }

    public PagedResponse(List<T> data, Pagination pagination)
    {
        Data = data;
        Pagination = pagination;
    }
}

