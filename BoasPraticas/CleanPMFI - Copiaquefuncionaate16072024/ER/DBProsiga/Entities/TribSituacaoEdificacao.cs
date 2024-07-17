using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSituacaoEdificacao
{
    public int SituacaoId { get; set; }

    public string? SituacaoNome { get; set; }

    public decimal? SituacaoFator { get; set; }

    public int? SituacaoPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
