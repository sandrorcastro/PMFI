using Domain.Entities.DBProsiga;

namespace Domain.Filters.DBProsiga;

public record ContribuinteFilter : BaseFilter
{
    public string? CPFCNPJ {  get; set; }
    public string? Nome { get; set; }
}
