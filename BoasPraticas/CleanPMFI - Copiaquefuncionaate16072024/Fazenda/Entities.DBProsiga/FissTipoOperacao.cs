using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissTipoOperacao
{
    public int TipoOpId { get; set; }

    public string? TipoOpNome { get; set; }

    public string? TipoOpGravaMov { get; set; }

    public virtual ICollection<FissCruzamento> FissCruzamentos { get; set; } = new List<FissCruzamento>();

    public virtual ICollection<FissMovim> FissMovims { get; set; } = new List<FissMovim>();

    public virtual ICollection<FissTomadorPrestador> FissTomadorPrestadors { get; set; } = new List<FissTomadorPrestador>();
}
