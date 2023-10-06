using Domain.Entities;

namespace Domain.Filters;

public record NfseTblNfseFilter : BaseFilter
{
   // public long? Idnfse { get; set; }
    public DateTime? Dtcompetencia{ get; set; }
    
}
