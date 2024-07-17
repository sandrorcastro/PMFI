using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribHonorariosSemCdum
{
    public int HonorarioSemCdaid { get; set; }

    public int HonorarioDivId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribHonorariosDivida HonorarioDiv { get; set; } = null!;

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
}
