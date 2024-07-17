using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivDiarioArrecadacaoEstorno
{
    public int IdArrecadacaoEstorno { get; set; }

    public int? IdArrecadacao { get; set; }

    public int? NrEstorno { get; set; }

    public short? NrAnoEstorno { get; set; }

    public DateTime? DtEstorno { get; set; }

    public decimal? VlOperacao { get; set; }

    public string? DsMotivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLoginInclusao { get; set; }

    public virtual TbDivDiarioArrecadacao? IdArrecadacaoNavigation { get; set; }
}
