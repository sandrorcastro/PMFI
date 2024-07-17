using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTipoDividum
{
    public int TipoDivId { get; set; }

    public string? TipoDivNome { get; set; }

    /// <summary>
    /// Informa se o tipo da divida pode ser feito parcelamento pelo REFIS
    /// </summary>
    public string TipoDivUsaCertidao { get; set; } = null!;

    public virtual ICollection<TribDividasImo> TribDividasImos { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIddestinoNavigations { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIdorigemNavigations { get; set; } = new List<TribProtestoLoteCdahistoricoSituacaoDividum>();

    public virtual ICollection<TribLeisDescTributo> TribLeisDescTributos { get; set; } = new List<TribLeisDescTributo>();
}
