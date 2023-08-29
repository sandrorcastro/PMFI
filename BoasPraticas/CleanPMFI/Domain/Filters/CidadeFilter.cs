namespace Domain.Filters;

public record CidadeFilter : BaseFilter
{
    public int? IdCidade {  get; set; }
    public string? Nome { get; set; }
}
