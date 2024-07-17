using Domain.Entities;

namespace Domain.Filters;

public record PaisFilter : BaseFilter
{
    public int? IdPais { get; set; }
    public string? Nome { get; set; }
}
