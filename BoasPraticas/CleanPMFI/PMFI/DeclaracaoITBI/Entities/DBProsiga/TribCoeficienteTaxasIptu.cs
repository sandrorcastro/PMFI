using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCoeficienteTaxasIptu
{
    public int TribCoeId { get; set; }

    public int? TipoTribId { get; set; }

    public decimal? Coeficiente { get; set; }

    public short? Idmoeda { get; set; }

    public string? Observacao { get; set; }

    public string? ParametroValor { get; set; }

    public decimal? ValorLimiteDe { get; set; }

    public decimal? ValorLimiteAte { get; set; }

    public byte QtdeParametros { get; set; }

    public virtual Moeda? IdmoedaNavigation { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }
}
