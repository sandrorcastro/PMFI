using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParIntegracoesContabei
{
    public short IdTipoIntegracao { get; set; }

    public short NrSequencia { get; set; }

    public string? DsIntegracao { get; set; }

    public string DsFormulaContabilDebito { get; set; } = null!;

    public string DsFormulaContabilCredito { get; set; } = null!;

    public string? CdEvento { get; set; }

    public string? CdHistorico { get; set; }

    public string? DsFormulaSequencia { get; set; }

    public decimal? VlPercentual { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public virtual TbParTiposIntegracao IdTipoIntegracaoNavigation { get; set; } = null!;
}
