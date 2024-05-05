using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class LocBaixa
{
    public long BxaId { get; set; }

    public string? BxaBancoId { get; set; }

    public string? BxaAgenciaId { get; set; }

    public DateTime? BxaDataBaixa { get; set; }

    public decimal? BxaValorPago { get; set; }

    public decimal? BxaVlraPagar { get; set; }

    public string? BxaOrigem { get; set; }

    public string? BxaNossoNumero { get; set; }

    public string? BxaTecUltAlt { get; set; }

    public DateTime? BxaDtUltAlt { get; set; }

    public virtual LocBoleto? BxaNossoNumeroNavigation { get; set; }
}
