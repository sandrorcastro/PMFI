using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAlvTipoResponsavel
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? DsSiglaSisObra { get; set; }

    public virtual ICollection<TribAlvDocumentoComplemento> TribAlvDocumentoComplementos { get; set; } = new List<TribAlvDocumentoComplemento>();
}
