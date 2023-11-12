using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ContribuintesEnviadosTce
{
    public int IdEnvio { get; set; }

    public short IdEmpresa { get; set; }

    public long ConId { get; set; }

    public DateTime DtEnvio { get; set; }

    public string? DsObservacao { get; set; }
}
