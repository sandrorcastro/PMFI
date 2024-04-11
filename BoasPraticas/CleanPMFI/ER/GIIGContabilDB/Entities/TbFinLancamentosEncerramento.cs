using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinLancamentosEncerramento
{
    public short IdLancamento { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? TpLancamento { get; set; }

    public short? NrSequencia { get; set; }

    public string? DsLancamento { get; set; }

    public string? CdContaContabilDebito { get; set; }

    public string? DsTipo { get; set; }

    public string? CdContaContabiCredito { get; set; }

    public string? DsValorOrigem { get; set; }

    public string? DsOperacaoEspecial { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? CdEvento { get; set; }

    public short? NrSeqEvento { get; set; }
}
