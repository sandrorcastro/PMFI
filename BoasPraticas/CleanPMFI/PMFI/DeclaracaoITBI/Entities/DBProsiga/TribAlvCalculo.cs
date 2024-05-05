using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAlvCalculo
{
    public int IdCalculo { get; set; }

    public int? IdDocumento { get; set; }

    public short? IdFormula { get; set; }

    public string? VlFormula { get; set; }

    public decimal? VlCalculo { get; set; }

    public decimal? VlTotalArea { get; set; }

    public string? DsMotivo { get; set; }

    public string? NrNota { get; set; }

    public int? IdTomador { get; set; }

    public decimal? VlNota { get; set; }

    public decimal? VlAliquota { get; set; }

    public int? TipoTribId { get; set; }

    public virtual TribAlvDocumento? IdDocumentoNavigation { get; set; }

    public virtual TribAlvFormula? IdFormulaNavigation { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }
}
