using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribComposicaoDivEmpresa
{
    public long DivEmpId { get; set; }

    public int TipoTribId { get; set; }

    public decimal? CompDivEmpValor { get; set; }

    public virtual TribDividasEmpresa DivEmp { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
