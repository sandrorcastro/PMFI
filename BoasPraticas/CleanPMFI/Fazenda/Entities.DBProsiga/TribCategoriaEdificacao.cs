using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCategoriaEdificacao
{
    public int CategId { get; set; }

    public string? CategNome { get; set; }

    public int? CategDe { get; set; }

    public int? CategAte { get; set; }

    public virtual ICollection<TribPlantaValore> TribPlantaValores { get; set; } = new List<TribPlantaValore>();

    public virtual ICollection<TribTipoPlantasValore> TribTipoPlantasValores { get; set; } = new List<TribTipoPlantasValore>();
}
