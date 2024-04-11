using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ImobensMovimento
{
    public long MovImoNumLanc { get; set; }

    public string? MovImoInscricao { get; set; }

    public int? MovImoNumFicha { get; set; }

    public DateTime? MovImodtMov { get; set; }

    public string? MovImoTransacao { get; set; }

    public decimal? MovImoMetragem { get; set; }

    public string? MovImoOcupacao { get; set; }

    public string? MovImoFuncionario { get; set; }

    public virtual ICollection<GrupoImobensMovimento> GrupoImobensMovimentos { get; set; } = new List<GrupoImobensMovimento>();
}
