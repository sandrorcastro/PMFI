using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivDividaAtivaJudicial
{
    public int IdDividaAtivaJudicial { get; set; }

    public int? IdCredito { get; set; }

    public string? TpCredito { get; set; }

    public int? NrOperacao { get; set; }

    public short? NrAnoOperacao { get; set; }

    public string? TpOperacao { get; set; }

    public DateTime? DtInicio { get; set; }

    public string? NrProcessoJudicial { get; set; }

    public DateTime? DtProcessoJudicial { get; set; }

    public int? IdLeiAto { get; set; }

    public decimal? VlOperacao { get; set; }

    public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }
}
