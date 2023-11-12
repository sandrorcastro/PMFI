using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscOrdemServicoFiscai
{
    public int? FiscalId { get; set; }

    public int? FiscOsid { get; set; }

    public virtual TribFiscOrdemServico? FiscOs { get; set; }

    public virtual TribFiscFiscai? Fiscal { get; set; }
}
