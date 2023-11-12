using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEstruturaParede
{
    public int EstrutId { get; set; }

    public string? EstrutNome { get; set; }

    public decimal? EstrutFator { get; set; }

    public int? EstrutPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; } = new List<TribPlantaValore>();
}
