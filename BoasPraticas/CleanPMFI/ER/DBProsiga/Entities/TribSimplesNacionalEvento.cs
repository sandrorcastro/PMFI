using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSimplesNacionalEvento
{
    public short SneventoId { get; set; }

    public string SneventoNome { get; set; } = null!;

    public string? SneventoEnquadra { get; set; }

    public int? IdRegra { get; set; }

    public virtual ICollection<TribSimplesNacionalOcorrEvento> TribSimplesNacionalOcorrEventos { get; set; } = new List<TribSimplesNacionalOcorrEvento>();
}
