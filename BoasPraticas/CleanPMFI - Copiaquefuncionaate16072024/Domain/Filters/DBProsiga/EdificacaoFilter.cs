using Domain.Entities;

namespace Domain.Filters.DBProsiga;

public record EdificacaoFilter : BaseFilter
{
    public string? InscricaoImobiliaria {  get; set; }
    
}
