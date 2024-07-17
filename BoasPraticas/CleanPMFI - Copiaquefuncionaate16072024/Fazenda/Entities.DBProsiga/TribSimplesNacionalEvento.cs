using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSimplesNacionalEvento
{
    public short SneventoId { get; set; }

    public string SneventoNome { get; set; } = null!;

    public string? SneventoEnquadra { get; set; }

    public int? IdRegra { get; set; }

    public virtual ICollection<TribSimplesNacionalOcorrEvento> TribSimplesNacionalOcorrEventos { get; set; } = new List<TribSimplesNacionalOcorrEvento>();
}
