using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdifNumPredial
{
    public int NumPid { get; set; }

    public long? EdificacaoId { get; set; }

    public DateTime? NumPdata { get; set; }

    public int? NumPnumProtocolo { get; set; }

    public string? NumPnumero { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }
}
