using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresasGrupoRisco
{
    public int IdGrupoRisco { get; set; }

    public string? CdGrupoRisco { get; set; }

    public int? NrAno { get; set; }

    public decimal? NrAreaMinima { get; set; }

    public decimal? NrAreaMaxima { get; set; }

    public decimal? VlCoeficiente { get; set; }

    public decimal? NrPercentual { get; set; }

    public decimal? VlTaxa { get; set; }
}
