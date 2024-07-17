using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTiposConstrucao
{
    public int TipoConId { get; set; }

    public string? TipoConNome { get; set; }

    public decimal? TipoConFator { get; set; }

    public int? TipoConPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; } = new List<TribPlantaValore>();
}
