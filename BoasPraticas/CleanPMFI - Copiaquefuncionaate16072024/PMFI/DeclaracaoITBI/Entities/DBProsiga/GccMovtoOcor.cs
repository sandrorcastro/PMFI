using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccMovtoOcor
{
    public string MovtoCnpjmembro { get; set; } = null!;

    public long MovtoId { get; set; }

    public int? MovtoCreId { get; set; }

    public long? MovtoCriId { get; set; }

    public int? MovtoTocorId { get; set; }

    public DateTime? MovtoData { get; set; }

    public string? MovtoDescr { get; set; }

    public virtual GccCriCreche? GccCriCreche { get; set; }

    public virtual GccTipoOcor? GccTipoOcor { get; set; }
}
