namespace Domain.Filters;

public record CidadeFilter : BaseFilter
{
    public string? Nome { get; set; }
}
