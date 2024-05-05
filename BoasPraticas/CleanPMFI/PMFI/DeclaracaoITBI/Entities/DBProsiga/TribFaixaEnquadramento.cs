using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFaixaEnquadramento
{
    public short FxEnquadrFaixa { get; set; }

    public int TipoTribId { get; set; }

    public decimal? FxEnquadrDe { get; set; }

    public decimal? FxEnquadraAte { get; set; }

    public decimal? FxEnquadrDesconto { get; set; }

    /// <summary>
    /// Tributo que sera gerado na composição dando o desconto cfme enquadramento
    /// </summary>
    public int? TipoTribIddesconto { get; set; }

    /// <summary>
    /// Tipo de baixa utilizado para casos que possui 100% de beneficio na taxa.
    /// </summary>
    public int? TipoBxId { get; set; }

    public string? FxSigla { get; set; }
}
