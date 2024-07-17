using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEdificacoesIsencaoTrib
{
    public int IsencaoId { get; set; }

    public int TipoTribId { get; set; }

    public decimal? Desconto { get; set; }

    public int? TipoBxId { get; set; }

    public virtual TribEdificacoesIsencao Isencao { get; set; } = null!;

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
