using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class CombustivelEntradum
{
    public long NumLancEntrada { get; set; }

    public long CodDeposito { get; set; }

    public DateTime DtLancEntrada { get; set; }

    public decimal QtdeLitros { get; set; }

    public decimal? ValorTotal { get; set; }

    public long ConId { get; set; }

    public long Nfnum { get; set; }

    public int EmpenhoAno { get; set; }

    public long EmpenhoNum { get; set; }

    public long LicitacaoNum { get; set; }

    public long LicitacaoTipo { get; set; }

    public virtual CombustivelDeposito CodDepositoNavigation { get; set; } = null!;

    public virtual Contribuinte Con { get; set; } = null!;
}
