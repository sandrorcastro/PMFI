using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribPosicaoEdificacao
{
    public int PosicaoId { get; set; }

    public string? PosicaoNome { get; set; }

    public decimal? PosicaoFator { get; set; }

    public int? PosicaoPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
