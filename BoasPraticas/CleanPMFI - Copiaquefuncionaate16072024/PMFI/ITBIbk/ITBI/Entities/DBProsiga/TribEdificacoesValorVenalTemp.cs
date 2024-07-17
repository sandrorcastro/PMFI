using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEdificacoesValorVenalTemp
{
    public int CalcId { get; set; }

    public string? CalcUsuario { get; set; }

    public DateTime? CalcData { get; set; }

    public long? EdificacaoId { get; set; }

    public short? CalcAno { get; set; }

    public decimal? ValorVenalCalculo { get; set; }

    public DateTime? CalcDataAte { get; set; }

    public decimal? ValorVenalEdificacao { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }
}
