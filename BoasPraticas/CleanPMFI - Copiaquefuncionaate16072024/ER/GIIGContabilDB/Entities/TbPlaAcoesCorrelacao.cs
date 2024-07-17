using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAcoesCorrelacao
{
    public int IdCorrelacao { get; set; }

    public int IdAcao { get; set; }

    public int IdAcaoCorrelacao { get; set; }

    public short? NrAno { get; set; }

    public int? IdVersaoCorrelacao { get; set; }

    public DateTime? DtCorrelacao { get; set; }

    public string? DsLoginCorrelacao { get; set; }

    public int? IdVersaoCancelamento { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public string? DsLoginCancelamento { get; set; }

    public virtual TbPlaAco IdAcaoCorrelacaoNavigation { get; set; } = null!;

    public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
}
