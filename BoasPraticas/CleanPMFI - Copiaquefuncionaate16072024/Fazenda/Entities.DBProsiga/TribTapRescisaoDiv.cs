using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTapRescisaoDiv
{
    public long ResDivId { get; set; }

    public int? ResId { get; set; }

    /// <summary>
    /// Código de identificação da dívida.
    /// </summary>
    public long? ImoIddivida { get; set; }

    public long? ConIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? IddividaOrigem { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
}
