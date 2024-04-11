using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbCntNumeroAtosContratuai
{
    public int IdNumeroAto { get; set; }

    public int IdContrato { get; set; }

    public int? NrAditivo { get; set; }

    public short? NrAnoAditivo { get; set; }

    public DateTime? DtTermo { get; set; }

    public string? DsAditivo { get; set; }

    public string? CdTcm { get; set; }

    public string? CdTipoNumero { get; set; }

    public bool? FlTipoLateral { get; set; }

    public string? DsTipoLateral { get; set; }

    public DateTime? DtEscrituracao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public int? IdNumeroAtoOrigem { get; set; }
}
