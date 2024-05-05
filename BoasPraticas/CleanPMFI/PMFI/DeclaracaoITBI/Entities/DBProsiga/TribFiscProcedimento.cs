using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscProcedimento
{
    public int ProcId { get; set; }

    public DateTime? ProcData { get; set; }

    public string? ProcRetorno { get; set; }

    public string? ProcDescricao { get; set; }

    public int? TipoProcId { get; set; }

    public int? TipoFiscId { get; set; }

    public int? FiscalId { get; set; }

    public int? CategEstId { get; set; }

    public int? VistId { get; set; }

    public virtual TribFiscCategoriaEstabelecimento? CategEst { get; set; }

    public virtual TribFiscFiscai? Fiscal { get; set; }

    public virtual TribFiscTipoFiscal? TipoFisc { get; set; }

    public virtual TribFiscTipoProcedimento? TipoProc { get; set; }
}
