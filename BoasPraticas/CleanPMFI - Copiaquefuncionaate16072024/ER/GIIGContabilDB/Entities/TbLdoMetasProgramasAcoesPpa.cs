using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoMetasProgramasAcoesPpa
{
    public int IdAcaoLdo { get; set; }

    public int IdAcao { get; set; }

    public short? NrAnoLdo { get; set; }

    public decimal? NrLdoMetaFisica { get; set; }

    public decimal? VlLdoTotalVinculado { get; set; }

    public decimal? VlLdoTotalOrdinario { get; set; }

    public string? DsLdoAcaoNotaExplicativa { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsMotivoCancelamento { get; set; }

    public string? DsTpComando { get; set; }

    public virtual TbPpaProgramasAco IdAcaoNavigation { get; set; } = null!;
}
