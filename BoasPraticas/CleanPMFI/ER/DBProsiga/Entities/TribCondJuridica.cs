using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCondJuridica
{
    public int JuriId { get; set; }

    public string? JuriNome { get; set; }

    public decimal? JuriFator { get; set; }

    public int JuriPontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
