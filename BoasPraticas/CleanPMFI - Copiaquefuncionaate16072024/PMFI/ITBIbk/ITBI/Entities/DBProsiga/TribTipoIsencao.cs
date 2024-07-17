using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTipoIsencao
{
    public int TipoIseId { get; set; }

    public string? Descricao { get; set; }

    public int? TipoBxId { get; set; }

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual ICollection<TribEdificacoesIsencao> TribEdificacoesIsencaos { get; set; } = new List<TribEdificacoesIsencao>();

    public virtual ICollection<TribTipoTributo> TipoTribs { get; set; } = new List<TribTipoTributo>();
}
