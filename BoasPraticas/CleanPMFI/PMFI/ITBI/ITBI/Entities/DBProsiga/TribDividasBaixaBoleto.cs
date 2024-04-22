using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribDividasBaixaBoleto
{
    public long BaiId { get; set; }

    public long BoleDivId { get; set; }

    public decimal? BoleValorPagoDivida { get; set; }

    public decimal? BoleValorPagoJuros { get; set; }

    public decimal? BoleValorPagoMulta { get; set; }

    public virtual TribDividasBaixa Bai { get; set; } = null!;

    public virtual TribBoletosDivida BoleDiv { get; set; } = null!;
}
