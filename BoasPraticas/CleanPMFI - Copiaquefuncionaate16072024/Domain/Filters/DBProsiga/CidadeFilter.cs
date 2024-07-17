using Domain.Entities.DBProsiga;

namespace Domain.Filters.DBProsiga;

public record CidadeFilter : BaseFilter
{
    public string? IdCidade {  get; set; }
    public string? Nome { get; set; }
}
