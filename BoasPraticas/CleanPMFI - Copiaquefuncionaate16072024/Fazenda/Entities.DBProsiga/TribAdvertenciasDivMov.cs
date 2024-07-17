using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAdvertenciasDivMov
{
    public long AdverMovId { get; set; }

    public string? TipoMov { get; set; }

    public DateTime? DataMov { get; set; }

    public string? Usuario { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public int? AdvertId { get; set; }

    public virtual TribAdvertencia? Advert { get; set; }
}
