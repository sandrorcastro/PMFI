using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Genero
{
    public int GeneroId { get; set; }

    public string? NmGenero { get; set; }

    public int? GrupoBemId { get; set; }

    public virtual ICollection<Especie> Especies { get; set; } = new List<Especie>();

    public virtual GrupoBem? GrupoBem { get; set; }
}
