using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GrupoBem
{
    /// <summary>
    /// Bens Permanentes ou Material de Consumo
    /// </summary>
    public int GrupoBemId { get; set; }

    public string? GrupoBemNome { get; set; }

    public virtual ICollection<Genero> Generos { get; set; } = new List<Genero>();
}
