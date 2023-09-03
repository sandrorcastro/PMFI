using Domain.Entities;

namespace Domain.Filters;

public record UfFilter : BaseFilter
{
    public int? IdUf { get; set; }
    public string? Sigla { get; set; }
    public string? Nome { get; set; } 
}
