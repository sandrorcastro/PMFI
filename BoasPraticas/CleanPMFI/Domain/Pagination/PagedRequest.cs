namespace Domain.Pagination;

public class PagedRequest<T>
{
    public T ViewModel { get; set; }
    public Pagination Pagination { get; }
    

    public PagedRequest(Pagination pagination)
    {
    
        Pagination = pagination;
    }
}

